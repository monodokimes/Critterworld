using CritterBrains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;

namespace CatCritter
{
    public class Defender : CritterBrain
    {
        private const string CritterName = "Defender";

        #region Configuration
        private int _sprintSpeed = 10;
        private int _normalSpeed = 1;
        private int _sprintSeconds = 4;
        private int _waitSeconds = 5;
        private int _findTargetSeconds = 5;
        #endregion

        private List<IWorldObject> _food;
        private IWorldObject _targetFood;

        public Defender() : this(null)
        {
        }

        public Defender(Image[] images) : base(CritterName, Constants.Creator, images)
        {
            _food = new List<IWorldObject>();
        }

        public override void Birth()
        {
            this.SetRandomDirection();
            this.Sprint(_sprintSeconds, _sprintSpeed);

            this.DoRepeating(_findTargetSeconds, () => _targetFood == null, SetTargetDirection);
        }

        public override void Think()
        {
            var nearbyObjects = Critter.Scan();
            var food = nearbyObjects.Where(o => o.Type == "Food");
            var critters = nearbyObjects.Where(o => o.Type == "Critter");

            if (food.Any())
            {
                foreach (var foodObject in food)
                {
                    if (_food.Any(f => f.X == foodObject.X && f.Y == foodObject.Y))
                        continue;

                    _food.Add(foodObject);
                }
            }

            if (!critters.Any() && _targetFood == null)
            {
                // It's possible some food was consumed so refresh the list before
                // trying to set a target
                _food = _food
                    .Where(f => f != null)
                    .ToList();

                if (_food.Any())
                {
                    _targetFood = this.GetClosest(_food);
                }

                this.SetSpeed(_normalSpeed);
                SetTargetDirection();
            }
        }

        public override void NotifyBlockedByTerrain()
        {
            if (_targetFood != null)
            {
                // target food is on the other side of a wall :(
                // Guess we'll just forget about it :(
                _food.Remove(_targetFood);
                _targetFood = null;
            }

            this.SetRandomDirection();
        }

        public override void NotifyCloseToCritter(OtherCritter other)
        {
            if (new[] { Strength.MuchWeaker, Strength.Weaker }.Contains(other.Strength))
            {
                // They might come and attack us, so sit and wait.
                this.SetSpeed(0);
                this.DoAfterDelay(_waitSeconds, () => this.SetSpeed(_normalSpeed));
            }
            else
            {
                // 50% or less chance of us winning the fight, let's run away!
                var awayDirection = this.GetOppositeDirection(other.DirectionTo);
                this.Sprint(_sprintSpeed, _sprintSeconds);
            }
        }

        public override void NotifyBumpedCritter(OtherCritter other)
        {
            if (new[] { Strength.MuchWeaker, Strength.Weaker }.Contains(other.Strength))
            {
                other.Attack();
            }
        }

        private void SetTargetDirection()
        {
            if (_targetFood != null)
            {
                this.SetTarget(_targetFood.X, _targetFood.Y);
            }
            else
            {
                this.SetRandomDirection();
            }
        }
    }
}

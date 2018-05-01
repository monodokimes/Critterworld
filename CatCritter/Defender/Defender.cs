using CritterBrains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace CatCritter
{
    /// <summary>
    /// The Defender critter moves slowly and sits around waiting for fights. If
    /// another critter is seen nearby, Defender will sit still and wait for them
    /// to go away; if they don't, it fights.
    /// </summary>
    public class Defender : CritterBrain
    {
        private const string CritterName = "Defender";

        private IWorldObject _targetFood;
        public DefenderConfiguration Config { get; private set; }

        public Defender() : this(null)
        {
        }

        public Defender(Image[] images) : base(CritterName, Constants.Creator, images)
        {
            LoadConfiguration();
        }

        public override Form Form => new DefenderConfigurationForm(this);

        private void LoadConfiguration()
        {
            Config = new DefenderConfiguration();

            if (!this.ConfigAvailable())
            {
                Console.WriteLine("No configuration available; loading default values");
                return;
            }

            Config.SprintSpeed = this.GetConfigValueInt("sprintSpeed");
            Config.NormalSpeed = this.GetConfigValueInt("normalSpeed");
            Config.SprintSeconds = this.GetConfigValueInt("sprintSeconds");
            Config.WaitSeconds = this.GetConfigValueInt("waitSeconds");
            Config.FindTargetSeconds = this.GetConfigValueInt("findTargetSeconds");
        }

        public void SaveConfiguration()
        {
            this.SaveConfig(Config);
            LoadConfiguration();
        }
        
        public override void Birth()
        {
            this.SetRandomDirection();
            this.Sprint(Config.SprintSeconds, Config.SprintSpeed);

            this.DoRepeating(Config.FindTargetSeconds, SetNewTarget);
        }

        public override void Think()
        {
            // Constantly look for new food and start moving towards it if found
            var newFood = this.GetClosest(Constants.Food);
            if (newFood != null)
            {
                if (_targetFood == null || this.DistanceTo(newFood) < this.DistanceTo(_targetFood))
                {
                    _targetFood = newFood;
                    SetNewTarget();
                }
            }
            
            if (!this.IsMoving())
            {
                SetNewTarget();
            }
        }

        public override void NotifyBlockedByTerrain()
        {
            if (_targetFood != null)
            {
                // target food is on the other side of a wall :(
                // Guess we'll just forget about it :(
                _targetFood = null;
            }

            SetNewTarget();
        }

        public override void NotifyCloseToCritter(OtherCritter other)
        {
            if (this.IsStrongerThan(other))
            {
                // They might come and attack us, so sit and wait.
                this.SetSpeed(0);
                this.DoAfterDelay(Config.WaitSeconds, () => this.SetSpeed(Config.NormalSpeed));
            }
            else
            {
                // 50% or less chance of us winning the fight, let's run away!
                var awayDirection = this.GetOppositeDirection(other.DirectionTo);
                this.Sprint(Config.SprintSpeed, Config.SprintSeconds);
            }
        }

        public override void NotifyBumpedCritter(OtherCritter other)
        {
            if (this.IsStrongerThan(other))
            {
                other.Attack();
            }
        }
        
        private void SetNewTarget()
        {
            var critters = this.GetNearbyObjects(Constants.Critter);

            // Don't move if anyone's nearby!
            if (critters.Any())
                return;

            _targetFood = this.GetClosest(Constants.Food);

            if (_targetFood != null)
            {
                this.SetTarget(_targetFood.X, _targetFood.Y);
            }
            else
            {
                this.SetRandomDirection();
            }

            this.SetSpeed(Config.NormalSpeed);
        }
    }
}

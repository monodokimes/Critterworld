using CritterBrains;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace CatCritter
{
    /// <summary>
    /// The goodest of bois. Will wander randomly and then
    /// spring on finding food or the goal.
    /// </summary>
    public class GoodBoi : CritterBrain
    {
        private const string CritterName = "GoodBoi";

        public GoodBoiConfiguration Config { get; private set; }
        
        public GoodBoi() : this(null)
        {
        }

        public GoodBoi(Image[] images) : base(CritterName, Constants.Creator, images)
        {
            LoadConfiguration();
        }

        public override Form Form => new GoodBoiConfigurationForm(this);

        private void LoadConfiguration()
        {
            Config = new GoodBoiConfiguration();

            if (!this.ConfigAvailable())
            {
                Console.WriteLine("No configuration available; loading default values");
                return;
            }

            Config.WanderSpeed = this.GetConfigValueInt("wanderSpeed");
            Config.RunSpeed = this.GetConfigValueInt("runSpeed");
            Config.ChangeDirectionDelay = this.GetConfigValueInt("changeDirectionDelay");
        }

        public void SaveConfiguration()
        {
            this.SaveConfig(Config);
            LoadConfiguration();
        }

        public override void Birth()
        {
            // Start wandering
            Movement();
            this.DoRepeating(Config.ChangeDirectionDelay, Movement);
        }

        public override void Think()
        {
            if (Critter.Speed == 0)
            {
                this.SetSpeed(GetTarget().HasValue ? Config.RunSpeed : Config.WanderSpeed);
            }

            // Avoid poop, sort of?
            var poop = this.GetNearbyObjects(Constants.Poop);
            if (poop.Any())
            {
                var closestPoop = this.GetClosest(poop);
                // Poop is *roughly* in front of critter
                if (Math.Abs(Critter.Direction - Critter.GetDirectionTo(closestPoop)) < 10)
                {
                    Movement();
                }
            }
        }

        private Point? GetTarget()
        {
            // Prioritise food over actually reaching the goal! :D
            var food = this.GetNearbyObjects(Constants.Food);
            if (food.Any())
            {
                var closestFood = this.GetClosest(food);
                return new Point
                {
                    X = closestFood.X,
                    Y = closestFood.Y
                };
            }

            var destination = Critter.GetDestination();
            if (destination.X == 0 && destination.Y == 0)
                return null;

            if (!Critter.IsTerrainBlockingRouteTo(destination.X, destination.Y))
            {
                return new Point
                {
                    X = destination.X,
                    Y = destination.Y
                };
            }

            return null;
        }

        private void Movement()
        {
            var target = GetTarget();
            if (target.HasValue)
            {
                this.SetTarget(target.Value.X, target.Value.Y);
                this.SetSpeed(Config.RunSpeed);

                return;
            }

            this.SetRandomDirection();
            this.SetSpeed(Config.WanderSpeed);
        }

        public override void NotifyEaten() => Movement();

        public override void NotifyBlockedByTerrain() => Movement();
    }
}

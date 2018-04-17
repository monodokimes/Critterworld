using CritterBrains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatCritter
{
    public static class Extensions
    {
        private static Random _random = new Random();

        public static void SetTarget(this CritterBrain critterBrain, IWorldObject target)
        {
            critterBrain.SetTarget(target.X, target.Y);
        }

        public static void SetTarget(this CritterBrain critterBrain, int x, int y)
        {
            var direction = critterBrain.Critter.GetDirectionTo(x, y);
            critterBrain.SetDirection(direction);
        }

        public static void SetDirection(this CritterBrain critterBrain, int direction)
        {
            critterBrain.Critter.Direction = direction;
        }

        public static void SetRandomDirection(this CritterBrain critterBrain)
        {
            critterBrain.SetDirection(_random.Next(0, 359));
        }

        /// <summary>
        /// Sets the critter's speed, values are clamped between 0 and 10
        /// </summary>
        /// <param name="critterBrain"></param>
        /// <param name="speed"></param>
        public static void SetSpeed(this CritterBrain critterBrain, int speed)
        {
            var critter = critterBrain.Critter;
            var maxSpeed = 10;

            if (speed <= 0)
            { 
                critter.Stop();
                return;
            }

            if (speed > maxSpeed)
            {
                speed = maxSpeed;
            }
            
            critter.Speed = speed;
        }
    }
}

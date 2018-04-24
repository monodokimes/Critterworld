using CritterBrains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

        public static int DistanceTo(this CritterBrain critterBrain, IWorldObject obj)
        {
            var critter = critterBrain.Critter;

            var a = obj.X - critter.X;
            var b = obj.Y - critter.Y;

            var c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

            return (int)c;
        }

        public static int GetOppositeDirection(this CritterBrain critterBrain, int direction)
        {
            return direction >= 180 ? direction - 180 : direction + 180;
        }

        /// <summary>
        /// Get a new direction from the given direction rotated by turnAngle.
        /// </summary>
        /// <param name="critterBrain"></param>
        /// <param name="direction">the original direction to be rotated</param>
        /// <param name="turnAngle">between -180 and 180 degrees</param>
        /// <returns></returns>
        public static int GetNewDirection(this CritterBrain critterBrain, int direction, int turnAngle)
        {
            if (turnAngle > 180 || turnAngle < -180)
                throw new ArgumentException();

            direction += turnAngle;

            if (direction < 0)
            {
                direction += 360;
            }
            else if (direction > 360)
            {
                direction -= 360;
            }

            return direction;
        }

        public static void Turn(this CritterBrain critterBrain, int turnAngle) =>
            critterBrain.Critter.Direction = GetNewDirection(
                critterBrain,
                critterBrain.Critter.Direction,
                turnAngle);

        public static void DoAfterDelay(this CritterBrain critterBrain, int waitSeconds, Action actionAfter)
        {
            new Thread(
                new ThreadStart(() =>
                {
                    Thread.Sleep(waitSeconds * 1000);
                    actionAfter.Invoke();
                }))
                .Start();
        }

        public static void DoRepeating(this CritterBrain critterBrain, int repeatSeconds, Action action)
        {
            new Thread(
                new ThreadStart(() =>
                {
                    // Forever! :D
                    while (true)
                    {
                        action.Invoke();
                        Thread.Sleep(repeatSeconds * 1000);
                    }
                }));
        }

        public static void Sprint(this CritterBrain critterBrain, int sprintSpeed, int sprintSeconds)
        {
            // Already sprinting, wouldn't want to start messing up threads :/
            if (critterBrain.IsSprinting(sprintSpeed))
                return;

            var initialSpeed = critterBrain.Critter.Speed;

            critterBrain.SetSpeed(sprintSpeed);
            critterBrain.DoAfterDelay(sprintSeconds, () => critterBrain.SetSpeed(initialSpeed));
        }

        public static bool IsMoving(this CritterBrain critterBrain) => critterBrain.Critter.Speed != 0;

        public static bool IsSprinting(this CritterBrain critterBrain, int sprintSpeed) => critterBrain.Critter.Speed == sprintSpeed;

        public static IWorldObject GetClosest(this CritterBrain critterBrain, IEnumerable<IWorldObject> objects) =>
            objects.OrderBy(critterBrain.DistanceTo)
                .FirstOrDefault();

        public static IWorldObject GetClosest(this CritterBrain critterBrain, string type) =>
            GetClosest(critterBrain, GetNearbyObjects(critterBrain, type));

        public static IEnumerable<IWorldObject> GetNearbyObjects(this CritterBrain critterBrain, string type) =>
            critterBrain.Critter
                .Scan()
                .Where(o => o.Type == type);

        public static bool IsStrongerThan(this CritterBrain critterBrain, OtherCritter other) =>
            new[] {
                Strength.MuchWeaker,
                Strength.Weaker
            }.Contains(other.Strength);
    }
}

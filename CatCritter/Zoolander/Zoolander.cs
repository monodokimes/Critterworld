using CritterBrains;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _100458008
{
    /// <summary>
    /// This one can only turn left :)
    /// </summary>
    public class Zoolander : CritterBrain
    {
        private const string CritterName = "Zoolander";

        public ZoolanderConfiguration Config { get; private set; }

        public Zoolander() : this(null)
        {
        }

        public Zoolander(Image[] images) : base(CritterName, Constants.Creator, images)
        {
            LoadConfiguration();
        }

        public override Form Form => new ZoolanderConfigurationForm(this);

        private void LoadConfiguration()
        {
            Config = new ZoolanderConfiguration();

            if (!this.ConfigAvailable())
            {
                Console.WriteLine("No configuration available; loading default values.");
                return;
            }

            Config.TurnAngle = this.GetConfigValueInt("turnAngle");
            Config.AngularFudge = this.GetConfigValueInt("angularFudge");
            Config.StartDirection = this.GetConfigValueInt("startDirection");
        }

        public void SaveConfiguration()
        {
            this.SaveConfig(Config);
            LoadConfiguration();
        }

        public override void Birth()
        {
            this.SetDirection(Config.StartDirection);
        }

        public override void Think()
        {
            this.SetSpeed(10);
            if (IsDesirableLeftOfMe() || IsUndesirableInFrontOfMe())
            {
                this.Turn(Config.TurnAngle);
            }
        }

        public override void NotifyBlockedByTerrain()
        {
            this.Turn(Config.TurnAngle);
        }

        private bool IsDesirableLeftOfMe() =>
            ObjectTypesInDirection(
                new[] {
                    Constants.Food
                },
                this.GetNewDirection(Critter.Direction, Config.TurnAngle));

        private bool IsUndesirableInFrontOfMe() =>
            ObjectTypesInDirection(
                new[] {
                    Constants.Poop,
                    Constants.Critter
                },
                Critter.Direction);

        private bool ObjectTypesInDirection(IEnumerable<string> types, int dir) =>
            Critter
                .Scan()
                .Where(o => types.Contains(o.Type))
                .Any(o => Math.Abs(dir - Critter.GetDirectionTo(o.X, o.Y)) < Config.AngularFudge);
    }
}

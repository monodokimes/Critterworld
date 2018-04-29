using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatCritter
{ 
    public class ZoolanderConfiguration
    {
        /// <summary>
        /// Angle to turn by
        /// </summary>
        public int TurnAngle { get; set; } = -90;
        /// <summary>
        /// The off-axis angle something can be to still be considered
        /// 'left of' or 'in front of' the critter
        /// </summary>
        public int AngularFudge { get; set; } = 10;
        /// <summary>
        /// Intial movement direction from spawn
        /// </summary>
        public int StartDirection { get; set; } = 180;

        public IEnumerable<string> Lines => new[] {
            TurnAngle.AsConfigLine("turnAngle"),
            AngularFudge.AsConfigLine("angularFudge"),
            StartDirection.AsConfigLine("startDirection")
        };
    }
}

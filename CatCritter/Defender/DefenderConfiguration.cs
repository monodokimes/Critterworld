using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatCritter
{
    public class DefenderConfiguration : IConfiguration
    {
        public int SprintSpeed { get; set; } = 10;
        public int NormalSpeed { get; set; } = 1;
        public int SprintSeconds { get; set; } = 4;
        public int WaitSeconds { get; set; } = 5;
        public int FindTargetSeconds { get; set; } = 5;

        public IEnumerable<string> Lines => new[]
        {
            SprintSpeed.AsConfigLine("sprintSpeed"),
            NormalSpeed.AsConfigLine("normalSpeed"),
            SprintSeconds.AsConfigLine("sprintSeconds"),
            WaitSeconds.AsConfigLine("waitSeconds"),
            FindTargetSeconds.AsConfigLine("findTargetSeconds")
        };
    }
}

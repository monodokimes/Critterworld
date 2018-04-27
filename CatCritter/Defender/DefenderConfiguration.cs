using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatCritter
{
    public class DefenderConfiguration
    {
        public int SprintSpeed { get; set; } = 10;
        public int NormalSpeed { get; set; } = 1;
        public int SprintSeconds { get; set; } = 4;
        public int WaitSeconds { get; set; } = 5;
        public int FindTargetSeconds { get; set; } = 5;

        public string[] Lines => new[]
        {
            ConfigLine("sprintSpeed", SprintSpeed),
            ConfigLine("normalSpeed", NormalSpeed),
            ConfigLine("sprintSeconds", SprintSeconds),
            ConfigLine("waitSeconds", WaitSeconds),
            ConfigLine("findTargetSeconds", FindTargetSeconds)
        };

        private string ConfigLine(string key, object value) =>
            string.Format("{0}={1}", key, value);
    }
}

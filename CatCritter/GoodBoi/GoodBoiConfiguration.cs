using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100458008
{
    public class GoodBoiConfiguration : IConfiguration
    {
        public int WanderSpeed { get; set; } = 5;
        public int RunSpeed { get; set; } = 10;
        public int ChangeDirectionDelay { get; set; } = 4;
        public IEnumerable<string> Lines => new[]
        {
            WanderSpeed.AsConfigLine("wanderSpeed"),
            RunSpeed.AsConfigLine("runSpeed"),
            ChangeDirectionDelay.AsConfigLine("changeDirectionDelay")
        };
    }
}

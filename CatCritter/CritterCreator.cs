using CritterBrains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatCritter
{
    public class CritterCreator : ICritterFactory
    {
        public IEnumerable<CritterBrain> GetCritterBrains()
        {
            var creator = "Cat Flynn 100458008";

            var critters = new[] {
                new CritterBrainAlpha("alpha", creator)
            };

            return critters;
        }
    }
}

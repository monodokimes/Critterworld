using CritterBrains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100458008
{
    public class CritterCreator : ICritterFactory
    {
        public IEnumerable<CritterBrain> GetCritterBrains()
        {
            return new CritterBrain[] {
                new Defender(),
                new Zoolander(),
                new GoodBoi()
            };
        }
    }
}

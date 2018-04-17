using CritterBrains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CatCritter
{
    public class CritterBrainAlpha : CritterBrain
    {
        public CritterBrainAlpha(string name, string creator) 
            : base (name, creator)
        {
        }

        public CritterBrainAlpha(string name, string creator, Image[] images) 
            : base (name, creator, images)
        {

        }
    }
}

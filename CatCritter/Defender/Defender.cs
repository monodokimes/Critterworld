using CritterBrains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;

namespace CatCritter
{
    public class Defender : CritterBrain
    {
        private const string CritterName = "Defender";

        private int _initialSpeed = 10;
        private int _normalSpeed = 1;
        private int _slowDownAfter = 1000; // milliseconds

        private List<IOtherCritter> _otherCritters = new List<IOtherCritter>();

        public Defender() 
            : base (CritterName, Constants.Creator)
        { }

        public Defender(Image[] images) 
            : base (CritterName, Constants.Creator, images)
        { }

        public override void Birth()
        {	
            this.SetSpeed(_initialSpeed);
            this.SetRandomDirection();
			
            new Thread(
				new ThreadStart(() => 
				{
					Thread.Sleep(_slowDownAfter);
					this.SetSpeed(_normalSpeed);
				}))
				.Start();
        }

        public override void Think()
        {
            
        }

        public override void NotifyBlockedByTerrain()
        {
            this.SetRandomDirection();
        }

        public override void NotifyCloseToCritter(OtherCritter otherCritter)
        {
            // Stop and wait for them to either go away or come to us
			// This maximises the energy we have going into a potential fight
        }
		
        public override void NotifyBumpedCritter(OtherCritter other)
        {
			// Check oppenent strength
			// If we're stronger, fight
			// Otherwise run
        }
    }
}

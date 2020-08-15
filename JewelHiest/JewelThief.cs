using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace JewelHiest
{
    class JewelThief:LockSmith
    {
        private Jewels stolenJewels = null;
         override public void ReturnContents(Jewels safeContents, Owner owner)
        {
            stolenJewels = safeContents;
            Console.WriteLine($"I'm strealing the contents! {stolenJewels.Sparkle()}");
        }
    }
}

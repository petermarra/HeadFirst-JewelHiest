using System;
using System.Collections.Generic;
using System.Text;

namespace JewelHiest
{
    class Owner
    {
        private Jewels returnedContents;
        public void ReceiveContents(Jewels safeContents)
        {
            returnedContents = safeContents;
            Console.WriteLine($"Thank you for returning my Jewels! {safeContents.Sparkle()}");
        }
    }
}

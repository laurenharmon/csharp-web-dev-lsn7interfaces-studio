using System;
using System.Collections.Generic;

namespace SpinningDiscs
{
    public class CD : DiscMaster, IOpticalDisc
    {
        public CD(string name, List<string> contents, string discType) : base(name, contents, discType) {
        }

        
        public void PlayMusic()
        {
            Console.WriteLine("*music symbols*");
        }

        public void SpinDisc()
        {
            Console.WriteLine("Disk is spinning at 500 RPM");
        }

        public void RewindDisc()
        {
            Console.WriteLine("Disk is spinning in reverse at 500 RPM");
        }

        public void WriteDisc()
        {
            Console.WriteLine("Thank god for LimeWire.");

        }
        // TODO: Implement your custom interface.

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately. 
    }
}

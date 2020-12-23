using System;
using System.Collections.Generic;

namespace SpinningDiscs
 
{
    public class DVD : DiscMaster, IOpticalDisc
    {

        public DVD(string name, List<string> contents, string discType) : base(name, contents, discType)
        {
        }
        public void PlayMovie()
        {
            Console.WriteLine("*movie playing in background*");
        }

        public void SpinDisc()
        {
            Console.WriteLine("Disk is spinning at 570 - 1600 RPM");
        }

        public void RewindDisc()
        {
            Console.WriteLine("Disk is spinning in reverse at 570 - 1600 RPM");
        }

        public void WriteDisc()
        {
            Console.WriteLine("This movie is for the pirated movie man (it's Shrek).");

        }

    }
}

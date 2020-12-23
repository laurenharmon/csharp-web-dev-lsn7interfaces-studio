using System;
using System.Collections.Generic;

namespace SpinningDiscs
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string>

                        cdList = new List<string>
                        {
                            "Scenes", 
                            "Bloopers", 
                            "Trailers for movies you'll never watch"
                        };

            CD AllanisMorisette = new CD("Bitter Pill", cdList, "CD-RW");

            //LOTR.PlayMovie();

            AllanisMorisette.SpinDisc();
            
            // TODO: Call each CD and DVD method to verify that they work as expected.
        }
    }
}

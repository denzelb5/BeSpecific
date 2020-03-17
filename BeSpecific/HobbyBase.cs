using System;
using System.Collections.Generic;
using System.Text;

namespace BeSpecific
{
    abstract class HobbyBase
    {
        public virtual bool TakesPractice { get; set; }
        public virtual bool RequiresCoordination { get; set; }
        public virtual bool NeedsPatience { get; set; }
        public virtual bool isCreative { get; set; }

        public virtual void Practice()
        {
            Console.WriteLine("Time to get to work!  Practice makes perfect!");
        }

        public virtual void BePatient()
        {
            Console.WriteLine("Don't give up! You may not get it the first time or even the first 5 times.  Just keep trying!");
        }
    }
}

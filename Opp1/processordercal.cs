using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opp1
{
    public class processordercal
    {
        public processordercal()
        {
            Console.WriteLine("I am in constructor");
        }       
        public virtual void checkdata()
        {
            Console.WriteLine("I am checking in Parent Class");
        }
    }

}

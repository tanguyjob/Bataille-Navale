using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleNavale
{
    internal class Ship
    {
        //public Ship(String Klass, int Size) 
        //  {
        //      this.Klass = Klass;
        //      this.Size = Size;
        //  }
       

        public virtual int Size { get; set; }

        public String Begin { get; set; }
        public String End { get; set; }



    }
}

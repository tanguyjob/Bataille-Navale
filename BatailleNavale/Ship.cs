using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleNavale
{
    public class Ship
    {
        //public Ship(String Klass, int Size) 
        //  {
        //      this.Klass = Klass;
        //      this.Size = Size;
        //  }
       public Ship(int Size, String Name) 
        {
            this.Size = Size;
            this.Name = Name;
        }

        public virtual int Size { get; }
        public virtual String Name { get; }

        internal String Begin { get; set; }
        internal String End { get; set; }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP3
{
    public abstract class Prototype
    {
        public virtual Prototype Clone()
        {
            return (Prototype)MemberwiseClone();
        }
    }
}

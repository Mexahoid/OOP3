using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public abstract class Prototype
    {
        public virtual Prototype Clone()
        {
            return (Prototype)MemberwiseClone();
        }
    }
}

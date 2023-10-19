using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci
{
    public class Menu : Urun
    {
        public override string ToString()
        {
            return $"{this.Ad} Menu";
        }
    }
}

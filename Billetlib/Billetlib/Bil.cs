using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetlib
{
    public class Bil
    {
        public string Nummerplade
        {
            get
            {
                return Nummerplade;
            }
            
        }

        public DateTime Dato
        {
            get
            {
                return Dato;
            }
        }
            public int pris()
        {
            return 240;
        }
        public string køretøj()
        {
            return "Bil";
        }
    }
}

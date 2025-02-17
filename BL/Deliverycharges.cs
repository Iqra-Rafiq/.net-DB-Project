using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectfinal.BL
{
    class Deliverycharges
    {
        private int charges;
        private string province;

        public int Charges { get => charges; set => charges = value; }
        public string City { get => province; set => province = value; }
        public Deliverycharges(string province,int charges)
        {
            this.province = province;
            this.charges = charges;
        }
        public Deliverycharges()
        {
            
        }
    }
}

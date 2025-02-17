using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectfinal.BL
{
    public class Rider
    {
        private string rider_Name;
        private string rider_Available;

        public string Rider_Name { get => rider_Name; set => rider_Name = value; }
        public string Rider_Available { get => rider_Available; set => rider_Available = value; }


        public Rider(string name , string available)
        {
            this.rider_Name = name;
            this.Rider_Available = available;
        }
    }
}

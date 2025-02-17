using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projectfinal.DL;
using Projectfinal.BL;
using System.IO;

namespace Projectfinal.DL
{
    class DeliveryChargesDL
    {
        private static List<Deliverycharges> chargeslist = new List<Deliverycharges>();
        internal static List<Deliverycharges> Chargeslist { get => chargeslist; set => chargeslist = value; }
        public   static void addtolist(Deliverycharges d)
        {
            chargeslist.Add(d);
        }
        public static void storeCharges(string path)
        {

            StreamWriter f1 = new StreamWriter(path, false);
            foreach (var u in chargeslist)
            {
                f1.WriteLine(u.City + ","+ u.Charges);
            }
            f1.Flush();
            f1.Close();
        }
        public static bool loadCharges(string path)
        {
            string record;
            StreamReader f1 = new StreamReader(path);
            if (File.Exists(path))
            {
                while ((record = f1.ReadLine()) != null)
                {
                    string[] splittedrecord = record.Split(',');
                    string name = splittedrecord[0];
                    string email = splittedrecord[1];
                    Deliverycharges d = new Deliverycharges(name, int.Parse(email));
                    chargeslist.Add(d);
                }
                f1.Close();
                return true;
            }
            return false;
        }
    }
}

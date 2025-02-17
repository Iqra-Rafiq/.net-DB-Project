using Projectfinal.BL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectfinal.DL
{
    internal class RiderDL
    {
        private static List<Rider> Riders = new List<Rider>();

        public static List<Rider> Riders1 { get => Riders; set => Riders = value; }

        public static void addtoList(Rider R)
        {
            Riders1.Add(R);
        }
        public static void storeRiders(string path)
        {

            StreamWriter f1 = new StreamWriter(path, false);
            for (int i = 0; i < Riders1.Count; i++)
            {
                {
                    f1.WriteLine(Riders1[i].Rider_Name + "," + Riders1[i].Rider_Available);
                }
            }
            f1.Flush();
            f1.Close();
        }

        public static bool loadRiders(string path)
        {

            StreamReader f1 = new StreamReader(path);
            string line;
            if (File.Exists(path))
            {
                while ((line = f1.ReadLine()) != null)
                {

                    string name = getField(line, 1);
                    string available = getField(line, 2);
                    Rider p = new Rider(name, available) ;
                    Riders1.Add(p);
                }
                f1.Close();
                return true;
            }

            return false;

        }
        public static string getField(string record, int field)
        {
            int commacount = 1;
            string item = "";
            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == ',')
                {
                    commacount++;
                }
                else if (commacount == field)
                {
                    item = item + record[x];
                }
            }
            return item;
        }
       
    }
}

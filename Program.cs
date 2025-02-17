using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projectfinal.DL;
using Projectfinal.BL;
using System.IO;

namespace Projectfinal
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*Users u=( ("Ali", "123", "Admin");*/
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SellerDL.loadSoldProducts("soldproducts.txt");
            SellerDL.loadSellers("sellers.txt");
            CustomerDL.loadCustomers("customers.txt");
            if (File.Exists("products.txt"))
            {
                ProductsDL.loadProducts("products.txt");
            }
            if (File.Exists("custproducts.txt"))
            {
                ProductsDL.custloadProducts("custproducts.txt");
            }
            if (File.Exists("rider.txt"))
            {
                RiderDL.loadRiders("rider.txt");
            }
            Application.Run(new SignInform());
            
        }
    }
}
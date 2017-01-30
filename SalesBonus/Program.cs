///
/// App name: Sales Bonus
/// Author's name: Navleen Kaur Gill
/// App Creation Date: January 29, 2016
/// App Description: This app calculates the sales bonus per month for each employee depending upon 
/// the monthly sales of the company.
/// 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesBonus
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MailOrder());
        }
    }
}

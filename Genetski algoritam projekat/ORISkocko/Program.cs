using ORISkocko.Controllers;
using ORISkocko.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ORISkocko
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
            Form1 view = new Form1();
            IUtility utility = new Utility();
            IUtilityController utilityController = new UtilityController(view, utility);
            foreach (var sp in view.Controls.OfType<TablePanel>())
                sp.setController(utilityController);
            //foreach (var pp in view.Controls.OfType<PoljaPanel>())
            //    pp.setController(utilityController);
            view.initializeNormalRegime();
            Application.Run(view);
        }
    }
}

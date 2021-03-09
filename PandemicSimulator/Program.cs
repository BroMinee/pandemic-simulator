using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


using System.Windows.Forms;


using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;

namespace PandemicSimulator
{
    static class Program
    {
        public static SeriesCollection SeriesCollection { get; private set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        

    }
}

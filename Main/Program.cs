using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autofac.Core.Activators.ProvidedInstance;
using Autofac;
using View;
using Presentation;

namespace Main
{
    class Program
    {
        [STAThread]

        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartConfigView());
        }
    }
}


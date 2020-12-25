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

            var builder = new ContainerBuilder();
            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                var presenter = scope.Resolve<StartConfigPresenter>();
                var view = scope.Resolve<IStartConfigView>();
            }
        }
    }
}


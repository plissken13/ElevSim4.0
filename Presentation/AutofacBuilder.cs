using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using Presentation;
using View;

namespace Presentation
{
    class AutofacBuilder
    {
        public static IContainer Build()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<StartConfigPresenter>().As<StartConfigPresenter>().SingleInstance();
            builder.RegisterType<StartConfigView>().As<IStartConfigView>().SingleInstance();

            return builder.Build();
        }
    }
}

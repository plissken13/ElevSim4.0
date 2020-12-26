using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using Presentation;
using Presentation.IModel;
using View;

namespace Main
{
    class AutofacBuilder
    {
        public static IContainer Build()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<StartConfigPresenter>().As<IPresenter>().SingleInstance();
            builder.RegisterType<StartConfigView>().As<IStartConfigView>().SingleInstance();
            builder.RegisterType<NonameService>().As<IBeginWithConfiguration>().SingleInstance();

            return builder.Build();
        }
    }
}

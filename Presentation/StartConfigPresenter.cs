using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presentation.IModel;
using Presentation.Entities;
using Autofac;
using View;

namespace Presentation
{
    public class StartConfigPresenter
    {
        private IStartConfigView _view;

        private IBeginWithConfiguration _service;

        public StartConfigPresenter(IStartConfigView view, IBeginWithConfiguration service)
        {
            _view = view;
            _view.AddStartConfig += AddStartConfig;

            _service = service;
        }

        private void AddStartConfig()
        {
            if (_view.FloorsNumber < 21 && _view.LiftsNumber < 6)
            {
                BeginningConfiguration beginningConfiguration = new BeginningConfiguration(_view.FloorsNumber, _view.LiftsNumber);
                _service.Begin(beginningConfiguration);
                Console.WriteLine("+++");
            }
            else
            {
                _view.ShowError("Invalid value");
            }
        }
    }
}

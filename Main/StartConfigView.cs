using System;
using System.Windows.Forms;
using View;
using Presentation;
using Autofac;
using Presentation.IModel;

namespace Main
{
    public partial class StartConfigView : Form, IStartConfigView
    {
        public int FloorsNumber => int.Parse(txt_floorNum.Text);
        public int LiftsNumber => int.Parse(txt_liftNum.Text);

        public event Action AddStartConfig;

        public StartConfigView()
        {
            InitializeComponent();
            var container = AutofacBuilder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                var presenter = scope.Resolve<IPresenter>();
                var view = scope.Resolve<IStartConfigView>();
            }
        }

        private void btn_addBuilding_Click(object sender, EventArgs e)
        {
            AddStartConfig?.Invoke();
        }

        public void ShowError(string message)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Windows.Forms;
using View;
using Presentation;
using Presentation.IModel;

namespace Main
{
    public partial class StartConfigView : Form
    {
        public int FloorsNumber => int.Parse(txt_floorNum.Text);
        public int LiftsNumber => int.Parse(txt_liftNum.Text);
        // public event Action AddStartConfig;

        public StartConfigView()
        {
            InitializeComponent();
        }

        private void btn_addBuilding_Click(object sender, EventArgs e)
        {
            MainFrame mainFrame = new MainFrame(FloorsNumber, LiftsNumber);
            mainFrame.Show();
            //AddStartConfig?.Invoke();
        }

        public void ShowError(string message)
        {
            throw new NotImplementedException();
        }
    }
}

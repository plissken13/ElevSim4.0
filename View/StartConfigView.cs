using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class StartConfigView : Form, IStartConfigView
    {
        public int FloorsNumber => int.Parse(txt_floorNum.Text);
        public int LiftsNumber => int.Parse(txt_liftNum.Text);

        public event Action AddStartConfig;

        public StartConfigView()
        {
            InitializeComponent();
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

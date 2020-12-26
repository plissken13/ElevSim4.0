using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace View
{
    public partial class EndWorkView : Form
    {
        public EndWorkView()
        {
            InitializeComponent();
        }

        private void btn_exportFile_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

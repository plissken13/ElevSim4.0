using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace View
{
    public partial class ChangeRules : Form
    {
        public ChangeRules()
        {
            InitializeComponent();
        }

        List<string> names = new List<string>
        {
            "Vlad",
            "Ilya",
            "Kyle",
            "Lloyd",
            "Oleg",
            "Mario",
            "Samuel",
            "Yury",
            "Max",
            "Basil"
        };
        private void btn_random_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int num = rand.Next(1, names.Count);
            txt_workerName.Text = names[num];
            txt_floor1.Text = rand.Next(1, 10).ToString();
            txt_floor2.Text = rand.Next(1, 10).ToString();
        }

        private void btn_applyRules_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace View
{
    public partial class AddWorkerView : Form
    {
        public AddWorkerView()
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

        private void button2_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int num = rand.Next(1, names.Count);
            txt_floor2.Text = names[num];
            txt_name.Text = rand.Next(1, 10).ToString();
            txt_floor1.Text = rand.Next(1, 10).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

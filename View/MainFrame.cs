using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace View
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        private void btn_alarm_Click(object sender, EventArgs e)
        {
            AlarmView alarmView = new AlarmView();
            alarmView.Show();
        }

        private void btn_end_Click(object sender, EventArgs e)
        {
            EndWorkView endWorkView = new EndWorkView();
            endWorkView.Show();
            this.Close();
        }


        private void btn_changeRules_Click(object sender, EventArgs e)
        {
            ChangeRules changeRules = new ChangeRules();
            changeRules.Show();
        }

        private void btn_addWorker_Click(object sender, EventArgs e)
        {
            AddWorkerView addWorkerView = new AddWorkerView();
            addWorkerView.Show();
        }
    }
}

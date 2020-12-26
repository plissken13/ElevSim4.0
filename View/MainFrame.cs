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
        public int FloorsNumber;
        public int LiftsNumber;
        public MainFrame(int floorsNum, int liftsNum)
        {
            InitializeComponent();
            FloorsNumber = floorsNum;
            LiftsNumber = liftsNum;
        }

        public void DrawBuilding(Graphics g)
        {
            for(int i = 0; i < FloorsNumber + 1; i++)
            {
                g.DrawLine(Pens.Black, new Point(100, 300-i*25), new Point(100 + 16 * 25, 300 - i * 25));
            }

            for(int j = 0; j < LiftsNumber; j++)
            {
                g.DrawRectangle(Pens.Red, 100 + j*50, 50, 20, 50);
            }
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

        private void MainFrame_Paint(object sender, PaintEventArgs e)
        {
            DrawBuilding(e.Graphics);
        }
    }
}

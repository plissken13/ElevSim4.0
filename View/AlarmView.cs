﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace View
{
    public partial class AlarmView : Form
    {
        public AlarmView()
        {
            InitializeComponent();
        }

        private void btn_addAlarm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

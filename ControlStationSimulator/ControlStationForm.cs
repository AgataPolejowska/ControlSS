﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlStationSimulator
{
    public partial class ControlStationForm : Form
    {
        private int timeCounter = 0;

        public ControlStationForm()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void warningsTimer_Tick(object sender, EventArgs e)
        {
            timeCounter++;

            if (timeCounter % 17 == 0 && !Program.alertOpened)
            {
                Program.alertOpened = true;
                AlertnessVerificationForm vaForm = new AlertnessVerificationForm();
                vaForm.Show();
                timeCounter = 0;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActivitiesCaller
{
    public partial class Form1 : Form
    {
        private int DefaultIntervalOfActivities = 1200;
        private int CounterOfIntervalOfActivities;

        public Form1()
        {
            this.CounterOfIntervalOfActivities = this.DefaultIntervalOfActivities;
            var Timer = new System.Windows.Forms.Timer();
            Timer.Interval = 1000;
            Timer.Tick += TimerTickHandler;
            Timer.Start();
            InitializeComponent();
            GetOutTimeLess();
        }

        private void GetOutTimeLess()
        {
            if (this.CounterOfIntervalOfActivities <= 128 && this.CounterOfIntervalOfActivities >= 0)
            {
                this.label1.ForeColor = Color.FromArgb(255, (byte)(255 - (this.CounterOfIntervalOfActivities * 2)), 0, 0);
            }
            this.label1.Text = "Activities after: " + CounterOfIntervalOfActivities + " sec";
        }

        public void TimerTickHandler(object sender, EventArgs e)
        {
            --this.CounterOfIntervalOfActivities;
            GetOutTimeLess();
            if (this.CounterOfIntervalOfActivities == 0)
            {
                MessageBox.Show("Wait 15 minutes");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.CounterOfIntervalOfActivities = this.DefaultIntervalOfActivities;
            this.label1.ForeColor = Color.Black;
            GetOutTimeLess();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var FormBuffer = new Form2(this.DefaultIntervalOfActivities);
            FormBuffer.ShowDialog();
            this.DefaultIntervalOfActivities = FormBuffer.GetInterval();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Focus();
        }
    }
}
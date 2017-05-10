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
    public partial class Form2 : Form
    {
        private int DefaultIntervalOfActivities;

        public int GetInterval()
        {
            return this.DefaultIntervalOfActivities;
        }

        public Form2(int Current)
        {
            this.DefaultIntervalOfActivities = Current;
            InitializeComponent();
            this.textBox1.Text = Current.ToString();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CloseForm();
            }
        }

        private void CloseForm()
        {
            int.TryParse(this.textBox1.Text, out this.DefaultIntervalOfActivities);
            this.Close();
        }
    }
}

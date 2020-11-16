using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Report
{
    public partial class Form1 : Form
    {
        int PW;
        bool Hided;

        public Form1()
        {
            InitializeComponent();
            PW = SPanel.Width;
            Hided = false;
        }

        private void BtHide_Click(object sender, EventArgs e)
        {
            if (Hided)
            {
                BtHide.Text = "Hide";
            }
            else
            {
                BtHide.Text = "Show";
            }
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(Hided)
            {
                SPanel.Width += 20;
                if(SPanel.Width>=PW)
                {
                    timer1.Stop();
                    Hided = false;
                    this.Refresh();
                }
            }
            else
            {
                SPanel.Width -= 20;
                if(SPanel.Width<=0)
                {
                    timer1.Stop();
                    Hided = true;
                    this.Refresh();
                }
            }
        }

        private void BtJanuary_Click(object sender, EventArgs e)
        {
            LabelMonth.Text = "January";
        }

        private void BtFebruary_Click(object sender, EventArgs e)
        {
            LabelMonth.Text = "February";
        }

        private void BtMars_Click(object sender, EventArgs e)
        {
            LabelMonth.Text = "Mars";
        }

        private void BtApril_Click(object sender, EventArgs e)
        {
            LabelMonth.Text = "April";
        }

        private void BtMay_Click(object sender, EventArgs e)
        {
            LabelMonth.Text = "May";
        }

        private void BtJune_Click(object sender, EventArgs e)
        {
            LabelMonth.Text = "June";
        }

        private void BtJuly_Click(object sender, EventArgs e)
        {
            LabelMonth.Text = "July";
        }

        private void BtAgustus_Click(object sender, EventArgs e)
        {
            LabelMonth.Text = "Agustus";
        }

        private void BtSeptember_Click(object sender, EventArgs e)
        {
            LabelMonth.Text = "September";
        }

        private void BtOctober_Click(object sender, EventArgs e)
        {
            LabelMonth.Text = "October";
        }

        private void BtNovember_Click(object sender, EventArgs e)
        {
            LabelMonth.Text = "November";
        }

        private void btDecember_Click(object sender, EventArgs e)
        {
            LabelMonth.Text = "December";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LabelMonth.Text = "January";
        }

        private void BtTest_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dataGridView1.Rows[0].Cells[0].Value.ToString());
        }
    }
}

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

        private void btClick_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
    }
}

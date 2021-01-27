using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roi_Tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (iAL.Text != string.Empty && iAR.Text != string.Empty &&
                iBL.Text != string.Empty && iBR.Text != string.Empty &&
                iCL.Text != string.Empty && iCR.Text != string.Empty)
            {
                int iARtemp = Convert.ToInt32(iAR.Text);
                int iALtemp = Convert.ToInt32(iAL.Text);

                int Asum = iARtemp - iALtemp + 1;
                string Asumstring = Convert.ToString(Asum);

                iAsum.Text = Asumstring;

                int iBRtemp = Convert.ToInt32(iBR.Text);
                int iBLtemp = Convert.ToInt32(iBL.Text);

                int Bsum = iBRtemp - iBLtemp + 1;
                string Bsumstring = Convert.ToString(Bsum);

                iBsum.Text = Bsumstring;

                int iCRtemp = Convert.ToInt32(iCR.Text);
                int iCLtemp = Convert.ToInt32(iCL.Text);

                int Csum = iCRtemp - iCLtemp + 1;
                string Csumstring = Convert.ToString(Csum);

                iCsum.Text = Csumstring;

                int grandsum = Asum + Bsum + Csum;
                string ABCgrandsum = Convert.ToString(grandsum);

                iGrandSum.Text = ABCgrandsum;
            }
            else
            {
                iAsum.Clear();
                iBsum.Clear();
                iCsum.Clear();
            }

            
        }
    }
}

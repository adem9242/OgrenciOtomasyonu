using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anasayfa
{
    public partial class ProgressBar : Form
    {
        public static int gelen;
        public ProgressBar()
        {
            InitializeComponent();

        }
        
        private void ProgressBar_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            progressBarControl1.EditValue = i;
            if (i == 100)
            {
               
                
                 this.Close();
                


            }

        }

        

       
    }
}

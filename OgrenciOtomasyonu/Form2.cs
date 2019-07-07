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
    
    public partial class Form2 : Form
    {
        private Point mouseOffset;
        private bool isMouseDown = false;
        public Form2()
        {
            InitializeComponent();
            
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            saniye.Start();
            //  saniye.Enabled = true;
        }

        private void saniye_Tick(object sender, EventArgs e)
        {
            arcScaleNeedleComponent3.Value += 0.2f;
            if(arcScaleNeedleComponent3.Value== 12.1999931f)
            {
                arcScaleNeedleComponent2.Value += 0.2f;
                arcScaleNeedleComponent3.Value = 0.2f;
                if(arcScaleNeedleComponent2.Value==8||arcScaleNeedleComponent2.Value==10 || arcScaleNeedleComponent2.Value == 11 || arcScaleNeedleComponent2.Value == 12)
                {
                    arcScaleNeedleComponent1.Value += 0.25f;
                }
            }
            
        }

        
        

        private void gaugeControl1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }

        }

        private void gaugeControl1_MouseDown(object sender, MouseEventArgs e)
        {
            int xOffset;

            int yOffset;

            if

            (e.Button == MouseButtons.Left)

            {

                xOffset = -e.X - SystemInformation.FrameBorderSize.Width;

                yOffset = -e.Y - SystemInformation.CaptionHeight - SystemInformation.FrameBorderSize.Height;

                mouseOffset = new Point(xOffset, yOffset);

                isMouseDown = true;

            }

        }

        private void gaugeControl1_MouseUp(object sender, MouseEventArgs e)
        {
            // isMouseDown değişkenini false yapalım ki

            // kullanıcı elini fareden çekince form sürüklenmesin.

            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }
    }
}

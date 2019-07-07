using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;

namespace Anasayfa
{
    public partial class SplashScreen1 : SplashScreen
    {
       // Anasayfa sy = new Anasayfa();
        public SplashScreen1()
        {
            InitializeComponent();
        }
        Anasayfa sy;
        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }

        private void SplashScreen1_Load(object sender, EventArgs e)
        {
            // timer1.Enabled = true;
            
            

        }
    }
}
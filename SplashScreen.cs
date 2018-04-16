using MetroFramework;
using MetroFramework.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WolfWatch
{
    public partial class SplashScreen : MetroFramework.Forms.MetroForm
    {
        public SplashScreen()
        {
            InitializeComponent();

            SplashScreenStart();
        }

        public async void SplashScreenStart()
        {
            await Task.Delay(500);
            Startup.Start();
        }
    }
}

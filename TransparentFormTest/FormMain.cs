using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransparentFormTest
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            var bmp = new Bitmap("trimg.png");
            var transKey = Color.White;
            bmp.MakeTransparent(transKey);
            this.BackgroundImage = bmp;
            this.BackColor = transKey;
            this.TransparencyKey = transKey;

            var screenW = Screen.PrimaryScreen.WorkingArea.Width;
            var screenH = Screen.PrimaryScreen.WorkingArea.Height;
            this.SetDesktopLocation(screenW - this.Width, screenH - this.Height);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timerSecond_Tick(object sender, EventArgs e)
        {
            labelClock.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }
    }
}

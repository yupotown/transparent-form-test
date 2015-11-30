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
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

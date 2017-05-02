using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaPractica1
{
    public partial class frmCanvas : Form
    {
        private System.Drawing.Graphics g;
        private int xpos = 0;
        private System.Drawing.Pen pen1 = new System.Drawing.Pen(Color.Black, 1F);
        Bitmap i;
        public frmCanvas()
        {
            InitializeComponent();
            
        }

        private void frmCanvas_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            cargar();
        }

        private void cargar() {

            g = pictureBox1.CreateGraphics();
            string directory = AppDomain.CurrentDomain.BaseDirectory;
           i = new Bitmap(directory + "../../imagenes/sprites.png");

            g.DrawImage(i, xpos, 0);
            xpos += 32;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cargar();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            var sourceRectangle = new Rectangle(xpos, 64, 32, 32);
            var destRectangle1 = new Rectangle(xpos, xpos, 32, 32);
            g.DrawImage(i,sourceRectangle, destRectangle1, GraphicsUnit.Pixel);
            xpos += 32;
        }
    }
}

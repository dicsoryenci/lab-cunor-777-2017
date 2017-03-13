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
        public frmCanvas()
        {
            InitializeComponent();
            cargar();
        }

        private void frmCanvas_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar() {
            g = pictureBox1.CreateGraphics();
            string directory = AppDomain.CurrentDomain.BaseDirectory;
            Image i = Image.FromFile(directory + "../../imagenes/sprites.png");


            g.DrawImage(i, xpos, 0);
            xpos += 32;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cargar();
        }
    }
}

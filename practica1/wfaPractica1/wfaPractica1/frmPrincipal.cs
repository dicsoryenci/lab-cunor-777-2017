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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string entrada = txtEntrada.Text;
            List<clsElemento> lstElementos = new List<clsElemento>();

            lstElementos = fncLeer(entrada, lstElementos);
            foreach (clsElemento ltr in lstElementos)
            {
                txtSalida.Text += ltr.letra + " -> " + ltr.cantidad + Environment.NewLine;
            }
        }

        public List<clsElemento> fncLeer(string cadena, List<clsElemento> lstLetras) {

            if (cadena != "")
            {
                char letra = cadena[0];

                bool encontrado = false;
                int inxLista = 0;
                int contador = 0;

                foreach (clsElemento ltr in lstLetras)
                {
                    if (ltr.letra == letra) {
                        encontrado = true;
                        inxLista = contador;
                    }
                    contador++;
                }

                if (encontrado == false)
                {
                    clsElemento m = new clsElemento();
                    m.letra = letra;
                    m.cantidad = 0;
                    lstLetras.Add(m);
                }
                else {
                    clsElemento elemento = lstLetras.ElementAtOrDefault(inxLista);
                    elemento.cantidad = elemento.cantidad +1;
                    lstLetras.RemoveAt(inxLista);
                    lstLetras.Add(elemento);
                    if (cadena.Length == 1) {
                        cadena = "";
                    } else
                    {
                        cadena = cadena.Substring(1, cadena.Length-1);
                    }
                    
                }

                fncLeer(cadena, lstLetras);
            }
            return lstLetras;
        }
    }
}

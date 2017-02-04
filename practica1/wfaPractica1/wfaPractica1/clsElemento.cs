using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaPractica1
{
    public class clsElemento
    {
        public char letra { get; set;} 
        public int cantidad { get; set; }

        public clsElemento(){
            this.letra = 'a';
            this.cantidad = 0;
        }
    }
}

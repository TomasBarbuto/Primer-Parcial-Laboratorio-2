using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Productos
{
    public class Pantalon : Producto
    {
        private string _tiroDeCintura;
        private int _bolsillos;

        public string TiroDeCintura
        {
            get { return _tiroDeCintura; }
            set { _tiroDeCintura = value; }
        }

        public int Bolsillos
        {
            get { return _bolsillos; }
            set { _bolsillos = value; }
        }

        public Pantalon(string nombre, float precio, string talle, string color, string tiroDeCintura, int bolsillos)
            : base(nombre, precio, talle, color)
        {
            _tiroDeCintura = tiroDeCintura;
            _bolsillos = bolsillos;
        }
    }

}

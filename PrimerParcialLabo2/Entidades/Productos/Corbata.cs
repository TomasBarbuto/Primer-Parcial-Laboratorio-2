using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Productos
{
    public class Corbata : Producto
    {
        private decimal _largo;
        private decimal _ancho;

        public decimal Largo
        {
            get { return _largo; }
            set { _largo = value; }
        }

        public decimal Ancho
        {
            get { return _ancho; }
            set { _ancho = value; }
        }

        public Corbata(string nombre, float precio, string talle, string color, decimal largo, decimal ancho)
            : base(nombre, precio, talle, color)
        {
            _largo = largo;
            _ancho = ancho;
        }
    }

}

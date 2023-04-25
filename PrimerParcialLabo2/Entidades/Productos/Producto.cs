using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Productos
{
    public class Producto
    {
        private int _codigo;
        private string _nombre;
        private float _precio;
        private string _talle;
        private string _color;

        public int Codigo
        {
            get { return _codigo; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public float Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }

        public string Talle
        {
            get { return _talle; }
            set { _talle = value; }
        }

        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public Producto(string nombre, float precio, string talle, string color)
        {
            Random RD = new();

            _codigo = RD.Next(000001, 999999);
            _nombre = nombre;
            _precio = precio;
            _talle = talle;
            _color = color;
        }
    }
}

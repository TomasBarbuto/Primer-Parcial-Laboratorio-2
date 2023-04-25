using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Productos
{
    public class Camisa : Producto
    {
        private string _manga;
        private string _cuello;

        public string Manga
        {
            get { return _manga; }
            set { _manga = value; }
        }

        public string Cuello
        {
            get { return _cuello; }
            set { _cuello = value; }
        }

        public Camisa(string nombre, float precio, string talle, string color, string manga, string cuello)
            : base(nombre, precio, talle, color)
        {
            _manga = manga;
            _cuello = cuello;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Productos
{
    public class Zapato : Producto
    {
        private string _tipoDeCierre;
        private string _tipoDePunta;

        public string TipoDeCierre
        {
            get { return _tipoDeCierre; }
            set { _tipoDeCierre = value; }
        }

        public string TipoDePunta
        {
            get { return _tipoDePunta; }
            set { _tipoDePunta = value; }
        }

        public Zapato(string nombre, float precio, string talle, string color, string tipoDeCierre, string tipoDePunta)
            : base(nombre, precio, talle, color)
        {
            _tipoDeCierre = tipoDeCierre;
            _tipoDePunta = tipoDePunta;
        }
    }
}

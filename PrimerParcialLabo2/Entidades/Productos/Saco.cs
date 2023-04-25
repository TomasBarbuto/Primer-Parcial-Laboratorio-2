using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Productos
{
    public class Saco : Producto
    {
        private string _tipoDeCuello;
        private string _tipoDeManga;

        public string TipoDeCuello
        {
            get { return _tipoDeCuello; }
            set { _tipoDeCuello = value; }
        }

        public string TipoDeManga
        {
            get { return _tipoDeManga; }
            set { _tipoDeManga = value; }
        }

        public Saco(string nombre, float precio, string talle, string color, string tipoDeCuello, string tipoDeManga)
            : base(nombre, precio, talle, color)
        {
            _tipoDeCuello = tipoDeCuello;
            _tipoDeManga = tipoDeManga;
        }
    }
}

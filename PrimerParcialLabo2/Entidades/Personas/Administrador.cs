using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Personas
{
    public class Administrador : Persona
    {
        private string _idAdmin;
        private string _usuario;
        private string _contrasena;

        public Administrador(string nombre, string apellido, string dni, string usuario, 
            string contrasena) : base(nombre, apellido, dni)
        {
            _idAdmin = dni;
            _usuario = usuario;
            _contrasena = contrasena;
        }

        public string IdAdmin
        {
            get { return _idAdmin; }
            set { _idAdmin = value; }
        }

        public string Usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }

        public string Contrasena
        {
            get { return _contrasena; }
            set { _contrasena = value; }
        }
    }
}

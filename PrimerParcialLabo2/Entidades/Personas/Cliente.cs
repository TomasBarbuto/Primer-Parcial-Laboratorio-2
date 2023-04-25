using Entidades.Productos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Personas
{
    public class Cliente : Persona
    {
        private string _direccion;
        private string _telefono;
        private string _email;
        private List <Producto> _carritoDeCompras;
        private string _idCliente;
        private string _contrasena;

        public Cliente(string nombre, string apellido, string dni, string direccion, string telefono, 
            string email, string contrasena): base(nombre, apellido, dni)
        {
            _direccion = direccion;
            _telefono = telefono;
            _email = email;
            _carritoDeCompras = new List<Producto>();
            _idCliente = dni;
            _contrasena = contrasena;
        }

        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public List<Producto> CarritoDeCompras
        {
            get { return _carritoDeCompras; }
            set { _carritoDeCompras = value; }
        }

        public string IdCliente
        {
            get { return _idCliente; }
            set { _idCliente = value; }
        }

        public string Contrasena
        {
            get { return _contrasena; }
            set { _contrasena = value; }
        }
    }
}

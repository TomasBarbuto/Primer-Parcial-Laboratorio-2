namespace Entidades.Personas
{
    public class Persona
    {
        private string _nombre;
        private string _apellido;
        private string _dni;

        public Persona(string nombre, string apellido, string dni)
        {
            _nombre = nombre;
            _apellido = apellido;
            _dni = dni;
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        public string Dni
        {
            get { return _dni; }
            set { _dni = value; }
        }
    }
}
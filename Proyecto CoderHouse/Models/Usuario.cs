using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_CoderHouse.Models
{
    public class Usuario
    {
        private int _id;
        private string _nombre;
        private string _apellido;
        private string _nombreUsuario;
        private string _contraseña;
        private string _mail;

        public Usuario() { }

        public Usuario(int id, string nombre, string apellido, string nombreusuario, string contraseña, string mail)
        {
            _id = id;
            _nombre = nombre;
            _apellido = apellido;
            _nombreUsuario = nombreusuario;
            _contraseña = contraseña;
            _mail = mail;
        }
        public int Id { get { return _id; } set { _id = value; } }
        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        public string Apellido { get { return _apellido; } set { _apellido = value; } }
        public string NombreUsuario { get { return _nombreUsuario; } set { _nombreUsuario = value; } }
        public string Contraseña { get { return _contraseña; } set { _contraseña = value; } }
        public string Mail { get { return _mail; } set { _mail = value; } }

    }
}
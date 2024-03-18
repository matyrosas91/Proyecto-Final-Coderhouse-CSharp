using Proyecto_CoderHouse.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_CoderHouse
{
    public partial class ABMUsuario : Form
    {
        public ABMUsuario()
        {
            InitializeComponent();
        }
        internal Usuario UsuarioCreado { get; set; }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario()
            {
                Apellido = this.txtApellido.Text,
                Nombre = this.txtNombre.Text,
                Contraseña = txtContraseña.Text,
                NombreUsuario = txtNombreUsuario.Text,
                Mail = txtMail.Text,
            };

            this.UsuarioCreado = usuario;
            this.Close();
        }
        private void ABMUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}

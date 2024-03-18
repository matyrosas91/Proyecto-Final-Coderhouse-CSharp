using Proyecto_CoderHouse.DataBase;
using Proyecto_CoderHouse.Models;
using Proyecto_CoderHouse.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_CoderHouse
{
    public partial class Vista : Form
    {
        public Vista()
        {
            InitializeComponent();
        }


        private void Vista_Load(object sender, EventArgs e)
        {

        }

        private void dgbProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void btnCargarDatos_Click(object sender, EventArgs e)
        {
            using (databasecontext database = new databasecontext())
            {
                List<Producto> productos = database.Productos
                    .Where(p => p.Id == 1) //Acá comienza la consula LINQ. En l acual sellecciona solo el producto con el ID 1
                    .Select(p => p)// " p " Es una variable temporal que se usa para la lista "productos"
                    .ToList();//Esta parte convierte la consulta LINQ en una lista de objetos Producto.

                MessageBox.Show(productos[0].Descripcion);

            }
        }

        private void btnListarProductos_Click(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            List<Usuario> usuarios = UsuarioService.ObtenerTodosLosUsuarios();

            this.ActualizarDgv(usuarios);
        }
        private void ActualizarDgv(object objeto)
        {
            this.dgbProductos.DataSource = null; //Se pone null primero para que el Data Grid View se limpie y no aparezcan datos erroneos
            this.dgbProductos.DataSource = objeto;

        }

        private void btnBuscarPorId_Click(object sender, EventArgs e)
        {
            string idString = this.txtId.Text;
            if (!string.IsNullOrWhiteSpace(idString))
            {
                int id = Convert.ToInt32(idString);

                Usuario usuarioBuscado = UsuarioService.ObtenerUsuarioPorId(id);

                List<Usuario> lista = new List<Usuario>() { usuarioBuscado };

                this.ActualizarDgv(lista);
            }
            else
            {
                MessageBox.Show("Complete el ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtId.Focus();
            }

        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            ABMUsuario frmAlta = new ABMUsuario();
            frmAlta.ShowDialog();
            this.Hide();

            Usuario usuario = frmAlta.UsuarioCreado;

            this.Show();

            if (UsuarioService.AgregarUsuario(usuario))
            {
                MessageBox.Show("Agregue un usuario");
            }

        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            String idString = this.txtId.Text;
            if (!string.IsNullOrWhiteSpace(idString))
            {
                int id = Convert.ToInt32(idString);
                bool resultado = ProductoService.EliminarProductoPorId(id);

                if (resultado)
                {
                    MessageBox.Show("Borrrado", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
               MessageBox.Show("Complete el ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtId.Focus();
            }
        }
    }
}
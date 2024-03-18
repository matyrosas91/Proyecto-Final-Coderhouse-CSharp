using Proyecto_CoderHouse.DataBase;
using Proyecto_CoderHouse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_CoderHouse.Service
{
    public class ProductoService
    {
        internal static List<Producto> ListaProductos()
        {
            using (databasecontext context = new databasecontext())
            {
                List<Producto> productos = context.Productos.ToList();

                return productos;
            }

        }

        internal static Producto ObtenerProductoPorId(int id)
        {
            using (databasecontext context = new databasecontext())
            {

                Producto? productoEncontrado = context.Productos.Where(p => p.Id == id).FirstOrDefault();
                return productoEncontrado;
            }
        }

        internal static bool AgregarProducto(Producto producto)
        {
            using (databasecontext context = new databasecontext())
            {
                context.Productos.Add(producto);

                context.SaveChanges();

                return true;
            }
        }

        internal static bool ActualizarProductoPorId(Producto producto, int id)
        {
            using (databasecontext context = new databasecontext())
            {
                Producto? productoBuscado = context.Productos.Where(p => p.Id == id).FirstOrDefault();
                productoBuscado.Descripcion = producto.Descripcion;
                productoBuscado.Costo = producto.Costo;
                productoBuscado.PrecioVenta = producto.PrecioVenta;
                productoBuscado.Stock = producto.Stock;
                productoBuscado.IdUsuario = producto.IdUsuario;

                context.Productos.Update(productoBuscado);

                context.SaveChanges();
                return true;
            }
        }

        internal static void EliminarProducto(int idProducto)
        {
            using (var context = new databasecontext())
            {
                var producto = context.Productos.Find(idProducto);

                // Eliminar las ventas relacionadas
                foreach (var venta in producto.Venta)
                {
                    context.Venta.Remove(venta);
                }

                // Eliminar el producto
                context.Productos.Remove(producto);

                context.SaveChanges();
            }
        }
    }
}
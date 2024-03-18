using Proyecto_CoderHouse.DataBase;
using Proyecto_CoderHouse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_CoderHouse.Service
{
    internal class ProductoVendidoService
    {
        internal static List<ProductoVendido> ListaProductosVendidos()
        {
            using (databasecontext context = new databasecontext())
            {
                List<ProductoVendido> productosVendidos = context.ProductoVendidos.ToList();

                return productosVendidos;
            }
        }

        internal static ProductoVendido ObtenerProductoVendidoPorId(int id)
        {
            using (databasecontext context = new databasecontext())
            {

                ProductoVendido? productoVendido = context.ProductoVendidos.Where(p => p._Id == id).FirstOrDefault();
                return productoVendido;
            }
        }

        internal static bool AgregarProductoVendido(ProductoVendido productoVendidos)
        {
            using (databasecontext context = new databasecontext())
            {
                context.ProductoVendidos.Add(productoVendidos);

                context.SaveChanges();

                return true;
            }
        }

        internal static bool ActualizarProductoVendidoPorId(ProductoVendido productoVendidos, int id)
        {
            using (databasecontext context = new databasecontext())
            {
                ProductoVendido? productoVendido = context.ProductoVendidos.Where(p => p._Id == id).FirstOrDefault();

                productoVendido.IdProducto = productoVendido.IdProducto;
                productoVendido.IdVenta = productoVendido.IdVenta;
                productoVendido.Stock = productoVendido.Stock;

                context.ProductoVendidos.Update(productoVendido);

                context.SaveChanges();
                return true;
            }
        }

        internal static void EliminarProductoVendido(int id)
        {
            using (var context = new databasecontext())
            {

                var productoVendido = context.ProductoVendidos.Find(id);

                if (productoVendido == null)
                {
                    return;
                }

                context.ProductoVendidos.Remove(productoVendido);

                context.SaveChanges();
            }
        }

    }
}
using Proyecto_CoderHouse.DataBase;
using Proyecto_CoderHouse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_CoderHouse.Service
{
    internal class VentaService
    {
        internal static List<Venta> ListaVenta()
        {
            using (databasecontext context = new databasecontext())
            {
                List<Venta> ventas = context.Venta.ToList();

                return ventas;
            }
        }

        internal static Venta ObtenerVentaPorId(int id)
        {
            using (databasecontext context = new databasecontext())
            {

                Venta? ventas = context.Venta.Where(p => p._Id == id).FirstOrDefault();
                return ventas;
            }
        }

        internal static bool AgregarVenta(Venta ventas)
        {
            using (databasecontext context = new databasecontext())
            {
                context.Venta.Add(ventas);

                context.SaveChanges();

                return true;
            }
        }

        internal static bool ActualizarVentaPorId(Venta ventas, int id)
        {
            using (databasecontext context = new databasecontext())
            {
                Venta? v = context.Venta.Where(p => p._Id == id).FirstOrDefault();

                ventas.Comentarios = ventas.Comentarios;
                ventas.IdUsuario = ventas.IdUsuario;

                context.Venta.Update(v);

                context.SaveChanges();
                return true;
            }
        }

        internal static void EliminarVenta(int id)
        {
            using (var context = new databasecontext())
            {

                var ventas = context.Venta.Find(id);

                if (ventas == null)
                {
                    Console.WriteLine("Ese ID no existe");
                    return;
                }

                context.Venta.Remove(ventas);

                context.SaveChanges();
            }
        }

    }
}

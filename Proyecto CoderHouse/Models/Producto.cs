using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_CoderHouse.Models
{
    public class Producto
    {
        public virtual ICollection<Venta> Venta { get; set; }

        private int _Id;
        private string _Descripcion;
        private double _Costo;
        private double _PrecioVenta;
        private int _Stock;
        private int _IdUsuario;

        public Producto() { }

        public Producto(int id, string descripcion, double costo, double precioVenta, int stock, int idUsuario)
        {
            _Id = id;
            _Descripcion = descripcion;
            _Costo = costo;
            _PrecioVenta = precioVenta;
            _Stock = stock;
            _IdUsuario = idUsuario;
        }

        public int Id { get { return _Id; } set { _Id = value; } }
        public string Descripcion { get { return _Descripcion; } set { _Descripcion = value; } }
        public double Costo { get { return _Costo; } set { _Costo = value; } }
        public double PrecioVenta { get { return _PrecioVenta; } set { _PrecioVenta = value; } }
        public int Stock { get { return _Stock; } set { _Stock = value; } }
        public int IdUsuario { get { return _IdUsuario; } set { _IdUsuario = value; } }
    }
}
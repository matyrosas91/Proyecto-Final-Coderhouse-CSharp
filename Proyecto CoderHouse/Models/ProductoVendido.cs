using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_CoderHouse.Models
{
    internal class ProductoVendido
    {
        [Key]
        public int _Id { get; set; }
        private int _IdProducto;
        private int _Stock;
        private int _IdVenta;

        public ProductoVendido() { }
        public ProductoVendido(int id, int idProducto, int stock, int idVenta)
        {
            _Id = id;
            _IdProducto = idProducto;
            _Stock = stock;
            _IdVenta = idVenta;
        }
        public int Stock { get; set; }
        public int IdVenta { get; set; }
        public int IdProducto {  get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_CoderHouse.Models
{
    public class Venta
    {
        [Key]
        public int _Id { get; set; }
        private string _Comentarios;
        private int _IdUsuario;

        public Venta() { }

        public Venta(int id, string comentarios, int idusuario)
        {
            _Id = id;
            _Comentarios = comentarios;
            _IdUsuario = idusuario;
        }

        public string Comentarios { get; set; }
        public int IdUsuario { get; set; }
    }
}
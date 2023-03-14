using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace ProyProductosEF.Models
{
    public class ProductEF
    {
        private int idProducto;
        private String nombre;
        private String categoria;
        private String detalle;

        public ProductEF() { }
        public ProductEF(int idProducto, string nombre, string categoria, string detalle)
        {
            this.idProducto = idProducto;
            this.nombre = nombre;
            this.categoria = categoria;
            this.detalle = detalle;
        }

        public int IdProducto { get => idProducto; set => idProducto = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public string Detalle { get => detalle; set => detalle = value; }
    }
}

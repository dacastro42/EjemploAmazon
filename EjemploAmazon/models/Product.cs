using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploAmazon.models
{
    public class Product
    {
        private int idProducto;
        private string nombreProducto;
        private double precio;
        private string descripcion;
        private int cantidadP;
        private string imagenProducto;
        private string fechaRegistro;

        public Product()
        {
        }

        public Product(int idProducto, string nombreProducto, double precio, string descripcion, int cantidadP, string imagenProducto, string fechaRegistro)
        {
            this.idProducto = idProducto;
            this.nombreProducto = nombreProducto;
            this.precio = precio;
            this.descripcion = descripcion;
            this.cantidadP = cantidadP;
            this.imagenProducto = imagenProducto;
            this.fechaRegistro = fechaRegistro;
        }

        public Product(string nombreProducto, double precio, string descripcion, int cantidadP)
        {
            this.nombreProducto = nombreProducto;
            this.precio = precio;
            this.descripcion = descripcion;
            this.cantidadP = cantidadP;
        }

        public int IdProducto { get => idProducto; set => idProducto = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public double Precio { get => precio; set => precio = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int CantidadP { get => cantidadP; set => cantidadP = value; }
        public string ImagenProducto { get => imagenProducto; set => imagenProducto = value; }
        public string FechaRegistro { get => fechaRegistro; set => fechaRegistro = value; }
    }
}

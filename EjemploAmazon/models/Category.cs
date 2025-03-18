using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploAmazon.models
{
    public class Category
    {
        private int idCategoria;
        private string nombreCategoria;
        private string descripcionCategoria;

       

        public Category(int idCategoria, string nombreCategoria, string descripcionCategoria)
        {
            this.idCategoria = idCategoria;
            this.nombreCategoria = nombreCategoria;
            this.descripcionCategoria = descripcionCategoria;
        }

        public Category(string nombreCategoria, string descripcionCategoria)
        {
            this.nombreCategoria = nombreCategoria;
            this.descripcionCategoria = descripcionCategoria;
        }
        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public string NombreCategoria { get => nombreCategoria; set => nombreCategoria = value; }
        public string DescripcionCategoria { get => descripcionCategoria; set => descripcionCategoria = value; }

    }
}

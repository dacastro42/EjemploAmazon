using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

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

        //Variables BD
        ConnectDB objConection = new ConnectDB();

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

        //Métodos de BD
        internal int SelectLastProductByID(string sql)
        {
            //List<Category> listCategory = new List<Category>();
            int idP = 0;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, objConection.DataSource());
                objConection.ConnectOpened();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        idP = reader.GetInt32(0);
                        Console.WriteLine("El último ID "+idP);
                        //string nombreCategoriac = reader.GetString(1);
                        //string descripcionc = reader.GetString(2);

                        //Category objc = new Category(idCategoriac, nombreCategoriac, descripcionc);

                        //listCategory.Add(objc);
                    }
                }
            }
            catch (Exception w)
            {
                Console.WriteLine("ERROOOOOOR " + w.Message);
                objConection.ConnectClosed();
            }
            finally
            {
                objConection.ConnectClosed();
            }


            return idP;
        }
    }
}

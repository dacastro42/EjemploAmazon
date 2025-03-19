using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace EjemploAmazon.models
{
    public class Category
    {
        private int idCategoria;
        private string nombreCategoria;
        private string descripcionCategoria;

        //Variables BD
        ConnectDB objConection = new ConnectDB();

        public Category()
        {
        }

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



        //Métodos para BD
        internal List<Category> SelectCategories(string sql)
        {
            List<Category> listCategory = new List<Category>();
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, objConection.DataSource());
                objConection.ConnectOpened();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int idCategoriac = reader.GetInt32(0);
                        string nombreCategoriac = reader.GetString(1);
                        string descripcionc= reader.GetString(2);

                        Category objc = new Category(idCategoriac, nombreCategoriac, descripcionc);

                        listCategory.Add(objc);
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


            return listCategory;
        }
    }
}

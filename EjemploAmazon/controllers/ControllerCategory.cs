using EjemploAmazon.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploAmazon.controllers
{
    public class ControllerCategory
    {
        internal List<Category> selectCategories()
        {
            List<Category> listC = new List<Category>();
            Category objC = new Category();
            string sql = "select * from categorias";
            listC = objC.SelectCategories(sql);

            return listC;
        }
    }
}

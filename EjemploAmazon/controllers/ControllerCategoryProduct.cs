using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjemploAmazon.models;

namespace EjemploAmazon.controllers
{
    class ControllerCategoryProduct
    {
        internal bool insertCategoryProducts(int idP, int idC)
        {
            bool result = false;
            string sql = "insert into categoria_productos(idCategoriaF, idProductoF) " +
                "values(" + idC + ", " + idP +");";

            ConnectDB objDB = new ConnectDB();
            result = objDB.ExecuteQuery(sql);
            return result;
        }
    }
}

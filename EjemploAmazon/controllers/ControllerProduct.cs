using EjemploAmazon.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploAmazon.controllers
{
    public class ControllerProduct
    {
        internal bool insertProduct(Product objp)
        {
            bool result = false;
            string sql = "insert into productos(nombreProducto, precio, descripcion, cantidadP) " +
                "values('"+objp.NombreProducto+"', "+objp.Precio+", '"+objp.Descripcion+"', "+objp.CantidadP+");";

            ConnectDB objDB = new ConnectDB();
            result = objDB.ExecuteQuery(sql);
            return result;
        }
    }
}

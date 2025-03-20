using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EjemploAmazon.models;
using EjemploAmazon.controllers;


namespace EjemploAmazon.views
{
    public partial class UI_Products : Form
    {
        List<Category> listC = null;
        public UI_Products()
        {
            InitializeComponent();
        }

        //Método para traer la imagen 
        private void button1_Click(object sender, EventArgs e)
        {

        }

        //método para insert producto
        private void button2_Click(object sender, EventArgs e)
        {
            string nombreProducto=textBox1.Text;
            double precio=double.Parse(textBox2.Text);
            string descripcion=textBox3.Text;
            int cantidadP= Int32.Parse(textBox4.Text);
            // string imagenProducto;
            Product objp = new Product(nombreProducto, precio, descripcion, cantidadP);

            ControllerProduct objCP = new ControllerProduct();

            bool result = objCP.insertProduct(objp);


            //insert tabla intermedia

            bool result2 = insertCategoryProduct();

            if (result && result2)
            {
                MessageBox.Show("Product successfully inserted");
            }
            else
            {
                MessageBox.Show("Product not inserted");
            }


        }

        public bool insertCategoryProduct()
        {
            bool result = false;
            ControllerProduct objCP = new ControllerProduct();
            int idPInsert = objCP.SelectLastProductByID();

            string selected = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);

            int idcategory = 0;
            for (int i = 0; i < listC.Count; i++)
            {
                if (selected.Equals(listC[i].NombreCategoria))
                {
                    idcategory = listC[i].IdCategoria;
                }

            }

            ControllerCategoryProduct objCCP = new ControllerCategoryProduct();
            result= objCCP.insertCategoryProducts(idPInsert, idcategory);

            return result;
        }

        //Carga de categorias 
        private void UI_Products_Load(object sender, EventArgs e)
        {
           
            ControllerCategory objCC = new ControllerCategory();
            listC = objCC.selectCategories();

            for (int i = 0; i < listC.Count; i++)
            {
                comboBox1.Items.Add(listC[i].NombreCategoria);

            }
        }
    }
}

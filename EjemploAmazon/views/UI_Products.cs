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

            if (result)
            {
                MessageBox.Show("Product successfully inserted");
            }
            else
            {
                MessageBox.Show("Product not inserted");
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M05Participation_JustinBarr
{
    public partial class ProductSearchForm : Form
    {
        //Create an instance of the database class
        ProductDbContext db = new ProductDbContext();
        public ProductSearchForm()
        {
            InitializeComponent();
        }

        private void BTNAddNew_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.ShowDialog();
        }

        private void BTNDelete_Click(object sender, EventArgs e)
        {
            //Ensure user has selected item
            if (CBProductID.SelectedIndex > -1)
            {
                //Selects the first item in the list of found products
                Product foundProd = db.Products.FirstOrDefault(prod => prod.Product_Number == CBProductID.SelectedItem.ToString());

                if (foundProd != null)
                {
                    db.Products.Remove(foundProd);
                    db.SaveChanges();
                    UpdateDataTables();
                }
                else
                {
                    //Error message
                    MessageBox.Show("Could not delete the product from the database.");
                }
            }
        }

        private void UpdateDataTables()
        {
            //Updates the datagridview
            DGVProducts.DataSource = db.Products.ToList();
            //Clears the datagridview
            CBProductID.Items.Clear();
            //Adds the new product list to datagridview
            CBProductID.Items.AddRange(db.Products.Select(prod => prod.Product_Number).ToArray());
        }

        private void TXTProductDesc_TextChanged(object sender, EventArgs e)
        {
            List<Product> products = db.Products.Where(prod => prod.Description.Contains(TXTProductDesc.Text)).ToList();

            //List<Product> linqstatement = (from prod in db.Products where prod.Description.Contains(TXTProductDesc.Text) select prod).ToList();

            //Updates the datagridview
            DGVProducts.DataSource = products;
        }

        private void ProductSearchForm_Load(object sender, EventArgs e)
        {
            List<Product> products = (from prod in db.Products select prod).ToList();
            //var products = db.Products.ToList();

            UpdateDataTables();
        }
    }
}
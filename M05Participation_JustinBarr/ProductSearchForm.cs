using System;
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
            //Initializes the Form
            InitializeComponent();
        }

        /// <summary>
        /// Opens the add product form and updates the table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTNAddNew_Click(object sender, EventArgs e)
        {
            //Create instance of the add product form and display
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.ShowDialog();

            //Updates the table
            UpdateDataTables();
        }

        /// <summary>
        /// Deletes selected item from table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTNDelete_Click(object sender, EventArgs e)
        {
            //Ensure user has selected item
            if (CBProductID.SelectedIndex > -1)
            {
                //Selects the first item in the list of found products
                Product foundProd = db.Products.FirstOrDefault(prod => prod.Product_Number == CBProductID.SelectedItem.ToString());

                //If the product is not null
                if (foundProd != null)
                {
                    //Remove the product, save changes, and update the table
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

        /// <summary>
        /// Updates the datagridview
        /// </summary>
        private void UpdateDataTables()
        {
            //Updates the datagridview
            DGVProducts.DataSource = db.Products.ToList();
            //Clears the datagridview
            CBProductID.Items.Clear();
            //Sets combo box text
            CBProductID.Items.Add("Select Product ID");
            //Adds the new product list to datagridview
            CBProductID.Items.AddRange(db.Products.Select(prod => prod.Product_Number).ToArray());
            //Resets the combobox text
            CBProductID.SelectedIndex = 0;
        }

        /// <summary>
        /// Actively searches the database from user input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TXTProductDesc_TextChanged(object sender, EventArgs e)
        {
            //Pulls product from database based on user input
            List<Product> products = db.Products.Where(prod => prod.Description.Contains(TXTProductDesc.Text)).ToList();

            //List<Product> linqstatement = (from prod in db.Products where prod.Description.Contains(TXTProductDesc.Text) select prod).ToList();

            //Updates the datagridview
            DGVProducts.DataSource = products;
        }

        /// <summary>
        /// Loads data before user interaction with form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductSearchForm_Load(object sender, EventArgs e)
        {
            //Pulls products from database
            List<Product> products = (from prod in db.Products select prod).ToList();
            //var products = db.Products.ToList();

            //Updates the table
            UpdateDataTables();
        }
    }
}
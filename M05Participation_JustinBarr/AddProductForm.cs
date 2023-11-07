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
    public partial class AddProductForm : Form
    {
        //Access to the database with db 
        ProductDbContext db = new ProductDbContext();

        public AddProductForm()
        {
            //Intializes Form
            InitializeComponent();
        }

        /// <summary>
        /// Closes Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTNCancel_Click(object sender, EventArgs e)
        {
            //Closes Form
            Close();
        }

        private void BTNAdd_Click(object sender, EventArgs e)
        {
            //Variable declaration
            int uoh;
            decimal price;

            //If input is valid
            if (TXTBoxDesc.Text != "" && TXTBoxProdNo.Text != "" && CBCategory.SelectedIndex > -1 && int.TryParse(TXTBoxUOH.Text, out uoh) && decimal.TryParse(TXTBoxPrice.Text, out price))
            {
                //Create an instance of a product
                Product newProd = new Product
                {
                    //Set values of product to user input
                    Product_Number = TXTBoxProdNo.Text,
                    Description = TXTBoxDesc.Text,
                    Price = price,
                    Units_On_Hand = uoh,
                    Category = CBCategory.SelectedIndex == 0 ? TXTBoxNew.Text : CBCategory.SelectedItem.ToString(),
                };

                //Add new product to database
                db.Products.Add(newProd);
                //Save database changes
                db.SaveChanges();
                //Close the form
                Close();
            }
            else
            {
                MessageBox.Show("Please enter valid data.", "Invalid Input");
            }
        }

        /// <summary>
        /// Displays or hides the new label and textbox depending on what index is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CBCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //If the first item in combobox is selected
            if(CBCategory.SelectedIndex == 0)
            {
                //Show the New label and textbox
                LBLNewCat.Show();
                TXTBoxNew.Show();
            }
            else
            {
                //Hide the New label and text box
                LBLNewCat.Hide();
                TXTBoxNew.Hide() ;
            }
        }

        /// <summary>
        /// Loads the combobox before user interacts with form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddProductForm_Load(object sender, EventArgs e)
        {
            //Creates new category option for Combobox
            CBCategory.Items.Add("New Category");
            //Pulls all categories from database
            var catItems = (from cat in db.Products where cat.Category != null group cat.Category by cat.Category into c select new { Category = c.Key });
            //var catItemsLinqMethod = db.Products.Where(cat >= cat.Category != null).GroupBy(cat => cat.Category).Select(c => new { Category = c.Key });

            //Adds the categories from database to the combobox
            CBCategory.Items.AddRange(catItems.Select(cats => cats.Category).ToArray());
        }
    }
}

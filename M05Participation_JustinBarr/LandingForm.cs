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
    public partial class LandingForm : Form
    {
        public LandingForm()
        {
            //Initializes Form
            InitializeComponent();
        }

        /// <summary>
        /// Loads the product search form from the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTNProdSearch_Click(object sender, EventArgs e)
        {
            //Create instance of product search form and opens it
            ProductSearchForm productSearchForm = new ProductSearchForm();
            productSearchForm.ShowDialog();
        }

        /// <summary>
        /// Loads the Category group form from the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTNGroupCat_Click(object sender, EventArgs e)
        {
            //Create instance of product search form and opens it
            CategoryForm categoryForm = new CategoryForm();
            categoryForm.ShowDialog();
        }
    }
}

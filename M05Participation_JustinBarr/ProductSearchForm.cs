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
            InitializeComponent();
        }

        private void BTNAddNew_Click(object sender, EventArgs e)
        {

        }

        private void BTNDelete_Click(object sender, EventArgs e)
        {

        }

        private void TXTProductDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProductSearchForm_Load(object sender, EventArgs e)
        {
            List<Product> products = (from prod in db.Products select prod).ToList();
            //var products = db.Products.ToList();

            DGVProducts.DataSource = products;
            CBProductID.Items.AddRange(products.Select(prod => prod.Product_Number).ToArray());
        }
    }
}
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
    public partial class CategoryForm : Form
    {
        //Access to the database
        ProductDbContext db = new ProductDbContext();
        public CategoryForm()
        {
            //Initializes form
            InitializeComponent();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            //Adds Columns to the listview
            LSTViewCat.Columns.Add("Category");
            LSTViewCat.Columns.Add("Count");

            //Pulls categories and count from database and loads into catTotals list
            List<CatTotals> catTotals = (from cat in db.Products where cat.Category != null group cat.Category by cat.Category into c select new CatTotals { CatName = c.Key, CatCount = c.Count()}).ToList();

            //Loops through every item in catTotals list
            foreach (var item in catTotals)
            {
                //Creates a string array of Name and Count
                string[] listitem = { item.CatName, item.CatCount.ToString() };
                //Makes new listviewitem using the created string array
                ListViewItem lvi = new ListViewItem(listitem);
                //Adds the list item to the listview
                LSTViewCat.Items.Add(lvi);
            }
        }
    }

    public class CatTotals
    {
        //Create readable writeable variables
        public string CatName { get; set; }
        public int CatCount { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MO4Movies
{
    public partial class MoviesForm : Form
    {
        /// <summary>
        /// Initializes MoviesForm
        /// </summary>
        public MoviesForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Saves Updates
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void movieBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.movieBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.iNFO2200_CrandallSayDataSet1);

        }

        /// <summary>
        /// Loads Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iNFO2200_CrandallSayDataSet1.Movie' table. You can move, or remove it, as needed.
            this.movieTableAdapter1.Fill(this.iNFO2200_CrandallSayDataSet1.Movie);
        }

        /// <summary>
        /// Performs a search based on user input to text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTNSearch_Click(object sender, EventArgs e)
        {
            //Searches and updates the data base to show results matching the user input to text box
            this.movieTableAdapter1.SearchMovieTitle(this.iNFO2200_CrandallSayDataSet1.Movie, TXTMovieSearch.Text);
        }

        /// <summary>
        /// Runs SQL Query and sorts table A-Z
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTNAZSort_Click(object sender, EventArgs e)
        {
            //Runs SQL Query and updates table to show results
            this.movieTableAdapter1.AZMovieSort(this.iNFO2200_CrandallSayDataSet1.Movie);
        }

        /// <summary>
        /// Runs SQL Query and sorts table Z-A
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTNZASort_Click(object sender, EventArgs e)
        {
            //Runs SQL Query and updates table to show results
            this.movieTableAdapter1.ZAMovieSort(this.iNFO2200_CrandallSayDataSet1.Movie);
        }

        /// <summary>
        /// Runs SQL Query and shows top 20 according to movieID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTNTop20Sort_Click(object sender, EventArgs e)
        {
            //Runs SQL Query and updates table to show results
            this.movieTableAdapter1.Top20Sort(this.iNFO2200_CrandallSayDataSet1.Movie);
        }

        /// <summary>
        /// Opens MovieDb Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTNTotalsSort_Click(object sender, EventArgs e)
        {
            //Creates and shows instance of movieDb form
            MovieDb movieDb = new MovieDb();
            movieDb.ShowDialog();
        }
    }
}

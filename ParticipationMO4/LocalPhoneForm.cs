using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParticipationMO4
{
    public partial class LocalPhoneForm : Form
    {
        /// <summary>
        /// Initializes LocalPhoneForm
        /// </summary>
        public LocalPhoneForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Saves Updates
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void phoneListTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.phoneListTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.localPhoneDBDataSet1);

        }

        /// <summary>
        /// Loads LocalPhoneForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LocalPhoneForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'localPhoneDBDataSet1.PhoneListTable' table. You can move, or remove it, as needed.
            this.phoneListTableTableAdapter.Fill(this.localPhoneDBDataSet1.PhoneListTable);

        }

        /// <summary>
        /// Sorts table by last name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_SortLN_Click(object sender, EventArgs e)
        {
            this.phoneListTableTableAdapter.SortByLastName(this.localPhoneDBDataSet1.PhoneListTable);
        }

        /// <summary>
        /// Sorts table to display those with age above 30
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Age30_Click(object sender, EventArgs e)
        {
            this.phoneListTableTableAdapter.FillByAge30(this.localPhoneDBDataSet1.PhoneListTable);
        }

        /// <summary>
        /// Displays average age of table entries
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_AvgAge_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"The Average Age is: {this.phoneListTableTableAdapter.AverageAge()}");
        }

        /// <summary>
        /// Resets the table to normal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            this.phoneListTableTableAdapter.Fill(this.localPhoneDBDataSet1.PhoneListTable);
        }

        /// <summary>
        /// Searches for entries using the search bar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Search_Click(object sender, EventArgs e)
        {
            this.phoneListTableTableAdapter.FillByFirstName(this.localPhoneDBDataSet1.PhoneListTable, TxtBox_FirstName.Text);

        }
    }
}

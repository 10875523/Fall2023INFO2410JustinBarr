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
    public partial class LandingForm : Form
    {
        /// <summary>
        /// Initializes LandingForm
        /// </summary>
        public LandingForm()
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

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'localPhoneDBDataSet1.PhoneListTable' table. You can move, or remove it, as needed.
            this.phoneListTableTableAdapter.Fill(this.localPhoneDBDataSet1.PhoneListTable);

        }

        /// <summary>
        /// Opens Local Numbers form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLocalNums_Click(object sender, EventArgs e)
        {
            //Creates and shows instance of localPhoneForm
            LocalPhoneForm localPhoneForm = new LocalPhoneForm();
            localPhoneForm.ShowDialog();
        }

        /// <summary>
        /// Opens the importednums Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnImportedNums_Click(object sender, EventArgs e)
        {
            //Creates and shows instance of ImportedPhoneForm
            ImportedPhoneForm frm = new ImportedPhoneForm();
            frm.ShowDialog();
        }

        /// <summary>
        /// Opens OnlineNums Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOnlineNums_Click(object sender, EventArgs e)
        {
            //Creates and shows instance of OnlinePhoneForm
            OnlinePhoneForm frm = new OnlinePhoneForm();
            frm.ShowDialog();
        }

        /// <summary>
        /// Quits application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClose_Click(object sender, EventArgs e)
        {
            //Closes application
            Close();
        }
    }
}

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
        public LandingForm()
        {
            InitializeComponent();
        }

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

        //Please work

        private void BtnLocalNums_Click(object sender, EventArgs e)
        {
            LocalPhoneForm localPhoneForm = new LocalPhoneForm();
            localPhoneForm.ShowDialog();
        }

        private void BtnImportedNums_Click(object sender, EventArgs e)
        {

        }

        private void BtnOnlineNums_Click(object sender, EventArgs e)
        {

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class OnlinePhoneForm : Form
    {
        /// <summary>
        /// Initializes OnlinePhoneForm
        /// </summary>
        public OnlinePhoneForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Saves updates
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uVUPhoneNumsTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.uVUPhoneNumsTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iNFO2200_CrandallSayDataSet);

        }

        /// <summary>
        /// Loads OnlinePhoneForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnlinePhoneForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iNFO2200_CrandallSayDataSet.UVUPhoneNumsTable' table. You can move, or remove it, as needed.
            this.uVUPhoneNumsTableTableAdapter.Fill(this.iNFO2200_CrandallSayDataSet.UVUPhoneNumsTable);

        }

        /// <summary>
        /// Displays the OnlineSummaryForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Summary_Click(object sender, EventArgs e)
        {
            OnlineSummaryForm frm = new OnlineSummaryForm();
            frm.ShowDialog();
        }
    }
}

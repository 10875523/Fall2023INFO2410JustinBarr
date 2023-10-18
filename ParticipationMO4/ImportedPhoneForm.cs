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
    public partial class ImportedPhoneForm : Form
    {
        public ImportedPhoneForm()
        {
            InitializeComponent();
        }

        private void uvuPhoneDirectoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.uvuPhoneDirectoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uVUPhoneNumsWorksDataSet);

        }

        private void ImportedPhoneForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uVUPhoneNumsWorksDataSet.UvuPhoneDirectory' table. You can move, or remove it, as needed.
            this.uvuPhoneDirectoryTableAdapter.Fill(this.uVUPhoneNumsWorksDataSet.UvuPhoneDirectory);

        }
    }
}

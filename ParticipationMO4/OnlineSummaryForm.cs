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
    public partial class OnlineSummaryForm : Form
    {
        public OnlineSummaryForm()
        {
            InitializeComponent();
        }

        private void OnlineSummaryForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iNFO2200_CrandallSaySP.UVUPhoneNumbersSP' table. You can move, or remove it, as needed.
            this.uVUPhoneNumbersSPTableAdapter.Fill(this.iNFO2200_CrandallSaySP.UVUPhoneNumbersSP);

        }
    }
}

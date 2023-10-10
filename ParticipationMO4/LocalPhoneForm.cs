﻿using System;
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
        public LocalPhoneForm()
        {
            InitializeComponent();
        }

        private void phoneListTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.phoneListTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.localPhoneDBDataSet1);

        }

        private void LocalPhoneForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'localPhoneDBDataSet1.PhoneListTable' table. You can move, or remove it, as needed.
            this.phoneListTableTableAdapter.Fill(this.localPhoneDBDataSet1.PhoneListTable);

        }
    }
}

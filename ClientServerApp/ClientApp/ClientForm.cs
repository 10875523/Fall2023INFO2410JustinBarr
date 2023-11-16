using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApp
{
    public partial class ClientForm : Form
    {

        SynchronousSocketClient client = new SynchronousSocketClient(); 

        public ClientForm()
        {
            InitializeComponent();
        }

        private void BTNSend_Click(object sender, EventArgs e)
        {
           TXTResponse.Text = client.ContactServer(TXTRequest.Text);
        }
    }
}

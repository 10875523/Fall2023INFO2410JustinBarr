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
        // Create an instance of the SynchronousSocketClient class
        SynchronousSocketClient client = new SynchronousSocketClient();

        // Constructor for the ClientForm class
        public ClientForm()
        {
            InitializeComponent();
        }

        // Event handler for the button click event
        private void BTNSend_Click(object sender, EventArgs e)
        {
            // Call the ContactServer method of the SynchronousSocketClient class with the text from TXTRequest
            // Set the text of TXTResponse to the result of the server communication
            TXTResponse.Text = client.ContactServer(TXTRequest.Text);
        }
    }
}

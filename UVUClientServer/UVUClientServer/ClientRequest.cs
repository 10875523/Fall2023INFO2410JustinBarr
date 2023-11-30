using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UVUClientServer
{
    public partial class ClientRequest : Form
    {
        // Constants for server connection
        private const string ServerIp = "127.0.0.1"; // Replace with your server's IP address
        private const int ServerPort = 11000;

        /// <summary>
        /// Constructor for the form
        /// </summary>
        public ClientRequest()
        {
            // Initializes Form
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for the "Submit" button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTNSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                // Using statement ensures proper disposal of resources (TcpClient and NetworkStream)
                using (TcpClient client = new TcpClient(ServerIp, ServerPort))
                using (NetworkStream stream = client.GetStream())
                {
                    // Get the user's request from the TextBox
                    string request = TXTRequest.Text;

                    // Convert the request string into a byte array using UTF-8 encoding
                    byte[] requestData = Encoding.UTF8.GetBytes(request);

                    // Send the request to the server
                    stream.Write(requestData, 0, requestData.Length);

                    // Receive the server's response
                    byte[] buffer = new byte[1024];
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);

                    // Convert the received byte array back to a string (decoding)
                    string response = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                    // Display the server's response in the multiline TextBox
                    DisplayResponse(response);
                }
            }
            // Error handling
            catch (Exception ex)
            {
                // Display an error message if an exception occurs
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Display the server's response in the multiline TextBox
        /// </summary>
        /// <param name="response"></param>
        private void DisplayResponse(string response)
        {
            TXTBoxResponse.Text = response;
        }
    }
}

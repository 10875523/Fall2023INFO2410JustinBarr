using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace ClientApp
{
    public class SynchronousSocketClient
    {
        // Server IP address and port number
        const string IP_ADDRESS = "127.0.0.1";
        const int PORT_NUM = 11000;

        // Method to contact the server synchronously
        public string ContactServer(string userRequest)
        {
            // Variable to store the server's response
            string responseString = "";

            try
            {
                // Create a new TCP client
                TcpClient client = new TcpClient();

                // Connect to the server using the specified IP address and port number
                client.Connect(IPAddress.Parse(IP_ADDRESS), PORT_NUM);

                // Get the network stream for sending and receiving data
                NetworkStream stream = client.GetStream();

                // Create a StreamWriter to write data to the network stream
                StreamWriter streamWriter = new StreamWriter(stream);

                // Create a StreamReader to read data from the network stream
                StreamReader streamReader = new StreamReader(stream);

                // Write the user request to the server
                streamWriter.WriteLine(userRequest);
                streamWriter.Flush(); // Ensure that the data is sent to the server immediately

                // Read the response from the server
                responseString = streamReader.ReadLine();

                // Close the StreamReader, StreamWriter, and NetworkStream
                streamReader.Close();
                streamWriter.Close();
                stream.Close();

                // Close the TCP client
                client.Close();
            }
            catch (Exception ex)
            {
                // If an exception occurs, set the response string to the error message
                responseString = ex.Message;
            }

            // Return the server's response or the error message
            return responseString;
        }
    }
}

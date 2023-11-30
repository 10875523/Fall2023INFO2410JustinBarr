using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UVUResponseServer
{
    internal class Program
    {
        // Port on which the server will listen for incoming connections
        private const int Port = 11000;

        // Path to the UVUFacts.txt file
        private static readonly string UVUFactsFilePath = "UVUFacts.txt";

        // Path to the UVUCourseDescriptions.txt file
        private static readonly string UVUMajorsFilePath = "UVUCourseDescriptions.txt";

        /// <summary>
        /// Runs when application is opened
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            try
            {
                // Set up a TCP listener on port 11000
                TcpListener listener = new TcpListener(IPAddress.Any, Port);
                listener.Start();

                // Display what port is being used
                Console.WriteLine("Server listening on port 11000...");

                while (true)
                {
                    // Accept incoming client connections
                    TcpClient client = listener.AcceptTcpClient();

                    // Handle client request on a separate thread or task if needed
                    ProcessClientRequest(client);

                    // Close the client connection
                    client.Close();
                }
            }
            catch (Exception ex)
            {
                // Display an error message if an exception occurs
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        /// <summary>
        /// Recieves request from client, and processes it
        /// </summary>
        /// <param name="client"></param>
        private static void ProcessClientRequest(TcpClient client)
        {
            try
            {
                using (NetworkStream stream = client.GetStream())
                {
                    // Read the client's request from the network stream
                    byte[] buffer = new byte[1024];
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    string request = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                    // Get the server's response based on the client's request
                    string response = GetServerResponse(request);

                    // Convert the response to a byte array
                    byte[] responseData = Encoding.UTF8.GetBytes(response);

                    // Send the response back to the client
                    stream.Write(responseData, 0, responseData.Length);

                    // Display the received request and sent response in the console
                    Console.WriteLine($"Received from client: {request}");
                    Console.WriteLine($"Sending to client: {response}");
                }
            }
            catch (Exception ex)
            {
                // Display an error message if an exception occurs during processing
                Console.WriteLine("Error processing client request: " + ex.Message);
            }
        }

        /// <summary>
        /// Gets a response from the proper txt file based on client request
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        private static string GetServerResponse(string request)
        {
            try
            {
                // Create an instance of UVUResponse
                UVUResponse uvuResponse = new UVUResponse(UVUFactsFilePath, UVUMajorsFilePath);

                // Use the instance to get the appropriate response
                string response = uvuResponse.GetUVUResponse(request);

                return response;
            }
            catch (Exception ex)
            {
                // Display an error message if an exception occurs during response generation
                Console.WriteLine($"Error getting server response: {ex.Message}");
                return "Error processing request.";
            }
        }
    }
}

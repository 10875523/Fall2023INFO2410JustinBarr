using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace ServerApp
{
    public class SynchronousSocketListener
    {
        // Constants for the server IP address, port, and request types
        const int PORT = 11000;
        const string IP_ADDRESS = "127.0.0.1";
        const string JOKE = "JOKE";
        const string CONSPIRACY = "CONSPIRACY";

        // Instance of the ServerData class for handling server-side data
        ServerData serverData = new ServerData();

        // TcpListener to listen for incoming socket connections
        TcpListener tcpListener;

        // Constructor for the SynchronousSocketListener class
        public SynchronousSocketListener()
        {
            // Load files or perform any necessary initialization in the ServerData class
            serverData.LoadFiles();
        }

        // Method to start listening for incoming socket connections
        public void StartListening()
        {
            // Parse the IP address
            IPAddress iPAddress = IPAddress.Parse(IP_ADDRESS);

            // Create a TcpListener with the specified IP address and port
            tcpListener = new TcpListener(iPAddress, PORT);

            // Start listening for incoming connections
            tcpListener.Start();

            // Create a new thread to process incoming socket connections
            Thread thread = new Thread(new ThreadStart(ProcessSocket));
            thread.Start();
        }

        // Method to process incoming socket connections
        private void ProcessSocket()
        {
            Socket socket = null;
            while (true)
            {
                try
                {
                    // Accept an incoming socket connection
                    socket = tcpListener.AcceptSocket();

                    // Get the network stream for sending and receiving data
                    NetworkStream stream = new NetworkStream(socket);

                    // Create a StreamWriter to write data to the network stream
                    StreamWriter writer = new StreamWriter(stream);

                    // Create a StreamReader to read data from the network stream
                    StreamReader streamReader = new StreamReader(stream);

                    // Enable auto-flushing for the StreamWriter
                    writer.AutoFlush = true;

                    // Read the user data from the network stream
                    string userData = streamReader.ReadLine();
                    Console.WriteLine(userData);

                    // Process the user data based on the request type
                    if (userData.ToUpper() == JOKE)
                    {
                        Console.WriteLine(serverData.GetRandomJoke());
                    }
                    else if (userData.ToUpper() == CONSPIRACY)
                    {
                        Console.WriteLine(serverData.GetRandomConspiracy());
                    }
                    else
                    {
                        Console.WriteLine($"Could not do anything with {userData}");
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions that may occur during socket processing
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}

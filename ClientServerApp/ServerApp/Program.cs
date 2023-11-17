using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerApp
{
    internal class Program
    {
        // Entry point of the program
        static void Main(string[] args)
        {
            // Display a message indicating that the server is starting
            Console.WriteLine("Starting Server...");

            // Create an instance of the ServerData class
            ServerData server = new ServerData();

            // Load files or perform any necessary initialization in the ServerData class
            server.LoadFiles();

            // Output a random conspiracy and joke (assuming these methods are implemented in ServerData)
            Console.WriteLine(server.GetRandomConspiracy());
            Console.WriteLine(server.GetRandomJoke());

            // Start listening for incoming client connections
            SynchronousSocketListener listener = new SynchronousSocketListener();
            listener.StartListening();
        }
    }
}

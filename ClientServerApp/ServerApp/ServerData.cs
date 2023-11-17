using System;
using System.Collections.Generic;
using System.IO;

namespace ServerApp
{
    public class ServerData
    {
        // Constants for file names
        const string JOKE_FILE = "jokes.txt";
        const string CONSPIRACIES_FILE = "conspiracies.txt";

        // Arrays to store all jokes and conspiracies
        string[] allJokes;
        string[] allConspiracies;

        // Random instance for selecting random jokes and conspiracies
        Random rand = new Random();

        // Method to load joke and conspiracy data from files
        public void LoadFiles()
        {
            try
            {
                // Read all lines from the jokes and conspiracies files
                allJokes = File.ReadAllLines(JOKE_FILE);
                allConspiracies = File.ReadAllLines(CONSPIRACIES_FILE);
            }
            catch (Exception ex)
            {
                // Handle exceptions that may occur during file reading
                Console.WriteLine(ex.Message);
            }
        }

        // Method to get a random joke
        public string GetRandomJoke()
        {
            // Return a random joke from the array
            return allJokes[rand.Next(allJokes.Length)];
        }

        // Method to get a random conspiracy
        public string GetRandomConspiracy()
        {
            // Return a random conspiracy from the array
            return allConspiracies[rand.Next(allConspiracies.Length)];
        }
    }
}

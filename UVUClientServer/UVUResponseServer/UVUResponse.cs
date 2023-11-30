using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UVUResponseServer
{
    public class UVUResponse
    {
        // Lists to store UVU facts and majors
        private List<string> uvuFacts;
        private List<string> uvuMajors;

        // Random number generator for selecting random facts and majors
        private Random random;

        /// <summary>
        /// Constructor that initializes UVU facts, majors, and the random number generator
        /// </summary>
        /// <param name="factsFilePath"></param>
        /// <param name="majorsFilePath"></param>
        public UVUResponse(string factsFilePath, string majorsFilePath)
        {
            // Load UVU facts and majors from files
            uvuFacts = ReadFile(factsFilePath);
            uvuMajors = ReadFile(majorsFilePath);

            // Initialize random number generator
            random = new Random();
        }

        /// <summary>
        /// Method to read lines from a file and return them as a list of strings
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        private List<string> ReadFile(string filePath)
        {
            try
            {
                // Read all lines from the specified file and convert to a list of strings
                return File.ReadAllLines(filePath).ToList();
            }
            catch (Exception ex)
            {
                // Display an error message if there's an issue reading the file
                Console.WriteLine($"Error reading file {filePath}: {ex.Message}");

                // Return an empty list in case of an error
                return new List<string>();
            }
        }

        /// <summary>
        /// Method to get a UVU response based on the client's request
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public string GetUVUResponse(string request)
        {
            // Determine the type of response based on the client's request
            switch (request)
            {
                case "UVUFact":
                    return GetRandomFact();
                case "UVUMajor":
                    return GetRandomMajor();
                default:
                    // Return the original request if it doesn't match known types
                    return request;
            }
        }

        /// <summary>
        /// Method to get a random UVU fact
        /// </summary>
        /// <returns></returns>
        private string GetRandomFact()
        {
            // Check if there are facts available
            if (uvuFacts.Count > 0)
            {
                // Generate a random index to select a fact
                int randomIndex = random.Next(uvuFacts.Count);
                // Return the randomly selected fact
                return uvuFacts[randomIndex];
            }
            else
            {
                // Return a message if no facts are available
                return "No UVU facts available.";
            }
        }

        /// <summary>
        /// Method to get a random UVU major
        /// </summary>
        /// <returns></returns>
        private string GetRandomMajor()
        {
            // Check if there are majors available
            if (uvuMajors.Count > 0)
            {
                // Generate a random index to select a major
                int randomIndex = random.Next(uvuMajors.Count);
                // Return the randomly selected major
                return uvuMajors[randomIndex];
            }
            else
            {
                // Return a message if no majors are available
                return "No UVU majors available.";
            }
        }
    }
}
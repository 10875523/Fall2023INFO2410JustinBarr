using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barr_Justin_PP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Welcome message
            Console.WriteLine("Welcome to the College Search App!");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine();

            //Get user input
            Console.WriteLine("Please enter a college and I will return the city. (x to exit, random to get a Random College/City)");
            Console.Write("College:");
            string userInput = Console.ReadLine();

            //Initialize dictionary
            Dictionary<string, string> collegeDict = new Dictionary<string, string>();

            //Open collegecities.txt file
            StreamReader reader = new StreamReader("collegecities.txt");

            //Read through each line in file, separate at the comma delimiter, add separated line to dictionary, close file
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] tempCollege = line.Split(',');
                string state = tempCollege[0];
                string capital = tempCollege[1];
                collegeDict.Add(state.ToUpper(), capital.ToUpper());
            }
            reader.Close();

            //Ensure user does not want to quit
            while (userInput != "x")
            {
                //If user input is in the dictionary, return the proper city data
                if (collegeDict.TryGetValue(userInput.ToUpper(), out string city))
                {
                    Console.WriteLine($"The city of {userInput.ToUpper()} is {city}");
                    Console.WriteLine();
                }
                //If user input is "random", return a random entry from dictionary
                else if(userInput == "random")
                {
                    //Create an instance of the random class and have it pick from dictionary
                    var rand = new Random();
                    int picker = rand.Next(1 , collegeDict.Count() - 1);
                    string key = collegeDict.Keys.ElementAt(picker);
                    string value = collegeDict[key];

                    //Return the randomly chosen key and value from dictionary to console
                    Console.WriteLine($"Random College: {key}, City: {value}");
                    Console.WriteLine();
                }
                //If user input isn't in the dictionary, state as such
                else
                {
                    Console.WriteLine($"No results were found for {userInput}");
                    Console.WriteLine();
                }

                //Ensure repeatability of code until user exits
                Console.WriteLine("Please enter a college and I will return the city. (x to exit, random to get a Random College/City)");
                Console.Write("College: ");
                userInput = Console.ReadLine();
            }
        }
    }
}

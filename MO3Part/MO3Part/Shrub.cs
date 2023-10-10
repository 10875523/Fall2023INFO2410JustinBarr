using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MO3Part
{
    /// <summary>
    /// Creates shrub class with methods, a child of plant class
    /// </summary>
    public class Shrub : Plant
    {
        /// <summary>
        /// Creates an instance of Shrub class from the parent plant class
        /// </summary>
        /// <param name="type">User input from combobox</param>
        /// <param name="environment">User input from combobox</param>
        /// <param name="name">User input</param>
        public Shrub(string type, string environment, string name) : base(type, environment, name)
        {
        }

        /// <summary>
        /// Overrides the parent sniff function from plant class
        /// </summary>
        /// <returns>A string</returns>
        public override string Sniff()
        {
            //Returns a string
            return "Shrubs smell good.";
        }
    }
}

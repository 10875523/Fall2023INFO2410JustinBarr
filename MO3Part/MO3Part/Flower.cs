using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MO3Part
{
    /// <summary>
    /// Creates Flower class with methods, a child of the plant class
    /// </summary>
    public class Flower : Plant
    {

        /// <summary>
        /// Creates instance of Flower class referencing the plant class
        /// </summary>
        /// <param name="type">User input from combobox</param>
        /// <param name="environment">User input from combobox</param>
        /// <param name="name">User input</param>
        public Flower(string type, string environment, string name) : base(type, environment, name)
        {

        }

        /// <summary>
        /// Overrides the parent sniff function
        /// </summary>
        /// <returns>A string</returns>
        public override string Sniff()
        {
            //Returns string
            return "Roses really smell like garbage.";
        }
    }
}

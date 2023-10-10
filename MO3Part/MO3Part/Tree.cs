using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MO3Part
{
    /// <summary>
    /// Creates tree class with methods, a child of plant class
    /// </summary>
    public class Tree : Plant
    {
        /// <summary>
        /// Creates an instance of tree class through the plant class
        /// </summary>
        /// <param name="type">User input from combobox</param>
        /// <param name="environment">User input from combobox</param>
        /// <param name="name">User input</param>
        public Tree(string type, string environment, string name) : base(type, environment, name)
        {
        }

        /// <summary>
        /// Overrides parent sniff class from plant class
        /// </summary>
        /// <returns>String</returns>
        public override string Sniff()
        {
            //Returns string
            return "Trees smell good.";
        }
    }
}

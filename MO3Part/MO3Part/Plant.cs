using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MO3Part
{
    /// <summary>
    /// Creates Plant class with methods
    /// </summary>
    public abstract class Plant
    {
        //Private variables for instance creation
        private string _name;
        private string _type;
        private string _environment;

        /// <summary>
        /// Creates instance of plant class
        /// </summary>
        /// <param name="type">Selected from combobox selection</param>
        /// <param name="environment">selected from combobox selection</param>
        /// <param name="name">User input</param>
        public Plant(string type, string environment, string name)
        {
            //Sets private variables to the user input
            _name = name;
            _type = type;
            _environment = environment;
        }

        //Methods that return variables and set them equal to user input
        public string Name { get { return _name; } set { _name = value; } }
        public string Type { get { return _type; } set { _type = value; } }
        public string Environment { get { return _environment; } set { _environment = value; } }

        //Used in all child classes
        public abstract string Sniff();
    }
}

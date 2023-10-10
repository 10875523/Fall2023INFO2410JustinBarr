using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustinBarrTheAnimalFarmMO3
{
    /// <summary>
    /// Makes Cat subclass from Animal base class
    /// </summary>
    public class Cat : Animal
    {
        /// <summary>
        /// Creates an instance of Cat subclass through the animal class
        /// </summary>
        public Cat() : base("Fur", "Catnip") { }

        /// <summary>
        /// Creates the Unique function for Cat subclass
        /// </summary>
        /// <returns></returns>
        public override string Unique()
        {
            //Returns string
            return "Catches Mice";
        }

        /// <summary>
        /// Overrides the Move function from animal class
        /// </summary>
        /// <returns></returns>
        public override string Move()
        {
            //Returns string
            return "Pounces gracefully";
        }
    }
}

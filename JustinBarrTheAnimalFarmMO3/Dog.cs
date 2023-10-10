using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustinBarrTheAnimalFarmMO3
{
    /// <summary>
    /// Makes the dog subclass using the base animal class
    /// </summary>
    public class Dog : Animal
    {
        /// <summary>
        /// Creates instance of Dog subclass through animal class
        /// </summary>
        public Dog() : base("Fur", "Meat") { }

        /// <summary>
        /// Creates the Unique function to go with dog subclass
        /// </summary>
        /// <returns></returns>
        public override string Unique()
        {
            //Returns string
            return "Play Fetch!";
        }

        /// <summary>
        /// Overrides the Move function from animal class
        /// </summary>
        /// <returns></returns>
        public override string Move()
        {
            //Returns string
            return "Runs on four legs";
        }
    }
}

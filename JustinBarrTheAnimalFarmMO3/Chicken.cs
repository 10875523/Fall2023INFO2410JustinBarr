using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustinBarrTheAnimalFarmMO3
{
    /// <summary>
    /// Makes Chicken subclass from the Animal base class
    /// </summary>
    public class Chicken : Animal
    {
        /// <summary>
        /// Creates instance of Chicken subclass through the animal class
        /// </summary>
        public Chicken() : base("Feathers", "Seeds") { }

        /// <summary>
        /// Creates Unique function for the Chicken subclass
        /// </summary>
        /// <returns></returns>
        public override string Unique()
        {
            //Returns string
            return "Clucks loudly";
        }

        /// <summary>
        /// Overrides the Move function from animal class
        /// </summary>
        /// <returns></returns>
        public override string Move()
        {
            //Returns string
            return "Struts around";
        }
    }
}

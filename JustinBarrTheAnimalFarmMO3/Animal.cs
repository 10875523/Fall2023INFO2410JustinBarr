using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustinBarrTheAnimalFarmMO3
{
    /// <summary>
    /// Create abstract class
    /// </summary>
    public abstract class Animal
    {
        //Create variables
        public string SkinType { get; }
        public string FoodType { get; }

        /// <summary>
        /// Make animal class with proper parameters
        /// </summary>
        /// <param name="skinType"></param>
        /// <param name="foodType"></param>
        public Animal(string skinType, string foodType)
        {
            //Set variables to passed parameters
            SkinType = skinType;
            FoodType = foodType;
        }

        /// <summary>
        /// Defines how animal eats
        /// </summary>
        /// <returns></returns>
        public string Eat()
        {
            //Returns a string
            return "chomp chomp";
        }

        /// <summary>
        /// Defines how an animal moves, is adaptable to subclass
        /// </summary>
        /// <returns></returns>
        public virtual string Move()
        {
            //Returns string
            return "hippity hop";
        }

        /// <summary>
        /// Defines how an animal reproduces
        /// </summary>
        /// <returns></returns>
        public string Reproduce()
        {
            //Returns string
            return "create offspring";
        }

        //Creates a string method to be used by subclasses
        public abstract string Unique();
    }

}

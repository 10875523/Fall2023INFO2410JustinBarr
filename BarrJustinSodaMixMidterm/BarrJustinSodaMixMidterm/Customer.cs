using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarrJustinSodaMixMidterm
{
    public class Customer
    {
        //Create readable and writable variables for creation
        public string Name { get; set; }
        public int Score { get; set; }

        /// <summary>
        /// Makes Customer
        /// </summary>
        /// <param name="name"></param>
        /// <param name="score"></param>
        public Customer(string name, int score)
        {
            //Sets variables equal to passed through variables
            Name = name;
            Score = score;
        }
    }

}

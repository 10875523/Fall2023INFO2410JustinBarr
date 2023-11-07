using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarrJustinSodaMixMidterm
{
    public class QuickSort
    {
        /// <summary>
        /// Calls the private sort method
        /// </summary>
        /// <param name="customers">An instance of the customer function</param>
        public static void Sort(Customer[] customers)
        {
            Sort(customers, 0, customers.Length - 1);
        }

        /// <summary>
        /// Sorts the customer array from highest to lowest
        /// </summary>
        /// <param name="customers">An instance of the customer function</param>
        /// <param name="low">The index of the first element in the array</param>
        /// <param name="high">The index of the last element in the array</param>
        private static void Sort(Customer[] customers, int low, int high)
        {
            //Ensure that there is something to sort
            if (low < high)
            {
                //Call the Partition function and set results to an int called pivot
                int pivot = Partition(customers, low, high);
                //Sorts the customers in two haves
                Sort(customers, low, pivot - 1);
                Sort(customers, pivot + 1, high);
            }
        }

        /// <summary>
        /// Partitions the subarray finding a pivot point
        /// </summary>
        /// <param name="customers">An instance of the customer class</param>
        /// <param name="low">The index of the first element in the array</param>
        /// <param name="high">The index of the last element in the array</param>
        /// <returns></returns>
        private static int Partition(Customer[] customers, int low, int high)
        {
            //Select the pivot element
            int pivot = customers[high].Score;
            int i = (low - 1);

            //Iterate over the elements in the subarray
            for (int j = low; j < high; j++)
            {
                //If an element is smaller than the pivot, swap it with the element at index 'i + 1'
                if (customers[j].Score >= pivot)
                {
                    i++;
                    //Call Swap Method
                    Swap(customers, i, j);
                }
            }

            //Swap the pivot with the element at index 'i + 1' to place it in its correct sorted position
            Swap(customers, i + 1, high);
            // Return the index of the pivot
            return i + 1;
        }

        /// <summary>
        /// Swaps two elements in the array
        /// </summary>
        /// <param name="customers">An instance of the Customer class</param>
        /// <param name="index1">Index of Customer array</param>
        /// <param name="index2">Index of Customer array</param>
        private static void Swap(Customer[] customers, int index1, int index2)
        {
            //Create a temporary customer to swap
            Customer temp = customers[index1];
            //Swap the first index with the second
            customers[index1] = customers[index2];
            //Swap the second index with the temporary customer
            customers[index2] = temp;
        }
    }

}

using BarrJustinSodaMixMidterm;
using System;

class Program
{
    static void Main(string[] args)
    {
        //Create an array of customers from an instance of the customer class
        Customer[] customers = {
            new Customer("Jim", 34),
            new Customer("Anne", 71),
            new Customer("Paul", 14),
            new Customer("Kodey", 99),
            new Customer("Kameron", 81),
            new Customer("Lisa", 45),
            new Customer("Jan", 5)
        };

        //Call the QuickSort Class and sort the customers
        QuickSort.Sort(customers);

        //Print to the Console the results
        Console.WriteLine("\nSorted Customers (by Score in Descending Order):");
        PrintCustomers(customers);

        //Make the results visible until the user is done
        Console.WriteLine("\nPress enter to exit");
        Console.ReadLine();
    }

    /// <summary>
    /// Prints the customers in a formatted line
    /// </summary>
    /// <param name="customers"></param>
    static void PrintCustomers(Customer[] customers)
    {
        //Loop through every customer in the array
        foreach (var customer in customers)
        {
            //Write the customer name and score
            Console.WriteLine($"Name: {customer.Name}, Score: {customer.Score}");
        }
    }
}


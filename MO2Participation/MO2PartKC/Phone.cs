using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MO2PartKC
{
  public class Phone
  {
    /// <summary>
    /// Disects a string array to have variables
    /// </summary>
    /// <param name="tempPhone">Create string array</param>
    public Phone(string[] tempPhone) 
    {
      //Sets variables to different parts of the string array
      Make = tempPhone[0];
      Model = tempPhone[1];
      Display = tempPhone[2];
      Storage = tempPhone[3];
      Price = decimal.Parse(tempPhone[4]);
    }
    
    //Create read and write variables for phone class
    public string Make { get; set; }
    public string Model { get; set; }
    public string Display { get; set; }
    public string Storage { get; set; }
    public decimal Price { get; set; }
  }
}

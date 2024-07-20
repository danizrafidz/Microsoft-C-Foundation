using System;

namespace Part3Module2
{
  class Program
  {
    static void Main(string[] args)
    {
      // SKU = Stock Keeping Unit. 
      // SKU value format: <product #>-<2-letter color code>-<size code>
      string sku = "03-BL-M";
      
      string[] product = sku.Split('-'); //{01, MN, L}
      
      string type = "";
      string color = "";
      string size = "";
      
      switch (product[0])
      {
          case "01":
              type = "Sweat shirt";
              break;
          case "02":
              type = "T-Shirt";
              break;
          case "03":
              type = "Sweat pants";
              break;
          default:
              type = "Other";
              break;
      }
      
      switch (product[1])
      {
          case "BL":
              color = "Black";
              break;
          case "MN":
              color = "Maroon";
              break;
          default:
              color = "White";
              break;
      }
      
      switch (product[2])
      {
          case "S":
              size = "Small";
              break;
          case "M":
              size = "Medium";
              break;
          case "L":
              size = "Large";
              break;
          default:
              size = "One Size Fits All";
              break;
      }
      
      Console.WriteLine($"Product: {size} {color} {type}");
  }
}

/*Output
Product: Large Maroon Sweat shirt
*/

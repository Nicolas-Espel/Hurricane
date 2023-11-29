//Nicolas Espel
using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("Please enter the wind speed to determine the hurricane category: ");
    double windSpeed = Convert.ToDouble(Console.ReadLine());

    if (windSpeed >= 157) {
      Console.WriteLine("Category 5 Hurricane");
    } else if (windSpeed >= 130) {
      Console.WriteLine("Category 4 Hurricane");
    } else if (windSpeed >= 111) {
      Console.WriteLine("Category 3 Hurricane");
    } else if (windSpeed >= 96) {
      Console.WriteLine("Category 2 Hurricane");
    } else if (windSpeed >= 74) {
      Console.WriteLine("Category 1 Hurricane");
    } else {
      Console.WriteLine("Not A Hurricane");
    }
  }
}
using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Please enter the wind speed in mph: ");
    double windSpeed = Convert.ToDouble(Console.ReadLine()); //converts the input to a double

    //make if else statement
      if (windSpeed >= 157) {
        Console.WriteLine("Category Five Hurricane");
      }
    else if (windSpeed >= 130) {
      Console.WriteLine("Category Four Hurricane"); 
    }
    else if (windSpeed >= 111) {
      Console.WriteLine("Category Three Hurricane");
    }
    else if (windSpeed >= 96) {
      Console.WriteLine("Category Two Hurricane");
    }
    else if (windSpeed >= 74) {
      Console.WriteLine("Category One Hurricane");
    }
    else { 
      Console.WriteLine("Not a Hurricane");
    }
  }

  }

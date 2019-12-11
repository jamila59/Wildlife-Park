using System;
using System.Collections.Generic;


namespace Animal.Tracker {

  class Program {

    public static void Main()
    {
      Console.WriteLine(Animal.MakeAnimalSounds("dog", "ruff ruff"));

      Animal monkey = new Animal("monkey", 7, "Woodland Park Zoo");
      Animal donkey = new Animal("donkey", 2, "Beach Monkey");
      Animal cougar = new Animal("cougar", 6, "Cougar Mountain Zoo");

      cougar.SetAge(12);
      Console.WriteLine(cougar.PrintProperties());
      Console.WriteLine(donkey.PrintProperties());

      Console.WriteLine(monkey.GetAnimalType());
      Console.WriteLine(monkey.GetAge()); 
      Console.WriteLine(monkey.GetLocation());
    }
  }
}

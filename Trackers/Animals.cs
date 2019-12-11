using System;


namespace Animal.Tracker {

  class Animal {

    private string _animalType;
    private int _age;
    private string _location;

    public Animal(string animalType, int age, string location)
    { 
      _animalType = animalType;
      _age = age;
      _location = location;
    }

    public string GetAnimalType()
    {
      return _animalType;
    }

    public int GetAge()
    {
      return _age;
    }

    public void SetAge(int newAge)
    {
      _age = newAge;
    }

    public string GetLocation()
    {
      return _location;
    }

    public string PrintProperties()
    {
      string animalProperties = "Type of animal: " + this._animalType + " Age: " + this._age + " Location: " + this._location;
      return animalProperties;
    }

    public static string MakeAnimalSounds(string animal, string sounds)
    {
      return "An " + animal + " makes these sounds... " + sounds;
    }

  }

}
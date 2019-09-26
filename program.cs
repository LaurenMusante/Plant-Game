using System; //frontEnd 
using myHouse; 

class Program
{
    //Main is the method where the game is actually happening. When the code is run, the Main method is the entry point. It's the first thing the computer looks for and runs. 
    static void Main()
  {
      //use parenthesis because we are calling constructor method:
    Plant myPlant = new Plant();
    //here we are using myPlant as our plantrameter. We are calling the below method now, in the main. We created showPlantStats to dry up the code...prevents us from having to repeat "Console.WriteLine" every time we want to show the plant stats.
    ShowPlantStats(myPlant);
    Console.WriteLine("To water your plant, press 'w'; to sun your plant, press 's'");
    string userAnswer = Console.ReadLine();
    if (userAnswer.ToLower() == "w" || userAnswer.ToLower() == "water")
    {
        myPlant.Water();
        Console.WriteLine("You watered your plant! Your plant's new height is " + myPlant.Height);
    }
    else if (userAnswer.ToLower() == "s" || userAnswer.ToLower() == "sun")
    {
        string health = myPlant.GiveSunshine();
        Console.WriteLine("You sunned your plant! Your plant's new health is " + health);
    }
  }
  //"Plant" is telling the method what data type the argument will be. 
  public static void ShowPlantStats(Plant plantrameter)
  {
    Console.WriteLine("Your plant's health level: " + plantrameter.Health);
    Console.WriteLine("Your plant's height: " + plantrameter.Height);
    Console.WriteLine("Your plant has " + plantrameter.Flowers + " flowers.");
  }
}
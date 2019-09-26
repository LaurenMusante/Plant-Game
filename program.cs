using System; //frontEnd 
using myHouse; 

class Program
{
  static void Main()
  {
      //use parenthesis because we are calling constructor method:
    Plant myPlant = new Plant();
    //here we are using myPlant as our plantrameter. We are calling the below method now, in the main. We created showPlantStats to dry up the code...prevents us from having to repeat "Console.WriteLine" every time we want to show the plant stats.
    ShowPlantStats(myPlant);
  }
  //"Plant" is telling the method what data type the argument will be. 
  public static void ShowPlantStats(Plant plantrameter)
  {
    Console.WriteLine("Your plant's health level: " + plantrameter.Health);
    Console.WriteLine("Your plant's height: " + plantrameter.Height);
    Console.WriteLine("Your plant has " + plantrameter.Flowers + " flowers.");

  }
}
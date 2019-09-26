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
    PromptUser(myPlant);

  }
  //"Plant" is telling the method what data type the argument will be. 
  public static void ShowPlantStats(Plant plantrameter)
  {
    Console.WriteLine("Your plant's health level: " + plantrameter.HealthArray[plantrameter.Health]);
    Console.WriteLine("Your plant's height: " + plantrameter.Height);
    Console.WriteLine("Flowers: " + plantrameter.printFlowers());
  }
  
//   this method has a new parameter of paramaplant, different than plantrameter because its a new method. however both are plant objects. when we call each of these method both will take in the argument myPlant.
  public static void PromptUser(Plant paramaPlant)
{
    Console.WriteLine("To water your plant, press 'w'; to sun your plant, press 's', to show your plant's description, press 'd'");
    string userAnswer = Console.ReadLine();
    
    if (userAnswer.ToLower() == "w" || userAnswer.ToLower() == "water")
    {
        paramaPlant.Water();
        if (paramaPlant.Height % 3 == 0)
        {
            paramaPlant.AddFlower();
            Console.WriteLine(paramaPlant.printFlowers());
        }
        Console.WriteLine("You watered your plant! Your plant's new height is " + paramaPlant.Height);
        PromptUser(paramaPlant);
    }
    else if (userAnswer.ToLower() == "s" || userAnswer.ToLower() == "sun")
    {
        string health = paramaPlant.GiveSunshine();
        Console.WriteLine("You sunned your plant! Your plant's new health is " + health);
        PromptUser(paramaPlant);
    }
    else if (userAnswer.ToLower() == "d" || userAnswer.ToLower() == "description")
    {
        ShowPlantStats(paramaPlant);
        PromptUser(paramaPlant);
    }
    else 
    {
        Console.WriteLine("Nice try! Go plant yourself!");
        PromptUser(paramaPlant);
    }
}

}
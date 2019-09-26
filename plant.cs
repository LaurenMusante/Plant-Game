using System; //backend

namespace myHouse 
{
    class Plant 
    {
        //public properties with auto-implements private backing fields:
        public int Health { get; set; }
        public string[] HealthArray { get; set; }
        public int Height { get; set; }
        public int Flowers { get; set; }

        //constructor (has to be the same name as the class):
        public Plant()
        {
            Health = 0;
            //to initialize an array, use this notation: Name of array equals:
            HealthArray = new string[] { "very withered", "withering", "ok", "doing well", "thriving", "mega-thriving", "living its best life", "now a 🌳 !" };
            Height = 1;
            Flowers = 0;
        }
        // You can tell this is a method because it's a different name than the class and contructor. Also, they have a return value, whereas classes and constructors do not. 
        public void Water()
        {
            Height++;
        }
        // When we GiveSunshine, we increase Health by 1. And then return HealthArray at index "Health", which is a number that coincide with the index of the array called HealthArray.
        public string GiveSunshine()
        {
            if (Health < 7) 
            {
                Health++;
            }
            return HealthArray[Health];
        }
        public void AddFlower()
        {
            Flowers++;
        }

        public string printFlowers()
        {
            string flowers = "";
            for (int i = 0; i < Flowers; i++)
            {
                flowers += "🌼 ";
            }
            if (flowers == "")
            {
                flowers = "none";
            }
            return flowers;
        }

    }
}
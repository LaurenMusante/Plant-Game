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
            Health = 2;
            //to initialize an array, use this notation: Name of array equals:
            HealthArray = new string[] { "very withered", "withering", "ok", "doing well", "thriving" };
            Height = 5;
            Flowers = 0;
        }
        // You can tell this is a method because it's a different name than the class and contructor. Also, they have a return value, whereas classes and constructors do not. 
        public void Water()
        {
            Height ++;
        }
        // When we GiveSunshine, we increase Health by 1. And then return HealthArray at index "Health", which is a number that coincide with the index of the array called HealthArray.
        public string GiveSunshine()
        {
            if (Health < 4) 
            {
            Health ++;
            }
            return HealthArray[Health];
        }

    }
}
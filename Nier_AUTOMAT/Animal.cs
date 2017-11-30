using System;
namespace Nier_AUTOMAT
{
    public abstract class Animal
    {
        public int Speed { get; set; }
        public double Strength { get; set; }

        
        public int[] Coordinates { get; set; }

        public Animal(int speed, double strength, int[] coordinates)
        {
            Speed = speed;
            Strength = strength;
            Coordinates = coordinates;

            
        }
        public Animal()
        {
        }
        public abstract void Move(Animal animal=null);
        public static void Hunt()
        {

           
        }
    }
}

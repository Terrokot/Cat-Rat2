using System;
using System.Threading;
namespace Nier_AUTOMAT
{
    public class TerroKot:Animal
    {
        public override void Move(Animal rat)
        {
            Random rand = new Random();
            int x = 0;
            int i = 0;
            while (!(Coordinates[0] == rat.Coordinates[0] && Coordinates[1] == rat.Coordinates[1]))
            {
                i++;
                x=rand.Next(0,4);
                if (x == 0)
                {
                    Coordinates[0] += Speed;
                    if (Coordinates[0] > 100)
                        Coordinates[0] = 0;
                }
                if (x == 1)
                {
                    Coordinates[0] -= Speed;
                    if (Coordinates[0] < 0)
                        Coordinates[0] = 100;
                }
                if (x == 2)
                {
                    Coordinates[1] += Speed;
                    if (Coordinates[1] > 100)
                        Coordinates[1] = 0;
                }
                if (x == 3)
                {
                    Coordinates[1] -= Speed;
                    if (Coordinates[1] < 0)
                        Coordinates[1] = 100;
                }
                //Console.Clear();
                Console.WriteLine($"Kot{Coordinates[0]},{Coordinates[1]}||Rat{rat.Coordinates[0]},{rat.Coordinates[1]}");
               // Thread.Sleep(50);
            }
            Console.WriteLine(i);
            Console.WriteLine("Ham-Ham");
            Environment.Exit(0);

        }


        public TerroKot(int speed, double strength,int[] coordinates):base(speed,strength,coordinates)
        {
        }
        public TerroKot()
        {
        }
    }
}

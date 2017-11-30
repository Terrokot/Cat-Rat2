using System;
using System.Threading;
namespace Nier_AUTOMAT
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            Console.ReadKey();
            TerroKot cat = new TerroKot(1, 2, new int[] { 5, 5 });
            Rat rat = new Rat(1, 1, new int[] { 6, 8 });
            h = RatMove;
            h.BeginInvoke(rat, null, null);
            cat.Move(rat);
            
        }

        public delegate void Test(Animal La);
        static Test h;

        public static void RatMove(Animal la)
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            la.Move();
        }

    }
}


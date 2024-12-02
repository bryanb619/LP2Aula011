using System;
using System.Threading;

namespace FrogRace
{
    public class Program
    {
        private static void Main(string[] args)
        {
           
            Thread t1, t2, t3;

            t1 = new Thread(FrogRun);
            t1.Name = "T_one";

            t2 = new Thread(FrogRun);
            t2.Name = "T_two";

            t3 = new Thread(FrogRun);
            t3.Name = "T_three";


            t1.Start(1);
            t2.Start(2);
            t3.Start(3);

            t3.Join();
            t2.Join();
            t1.Join();
        }

        private static void FrogRun(object frogNum)
        {

            int frogN = 0;

            try 
            {
                frogN = (int)frogNum;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            

            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                int timeToSleep = rand.Next(1001);

                Thread.Sleep(timeToSleep);

                Console.WriteLine($"Frog: {frogN} Jump: {i +1} Thread: {Thread.CurrentThread.Name}");
            }
        }
    }
}

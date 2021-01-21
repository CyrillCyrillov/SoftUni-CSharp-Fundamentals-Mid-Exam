using System;

namespace Task01_Bakery
{
    class Program
    {
        static void Main(string[] args)
        {
            int biscuitsPerWorkerPerDay = int.Parse(Console.ReadLine());
            int countOfWorkers = int.Parse(Console.ReadLine());
            int competingBiscuits = int.Parse(Console.ReadLine());

            double producedBiscuits = 0;
            int bisciutsPerDay = biscuitsPerWorkerPerDay * countOfWorkers;

            for (int i = 1; i <= 30; i++)
            {
                if(i % 3 == 0)
                {
                    producedBiscuits += Math.Floor(bisciutsPerDay * 0.75);
                }
                else
                {
                    producedBiscuits += bisciutsPerDay;
                }
            }

            Console.WriteLine($"You have produced {producedBiscuits} biscuits for the past month.");

            if(producedBiscuits > competingBiscuits)
            {
                Console.WriteLine($"You produce {((producedBiscuits - competingBiscuits) / competingBiscuits * 100):f2} percent more biscuits.");
            }
            else
            {
                Console.WriteLine($"You produce {((competingBiscuits - producedBiscuits) / competingBiscuits * 100):f2} percent less biscuits.");
            }
        }
    }
}

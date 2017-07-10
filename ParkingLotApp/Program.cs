using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ParkingLot newPL = new ParkingLot();
            Vehicle car = new Vehicle(1);
            Vehicle bus = new Vehicle(5);
            Vehicle bus2 = new Vehicle(5);
            int[,] lSpaces = newPL.BuildLSpaces();
            int[,] mSpaces = newPL.BuildMSpaces();
            int[,] comSpaces = newPL.BuildComSpaces();
            int totalSpaces = lSpaces.Length + mSpaces.Length + comSpaces.Length;
            Console.WriteLine($"there are {totalSpaces} spots in the garage.");


            car.Park(comSpaces);
            bus.Park(lSpaces);
            bus.Park(lSpaces);

            int w = comSpaces.GetLength(0);
            int h = comSpaces.GetLength(1);

            for (int x = 0; x < w; x++)
            {
                for (int y = 0; y < h; y++)
                {
                    Console.WriteLine(lSpaces[x, y]);
                }
            }

        }
    }
}

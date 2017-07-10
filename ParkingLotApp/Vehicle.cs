using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotApp
{
    class Vehicle
    {
        int size;

        public Vehicle(int size)
        {
            this.size = size;
        }

        public int[,] Park(int[,] lot)
        {
            int[,] pLot = lot;
            int vehicle = size;
            List<int> openSpot = FindSpot(pLot);
            Console.WriteLine(openSpot[0].ToString(), openSpot[1].ToString());

            if (vehicle == 1)
            {
                pLot[openSpot[0], openSpot[1]] = 1;
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    if (openSpot[0] + i < pLot.GetLength(0) && openSpot[1] + i < pLot.GetLength(1))
                    {
                        pLot.SetValue(1, openSpot[0] + i, openSpot[1] + i);
                    }
                    else if (i == 5)
                    {
                        Console.WriteLine("No more room!");
                    }
                }
            }


            return pLot;
        }

        public static List<int> FindSpot(int[,] lot)
        {
            List<int> coords = new List<int>();
            int[,] pLot = lot;
            int w = pLot.GetLength(0);
            int h = pLot.GetLength(1);

            for (int x = 0; x < w; x++)
            {
                for (int y = 0; y < h; y++)
                {
                    if (pLot[x, y].Equals(0))
                    {
                        coords.Add(x);
                        coords.Add(y);
                        return coords;
                    }
                }
            }
            coords.Add(-1);

            return coords;
            
        }
        
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotApp
{
    class ParkingLot
    {
        private int[,] comSpaces;
        private int[,] lSpaces;
        private int[,] mSpaces;
        private int numComSpace;
        private int numLSpaces;
        private int numMSpaces;
        private int levels;

        public ParkingLot()
        {
            numComSpace = SetComSpaces();
            numLSpaces = SetLSpaces();
            numMSpaces = SetMSpaces();
            levels = SetLevels();
            comSpaces = BuildComSpaces();
            lSpaces = BuildLSpaces();
            mSpaces = BuildMSpaces();
        }

        public int SetComSpaces()
        {
            string x;
            int y;

            Console.WriteLine("How many compact spaces are on each level of the garage?\n");
            x = Console.ReadLine();
            y = Validator.CheckInts(x);

            return y;
        }

        public int SetLSpaces()
        {
            string x;
            int y;

            Console.WriteLine("How many large spaces are on each level of the garage?\n");
            x = Console.ReadLine();
            y = Validator.CheckInts(x);

            return y;
        }

        public int SetMSpaces()
        {
            string x;
            int y;

            Console.WriteLine("How many motorcycle spots are on each level of the garage?\n");
            x = Console.ReadLine();
            y = Validator.CheckInts(x);

            return y;
        }

        public int SetLevels()
        {
            string x;
            int y;

            Console.WriteLine("How many levels are on each level of the garage?\n");
            x = Console.ReadLine();
            y = Validator.CheckInts(x);

            return y;
        }

        public int[,] BuildComSpaces()
        {
            comSpaces = new int[levels, numComSpace];

            return comSpaces;
        }

        public int[,] BuildLSpaces()
        {
            lSpaces = new int[levels, numLSpaces];

            return lSpaces;
        }

        public int[,] BuildMSpaces()
        {
            mSpaces = new int[levels, numMSpaces];

            return mSpaces;
        }
    }
}

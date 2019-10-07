using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brandon_Miranda_17610437_Assignment_1
{
    class Map
    {
        public string[,] GameMap = new string[20, 20];
        public Unit[] units = new Unit[10];

        Random Rnd = new Random();
        public void Makemap()
        {
            for (int y = 0; y < 20; y++)
            {
                for (int x = 0; x < 20; x++)
                {
                    GameMap[y, x] = " ";
                }
            }

        }
        public void FillMap()
        {
            SpawnUnit();
        }
        public void SpawnUnit()
        {
            switch (MeleeUnit, RangedUnit) // 1 hour down the line and i just couldnt figure it out, had to move on...
            {

                case 1: //Melee Unit
                {
                    int(k = 0; k < units.Length; k++)
                    {
                        Console.WriteLine(units[k].ToString());
                    }
                    units[k] = new MeleeUnit;
                    break;
                }
                case 2: //Range Unit
                {
                    int( k = 0; k < units.Length; k++)
                    {
                        Console.WriteLine(units[k].ToString());
                    }
                    units[k] = new RangeUnit;
                    break;
                }
            }// I feel asleep on my keyboard while working and lost huge portions of code not sure how but hey....

        }
    }
}

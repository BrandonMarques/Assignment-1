using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brandon_Miranda_17610437_Assignment_1
{
    class Game_Engine
    {
        public Map map = new Map();
        private void UnitTurn()
        {
            for (int k = 0; k < map.units.Length; k++) //Picks a unit for their turn
            {
                if (map.units[k] != null)
                {
                    //GameMap[map.units[k].YPosition, map.units[k].XPosition] = " ";
                    //this was to make sure when the player moves it leaves a blank space behind it but i couldnt quite get it work.... i left it here to show i tired

                    if (map.units[k].Hp > 0) //IF THE UNIT HAS NOT BEEN KILLED
                    {
                        if ((map.units[k].Hp / map.units[k].MaxHP) * 100 <= 25 / 100) //GENERAL AKBAR would be proud
                        {
                            map.units[k].Retreat();
                            if (map.units[k].InRangeOfEnemy(map.units[k].MovetoCLoseEnemy(map.units)) == true) //  must be in range for the attack will move too or away from enemy
                            {
                                for (int a = 0; a < map.units.Length; a++)
                                {
                                    if (map.units[a] == map.units[k].MovetoCLoseEnemy(map.units) && map.units[a] != null)
                                        map.units[a].Hp -= map.units[k].Attack();
                                }
                            }

                        }
                        else //mama never raise no quiter guess whos coming for youuuuuuuu
                        {
                            if (map.units[k].InRangeOfEnemy(map.units[k].MovetoCLoseEnemy(map.units)) == true) //Enemy is in range, Unit will attack
                            {
                                for (int a = 0; a < map.units.Length; a++)
                                {
                                    if (map.units[a] == map.units[k].MovetoCLoseEnemy(map.units) && map.units[a] != null)
                                        map.units[a].Hp -= map.units[k].Attack();
                                }
                            }
                            else //Go to closest enemy
                                map.units[k].MovetoCLoseEnemy(map.units[k].MoveToEnemy(map.units)); //not sure why this was happening i tried 2 other ways and they didnt work either this was the closest i could get without makign the whole page red :D
                        }

                        //GameMap[map.units[k].YPosition, map.units[k].XPosition] = map.units[k].Image; 
                        //This was supposed to change the player on the map to an image but i couldnt get it to work without red textinting everything.... 
                    }
                }
            }
        }
    }
}


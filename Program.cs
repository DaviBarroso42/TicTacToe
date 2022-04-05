using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {

            bool playAgain = true;

            char storePlaceValue = '.';

            int victoryH  = 0;
            int victoryV = 0;
            int victoryD = 0;
            int victoryD2 = 0;

            Char turn = 'X';
            bool switchTurn = true;
            Char[,] places = { { '1', '2', '3' }, {'4', '5', '6'}, {'7', '8', '9'} };

            while (playAgain)
            {
                Console.WriteLine("");
                Console.WriteLine(places[0, 0] + " | " + places[0, 1] + " | " + places[0, 2]);
                Console.WriteLine("-----------");
                Console.WriteLine(places[1, 0] + " | " + places[1, 1] + " | " + places[1, 2]);
                Console.WriteLine("-----------");
                Console.WriteLine(places[2, 0] + " | " + places[2, 1] + " | " + places[2, 2]);
                Console.WriteLine("");

                Console.Write(turn + " Turn - Choose a place: ");
                int place = Convert.ToInt32(Console.ReadLine());

                switch(place)
                {
                    case 1:
                        places[0, 0] = turn;
                    break;
                    case 2:
                        places[0, 1] = turn;
                        break;
                    case 3:
                        places[0, 2] = turn;
                        break;
                    case 4:
                        places[1, 0] = turn;
                        break;
                    case 5:
                        places[1, 1] = turn;
                        break;
                    case 6:
                        places[1, 2] = turn;
                        break;
                    case 7:
                        places[2, 0] = turn;
                        break;
                    case 8:
                        places[2, 1] = turn;
                        break;
                    case 9:
                        places[2, 2] = turn;
                        break;
                    default:
                        switchTurn = false;
                        break;
                }

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (places[i, i] == places[i, j])
                        {
                            victoryH++;
                        }
                        if (places[i, i] == places[j, i])
                        {
                            victoryV++;
                        }
                        if (places[i, i] == places[j, j])
                        {
                            victoryD++;
                        }
                        if (i + j == 2)
                        {
                            if (i == 0)
                            {
                                storePlaceValue = places[i, j];
                            }
                            else if (storePlaceValue == places[i, j])
                            {
                                victoryD2++;
                            }
                            else
                            {
                                victoryD2 = 0;
                            }
                        }

                    }

                    if (victoryH < 3 && victoryV < 3 && victoryD < 3 && victoryD2 < 2)
                    {
                        victoryH = 0;
                        victoryV = 0;
                        victoryD = 0;
                    }
                    else
                    {
                        playAgain = false;
                        break;
                    }
                }

                if (turn == 'X' && switchTurn && playAgain)
                {
                    turn = 'Y';
                }
                else if(switchTurn && playAgain)
                {
                    turn = 'X';
                }

                switchTurn = true;
                Console.Clear();

            }

            Console.WriteLine("");
            Console.WriteLine(places[0, 0] + " | " + places[0, 1] + " | " + places[0, 2]);
            Console.WriteLine("-----------");
            Console.WriteLine(places[1, 0] + " | " + places[1, 1] + " | " + places[1, 2]);
            Console.WriteLine("-----------");
            Console.WriteLine(places[2, 0] + " | " + places[2, 1] + " | " + places[2, 2]);
            Console.WriteLine("");

            Console.WriteLine("Thanks For Playing, Player " + turn + " Won!!");
            Console.ReadKey();
        }
    }
}

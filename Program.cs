using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {

            bool playAgain = true;

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

                if (turn == 'X' && switchTurn)
                {
                    turn = 'Y';
                }
                else if(switchTurn)
                {
                    turn = 'X';
                }

                switchTurn = true;
                Console.Clear();
            }

            Console.ReadKey();
        }
    }
}

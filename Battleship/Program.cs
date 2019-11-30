using System;

namespace Battleship
{
    class Program
    {
        static void Main(string[] args)
        {// build the grid and place the battleship (test)

            int x = 0;
            int y = 0;


            bool[,] grid = new bool[8, 8];

            // Console.WriteLine("Defensive Player: How many battle ships would you like to task to position?");
            // Int BS = Console.ReadLine()
            grid[1, 7] = true;
            grid[5, 5] = true;
            grid[7, 1] = true;

            {// print the grid
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (grid[i, j] == true)
                        {
                            Console.Write(" ~~ ");
                        }
                        else
                        {
                            Console.Write(" ~~ ");
                        }

                    }
                    Console.WriteLine();
                }
            }   //ask the user to select a coordinate

            int ships = 3;
            // replace this with keep looping while (grid[x, y] == false)   
            {
            again:
                Console.WriteLine("Please choose your X coordinate");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please choose your y coordinate");
                y = Convert.ToInt32(Console.ReadLine());
                if (x > 7 || x < 0 || y < 0 || y > 7)
                {
                    Console.WriteLine(" Coordinnates not found, please try again.");
                    goto again;
                }
                //compare selected to ship coordinates
                if (grid[x, y] == true)
                {
                    Console.WriteLine("YOU SUNK MY BATTLE SHIP");
                    ships = (ships - 1);

                }
                if (ships > 0)
                {
                    goto again;
                }
                else
                {
                    Console.WriteLine("You have sunk ALL my ships!!! ");
                    Console.WriteLine("GAME OVER");
                    
                }

                {
                    Console.WriteLine("TRY AGAIN, YOU MISSED");
                    goto again;
                }
            }
            Console.ReadLine();
        }
    }
}

// options Battleship

  //grid with empty water
  // int row = 8;
  // int column = 8;
  // int [,] grid = new int[row, column];
  // for (int i = 0;i < row; i++)
  // for (int j = 0; j < column; j++)
  // grid[i,j] = water

    //Add ons
    // let them know if they picked "close"
    // let them know if they picked the same coordinates before
    // once all battleships are sunk THEY WIN
    // random generator to place battle ships
    // play against computer
    // allowing you to have battleships
    // add mines 
    
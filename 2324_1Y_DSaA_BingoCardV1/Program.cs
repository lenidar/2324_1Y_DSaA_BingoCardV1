using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2324_1Y_DSaA_BingoCardV1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] bingoCard = new int[5][];
            string[][] displayCard = new string[5][];
            Random rnd = new Random();
            bool duplicate = false;
            int temp = 0;

            // declaration
            for(int x = 0; x < bingoCard.Length; x++) 
            {
                bingoCard[x] = new int[5];
                displayCard[x] = new string[5];
                for(int y = 0; y < bingoCard[x].Length;y++)
                {
                    bingoCard[x][y] = -1;
                }
            }

            // filling up
            for (int x = 0; x < bingoCard.Length; x++)
            {
                for (int y = 0; y < bingoCard[x].Length; y++)
                {
                    temp = (rnd.Next(0, 15) + 1) + (x * 15);
                    duplicate = false;
                    for(int z = 0; z < bingoCard[x].Length; z++)
                    {
                        if (bingoCard[x][z] == -1)
                            break;
                        else if (bingoCard[x][z] == temp)
                        {
                            duplicate = true;
                            break;
                        }
                    }

                    if(duplicate)
                        y--;
                    else
                        bingoCard[x][y] = temp;


                    //bingoCard[y][x] = (rnd.Next(0, 15) + 1) + (x * 15);
                }
            }

            // display
            //for (int x = 0; x < bingoCard.Length; x++)
            //{
            //    for (int y = 0; y < bingoCard[x].Length; y++)
            //        Console.Write(bingoCard[y][x] + "\t");
            //    Console.WriteLine();
            //}

            // transfer the values from int to string card
            for (int x = 0; x < bingoCard.Length; x++)
            {
                for (int y = 0; y < bingoCard[x].Length; y++)
                {
                    displayCard[y][x] = bingoCard[y][x] + "";
                    while (displayCard[y][x].Length < 3)
                        displayCard[y][x] = " " + displayCard[y][x];
                }
            }

            displayCard[2][2] = "FRE";

            // display the card
            Console.WriteLine(" |  B  |  I  |  N  |  G  |  O  | ");
            Console.WriteLine(" ===============================");
            for (int x = 0; x < displayCard.Length; x++)
            {
                Console.Write(" | ");
                for (int y = 0; y < displayCard[x].Length; y++)
                    Console.Write(displayCard[y][x] + " | ");
                Console.WriteLine("\n ===============================");
            }

            Console.ReadKey();
        }
    }
}

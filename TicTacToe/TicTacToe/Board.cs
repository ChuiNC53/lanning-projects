﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Board
    {
        private char[,] boardArray = new char[3, 3];
        public Board() { }
        public void Clear()
        {
            Array.Clear(boardArray, 0, boardArray.Length);
        }
        public void Print()
        {
            Console.WriteLine(
                "   |   |   \n" +
                " {0} | {1} | {2} \n" +
                "   |   |   \n" +
                "---+---+---\n" +
                "   |   |   \n" +
                " {3} | {4} | {5} \n" +
                "   |   |   \n" +
                "---+---+---\n" +
                "   |   |   \n" +
                " {6} | {7} | {8} \n" +
                "   |   |   ", boardArray[0,0], boardArray[0, 1], boardArray[0, 2], boardArray[1, 0], boardArray[1, 1], 
                               boardArray[1, 2], boardArray[2, 0], boardArray[2, 1], boardArray[2, 2]);
        }
        public void Play(int input)
        {
            switch (input)
            {
                case 1:
                    if(boardArray[0,0] == 0)
                    {
                        boardArray[0, 0] = 'O';
                    } else
                    {
                        Console.WriteLine("Illegal Play");
                    }
                    break;
                case 2:
                    if (boardArray[0, 1] == 0)
                    {
                        boardArray[0, 1] = 'O';
                    }
                    else
                    {
                        Console.WriteLine("Illegal Play");
                    }
                    break;
                case 3:
                    if (boardArray[0, 2] == 0)
                    {
                        boardArray[0, 2] = 'O';
                    }
                    else
                    {
                        Console.WriteLine("Illegal Play");
                    }
                    break;
                case 4:
                    if (boardArray[1, 0] == 0)
                    {
                        boardArray[1, 0] = 'O';
                    }
                    else
                    {
                        Console.WriteLine("Illegal Play");
                    }
                    break;
                case 5:
                    if (boardArray[1, 1] == 0)
                    {
                        boardArray[1, 1] = 'O';
                    }
                    else
                    {
                        Console.WriteLine("Illegal Play");
                    }
                    break;
                case 6:
                    if (boardArray[1, 2] == 0)
                    {
                        boardArray[1, 2] = 'O';
                    }
                    else
                    {
                        Console.WriteLine("Illegal Play");
                    }
                    break;
                case 7:
                    if (boardArray[2, 0] == 0)
                    {
                        boardArray[2, 0] = 'O';
                    }
                    else
                    {
                        Console.WriteLine("Illegal Play");
                    }
                    break;
                case 8:
                    if (boardArray[2, 1] == 0)
                    {
                        boardArray[2, 1] = 'O';
                    }
                    else
                    {
                        Console.WriteLine("Illegal Play");
                    }
                    break;
                case 9:
                    if (boardArray[2, 2] == 0)
                    {
                        boardArray[2, 2] = 'O';
                    }
                    else
                    {
                        Console.WriteLine("Illegal Play");
                    }
                    break;
                default:

                    break;
            }
        }
        private void Check()
        {

        }
        private void AI()
        {

        }

    }
}

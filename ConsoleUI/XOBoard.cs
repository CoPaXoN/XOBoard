using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class XOBoard
    {
        public XOSymbols[,] board;
        public const int length = 3;
        public GameStatus gameStatus = GameStatus.None;
        public XOBoard()
        {
            board = new XOSymbols[length, length];

        }

        private static int turn = 1;
        public void Put(int row, int col)
        {
            //check if game over
            if(gameStatus != GameStatus.None)
            {
                Console.WriteLine("Game Over");
                return;
            }

            //check if location available
            if (board[row, col] != XOSymbols.N)
            {
                Console.WriteLine("Can't put in this location.");
                return; //get out of put function
            }

            //determine which turn it is and make a X or Y symbol
            XOSymbols currentSymbol = XOSymbols.X;
            if(turn%2 == 0)
            {
                currentSymbol = XOSymbols.O;
            }
            board[row, col] = currentSymbol;
            turn++;

            //minimum turn you can check for win
            if(turn < length*2-1)
            {
                return;
            }

            int count = 0;
            //check row
            for (int i = 0; i < length; i++)
            {
                if(board[row, i] == currentSymbol)
                {
                    count++;
                }
            }
            if(count == length)
            {
                gameStatus = (currentSymbol == XOSymbols.X) ? GameStatus.X : GameStatus.O;
                return;
            }
            count = 0;

            //check up and down
            for (int i = 0; i < length; i++)
            {
                if (board[i, col] == currentSymbol)
                {
                    count++;
                }
            }
            if (count == length)
            {
                gameStatus = (currentSymbol == XOSymbols.X) ? GameStatus.X : GameStatus.O;
                return;
            }
            count = 0;

            //check left diagonal
            if (col == row)
            {
                for (int i = 0; i < length; i++)
                {
                    if (board[i, i] == currentSymbol)
                    {
                        count++;
                    }
                }
                if (count == length)
                {
                    gameStatus = (currentSymbol == XOSymbols.X) ? GameStatus.X : GameStatus.O;
                    return;
                }
            }
            count = 0;

            //check right diagonal
            if (row + col == length-1)
            {
                for (int i = 0; i < length; i++)
                {
                    if (board[i, length - 1 - i] == currentSymbol)
                    {
                        count++;
                    }
                }
                if (count == length)
                {
                    gameStatus = (currentSymbol == XOSymbols.X) ? GameStatus.X : GameStatus.O;
                    return;
                }
            }
            
            //draw
            if (turn == length * length+1)
            {
                gameStatus = GameStatus.Draw;
                return;
            }
            
        }

        public GameStatus Status()
        {
            return gameStatus;
        }

        public void Display()
        {
            for (int row = 0; row < length; row++)
            {
                for (int col = 0; col < length; col++)
                {
                    Console.Write($"{board[row,col]} ");
                }
                Console.WriteLine();
            }
            
        }
    }
    public enum XOSymbols 
    {
        //N means empty square
        N, X, O
    }
    public enum GameStatus
    {
        X, O, None, Draw
    }
}

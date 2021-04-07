using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        //Game board 3X3 locations example
        //0,0 0,1 0,2    
        //1,0 1,1 1,2 
        //2,0 2,1 2,2 
        static void Main(string[] args)
        {
            XOBoard xoBoard = new XOBoard();
            // X Wins example
            //putAndDisplay(xoBoard, 0, 0);
            //putAndDisplay(xoBoard, 1, 0);
            //putAndDisplay(xoBoard, 0, 1);
            //putAndDisplay(xoBoard, 2, 0);
            //putAndDisplay(xoBoard, 0, 2);

            // O Wins example right diagnal
            //putAndDisplay(xoBoard, 0, 0);
            //putAndDisplay(xoBoard, 1, 1);
            //putAndDisplay(xoBoard, 1, 2);
            //putAndDisplay(xoBoard, 2, 0);
            //putAndDisplay(xoBoard, 0, 1);
            //putAndDisplay(xoBoard, 0, 2);

            //Draw
            //putAndDisplay(xoBoard, 0, 1);
            //putAndDisplay(xoBoard, 0, 0);
            //putAndDisplay(xoBoard, 1, 1);
            //putAndDisplay(xoBoard, 0, 2);
            //putAndDisplay(xoBoard, 2, 2);
            //putAndDisplay(xoBoard, 2, 1);
            //putAndDisplay(xoBoard, 2, 0);
            //putAndDisplay(xoBoard, 1, 2);
            //putAndDisplay(xoBoard, 1, 0);

            Console.ReadKey();
        }

        public static void putAndDisplay(XOBoard xoBoard, int row, int col)
        {
            xoBoard.Put(row, col);
            xoBoard.Display();
            
            Console.WriteLine($"GameStatus: {xoBoard.Status()}" );
            Console.WriteLine();
        }
    }
}

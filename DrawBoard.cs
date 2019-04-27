using System;

namespace DrawBoard
{

    public static class Board
    {

        public static void MyBoard()
        {
            Console.WriteLine("drawBoard class is writing");
            // change gameRow to importBoard

            String space = " ";
            String vbar = "|";
            String plus = "+";
            String dash = "-";

            String[,] myBoard = new String[,] { {"X", vbar, "X", vbar, "X" },
                { dash, plus, dash, plus, dash },
                { "X", vbar, "X", vbar, "X" },
                { dash, plus, dash, plus, dash },
                { "X", vbar, "X", vbar, "X"} };

            String[] boardData = new String[] {"3", "6", "2", "7", "5", "1", ":9", "4", "8" };

            myBoard[0, 0] = boardData[0];
            myBoard[0, 2] = boardData[1];
            myBoard[0, 4] = boardData[2];

            myBoard[2, 0] = boardData[3];
            myBoard[2, 2] = boardData[4];
            myBoard[2, 4] = boardData[5];

            myBoard[4, 0] = boardData[6];
            myBoard[4, 2] = boardData[7];
            myBoard[4, 4] = boardData[8];

            Console.WriteLine("myBoard {0}", arg0: myBoard[0,0]);
        }


    }
}
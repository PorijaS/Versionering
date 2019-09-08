using System;
using System.Collections.Generic;
using System.Text;

namespace Ludo
{
    class Board 
    {
        Piece[] brikker = new Piece[16];
        Felter[] arrboard = new Felter[52];

        public Board() //Den her variable printer basically boarded ud når man nævner den i program.cs man laver en index som starter fra 0 til hvor mange felter der er på et board, også giver den en x og y.
        {
            this.arrboard[0] = new Felter(2, 7, "Red");
            this.arrboard[1] = new Felter(3, 7, "White");
            this.arrboard[2] = new Felter(4, 7, "White");
            this.arrboard[3] = new Felter(5, 7, "White");
            this.arrboard[4] = new Felter(6, 7, "White");
            this.arrboard[5] = new Felter(7, 6, "White");
            this.arrboard[6] = new Felter(7, 5, "White");
            this.arrboard[7] = new Felter(7, 4, "White");
            this.arrboard[8] = new Felter(7, 3, "White");
            this.arrboard[9] = new Felter(7, 2, "White");
            this.arrboard[10] = new Felter(7, 1, "White");
            this.arrboard[11] = new Felter(8, 1, "White");
            this.arrboard[12] = new Felter(9, 1, "White");
            this.arrboard[13] = new Felter(9, 2, "Green");
            this.arrboard[14] = new Felter(9, 3, "White");
            this.arrboard[15] = new Felter(9, 4, "White");
            this.arrboard[16] = new Felter(9, 5, "White");
            this.arrboard[17] = new Felter(9, 6, "White");
            this.arrboard[18] = new Felter(10, 7, "White");
            this.arrboard[19] = new Felter(11, 7, "White");
            this.arrboard[20] = new Felter(12, 7, "White");
            this.arrboard[21] = new Felter(13, 7, "White");
            this.arrboard[22] = new Felter(14, 7, "White");
            this.arrboard[23] = new Felter(15, 7, "White");
            this.arrboard[24] = new Felter(15, 8, "White");
            this.arrboard[25] = new Felter(15, 9, "White");
            this.arrboard[26] = new Felter(14, 9, "Yellow");
            this.arrboard[27] = new Felter(13, 9, "White");
            this.arrboard[28] = new Felter(12, 9, "White");
            this.arrboard[29] = new Felter(11, 9, "White");
            this.arrboard[30] = new Felter(10, 9, "White");
            this.arrboard[31] = new Felter(9, 10, "White");
            this.arrboard[32] = new Felter(9, 11, "White");
            this.arrboard[33] = new Felter(9, 12, "White");
            this.arrboard[34] = new Felter(9, 13, "White");
            this.arrboard[35] = new Felter(9, 14, "White");
            this.arrboard[36] = new Felter(9, 15, "White");
            this.arrboard[37] = new Felter(8, 15, "White");
            this.arrboard[38] = new Felter(7, 15, "White");
            this.arrboard[39] = new Felter(7, 14, "Blue");
            this.arrboard[40] = new Felter(7, 13, "White");
            this.arrboard[41] = new Felter(7, 12, "White");
            this.arrboard[42] = new Felter(7, 11, "White");
            this.arrboard[43] = new Felter(7, 10, "White");
            this.arrboard[44] = new Felter(6, 9, "White");
            this.arrboard[45] = new Felter(5, 9, "White");
            this.arrboard[46] = new Felter(4, 9, "White");
            this.arrboard[47] = new Felter(3, 9, "White");
            this.arrboard[48] = new Felter(2, 9, "White");
            this.arrboard[49] = new Felter(1, 9, "White");
            this.arrboard[50] = new Felter(1, 8, "White");
            this.arrboard[51] = new Felter(1, 7, "White");

            this.brikker[0] = new Piece(0, "home", "Red");
            this.brikker[1] = new Piece(0, "home", "Red");
            this.brikker[2] = new Piece(0, "home", "Red");
            this.brikker[3] = new Piece(0, "home", "Red");
            this.brikker[4] = new Piece(13, "home", "Green");
            this.brikker[5] = new Piece(13, "home", "Green");
            this.brikker[6] = new Piece(13, "home", "Green");
            this.brikker[7] = new Piece(13, "home", "Green");
            this.brikker[8] = new Piece(26, "home", "Yellow");
            this.brikker[9] = new Piece(26, "home", "Yellow");
            this.brikker[10] = new Piece(26, "home", "Yellow");
            this.brikker[11] = new Piece(26, "home", "Yellow");
            this.brikker[12] = new Piece(39, "home", "Blue");
            this.brikker[13] = new Piece(39, "home", "Blue");
            this.brikker[14] = new Piece(39, "home", "Blue");
            this.brikker[15] = new Piece(39, "home", "Blue");

        }

        public void visBoard()
        {
            for (int i = 0; i < arrboard.Length; i++)
            {
                arrboard[i].visFelt();
            }
        }

        public void visPiece(int position)
        {
            Piece p = new Piece(position, "home", "Red");

            int pos = p.getPosition();
            int x = this.arrboard[pos].getX();
            int y = this.arrboard[pos].getY();
            Console.SetCursorPosition(x, y);
            Console.BackgroundColor = ConsoleColor.Cyan;
            
           
        }

    }
}

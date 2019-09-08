using System;
using System.Collections.Generic;
using System.Text;

namespace Ludo
{
    class Piece
    {
       public int position;
       public string tilstand; // Hjemme, Motervej, Slutspil, færdig//
       public string farve; //Rød, Grøn, Gul, Blå//

        public Piece(int position, string tilstand, string farve)
        {
            this.position = position;
            this.tilstand = tilstand;
            this.farve = farve;
        }

        public int getPosition()
        {
            return this.position;
        }

    }
}

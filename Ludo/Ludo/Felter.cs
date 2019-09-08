using System;
using System.Collections.Generic;
using System.Text;

namespace Ludo
{
    class Felter
    {
        public string farve;

        public int x;

        public int y;

        public Felter(int x, int y, string farve)
        {
            this.x = x;
            this.y = y;
            this.farve = farve;
        }

        public void visFelt()
        {
            Console.SetCursorPosition(this.x, this.y);

            if (this.farve == "White") 
                Console.BackgroundColor = ConsoleColor.White;

            if (this.farve == "Red")
                Console.BackgroundColor = ConsoleColor.Red;

            if (this.farve == "Green")
                Console.BackgroundColor = ConsoleColor.Green;

            if (this.farve == "Yellow")
                Console.BackgroundColor = ConsoleColor.Yellow;

            if (this.farve == "Blue")
                Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Black;
        }

        public int getX()
        {
            return this.x;
        }

        public int getY()
        {
            return this.y;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Ludo
{
    class Die
    {
        /*public int RullDie()
        {
            int DieValue;
            Random rnd = new Random();

            DieValue = rnd.Next(1, 7);
            return DieValue;
        }*/

        Random rnd = new Random();
        int dicevalue = 0;
        int dicevalue2 = 0;
        int antalKast = 3;

        Piece p = new Piece(1, "home", "white");

        public void RollDie()
        {
            p.getPosition();

            int dice = rnd.Next(1, 7);
            Console.WriteLine("Velkommen til mit ludospil\n Tryk på k for at slå med terningen 3 gange.");
            char kast = Convert.ToChar(Console.ReadLine().ToLower());

            while (kast == 'k')
            {
                int homedice = rnd.Next(1, 7);
                dicevalue = homedice;

                if (dicevalue != 6 && antalKast > 0)
                {
                    Console.WriteLine(string.Format("{2,5}", "Du slog en " + homedice + "'er. Slaa en 6'er for at faa en brik ud."));
                    antalKast--;
                }
                else if (dicevalue == 6 && antalKast > 0)
                {
                    Console.WriteLine("Du slog en " + homedice + "'er. Du har slaaet en brik ud");
                    antalKast--;

                    Console.WriteLine("Du må slaa igen. Tryk på k");
                    char kast2 = Convert.ToChar(Console.ReadLine().ToLower());

                    if (kast2 == 'k')
                    {
                        Console.WriteLine("Du slog en " + (dicevalue2 = dice) + "'er. Ryk " + dicevalue2 + " felter frem");
                        p.position = p.position + dicevalue2;
                        //Console.WriteLine(p.position);

                    }

                    break;
                }

                if (antalKast == 0 && dicevalue != 6)
                {
                    Console.WriteLine("Du slog desvaere ikke nogen 6'er i denne runde");
                    break;
                }
            }

        }
    }
}

using System;
namespace Ludo
{
    class Program
    {
        static void Main(string[] args)
        {
            Die dice = new Die();
            dice.RollDie(); 

            Board b = new Board();
            b.visBoard(); // Denne linje der laver jeg et nyt viable via viablen b som hedder b.visBoard() som gøre at programmet kan printe ludobrættet når programmet starter//
            b.visPiece(0);
            Console.ReadKey();
        }

    }
}

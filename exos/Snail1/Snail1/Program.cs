//caractéristique  de l'escargot
// affichage de l'escargot 
//deplacer l'escargot 
namespace Snail1
{
    internal class Program
    {

        public class Snail
        {
            private int _x;
            private int _y;
            private ConsoleColor _color;
            private int _energy = 50;

            private const string SNAIL = "_@_ö";
            private const string NO_SNAIL = "    ";
            private const string DEAD_SNAIL = "____";
            static void Main(string[] args)
        {
           
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.CursorVisible = false;

            while (snailvie>0 )
            {
                Thread.Sleep(120);
                Console.SetCursorPosition(x, 10);
                x++;
                snailvie--;
                Console.Write(Snail);
            }
            
           
            
        }
    }
}
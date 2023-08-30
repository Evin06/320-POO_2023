//caractéristique  de l'escargot
// affichage de l'escargot 
//deplacer l'escargot 
namespace Snail1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Snail = " _@_ö";
            string Mort = "____";
            int snailvie = 50;
            int x= 0;
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
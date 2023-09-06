namespace Parachutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo keyPressed;

            //ne pas afficher le cursor
            Console.CursorVisible = false;

            //taille de la fenetre 
            Console.WindowHeight = Config.SCREEN_HEIGHT;
            Console.WindowWidth = Config.SCREEN_WIDTH;

            // 
            Plane plane = new Plane();

            while (true)
            {
                //supprime l'écran
                Console.Clear();
                //modifier le modèle
                plane.update();
                //modifier ce que l'on voit 
                plane.Draw();
                //temporiser
                Thread.Sleep(90);
            }

            if (Console.KeyAvailable) // L'utilisateur a pressé une touche
            {
                keyPressed = Console.ReadKey(false);
                switch (keyPressed.Key)
                {
                    case ConsoleKey.Escape:

                        break;

                }
            }
        }
    }
}
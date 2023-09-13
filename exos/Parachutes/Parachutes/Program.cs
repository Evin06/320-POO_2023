namespace Parachutes
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //ne pas afficher le cursor
            Console.CursorVisible = false;

            //taille de la fenetre 
            Console.WindowHeight = Config.SCREEN_HEIGHT;
            Console.WindowWidth = Config.SCREEN_WIDTH;

            ConsoleKeyInfo keyPressed;


            // 
            Plane plane = new Plane();
            Para para = null;

            while (true)
            {

                if (Console.KeyAvailable) // L'utilisateur a pressé une touche
                {
                    keyPressed = Console.ReadKey(false);
                    switch (keyPressed.Key)
                    {
                        case ConsoleKey.Escape:
                            System.Environment.Exit(0);
                            break;
                        case ConsoleKey.Spacebar:
                            para = plane.parachutist;
                            para.x = plane.x;
                            break;

                    }
                }

                //supprime l'écran
                Console.Clear();
                //modifier le modèle
                plane.update();
                if(para != null)
                {
                    para.update();
                }
                //modifier ce que l'on voit 
                plane.Draw();
                if (para != null)
                {
                    para.Draw();
           
                }
                //temporiser
                Thread.Sleep(50);
            }


        }
    }
}
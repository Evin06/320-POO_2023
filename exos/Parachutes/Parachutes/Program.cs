namespace Parachutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //taille de la fenetre 
            Console.WindowHeight = Config.SCREEN_HEIGHT;
            Console.WindowWidth = Config.SCREEN_WIDTH;
            
            // 
            Plane plane= new Plane();

            while (true) 
            {
                Console.Clear();
                //modifier le modèle
                plane.update();
                //modifier ce que l'on voit 
                plane.Draw();
                //temporiser
                Thread.Sleep(100);
            }
         
            
        }

   
    }
}
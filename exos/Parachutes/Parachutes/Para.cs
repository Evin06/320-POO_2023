using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parachutes
{
    public class Para
    {

        //parachutiste sans parachute 
        private string[] withParachute =
        {
             @"     ",
             @"     ",
             @"     ",
             @"  o  ",
             @" /░\ ",
             @" / \ ",
         };

        //parachutiste avec parachute
        private string[] withoutParachute =
        {
             @" ___ ",
             @"/|||\",
             @"\   /",
             @" \o/ ",
             @"  ░  ",
             @" / \ ",
         };

        private const int PARA_HEIGHT = 6;
        public int x;
        public int altitude;
        string name;
        public bool parachuteopen;
        
        //faire le mouvement du parachutiste 

        //afficher le parachutiste 
        public void Draw()
        {
            for (int i = 0; i < withoutParachute.Length; i++)
            {

                Console.SetCursorPosition( x , altitude + i);
                Console.WriteLine(withParachute[i]);
            }
        }
        public void update()
        {
            // si le parachute est ouvert le parachutiste descent lentement 
            if (parachuteopen)
            {
                altitude -= 1;
            }
            // si le parachute est fermé le parachutiste descent plus le vite 
            else
            {
                altitude -= 3;
            }
        }

    }
}

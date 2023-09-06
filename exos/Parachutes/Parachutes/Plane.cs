using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parachutes
{
    public class Plane
    {
        //"dessin" de l'avion 
        private string[] view =
        {
            @" _                         ",
            @"| \                        ",
            @"|  \       ______          ",
            @"--- \_____/  |_|_\____  |  ",
            @"  \_______ --------- __>-} ",
            @"        \_____|_____/   |  "
        };

        public int x = 0;
        public int y = 1;
        public Para bob = new Para();

        //affiche l'avion 
        public void Draw()
        {
            for (int i = 0; i < view.Length; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.WriteLine(view[i]);
            }
        }
        //permet de bouger l'avion
        public void update()
        {
            x++;
        }
    }
}

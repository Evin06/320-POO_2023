using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parachutes
{
    public class Plane
    {

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

        public void Draw()
        {
            for (int i = 0; i < view.Length; i++)
            {
                
               Console.SetCursorPosition(x,y+i);
                Console.WriteLine(view[i]);
                
            }
       
        }
        
        public void update()
        {
          
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parachutes
{
    public class Para
    {

        private string[] withParachute =
        {
             @"     ",
             @"     ",
             @"     ",
             @"  o  ",
             @" /░\ ",
             @" / \ ",
         };

        private string[] withoutParachute =
        {
             @" ___ ",
             @"/|||\",
             @"\   /",
             @" \o/ ",
             @"  ░  ",
             @" / \ ",
         };

        int X;
        public int altitude;
        string nom;
        
        public void update()
        {
            for (int i = 0; i < withParachute.Length; i++)
            {

            }
        }

        public void Draw()
        {

        }

    }
}

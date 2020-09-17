using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPartie1
{
    class ManipulationChaines
    {
        public static void TestWriteLine()
        {
            int a = 2;
            int b = 3;
            Console.WriteLine($"{a,0:c} + {b,0:c} =\t{a + b,0:c}");
            // ici j'ai pas le bon format de décimal ... pénible
            Console.WriteLine(a.ToString() + " $ + " + b.ToString() + " $ =\t" + (a + b).ToString() + " $");

            


            
        }
    }
}

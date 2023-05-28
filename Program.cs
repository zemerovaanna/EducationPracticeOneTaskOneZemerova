using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOneCreateCat
{
    class Program
    {
        static void Main (string [ ] args)
        {
            Cat murzik = new Cat("123", -12.4);
            Cat barsik = new Cat("Барсег", 8.8);

            barsik.Meow( );

            Console.ReadKey( );
        }
    }
}
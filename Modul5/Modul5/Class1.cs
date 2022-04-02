using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul5
{
    class Class1
    {
        static void Main(string[] args)
        {
            SayaTubeVideo saya = new SayaTubeVideo("Tutorial Design By Contract - Rakha Pratama Wahyudi");
            saya.IncreasePlayCount(0);
            saya.PrintVideoDetails();

            Console.WriteLine();

            SayaTubeVideo saya1 = new SayaTubeVideo("Rakha Pratama Wahyudi");
            saya1.IncreasePlayCount(1000000000);
            saya1.PrintVideoDetails();
        }
    }
}
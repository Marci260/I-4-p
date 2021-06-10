using System;
using System.Collections.Generic;
using System.Text;


namespace I_4_p
{

   
    class Program
    {
        static void Main(string[] args)
        {
            Encrypt asd = new Encrypt("hello world", "abcdefgijkl");
            string megoldas;
            Encrypt secret = new Encrypt("hfnosebw vo", "abcdefgijkl");
            string megoldas2; 





            megoldas = asd.coding();
            megoldas2 = secret.decoding();
          
            Console.WriteLine(megoldas);
            Console.WriteLine(megoldas2);
          




            Console.ReadKey();
        }
    }
}

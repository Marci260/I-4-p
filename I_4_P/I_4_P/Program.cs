using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace I_4_P
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            
            #region Test
            Encrypt asd = new Encrypt("early bird catches the worm", "oirkd uertma dtuafkbiweymud");
            string megoldas;
            Encrypt secret = new Encrypt("sihvazvmhwlc wvaexjup dt kp", "oirkd uertma dtuafkbiweymud");
            string megoldas2;
            Encrypt asd2 = new Encrypt("curiosity killed the cat", "oirkd uertma dtuafkbiwey");
            string megoldas4;
            Encrypt secret2 = new Encrypt("qbhsrrbxoswikoxx yrfhyeq", "oirkd uertma dtuafkbiweymud");
            string megoldas5;
            megoldas = asd.coding();
            megoldas2 = secret.decoding();
            megoldas4 = asd2.coding();
            megoldas5 = secret2.decoding();
            Console.WriteLine(megoldas);
            Console.WriteLine(megoldas2);
            Console.WriteLine(megoldas4);
            Console.WriteLine(megoldas5);

            //beolvasas
            #region read
            string[] blockWords;
            StreamReader Sr = new StreamReader("words.txt", Encoding.Default);
            int db = 0;
            while (!Sr.EndOfStream)
            {
                Sr.ReadLine();
                db++;
            }
            Sr.Close();
            StreamReader Read = new StreamReader("words.txt", Encoding.Default);
            blockWords = new string[db];
            int i = 0;
            while (!Read.EndOfStream)
            {
                blockWords[i] += Read.ReadLine();
                i++;

            }
            Read.Close();
            #endregion

            Guess myGuess = new Guess(blockWords);
            string megoldas3;
            megoldas3 = myGuess.MakeAGuess("sihvazvmhwlc wvaexjup dt kp", "qbhsrrbxoswikoxx yrfhyeq");

            Console.WriteLine("\n");
            Console.WriteLine("megoldas: oirkd uertma dtuafkbiweymud") ;
            Console.WriteLine("\n");

            Console.WriteLine(megoldas3);


            Encrypt secret3 = new Encrypt("sihvazvmhwlc wvaexjup dt kp","oirkd uertmjapwyfzkgqzer");
            string megoldas6 = secret3.decoding();
            Encrypt secret4 = new Encrypt("qbhsrrbxoswikoxx yrfhyeq", "oirkd uertmjapwyfzkgqzer");
            string megoldas7 = secret4.decoding();
            Console.WriteLine(megoldas6);
            Console.WriteLine(megoldas7);
            #endregion
            
            */
            Console.ReadKey();
        }
    }
}

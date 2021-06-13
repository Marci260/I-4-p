using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace I_4_p
{

   
    class Program
    {
        static void Main(string[] args)
        {

            

            #region Test
            Encrypt asd = new Encrypt("hello world", "abcdefgijkl");
            string megoldas;
            Encrypt secret = new Encrypt("hfnosebw vo","abcdefgijkl");
            string megoldas2;
            megoldas = asd.coding();
            megoldas2 = secret.decoding();
            Console.WriteLine(megoldas);
            Console.WriteLine(megoldas2);
            
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
            megoldas3 = myGuess.MakeAGuess("kiuehzdamdkfugiatebfirta lo", "ibubyrklt vlezkxofjraqxs");
            Console.WriteLine(megoldas3);
            #endregion



            Console.ReadKey();
        }
    }
}

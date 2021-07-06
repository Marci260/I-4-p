using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using I_4_P;
using NUnit.Framework;
using System.IO;

namespace Tester
{
    [TestFixture]
    public class TesterClass
    {

        [TestCase]
        public void CodingTest() 
        {
            Encrypt coding = new Encrypt("hello world", "abcdefgijkl");
            string megoldas;
            megoldas = coding.coding();
            

            Assert.That(megoldas.Length == coding.CodeKey.Length);
        }

        [TestCase]
        public void DecodingTest() 
        {
            
            Encrypt secret = new Encrypt("hfnosebw vo", "abcdefgijkl");
            string megoldas2;
            megoldas2 = secret.decoding();


            Assert.That(megoldas2 == "hello world");
            
        }

        string[] blockWords;

        [SetUp]
        public void Init() 
        {
            #region Read
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

            
        }

        [TestCase]
        public void GuessTest() 
        {
            Guess myGuess = new Guess(blockWords);
            string megoldas3;
            string message1 = "kiuehzdamdkfugiatebfirta lo";
            string message2 = "ibubyrklt vlezkxofjraqxs";
            megoldas3 = myGuess.MakeAGuess(message1, message2);
            
            Assert.That(megoldas3.Length == message2.Length );

        }






    }
}

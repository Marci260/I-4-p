using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace I_4_p
{
    class Guess
    {
        #region Variables
        private string[] words;

        public string[] Words 
        {
            get { return words; }
            set {  }
        }
        private string abc;

        public string Abc 
        {
            get { return abc; }
        }

        #endregion

        #region Constructors
        public Guess(string[] aWords)
        {
            this.words = aWords;
            this.abc = "abcdefghijklmnopqrstuvwxyz ";
        }
        #endregion

        #region Methods
        public string MakeAGuess(string secret,string message1, string message2) 
        {
            string guessTheKey = "";
            string[] temporary = new string[message1.Length / 2];
            int number = 0;
            int i = 0;
            int[] character = new int[secret.Length];
            string secondWord = "";
            string guess = "";


            while (message1[i] != ' ')
            {

                guess += message1[i];
                i++;
            }
            for (int j = 0; j < words.Length; j++)
            {
                if (words[j].Contains(guess))
                {
                    temporary[number] = words[j];
                    number++;
                }
               
            }
            for (int j = 0; j < secret.Length; j++)
            {
                for (int k = 0; k < abc.Length; k++)
                {
                    if (secret[j] == abc[k])
                    {
                        character[j] = k;
                    }
                }
            }
            for (int j = 0; j < guess.Length; j++)
            {
                for (int k = 0; k < abc.Length; k++)
                {
                    if (guess[j] == abc[k])
                    {
                      
                        character[j] -= k;
                    }
                }
            }
            for (int j = 0; j < character.Length; j++)
            {
                for (int k = 0; k < abc.Length; k++)
                {
                    if (character[j] < 0)
                    {
                        int tempnum = character[j] + 27;
                        guessTheKey += abc[tempnum];
                    }
                    else
                    {
                        guessTheKey += abc[k];
                    }
                }
                break;
            }
            /////
            int[] tempsize = new int[message2.Length];
            for (int j= 0; j < guess.Length; j++)
            {
                
                for (int k = 0; k < abc.Length; k++)
                {
                    if (guess[j] == abc[k])
                    {
                        tempsize[j] += k;
                    }
                    
                }
            }
            for (int j = 0; j < secret.Length; j++)
            {
                for (int k = 0; k < abc.Length; k++)
                {
                    if (secret[j] == abc[k])
                    {
                        tempsize[j] += k;
                    }
                }
            }
            for (int j = 0; j < tempsize.Length; j++)
            {
                for (int k = 0; k < abc.Length; k++)
                {
                    if (tempsize[j] > 26)
                    {
                        int tempnum = tempsize[j] % 27;
                        secondWord += abc[tempnum];

                    }
                    else
                    {
                        secondWord += abc[k];
                    }
                }
            }


            




            return guessTheKey;



        }
        #endregion





    }
}

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
        public string MakeAGuess(string message1, string message2)
        {
            //lopp (ha paratlan szam akkor message2, ha paros akkor message1)
            //feltesszuk hogy mind a ket uzenet ugyan azzal a kulccsal keszult
            string first_word = "early "; // megoldani hogy talalgatassal is menjen
            string key = ""; // a kitalalt kulcsunk
            int[] keyWordNumber = new int[message1.Length];
            string word_fragment = "";
            int currentMessageNumber = 1;
            string currentmessage_first = "";
            string currentmessage_second = "";


            while (key.Length != message2.Length)
            {


                //eldontjuk hogy melyik uzenetet helyettesitjuk eppen
                if (currentMessageNumber % 2 == 0)
                {
                    currentmessage_first = message2;
                    currentmessage_second = message1;
                }
                else
                {
                    currentmessage_first = message1;
                    currentmessage_second = message2;
                }
                //bele rakjuk egy tombbe az aktualisan kitalat szo karaktereinek hianyzo erteket
                for (int i = 0; i < first_word.Length; i++)
                {
                    for (int j = 0; j < abc.Length; j++)
                    {
                        if (currentmessage_first[i] == abc[j] && i >= key.Length)
                        {
                            keyWordNumber[i] += j;
                        }

                    }
                }
                
                //kivonjuk belole az uzenet aktualis karaktereinek erteket
                for (int i = 0; i < first_word.Length; i++)
                {
                    for (int j = 0; j < abc.Length; j++)
                    {
                        if (first_word[i] == abc[j] && i >= key.Length)
                        {
                            keyWordNumber[i] -= j;
                        }
                    }
                }
                
                //az igy kapott erteket bele iratjuk a kulcsunkba
                for (int i = 0; i < first_word.Length; i++)
                {
                    for (int j = 0; j < abc.Length; j++)
                    {
                        if (i >= key.Length)
                        {

                            if (keyWordNumber[i] < 0)
                            {
                                int tempnum = keyWordNumber[i] + 27;
                                key += abc[tempnum];
                            }
                            else
                            {
                                key += abc[keyWordNumber[i]];
                            }
                            break;
                        }
                        
                    }
                    
                }
                


                
                //kitisztítjuk a tombot
                for (int i = 0; i < keyWordNumber.Length; i++)
                {
                    keyWordNumber[i] = 0;
                }

                
                
                //kulcs behelyettesitese a masik uzenetbe

                for (int i = 0; i < first_word.Length; i++)
                {
                    for (int j = 0; j < abc.Length; j++)
                    {
                        if (currentmessage_second[i] == abc[j])
                        {
                            keyWordNumber[i] += j;
                        }

                    }
                }
                
                for (int i = 0; i < first_word.Length; i++)
                {
                    for (int j = 0; j < abc.Length; j++)
                    {
                        if (key[i] == abc[j] )
                        {
                            keyWordNumber[i] -= j;
                        }
                    }
                }
                
                word_fragment = "";
                //megkapjuk a szotoredeket
                for (int i = 0; i < first_word.Length; i++)
                {
                    for (int j = 0; j < abc.Length; j++)
                    {
                        
                        if (keyWordNumber[i] < 0)
                        {
                            int tempnum = keyWordNumber[i] + 27;
                            word_fragment += abc[tempnum];
                        }
                        else
                        {
                            word_fragment += abc[keyWordNumber[i]];
                        }
                        break;
                    }
                    
                }
               
               
                
                
                
                
                // megkeressuk azokat a szavakat amiben benne van ez a toredek 
                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i].Contains(word_fragment,0))
                    {
                        first_word = words[i] +=" " ;
                    }
                    
                }
                currentMessageNumber++;
                
            }

            return key;
        }
        #endregion





    }
}

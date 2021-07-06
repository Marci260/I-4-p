using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace I_4_P
{
    public class Guess
    {
        #region Variables
        private string[] words;

        public string[] Words
        {
            get { return words; }
            set { }
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
            
            string first_word = "early "; 
            string key = ""; 
            string word_fragment = "";
            int currentMessageNumber = 1;
            string currentmessage_first = "";
            string currentmessage_second = "";
            int place = 0;
            int messageLength;
            #region Setup
            if (message1.Length< message2.Length)
            {
                messageLength = message1.Length;
            }
            else
            {
                messageLength = message2.Length;
            }
            int[] keyWordNumber = new int[messageLength];
            #endregion

            #region ciklusok
            while (key.Length != messageLength)
            {
                
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

               

  

                for (int i = 0; i < keyWordNumber.Length; i++)
                {
                    for (int j = 0; j < abc.Length; j++)
                    {
                        if (i >= place && i<= first_word.Length-1)
                        {
                            if (currentmessage_first[i] == abc[j])
                            {
                                keyWordNumber[i] += j;
                            }
                        }    
                        
                    }
                }
                for (int i = 0; i < first_word.Length ; i++)
                {
                    for (int j = 0; j < abc.Length; j++)
                    {
                        if (i>= place && i<= first_word.Length-1)
                        {


                            if (first_word[i] == abc[j])
                            {
                                keyWordNumber[i] -= j;

                            }
                        }
                        
                    }
                }
                
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
                            else if (keyWordNumber[i] > 27)
                            {
                                int tempnum = keyWordNumber[i] % 27;
                                key += abc[tempnum];
                               
                                
                            }
                            else
                            {
                                key += abc[keyWordNumber[i]];
                                
                            }
                            
                        }
                        break;
                    }
                }

                //
                for (int i = 0; i < keyWordNumber.Length; i++)
                {
                    keyWordNumber[i] = 0;
                }
                //
        
                for (int i = 0; i < keyWordNumber.Length ; i++)
                {
                    for (int j = 0; j < abc.Length; j++)
                    {
                        if (i >= place && i <= key.Length)
                        {
                            if (currentmessage_second[i] == abc[j])
                            {
                                keyWordNumber[i] += j;
                            }
                        }
                        

                    }
                }
              
                for (int i = 0; i < currentmessage_second.Length ; i++)
                {
                    for (int j = 0; j < abc.Length; j++)
                    {
                        if (i >= place && i< key.Length)
                        {
                            if (key[i] == abc[j])
                            {
                                keyWordNumber[i] -= j;
                            }
                            
                        }
                        
                    }
                    
                }

              
                
                word_fragment = "";

                
              
                for (int i = 0; i <  keyWordNumber.Length; i++)
                {
                    for (int j = 0; j < abc.Length; j++)
                    {
                        if ( i >= place && i< key.Length)
                        {

                            if (keyWordNumber[i] < 0)
                            {
                                int tempnum = keyWordNumber[i] + 27;
                                word_fragment += abc[tempnum];
                            }
                            else if (keyWordNumber[i] > 27)
                            {
                                int tempnum = keyWordNumber[i] % 27;
                                word_fragment += abc[tempnum];
                            }
                            else
                            {
                                word_fragment += abc[keyWordNumber[i]];
                            }
                            break;
                        }
                    }
                    
                }
               

                place = key.Length;

                ;
                first_word = "";

                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i].Contains(word_fragment) )
                    {
                        first_word = words[i];

                        if (first_word[first_word.Length-1] != ' ')
                        {
                            first_word += ' ';
                        }
                        break;
                    }
                    
                    
                }
                for (int i = 0; i < keyWordNumber.Length; i++)
                {
                    keyWordNumber[i] = 0;
                }
               
                
               

                currentMessageNumber++;
                
            }

            #endregion
            return key;
        }
            #endregion

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace I_4_p
{
    class Encrypt
    {
        #region Variables
        private string code;

        public string Code
        {
            get { return code; }

            set { }
        }

        private string codekey;

        public string CodeKey 
        {
            get { return codekey; }
            set { }

        }

        private string answer;

        public string Answer 
        {
            get { return answer; }

            set { }
        }

        private string abc;
        
        protected string Abc 
        {
            get { return abc; }
        }
        #endregion

        #region Constructors
        public Encrypt(string acode, string acodekey)
        {
            this.code = acode;
            this.codekey = acodekey;
            this.abc = "abcdefghijklmnopqrstuvwxyz ";
            //A B C D E F G H I J K  L  M  N  O  P  Q  R  S  T  U  V  W  X  Y  Z  " "
            //0 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26
        }
        

        
        #endregion


        public string coding() 
        {
            //ha a key hoszabb mint a kod akkor ha megfejtes a kod hossza lesz
            string temporary = "";
            if (code.Length < codekey.Length)
            {
               
                for (int i = 0; i < code.Length; i++)
                {
                    temporary += codekey[i];
                }
                codekey = temporary;
            }


            int[] temp = new int[code.Length];
            for (int i = 0; i < code.Length; i++)
            {

                for (int j = 0; j < abc.Length; j++)
                {
                    if (code[i] == abc[j])
                    {
                        temp[i] += j;
                    }


                }

            }
            for (int i = 0; i < codekey.Length; i++)
            {

                for (int j = 0; j < abc.Length; j++)
                {
                    if (codekey[i] == abc[j])
                    {
                        temp[i] += j;

                    }

                }

            }
            for (int i = 0; i < temp.Length; i++)
            {
                for (int j = 0; j < abc.Length; j++)
                {
                    if (temp[i] > 26)
                    {
                        int number = temp[i] % 27;
                        this.answer += abc[number];
                    }
                    else
                    {
                        this.answer += abc[temp[i]];
                    }
                    break;
                }
            }
            return answer;
        }

        public string decoding() 
        {

            string temporary = "";
            if (code.Length < codekey.Length)
            {
                for (int i = 0; i < code.Length; i++)
                {
                    temporary += codekey[i];
                }
                codekey = temporary;
            }
            int[] temp = new int[code.Length];
            for (int i = 0; i < code.Length; i++)
            {
                for (int j = 0; j < abc.Length; j++)
                {
                    if (code[i] == abc[j])
                    {
                        temp[i] += j;
                    }
                }
            }

            for (int i = 0; i < codekey.Length; i++)
            {
                for (int j = 0; j < abc.Length; j++)
                {
                    if (codekey[i] == abc[j])
                    {
                        temp[i] -= j;
                    }
                }
            }
            for (int i = 0; i < temp.Length; i++)
            {
                for (int j = 0; j < abc.Length; j++)
                {
                    if (temp[i]<0)
                    {
                        int number = temp[i]  *(-1); /// javítani

                        answer += abc[number];
                    }
                    else
                    {
                        answer += abc[temp[i]];
                    }
                   
                    break;
                }
             
            }         

            return answer;

        }

    }
}

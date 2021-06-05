using System;

namespace I_4_p
{

   
    class Program
    {
        static void Main(string[] args)
        {

            string code = "alma";
            string codekey = "acdf";
            int[] temp = new int[code.Length];
            var answer = "";
            string abc = "abcdefghijklmnopqrstuvwxyz ";
            //A B C D E F G H I J K  L  M  N  O  P  Q  R  S  T  U  V  W  X  Y  Z  " "
            //0 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26



            //kodolas
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

            ////////////////////idáig jó

            for (int i = 0; i < temp.Length; i++)
            {
                for (int j = 0; j < abc.Length; j++)
                {
                    if (temp[i] > 26)
                    {
                        int number = temp[i] % 27;
                        answer += abc[number];

                    }
                    else
                    {
                        answer += abc[temp[i]];

                    }
                    break;



                }

            }




            Console.WriteLine(code);
            Console.WriteLine(codekey);
            for (int i = 0; i < temp.Length; i++)
            {
                Console.WriteLine(temp[i]);
            }
            Console.WriteLine(answer);
            Console.ReadKey();
        }
    }
}

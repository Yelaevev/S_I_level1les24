using System;
using System.Collections.Generic;

namespace Level1Space
{
    public static class Level1
    {
        static public string Remove(string s)
        {
            if (s == "1") return "0";
            if (s == "0") return "1";
            return s;
        }
        static public string  Keymaker(int k)
        {
            int action = 0;
            string[] test = new string[k];
            for (int i = 0; i < test.Length; i++)
            {
                test[i] = "1";
            }
            action = 1;

            while (action != k)
            {
                action++;
                for (int i = 1; i * action <= test.Length; i++)
                {
                    test[i * action - 1] = Remove(test[i * action - 1]);
                    // test[i * action - 1] = Convert.ToString( action);
                }

                //Console.WriteLine(action);
                //foreach (var t in test) Console.Write(t + " ");
                //Console.WriteLine();

                // for (int i = 1; i * action <= test.Length; i++)
                // {
                //     test2[i * action-1] = Remove(test2[i * action-1]);

                // }

                //// Console.WriteLine(action);
                // foreach (var t in test2) Console.Write(t + " ");
                // Console.WriteLine();
            }

            string result = test[0];
            for (int i = 1; i < test.Length; i++) result = result.Insert(result.Length, test[i]);
            return result;
        }
        //static void Main(string[] args)
        //{
        //    int k = 36;
        //    string result = Keymaker(k);
        //    Console.WriteLine(result);
        //    Console.WriteLine(result[result.Length-1]);

        //}
    }
}

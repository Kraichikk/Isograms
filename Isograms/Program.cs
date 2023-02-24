using System;

namespace Isograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsIsogram("abc"));
        }
        public static bool IsIsogram(string s)
        {
            string str = s.ToLower();
            int counter = 0;
            char val = ' ';

            for (int i = 0; i < str.Length; i++)
            {
                val = str[i];

                for (int j = 0; j < str.Length; j++)
                {
                    if ((j != i) && (val == str[j]))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}

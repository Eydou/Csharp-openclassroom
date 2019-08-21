using System;
using System.Collections.Generic;

namespace Activity1_opclassroom
{
    class Program
    {
        private static void display(Dictionary<int, int> dict)
        {
            Console.WriteLine("Voici le loto :");
            foreach (var nb in dict)
                Console.WriteLine(nb.Key);
        }
        private static bool Verification(Dictionary<int, int> dict)
        {
            if (dict.Count != 7)
                return false;
            return true;
        }
        static void Main()
        {
            Random rndm = new Random();
            int[] array = new int[7];
            var dict = new Dictionary<int, int>();

            for (int i = 0; i < array.Length; i++)
                array[i] = rndm.Next(1, 8);
            foreach (var nb in array)
            {
                if (!dict.ContainsKey(nb))
                {
                    dict.Add(nb, 0);
                }
                dict[nb]++;             
            }
            if (Verification(dict) == true)
                display(dict);
            else
            {
                for (int i = dict.Count; dict.Count != 7; i++)
                    dict[i] = rndm.Next(1, 8);
                display(dict);
            }
        }
    }
}
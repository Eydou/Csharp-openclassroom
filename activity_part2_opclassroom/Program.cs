using System;

namespace Activity1_opclassroom
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rndm = new Random();
            int[] array = new int[7];

            for (int i = 0; i < array.Length; i++)
                array[i] = rndm.Next(1, 49);
            foreach (int nb in array)
                Console.WriteLine(nb);
        }
    }
}

using System;
using System.Collections.Generic;

namespace tp2_openclassroom
{
    class Program
    {
        private static int CalculMultiple()
        {
            int result = 0;
            List<int> liste3 = new List<int> { };
            List<int> liste5 = new List<int> { };

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                   liste3.Add(i);
                if (i % 5 == 0)
                   liste5.Add(i);
            }
            foreach (int multiples3 in liste3)
                foreach (int multiples5 in liste5)
                {
                    if (multiples3 == multiples5)
                        result += (multiples3 + multiples5);
                }
            return (result);
        }
        private static double CalculMoyenne(List<double> liste)
        {
            double result = 0.00;

            for (int i = 0; i != liste.Count; i++)
                 result += liste[i];
            result /= liste.Count;
            return (result);
        }
        private static int CalculSommeEntiers(int first, int last)
        {
            int result = 0;

            for (; first <= last; first++)
                result += first;
            return result;
        }
        static void Main(string[] args)
        {
            List<double> liste = new List<double> { 1.0, 5.5, 9.9, 2.8, 9.6 };

            Console.WriteLine("Calcul entier : " + CalculSommeEntiers(1, 10));
            Console.WriteLine("Calcul entier : " + CalculSommeEntiers(1, 100));
            Console.WriteLine("Calcul moyenne : " + CalculMoyenne(liste));
            Console.WriteLine(CalculMultiple());
        }
    }
}

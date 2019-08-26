using System;

namespace tp3_openclassroom
{
    class Program
    {
        static void Main(string[] args)
        {
            int rdm_valor = new Random().Next(0, 100);
            Boolean verif = false;
            string str;
            int nb;

            while (!verif)
            {
                Console.WriteLine("Enter a number : ");
                str = Console.ReadLine();
                if (int.TryParse(str, out nb))
                {
                    if (nb < rdm_valor)
                    {
                        Console.WriteLine("Enter a bigger number");
                        verif = false;
                    }
                    if (nb > rdm_valor)
                    {
                        Console.WriteLine("Enter a smaller nummber");
                        verif = false;
                    }
                    else if (nb == rdm_valor)
                    {
                        Console.WriteLine("Good Job ! You have " + rdm_valor + " years old");
                        verif = true;
                    }

                }
                else
                    Console.WriteLine("Invalid argument, please retry and enter a number");
            }
        }
    }
}

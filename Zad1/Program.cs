using System;

namespace APBD_Zadanie1.Zad1
{
    public class Zad1
    {
        public static void Main()
        {
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(i);
            }

            int[] tab = { 1, 3, 2 };
            Console.WriteLine("Średnia: " + avg(tab));
        }

        public static float avg(int[] tabInt)
        {
            float avg = 0;
            for (int i = 0; i < tabInt.Length; i++)
            {
                avg += tabInt[i];
            }

            return avg / tabInt.Length;
        }
    }
}


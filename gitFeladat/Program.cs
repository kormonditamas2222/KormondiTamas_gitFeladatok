using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gitFeladat
{
    internal class Program
    {
        static void f01(int[] tomb)
        {
            Random random = new Random();
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = random.Next(1, 51);
            }
        }

        static int f02(int[] tomb)
        {
            int counter = 0;
            for (int i = 0; i < tomb.Length; i++) 
            {
                if (tomb[i] % 2 == 0)
                {
                    counter++;
                }
            }
            return counter;
        }

        static double f03(int[] tomb)
        {
            double avg = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                avg += tomb[i];
            }
            avg /= tomb.Length;
            return avg;
        }

        static int[] f04(int[] tomb)
        {
            int[] paratlanok = new int[10];
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] % 2 == 0)
                {
                    paratlanok[i] = tomb[i] + 1;
                }
                else
                {
                    paratlanok[i] = tomb[i];
                }
            }
            return paratlanok;
        }

        static void Main(string[] args)
        {
        }
    }
}

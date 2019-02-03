using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution1
{
    class Solution
    {
        static void Main(string[] args)
        {
            Start();
        }

        static void Start()
        {
            int T = 0;
            string input = Console.ReadLine();
            if (int.TryParse(input, out T))
            {
                int[] N = new int[T];
                for (int i = 0; i < T; i++)
                {
                    N[i] = Int32.Parse(Console.ReadLine());
                }
                Call_Summ(N);
                Console.ReadKey();
            }
            else
            {
                Start();
            }
        }
 
        static void Call_Summ(int[] Smth)
        {
            for(int i = 0; i < Smth.Length; i++)
            {
                Summ(Smth[i]);
            }

        }

        static void Summ(int count)
        {
            int output = 0;
            for (int i = 1; i < count; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    output += i;
                }
            }
            Console.WriteLine(output);
        }
    }
}

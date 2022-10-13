using System;
using System.Collections.Generic;
using System.Text;

namespace MathFactorial
{
    class MathFactorial
    {
        public void Factorial()
        {
            while (true)
            {
                int num;

                num = int.Parse(Console.ReadLine());

                if (num==0)
                {
                    break;
                }

                int F = 1;

                for (int i = 1; i <= num; i++)
                {
                    F *= i;
                }
                Console.WriteLine(F);
            }
            
        }
    }
}

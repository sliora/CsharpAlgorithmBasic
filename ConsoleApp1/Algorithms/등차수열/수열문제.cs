using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 아래 수열의 결과값을 구하는 프로그램을 작성하시오.
/// 1/2 - 2/3 + 3/4 ... 98/99 + 99/100 = ?
/// </summary>

namespace ConsoleApp1.Algorithms.등차수열
{
    class 수열문제
    {
        static void Main()
        {
            //[1] Input
            double sum = 0.0;

            //[2] Process
            for (int i = 1; i <= 99; i++)
            {   
                if (i % 2 != 0)
                {
                    sum += i / (double)(i + 1);
                }
                else
                {
                    sum -= i / (double)(i + 1);
                }
            }

            //[3] Output
            Console.WriteLine(sum);
        }

    }
}

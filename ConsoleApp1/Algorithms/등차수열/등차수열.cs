// 등차수열 : 연속하는 두 수의 차이가 일정한 수열
// 1, 3, 5, 7, 9, ...
using System;

namespace ConsoleApp1.Algorithms.등차수열
{
    class 등차수열
    {
        static void Main()
        {
            //[1] Input
            int sum = 0;

            //[2] Process

            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 1) //홀수의 합
                {
                    sum += i;
                }
            }

            //[3] Output
            Console.WriteLine("1부터 100까지 홀수의 합: {0}", sum);
        }
    }
}

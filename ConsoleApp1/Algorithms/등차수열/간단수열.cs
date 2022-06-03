/// <summary>
/// 아래 수열의 결과값을 구하는 프로그램을 작성하시오.
/// 1 - 2 + 3 - 4 + 5 - .... + 99 - 100 = ?
/// 패턴 : 홀수는 +, 짝수는 -
/// </summary>
using System;

namespace ConsoleApp1.Algorithms.등차수열
{
    class 간단수열
    {
        static void Main()
        {
            //[1] Input
            int sum = 0;

            //[2] Process

            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 1) //홀수
                {
                    sum += i;
                }
                else
                {
                    sum -= i;
                }
            }

            //[3] Output
            Console.WriteLine("1부터 100까지 홀수의 합: {0}", sum);
        }
    }
}

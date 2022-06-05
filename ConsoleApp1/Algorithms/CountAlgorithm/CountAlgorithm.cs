using System;
using System.Linq;
/// <summary>
/// [?] 1부터 1000까지의 정수 중 13의 배수의 개수
/// 개수 알고리즘(Count Algorithm) : 주어진 범위에 주어진 조건에 해당하는 자료들의 개수
/// </summary>

namespace ConsoleApp1.Algorithms.CountAlgorithm
{
    class CountAlgorithm
    {
        static void Main()
        {
            //[1] Input
            int count = 0;

            //[2] Process
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 13 == 0)
                {
                    count++;
                }
            }

            //실무용
            Enumerable.Range(1, 1_000).ToArray().Where(n => n % 13 == 0).Count();
            Enumerable.Range(1, 1_000).ToArray().Count(n => n % 13 == 0);

            //[3] Output
            Console.WriteLine($"1부터 1,000까지의 정수 중 13의 배수의 개수 : {count}");
            
        }
    }
}

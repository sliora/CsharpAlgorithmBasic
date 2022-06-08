using System;
/// <summary>
/// 문제 : 자연수 하나를 입력 받아서, 2부터 해당 수까지 안에 존재하는 모든 소수를 찾아서 출력하는 프로그램
/// </summary>
namespace ConsoleApp1.Algorithms.CountAlgorithm
{
    class PrimeNumberCount
    {
        static void Main()
        {
            //[1] Input
            int cnt = 0;
            int num = 0;
            bool sw = true;
            Console.Write("수 입력: _\b");
            num = Convert.ToInt32(Console.ReadLine());
            //[2] Process

            for (int i = 2; i <= num; i++)
            {
                sw = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        sw = false;
                    }
                }

                if (sw)
                {
                    Console.WriteLine(i);
                    cnt++;
                }
                
            }

            //[3] Output
            Console.Write("{0},{1}",num, cnt);


        }
    }
}

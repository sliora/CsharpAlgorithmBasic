using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 알고리즘_완전수 : 자신을 제외한 약수의 합이 자신과 같은 수
/// 예 6 = 1 + 2 + 3
/// 1부터 10000까지의 완전수와 개수를 출력
/// </summary>

namespace ConsoleApp1.Algorithms.CountAlgorithm
{
    class 완전수
    {
        static void Main(string[] args)
        {
            //[1]Input
            int cnt = 0; //완전수의 개수

            //[2]Process
            for (int i = 1; i <= 10000; i++)
            {
                int sum = 0; // 완전수의 합계
                
                // 값에 2로 나누면 최대 약수다.
              
                for(int j=1; j< i; j++)
                {
                    if (i % j == 0)
                    {
                        sum += j;
                    }
                }
                if (sum == i)
                {
                    Console.WriteLine(sum);
                    cnt++;
                }
            }

            //[3]Output
            Console.WriteLine("완전수의 개수는 : {0}", cnt);

        }
    }
}

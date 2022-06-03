using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 아래 수열의 결과값을 구하는 프로그램을 작성하시오.
/// 1 + 2 + 4 + 7 + 11 + 16 + 22 + ... +
/// 위 패턴대로 20번 반복했을 때의 결과값은 얼마?
/// </summary>

namespace ConsoleApp1.Algorithms.등차수열
{
    class 수열퀴즈
    {
        static void Main(string[] args)
        {
            //[1] Input
            int data = 1;
            int sum = 0;

            //[2] Process
            for (int i = 0; i < 20; i++)
            {
                data += i;
                sum += data;
                Console.WriteLine(data);
            }

            //[3] Output
            Console.WriteLine(sum);
        }
    }
}

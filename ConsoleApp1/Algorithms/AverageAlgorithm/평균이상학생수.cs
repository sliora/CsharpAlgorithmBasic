using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 5명의 학생의 토익 점수를 입력 받아서 전체 학생 평균 이상의 성적인 학생의 수를 구하는 프로그램
/// 평균(합계, 카운트) -> 카운트 
/// </summary>

namespace ConsoleApp1.Algorithms.AverageAlgorithm
{
    class 평균이상학생수
    {
        static void Main(string[] args)
        {
            int[] t = {100, 90, 80, 70, 60};

            int sum = 0; //총점
            double avg = 0.0; //평균
            int count = 0; //학생 수(평균 이상)

            for (int i = 0; i < t.Length; i++)
            {
                sum += t[i];
            }

            avg = sum / (double)t.Length;

            Console.WriteLine($"학생의 평균은 : {avg}");

            for (int i = 0; i < t.Length; i++)
            {
                if (avg <= t[i])
                {
                    count++;
                }
            }

            Console.WriteLine($"평균 이상의 학생 수는 : {count}");
        }
    }
}

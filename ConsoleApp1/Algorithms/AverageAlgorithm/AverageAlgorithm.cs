using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// [?] n명의 점수 중에서 80점 이상 95점 이하인 점수의 평균
/// 평균 알고리즘(Average Algorithm) : 주어진 범위에 주어진 조건에 해당하는 자료들의 평균
/// 
/// </summary>

namespace ConsoleApp1.Algorithms.AverageAlgorithm
{
    class AverageAlgorithm
    {
        static void Main(string[] args)
        {
            //[1] Input
            int[] data = { 90, 65, 79, 50, 95 };
            int sum = 0; // 합계 담는 변수
            int count = 0; // 개수 담는 변수

            //[2] Process
            //AVG = SUM / COUNT
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= 80 && data[i] <= 95)
                {
                    sum += data[i];
                    count++;
                }
            }
            double avg = sum / (double)count;

            //실무용
            //data.Where(d => d >= 80 && d <= 95).Average();

            //[3] Output
            Console.WriteLine($"80점 이상 95점 이하인 자료의 평균 : {avg}");
        }
    }
}

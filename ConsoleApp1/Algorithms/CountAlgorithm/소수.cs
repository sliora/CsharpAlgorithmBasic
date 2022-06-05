using System;
/// <summary>
/// 소수 : 
/// - 자연수 중에서 1과 자기 자신만을 약수로 가지는 자연수
/// - 5는 소수 : 1과 5만을 약수로 가짐
/// - 6은 소수가 아님 : 1, 3, 6을 약수로 가지므로
/// </summary>

namespace ConsoleApp1.Algorithms.CountAlgorithm
{
    class PrimeNumber
    {
        static void Main()
        {
            int k = 1;
            int num = 0;
            Console.Write("수 입력: _\b");
            num = Convert.ToInt32(Console.ReadLine());

            do
            {
                k++;
                Console.WriteLine("{0} % {1} = {2}", num, k, num % k);

            } while (num % k != 0);

            if (num == k)
            {
                Console.WriteLine("소수임");
            }
            else
            {
                Console.WriteLine("소수아님");
            }


        }
    }
}

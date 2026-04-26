using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int num1, num2, score;

        Console.Write("A의 점수를 입력하세요");
        num1 = int.Parse(Console.ReadLine()); // int.Parse() → 문자열을 정수로 변환
        Console.Write("B의 점수를 입력하세요");
        num2 = int.Parse(Console.ReadLine());

        if (num1 > num2)
        {
            Console.WriteLine("A가 더 높은 점수");
        }
        else if (num1 < num2)
        {
            Console.WriteLine("B가 더 높은 점수"); 
        }
        else
        {
            Console.WriteLine("점수가 동일합니다");
        }




        }
    }
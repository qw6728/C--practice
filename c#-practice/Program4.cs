using System;
using System.Net.Cache;

class Dog
{
    public String Name; // 필드 변수 구현
    public int Age;

    public Dog(String name, int age) // Dog 생성자 
    {
        Name = name; // 전달받은 매개변수 name을 필드에 저장
        Age = age;  // 전달받은 매개변수 age를 필드에 저장

        Console.WriteLine("강아지의 이름은" + Name + "이고 나이는" + Age + "입니다");

    }

}

class Program4 //Main 메서드
{
    public static void Main(String[] args)
    {
        Dog mydog = new Dog("바둑이", 3); // (인스턴스 생성) :생성자 Dog 호출 - > "코코 출략"
        mydog.Age = 4; // 객채의 속성(Age)를 4로 변경

        Console.WriteLine("강아지의 이름은" + mydog.Name + "이고 나이는 " + mydog.Age + "입니다");
    }
}
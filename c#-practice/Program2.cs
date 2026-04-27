using System;

class Person
{
    public string Name; //사람의 이름을 저장하는 문자열 변수

    public void Eat() //메소드
    {
        Console.WriteLine(Name + "이(가) 식사를 합니다");
    }
}

class Program2
{
    public static void Main () // ->프로그램 실행 시 가장 먼저 호출
    {
        Person p1 = new Person(); //p1의 메모리 공간 할당, Person 클래스의 인스턴스 생성
        p1.Name = "서준"; //p1 객채의 anme 필드에 "서준' 저장
        p1.Eat();
    }
}
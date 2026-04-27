using System;

class cat
{
    public string Name;
    public int weight;

    public cat(String Cat)  // 생성자 1
    {
        Name = Name;
        Console.WriteLine("고양이의 이름은" + Name + "입니다.");
    }
    public cat(String Name, int weight) //생성자 2
    {
        Name = Name;
        weight = weight;
        Console.WriteLine("고양이의 이름은" + Name + "이고 몸무게는" + weight + "입니다");
    }
}

class Program3
{
    public static void Main(String[] args)
    {
        cat myCat1 = new cat("코코"); //my cat1 에서는 첫번째 생성자 호출
        cat myCat2 = new cat("물리", 5); // my cat2에서는 두번째 생성자 호출
    }
}
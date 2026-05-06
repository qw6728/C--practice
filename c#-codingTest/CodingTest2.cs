using System;

class Student
{
    public String Name;
    public int Score;

}

public class CodingTest2
{
    public static void Main()
    {
        Student[] student = new Student[3];
        {
            student[0] = new Student();
            student[0].Name = "영의";
            student[0].Score = 90;

            student[1] = new Student();
            student[1].Name = "철수";
            student[1].Score = 80;

            student[2] = new Student();
            student[2].Name = "바버";
            student[2].Score = 44;
        }

        int max = student[0].Score;
        string topName = student[0].Name;

        for (int i = 0; i < student.Length; i++)
        {
            if (student[i].Score > max)
            {
                max = student[i].Score;
                topName = student[i].Name;
            }
        }

        Console.WriteLine("1등" + topName);

    }
}
using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks.Sources;

class Student
{
    public string Name; // Name 필드 생성
    public int Score; // Score 필드 생성

    public Student(String Name, int Score) //Student 생성자
    {
        this.Name = Name; // 매개변수 Name을 필드 Name에 저장
        this.Score = Score; // 매개변수 Score을 필드 Score에 저장
    }
    public string GetGrade() //학점 계산하는 메소드
    {
        if (Score >= 100) return "A";
        else if (Score >= 90) return "B";
        else if (Score >= 80) return "C";
        else if (Score >= 70) return "D";
        else if (Score >= 60) return "F";
    }
}

class CodingTest1 // Main 클래스
{
    public static void Main(String[] args)
    {
        Student[] students = new Student[3]; //학생 배열 3명 생성

        String[] names = { "김", "윤", "박" };// 학생 이름 선언
        int[] scores = { 95, 85, 60 }; // 점수 선언

        for (int i = 0; i < students.Length; i++) // for구문으로 학생 객체 생성
        {
            students[i] = new Student(names[i], scores[i]);
        }

    

    int total = 0; // 총점,최소점,최대점 초기화
    int max = int.MinValue;
    int min = int.MaxValue;

    for (int i = 0; i<students.Length; i++) //학생 배열 순회
    {
            total += students[i].Score; // 점수 합계 누적

            if (students[i].Score > max) max = students[i].Score; //최고 점수 갱신 
            if (students[i].Score < min) min = students[i].Score; //최저 점수 갱신

            Console.WriteLine(students[i].Name + "의 학점: " + students[i].GetGrade());
    }

    double average = (double)total / students.Length; // 형 변환
    
    Console.WriteLine("평균 점수: " + average);
    Console.WriteLine("최고 점수: " + max);
    Console.WriteLine("최저 점수: " + min);
    }
}




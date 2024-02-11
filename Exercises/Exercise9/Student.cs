using System;
using System.Collections;
using static System.Console;
using System.Threading;
using System.Globalization;
using System.Reflection.Metadata;
using System.Runtime.InteropServices.ComTypes;
using Microsoft.VisualBasic;
namespace Exercise9;

public class Student
{
    public int StudentId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    private static int _studentNumber;
    
    public List<Lessons> LessonsList = new List<Lessons>();
    
     
    public Student(){}
    
    public Student(int StudentId, string FirstName, string LastName, int Age)
    {
        this.StudentId = StudentId;
        this.FirstName = FirstName;
        this.LastName = LastName;
        this.Age = Age;
    }
    
    public static int StudentNumber ()
    {
        Write("Insert student number: ");

        bool flag = int.TryParse(ReadLine(), out _studentNumber);

        while (flag == false)
        {
            WriteLine("Unknown answer! try again...");
            flag = int.TryParse(ReadLine(), out _studentNumber);
            Clear();
        }
        Clear();
        return _studentNumber;
    }
    
    public void PrintStudentInfo()
    {
        WriteLine("_______________________________________________________________________________________________");
        WriteLine("id:{0} \t first name:{1} \t last name:{2} \t age:{3}" , StudentId , FirstName , LastName , Age);
    }

    public void AddLesson(Lessons lesson)
    {
        LessonsList.Add(lesson);
    }
    
    
    
    
    
    
    
}

// Exercise9 - in this exercise we have a program that get user's first name and last name until the user wants to stop.
using System;
using System.Collections;
using static System.Console;
using System.Threading;
using System.Globalization;
using System.Reflection.Metadata;
using System.Runtime.InteropServices.ComTypes;
using Microsoft.VisualBasic;

namespace Exercise9
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            List<Student> StudentList = new List<Student>();
            int studentNumber = Student.StudentNumber();
            
            for (int i = 1; i <= studentNumber; i++)
            {
                Write("{0}.Enter your id: " , i);
                int studentId = Convert.ToInt32(ReadLine());
                Write("{0}.Enter your first name: ", i);
                string firstName = ReadLine();
                Write("{0}.Enter your last name: ", i);
                string lastName = ReadLine();
                Write("{0}.how old are you?: ", i);
                int age = Convert.ToInt32(ReadLine());
                Clear();
                
                Student student = new Student(studentId, firstName, lastName, age);
                
                
                Write("Enter number of lessons: ");
                int lessonNumber = Convert.ToInt32(ReadLine());

                for (int j = 1; j <= lessonNumber; j++)
                {
                    Write("{0}.Enter lesson id: ", j);
                    int lessonId = Convert.ToInt32(ReadLine());
                    Write("{0}.Enter lesson name: ", j);
                    string lessonName = ReadLine();
                    Write("{0}.Enter master name: ", j);
                    string lessonMaster = ReadLine();
                    Write("{0}.Enter lesson unit: ", j);
                    int lessonUnit = Convert.ToInt32(ReadLine());
                    Clear();
                    Lessons lessons = new Lessons(lessonId,lessonName,lessonMaster,lessonUnit);
                    student.AddLesson(lessons);
                }
                StudentList.Add(student);
            }

            foreach (var item in StudentList)
            {
                item.PrintStudentInfo();
                foreach (var item2 in item.LessonsList)
                {
                    item2.PrintLessonInfo();
                }
            }
            WriteLine("\npress any key to quit...");
            ReadKey();
        }
    }

}
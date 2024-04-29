using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace UniProject;

public class Courses
{
    public int CourseId { get; set; }
    public static int Id { get; set; } = 90;
    public string CourseName { get; set; }
    public int CourseUnit { get; set; }
    public string CourseMasterName { get; set; }

    public Courses(string CourseName, int CourseUnit, string CourseMasterName)
    {
        Id++;
        this.CourseId = Id;
        this.CourseName = CourseName;
        this.CourseUnit = CourseUnit;
        this.CourseMasterName = CourseMasterName;
    }
    
    public void Print()
    {
        Write("C-Id: {0}\n   Name:{1}\n   Unit: {2}\n   Master{3}\n", CourseId , CourseName , CourseUnit , CourseMasterName);
        WriteLine("\n________________________________________________________________________________________________________________________________");
    }

}
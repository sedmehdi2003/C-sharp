using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace UniProject;

public class Students : Parent
{
    public int StudentId { get; set; }
    public static int Id { get; set; } = 70;
    public List<Courses> StudentCourseList = new List<Courses>();
    public Students( string Name, string Family , string PhoneNumber, string City , int Age) : base(Name, Family, PhoneNumber, City, Age)
    {
        Id++;
        this.StudentId = Id;
    }
    /// <summary>
    /// printing personal status of student
    /// </summary>
    public override void Print()
    {
        Write("S-Id: {0}", StudentId);
        base.PrintParentInfo();
        WriteLine("\n________________________________________________________________________________________________________________________________");
    }

    /// <summary>
    /// this method adds courses to student
    /// </summary>
    /// <param name="courseItem">new course for student</param> 
    public void AddCourseForStudent(Courses courseItem)
    {
        StudentCourseList.Add(courseItem);
    }
    
}
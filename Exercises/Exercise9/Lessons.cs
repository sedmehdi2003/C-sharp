using System;
using System.Collections;
using static System.Console;
using System.Threading;
using System.Globalization;
using System.Reflection.Metadata;
using System.Runtime.InteropServices.ComTypes;
using Microsoft.VisualBasic;
namespace Exercise9;

public class Lessons
{
    public int LessonId { get; set; }
    public string LessonName { get; set; }
    public string LessonMaster { get; set; }
    public int LessonUnit { get; set; }

    public Lessons () {}
    public Lessons(int LessonId ,string LessonName,string LessonMaster ,int LessonUnit)
    {
        this.LessonId = LessonId;
        this.LessonName = LessonName;
        this.LessonMaster = LessonMaster;
        this.LessonUnit = LessonUnit;
    }
    
    public void PrintLessonInfo()
    {
        WriteLine("{0}-lesson id:{0} \t lesson name:{1} \t master name:{2} \t unit:{3}", LessonId , LessonName , LessonMaster , LessonUnit );
    }
}
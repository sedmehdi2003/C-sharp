using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace UniProject;

public class Masters: Parent
{
    public int MasterId { get; set;}
    public static int Id { get; set; } = 30;

    public Masters(string Name, string Family, string PhoneNumber, string City, int Age) : base(Name, Family, PhoneNumber, City, Age)
    {
        Id++;
        this.MasterId = Id;
    }
    public override void Print()
    {
        Write("M-Id: {0}", MasterId);
        base.PrintParentInfo();
        WriteLine("\n________________________________________________________________________________________________________________________________");
    }
    
}
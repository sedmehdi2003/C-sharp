using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace UniProject;

public class Employees: Parent
{
    public int EmployeeId { get; set;}
    public static int Id { get; set; } = 10;

    public Employees(string Name, string Family, string PhoneNumber, string City, int Age) : base(Name, Family, PhoneNumber, City, Age)
    {
        Id++;
        this.EmployeeId = Id;
    }
    public override void Print()
    {
        Write("E-Id: {0}", EmployeeId);
        base.PrintParentInfo();
        WriteLine("\n________________________________________________________________________________________________________________________________");
    }
    
}
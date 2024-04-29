using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace UniProject;

public abstract class Parent
{
    /// <summary>
    /// first name
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// last name
    /// </summary>
    public string Family { get; set; }
    /// <summary>
    /// phone number
    /// </summary>
    public string PhoneNumber { get; set; }
    /// <summary>
    /// City
    /// </summary>
    public string City { get; set; }
    /// <summary>
    /// Age
    /// </summary>
    public int Age { get; set; }
/// <summary>
/// Parent class constructor
/// </summary>
/// <param name="Name">first name</param>
/// <param name="Family">last name</param>
/// <param name="PhoneNumber">phone number</param>
/// <param name="City">City you live in</param>
/// <param name="Age">age</param>
    public Parent(string Name, string Family, string PhoneNumber, string City , int Age)
    {
        this.Name = Name;
        this.Family = Family;
        this.PhoneNumber = PhoneNumber;
        this.City = City;
        this.Age = Age;
    }

    public void PrintParentInfo()
    {
        Write("   Name: {0}\n   Family: {1}\n   Phone: {2}\n   City: {3}\n   Age: {4}\n", Name, Family, PhoneNumber, City, Age);
        
    }

    public abstract void Print();
}

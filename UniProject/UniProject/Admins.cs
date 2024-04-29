using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace UniProject;

public class Admins : Parent
{
    public int AdminId { get; set; }
    public static int Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }

    public Admins(string Username, string Password , string Name, string Family , string PhoneNumber, string City , int Age) :base(Name, Family, PhoneNumber, City , Age)
    {
        Id++;
        this.AdminId = Id;
        this.Username = Username;
        this.Password = Password;
    }

    public string PasswordHider()
    {
        string starPassword = Password;
        for (int i = 0; i < Password.Length; i++)
        {
            starPassword = starPassword.Replace(Password[i],'*');
        }
        return starPassword + "\n";
    }
    
    public override void Print()
    {
        Write("A-Id: {0}\n   Username: {1}\n   Password: {2}", AdminId , Username , PasswordHider());
        base.PrintParentInfo();
        WriteLine("\n________________________________________________________________________________________________________________________________");
    }
    
}
// Exercise8 - in this exercise we have a program that get user's first name and last name until the user wants to stop.
using System;
using System.Collections;
using static System.Console;
using System.Threading;
using System.Globalization;
using System.Reflection.Metadata;
using System.Runtime.InteropServices.ComTypes;
using Microsoft.VisualBasic;

namespace Exercise8
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            bool answer = true;
            int idCount = Member.GetId();
            
            bool Question()
            {
                string answers ="";
                while (answers != "y" && answers != "n")
                {
                    WriteLine("enough?(y, n)");
                    answers = ReadLine();
                    if (answers == "y")
                    {
                        answer = false;
                    }
                    else if (answers == "n")
                    {
                        answer = true;
                    }
                    else
                    {
                        WriteLine("Unknown answer !");
                    }
                }
                Clear();
                return answer;
            }
            
            
            List<Member> members = new List<Member>();
            
            while (answer == true)
            {
                Member user = new Member();
                Write("First name: ");
                user.FName = ReadLine();
                Write("Last name: ");
                user.LName = ReadLine();
                Clear();
                
                members.Add(user);
                
                Question();
            }

            if (answer == false)
            {
                for (int i = 0; i < members.Count; i++)
                {
                    WriteLine("{0}.\t id:{1} \t first name:{2} \t last name:{3}" , i+1 ,idCount++ , members[i].FName , members[i].LName);
                }
            }
            WriteLine("press any key to quit...");
            ReadKey();

        }
    }

    public class Member
    {
        private static int _Id = 100; // doesn't want to let user set id.
        public string FName { get; set; }
        public string LName { get; set; }
        private static int _Count { get; set; } = 0;

        public Member()
        {
            _Count++;
        }

        public static int GetId()
        {
            return _Id;
        }

        public static void MembersNumber()
        {
            WriteLine("There are {0} users:", _Count);
        }

        public void WriteInfo()
        {
            WriteLine("id:{0} \t first name:{1} \t last name:{2}" , _Id , FName , LName);
        }
    }

}
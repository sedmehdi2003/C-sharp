using System;
using System.Collections;
using static System.Console;
using System.Threading;
using System.Globalization;
using System.Runtime.InteropServices.ComTypes;

namespace Exercise7
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Member user1 = new Member(100);
            user1.FName = "amir";
            user1.LName = "khalili";

            Member user2 = new Member(101);
            user2.FName = "ali";
            user2.LName = "akbari";

            Member user3 = new Member(102);
            user3.FName = "soheil";
            user3.LName = "zamani";
            Member.MembersNumber();
            user1.WriteInfo();
            user2.WriteInfo();
            user3.WriteInfo();
            ReadKey();

        }
    }

    public class Member
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        private static int Count { get; set; } = 0;

        public Member(int Id, string FName = null, string LName = null)
        {
            this.Id = Id;
            this.LName = LName;
            this.FName = FName;
            Count++;
        }

        public static void MembersNumber()
        {
            WriteLine("There are {0} users:", Count);
        }

        public void WriteInfo()
        {
            WriteLine("id:{0} \t first name:{1} \t last name:{2}" , Id , FName , LName);
        }
    }

}
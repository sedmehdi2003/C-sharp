using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Console;
using System.Globalization;

namespace UniProject;

public class Methods
{
     /// <summary>
     /// this method prints error message for non int inputs.
     /// </summary>
     /// <param name="world"></param>
     public static void PrintJustNumber(string world)
     {
          DateTime.Now.PrintDateTime();
          WriteLine("Warning !!!\n");
          Thread.Sleep(3000);
          WriteLine("\tJust Numbers !!!");
          WriteLine("\tyou can type only number for {0}", world);
          WriteLine("\t\tRedirecting...");
          Thread.Sleep(3000);
          DateTime.Now.PrintDateTime();
     }

}
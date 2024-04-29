using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Globalization;

namespace UniProject
{
    class Program
    {
        static void Main(string[] args)
        {
             
            #region our Generic lists

            List<Admins> adminsList = new List<Admins>();
            List<Courses> coursesList = new List<Courses>();
            List<Employees> employeesList = new List<Employees>();
            List<Masters> mastersList = new List<Masters>();
            List<Students> studentsList = new List<Students>();

            #endregion

            #region default values in lists
            
            #region default values for admins

            Admins amirkh = new Admins("amir2003", "Amir2003" , "Amirmahdi" , "Khalili" , "09121223223" , "Tehran" , 20);
            adminsList.Add(amirkh);
            string adminPanelName = "";
            #endregion

            #region default values for employees

            Employees employee1 = new Employees("hossein", "alizade", "09015494759", "Karaj", 53);
            employeesList.Add(employee1);
            
            Employees employee2 = new Employees("parsa", "zareai", "09222587686", "Karaj", 42);
            employeesList.Add(employee2);
            
            #endregion

            #region default values for maasters

            Masters master1 = new Masters("hossein", "abdolkarimi", "09337856539", "qom", 42);
            mastersList.Add(master1);

            Masters master2 = new Masters("mina", "golzar", "09133447192", "qom", 29);
            mastersList.Add(master2);
            #endregion

            #region default values for students

            Students student1 = new Students("mahdi", "mandani", "09145236239", "Tehran", 19);
            studentsList.Add(student1);
            
            Students student2 = new Students("amin", "dashti", "09102244019", "Tehran", 21);
            studentsList.Add(student2);

            #endregion

            #region dafault values for courses

            Courses course1 = new Courses("Math",3,"Fateme Moslemi");
            coursesList.Add(course1);
            
            Courses course2 = new Courses("Databases",2,"Ali Zeighami");
            coursesList.Add(course2);
            #endregion
            #endregion

            #region sign in and register

            admin_menu:
            DateTime.Now.PrintDateTime();
            
            WriteLine("Admin login or registration form\n");
            WriteLine("1. Sign in");
            WriteLine("2. Register");
            Write("\nYour answer : ");
            int adminMenu;
            while (!int.TryParse(ReadLine(), out adminMenu))
            {
                Methods.PrintJustNumber("admin menu");
                goto admin_menu;
            }

            switch (adminMenu)
            {
                #region Admin login form
                
                case 1 :
                    DateTime.Now.PrintDateTime();
                    WriteLine("Admin Login form\n");
                    Write("Enter your username : ");
                    string adminUsernameSignIn = ReadLine();
                    Write("Enter your password : ");
                    string adminPasswordSignIn = ReadLine();

                    if (adminsList.Any(a => a.Username == adminUsernameSignIn && a.Password == adminPasswordSignIn))
                    {
                        var loggedAdmin = adminsList.First(a => a.Username == adminUsernameSignIn && a.Password == adminPasswordSignIn);
                        adminPanelName = loggedAdmin.Name + " " + loggedAdmin.Family;
                        DateTime.Now.PrintDateTime();
                        WriteLine("Welcome {0}", adminPanelName);
                        WriteLine("{0} You successfully logged in.\n\t\tRedirecting...",adminPanelName);
                        Thread.Sleep(3000);
                        break;
                    }

                    else
                    {
                        DateTime.Now.PrintDateTime();
                        WriteLine("Your username or password is incorrect\n\t\tRedirecting...");
                        Thread.Sleep(3000);
                        goto admin_menu;
                    }
                
                #endregion

                #region Admin register form

                case 2 :
                    DateTime.Now.PrintDateTime();
                    WriteLine("Admin registration form\n");
                    Write("Enter your name : ");
                    string adminName = ReadLine();
                    Write("Enter your family : ");
                    string adminFamily = ReadLine();
                    Write("Enter your age : ");
                    int adminAge = Convert.ToInt32(ReadLine());
                    Write("Enter your city : ");
                    string adminCity = ReadLine();
                    Write("Enter your phone : ");
                    string adminPhoneNumber = ReadLine();
                    Write("Enter new username : ");
                    string adminUsername = ReadLine();
                    Write("Enter new password : ");
                    string adminPassword = ReadLine();
                    
                    Admins admin = new Admins(adminUsername, adminPassword ,adminName , adminFamily , adminPhoneNumber, adminCity , adminAge);
                    adminsList.Add(admin);
                    DateTime.Now.PrintDateTime();
                    WriteLine("{0} {1} Your registration was successful.\n\tRedirecting...",adminName , adminFamily);
                    Thread.Sleep(3000);
                    break;

                #endregion
                
                default:
                    DateTime.Now.PrintDateTime();
                    WriteLine("Please enter a valid number!");
                    WriteLine("\t\tRedirecting...");
                    Thread.Sleep(3000);
                    goto admin_menu;
                    
            }
            

            #endregion
            
            #region Showing status
            
            menu_Base:
            
            DateTime.Now.PrintDateTime();
            Write("Admins : {0} |    ", adminsList.Count);
            Write("Masters : {0} |    ", mastersList.Count);
            Write("Employees : {0} |    ", employeesList.Count);
            Write("Courses : {0} |    ", coursesList.Count);
            Write("Students : {0}\n", studentsList.Count);
            WriteLine("___________________________________________________________________________________");
            
            #endregion

            #region printing main menu

            WriteLine("1. Change background color");
            WriteLine("2. Register new admin");
            WriteLine("3. Register new master");
            WriteLine("4. Register new course");
            WriteLine("5. Register new student");
            WriteLine("6. Register new employee");
            WriteLine("7. View list of admins");
            WriteLine("8. View list of masters");
            WriteLine("9. View list of courses");
            WriteLine("10. View list of students");
            WriteLine("11. View list of employees");
            WriteLine("12. Exit admin panel\n");
            
            Write("Your answer : ");
            int menuItem;

            while (!int.TryParse(ReadLine(),out menuItem))
            {
                Methods.PrintJustNumber("Main menu");
                goto menu_Base;
            }

            #endregion

            #region main menu codes
            
            switch (menuItem)
            {
                #region Changing background color

                case 1 :
                    Continue:
                    DateTime.Now.PrintDateTime();
                    WriteLine("{0} what color do you like as your background?" , adminPanelName);
                    WriteLine("1.Black");
                    WriteLine("2.Red");
                    WriteLine("3.blue");
                    WriteLine("4.Purple");
                    WriteLine("5.Green\n");
                    Write("Your answer is : ");
                    int color;

                    while (!int.TryParse(ReadLine(), out color))
                    {
                        Methods.PrintJustNumber("Background Color");
                        WriteLine("Redirecting...");
                        Thread.Sleep(3000);
                        goto Continue;
                    }

                    switch (color)
                    {
                    case 1 :
                        DateTime.Now.PrintDateTime();
                        Write("Changing background to 'Black'");
                        Thread.Sleep(5000);
                        BackgroundColor = ConsoleColor.Black;
                        DateTime.Now.PrintDateTime();
                        break;
                
                    case 2 :
                        DateTime.Now.PrintDateTime();
                        Write("Changing background to 'Red'...");
                        Thread.Sleep(5000);
                        BackgroundColor = ConsoleColor.DarkRed;
                        DateTime.Now.PrintDateTime();
                        break;
                        
                    case 3 :
                        DateTime.Now.PrintDateTime();
                        Write("Changing background to 'Blue'");
                        Thread.Sleep(5000);
                        BackgroundColor = ConsoleColor.DarkBlue;
                        DateTime.Now.PrintDateTime();
                        break;
                        
                    case 4 :
                        DateTime.Now.PrintDateTime();
                        Write("Changing background to 'Purple'");
                        Thread.Sleep(5000);
                        BackgroundColor = ConsoleColor.DarkMagenta;
                        break;
                
                    case 5 :
                        DateTime.Now.PrintDateTime();
                        Write("Changing background to 'Green'");
                        Thread.Sleep(5000);
                        BackgroundColor = ConsoleColor.DarkGreen;
                        DateTime.Now.PrintDateTime();
                        break;
                
                    default:
                        DateTime.Now.PrintDateTime();
                        WriteLine("Please enter a valid number!");
                        WriteLine("\t\tRedirecting...");
                        Thread.Sleep(5000);
                        goto Continue;
                    }
                    goto menu_Base;

                #endregion

                #region register new admin

                case 2 :
                    DateTime.Now.PrintDateTime();
                    WriteLine("Admin registration form\n");
                    Write("Enter your name : ");
                    string adminName = ReadLine();
                    Write("Enter your family : ");
                    string adminFamily = ReadLine();
                    Write("Enter your age : ");
                    int adminAge = Convert.ToInt32(ReadLine());
                    Write("Enter your city : ");
                    string adminCity = ReadLine();
                    Write("Enter your phone : ");
                    string adminPhoneNumber = ReadLine();
                    Write("Enter new username : ");
                    string adminUsername = ReadLine();
                    Write("Enter new password : ");
                    string adminPassword = ReadLine();
                    
                    Admins admin = new Admins(adminUsername, adminPassword ,adminName , adminFamily , adminPhoneNumber, adminCity , adminAge);
                    adminsList.Add(admin);
                    DateTime.Now.PrintDateTime();
                    WriteLine("{0} {1} Your registration was successful.\n\tRedirecting...",adminName , adminFamily);
                    Thread.Sleep(3000);

                    goto menu_Base;

                #endregion

                #region register new master

                case 3 :
                    
                    DateTime.Now.PrintDateTime();
                    WriteLine("\t{0} \n\t How many masters must be registered?" , adminPanelName);
                    Write("\nYour answer : ");
                    int masterCount;
                    while (!int.TryParse(ReadLine(), out masterCount))
                    {
                        Methods.PrintJustNumber("master registration");
                        WriteLine("\t{0} \n\t How many masters must be registered?" , adminPanelName);
                        Write("\nYour answer : ");
                    }

                    for (int i = 0; i < masterCount; i++)
                    {
                        DateTime.Now.PrintDateTime();
                        WriteLine("master registration form\n");
                        Write("Enter master {0} name : ", i+1);
                        string masterName = ReadLine();
                        Write("Enter master {0} family : ",i+1);
                        string masterFamily = ReadLine();
                        Write("Enter master {0} age : ", i+1);
                        int masterAge = Convert.ToInt32(ReadLine());
                        Write("Enter master {0} city : ", i+1);
                        string masterCity = ReadLine();
                        Write("Enter master {0} phone : ", i+1);
                        string masterPhoneNumber = ReadLine();
                    
                        Masters master = new Masters(masterName, masterFamily ,masterPhoneNumber , masterCity, masterAge );
                        mastersList.Add(master);
                        DateTime.Now.PrintDateTime();
                        WriteLine("{0} {1} registration was successful.",masterName , masterFamily);
                        Thread.Sleep(2000);

                        
                    }
                    Write("\n\tRedirecting...");
                    Thread.Sleep(3000);
                    goto menu_Base;

                #endregion

                #region register new course
                
                case 4 :
                    DateTime.Now.PrintDateTime();
                    WriteLine("\t{0} \n\t How many courses must be registered?" , adminPanelName);
                    Write("\nYour answer : ");
                    int courseCount;
                    while (!int.TryParse(ReadLine(), out courseCount))
                    {
                        Methods.PrintJustNumber("course registration");
                        WriteLine("\t{0} \n\t How many course must be registered?" , adminPanelName);
                        Write("\nYour answer : ");
                    }

                    for (int i = 0; i < courseCount; i++)
                    {
                        DateTime.Now.PrintDateTime();
                        WriteLine("Course registration form\n");
                        Write("Enter course {0} name : ", i+1);
                        string courseName = ReadLine();
                        Write("Enter course {0} unit : ",i+1);
                        int courseUnit = Convert.ToInt32(ReadLine());
                        Write("Enter course {0} master : ", i+1);
                        string courseMaster = ReadLine();
                    
                        Courses course = new Courses(courseName, courseUnit ,courseMaster);
                        coursesList.Add(course);
                        DateTime.Now.PrintDateTime();
                        WriteLine("{0} registration was successful.",courseName);
                        Thread.Sleep(2000);
                        
                    }
                    Write("\n\tRedirecting...");
                    Thread.Sleep(3000);
                    goto menu_Base;
                    
                #endregion

                #region register new student

                case 5 :
                    DateTime.Now.PrintDateTime();
                    WriteLine("\t{0} \n\t How many students must be registered?" , adminPanelName);
                    Write("\nYour answer : ");
                    int studentCount;
                    while (!int.TryParse(ReadLine(), out studentCount))
                    {
                        Methods.PrintJustNumber("student registration");
                        WriteLine("\t{0} \n\t How many student must be registered?" , adminPanelName);
                        Write("\nYour answer : ");
                    }

                    for (int i = 0; i < studentCount; i++)
                    {
                        DateTime.Now.PrintDateTime();
                        WriteLine("Student registration form\n");
                        Write("Enter student {0} name : ", i + 1);
                        string studentName = ReadLine();
                        Write("Enter student {0} family : ", i + 1);
                        string studentFamily = ReadLine();
                        Write("Enter student {0} age : ", i + 1);
                        int studentAge = Convert.ToInt32(ReadLine());
                        Write("Enter student {0} phone : ", i + 1);
                        string studentPhoneNumber = ReadLine();
                        Write("Enter student {0} City : ", i + 1);
                        string studentCity = ReadLine();
                        Students student = new Students(studentName, studentFamily, studentPhoneNumber, studentCity, studentAge);
                       
                        #region choosing course for student
                       
                        chooseUnit:
                        DateTime.Now.PrintDateTime();
                        WriteLine("\n\t{0}\n\tDo you choose a unit for student '{1} {2}'?\n\n\t1. Yes\n\t2. No", adminPanelName, studentName, studentFamily);
                        Write("\n\nYour Answer is : ");
                        int studentCourseAdd;
                        while (!int.TryParse(ReadLine(), out studentCourseAdd))
                        {
                            Methods.PrintJustNumber("course registration");
                            WriteLine("\n\t{0}\n\tDo you choose unit for student '{1} {2}'?\n\n\t1. Yes\n\t2. No", adminPanelName, studentName, studentFamily);
                            Write("\n\nYour Answer is : ");
                        }
                        
                        switch (studentCourseAdd)
                        {
                            #region Yes
                       
                            case 1:
                                DateTime.Now.PrintDateTime();
                                WriteLine("\n\t{0}\n\tHow many courses do you choose for student '{1} {2}'?", adminPanelName, studentName, studentFamily);
                                Write("\n\nYour Answer is : ");
                                int StudentCourseCount;
                                while (!int.TryParse(ReadLine(), out StudentCourseCount))
                                {
                                    Methods.PrintJustNumber("course registration");
                                    WriteLine("\n\t{0}\n\tHow many courses do you choose for student '{1} {2}'?", adminPanelName, studentName, studentFamily);
                                    Write("\n\nYour Answer is : ");
                                }
                       
                                for (int j = 0; j < StudentCourseCount; j++)
                                {
                                    DateTime.Now.PrintDateTime();
                                    WriteLine("Course registration form for student '{0} {1}'\n", studentName, studentFamily);
                                    Write("Enter course {0} name : ", j + 1);
                                    string courseName = ReadLine();
                                    Write("Enter course {0} unit : ", j + 1);
                                    int courseUnit = Convert.ToInt32(ReadLine());
                                    Write("Enter course {0} master : ", j + 1);
                                    string courseMaster = ReadLine();
                       
                                    Courses course = new Courses(courseName, courseUnit, courseMaster);
                                    student.AddCourseForStudent(course);
                                    DateTime.Now.PrintDateTime();
                                    WriteLine("{0} registration was successful.", courseName);
                                    Thread.Sleep(2000);
                                }
                       
                                break;
                       
                       
                            #endregion
                       
                            #region No
                       
                            case 2:
                                break;
                       
                            #endregion
                       
                            default:
                                goto chooseUnit;
                                
                        }
                        
                        #endregion
                        
                        studentsList.Add(student);
                        DateTime.Now.PrintDateTime();
                        WriteLine("{0} {1} registration was successful.", studentName , studentFamily);
                        Thread.Sleep(2000); 
                    }
                    Write("\n\tRedirecting...");
                    Thread.Sleep(3000);
                    goto menu_Base;
                    
                    #endregion

                #region register new employee
                
                case 6 :
                    DateTime.Now.PrintDateTime();
                    WriteLine("\t{0} \n\t How many employees must be registered?" , adminPanelName);
                    Write("\nYour answer : ");
                    int employeeCount;
                    while (!int.TryParse(ReadLine(), out employeeCount))
                    {
                        Methods.PrintJustNumber("employee registration");
                        WriteLine("\t{0} \n\t How many employee must be registered?" , adminPanelName);
                        Write("\nYour answer : ");
                    }

                    for (int i = 0; i < employeeCount; i++)
                    {
                        DateTime.Now.PrintDateTime();
                        WriteLine("employee registration form\n");
                        Write("Enter employee {0} name : ", i + 1);
                        string employeeName = ReadLine();
                        Write("Enter employee {0} family : ", i + 1);
                        string employeeFamily = ReadLine();
                        Write("Enter employee {0} age : ", i + 1);
                        int employeeAge = Convert.ToInt32(ReadLine());
                        Write("Enter employee {0} city : ", i + 1);
                        string employeeCity = ReadLine();
                        Write("Enter employee {0} phone : ", i + 1);
                        string employeePhoneNumber = ReadLine();

                        Employees employee = new Employees(employeeName, employeeFamily, employeePhoneNumber, employeeCity, employeeAge);
                        employeesList.Add(employee);
                        DateTime.Now.PrintDateTime();
                        WriteLine("{0} {1} registration was successful.", employeeName, employeeFamily);
                        Thread.Sleep(2000);
                    }
                    goto menu_Base;
                    
                #endregion

                #region view admins list
                
                case 7:
                    
                    viewAdmin:
                    DateTime.Now.PrintDateTime();
                    WriteLine("\n\tPlease select the type of information you want to fetch.\n\n\t1. View all admins list\n\t2. Search a admin");
                    Write("\n\nYour answer is : ");
                    int itemViewAdminList;
                    while (!int.TryParse(ReadLine(), out itemViewAdminList))
                    {
                        DateTime.Now.PrintDateTime();
                        Methods.PrintJustNumber("view admin list");
                        Thread.Sleep(3000);
                        DateTime.Now.PrintDateTime();
                        WriteLine("\n\tPlease select the type of information you want to fetch.\n\n\t1. View all admins list\n\t2. Search a admin");
                        Write("\n\nYour answer is : "); 
                    }

                    switch (itemViewAdminList)
                    {
                        #region printing admins list

                        case 1:
                            DateTime.Now.PrintDateTime();
                            foreach (var item in adminsList)
                            {
                                item.Print();
                            }
                            WriteLine("\n\nPress any key to return to the main menu ...");
                            ReadLine();
                            goto menu_Base;
                            
                        #endregion

                        #region search an admin

                            case 2:
                                DateTime.Now.PrintDateTime();
                                Write("Enter name of admin : ");
                                string adminNameFind = ReadLine();
                                Write("Enter family of admin : ");
                                string adminFamilyFind = ReadLine();
                                DateTime.Now.PrintDateTime();
                                WriteLine("You searched ' name : {0} $ family: {1} '\n",adminNameFind,adminFamilyFind);
                                var adminFind = adminsList.Where(Admin => Admin.Name.Contains(adminNameFind) || Admin.Family.Contains(adminFamilyFind));
                                foreach (var item in adminFind)
                                {
                                    item.Print();
                                }
                                WriteLine("\n\nPress any key to return to the main menu ...");
                                ReadLine();
                                goto menu_Base;
                                
                        #endregion
                        
                        default:
                            goto viewAdmin;
                    }
                    
                #endregion

                #region view masters list

                case 8 :
                    
                    viewMaster:
                    DateTime.Now.PrintDateTime();
                    WriteLine("\n\tPlease select the type of information you want to fetch.\n\n\t1. View all masters list\n\t2. Search a master");
                    Write("\n\nYour answer is : ");
                    int itemViewMasterList;
                    while (!int.TryParse(ReadLine(), out itemViewMasterList))
                    {
                        DateTime.Now.PrintDateTime();
                        Methods.PrintJustNumber("view master list");
                        Thread.Sleep(3000);
                        DateTime.Now.PrintDateTime();
                        WriteLine("\n\tPlease select the type of information you want to fetch.\n\n\t1. View all masters list\n\t2. Search a master");
                        Write("\n\nYour answer is : "); 
                    }

                    switch (itemViewMasterList)
                    {
                        #region printing master list

                        case 1:
                            DateTime.Now.PrintDateTime();
                            foreach (var item in mastersList)
                            {
                                item.Print();
                            }
                            WriteLine("\n\nPress any key to return to the main menu ...");
                            ReadLine();
                            goto menu_Base;
                            
                        #endregion

                        #region search an master

                            case 2:
                                DateTime.Now.PrintDateTime();
                                Write("Enter name of master : ");
                                string masterNameFind = ReadLine();
                                Write("Enter family of master : ");
                                string masterFamilyFind = ReadLine();
                                DateTime.Now.PrintDateTime();
                                WriteLine("You searched ' name : {0} $ family: {1} '\n",masterNameFind,masterFamilyFind);
                                var masterFind = mastersList.Where(Master => Master.Name.Contains(masterNameFind) || Master.Family.Contains(masterFamilyFind));
                                foreach (var item in masterFind)
                                {
                                    item.Print();
                                }
                                WriteLine("\n\nPress any key to return to the main menu ...");
                                ReadLine();
                                goto menu_Base;
                                
                        #endregion
                        
                        default:
                            goto viewMaster;
                    }

                #endregion

                #region view courses list

                case 9 :
                    
                    viewCourse:
                    DateTime.Now.PrintDateTime();
                    WriteLine("\n\tPlease select the type of information you want to fetch.\n\n\t1. View all courses list\n\t2. Search a course");
                    Write("\n\nYour answer is : ");
                    int itemViewCourseList;
                    while (!int.TryParse(ReadLine(), out itemViewCourseList))
                    {
                        DateTime.Now.PrintDateTime();
                        Methods.PrintJustNumber("view course list");
                        Thread.Sleep(3000);
                        DateTime.Now.PrintDateTime();
                        WriteLine("\n\tPlease select the type of information you want to fetch.\n\n\t1. View all courses list\n\t2. Search a course");
                        Write("\n\nYour answer is : "); 
                    }

                    switch (itemViewCourseList)
                    {
                        #region printing course list

                        case 1:
                            DateTime.Now.PrintDateTime();
                            foreach (var item in coursesList)
                            {
                                item.Print();
                            }
                            WriteLine("\n\nPress any key to return to the main menu ...");
                            ReadLine();
                            goto menu_Base;
                            
                        #endregion

                        #region search an course

                        case 2:
                            DateTime.Now.PrintDateTime();
                            Write("Enter name of course : ");
                            string courseNameFind = ReadLine();
                            DateTime.Now.PrintDateTime();
                            WriteLine("You searched ' course name : {0} '\n",courseNameFind);
                            var courseFind = coursesList.Where(Course => Course.CourseName.Contains(courseNameFind));
                            foreach (var item in courseFind)
                            {
                                item.Print();
                            }
                            WriteLine("\n\nPress any key to return to the main menu ...");
                            ReadLine();
                            goto menu_Base;
                                
                        #endregion
                        
                        default:
                            goto viewCourse;
                    }

                #endregion

                #region view students list

                case 10 : 
                    
                    viewStudent:
                    DateTime.Now.PrintDateTime();
                    WriteLine("\n\tPlease select the type of information you want to fetch.\n\n\t1. View all students list\n\t2. Search a student");
                    Write("\n\nYour answer is : ");
                    int itemViewStudentList;
                    while (!int.TryParse(ReadLine(), out itemViewStudentList))
                    {
                        DateTime.Now.PrintDateTime();
                        Methods.PrintJustNumber("view student list");
                        Thread.Sleep(3000);
                        DateTime.Now.PrintDateTime();
                        WriteLine("\n\tPlease select the type of information you want to fetch.\n\n\t1. View all students list\n\t2. Search a student");
                        Write("\n\nYour answer is : "); 
                    }

                    switch (itemViewStudentList)
                    {
                        #region printing student list

                        case 1:
                            DateTime.Now.PrintDateTime();
                            foreach (var item in studentsList)
                            {
                                item.Print();
                            }
                            WriteLine("\n\nPress any key to return to the main menu ...");
                            ReadLine();
                            goto menu_Base;
                            
                        #endregion

                        #region search an student

                        case 2:
                            DateTime.Now.PrintDateTime();
                            Write("Enter name of student : ");
                            string studentNameFind = ReadLine();
                            Write("Enter family of student : ");
                            string studentFamilyFind = ReadLine();
                            DateTime.Now.PrintDateTime();
                            WriteLine("You searched ' name : {0} $ family: {1} '\n",studentNameFind,studentFamilyFind);
                            var studentFind = studentsList.Where(Student => Student.Name.Contains(studentNameFind) || Student.Family.Contains(studentFamilyFind));
                            foreach (var item in studentFind)
                            {
                                item.Print();

                                #region printing coureses of student

                                //  another way to print student courses
                                //  foreach(var key in item.StudentCourseList)
                                // {
                                //     key.Print();
                                // }

                                for (int z = 0; z < item.StudentCourseList.Count; z++)
                                {
                                    item.StudentCourseList[z].Print();
                                }

                                #endregion
                            }
                            WriteLine("\n\nPress any key to return to the main menu ...");
                            ReadLine();
                            goto menu_Base;
                                
                        #endregion
                        
                        default:
                            goto viewStudent;
                    }

                #endregion
                
                #region view employees list

                case 11 :
                    viewEmployee:
                    DateTime.Now.PrintDateTime();
                    WriteLine("\n\tPlease select the type of information you want to fetch.\n\n\t1. View all employees list\n\t2. Search a employee");
                    Write("\n\nYour answer is : ");
                    int itemViewEmployeeList;
                    while (!int.TryParse(ReadLine(), out itemViewEmployeeList))
                    {
                        DateTime.Now.PrintDateTime();
                        Methods.PrintJustNumber("view employee list");
                        Thread.Sleep(3000);
                        DateTime.Now.PrintDateTime();
                        WriteLine("\n\tPlease select the type of information you want to fetch.\n\n\t1. View all employees list\n\t2. Search a employee");
                        Write("\n\nYour answer is : "); 
                    }

                    switch (itemViewEmployeeList)
                    {
                        #region printing employee list

                        case 1:
                            DateTime.Now.PrintDateTime();
                            foreach (var item in employeesList)
                            {
                                item.Print();
                            }
                            WriteLine("\n\nPress any key to return to the main menu ...");
                            ReadLine();
                            goto menu_Base;
                            
                        #endregion

                        #region search an employee

                        case 2:
                            DateTime.Now.PrintDateTime();
                            Write("Enter name of employee : ");
                            string employeeNameFind = ReadLine();
                            Write("Enter family of employee : ");
                            string employeeFamilyFind = ReadLine();
                            DateTime.Now.PrintDateTime();
                            WriteLine("You searched ' name : {0} $ family: {1} '\n",employeeNameFind,employeeFamilyFind);
                            var employeeFind = employeesList.Where(Employee => Employee.Name.Contains(employeeNameFind) || Employee.Family.Contains(employeeFamilyFind));
                            foreach (var item in employeeFind)
                            {
                                item.Print();
                            }
                            WriteLine("\n\nPress any key to return to the main menu ...");
                            ReadLine();
                            goto menu_Base;
                                
                        #endregion
                        
                        default:
                            goto viewEmployee;
                    }


                #endregion
                
                #region Exit

                case 12 :
                    DateTime.Now.PrintDateTime();
                    WriteLine("\n\t\tGoodbye ^^");
                    Thread.Sleep(2000);
                    goto admin_menu;                    

                #endregion

            }

            #endregion
            
        }
        
        
        
        
        
        
        
        
    }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
}
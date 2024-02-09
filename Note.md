## methods , key words & Points:

### Basics

* Notations: \
  Camel case : thisIsExample		(for variable) \
  Pascal case: ThisIsExample		(for class and method) \
  Snake case: this_is_example  /  This_Is_Example (for privates : _example) \
  Kebab case: this-is-example  /  This-Is-Example


**Data types memory size:**

  bool: 1 byte
  char: 1 byte
  int: 4 bytes
  float: 4 bytes
  double: 8 bytes
  decimal: 16 bytes


**Operations :**

/ %  - * \
+= -= *= %=        
< > <= >= !=       
&& || !

* we can have <br />
`Console.WriteLine("{0} {1} {2} {3}", name , family , age , flag)` <br />
or <br />
`Console.WriteLine($"{name} {family} {age} {flag}")` <br />
both outputs are same : name family age flag <br />
* difference between "if" and "else if" is when you declare an "if else"
  your saying if our current "if" worked dont check other expressions. <br />
```
while (!int.TryParse(Console.ReadLine(), out number))
{
	Console.Write("Enter your number: ")
}
```
* in "do/while" statement we need semicolon.
```
switch (number)
{
    case 1:
    case 20:
        codes
        break;
    case 2:
        codes
        break;
    default:
    codes
    break;
}
```
case value should be static value and can't be a variable.

* in C# we declare a array like this :
  ```int[] num = new int[7]``` or ```int[] num = {1 , 2, ... , 7} ``` or ```int[] num = new int[] {1, 2, ... , 7}```

```
foreach (int i in {array})
{
    Write(i);
}
```
output: it will write all indexes of our array.

* for converting a char array to string we can do this:
  string str = new string (charArray);

* when you connect methods , last method will be our output
  ```int A = name.Substring (3, 8).Replace("m", "*").IndexOf("s");``` <br />
  out put will be a int because our last method was .IndexOf() <br />
* this is how we declare 2D arrays: <br />
  `int [ , ] age = new int [3 , 4]` - 3 row and 4 column <br />
  for using matrices we need to use for in another for <br />
* ```Console.Write("")``` - writing without end line <br />
* ```Console.WriteLine("")``` - writing with end line <br />
* ```Console.ReadKey()``` - press any key to end program <br />
* ```{variable type}.Parse("only strings required")```- ```int.Parse(Console.readLine())``` <br />
* ```{variable type}.TryParse(string , out {variable})``` - ``` bool flag = int.TryParse(Console.ReadLine(), out number) ``` <br />
* ```Convert.{}()``` - ```Convert.ToInt32(22.55)``` <br />
* for converting float we should use `.Parse()` because Convert class doesn't have `Convert.ToFloat`. <br />
* ```continue;``` - skip current number of loop <br />
* ```Environment.NewLine``` or ```"\n"``` - ```string name = "Amir" + Environment.NewLine + "Mahdi";``` <br />
* ```Thread.Sleep();``` - ```Thread.Sleep(200);``` makes 200 m/s pause for every output. <br />
* ```Random {}``` - give us a random number, ```Random rand = new Random();``` <br />
* ```{variable}.Next()``` - random number range, ```rand.Next (1 , 10) ```
(1 , 10 actually means 1 , 9 because its x < 10. <br />
* ```using static System.Console;``` - no more need to type Console in whole project. <br />
* ```Console.Clear()``` - clear previous lines <br />
* ```{variable}.Length``` - it more use for arrays var.Length <br />
* ```var``` - is a variable type that automatically set when you declare data. <br />
* ```{variable}.ToCharArray()``` - ```char[] charText = variable.ToCharArray();``` <br />
* `DateTime.Now` - return date and time of now. <br />
* `System.Globalization;` - this is namespace for Calender. <br />
* `PersianCalendar {name} = new PersianCalender();` - works on Shamsi calendar. <br/>
* `GetDayOfMonth(Date.Now);` - calculating of day Shamsi. <br />
* `GetMonth(Date.Now);` - calculating of month Shamsi. <br />
* `GetYear(Date.Now);` - calculating of year Shamsi. <br />
this will make each letter of our string to charText indexes.
  <br />

### Strings

*  ```{variable}.IndexOf``` - search index in a string.
```
string name = "hello its amir";
int A = name.IndexOf("its");
``` 
now A is index number of first letter (i) , it means A = 6; <br />
you can also tell it start from specific index : ```int B = name.IndexOf("its", 10);``` <br />
and you can also search for first index of final repeated word in string by```{variable}.LastIndexOf()```
* ```{variable}.Replace(first input , second)``` - this will replace first input with second input in a string <br />
so ```string A = name.Replace('a' , '*');```
* ```{variable}.Remove(start index , end index)``` - this will remove from start index to end index <br />
    we can also save removed letters to a string```string A = name.Remove(6 , 10);``` <br />
    we can also remove just one index ```string A = name.Remove(10);``` <br />
    we can remove specific part of our string by using ```string A = name.Remove(name.IndexOf("ali") , 3);```<br />
* ```{variable}.Contains("ali")``` - it will give us a boolean if found the string that we specified <br />
*  ```{variable}.StartWith("ali")``` and ```{variable}.EndWith("ali")``` - check if we start or end the string with "ali" or not and output will be boolean. <br />
* ```{variable}.ToLower()``` - it will convert all upper case characters to lower case <br />
* ```{variable}.ToUpper()``` - it will convert all lower case characters to upper case <br />
* ```{variable}.Trim()``` - removes spaces from start and end of string <br />
we have also ```{variable}.TrimStart()``` and ```{variable}.TrimEnd()``` <br />
* `{variable}.Substring(3 , 5)` - remove from first index to 3 and type 8 indexes after 3. <br />
* `{variable}.ToString()` - convert everything to string <br />
* `{variable}.Split(' ')` - it will break your string with char you specified (' ') to parts and <br />
output will be array of a string <br /> and each index include seperated part`string[] A = name.Split (' ');` <br />
* `bool flag = {variable}.Equals(' ');` - if variable equals to your string it will output a true <br />
* `string[] A = string.Join ("-", name);` - first removes spaces and then add dash between words <br />

**jagged arrays:**
  

* you have to declare rows first you declare array`int [][] number = new int [3][]`  <br />
* for columns you should use this: <br />
  `number [0] = new int[4];` <br />
  `number [1] = new int[5];` <br />
  `number [2] = new int[6];` <br />
* for selecting each index in jagged arrays :
```
for (int i = 0; i < 3; i++){
  for (int j = 0; j < number[i].Length; j++)
  {

  }
}
```
or
```
for (int i = 0; i < 3; i++){
  foreach (var item in number[i])
  {
    
  }
}
```

### Collections

* Collections are so slower that arrays so if we know how much memory we need <br />
  we should use arrays otherwise we should use collections.<br />
  in collections data type doesn't matter. <br />
* first we should add library `using System.Collections`. <br />

**Array list:**

* in arrays we have 1 memory but with many (specified) parts that they are indexes <br />
  but in ArrayList we have many memories that each one known as a index. <br />
* `ArrayList {} = new ArrayList();` making array list `ArrayList {List1} = new ArrayList();`  <br />
we can add anything (any data types) to our list `List1.Add(800)` or `List1.Add("hello")` or <br />
you can add value by user :`List1.Add(Console.ReadLie());`
* for writing array list we use array form `Console.WriteLine(List1[1]);` <br />     
* in collection we don't have length method but we have same method that work like .Length:`List1.Count` <br />
```
for (int i = 0; i < List1.Count; i++)
{

}
```
* by using `{}.Remove(value)` we can remove an index of our list. `List1.Remove('a')`  <br />
in this method you should enter value of index. <br />
if we had many indexes with same value it will remove value with lower index number. <br />
* another method is `{}.RemoveAt()` and it removes an index by index number.<br />
`List1.RemoveAt(4)` it will remove index number 4. <br />
* `List.Clear();` this will remove all of our list. <br />
* `List.Sort();` it will sort ascending. doesn't have input. <br />
* `List.Reverse();` it reverses your list (last index = first index and so on) , doesn't have input. <br />
* for sorting descending first use `List.Sort();` and then `List.Reverse();` <br>
* `List.Contains();` search in the list , output is a boolean.<br>

**Sorted list:**
* in SortedList we have a key and value , key is place of our sorted list in memory key can be anything, <br />
  it means we can have our index (key) as a string. <br />
* when we declare first key other keys should have same data value for example: <br />
  when we have "home1" as our first key next key should made by string too. <br />
* sorted list sorts by keys (A-Z when is string) so if we have different value types for keys then it cant sort the list. <br />
* `SortedList List1 = new SortedList();` making a sorted list. <br/>
`SortedList List1 = new SortedList("one","hello")`. <br>
* for writing a sorted list : `Console.Write(List1["one"]);`. <br>
* you can write value or key by using `List1.Values` or `List1.Keys`. <br />
* for selecting values or keys from a list :
```
foreach (var item in List1.Values){

}
```
or 
```
foreach (var item in List1.Keys){

}
```
* Search for a key: `List1.ContainsKey()` , example: `List1.ContainsKey("one")` output is boolean. <br />
* search for a value `List1.CocntainsValue()` , example: `List1.CocntainsValue("hello");` output is boolean. <br />
* for adding new values to a list we use same methods that we were using in array lists. <br />
* in sorted lists we have actual indexes too but it will set after sort, <br/>
it means indexes doesnt set per list which defined at upper line. <br />
* Writing keys with values : <br />
```
foreach (var item in List1.keys){
  Console.WriteLine(item + " " + List1[item])
}
```

### Generic Collections

* for add generics `using System.Collections.Generic`. <br />


**List:**

* for defining a list : `List<data type> {name} = new List<data type>();` for example: `List<int> list1 = new List<int>();`. <br />
* we can use methods and tools of ArrayList for List too. <br />
* we can add a class to the list:
```
Student student = new Student();
// Student is a class name
List<Student> studentList = new List<Student>();
studentList.Add(student);
```
* foreach loop of list:
```
foreach (var item in List)
{
item.print(); // prints members of list
}
```
and for adding course to student class: <br/>


### Functions

* functions can have 0 to N inputs but their output will be 0 to 1. <br />
* functions name should be Pascal case. <br />
* creating a function in C# : <br />
``` 
static void Name (){
  codes
}
```
or 
``` 
static void Name (int a){
codes
}
``` 
or
```
static int Sum(int a , int b , int c){
//for example
int sum = a + b + c;
return sum;
}
```
or
```
static int Sum(int a , int b , int c){
//for example
return a + b + c;
}
```

* its better to create many small functions instead of one big function. <br />
* after creating a function you can hit backslash 3 times (///)to make a XML comment and add info for your function. <br />
* Method with multi inputs: <br />
we need to have multi functions with same name but different arguments and code doesn't matter. <br />

### OOP

* methods and classes should written by pascal case. <br />
* methods are shared between all shapes. <br /> 
* Fields are data members of our class. <br />
* object class inheriting every class, so you can use methods of class object. <br />
* you can add class as a .cs file to avoid long code lines <br />
and to use that class, namespace names should be same or you can use key word `using` plus namespace name. <br />

**creating new class and shape:**

```
class Student 
{
    int grade;
    int age;
    \\grade and age are properties
    void avgGrade()
    {
    \\this function called method
    }

}
```
* when you create new shape with `new` keyword, you can use methods of class. <br /> 
so we can create new shape this way: `Random number = new Random();` then we can use methods of class Random. <br />
* we can create new shapes with for loop to avoid repeated codes: <br />
```
List<Student> studentList = new List<Student>();

for (int i = 0; i < 3; i++)
{
Student student = new Student();
// Student is a class name
Console.writeLine("Enter id: ");
student.StudentId = Convert.ToInt32(Console.ReadLine());
Console.writeLine("Enter first name: ");
student.StudentFName = Console.ReadLine();
Console.writeLine("Enter lastname: ");
student.StudentLName = Console.ReadLine();
Console.writeLine("Enter age: ");
student.StudenAge = Convert.ToInt32(Console.ReadLine());

studentList.Add(student);
}
```
and then for writing we use: <br />
```
for (int i = 0; i < studentList.Count;i++)
{
Console.writeLine("studentList[i].StudentId + studentList[i].StudentFName + studentList[i].StudentLName + studentList[i].StudentFName + studentList[i].StudentAge");
}
```
and foreach loop:
```
foreach (var item in studentList)
{
Console.writeLine("item.StudentId + item.StudentFName + item.StudentLName + item.StudentFName + item.StudentAge");
}
```

**access levels:**

* we have 5 types of access levels :
public <br />
private <br />
protected <br />
internal <br />
protected internal <br />
* if you don't set access level system will imagine it as private. <br />
* we can also set field value in main class(if you set access level to public). <br />
* setting properties access level to public is dangerous because of security issues. <br />

**setter and getter me:**

* setter methods should be public and they have 1 or more arguments, <br /> 
so we can set value for private properties by setter methods. <br />
* getter methods should be public and they return property value, <br />
so we can have access value of private properties by getter method. <br />
* in new shapes, if we don't declare value of any int field it will be zero (0) automatically. <br />
* we can also set value to arguments, so when calling setter method, <br />
user can don't set values that we set in argument and it will be fill with argument value: <br />
```
public void Setter (int a, int b = 0,int c = 10) 
{
  codes...
}
```
* calling is like this: <br />
```
MyClass c1 = new MyClass();
c1.Setter(20);
```
* we should set value from right argument to left one. <br />

**overloading**

* overloading is creating a method with different inputs, it means we can set its arguments in different situations. <br />
* how to overload a method? for doing this we should declare a method several times with same name and different <br />
arguments data types or arguments numbers. <br />
```
class person 
{
  int personId;
  int personAge;
  string personName;
  
  public void Setter(int personId, int personAge, string personName)
  {
  this.personId = personId;
  this.personAge = personAge;
  this.personName = personName;
  }
  
  public void Setter(int personId, int personAge)
  {
  this.personId = personId;
  this.personAge = personAge;
  }
  
  public void Setter(int personId)
  {
  this.personId = personId;
  }

}
```
* when we call this method we can set arguments in different situations:
```
Setter(128 , 19 , "amir");
Setter(129 , 20);
Setter(130);
```
as you can see we called same method with different arguments numbers 

**`this` keyword**

* when properties are out of method scope and we have a setter method with all arguments (arguments are same name with property). <br />
for understanding that which property is out and which is our argument we use `this.{property}` key word. <br/>
for example: <br/>
```
public void Setter (int personId , string personFirstName , string personLastName)
{
this.personId = personId;
this.personFirstName = personFirstName;
this.personLastName = personLastName;
}
```

**Properties:**

* properties always use pascal case. <br />
* a field that can do set and get called property: <br />
```
public int PersonId 
{ 
  get
  {
    return {something};
  }
  set
  {
    personId = value;
  }
  
}
```
or we can simply use: <br />
```
public int PersonId { get; set; }
// this property will declare a field by name of the property.
```
* `value` is a key word that mean property's value type can place instead `value`. <br />
* for calling properties : <br />
if we want to set we should put property left side of `=` like: `person1.PersonId = 10;`. <br /> 
if we want to get we should put property right side of `=` like: `int x = person1.PersonId;`. <br />

**constructor method**

* constructor method makes our shape by `new` keyword. <br/>
* system defines a constructor method by default when we create a class. <br/>
* when we rewrite the constructor method, default constructor method will be destroyed. <br/>
* constructor method has same name as our class name. <br />
* how to make a constructor method: <br />
```
class Person
{
    public Person (int personId , string personFirstName , string personLastName)
    {
        this.personId = personId;
        this.personFirstName = personFirstName;
        this.personLastName = personLastName;
    }
}
```
* we can just use the constructor method to create a shape for one time and can't use shape after calling constructor. <br />
  
**Static**

* methods which we can access them by their class name, called static methods. <br />
* if a class member be static it wont be member of shape of class, it will be member of our class. <br />
* if a method is static, it only able to access static fields. <br />
* static members belong to all members of the class so value would be shared. <br />
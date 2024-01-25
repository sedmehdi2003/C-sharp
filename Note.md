
Points:

* Notations ->
Camel case : thisIsExample		(for variable)
Pascal case: ThisIsExample		(for class and method)
Snake case: this_is_example  /  This_Is_Example (for privates : _example)
Kebab case: this-is-example  /  This-Is-Example

* Data types memory size:
bool: 1 byte
char: 1 byte
int: 4 bytes
float: 4 bytes
double: 8 bytes
decimal: 16 bytes

* we can have ```Console.WriteLine("{0} {1} {2} {3}", name , family , age , flag)```  - output : name family age flag

* Operations :
- * / %           += -= *= %=        < > <= >= !=       && || !

* difference between "if" and "else if" is when you declare an "if else" 
your saying if our current "if" worked dont check other expressions.
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

* {variable}.IndexOf - search index in a string.
```
string name = "hello its amir";
int A = name.IndexOf("its");
```
now A is index number of first letter (i) , it means A = 6;

























methods & key words: 

* Console.Write("") - writing without end line

* Console.WriteLine("") - writing with end line

* Console.ReadKey() - press any key to end program 

* {variable type}.Parse("only strings required") - ```int.Parse(Console.readLine())```

* {variable type}.TryParse(string , out {variable}) - ``` bool flag = int.TryParse(Console.ReadLine(), out number) ```

* Convert.{}() - Convert.ToInt32(22.55)

* continue; - skip current number of loop 

* Environment.NewLine or \n - ```string name = "Amir" + Environment.NewLine + "Mahdi";```

* Thread.Sleep(); - ```Thread.Sleep(200);``` makes 200 m/s pause for every output.

* Random {variable} - give us a random number, ```Random rand = new Random();```

* {variable}.Next() - random number range, ```rand.Next (1 , 10) ```
(1 , 10 actually means 1 , 9 because its x < 10.

* using static System.Console; - no more need to type Console in whole project.

* Console.Clear() - clear previous lines

* {variable}.Length - it more use for arrays var.Length

* var - is a variable type that automatically set when you declare data.
 
* {variable}.ToCharArray() - ```char[] charText = variable.ToCharArray();```
this will make each letter of our string to charText indexes. 

### Points:

* Notations: \
Camel case : thisIsExample		(for variable) \
Pascal case: ThisIsExample		(for class and method) \
Snake case: this_is_example  /  This_Is_Example (for privates : _example) \
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

/ %  - * \
+= -= *= %=        
< > <= >= !=       
&& || !

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

* when you connect methods , last method will be our output 
```int A = name.Substring (3, 8).Replace("m", "*").IndexOf("s");``` <br />
out put will be a int because our last method was .IndexOf()

  <br />
  <br />
  <br />
  <br />
  <br />

### methods & key words:

* ```Console.Write("")``` - writing without end line
  <br />
  <br />
* ```Console.WriteLine("")``` - writing with end line
  <br />
  <br />
* ```Console.ReadKey()``` - press any key to end program
  <br />
  <br />
* ```{variable type}.Parse("only strings required")```- ```int.Parse(Console.readLine())```
  <br />
  <br />
* ```{variable type}.TryParse(string , out {variable})``` - ``` bool flag = int.TryParse(Console.ReadLine(), out number) ```
  <br />
  <br />
* ```Convert.{}()``` - ```Convert.ToInt32(22.55)```
  <br />
  <br />
* ```continue;``` - skip current number of loop
  <br />
  <br />
* ```Environment.NewLine``` or ```"\n"``` - ```string name = "Amir" + Environment.NewLine + "Mahdi";```
  <br />
  <br />
* ```Thread.Sleep();``` - ```Thread.Sleep(200);``` makes 200 m/s pause for every output.
  <br />
  <br />
* ```Random {variable}``` - give us a random number, ```Random rand = new Random();```
  <br />
  <br />
* ```{variable}.Next()``` - random number range, ```rand.Next (1 , 10) ```
(1 , 10 actually means 1 , 9 because its x < 10.
  <br />
  <br />
* ```using static System.Console;``` - no more need to type Console in whole project.
  <br />
  <br />
* ```Console.Clear()``` - clear previous lines
  <br />
  <br />
* ```{variable}.Length``` - it more use for arrays var.Length
  <br />
  <br />
* ```var``` - is a variable type that automatically set when you declare data.
  <br />
  <br />
* ```{variable}.ToCharArray()``` - ```char[] charText = variable.ToCharArray();``` <br />
this will make each letter of our string to charText indexes.
  <br />
  <br />

#### Strings:

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
* `{variable}.Split(' ')` - it will break your string with char you specified (' ') to parts and output will be array of a string <br /> and each index include seperated part 
`string[] A = name.Split (' ');` <br />
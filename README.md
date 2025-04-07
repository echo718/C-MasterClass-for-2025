Chapter 2: Foundations
1. Ctrl+shift+p type.net select console app
then app will be created automatically, then dotnet run
2. in Bin folder, .dll file is used for save files that computer can understand, .exe can run the app
3.shift+alt+up/down copy current line up/down
4. console.writeLine(a-b) will not work as subtraction operator is lower, but + and * and / works
5.Console.ReadLine() read user input
6. Add comment:/*00*/,  ctrl+k+c can add comment to multiple lines, ctrl+k+u to uncomment
7. int.Parse(value); change from string to number type
8. string interpolation: $"this is:{a},second is:{b}"; or $"sum is :{a+b}";
9. Char type means only one letter, write with singlequote: 'a';
string type means many letters, write with double quote:"abc";
10. int[] numbers = new int[3];=> is an array, numbers[0], numbers[1],numbers[2]is 0; 
	numbers[numbers.length-2] same as number[^2]; ^ means index from end 2 operator
	also, if declare with values: int[] numbers = new int[]{1,2,3,4};
	char[,] letters = new char[2,3]=>declare an array with 2 rows, 3 columns.
	or, we can declare with valules: var words = new []{1,2,3};
11. foreach(a in test){};
12. Array length is fixed, List size can be changed.
	List<string> words = new List<string>();=>words length is words.Count, then will get 0.
	words.Add("test"); to create values, 
words[0] to get value, 
words.Remove("test") to remove item,  
words.RemoveAt(0); remove first element; 
words.IndexOf("test") find the index of words;
words.Clear()
13. if a function aims to return multiple values, can use Out keywords as a parameter, eg:
 Calculate(int a, int b, out int sum, out int product)
    {
        sum = a + b;
        product = a * b;
    }
int resultSum, resultProduct; // No need to initialize
Calculate(x, y, out resultSum, out resultProduct);
Console.WriteLine($"Sum: {resultSum}, Product: {resultProduct}");
14. int.TryParse(value,out int number)=>return Boolean, if parse to int succeed, return true, number is int type value; if parse not succeed, return nothing, number is 0
-15. oop means face to object, based on object concept, object can have list object, include person, abstract object, for object we create class. 
------------------------------

Chapter 3: OOP
1. class name first letter is capital, class first build fields,eg: public int a;-- this is initialized to 0 automatically;
	constructor is created to pass parameter; use ctor tab tab quick create;ctor name is same with class name, public classname (){};
	if we public a field in class, public int (variable name first letter should be capital);
	if we private a field in class, name start with underscore, eg: private int _-base
	if name as name variable in c#, use @, such as @base
2. method overloading:
in class, we can have two same method name, but parameter type should be different
3. expression: evaluates to a value;eg: getText();
statement: not evaluate to a value; eg:if statement;
4. if a method only return one line, we can write as: public int a() => a*b; 
5. this keyword: reference the current class;
6. optional parameter: int daysFromNow = 7; must appear after all parameters; if more thanone optional parameter, we have to clarify the parameter name when invoke it;
7. in the method, declare a variable no need var, can int a=3; direcly
8. nameof() return a string of a variable
9. readonly can only be assigned at the declaration or in ctor;eg public readonly int a; try use readonly is good practice;
const int Name = 1; is a const type variable; const variable name start with capital letter; no matter in method or initial declaration;
10. property: when we public a variable and set value, we do like this:
private int _test;
public int Test
{
get =>_test; or can write like this:
get{ return _test;}
set=>_test = value; or can write this:
set{
_test = value;
}
}
it's old version for c#, now we write like:
public int Test {get; private set;}
fields: is variable-like, single access modifier;
properties: method-like, separate access for getter and setter;
11. object initializers: if we use ctor, can't initializer again.
12. computed property:
method represents actions; properties represent data;
13. static class can't be instantiated, only works as a container; const can't be initialized, if const don't work, try static.
14. single responsibility principle: one class should responsibility for one purpose/method, such addfile only, 
repositories are classes or components that encapsulate the logic required to access data resources, so if logic is relative to access data resource, can me as class NamesRepository{};
15.namespace can include classes, then each class can invoke directly even though not in the same cs file; but if different namespace, have to use using ** ;
16. global using directive: if use one at many  files, we can glable using** directly, then other files no need to import again

----------------------------------------------
    
Chapter 4: OOP Advanced
1. polymorphism 多态性: offer a single interface to entities of different types, 
Inheritance继承: public class dog:animal{}, dog继承animal的类型， animal是polymorphism, we can invoke animal public and protected method from dog class, dog can inheritance public and protected method from animal.
2. If dog class override a variable which also exist in animal, even though we invoke animal class variable, it still same as dog. 
eg: public class Animal
{
public string Name{get;}="test";
}
public class Dog: Animal
{
public override string Name=>"test1"
}
Animal newAnimal = new Dog();
newAnimal.Name => is test1, not test.
3. virtual method:
virtual method combine with override method can help avoid code duplicated,
	eg: public class NumberSumCalculater
	{
	 public int Calculate(List<int> numbers)
	{
		int sum=0;
	foreach(int number in numbers)
	{
		if(IsAddNumber(number))
		{
			sum+=number;
		}
	}
	return sum;
	}
	protected virtual bool IsAddNumber(int number)
	{
		return true;
	}
	}
	--
	public class PositiveCalculater : NumberSumCalculater
	{
		public override bool IsAddNumber(int number)
		{
			return number>0
		}
	}
	var numbers = new List<int>{1,2,3,4};
	NumberSumCalculater calculater = new NumberSumCalculater(_);
	or 
	NumberSumCalculater calculater = new PositiveCalculater(_);
	
	int results = calculater.Calculate(numbers);
	For above code logic, if invoke PositiveCalculater method, results only calculate positive numbers;
	if invoke NumberSumCalculater method, results calculate all numbers

4.we try to avoid multiple inheritance, otherwise too complex
5.base keyword: within a derived class. base keyword is used to access base class member/method/properties
eg: call base.Show() in derive class, it will call parent Show method.
6.Implicit/explicit Conversion转换: 
implicit模糊 conversion doesn't require cast expression,
explicit conversion: int d = (int)c=>c is decimal type
7.upcasting: from derived class to base class=>work
downcasting: from base class to derived class=>not work
8.is operator: used to check if some object is of a give type, eg: string word="h"; bool isInt = word is int; we can use is operator to check the type, then case the variable
9.as operator: type conversion, compared with cast, as will return null if case fails, but if use explicit conversion, will cause an exception if case fails.
10.Abstract class and method:
abstract method can only be declared in abstract class, normal method can be declared in both abstract and non-abstract class.
abstract method not provide any implementation.
eg://Abstract method - no implementation
    public abstract void MakeSound();
11.Sealed class and method: sealed class can't be inheritance, eg: sealed class Car{}, then next class if write:Car will cause error.
sealed method can precent further overriding in child class.
12.static class: can't be derive from them, eg:
public static class A{public static methodName(){}}
var test = new A()=>will cause error, 
correct: var test = A.methodName();
static method can't be overridden because it's sealed method
13.extension method: we can create a method and invoke without change resource code,
it must be a static class and method, use this as the first parameter
eg:
namespace Polymorphism.Extensions
{
	public static class StringExtensions
	{
		public static int Countlines(this string input)=>
			input.split(Environment.NewLine).Length;
	}
}
14.add @ symbol in from of string, will allow you write multiple lines
eg: var a = @"a
b
c";
15.interface: create a behaves-like relationship between types, such as class bird, kite, plane they all can fly, 
compared with Inheritance, it's a is-a relationship between types.
interface method will be implemented in class not interface.
eg: public interface IFly
{
int Transform(int number);
}
public class test: IFly
{
	public int Transform(int number)=> ++number;
}
Interface&&abstract class difference:
interface not include any data, no implementation; define " behaviour" "can do","is able to"
abstract class can contain data, can implement in non-abstract method. define"is","category""is-a"
both can't be inheritance. 
16.
JSON:JsonSerializer.Serialize(a);=>return object as JSON string.
a is an object     
JsonSerializer.Deserialize<A>(a); =>must put return type and change json to string;

------------------

Chapter 5:
1. throw new Exception("***"), different with throw, throw preserves the stack trace, whereas throw ex will not preserve the stack trace, we will lose information about the first place where error occurs.
2. try to avoid use throw; as it can't offer precise information.
3. we can create a global try-catch in app base point, such as:
 try{
Run();
}catch(Exception ex)
{
Console.WriteLine(" app error");
Console.ReadyKey(); // readykey monitor ctril, alt, single key press; readLine return string type
}
4. exception filer, we can add when(ex.**) to filer the different exception type
try{}
catch(HTTPRequestException ex) when (ex.Message = 403)
{
	**
}
5. we can custom exception, except using buildin exceptions, such as ArgumentException("") or ArgumentOutOfRangeException(""), ArgumentNullException(""), InvalidOperationException("")
6. change console color:Console.ForegroundColor = ConsoleColor.Red;




















	

//RECURSION EXAMPLES -1.
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

/*class Program
{
    static int Factorial(int n)
    {
        if (n == 0 || n == 1)
        return 1;
        else
        return n * Factorial(n-1);
    }
    static void Main()
    {
        Console.WriteLine("Enter a number");
        int num = Convert.ToInt32(Console.ReadLine());

        int result = Factorial(num);
        Console.WriteLine($"Factorial of {num} is: {result}");
    }
}*/

//2.
/*public class MedicineBox<T>
{
    private  List<T> medicines = new List<T>();

    public void Add(T medicine)
    {
        medicines.Add(medicine);
        Console.WriteLine($"{medicine} added to box.");
    }
}
class Program
{
    static void Main()
    {
        var nameBox = new MedicineBox<string>();
        nameBox.Add("Paracetamol");
        nameBox.Add("Vitamin C");

        var idBox = new MedicineBox<int>();
        idBox.Add(101);
        idBox.Add(202);

    }
}*/

//3.
/*public class Locker<T>
{
    public T item {get; set;}

}
class Program
{
    static void Main()
    {
        var jewelryLocker = new Locker<string> {item = "Gold Necklace"};
        var cashLocker = new Locker<int> {item = 50000};

        Console.WriteLine($"Jewelry: {jewelryLocker.item}");
        Console.WriteLine($"Cash: {cashLocker}");
    }
}*/

//4.
/*public class Bag<T>
{
    private List<T> items = new List<T>();

    public void AddItem(T item)
    {
        items.Add(item);
    }
    public void ShowItems()
    {
        foreach(var item in items)
        {
            Console.WriteLine(item);
        }
    }
}
class Program
{
    static void Main()
    {
        var bookBag = new Bag<string>();
        bookBag.AddItem("Math Book");
        bookBag.AddItem("Science NoteBook ");
        bookBag.ShowItems();

        
    }
}*/

//5. 
/*public class Library<T>
{
    private List<T> items = new List<T>();

    public void AddItem(T item)
    {
        items.Add(item);
        Console.WriteLine($"{item} added to library");
    }
    public void DisplayItems()
    {
        foreach(var item in items)
        {
            Console.WriteLine(item);
        }
    }
}
public class Book
{
    public string Title {get; set;}
    public override string ToString() => $"Book: {Title}";
}
class Program
{
    static void Main()
    {
        Library<Book> bookLibrary = new Library<Book>();
        bookLibrary.AddItem(new Book{ Title = "C# basics"});
        bookLibrary.AddItem(new Book{ Title = "Generics in Depth"});
        bookLibrary.DisplayItems();
    }
}*/

//6.
/*public class Printer
{
    public void Print<T>(T data)
    {
        Console.WriteLine(data);
    }
}
class Program
{
    static void Main()
    {
        Printer P = new Printer();
        P.Print<int>(100);
        P.Print<string>("Hello Generics");
    }
}*/

//6.
/*public interface IRepository<T>
{
    void Add(T item);
    T Get(int id);
}*/
//7.
/*public class Utility
{
    public void PrintData<T>(T Data)
    {
        Console.WriteLine("Data: " + Data);
    }
}
class Program
{
    static void Main()
    {
        Utility util = new Utility();
        util.PrintData<int>(500);
        util.PrintData<string>("Hello!");
    }
}*/

//8.
/*class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        numbers.Add(10);
        numbers.Add(20);

       foreach (int num in numbers)
{
    Console.WriteLine(num);  

List<string> names = new List<string>();
names.Add("Rahul");
names.Add("Priya");

foreach (string name in names)
{
    Console.WriteLine(name);  
}
    }
    }
}*/

//9.
/*class Program
{
    static void Main()
    {
        List<string> students = new List<string>();
       
       students.Add("Rahul");
       students.Add("Priya");
       students.Add("Amit");

       Console.WriteLine("Students List");
       foreach(string student in students)
        {
            Console.WriteLine("student");
        }

        students.Remove("Priya");

        if (students.Contains("Rahul"))
        {
            Console.WriteLine("Rahul in list present");
        }
        Console.WriteLine("All Students: ", +students.Count);
    }
}*/

//List or Array ma difference dijiya
//Array- example
/*class Program
{
    static void Main()
    {
        int[] numbers = new int[3];
        numbers[0] = 10;
        numbers[1] = 20;
        numbers[2] = 30;

        Console.WriteLine("Array elements:");
        foreach(int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}*/

//List example
/*class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(30);
        numbers.Add(40);

        Console.WriteLine("List elements");

        foreach(int num in numbers)
        {
            Console.WriteLine(num);
        }

        numbers.Remove(20);
        Console.WriteLine("After removing 20:");

        foreach(int num in numbers)
        {
            Console.WriteLine(num);
        }

    }
}*/

//try,catch and finally method questions
/*class Program
{
    static void Main()
    {
        int balance = 5000;

        try
        {
            Console.WriteLine("Enter amount to withdraw");
            int amount = Convert.ToInt32(Console.ReadLine());

            if(amount > balance)
            {
                throw new InvalidOperationException("Insufficient balance!");
            }
            balance -= amount;
            Console.WriteLine("Withdrawl successfull. Remaining bnalance: " +balance);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unexcepted errror: ", ex.Message);
        }
        finally
        {
            Console.WriteLine("Transaction process completed.");
        }
    }
}*/

//
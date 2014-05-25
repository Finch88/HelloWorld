using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}*/

//Needs to be in a class, but doesn't need a namespace
class HelloWorld
{
    public void Write()
    {
        Console.WriteLine("Hello World!");
    }
}

class Rectangle
{
    //member variables
    double length, width;

    public void AcceptDetails()
    {
        length = 4.5;
        width = 3.5;
    }
    public double calcArea()
    {
        return length * width;
    }
    public void display()
    {
        Console.WriteLine("Length: {0}",length);
        Console.WriteLine("Width: {0}", width);
        Console.WriteLine("Area: {0}", calcArea());
    }
    public void SetLength(double l)
    {
        length = l;
    }
    public void SetWidth(double w)
    {
        width=w;
    }

}

class Execute
{
    static void Main()
    {
        HelloWorld hw = new HelloWorld();
        hw.Write();

        Console.WriteLine("\n");

        Rectangle r = new Rectangle();
        r.AcceptDetails();
        Console.WriteLine("Input length:");
        //r.SetLength(Convert.ToDouble(Console.ReadLine()));
        Console.WriteLine("Input width:");
        //r.SetWidth(Convert.ToDouble(Console.ReadLine()));

        r.display();

        //initialise all to zero with new
        double[] array = new double[10];
        //int[] marks = new int[] { 2, 1, 5, 2, 6 };
        int[] marks = { 2, 1, 5, 2, 6 };
        for (int i = 0; i < 5; i++)
        {
            Console.Write("{0} \t {1} \n", array[i], marks[i]);
        }
        foreach (int i in marks)
        {
            Console.Write("{0} \t", i);
        }
        Console.WriteLine();    
        
        //you can do other stuff with strings in c#
        string fname, sname;
        fname = "Jimmy";
        sname = "McCarthy";
        string fullName = fname + sname;
        Console.WriteLine("\n Hello world, my name is: {0}", fullName);

        //array of strings
        string[] sarray = { "Hello", "World", "I can", "Join", "String Arrays" };
        foreach (string s in sarray) { Console.Write("{0}  ", s); }
        Console.WriteLine();
        string joint = String.Join(" ",sarray);
        Console.WriteLine(joint);

        //DateTime variable type DateTime(year month, day, hour, minute, second
        DateTime dt = new DateTime(2014, 01, 12, 22, 40, 00);
        //Format DateTime
        Console.WriteLine(String.Format("\n Display the date {0:D} at time {0:t}",dt));

        Console.WriteLine("\n StringComparisons");
        StringComparison[] comparisons = (StringComparison[])Enum.GetValues(typeof(StringComparison));
        foreach (var comparison in comparisons)
        {
            Console.WriteLine(comparison);
        }
        
        sname = "jimmy";
        //Default String.Equals is case sensitive
        if (fname.Equals(sname,StringComparison.OrdinalIgnoreCase)) { Console.WriteLine("\n {0} equals {1}", fname, sname); }
        else { Console.WriteLine("\n {0} does not equal {1}", fname, sname); }

        Console.WriteLine("Enter any key to exit!");
        Console.ReadKey();  
    }
}

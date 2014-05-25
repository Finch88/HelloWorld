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

// Interface defines some functions all classes inheriting it must have
// Doesn't require a particular definition
public interface shapes
{
    double calcArea();
}
class Rectangle: shapes
{
    //member variables
    //default access is private
    double length, width;

    //constructors
    public Rectangle() {
        Console.WriteLine("Creating a rectangle");
    }

    public Rectangle(double l, double w)
    {
        Console.WriteLine("Creating a rectangle with length= {0} and width= {1}", l, w);
        SetLength(l);
        SetWidth(w);
    }
    //destructor
    ~Rectangle()
    {
        Console.WriteLine("Deleting rectangle");
    }

    // no matter how many rectangle obects are made, there is only one instance of static members
    private static int statVar=0;

    public void addToStatVar()
    {
        statVar++;
    }
    //static mumber functions can only get static variables
    public static int getStatVar() { return statVar; }
    public const double pi = 3.14159;
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
    public double GetLength(){ return length; }
    public double GetWidth(){ return width; }

    // overloading operators needs to be declared public and static
    // = operator can't be overloaded
    public static Rectangle operator+ (Rectangle a, Rectangle b)
    {
        Rectangle c = new Rectangle();
        c.SetLength(a.GetLength()+b.GetLength());
        c.SetWidth(a.GetWidth()+b.GetWidth());
        return c;
    }

}
// Derived class:
class ColouredRectangle : Rectangle
{
    public ColouredRectangle() {}
    public ColouredRectangle(double l, double w, string col) : base(l, w) 
    {
        colour = col;
    }
    private string colour;
    public void setColour(string col){ colour=col; }
    public string getColour() { return colour;  }
    public void display()
    {
        base.display();
        Console.WriteLine("Colour: {0}", colour);
    }
}

class Triangle: shapes
{
    //member variables
    //default access is private
    double width, height;

    //constructors
    public Triangle() {
        Console.WriteLine("Creating a rectangle");
    }

    public Triangle(double b,double h)
    {
        Console.WriteLine("Creating a triangle with base= {0} and height= {1}", b, h);
        SetHeight(h);
        SetWidth(b);
    }
    //destructor
    ~Triangle()
    {
        Console.WriteLine("Deleting triangle");
    }
    public double calcArea()
    {
        return 0.5 * width * height;
    }
    public void display()
    {
        Console.WriteLine("Base: {0}",width);
        Console.WriteLine("Height: {0}", height);
        Console.WriteLine("Area: {0}", calcArea());
    }
    public void SetHeight(double h)
    {
        height = h;
    }
    public void SetWidth(double w)
    {
        width=w;
    }
}
class Execute
{
    // structure is a datatype holding related data types    
    struct Cards
    {
        public string suit;
        public string value;

        public void Print()
        {
            Console.Write("{0} of {1}", value, suit);
        }
    }
    //enumeration list useful for finding position in list 
    // Needs to be defines outside of main
    enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat };

    static void Main()
    {
        HelloWorld hw = new HelloWorld();
        hw.Write();

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
        Console.WriteLine("\nHello world, my name is: {0}", fullName);

        //array of strings
        string[] sarray = { "Hello", "World", "I can", "Join", "String Arrays" };
        foreach (string s in sarray) { Console.Write("{0}  ", s); }
        Console.WriteLine();
        string joint = String.Join(" ", sarray);
        Console.WriteLine(joint);

        //DateTime variable type DateTime(year month, day, hour, minute, second
        DateTime dt = new DateTime(2014, 01, 12, 22, 40, 00);
        //Format DateTime
        Console.WriteLine(String.Format("\nDisplay the date {0:D} at time {0:t}", dt));

        Console.WriteLine("\nStringComparisons");
        StringComparison[] comparisons = (StringComparison[])Enum.GetValues(typeof(StringComparison));
        foreach (var comparison in comparisons)
        {
            Console.WriteLine(comparison);
        }

        sname = "jimmy";
        //Default String.Equals is case sensitive
        if (fname.Equals(sname, StringComparison.OrdinalIgnoreCase)) { Console.WriteLine("\n {0} equals {1}", fname, sname); }
        else { Console.WriteLine("\n{0} does not equal {1}", fname, sname); }

        Console.WriteLine("\n");

        Rectangle r = new Rectangle(4.5,3.0);
        //r.AcceptDetails();
        //Console.WriteLine("Input length:");
        //r.SetLength(Convert.ToDouble(Console.ReadLine()));
        //Console.WriteLine("Input width:");
        //r.SetWidth(Convert.ToDouble(Console.ReadLine()));

        r.display();

        Rectangle r2 = new Rectangle(12, 5);
        r.addToStatVar();
        r.addToStatVar();
        r2.addToStatVar();

        Console.WriteLine("\nstatVar= {0} for r and {1} for r2", Rectangle.getStatVar(), Rectangle.getStatVar());
        Console.WriteLine("\npi= {0}", Rectangle.pi);

        ColouredRectangle cr = new ColouredRectangle(4.5,3.2,"Red");
        //cr.AcceptDetails();
        //cr.setColour("Red");
        cr.display();
        Console.WriteLine("\n{0} rectangle with area {1}", cr.getColour(), cr.calcArea());
        //delete r;

        Triangle tr = new Triangle(2, 4);
        tr.display();

        Rectangle r3 = new Rectangle();
        r3 = r + r2;
        r3.display();
        Cards card1, card2;

        card1.suit = "Hearts";
        card1.value = "5";

        card2.suit = "Diamonds";
        card2.value = "Jack";

        //Console.WriteLine("\nCard1 is the {0} of {1} and Card2 is the {2} of {3}", card1.value, card1.suit, card2.value, card2.suit);
        Console.WriteLine();
        Console.Write("Card1: ");
        card1.Print();
        Console.WriteLine();
        Console.Write("Card2: ");
        card2.Print();
        Console.WriteLine();

        Console.WriteLine("\nMonday is at position {0}", (int)Days.Mon); 

        Console.WriteLine("\nEnter any key to exit!");
        Console.ReadKey();  
    }
}

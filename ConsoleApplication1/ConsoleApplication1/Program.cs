using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Program
{
    static void Main(string[] args)
    {


        SimpleClass.printBaseline();


        Console.WriteLine("Press ENTER to continue...");
        Console.ReadLine();
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
            Console.Beep();
        }
    }

    static string promptInput()
    {
        System.Console.WriteLine("Not in OtherNameSpace.Program right now.");
        return "";
    }
}

class SimpleClass
{
    static readonly DateTime baseline;

    static SimpleClass()
    {
        baseline = DateTime.Today;
        Console.WriteLine("SimpleClass static constructor");
    }

    public static void printBaseline()
    {
        Console.WriteLine(baseline);
    }
}
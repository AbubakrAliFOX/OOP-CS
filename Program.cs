using System;

class clsPerson
{
    public string FirstName
    {
        get;
        set;
    }

    public string LastName
    {
        get;
        set;
    }

    public string fullName ()
    {
        return FirstName + " " + LastName;
    }

    public void writeFullName ()
    {
        Console.WriteLine(fullName());
    }
}

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            clsPerson Person1 = new clsPerson();
            Person1.FirstName = "Ahmad";
            Person1.LastName = "Ali";
            Person1.writeFullName();
        }
    }
}



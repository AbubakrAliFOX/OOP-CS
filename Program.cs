using System;

class clsPerson
{
    protected string firstName;
    private string lastName;

    public string fullName ()
    {
        return firstName + " " + lastName;
    }

    public void writeFullName ()
    {
        Console.WriteLine(fullName());
    }
}

class clsEmployee : clsPerson
{
    public void writeFullName()
    {

        Console.WriteLine(firstName);
    }
}

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            clsPerson Person1 = new clsPerson();
            clsEmployee Employee1 = new clsEmployee();
            Employee1.
            Person1.writeFullName();
            Person1.
        }
    }
}



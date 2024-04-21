using System;

class clsPerson
{
    private string _firstName;
    private string _lastName;

    public string FirstName
    {
        get
        { return _firstName; }

        set { _firstName = value; }
    }

    public string LastName
    {
        get { return _lastName;}
        set { _lastName = value; }  
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



using System;

class clsPerson
{
    public string firstName;
    public string lastName;

    public string fullName ()
    {
        return firstName + " " + lastName;
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

        }
    }
}



﻿using System;
using System.Xml.Linq;


public class clsPerson
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Age { get; set; }

    public void Print ()
    {
        Console.WriteLine("This is from Person");
    }

    //public clsPerson(int id, string name, string description, int age)
    //{
    //    this.Id = id;
    //    this.Name = name;
    //    this.Description = description;
    //    this.Age = age;
    //}
}

public class clsEmployee : clsPerson
{
    public string Department { get; set; }
    public float Salary { get; set; }

    public void Print()
    {
        Console.WriteLine("This is from Employee");
        base.Print();
    }

    //public clsEmployee (int id, string name, string description, int age, string department, float salary) 
    //        : base(id, name, description, age)
    //{
    //    this.Department = department;
    //    this.Salary = salary;
    //}

}

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            clsPerson person1 = new clsPerson();
            person1.Print();

            clsEmployee empolyee1 = new clsEmployee();
            empolyee1.Print();
        }
    }
}



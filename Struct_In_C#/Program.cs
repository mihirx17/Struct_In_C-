using System;

struct Employee
{
    public int Id;
    public string Name;
    public string Department;
    public double Salary;

    // ✅ Parameterized Constructor
    public Employee(int id, string name, string dep, double salary)
    {
        this.Id = id;
        this.Name = name;
        this.Department = dep;
        this.Salary = salary;
    }

    // ✅ Display method
    public void Display()
    {
        Console.WriteLine("Employee Id : " + Id);
        Console.WriteLine("Employee Name : " + Name);
        Console.WriteLine("Employee Department : " + Department);
        Console.WriteLine("Employee Salary : " + Salary);
    }
    public void Setvalues(int id, string name, string dep, double salary)
    {
        this.Id = id;
        this.Name = name;
        this.Department = dep;
        this.Salary = salary;
    }
}
class Student
{
    public int Id;
    public string Name;
    public string Department;
    public double Salary;
    public  Student()
    {
        Console.WriteLine("Default Constructor--using class");
    }
    public Student(int id, string name, string dep, double salary)
    {
        this.Id = id;
        this.Name = name;
        this.Department = dep;
        this.Salary = salary;
    }
    public void Display() { Console.WriteLine("Student Id : " + Id);
    
    Console.WriteLine("Student Name : " + Name);
        Console.WriteLine("Student Department : " + Department);
        Console.WriteLine("Student Salary : " + Salary);

    }
    //struct Manger :Employee
    //{
    //    Console.writeline("Here Struct cannot called Inheritence");
    //}
    

}

interface IEmployee
{
    void Display();
}
struct Manager : IEmployee
{
    public void Display()
    {
        Console.WriteLine("Manager Display");
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        // ✅ Using Parameterized Constructor
        Employee employee = new Employee(101, "John", "IT", 50000);
        employee.Display();
        
        // ✅ Using another instance
        Employee employee1 = new Employee(102, "Smith", "HR", 60000);
        employee1.Display();
        // without using new keyword
        Employee employee2;
        employee2.Id = 103;
        employee2.Name = "David";
        employee2.Department = "Finance";
        employee2.Salary = 70000;
        employee2.Display();
        // Using Setvalues method
        Employee employee3 = new Employee();
        employee3.Setvalues(104, "Sam", "IT", 80000);
        employee3.Display();

        // Default Constructor using class
        Student student = new Student();
        // Parameterized Constructor using class
        Student student1 = new Student(101, "John", "IT", 50000);

        student1.Display();
        Employee emp;
        //emp=null;
        Manager manager = new Manager();
        manager.Display();
        IEmployee iemployee = new Manager();
        iemployee.Display();


    }
}
//struct Employee is a value type and class Student is a reference type.
//Structs are value types and classes are reference types.
//Structs are stored on the stack, whereas classes are stored on the heap.
//Structs are lightweight and faster than classes
//Structs can't have destructors, but classes can have destructors.
//Structs can't have explicit parameterless constructors, but classes can have explicit parameterless constructors.
//Structs can't inherit from another struct, but classes can inherit from another class.
//Structs can't be null, but classes can be null
//we can create instance without using new keyword in struct
//Here we cannot call default constructor of struct

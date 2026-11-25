using System.Net.Http.Headers;

class Student
{
    int rollNo;
    string name;
    int age;
    int standard;

    public void SetStudent(int rollNo, string name, int age, int standard)
    {
        this.rollNo = rollNo;
        this.name = name;
        this.age = age;
        this.standard = standard;

    }

    public void getStudent()
    {
 

        Console.WriteLine("Your Rollno is: {0}", this.rollNo);
        Console.WriteLine("Your Name is: {0}", this.name);
        Console.WriteLine("Your Age is: {0}", this.age);
        Console.WriteLine("Your standard is: {0}", this.standard);

    }
    static void Main()
    {
        Student Ali = new Student();
        Ali.SetStudent(22, "InshaW", 23, 2);
        Ali.getStudent();
        Console.ReadLine();
    }

}
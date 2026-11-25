using System.Net.Http.Headers;

//class Student
//{
//    int rollNo;
//    string name;
//    int age;
//    int standard;

//    public void SetStudent(int rollNo, string name, int age, int standard)
//    {
//        this.rollNo = rollNo;
//        this.name = name;
//        this.age = age;
//        this.standard = standard;

//    }

//    public void getStudent()
//    {
 

//        Console.WriteLine("Your Rollno is: {0}", this.rollNo);
//        Console.WriteLine("Your Name is: {0}", this.name);
//        Console.WriteLine("Your Age is: {0}", this.age);
//        Console.WriteLine("Your standard is: {0}", this.standard);

//    }
//    static void Main()
//    {
//        Student Ali = new Student();
//        Ali.SetStudent(22, "InshaW", 23, 2);
//        Ali.getStudent();
//        Console.ReadLine();
//    }

//}




// METHODS AND FUNCTIONS 
class Program {
 //A GROUP OF STATEMENTS THAT WORKS TOGETHER TO PERFOM SPECIFIC TASKS
 // WE'LL ALWAYS CREATE A NEW METHOD FUNCTION WITHIN A CLASS
 // MAKE SURE YOU DON'T ADD A NEW METHOD IN SOME OTHER METHODS OF SMAE CLASSE
 //tTHIS IS THE SYNTAX OF METHODS, public IS ACCESS SPECIFIER
 //void IS RETURN TYPE.NEXT FUNCTION NAME AND PARANTHESIS
    public void Insha()
    {
        Console.WriteLine("hey insha");

    }


static void Main()
    {
     Program obj = new Program();
        obj.Insha();


        // IF WE DON'T FOLLOW THE SEQUENCE IN PARAMETER AND ARGUMENTS THEN WE'LL 
        // USE "NAMED ARGUMENTS" LIKE THIS 
        Program.ShowNameAge(age:23, name:"Insha Waheed");

    }
    public static void ShowNameAge(string name, int age)
    {
        Console.WriteLine("Your age is: " + age);
        Console.WriteLine("Your Name is: " + name);


    }

}

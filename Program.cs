
//class Student {
//    int rollNo;
//    string name;
//    int age;
//    int standard; 
//    public void setRollNo(int rollNo)
//    {
//        this.rollNo = rollNo;
//    }
//    public int getRollNo()
//    {
//        return this.rollNo;
//    }



//static void Main()
//    {

//        Student Ali = new Student();
//        Ali.setRollNo(123);
//        Console.WriteLine( Ali.getRollNo());

//        Console.ReadLine();

//    }




//}


////CLASSES AND OBJECTS ARE REFERENCE DATA TYPES 





using classes_objects;

class Car {
    string Color = "red";
    string Model = "BMW";



    // THIS IS THE CORRECT WAY OF CREATING AN OBJECT WITHIN A CLASS
    static void Main()
    {
        Car myObj = new Car();

        Console.WriteLine(myObj.Model + " " + myObj.Color);
    }


}



class Program {
static void Main()
    {

        studentRecord obj = new studentRecord();
        obj.studentR();

    }

}

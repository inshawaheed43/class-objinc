using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace classes_objects
{
    internal class Student {
        public string name;
        public int rollNo;



        static void Main()
        {
            //Student s1 = new Student();
            //s1.name = "Ali";
            //s1.rollNo = 1;
            //Console.WriteLine(s1.name);

        }


        //OK SO HERE THIS STUDENT ISN'T A METHODS IT'S A CONSTRUCTOR.
        // AS IT HAS SAME NAME AS CLASS AND HAS NO RETURN TYPE SO IT'S A CONSTRUCTOR
        public Student( string n, int r)
        {
            name = n;
            rollNo = r;
        }
      
    }

}


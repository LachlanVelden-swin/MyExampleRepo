using System;
using System.Collections.Generic;

namespace ManyClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var studentClass = new StudentClass();
            studentClass.Name = "Intro Programing";
            studentClass.StartTime = "8:30";
            studentClass.EndTime = "13:30";

            var student1 = new Student();
            student1.Age= 31;
            student1.FirstName = "Bob";
            student1.LastName = "Joe";
            Console.WriteLine(student1.Age);
            student1.HappyBirthday();
            Console.WriteLine(student1.Age);


            var student2 = new Student();
            student2.Age = 564;
            student2.FirstName = "Frank";
            student2.LastName = "Pooped";


            studentClass.Students.Add(student1);

            foreach (var item in studentClass.Students)
            {
                Console.WriteLine(item.FirstName);
            }


        }
    }


    public class StudentClass
    {
        public string Name;
        public string StartTime;
        public string EndTime;

        public List<Student> Students = new List<Student>();


    }

    public class Student
    {
        public string Id;
        public string FirstName;
        public string LastName;

        public int Age;

        public string PhoneNumber;


        public void HappyBirthday()
        {
            this.Age = this.Age + 1;
        }



    }

}

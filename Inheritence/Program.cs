using Inheritence;
using OOPtasks;
//using PhotoBook;
using System;

namespace OOPtasks;
internal class Program
{
    static void Main(string[] args)
    {
        Person[] people = new Person [3];

        Professor professor = new Professor("Juan");  

        Student student1 = new Student("Sara");
        Student student2 = new Student("Carlos");

        people[0] = professor;
        people[1] = student1;
        people[2] = student2;

        for (int i = 0; i < people.Length; i++)
        {
            Person person = people[i]; //Student
            try
            {
                if (person == (Professor)person)
                {
                    Professor proffessor = (Professor)person;
                    proffessor.Explain();
                }
            } catch (Exception)
            {
                Console.WriteLine("Error occured while casting to Professor");
            };
            try
            {
                if (person == (Student)person)
                {
                    Student student = (Student)person;
                    student.Study();
                }
            }
            catch (Exception) 
            {
                Console.WriteLine("Error occured while casting to Student");
            };

        }

        //var person = new Person();
        //person.Greet();

        //var student = new Student();
        //student.SetAge(20);
        //student.Greet();
        //student.ShowAge();

        //var teacher = new Professor();
        //teacher.SetAge(27);
        //teacher.Greet();
        //teacher.Explain();
        //PhotoBookTest.Test();
    }
}
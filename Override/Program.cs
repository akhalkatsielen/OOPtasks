using OOPtasks;

namespace OOPtasks;
internal class Program
{
    static void Main(string[] args)
    {

        int[] ints = new int[3];

        ints[0] = 5;
        ints[1] = 10;
        ints[2] = 15;

        //----------------------------------------
        int peoplesCount = 3;
        Person[] people = new Person[peoplesCount];

        for (int i = 0; i < peoplesCount; i++)
        {
            var name = Console.ReadLine();
            var person = new Person(name);
            people[i] = person;
        }

        for (int i = 0; i < peoplesCount; i++)
        {
            Console.WriteLine(people[i].ToString());
        }

    }
}
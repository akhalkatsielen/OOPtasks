namespace Abstract;
internal class Program
{
    static void Main(string[] args)
    {
        var dog = new Dog();
        dog.SetName("Lady");

        Console.WriteLine(dog.GetName());
        Console.WriteLine(dog.Eat());
    }
}

namespace Files;
internal class Program
{
    static void Main(string[] args)
    {
        //while (true) 
        //{
        //    Console.WriteLine("1. Add User\n2. Get Users");
        //    var choise = Console.ReadLine();
            
        //    if (choise == "1")
        //    {
        //        Console.WriteLine("FirstName: ");
        //        var firstName = Console.ReadLine();

        //        Console.WriteLine("LastName: ");
        //        var lastName = Console.ReadLine();

        //        Console.WriteLine("Email: ");
        //        var email = Console.ReadLine();

        //        Console.WriteLine("Phone: ");
        //        var phone = Console.ReadLine();

        //        UserService.CreateUser(firstName, lastName, email, phone);
        //    }
        //    else if (choise == "2")
        //    {
        //        var users = UserService.GetUsers();
        //        Console.WriteLine(users);
        //    }
        //}

        List<User> list = new List<User>();
        list.Add(new User(1,"elene","akhalkatsi","elene@gmai.com", "57575757"));
        list.Add(new User(1,"elene","akhalkatsi","elene@gmai.com", "57575757"));
        list.Add(new User(1,"elene","akhalkatsi","elene@gmai.com", "57575757"));
        list.Add(new User(1,"elene","akhalkatsi","elene@gmai.com", "57575757"));
        list.Add(new User(1,"elene","akhalkatsi","elene@gmai.com", "57575757"));
        list.Add(new User(1,"elene","akhalkatsi","elene@gmai.com", "57575757"));
        list.Add(new User(1,"elene","akhalkatsi","elene@gmai.com", "57575757"));
        list.Add(new User(1,"elene","akhalkatsi","elene@gmai.com", "57575757"));

        UserService.GenerateString(list);
    }
}
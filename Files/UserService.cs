using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Files;

public static class UserService
{
    private static FileManager FileManager = new FileManager("Users.txt");
    public static bool CreateUser(string firstName, string lastName, string email, string phone)
    {
        var user = new User(1, firstName, lastName, email, phone);

        var userRow = "";
        userRow += user.Id.ToString() + "|" + user.FirstName + "|" + user.LastName + "|" + user.Email + "|" + user.Phone + "\n";
        var IsCreated = FileManager.AddInFile(userRow);
        return IsCreated;
    }
    public static string GetUsers()
    {
        var fileUsers = FileManager.ReadFile();
        var userRows = fileUsers.Split("\n").ToList();

        var users = "";

        foreach (var user in userRows) 
        {
            var userInfo = user.Split("|").ToList();
            if (userInfo.Count < 4) continue;

            users += $"FirstName: {userInfo[1]}" +
                $"\nLastName: {userInfo[2]}" +
                $"\nEmail: {userInfo[3]}" +
                $"\nPhone: {userInfo[4]}" +
                $"\n-------------------------------";
        }

        return users;
    }
    public static void GenerateString<T>(List<T> list)
    {
        var listItem = list.FirstOrDefault();
        Type myType = listItem.GetType();
        List<PropertyInfo> props = new List<PropertyInfo>(myType.GetProperties());

        var returnString = "";

        foreach (PropertyInfo prop in props) 
        {
            returnString += prop.Name + "   ";
        }

        foreach (var item in list) 
        {
            foreach (PropertyInfo prop in props)
            {
                
                returnString += prop.GetValue(item);
            }
            returnString += "\n";
        }

        Console.WriteLine(returnString);
    }
}

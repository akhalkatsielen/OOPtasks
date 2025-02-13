using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FileParser;

class FileManager
{
    string path = @"..\..\..\";
    string filePath;
    public FileManager(string fileName)
    {
        filePath = Path.Combine(path, fileName);

    }

    public void Create()  
    {
        try
        {
            File.Create(filePath);
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine("FilePath is null!");
        }
        catch (Exception ex) 
        {
            Console.WriteLine("Unknown Error");
        }
    }
    public string ReadFile()
    {
        try
        {
            if (!File.Exists(filePath))
            {
                return "File doesnt exist";
            }
            else
            {
                return File.ReadAllText(filePath);
            }
        }
        catch (Exception ex)
        {
            return "Unknown error";
        }
    }

    public bool WriteInFile(string text)
    {
        try
        {
            File.WriteAllText(filePath, text);
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }
    public bool AddInFile(string text)
    {
        try
        {
            File.AppendAllText(filePath, text);
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }
    public bool Delete()
    {
        try
        {
            File.Delete(filePath);
            return true;
        }
        catch (Exception ex) 
        { 
            return false;
        }
    }
}

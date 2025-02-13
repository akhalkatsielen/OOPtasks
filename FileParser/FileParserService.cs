using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace FileParser;

public static class FileParserService
{
    public static void ReadDataFromDB(string oldFileName, string newFileName)
    {
        var employeeList = new List<Employee>();

        var fileManager = new FileManager(oldFileName);

        var dbText = fileManager.ReadFile();

        var personsInfo = dbText.Split("\r\n\r\n").ToList();

        //ID: 101
        //NAME: Alice Smith
        //POSITION: Software Engineer
        //DEPARTMENT: IT
        //SALARY: 80000
        //PROJECTS: Project A, Project B
        //CERTIFICATIONS: AWS, Docker
        //SKILLS: C#, .NET, Azure

        foreach (var personInfo in personsInfo) 
        {
            var lines = personInfo.Split("\r\n");

            var idLine = lines[0];
            var nameLine = lines[1];
            var positionLine = lines[2];
            var departmentLine = lines[3];
            var salaryLine = lines[4];
            var projectsLine = lines[5];
            var certificationsLine = lines[6];
            var skillsLine = lines[7];

            var employee = new Employee(
                //lines[0].Split(":")[1],
                idLine.Split(":")[1].Trim(),
                nameLine.Split(":")[1].Trim(),
                positionLine.Split(":")[1].Trim(),
                departmentLine.Split(":")[1].Trim(),
                salaryLine.Split(":")[1].Trim(),
                projectsLine.Split(":")[1].Trim(),
                certificationsLine.Split(":")[1].Trim(),
                skillsLine.Split(":")[1].Trim()
             );

            employeeList.Add(employee);
        }
        Console.WriteLine("Done!");
    }
    public static void CreateTableStyledTXT(int columns, int rows, int length)
    {
        int rowsCount = 2 * rows + 1;
        int colCount = length * columns + columns + 1;
        for (int i = 1; i <= rowsCount; i++) 
        {
            if (i % 2 == 1)
            {
                for (int j = 1; j <= colCount; j++)
                {
                    if ((j - 1) % (length + 1) == 0) { Console.Write("+"); }
                    else Console.Write("-");
                }
            }
            else 
            { 
                for(int j = 1; j <= colCount; j++)
                {
                    if ((j - 1) % (length + 1) == 0) { Console.Write("|"); }
                    else Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
    
}

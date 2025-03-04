using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace FileParser;

public static class FileParserService
{
    public static List<Employee> ReadDataFromDB(string dbFileName)
    {
        var employeeList = new List<Employee>();

        var fileManager = new FileManager(dbFileName);

        var dbText = fileManager.ReadFile();

        var personsInfo = dbText.Split("\r\n\r\n").ToList();

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
        return employeeList;
    }
    public static void CreateTableStyledTXT(int columns, int rows, int length)
    {
        int rowsCount = 2 * rows + 1;
        int colCount = length * columns + columns + 1;  //col*(length+1) + 1
        for (int i = 1; i <= rowsCount; i++)
        {
            if (i % 2 == 1) // + - 
            {
                for (int j = 1; j <= colCount; j++)
                {
                    if ((j - 1) % (length + 1) == 0) { Console.Write("+"); }
                    else Console.Write("-");
                }
            }
            else // |
            {
                for (int j = 1; j <= colCount; j++)
                {
                    if ((j - 1) % (length + 1) == 0) { Console.Write("|"); }
                    else Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
    public static void CreateTableStyledTXT(List<Employee> employees, string newFileName)
    {
        var fileManager = new FileManager(newFileName);
        string newFileText = "";

        int rows = employees.Count;
        int columns = 8;

        int maxLength = CountMaxLengthInEmployees(employees);

        int rowsCount = 2 * rows + 1;
        int colCount = maxLength * columns + columns + 1;  //col*(length+1) + 1
        int employeeIndex = 0;
        
        for (int i = 1; i <= rowsCount; i++)
        {
            if (i % 2 == 1) // + - 
            {
                for (int j = 1; j <= colCount; j++)
                {
                    if ((j - 1) % (maxLength + 1) == 0) { newFileText += "+"; }
                    else newFileText += "-";
                }
            }
            else
            {
                var currentEmployee = employees[employeeIndex];

                List<string> employeeInfo = new List<string>();
                employeeInfo.Add(currentEmployee.ID);
                employeeInfo.Add(currentEmployee.NAME);
                employeeInfo.Add(currentEmployee.DEPARTMENT);
                employeeInfo.Add(currentEmployee.POSITION);
                employeeInfo.Add(currentEmployee.SKILLS);
                employeeInfo.Add(currentEmployee.SALARY);
                employeeInfo.Add(currentEmployee.PROJECTS);
                employeeInfo.Add(currentEmployee.CERTIFICATIONS);

                for (int j = 0; j < columns; j++)
                {
                    var valueText = employeeInfo[j];
                    var spaces = new String(' ', maxLength - valueText.Count());
                    newFileText += $"|{valueText}{spaces}";
                }
                newFileText += "|";
                employeeIndex++;
            }
            newFileText += "\n";
        }
        fileManager.WriteInFile(newFileText);
    }
    public static int CountMaxLengthInEmployees(List<Employee> employees)
    {
        int maxLength = 0;

        foreach (Employee employee in employees)
        {
            if (employee.ID.Length > maxLength) maxLength = employee.ID.Length;
            if (employee.NAME.Length > maxLength) maxLength = employee.NAME.Length;
            if (employee.POSITION.Length > maxLength) maxLength = employee.POSITION.Length;
            if (employee.PROJECTS.Length > maxLength) maxLength = employee.PROJECTS.Length;
            if (employee.SALARY.Length > maxLength) maxLength = employee.SALARY.Length;
            if (employee.SKILLS.Length > maxLength) maxLength = employee.SKILLS.Length;
            if (employee.DEPARTMENT.Length > maxLength) maxLength = employee.DEPARTMENT.Length;
            if (employee.CERTIFICATIONS.Length > maxLength) maxLength = employee.CERTIFICATIONS.Length;
        }

        return maxLength;
    } 
}

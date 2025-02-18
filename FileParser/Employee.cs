using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileParser;

public class Employee
{
    public Employee(string id, 
        string name,
        string position,
        string department,
        string salary,
        string projects,
        string certifications,
        string skills)
    {
        ID = id;
        NAME = name;
        POSITION = position;
        DEPARTMENT = department;
        SALARY = salary;
        PROJECTS = projects;
        CERTIFICATIONS = certifications;
        SKILLS = skills;
    }
    public Employee(string id,
        string name,
        string position,
        string department,
        string salary,
        string projects)
    {
        ID = id;
        NAME = name;
        POSITION = position;
        DEPARTMENT = department;
        SALARY = salary;
        PROJECTS = projects;
    }
    public string ID { get; set; }
    public string NAME { get; set; }
    public string POSITION { get; set; }
    public string DEPARTMENT { get; set; }
    public string SALARY { get; set; }
    public string PROJECTS { get; set; }
    public string CERTIFICATIONS { get; set; }
    public string SKILLS { get; set; }
}

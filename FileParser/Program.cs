namespace FileParser;
public class Program
{
    static void Main(string[] args)
    {
        //FileParserService.CreateTableStyledTXT(3, 2, 5);
        var employeeList = FileParserService.ReadDataFromDB("DATADBCopy.txt");
        FileParserService.CreateTableStyledTXT(employeeList);
    }
}

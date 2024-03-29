using System.Text;

namespace CsharpDotnet;

public static class DisplayHelper
{
    public static string DisplayTable(IEnumerable<TableRecords> tableRecords)
    {
        StringBuilder sb = new();
        sb.AppendLine("FullName\t\t\tID\tCurrent Salary\tTarget Salary\n");

        decimal totalCurrent = 0;
        decimal totalTarget = 0;

        foreach (var item in tableRecords)
        {
            totalCurrent += item.CurrentSalary;
            totalTarget += item.TargetSalary;
            sb.AppendLine($"{item.FullName}\t\t\t{item.Id}\t{item.CurrentSalary:C}\t{item.TargetSalary:C}");
        }
        sb.AppendLine($"\n\t\t\t\tTotal of Current Salaries:\t{totalCurrent:C}");
        sb.Append($"\t\t\t\tTotal of Target Salaries:\t{totalTarget:C}");

        return sb.ToString();
    }
}

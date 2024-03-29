// See https://aka.ms/new-console-template for more information

using Microsoft.FSharp.Collections;
using VisualBasicDotnet.VisualBasicDotnet;
using FsharpDotnet;
using CsharpDotnet;

var employees = EmployeeRepository.GetEmployees();

FSharpList<(int, decimal)> employeesAsFsharpList = ListModule.OfSeq(
    employees.Select(employee => (employee.Id, employee.Salary)));

var employeesWithRaise = RaiseManager.AddRaise(employeesAsFsharpList, 10);

var tableRecords = employeesWithRaise.Join(employees,
    employeeWithRaise => employeeWithRaise.EmployeeId,
    employee => employee.Id,
    (employeeWithRaise, employee) => new TableRecords
    {
        Id = employeeWithRaise.EmployeeId,
        FullName = employee.FullName,
        CurrentSalary = employeeWithRaise.CurrentSalary,
        TargetSalary = employeeWithRaise.TargetSalary,
    }).ToList();

var tableToDisplay = DisplayHelper.DisplayTable(tableRecords);

Console.WriteLine(tableToDisplay);
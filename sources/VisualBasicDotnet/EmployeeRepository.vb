Namespace VisualBasicDotnet
    Public Class EmployeeRepository
        Public Shared Function GetEmployees() As List(Of Employee)

            Return New List(Of Employee) From
            {
                New Employee With
                {
                    .Id = 1,
                    .FirstName = "Arthur",
                    .LastName = "Kamsu",
                    .Salary = 100_000
                },
                New Employee With
                {
                    .Id = 2,
                    .FirstName = "John",
                    .LastName = "Tagne",
                    .Salary = 50_000
                },
                New Employee With
                {
                    .Id = 3,
                    .FirstName = "Zanab",
                    .LastName = "Li",
                    .MiddleName = "Paul",
                    .Salary = 200_000
                },
                New Employee With
                {
                    .Id = 4,
                    .FirstName = "Joseph",
                    .LastName = "King",
                    .Salary = 80_000
                },
                New Employee With
                {
                    .Id = 5,
                    .FirstName = "Ma",
                    .LastName = "Wang",
                    .MiddleName = "San",
                    .Salary = 70_000
                }
            }
        End Function
    End Class
End Namespace

namespace FsharpDotnet

type EmployeeIdWithTargetSalary(employeeId: int, currentSalary: decimal, targetSalary: decimal) =
    member this.EmployeeId : int = employeeId
    member this.CurrentSalary: decimal = currentSalary
    member this.TargetSalary: decimal = targetSalary

    member this.ToString() = 
        printf "{EmployeeId: %d, CurrentSalary: %M, TargetSalary: %M}", this.EmployeeId, this.CurrentSalary, this.TargetSalary
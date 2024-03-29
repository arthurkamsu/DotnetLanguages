namespace FsharpDotnet

module RaiseManager =
    let AddRaise(employeeIdsWithInitialSalary: (struct (int * decimal)) list, percentage: int) = 
        if percentage > 100 || percentage < 1 then
            raise (invalidOp "Invalid percentage (Must be between 1 and 100).")

        employeeIdsWithInitialSalary
        |> List.map(fun struct (employeeId, initialSalary) -> EmployeeIdWithTargetSalary(
        employeeId,
        initialSalary,
        initialSalary + (initialSalary * decimal percentage / decimal 100)))

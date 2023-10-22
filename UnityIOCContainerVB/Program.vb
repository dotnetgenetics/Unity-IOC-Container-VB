Module Program

    Dim _unitOfWork As IUnitOfWork
    Dim _resolver As UnityContainerResolver

    Sub Main(args As String())
        _resolver = New UnityContainerResolver()

        Console.WriteLine($"\n-----------------------------Employee Record-----------------------------")

        _unitOfWork = CType(_resolver.Resolver(), IUnitOfWork)

        Dim emp = _unitOfWork.EmployeeRepository.FindById(1)
        Console.WriteLine($"Employee Name: { emp.FirstName} " + $"{ emp.LastName}, Employee Email: {emp.EmailAddress} ")

        Console.ReadLine()
    End Sub
End Module

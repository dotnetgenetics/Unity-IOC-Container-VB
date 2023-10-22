Public Class UnitOfWork
    Implements IUnitOfWork

    Public Sub New(employeeRepository As EmployeeRepository)
        Me.EmployeeRepository = employeeRepository
    End Sub

    Private p_IEmployeeRepository As IEmployeeRepository
    Public Property EmployeeRepository As IEmployeeRepository Implements IUnitOfWork.EmployeeRepository
        Get
            Return p_IEmployeeRepository
        End Get

        Set(value As IEmployeeRepository)
            p_IEmployeeRepository = value
        End Set
    End Property

End Class
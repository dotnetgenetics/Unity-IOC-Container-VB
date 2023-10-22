Option Strict On

Imports Unity

Public Class UnityContainerResolver
    Private container As UnityContainer

    Public Sub New()
        container = New UnityContainer()
        RegisterTypes()
    End Sub

    Public Sub RegisterTypes()
        container.RegisterType(Of IEmployeeRepository, EmployeeRepository)()
        container.RegisterType(Of IUnitOfWork, UnitOfWork)()
    End Sub

    Public Function Resolver() As UnitOfWork
        Return container.Resolve(Of UnitOfWork)()
    End Function
End Class
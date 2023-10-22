Option Strict On

Imports Dapper
Imports System.Configuration
Imports System.Data.SqlClient

Public Class EmployeeRepository
    Implements IEmployeeRepository

    Private _db As SqlConnection

    Public Sub New()
        Dim conn As String = ConfigurationManager.AppSettings("ContosoDB")
        _db = New SqlConnection(conn)
    End Sub

    Public Function FindById(Id As Integer) As Employee Implements IEmployeeRepository.FindById

        Dim empObject As New Employee()

        empObject = _db.Query(Of Employee)("SELECT * FROM DimEmployee WHERE EmployeeKey=@Id", New With {
            Key .Id = Id
        }).FirstOrDefault()

        Return empObject

    End Function

End Class
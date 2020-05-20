Public Class BankAccount

    Private AccountOwner As String
    Private AccountNumber As Integer
    Private Balance As Double
    Private InterestRate As Double
    Private Country As String

    Public Sub New(AccountOwner As String, AccountNumber As Integer, Balance As Double, InterestRate As Double, Country As String)
        Me.AccountOwner = AccountOwner
        Me.AccountNumber = AccountNumber
        Me.Balance = Balance
        Me.InterestRate = InterestRate
        Me.Country = Country

    End Sub

    Public Sub New(AccountOwner As String, AccountNumber As Integer, Balance As Double, InterestRate As Double)
        Me.AccountOwner = AccountOwner
        Me.AccountNumber = AccountNumber
        Me.Balance = Balance
        Me.InterestRate = InterestRate

    End Sub

    Public Sub New(AccountOwner As String, AccountNumber As Integer, Balance As Double)
        Me.AccountOwner = AccountOwner
        Me.AccountNumber = AccountNumber
        Me.Balance = Balance

    End Sub

End Class
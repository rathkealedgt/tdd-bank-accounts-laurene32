Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class UnitTest1

    <TestMethod()> Public Sub TestConstructors()

        'Arrange
        Dim AccountOwner As String = "Ms I. N. Cognito"
        Dim AccountNumber As String = "ABCD 890111 11167890"
        Dim InterestRate As Double = 4.3
        Dim Balance As Double = 10343.82
        Dim Country As String = "Isle of Man"

        'Act
        Dim Account1 As New BankAccounts.BankAccount(AccountOwner, AccountNumber, Balance, InterestRate, Country)
        Dim Account2 As New BankAccounts.BankAccount(AccountOwner, AccountNumber, Balance, InterestRate)
        Dim Account3 As New BankAccounts.BankAccount(AccountOwner, AccountNumber, Balance)

        'Assert
        Assert.IsNotNull(Account1)
        Assert.IsNotNull(Account2)
        Assert.IsNotNull(Account3)


    End Sub
End Class


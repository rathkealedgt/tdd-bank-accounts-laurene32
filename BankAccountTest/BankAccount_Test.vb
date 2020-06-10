Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports BankAccounts

<TestClass()> Public Class BankAccount_Test

    <TestMethod()> Public Sub TestConstructors()

        'Arrange
        Dim AccountOwner As String = "Ms I. N. Cognito"
        Dim AccountNumber As String = "ABCD 890111 11167890"
        Dim InterestRate As Double = 4.3
        Dim AccBalance As Double = 10343.82
        Dim AccCountry As String = "Isle of Man"

        'Act
        Dim Account1 As New BankAcct(AccountOwner, AccountNumber, AccBalance, InterestRate, AccCountry)
        Dim Account2 As New BankAcct(AccountOwner, AccountNumber, AccBalance, InterestRate)
        Dim Account3 As New BankAcct(AccountOwner, AccountNumber, AccBalance)

        'Assert
        Assert.IsNotNull(Account1)
        Assert.IsNotNull(Account2)
        Assert.IsNotNull(Account3)

    End Sub

    <TestMethod()> Public Sub TestGetAccountOwner()

        'Arrange
        Dim AccountOwner As String = "Ms I. N. Cognito"
        Dim AccountNumber As String = "ABCD 890111 11167890"
        Dim InterestRate As Double = 4.3
        Dim AccBalance As Double = 10343.82
        Dim AccCountry As String = "Isle of Man"
        Dim Account1 As New BankAcct(AccountOwner, AccountNumber, AccBalance, InterestRate, AccCountry)

        'Act
        Dim Name As String = Account1.GetAccountOwner()
        Dim Number As String = Account1.GetAccountNumber()
        Dim Interest As Double = Account1.GetInterestRate()
        Dim Country As String = Account1.GetCountry()
        Dim Balance As Double = Account1.GetBalance()

        'Assert
        Assert.AreEqual(Name, "Ms I. N. Cognito")
        Assert.AreEqual(Number, "ABCD 890111 11167890")
        Assert.AreEqual(Interest, 4.3)
        Assert.AreEqual(AccCountry, "Isle of Man")
        Assert.AreEqual(AccBalance, 10343.82)

    End Sub

    <TestMethod()> Public Sub TestGetInterestRate()

        'Arrange
        Dim AccountOwner As String = "Ms I. N. Cognito"
        Dim AccountNumber As String = "ABCD 890111 11167890"
        Dim InterestRate As Double = 4.3
        Dim AccBalance As Double = 10343.82
        Dim AccCountry As String = "Isle of Man"
        Dim Account1 As New BankAcct(AccountOwner, AccountNumber, AccBalance, InterestRate, AccCountry)

        'Act
        Dim IR As Double = Account1.GetInterestRate()

        'Assert
        Assert.AreEqual(4.3, IR)

    End Sub

    <TestMethod()> Public Sub TestGetCountry()

        'Arrange
        Dim AccountOwner As String = "Ms I. N. Cognito"
        Dim AccountNumber As String = "ABCD 890111 11167890"
        Dim InterestRate As Double = 4.3
        Dim AccBalance As Double = 10343.82
        Dim AccCountry As String = "Isle of Man"
        Dim Account1 As New BankAcct(AccountOwner, AccountNumber, AccBalance, InterestRate, AccCountry)

        'Act
        Dim Country As String = Account1.GetCountry()


        'Assert
        Assert.AreEqual("Isle of Man", Country)

    End Sub

    <TestMethod()> Public Sub TestGetBalance()

        'Arrange
        Dim AccountOwner As String = "Ms I. N. Cognito"
        Dim AccountNumber As String = "ABCD 890111 11167890"
        Dim InterestRate As Double = 4.3
        Dim AccBalance As Double = 10343.82
        Dim AccCountry As String = "Isle of Man"
        Dim Account1 As New BankAcct(AccountOwner, AccountNumber, AccBalance, InterestRate, AccCountry)

        'Act
        Dim Balance As Double = Account1.GetBalance()

        'Assert
        Assert.AreEqual(10343.82, Balance)

    End Sub

    <TestMethod()> Public Sub TestGetAccountNumber()

        'Arrange
        Dim AccountOwner As String = "Ms I. N. Cognito"
        Dim AccountNumber As String = "ABCD 890111 11167890"
        Dim InterestRate As Double = 4.3
        Dim AccBalance As Double = 10343.82
        Dim AccCountry As String = "Isle of Man"
        Dim Account1 As New BankAcct(AccountOwner, AccountNumber, AccBalance, InterestRate, AccCountry)

        'Act
        Dim Number As String = Account1.GetAccountNumber()

        'Assert
        Assert.AreEqual("ABCD 890111 11167890", Number)

    End Sub

    <TestMethod()> Public Sub TestSetInterestRate()


        'Arrange
        Dim Account1 As BankAccounts.BankAcct = Me.NewAccount()

        'Act
        Account1.SetInterestRate(5.1)

        'Assert
        Assert.AreEqual(5.1, Account1.GetInterestRate())

    End Sub

    <TestMethod()> Public Sub TestApplyInteresRate()
        'p x r x t = i => 37.07 + 10343.82 = 10380.89

        'Arrange
        Dim Account1 As BankAccounts.BankAcct = Me.NewAccount()

        'Act
        Account1.ApplyInterest()

        'Assert
        Assert.AreEqual(Account1.GetBalance(), 10380.89)

    End Sub

    <TestMethod()> Public Sub TestToStringMethod()

        'Must print:
        'Isle of Man + vbcrlf
        'ABCD 890111 11167890 + vbcrlf
        'MS I.N.Cognito + vbcrlf
        'Interest: 4.3% + vbcrlf
        '10343.82 + vbcrlf

        'Arrange
        Dim ExpectedValueString As New StringBuilder()
        ExpectedValueString.Append("Isle of Man" & vbCrLf)
        ExpectedValueString.Append("ABCD 890111 11167890" & vbCrLf)
        ExpectedValueString.Append("MS I.N.Cognito" & vbCrLf)
        ExpectedValueString.Append("Interest: 4.3%" & vbCrLf)
        ExpectedValueString.Append("10343.82" & vbCrLf)


        Dim Account1 As BankAcct = NewAccount()

        'Act
        Dim ActualString = Account1.ToString()


        'Assert
        Assert.AreEqual(ExpectedValueString.ToString(), ActualString)

    End Sub

    <TestMethod()> Public Sub TestDeposit()

        'Arrange
        Dim Account1 As BankAccounts.BankAcct = Me.NewAccount()
        Dim ExpectedValue As Double = 10343.82 + 700

        'Act
        Dim ActualValue As Double = Account1.Deposit(700)

        'Assert
        Assert.AreEqual(ExpectedValue, ActualValue)

    End Sub

    <TestMethod()> Public Sub TestWithdrawalSmall()

        'Arrange
        Dim Account1 As BankAccounts.BankAcct = Me.NewAccount()
        Dim ExpectedVal As Double = 10343.82 - 700.0

        'Act
        Dim NewBalance = Account1.Withdrawal(700.0)

        'Assert
        Assert.AreEqual(ExpectedVal, NewBalance)

    End Sub

    <TestMethod()> Public Sub TestWithdrawalLarge()

        'Arrange
        Dim Account1 As BankAccounts.BankAcct = Me.NewAccount()
        Dim ExpectedVal As Double = 10343.82

        'Act
        Try
            Dim NewBalance = Account1.Withdrawal(11000.0)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        'Assert
        Assert.AreEqual(ExpectedVal, Account1.GetBalance())

    End Sub

    Private Function NewAccount() As BankAccounts.BankAcct

        'Housekeeping
        Dim AccountOwner As String = "Ms I. N. Cognito"
        Dim AccountNumber As String = "ABCD 890111 11167890"
        Dim InterestRate As Double = 4.3
        Dim AccBalance As Double = 10343.82
        Dim AccCountry As String = "Isle of Man"

        'Instantiate a new BankAccount object
        Dim Account1 As New BankAcct(AccountOwner, AccountNumber, AccBalance, InterestRate, AccCountry)

        'Return the New object
        Return Account1

    End Function

End Class


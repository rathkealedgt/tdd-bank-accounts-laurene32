Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports BankAccounts

<TestClass()> Public Class GUI_Test

    <TestMethod()> Public Sub TestCreateAccount()

        Dim AccountOwner As String = "Ms I. N. Cognito"
        Dim AccountNumber As String = "ABCD 890111 11167890"
        Dim InterestRate As String = "4.3"
        Dim AccBalance As String = "10343.82"
        Dim AccCountry As String = "Isle of Man"

        Dim BF As New BankAccountsForm()
        BF.SetTextForTesting(AccountOwner, AccountNumber, InterestRate, AccBalance, AccCountry)

        BF.CreateAccount()
        Dim TempAccount() As BankAcct = BF.GetAccounts()

        Assert.AreEqual(AccountOwner, TempAccount(0).GetAccountOwner())
        Assert.AreEqual(AccountNumber, BF.GetAccounts(0).GetAccountNumber())
        Assert.AreEqual(4.3, BF.GetAccounts(0).GetInterestRate)
        Assert.AreEqual(10343.82, BF.GetAccounts(0).GetBalance)
        Assert.AreEqual(AccCountry, BF.GetAccounts(0).GetCountry)

    End Sub

    <TestMethod()> Public Sub TestEmptyAccountOwner()

        Dim AccountOwner As String = ""
        Dim AccountNumber As String = "ABCD 890111 11167890"
        Dim InterestRate As String = "4.3"
        Dim AccBalance As String = "10343.82"
        Dim AccCountry As String = "Isle of Man"

        Dim BF As New BankAccountsForm()
        BF.SetTextForTesting(AccountOwner, AccountNumber, InterestRate, AccBalance, AccCountry)

        Try
            BF.CreateAccount()
            Assert.Fail()
        Catch ex As Exception
            Assert.AreEqual("AccountOwnerRequiredException", ex.Message)

        End Try

    End Sub

End Class
Imports System.Windows.Forms

Public Class BankAccountsForm

    Private Accounts(4) As BankAcct
    Private NumAccounts As Integer

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.NumAccounts = 0

    End Sub

    Public Function CreateAccount()

        Dim AccountOwner As String = txtAccountOwner.Text
        Dim AccountNumber = txtAccountNumber.Text
        Dim InterestRate As Double = CDbl(txtInterestRate.Text)
        Dim AccBalance As Double = CDbl(txtBalance.Text)
        Dim AccCountry As String = txtCountry.Text

        If AccountOwner = "" Then Throw New Exception("AccountOwnerRequiredException")

        Dim NewAccount As New BankAcct(AccountOwner, AccountNumber, InterestRate, AccBalance, AccCountry)
        Me.Accounts(Me.NumAccounts) = NewAccount

        Return Nothing
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()

    End Sub


    Public Function SetTextForTesting(AccountOwner As String, AccountNumber As String, AccBalance As String, InterestRate As String, Country As String)

        txtAccountOwner.Text = AccountOwner
        txtAccountNumber.Text = AccountNumber
        txtBalance.Text = AccBalance
        txtInterestRate.Text = InterestRate
        txtCountry.Text = Country

        Return Nothing

    End Function

    Public Function GetAccounts() As BankAcct()
        Return Me.Accounts

    End Function
End Class


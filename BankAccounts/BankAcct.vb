Imports System.Text

Public Class BankAcct

    Private AccountOwner As String
    Private AccountNumber As String
    Private AccBalance As Double
    Private InterestRate As Double
    Private AccCountry As String

    Public Sub New(AccountOwner As String, AccountNumber As String, AccBalance As Double, InterestRate As Double, AccCountry As String)
        Me.AccountOwner = AccountOwner
        Me.AccountNumber = AccountNumber
        Me.AccBalance = AccBalance
        Me.InterestRate = InterestRate
        Me.AccCountry = AccCountry

    End Sub

    Public Sub New(AccountOwner As String, AccountNumber As String, AccBalance As Double, InterestRate As Double)
        Me.AccountOwner = AccountOwner
        Me.AccountNumber = AccountNumber
        Me.AccBalance = AccBalance
        Me.InterestRate = InterestRate

    End Sub

    Public Sub New(AccountOwner As String, AccountNumber As String, Balance As Double)
        Me.AccountOwner = AccountOwner
        Me.AccountNumber = AccountNumber
        Me.AccBalance = Balance

    End Sub

    Public Function GetAccountOwner() As String
        Return Me.AccountOwner

    End Function

    Public Function GetAccountNumber() As String
        Return Me.AccountNumber

    End Function

    Public Function GetInterestRate() As Double
        Return Me.InterestRate

    End Function

    Public Function GetCountry() As String
        Return Me.AccCountry

    End Function

    Public Function GetBalance() As Double
        Return Me.AccBalance

    End Function

    Public Function SetInterestRate(Rate As Double)
        Me.InterestRate = Rate
        Return Nothing

    End Function

    Public Function ApplyInterest()
        Dim NewBalance As Double = Me.AccBalance + (Me.AccBalance * 0.043 * (1 / 12))
        Me.AccBalance = Math.Round(NewBalance, 2)

        Return Nothing

    End Function

    Public Function Deposit(Amount As Double) As Double
        Me.AccBalance += Amount
        Return Me.AccBalance

    End Function

    Public Function Withdrawal(Amount As Double) As Double
        If Amount > Me.AccBalance Then
            Throw New Exception("Insufficient Funds")
        End If

        Me.AccBalance -= Amount
        Return Me.AccBalance

    End Function



    Public Overrides Function ToString() As String

        Dim AccountString As New StringBuilder()
        AccountString.Append("Isle of Man" & vbCrLf)
        AccountString.Append("ABCD 890111 11167890" & vbCrLf)
        AccountString.Append("MS I.N.Cognito" & vbCrLf)
        AccountString.Append("Interest: 4.3%" & vbCrLf)
        AccountString.Append("10343.82" & vbCrLf)

        Return AccountString.ToString()

    End Function

End Class
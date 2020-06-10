<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BankAccountsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtAccountOwner = New System.Windows.Forms.TextBox()
        Me.AccountOwnerName = New System.Windows.Forms.Label()
        Me.btn_AddInterest = New System.Windows.Forms.Button()
        Me.btn_DespositWithdraw = New System.Windows.Forms.Button()
        Me.btn_AddAccount = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAccountNumber = New System.Windows.Forms.TextBox()
        Me.txtBalance = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtInterestRate = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtShowAccounts = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCountry = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.btn_transaction = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(467, 412)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 48)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtAccountOwner
        '
        Me.txtAccountOwner.Location = New System.Drawing.Point(15, 39)
        Me.txtAccountOwner.Name = "txtAccountOwner"
        Me.txtAccountOwner.Size = New System.Drawing.Size(211, 20)
        Me.txtAccountOwner.TabIndex = 1
        '
        'AccountOwnerName
        '
        Me.AccountOwnerName.AutoSize = True
        Me.AccountOwnerName.Location = New System.Drawing.Point(12, 23)
        Me.AccountOwnerName.Name = "AccountOwnerName"
        Me.AccountOwnerName.Size = New System.Drawing.Size(115, 13)
        Me.AccountOwnerName.TabIndex = 2
        Me.AccountOwnerName.Text = "Account Owner Name:"
        '
        'btn_AddInterest
        '
        Me.btn_AddInterest.Location = New System.Drawing.Point(266, 399)
        Me.btn_AddInterest.Name = "btn_AddInterest"
        Me.btn_AddInterest.Size = New System.Drawing.Size(110, 61)
        Me.btn_AddInterest.TabIndex = 3
        Me.btn_AddInterest.Text = "Add Interest"
        Me.btn_AddInterest.UseVisualStyleBackColor = True
        '
        'btn_DespositWithdraw
        '
        Me.btn_DespositWithdraw.Location = New System.Drawing.Point(139, 399)
        Me.btn_DespositWithdraw.Name = "btn_DespositWithdraw"
        Me.btn_DespositWithdraw.Size = New System.Drawing.Size(110, 61)
        Me.btn_DespositWithdraw.TabIndex = 4
        Me.btn_DespositWithdraw.Text = "Deposit / Withdraw"
        Me.btn_DespositWithdraw.UseVisualStyleBackColor = True
        '
        'btn_AddAccount
        '
        Me.btn_AddAccount.Location = New System.Drawing.Point(12, 399)
        Me.btn_AddAccount.Name = "btn_AddAccount"
        Me.btn_AddAccount.Size = New System.Drawing.Size(110, 61)
        Me.btn_AddAccount.TabIndex = 5
        Me.btn_AddAccount.Text = "Add Account"
        Me.btn_AddAccount.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Account Number:"
        '
        'txtAccountNumber
        '
        Me.txtAccountNumber.Location = New System.Drawing.Point(15, 98)
        Me.txtAccountNumber.Name = "txtAccountNumber"
        Me.txtAccountNumber.Size = New System.Drawing.Size(211, 20)
        Me.txtAccountNumber.TabIndex = 7
        '
        'txtBalance
        '
        Me.txtBalance.Location = New System.Drawing.Point(15, 159)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.Size = New System.Drawing.Size(211, 20)
        Me.txtBalance.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Balance"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(118, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Interest Rate:"
        '
        'txtInterestRate
        '
        Me.txtInterestRate.Location = New System.Drawing.Point(121, 198)
        Me.txtInterestRate.Name = "txtInterestRate"
        Me.txtInterestRate.Size = New System.Drawing.Size(105, 20)
        Me.txtInterestRate.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(317, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Accounts:"
        '
        'txtShowAccounts
        '
        Me.txtShowAccounts.Location = New System.Drawing.Point(320, 39)
        Me.txtShowAccounts.Multiline = True
        Me.txtShowAccounts.Name = "txtShowAccounts"
        Me.txtShowAccounts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtShowAccounts.Size = New System.Drawing.Size(211, 240)
        Me.txtShowAccounts.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 243)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Country:"
        '
        'txtCountry
        '
        Me.txtCountry.Location = New System.Drawing.Point(15, 259)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Size = New System.Drawing.Size(211, 20)
        Me.txtCountry.TabIndex = 15
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(12, 325)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(110, 61)
        Me.Button5.TabIndex = 16
        Me.Button5.Text = "Print Accounts"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'btn_transaction
        '
        Me.btn_transaction.Location = New System.Drawing.Point(139, 325)
        Me.btn_transaction.Name = "btn_transaction"
        Me.btn_transaction.Size = New System.Drawing.Size(110, 61)
        Me.btn_transaction.TabIndex = 17
        Me.btn_transaction.Text = "Transaction History"
        Me.btn_transaction.UseVisualStyleBackColor = True
        '
        'BankAccountsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 472)
        Me.Controls.Add(Me.btn_transaction)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.txtCountry)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtShowAccounts)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtInterestRate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBalance)
        Me.Controls.Add(Me.txtAccountNumber)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_AddAccount)
        Me.Controls.Add(Me.btn_DespositWithdraw)
        Me.Controls.Add(Me.btn_AddInterest)
        Me.Controls.Add(Me.AccountOwnerName)
        Me.Controls.Add(Me.txtAccountOwner)
        Me.Controls.Add(Me.Button1)
        Me.Name = "BankAccountsForm"
        Me.Text = "BankAccountsForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Windows.Forms.Button
    Friend WithEvents txtAccountOwner As Windows.Forms.TextBox
    Friend WithEvents AccountOwnerName As Windows.Forms.Label
    Friend WithEvents btn_AddInterest As Windows.Forms.Button
    Friend WithEvents btn_DespositWithdraw As Windows.Forms.Button
    Friend WithEvents btn_AddAccount As Windows.Forms.Button
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents txtAccountNumber As Windows.Forms.TextBox
    Friend WithEvents txtBalance As Windows.Forms.TextBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents txtInterestRate As Windows.Forms.TextBox
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents txtShowAccounts As Windows.Forms.TextBox
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents txtCountry As Windows.Forms.TextBox
    Friend WithEvents Button5 As Windows.Forms.Button
    Friend WithEvents btn_transaction As Windows.Forms.Button
End Class

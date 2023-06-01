Imports System.Data.SqlClient


Partial Class Loan_Approval
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtBsinessName = New System.Windows.Forms.TextBox()
        Me.txtPhoneNo = New System.Windows.Forms.TextBox()
        Me.txtAnnual = New System.Windows.Forms.TextBox()
        Me.txtLoadTerm = New System.Windows.Forms.TextBox()
        Me.txtAdd = New System.Windows.Forms.ListView()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(14, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 18)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Business Name :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(353, 37)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 18)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Address :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(353, 192)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 18)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Loan Term :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(353, 245)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 18)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Annual Income :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(14, 121)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(98, 36)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Business Phone" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " No :"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtBsinessName
        '
        Me.txtBsinessName.Location = New System.Drawing.Point(124, 36)
        Me.txtBsinessName.Name = "txtBsinessName"
        Me.txtBsinessName.Size = New System.Drawing.Size(196, 23)
        Me.txtBsinessName.TabIndex = 5
        '
        'txtPhoneNo
        '
        Me.txtPhoneNo.Location = New System.Drawing.Point(124, 121)
        Me.txtPhoneNo.Name = "txtPhoneNo"
        Me.txtPhoneNo.Size = New System.Drawing.Size(196, 23)
        Me.txtPhoneNo.TabIndex = 6
        '
        'txtAnnual
        '
        Me.txtAnnual.Location = New System.Drawing.Point(464, 245)
        Me.txtAnnual.Name = "txtAnnual"
        Me.txtAnnual.Size = New System.Drawing.Size(196, 23)
        Me.txtAnnual.TabIndex = 7
        '
        'txtLoadTerm
        '
        Me.txtLoadTerm.Location = New System.Drawing.Point(454, 192)
        Me.txtLoadTerm.Name = "txtLoadTerm"
        Me.txtLoadTerm.Size = New System.Drawing.Size(206, 23)
        Me.txtLoadTerm.TabIndex = 8
        '
        'txtAdd
        '
        Me.txtAdd.Location = New System.Drawing.Point(439, 37)
        Me.txtAdd.Name = "txtAdd"
        Me.txtAdd.Size = New System.Drawing.Size(221, 120)
        Me.txtAdd.TabIndex = 13
        Me.txtAdd.UseCompatibleStateImageBehavior = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnSearch.Font = New System.Drawing.Font("Harrington", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSearch.Location = New System.Drawing.Point(175, 65)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(81, 24)
        Me.btnSearch.TabIndex = 15
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button2.Font = New System.Drawing.Font("Harrington", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button2.Location = New System.Drawing.Point(601, 396)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 35)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Submit"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button3.Font = New System.Drawing.Font("Harrington", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button3.Location = New System.Drawing.Point(512, 396)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(83, 35)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "Cancel"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Goldenrod
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.txtAdd)
        Me.Panel1.Controls.Add(Me.txtLoadTerm)
        Me.Panel1.Controls.Add(Me.txtAnnual)
        Me.Panel1.Controls.Add(Me.txtPhoneNo)
        Me.Panel1.Controls.Add(Me.txtBsinessName)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Location = New System.Drawing.Point(14, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(698, 320)
        Me.Panel1.TabIndex = 18
        '
        'Loan_Approval
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Firebrick
        Me.ClientSize = New System.Drawing.Size(728, 484)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Name = "Loan_Approval"
        Me.Text = "Loan_Approval"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtBsinessName As TextBox
    Friend WithEvents txtPhoneNo As TextBox
    Friend WithEvents txtAnnual As TextBox
    Friend WithEvents txtLoadTerm As TextBox
    Friend WithEvents txtAdd As ListView
    Friend WithEvents btnSearch As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel1 As Panel

    Private Sub btnSearch_Click(sender As Object, e As EventArgs)
        btnSearch_Click(sender, e, Reader, Reader, Reader, Reader)
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs, reader1 As Object, reader2 As Object, sqlDataReader1 As SqlDataReader, sqlDataReader2 As SqlDataReader)
        Throw New NotImplementedException()
    End Sub

    Private ReadOnly Property Reader As SqlDataReader
        Get
            Return Reader
        End Get
    End Property

    Private ReadOnly Property Reader1 As SqlDataReader
        Get
            Return Reader
        End Get
    End Property

    Private Sub btnSearch_Click(sender As Object, e As EventArgs, reader As SqlDataReader, reader As SqlDataReader, reader As SqlDataReader, reader As SqlDataReader)
        btnSearch_Click(sender, e, reader, reader, reader, reader, reader, Reader1, reader)
    End Sub

    Private Function GetReader() As SqlDataReader
        Return Reader
    End Function

    Private Sub btnSearch_Click(sender As Object, e As EventArgs, reader As SqlDataReader, reader As SqlDataReader, reader As SqlDataReader, reader As SqlDataReader, reader As SqlDataReader, reader As SqlDataReader, reader As SqlDataReader) Handles btnSearch.Click
        Dim connectionString As String = "Data Source=CHAAA\LOUISSAJOHN;Initial Catalog=MiniProject2;Trusted_Connection = True;"
        Dim connection As New SqlConnection(connectionString)
        Dim value = connection.Open()

        Dim query As String = "SELECT * FROM Login WHERE  Username=@Username"
        Dim command As New SqlCommand(query, connection)

        command.Parameters.AddWithValue("@Username", btnSearch.Text)
        Dim reader As SqlDataReader = command.ExecuteReader()

        While reader.Read()
            txtBsinessName.Text = reader("Username").ToString()
            txtAdd.Text = reader("Password").ToString()
            txtAnnual.Text = reader("Password").ToString()
            txtBsinessName.Text = reader("Password").ToString()
            txtPhoneNo.Text = reader("Password").ToString()
        End While
        Dim value1 = connection.Close()
    End Sub

End Class

Friend Class SqlDataReader
    Public Property HasRows As Boolean

    Friend ReadOnly Property Read As Boolean
        Get
            Throw New NotImplementedException()
        End Get
    End Property
End Class

Friend Class SqlCommand
    Private query As String
    Private connection As SqlConnection

    Public Sub New(query As String, connection As SqlConnection)
        Me.query = query
        Me.connection = connection
    End Sub

    Friend ReadOnly Property ExecuteReader As SqlDataReader
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Friend Function Parameters() As Object
        Throw New NotImplementedException()
    End Function
End Class

Friend Class SqlConnection
    Private connectionString As String

    Public Sub New(connectionString As String)
        Me.connectionString = connectionString
    End Sub

    Friend ReadOnly Property Open As Object
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Friend ReadOnly Property Close As Object
        Get
            Throw New NotImplementedException()
        End Get
    End Property
End Class

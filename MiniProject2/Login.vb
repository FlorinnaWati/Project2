Public Class Login
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim rdr As SqlDataReader

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles txtPassword.Click

    End Sub

    Private Function GetCmd() As SqlCommand
        Return cmd
    End Function

    Private Sub Loginbutton_Click(sender As Object, e As EventArgs, con As Object, cmd As SqlCommand) Handles Loginbutton.Click

        If (txtboxUsername.Text = "") Then
            MessageBox.Show("Enter the username") ' User enter your name '
            txtboxUsername.Focus()

            Exit Sub

        End If
        If (txtboxPassword.Text = "") Then
            MessageBox.Show("Enter the password") ' user enter your password '
            txtboxPassword.Focus()

            Exit Sub
        End If
        Try
            Dim value = CObj(New SqlConnection("Data Source=CHAAA\LOUISSAJOHN;Initial Catalog=MiniProject2;Trusted_Connection = True;")).Open()
            cmd = New SqlCommand("select * from login where username= '" + txtboxUsername.Text + "'and password='" + txtboxPassword.Text + "'", New SqlConnection("Data Source=CHAAA\LOUISSAJOHN;Initial Catalog=LabTask4;Trusted_Connection = True;"))
            rdr = cmd.ExecuteReader()
            If (rdr.Read()) Then
                Form1.Show()


            End If

        Catch ex As Exception
        End Try
        Form1.Show()
    End Sub
End Class

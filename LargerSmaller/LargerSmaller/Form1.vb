Public Class Form1
    Private Sub btnCompare_Click(sender As Object, e As EventArgs) Handles btnCompare.Click
        Dim intA As Int32
        Dim intB As Int32
        'intA = Convert.ToInt32(txtA.Text)
        'intB = Convert.ToInt32(txtB.Text)

        If Integer.TryParse(txtA.Text, intA) And Integer.TryParse(txtB.Text, intB) Then
            If intA > intB Then
                lblMessage.Text = "Value A is greatest"
            ElseIf intB > intA Then
                lblMessage.Text = "Value B is greatest"
            Else
                lblMessage.Text = "Both are equal"
            End If
        Else
            lblMessage.Text = "Cannot convert to an integer"
        End If


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class

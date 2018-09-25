Public Class Form1

    'the Val function converts text to numerical data'
    ' If a non-number is input, it converts it to 0'
    Private Sub mnuArea_Click(sender As Object, e As EventArgs) Handles mnuArea.Click
        MessageBox.Show("The area of the cirle with radius " & txtRadius.Text & " is " & Math.PI * Math.Pow(Val(txtRadius.Text, 2)))
    End Sub

    Private Sub mnuPerimeter_Click(sender As Object, e As EventArgs) Handles mnuPerimeter.Click
        MessageBox.Show("The perimeter of the circle with radius " & txtRadius.Text & " is " & 2 * Math.PI * (Val(txtRadius.Text)))
    End Sub

End Class

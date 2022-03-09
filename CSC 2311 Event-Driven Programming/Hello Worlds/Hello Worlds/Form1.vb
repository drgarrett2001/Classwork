'David Garrett
Option Strict On
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClickMe.Click
        Console.WriteLine("Hello World!")

    End Sub
    'clicking the button
    Private Sub chk1_CheckedChanged(sender As Object, e As EventArgs) Handles chk1.CheckedChanged

        Console.WriteLine("Hello World!")
    End Sub
    'check the box
    Private Sub txtBox_TextChanged(sender As Object, e As EventArgs) Handles txtBox.TextChanged
        Console.WriteLine("Hello World!")
    End Sub
    'click the dog picture
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles imgCLick.Click
        Console.WriteLine("Hello World!")
    End Sub
    'click the progress bar
    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles prgClick.Click
        Console.WriteLine("Hello World!")
    End Sub
End Class

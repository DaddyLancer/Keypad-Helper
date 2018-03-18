Public Class Form1
    Private WithEvents kbHook As New KeyboardHook


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub kbHook_KeyDown(Key As Keys) Handles kbHook.KeyDown
        Debug.WriteLine(Key.ToString)
    End Sub

    Private Sub kbHook_KeyUp(Key As Keys) Handles kbHook.KeyUp
        Debug.WriteLine(Key)
    End Sub


End Class
Public Class Form1
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles Tk.TextChanged

    End Sub

    Private Sub B1_Click(sender As Object, e As EventArgs) Handles B1.Click
        Dim i, x1, x2, S, k As Integer, Sa As Single
        S = 0 : k = 0
        For i = 10 To 99
            x1 = i \ 10
            x2 = i Mod 10
            If x1 < x2 Then
                Posl.Text = Posl.Text + CStr(i) + vbNewLine
                S = S + i
                k = k + i

            End If
        Next
        If k <> 0 Then Sa = S / k
        TS.Text = S
        Tk.Text = k
        TSa.Text = Sa

    End Sub
End Class

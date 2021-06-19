Public Class Form1

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ans.Click

    End Sub

    

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tasu.Click
        Ans.Text = Val(T1.Text) + Val(T2.Text)
        kigou.Text = "＋"
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kakeru.Click
        Ans.Text = Val(T1.Text) / Val(T2.Text)
        kigou.Text = "÷"
    End Sub

    Private Sub mainasu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mainasu.Click
        Ans.Text = Val(T1.Text) - Val(T2.Text)
        kigou.Text = "－"
    End Sub

    Private Sub waru_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles waru.Click
        Ans.Text = Val(T1.Text) * Val(T2.Text)
        kigou.Text = "×"
    End Sub

    Private Sub Label1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub kigou_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kigou.Click

    End Sub
End Class

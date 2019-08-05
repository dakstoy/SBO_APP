Public Class Form5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim N As String

        N = InputBox("Enter Team name")

        TreeView1.SelectedNode.Nodes.Add(N, N)

    End Sub


End Class
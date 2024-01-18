
Public Class Form1

    Private Sub BTN_PRO_Click(sender As Object, e As EventArgs) Handles BTN_PRO.Click
        Dim CBIN As Integer = CB1.SelectedIndex
        Dim CBINDUP As Integer = CB2.SelectedIndex
        Dim DIS As Integer = CB3.SelectedIndex
        Dim DIS2 As Double
        If CB1.SelectedIndex = CB2.SelectedIndex Then
            CB1.SelectedIndex = -1
            CB2.SelectedIndex = -1
            CB3.SelectedIndex = -1
            OR1.Text = ""
            DS1.Text = ""
            GF1.Text = ""
            DIS1.Text = ""
            NF1.Text = ""
        End If

        Dim RES As Integer = Math.Abs(CBIN - CBINDUP) * 20
        If DIS = 1 Then
            DIS2 = RES * 0.1

        ElseIf DIS = 2 Then
            DIS2 = RES * 0.15
        ElseIf DIS = 3 Then
            DIS2 = RES * 0.2
        ElseIf DIS = 4 Then
            DIS2 = RES * 0.5
        End If

        OR1.Text = CB1.SelectedItem
        DS1.Text = CB2.SelectedItem
        GF1.Text = RES.ToString("0.00")
        DIS1.Text = DIS2.ToString("0.00")
        NF1.Text = (RES - DIS2).ToString("0.00")
    End Sub

    Private Sub DS1_TextChanged(sender As Object, e As EventArgs) Handles DS1.TextChanged

    End Sub
End Class


Public Class Form1
    Dim a, b As Single
    Dim sign As String
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = TextBox1.Text & 0 & 0
        TextBox2.Text = TextBox2.Text & 0 & 0

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        TextBox1.Text = TextBox1.Text & 1
        TextBox2.Text = TextBox2.Text & 1
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        TextBox1.Text = TextBox1.Text & 2
        TextBox2.Text = TextBox2.Text & 2
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        TextBox1.Text = TextBox1.Text & 3
        TextBox2.Text = TextBox2.Text & 3
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.Text = TextBox1.Text & 4
        TextBox2.Text = TextBox2.Text & 4
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TextBox1.Text = TextBox1.Text & 5
        TextBox2.Text = TextBox2.Text & 5
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        TextBox1.Text = TextBox1.Text & 6
        TextBox2.Text = TextBox2.Text & 6
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = TextBox1.Text & 7
        TextBox2.Text = TextBox2.Text & 7

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text = TextBox1.Text & 8
        TextBox2.Text = TextBox2.Text & 8

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text = TextBox1.Text & 9
        TextBox2.Text = TextBox2.Text & 9

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        TextBox1.Text = TextBox1.Text & 0
        TextBox2.Text = TextBox2.Text & 0



    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        b = TextBox1.Text
        If sign = "+" Then
            TextBox1.Text = a + b
        Else
            b = TextBox1.Text
            If sign = "-" Then
                TextBox1.Text = a - b
            Else
                b = TextBox1.Text
                If sign = "*" Then
                    TextBox1.Text = a * b
                Else
                    b = TextBox1.Text
                    If sign = "/" Then
                        TextBox1.Text = a / b
                    Else


                    End If
                End If
            End If
        End If
        TextBox2.Text = TextBox2.Text & "="
        TextBox2.Text = TextBox2.Text & TextBox1.Text










    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        TextBox1.Text = TextBox1.Text & "."
        TextBox2.Text = TextBox2.Text & "."
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        a = TextBox1.Text
        sign = "-"
        TextBox1.Text = ""
        TextBox2.Text = TextBox2.Text & "-"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        a = TextBox1.Text
        sign = "*"
        TextBox1.Text = ""
        TextBox2.Text = TextBox2.Text & "x"
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click

        a = TextBox1.Text
        sign = "/"
        TextBox1.Text = ""
        TextBox2.Text = TextBox2.Text & "/"


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs)
        TextBox2.Text = ""

    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        If TextBox1.Text.Length > 0 Then
            TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Length - 1, 1)
        End If
        TextBox2.Text = TextBox2.Text.Remove(TextBox2.Text.Length - 1, 1)

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub OnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OnToolStripMenuItem.Click
        TextBox2.Visible = True
    End Sub

    Private Sub OffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OffToolStripMenuItem.Click
        TextBox2.Visible = False
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs)
        a = TextBox1.Text
        sign = "%"
        TextBox1.Text = ""
        TextBox2.Text = TextBox2.Text & "%"

    End Sub

    Private Sub ViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewToolStripMenuItem.Click

    End Sub

    Private Sub AutoCalculateToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Button9.Enabled = True
    End Sub

    Private Sub CreaditsAboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreaditsAboutToolStripMenuItem.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button19.Enabled = True
    End Sub

    Private Sub AutoCalculateToolStripMenuItem_Click_1(sender As Object, e As EventArgs)


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub OnToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        Me.Width = 645

    End Sub

    Private Sub OffToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        Me.AutoSize = 739
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub HistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistoryToolStripMenuItem.Click

    End Sub

    Private Sub OnToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles OnToolStripMenuItem1.Click
        Me.AutoSize = 739
    End Sub

    Private Sub OffToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) 

    End Sub

    Private Sub OffToolStripMenuItem1_Click_2(sender As Object, e As EventArgs) Handles OffToolStripMenuItem1.Click
        If (MsgBox("To Close Credits And Instructions Please Restart The Applications Manually Or Reasize The Window As You Like . Do You Want To Close This Calculator And Restart Manually ?", vbQuestion + vbYesNo, "Ask")) = vbYes Then
            End

        End If
    End Sub

    Private Sub Button22_Click_1(sender As Object, e As EventArgs) Handles Button22.Click
        TextBox1.Text = ""
        TextBox2.Text = TextBox2.Text & " "

    End Sub

    Private Sub HistoryClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistoryClearToolStripMenuItem.Click
        TextBox2.Text = ""
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim webadd As String
        webadd = "https://github.com/DeveloperSumanOfficial"
        Process.Start(webadd)
    End Sub

    Private Sub CheckUpdateManuallyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckUpdateManuallyToolStripMenuItem.Click
        If (MsgBox("Go To The GitHub WebSite and Check Update Manually.Compare Current Version To The Latest Version or New Version . If There Is Any Latest Version Avalable Update It. If Update Not Work then Manually Uninstall The Current Version At First and then Install The Latest Version. Do You Want To Check It Right Now  ? Current Version Is : 0.0.0.3 ", vbQuestion + vbYesNo, "Ask")) = vbYes Then
            Dim webadd As String
            webadd = "https://github.com/DeveloperSumanOfficial/Standard-Calculator/releases/tag/Application"
            Process.Start(webadd)
        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        a = TextBox1.Text
        sign = "+"
        TextBox1.Text = ""
        TextBox2.Text = TextBox2.Text & "+"



    End Sub
End Class
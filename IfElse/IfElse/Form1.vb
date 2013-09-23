Option Strict On

Public Class Form1

    Private Sub btnFindLarger_Click(sender As System.Object, e As System.EventArgs) Handles btnFindLarger.Click
        Dim num1, num2 As Double
        If IsNumeric(txtFirstNum.Text) and IsNumeric(txtSecondNum.Text) Then ' if you say Or instead of And, it crashes because Ir means "if either one works, proceed"

           

            'Sterile area
            num1 = CDbl(txtFirstNum.Text)
            num2 = CDbl(txtSecondNum.Text)
            If num1 < 0 Or num2 < 0 Then

                MessageBox.Show("Error please type a positive number")
            End If


            If (num1 > num2) Then

                txtResult.Text = "The Larger number is " & num1
            ElseIf (num1 < num2) Then

                txtResult.Text = "The Larger number is " & num2
            Else
                txtResult.Text = "They are equal"
            End If
        Else
            MessageBox.Show("Error, please type a number")

        End If






    End Sub
End Class

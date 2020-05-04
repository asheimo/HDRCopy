Public Class AddDisplayProperty
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        For Each tb As TextBox In Me.Controls.OfType(Of TextBox)()
            If Not tb.Name = tbxName.Name Then
                Select Case tb.Name
                    Case tbxRedX.Name

                    Case tbxRedY.Name

                    Case tbxGreenX.Name
                    Case tbxGreenY.Name
                    Case tbxBlueX.Name
                    Case tbxBlueY.Name
                    Case tbxWhiteX.Name
                    Case tbxWhiteY.Name

                End Select
            End If

        Next

    End Sub
End Class
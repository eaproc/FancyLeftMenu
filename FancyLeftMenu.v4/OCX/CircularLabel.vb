Imports DevExpress.XtraEditors
Imports System.Drawing




Namespace OCX

    Public Class CircularLabel
        Inherits LabelControl


        Public Sub New()
            MyBase.New()


            Me.AutoSizeMode = LabelAutoSizeMode.None
            With Me.Appearance.TextOptions
                .HAlignment = DevExpress.Utils.HorzAlignment.Center
                .VAlignment = DevExpress.Utils.VertAlignment.Center
            End With


        End Sub








        Private Sub CircularLabel_Resize(sender As Object, e As EventArgs) Handles Me.Resize
            If Me.Width <> Me.Height Then
                Me.Width = Me.Height
                Return
            End If

            Dim r As Rectangle = New Rectangle(0, 0, Me.Width, Me.Height)
            Dim gp As System.Drawing.Drawing2D.GraphicsPath = New System.Drawing.Drawing2D.GraphicsPath()

            gp.AddEllipse(0, 0, Me.Width - 1, Me.Height - 1)

            Me.Region = New Region(gp)

        End Sub
    End Class


End Namespace
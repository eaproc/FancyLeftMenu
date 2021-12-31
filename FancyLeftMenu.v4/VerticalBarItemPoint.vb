Imports System.Drawing





Friend Class VerticalBarItemPoint


#Region "Properties"






#End Region





#Region "Constructors"


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.pnlPositionIndicator.Width = Me.Width
        Me.pnlPositionIndicator.Left = 0

    End Sub


    Public Sub New(pIndicatorColor As Color)
        Me.New()
        Me.pnlPositionIndicator.BackColor = pIndicatorColor

    End Sub



#End Region





#Region "Methods"


    Public Sub hideIndicator()
        Me.SetIndicator(0, 0)
    End Sub


    Public Sub SetIndicator(pTop As Int32,
                            pHeight As Int32
                            )
        Me.pnlPositionIndicator.Top = pTop
        Me.pnlPositionIndicator.Height = pHeight

    End Sub



#End Region






    Private Sub VerticalBarItemPoint_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Me.pnlPositionIndicator.Width = Me.Width
    End Sub


End Class








    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class VerticalBarItemPoint
        Inherits DevExpress.XtraEditors.XtraUserControl

        'UserControl overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.pnlPositionIndicator = New DevExpress.XtraEditors.PanelControl()
            CType(Me.pnlPositionIndicator, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'pnlPositionIndicator
            '
            Me.pnlPositionIndicator.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(45, Byte), Integer))
            Me.pnlPositionIndicator.Appearance.Options.UseBackColor = True
            Me.pnlPositionIndicator.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pnlPositionIndicator.Location = New System.Drawing.Point(17, 17)
            Me.pnlPositionIndicator.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
            Me.pnlPositionIndicator.LookAndFeel.UseDefaultLookAndFeel = False
            Me.pnlPositionIndicator.Name = "pnlPositionIndicator"
            Me.pnlPositionIndicator.Size = New System.Drawing.Size(31, 78)
            Me.pnlPositionIndicator.TabIndex = 1
            '
            'VerticalBarItemPoint
            '
            Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
            Me.Appearance.Options.UseBackColor = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.pnlPositionIndicator)
            Me.Name = "VerticalBarItemPoint"
            Me.Size = New System.Drawing.Size(300, 177)
            CType(Me.pnlPositionIndicator, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents pnlPositionIndicator As DevExpress.XtraEditors.PanelControl

    End Class



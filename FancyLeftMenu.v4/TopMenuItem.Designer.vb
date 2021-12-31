

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class TopMenuItem
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TopMenuItem))
            Me.picMenuIcon = New System.Windows.Forms.PictureBox()
            Me.lblMenuText = New DevExpress.XtraEditors.LabelControl()
        Me.CircularNotification = New OCX.CircularLabel()
            CType(Me.picMenuIcon, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'picMenuIcon
            '
            Me.picMenuIcon.BackColor = System.Drawing.Color.White
            Me.picMenuIcon.Cursor = System.Windows.Forms.Cursors.Hand
            Me.picMenuIcon.Image = CType(resources.GetObject("picMenuIcon.Image"), System.Drawing.Image)
            Me.picMenuIcon.Location = New System.Drawing.Point(21, 10)
            Me.picMenuIcon.Name = "picMenuIcon"
            Me.picMenuIcon.Size = New System.Drawing.Size(16, 16)
            Me.picMenuIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.picMenuIcon.TabIndex = 10
            Me.picMenuIcon.TabStop = False
            '
            'lblMenuText
            '
            Me.lblMenuText.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMenuText.Appearance.ForeColor = System.Drawing.Color.White
            Me.lblMenuText.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblMenuText.Location = New System.Drawing.Point(70, 10)
            Me.lblMenuText.Name = "lblMenuText"
            Me.lblMenuText.Size = New System.Drawing.Size(78, 13)
            Me.lblMenuText.TabIndex = 11
            Me.lblMenuText.Text = "LabelControl1"
            '
            'CircularNotification
            '
            Me.CircularNotification.AutoSize = True
            Me.CircularNotification.Location = New System.Drawing.Point(282, 11)
            Me.CircularNotification.Name = "CircularNotification"
            Me.CircularNotification.Size = New System.Drawing.Size(38, 13)
            Me.CircularNotification.TabIndex = 12
            Me.CircularNotification.Text = "Label1"
            '
            'TopMenuItem
            '
            Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
            Me.Appearance.Options.UseBackColor = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.CircularNotification)
            Me.Controls.Add(Me.lblMenuText)
            Me.Controls.Add(Me.picMenuIcon)
            Me.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Name = "TopMenuItem"
            Me.Size = New System.Drawing.Size(331, 39)
            CType(Me.picMenuIcon, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents picMenuIcon As System.Windows.Forms.PictureBox
        Friend WithEvents lblMenuText As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CircularNotification As OCX.CircularLabel

    End Class



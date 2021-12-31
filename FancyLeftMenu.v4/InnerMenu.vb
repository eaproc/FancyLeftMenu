Imports System.Windows.Forms





    ''' <summary>
    ''' Non Resizable Left Menu Manager
    ''' </summary>
    ''' <remarks></remarks>
    Public Class InnerMenu
        Inherits DevExpress.XtraEditors.LabelControl




#Region "Properties"

        'Private ____Font As Font,
        '               ____BackColor As Color,
        '               ____ForeColor As Color,
        '               ____HighlightForeColor As Color,
        '               ____SelectedForeColor As Color

        Private _____themeForDisplay As Themes.IFancyMenuTheme__v1



        Private ____IsSelected As Boolean
        Public Property IsSelected As Boolean
            Get
                Return Me.____IsSelected
            End Get
            Set(value As Boolean)
                Me.____IsSelected = value
                If Me.IsSelected Then
                    Me.ForeColor = Me._____themeForDisplay.InnerItem___SelectionForeColor
                    'Me.Font = New Font(Me.Font, FontStyle.Bold)
                    'Me.Font = New Font(Me.Font.FontFamily, Me.____Font.Size)
                    Me.Font = Me._____themeForDisplay.InnerItem___SelectedFont
                Else
                    Me.ForeColor = Me._____themeForDisplay.InnerItem___ForeColor
                    'Me.Font = New Font(Me.Font, FontStyle.Regular)
                    Me.Font = Me._____themeForDisplay.InnerItem___Font

                End If
                RaiseEvent SelectionChanged(Me)
            End Set
        End Property





#End Region






#Region "Constructors"

        Public Sub New(pName As String,
                      pText As String,
                     pTheme As Themes.IFancyMenuTheme__v1
                     )
            MyBase.New()
            Me._____themeForDisplay = pTheme

            'Me.____BackColor = pBackColor
            'Me.____Font = pFont
            'Me.____ForeColor = pForeColor
            'Me.____HighlightForeColor = pHighlightForeColor
            'Me.____SelectedForeColor = pSelectedForeColor

            Me.BackColor = pTheme.InnerItem___BackColor
            Me.ForeColor = pTheme.InnerItem___ForeColor
            Me.Font = pTheme.InnerItem___Font


            Me.Name = pName
            Me.Text = pText


        End Sub

        'Public Sub New(pName As String,
        '               pText As String,
        '               pFont As Font,
        '               pBackColor As Color,
        '               pForeColor As Color,
        '               pHighlightForeColor As Color,
        '               pSelectedForeColor As Color)
        '    MyBase.New()

        '    Me.____BackColor = pBackColor
        '    Me.____Font = pFont
        '    Me.____ForeColor = pForeColor
        '    Me.____HighlightForeColor = pHighlightForeColor
        '    Me.____SelectedForeColor = pSelectedForeColor

        '    Me.BackColor = pBackColor
        '    Me.ForeColor = pForeColor
        '    Me.Font = pFont


        '    Me.Name = pName
        '    Me.Text = pText


        'End Sub





#End Region


#Region "Events"
        Public Event SelectionChanged(pMenu As InnerMenu)
#End Region



#Region "Enums and Consts"




#End Region






#Region "Methods"

        Public Sub selectMenu()
            ' Me.IsSelected = False
            InnerMenu_MouseClick(Me, Nothing)
        End Sub


#End Region

        Private Sub InnerMenu_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick

            If Me.IsSelected Then Return ' Disable Unchecking

            Me.IsSelected = Not Me.IsSelected
        End Sub

        Private Sub InnerMenu_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        End Sub

        Private Sub InnerMenu_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter
            If Not Me.IsSelected Then
                'Me.ForeColor = Me.____HighlightForeColor
                'Me.Font = New Font(Me.Font.FontFamily, Me.____Font.Size + 1)
                Me.Font = Me._____themeForDisplay.InnerItem___HighlightedFont
                Me.ForeColor = Me._____themeForDisplay.InnerItem___HighlightForeColor

            End If
        End Sub









        Private Sub InnerMenu_MouseHover(sender As Object, e As EventArgs) Handles Me.MouseHover
            '    Not fast enough
        End Sub

        Private Sub InnerMenu_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave
            If Not Me.IsSelected Then
                Me.Font = Me._____themeForDisplay.InnerItem___Font
                Me.ForeColor = Me._____themeForDisplay.InnerItem___ForeColor

            End If

        End Sub

        Private Sub InnerMenu_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp

        End Sub















    End Class




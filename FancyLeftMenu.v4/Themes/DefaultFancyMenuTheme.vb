Imports System.Runtime.Serialization
Imports System.Drawing


Namespace Themes

    <Serializable()>
    Public Class DefaultFancyMenuTheme
        Implements IFancyMenuTheme





#Region "Constructors"

        Public Sub New()
            Me.New(CType(Nothing, Image))
        End Sub

        Public Sub New(pDefaultIcon As Image)

            Me._____________TopItem___Icon = pDefaultIcon


        End Sub


        Public Sub New(pTheme As DefaultFancyMenuTheme)


            '   Fonts
            With pTheme
                Me._____________GeneralFont = .GeneralFont

                Me._____________TopItem___Font = .TopItem___Font
                Me._____________TopItem___HighlightedFont = .TopItem___HighlightedFont
                Me._____________TopItem___SelectedFont = .TopItem___SelectedFont

                Me._____________InnerItem___Font = .InnerItem___Font
                Me._____________InnerItem___SelectedFont = .InnerItem___SelectedFont
                Me._____________InnerItem___HighlightedFont = .InnerItem___HighlightedFont














                '   Images

                Me._____________TopItem___Icon = .TopItem___Icon











                '   Colors

                '   Menu Panel Area Color
                Me._____________MenuArea___BackColor = .MenuArea___BackColor



                Me._____________TopItem___BackColor = .TopItem___BackColor
                Me._____________TopItem___ForeColor = .TopItem___ForeColor
                Me._____________TopItem___HighlightForeColor = .TopItem___HighlightForeColor
                Me._____________TopItem___HighlightBackColor = .TopItem___HighlightBackColor
                Me._____________TopItem___SelectionBackColor = .TopItem___SelectionBackColor
                Me._____________TopItem___SelectionForeColor = .TopItem___SelectionForeColor


                Me._____________InnerItem___BackColor = .InnerItem___BackColor
                Me._____________InnerItem___ForeColor = .InnerItem___ForeColor
                Me._____________InnerItem___HighlightForeColor = .InnerItem___HighlightForeColor
                Me._____________InnerItem___SelectionForeColor = .InnerItem___SelectionForeColor





                Me._____________Indicator___SelectedColor = .Indicator___SelectedColor
                Me._____________Indicator___BackColor = .Indicator___BackColor











                '   Layout Settings
                Me._____________MenuArea___PadTop = .MenuArea___PadTop



                Me._____________TopItem___Height = .TopItem___Height
                Me._____________TopItem___ImageIndent = .TopItem___ImageIndent
                Me._____________TopItem___TextIndent = .TopItem___TextIndent


                Me._____________Indicator___Width = .Indicator___Width
                Me._____________Indicator___LeftIndent = .Indicator___LeftIndent


                Me._____________InnerItem___Height = .InnerItem___Height
                Me._____________InnerItem___MarginBottom = .InnerItem___MarginBottom
                Me._____________InnerItem___IndicatorIndent = .InnerItem___IndicatorIndent



            End With




        End Sub


#End Region





        '   Fonts

        Protected _____________GeneralFont As Font = New Font("Proxima Nova Rg", 10.75)

        Protected _____________TopItem___Font As Font = GeneralFont
        Protected _____________TopItem___HighlightedFont As Font = GeneralFont
        Protected _____________TopItem___SelectedFont As Font = GeneralFont

        Protected _____________InnerItem___Font As Font = New Font(GeneralFont.FontFamily, GeneralFont.Size - 1)
        Protected _____________InnerItem___SelectedFont As Font = GeneralFont
        Protected _____________InnerItem___HighlightedFont As Font = GeneralFont














        '   Images

        Protected _____________TopItem___Icon As Image











        '   Colors

        '   Menu Panel Area Color
        Protected _____________MenuArea___BackColor As Color = Color.WhiteSmoke


        Protected _____________TopItem___BackColor As Color = _____________MenuArea___BackColor
        Protected _____________TopItem___ForeColor As Color = Color.DimGray
        Protected _____________TopItem___HighlightForeColor As Color = Color.White
        Protected _____________TopItem___HighlightBackColor As Color = Color.Gray
        Protected _____________TopItem___SelectionBackColor As Color = Color.DarkGray
        Protected _____________TopItem___SelectionForeColor As Color = Color.White


        Protected _____________InnerItem___BackColor As Color = Color.LightGray
        Protected _____________InnerItem___ForeColor As Color = Color.DimGray
        Protected _____________InnerItem___HighlightForeColor As Color = Color.White
        Protected _____________InnerItem___SelectionForeColor As Color = Color.Black





        Protected _____________Indicator___SelectedColor As Color = Color.DarkGray
        Protected _____________Indicator___BackColor As Color = Color.WhiteSmoke











        '   Layout Settings
        Protected _____________MenuArea___PadTop As Int32 = 30



        Protected _____________TopItem___Height As Int32 = 52
        Protected _____________TopItem___ImageIndent As Int32 = 20
        Protected _____________TopItem___TextIndent As Int32 = 15


        Protected _____________Indicator___Width As Int32 = 4
        Protected _____________Indicator___LeftIndent As Int32 = 28


        Protected _____________InnerItem___Height As Int32 = 50
        Protected _____________InnerItem___MarginBottom As Int32 = 10
        Protected _____________InnerItem___IndicatorIndent As Int32 = 17











































































        Public Overridable ReadOnly Property GeneralFont As Font Implements IFancyMenuTheme.GeneralFont
            Get
                Return _____________GeneralFont
            End Get
        End Property

        Public Overridable ReadOnly Property Indicator___BackColor As Color Implements IFancyMenuTheme.Indicator___BackColor
            Get
                Return _____________Indicator___BackColor
            End Get
        End Property

        Public Overridable ReadOnly Property Indicator___Width As Integer Implements IFancyMenuTheme.Indicator___Width
            Get
                Return _____________Indicator___Width
            End Get
        End Property

        Public Overridable ReadOnly Property Indicator___LeftIndent As Integer Implements IFancyMenuTheme.Indicator___LeftIndent
            Get
                Return _____________Indicator___LeftIndent
            End Get
        End Property

        Public Overridable ReadOnly Property Indicator___SelectedColor As Color Implements IFancyMenuTheme.Indicator___SelectedColor
            Get
                Return _____________Indicator___SelectedColor
            End Get
        End Property

        Public Overridable ReadOnly Property InnerItem___BackColor As Color Implements IFancyMenuTheme.InnerItem___BackColor
            Get
                Return _____________InnerItem___BackColor
            End Get
        End Property

        Public Overridable ReadOnly Property InnerItem___ForeColor As Color Implements IFancyMenuTheme.InnerItem___ForeColor
            Get
                Return _____________InnerItem___ForeColor
            End Get
        End Property

        Public Overridable ReadOnly Property InnerItem___Height As Integer Implements IFancyMenuTheme.InnerItem___Height
            Get
                Return _____________InnerItem___Height
            End Get
        End Property

        Public Overridable ReadOnly Property InnerItem___HighlightedFont As Font Implements IFancyMenuTheme.InnerItem___HighlightedFont
            Get
                Return _____________InnerItem___HighlightedFont
            End Get
        End Property

        Public Overridable ReadOnly Property InnerItem___HighlightForeColor As Color Implements IFancyMenuTheme.InnerItem___HighlightForeColor
            Get
                Return _____________InnerItem___HighlightForeColor
            End Get
        End Property

        Public Overridable ReadOnly Property InnerItem___IndicatorIndent As Integer Implements IFancyMenuTheme.InnerItem___IndicatorIndent
            Get
                Return _____________InnerItem___IndicatorIndent
            End Get
        End Property

        Public Overridable ReadOnly Property InnerItem___MarginBottom As Integer Implements IFancyMenuTheme.InnerItem___MarginBottom
            Get
                Return _____________InnerItem___MarginBottom
            End Get
        End Property

        Public Overridable ReadOnly Property InnerItem___Font As Font Implements IFancyMenuTheme.InnerItem___Font
            Get
                Return _____________InnerItem___Font
            End Get
        End Property

        Public Overridable ReadOnly Property InnerItem___SelectedFont As Font Implements IFancyMenuTheme.InnerItem___SelectedFont
            Get
                Return _____________InnerItem___SelectedFont
            End Get
        End Property

        Public Overridable ReadOnly Property InnerItem___SelectionForeColor As Color Implements IFancyMenuTheme.InnerItem___SelectionForeColor
            Get
                Return _____________InnerItem___SelectionForeColor
            End Get
        End Property

        Public Overridable ReadOnly Property MenuArea___BackColor As Color Implements IFancyMenuTheme.MenuArea___BackColor
            Get
                Return _____________MenuArea___BackColor
            End Get
        End Property

        Public Overridable ReadOnly Property MenuArea___PadTop As Integer Implements IFancyMenuTheme.MenuArea___PadTop
            Get
                Return _____________MenuArea___PadTop
            End Get
        End Property

        Public Overridable ReadOnly Property TopItem___BackColor As Color Implements IFancyMenuTheme.TopItem___BackColor
            Get
                Return _____________TopItem___BackColor
            End Get
        End Property

        Public Overridable ReadOnly Property TopItem___Font As Font Implements IFancyMenuTheme.TopItem___Font
            Get
                Return _____________TopItem___Font
            End Get
        End Property

        Public Overridable ReadOnly Property TopItem___ForeColor As Color Implements IFancyMenuTheme.TopItem___ForeColor
            Get
                Return _____________TopItem___ForeColor
            End Get
        End Property

        Public Overridable ReadOnly Property TopItem___Height As Integer Implements IFancyMenuTheme.TopItem___Height
            Get
                Return _____________TopItem___Height
            End Get
        End Property

        Public Overridable ReadOnly Property TopItem___HighlightBackColor As Color Implements IFancyMenuTheme.TopItem___HighlightBackColor
            Get
                Return _____________TopItem___HighlightBackColor
            End Get
        End Property

        Public Overridable ReadOnly Property TopItem___HighlightedFont As Font Implements IFancyMenuTheme.TopItem___HighlightedFont
            Get
                Return _____________TopItem___HighlightedFont
            End Get
        End Property

        Public Overridable ReadOnly Property TopItem___HighlightForeColor As Color Implements IFancyMenuTheme.TopItem___HighlightForeColor
            Get
                Return _____________TopItem___HighlightForeColor
            End Get
        End Property

        Public Overridable ReadOnly Property TopItem___Icon As Image Implements IFancyMenuTheme.TopItem___Icon
            Get
                Return _____________TopItem___Icon
            End Get
        End Property

        Public Overridable ReadOnly Property TopItem___ImageIndent As Integer Implements IFancyMenuTheme.TopItem___ImageIndent
            Get
                Return _____________TopItem___ImageIndent
            End Get
        End Property

        Public Overridable ReadOnly Property TopItem___SelectedFont As Font Implements IFancyMenuTheme.TopItem___SelectedFont
            Get
                Return _____________TopItem___SelectedFont
            End Get
        End Property

        Public Overridable ReadOnly Property TopItem___SelectionBackColor As Color Implements IFancyMenuTheme.TopItem___SelectionBackColor
            Get
                Return _____________TopItem___SelectionBackColor
            End Get
        End Property

        Public Overridable ReadOnly Property TopItem___SelectionForeColor As Color Implements IFancyMenuTheme.TopItem___SelectionForeColor
            Get
                Return _____________TopItem___SelectionForeColor
            End Get
        End Property

        Public Overridable ReadOnly Property TopItem___TextIndent As Integer Implements IFancyMenuTheme.TopItem___TextIndent
            Get
                Return _____________TopItem___TextIndent
            End Get
        End Property



    End Class




End Namespace













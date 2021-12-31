Imports System.Drawing


Namespace Themes


    Public Interface IFancyMenuTheme__v1



        '   Fonts

        ReadOnly Property GeneralFont As Font

        ReadOnly Property TopItem___Font As Font
        ReadOnly Property TopItem___HighlightedFont As Font
        ReadOnly Property TopItem___SelectedFont As Font
        ReadOnly Property InnerItem___Font As Font
        ReadOnly Property InnerItem___SelectedFont As Font
        ReadOnly Property InnerItem___HighlightedFont As Font














        '   Images

        ReadOnly Property TopItem___Icon As Image











        '   Colors
        ReadOnly Property General___TextForeColor As Color


        '   Menu Panel Area Color
        ReadOnly Property MenuArea___BackColor As Color



        ReadOnly Property TopItem___BackColor As Color
        ReadOnly Property TopItem___ForeColor As Color
        ReadOnly Property TopItem___HighlightForeColor As Color
        ReadOnly Property TopItem___HighlightBackColor As Color
        ReadOnly Property TopItem___SelectionBackColor As Color
        ReadOnly Property TopItem___SelectionForeColor As Color


        ReadOnly Property InnerItem___BackColor As Color
        ReadOnly Property InnerItem___ForeColor As Color
        ReadOnly Property InnerItem___HighlightForeColor As Color
        ReadOnly Property InnerItem___SelectionForeColor As Color





        ReadOnly Property Indicator___SelectedColor As Color
        ReadOnly Property Indicator___BackColor As Color











        '   Layout Settings
        ReadOnly Property MenuArea___PadTop As Int32



        ReadOnly Property TopItem___Height As Int32
        ReadOnly Property TopItem___ImageIndent As Int32
        ReadOnly Property TopItem___TextIndent As Int32


        ReadOnly Property Indicator___Width As Int32
        ReadOnly Property Indicator___LeftIndent As Int32


        ReadOnly Property InnerItem___Height As Int32
        ReadOnly Property InnerItem___MarginBottom As Int32
        ReadOnly Property InnerItem___IndicatorIndent As Int32










    End Interface



End Namespace
Imports System.Runtime.Serialization
Imports System.Drawing


Namespace Themes

    ''' <summary>
    ''' Non-Serializable, Non Loadable, Editable Fancy Menu Theme
    ''' </summary>
    ''' <remarks></remarks>
    Public Class EditableFancyMenuTheme
        Inherits DefaultFancyMenuTheme__v1




#Region "Constructors"


        Public Sub New(pTheme As DefaultFancyMenuTheme__v1)

            MyBase.New(pTheme)


        End Sub



#End Region












        Public Overloads WriteOnly Property GeneralFont As Font
            Set(value As Font)
                Me._____________GeneralFont = value
            End Set
        End Property

        Public Overloads WriteOnly Property Indicator___BackColor As Color
            Set(value As Color)
                Me._____________Indicator___BackColor = value
            End Set
        End Property

        Public Overloads WriteOnly Property Indicator___Width As Integer
            Set(value As Integer)
                Me._____________Indicator___Width = value
            End Set
        End Property

        Public Overloads WriteOnly Property Indicator___LeftIndent As Integer
            Set(value As Integer)
                Me._____________Indicator___LeftIndent = value
            End Set
        End Property

        Public Overloads WriteOnly Property Indicator___SelectedColor As Color
            Set(value As Color)
                Me._____________Indicator___SelectedColor = value
            End Set
        End Property

        Public Overloads WriteOnly Property InnerItem___BackColor As Color
            Set(value As Color)
                Me._____________InnerItem___BackColor = value
            End Set
        End Property

        Public Overloads WriteOnly Property InnerItem___ForeColor As Color
            Set(value As Color)
                Me._____________InnerItem___ForeColor = value
            End Set
        End Property

        Public Overloads WriteOnly Property InnerItem___Height As Integer
            Set(value As Integer)
                Me._____________InnerItem___Height = value
            End Set
        End Property

        Public Overloads WriteOnly Property InnerItem___HighlightedFont As Font
            Set(value As Font)
                Me._____________InnerItem___HighlightedFont = value
            End Set
        End Property

        Public Overloads WriteOnly Property InnerItem___HighlightForeColor As Color
            Set(value As Color)
                Me._____________InnerItem___HighlightForeColor = value
            End Set
        End Property

        Public Overloads WriteOnly Property InnerItem___IndicatorIndent As Integer
            Set(value As Integer)
                Me._____________InnerItem___IndicatorIndent = value
            End Set
        End Property

        Public Overloads WriteOnly Property InnerItem___MarginBottom As Integer
            Set(value As Integer)
                Me._____________InnerItem___MarginBottom = value
            End Set
        End Property

        Public Overloads WriteOnly Property InnerItem___Font As Font
            Set(value As Font)
                Me._____________InnerItem___Font = value
            End Set
        End Property

        Public Overloads WriteOnly Property InnerItem___SelectedFont As Font
            Set(value As Font)
                Me._____________InnerItem___SelectedFont = value
            End Set
        End Property

        Public Overloads WriteOnly Property InnerItem___SelectionForeColor As Color
            Set(value As Color)
                Me._____________InnerItem___SelectionForeColor = value
            End Set
        End Property

        Public Overloads WriteOnly Property MenuArea___BackColor As Color
            Set(value As Color)
                Me._____________MenuArea___BackColor = value
            End Set
        End Property

        Public Overloads WriteOnly Property MenuArea___PadTop As Integer
            Set(value As Integer)
                Me._____________MenuArea___PadTop = value
            End Set
        End Property

        Public Overloads WriteOnly Property TopItem___BackColor As Color
            Set(value As Color)
                Me._____________TopItem___BackColor = value
            End Set
        End Property

        Public Overloads WriteOnly Property TopItem___Font As Font
            Set(value As Font)
                Me._____________TopItem___Font = value
            End Set
        End Property

        Public Overloads WriteOnly Property TopItem___ForeColor As Color
            Set(value As Color)
                Me._____________TopItem___ForeColor = value
            End Set
        End Property

        Public Overloads WriteOnly Property TopItem___Height As Integer
            Set(value As Integer)
                Me._____________TopItem___Height = value
            End Set
        End Property

        Public Overloads WriteOnly Property TopItem___HighlightBackColor As Color
            Set(value As Color)
                Me._____________TopItem___HighlightBackColor = value
            End Set
        End Property

        Public Overloads WriteOnly Property TopItem___HighlightedFont As Font
            Set(value As Font)
                Me._____________TopItem___HighlightedFont = value
            End Set
        End Property

        Public Overloads WriteOnly Property TopItem___HighlightForeColor As Color
            Set(value As Color)
                Me._____________TopItem___HighlightForeColor = value
            End Set
        End Property

        Public Overloads WriteOnly Property TopItem___Icon As Image
            Set(value As Image)
                Me._____________TopItem___Icon = value
            End Set
        End Property

        Public Overloads WriteOnly Property TopItem___ImageIndent As Integer
            Set(value As Integer)
                Me._____________TopItem___ImageIndent = value
            End Set
        End Property

        Public Overloads WriteOnly Property TopItem___SelectedFont As Font
            Set(value As Font)
                Me._____________TopItem___SelectedFont = value
            End Set
        End Property

        Public Overloads WriteOnly Property TopItem___SelectionBackColor As Color
            Set(value As Color)
                Me._____________TopItem___SelectionBackColor = value
            End Set
        End Property

        Public Overloads WriteOnly Property TopItem___SelectionForeColor As Color
            Set(value As Color)
                Me._____________TopItem___SelectionForeColor = value
            End Set
        End Property

        Public Overloads WriteOnly Property TopItem___TextIndent As Integer
            Set(value As Integer)
                Me._____________TopItem___TextIndent = value
            End Set
        End Property


        Public Overloads WriteOnly Property General___TextForeColor As Color
            Set(value As Color)
                Me._____________General___TextForeColor = value
            End Set
        End Property




























        Public Function getLoadableBase() As DefaultFancyMenuTheme__v1
            Return New DefaultFancyMenuTheme__v1(Me)
        End Function










    End Class





End Namespace
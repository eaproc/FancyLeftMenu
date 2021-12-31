Imports System.Drawing



Friend Class InnerMenuItemContainer



#Region "Properties"


    Private ____MenuItems As Dictionary(Of String, InnerMenu)

    Private ____ParentHolder As TopMenuItem


    Public ReadOnly Property hasMenus As Boolean
        Get
            Return Me.____MenuItems.Count > 0
        End Get
    End Property


    Private ____posIndicator As VerticalBarItemPoint

    'Private ____MarginBottom As Int32


    'Private ____IndicatorWidth As Int32
    'Private ____IndicatorIndent As Int32
    'Private ____MenuIndent As Int32
    'Private ____MenuHeight As Int32



    'Private ____ItemFont As Font
    'Private ____ItemBackColor As Color
    'Private ____ItemForeColor As Color
    'Private ____ItemHighlightColor As Color
    'Private ____ItemSelectedColor As Color






    Private _____ExpandedItem As InnerMenu

    Public ReadOnly Property ExpandedItem As InnerMenu
        Get
            Return Me._____ExpandedItem
        End Get
    End Property


    Public ReadOnly Property IsMenuExpanded As Boolean
        Get
            Return Me.ExpandedItem IsNot Nothing
        End Get
    End Property



    Default Public ReadOnly Property Menu(pMenuName As String) As InnerMenu
        Get
            If pMenuName Is Nothing OrElse pMenuName.Trim() = String.Empty Then Return Nothing
            If Not Me.____MenuItems.ContainsKey(pMenuName) Then Throw New Exception(String.Format(
                    "{0} menu name was not found in collection.", pMenuName)
                )
            Return Me.____MenuItems(pMenuName)
        End Get
    End Property


#End Region





#Region "Constructors"


    Private Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub




    Public Sub New(pParentHolder As TopMenuItem)
        Me.New()

        Me.____MenuItems = New Dictionary(Of String, InnerMenu)()
        Me.____ParentHolder = pParentHolder
        'Me.____posIndicator = New VerticalBarItemPoint(Color.DarkGray)

        'Me.____posIndicator.BackColor = Color.WhiteSmoke

        Me.____posIndicator = New VerticalBarItemPoint(pParentHolder.themeForDisplay.Indicator___SelectedColor)

        Me.____posIndicator.BackColor = pParentHolder.themeForDisplay.Indicator___BackColor

        Me.Controls.Add(Me.____posIndicator)

        'Me.____MarginBottom = 10

        'Me.____IndicatorIndent = 28
        'Me.____IndicatorWidth = 4
        'Me.____MenuIndent = 17
        'Me.____MenuHeight = 50



        With Me.____ParentHolder

            Me.____posIndicator.Top = 0
            Me.____posIndicator.Height = Me.Height
            Me.____posIndicator.Left = .themeForDisplay.Indicator___LeftIndent
            Me.____posIndicator.Width = .themeForDisplay.Indicator___Width


            Me.____posIndicator.hideIndicator()


            'Me.____ItemFont = pFont
            'Me.____ItemForeColor = pForeColor
            'Me.____ItemHighlightColor = pHighlightForeColor
            'Me.____ItemSelectedColor = pSelectedForeColor
            'Me.____ItemBackColor = pBackColor


            Me.BackColor = .themeForDisplay.InnerItem___BackColor

        End With

    End Sub



    ''Public Sub New(pParentHolder As TopMenuItem,
    ''               pFont As Font,
    ''               pBackColor As Color,
    ''               pForeColor As Color,
    ''               pHighlightForeColor As Color,
    ''               pSelectedForeColor As Color
    ''               )
    ''    Me.New()

    ''    Me.____MenuItems = New Dictionary(Of String, InnerMenu)()
    ''    Me.____ParentHolder = pParentHolder
    ''    Me.____posIndicator = New VerticalBarItemPoint(Color.DarkGray)

    ''    Me.____posIndicator.BackColor = Color.WhiteSmoke


    ''    Me.Controls.Add(Me.____posIndicator)

    ''    Me.____MarginBottom = 10

    ''    Me.____IndicatorIndent = 28
    ''    Me.____IndicatorWidth = 4
    ''    Me.____MenuIndent = 17
    ''    Me.____MenuHeight = 50




    ''    Me.____posIndicator.Top = 0
    ''    Me.____posIndicator.Height = Me.Height
    ''    Me.____posIndicator.Left = Me.____IndicatorIndent
    ''    Me.____posIndicator.Width = Me.____IndicatorWidth


    ''    Me.____posIndicator.hideIndicator()


    ''    Me.____ItemFont = pFont
    ''    Me.____ItemForeColor = pForeColor
    ''    Me.____ItemHighlightColor = pHighlightForeColor
    ''    Me.____ItemSelectedColor = pSelectedForeColor
    ''    Me.____ItemBackColor = pBackColor


    ''    Me.BackColor = pBackColor

    ''End Sub

#End Region





#Region "Methods"

    Private Function getNextTopPosition() As Int32
        If Not Me.hasMenus() Then Return 0
        Return Me.____MenuItems.Count * Me.____ParentHolder.themeForDisplay.TopItem___Height
    End Function

    Public Function addMenu(pMenuName As String, pMenuText As String) As InnerMenu
        Dim p As New InnerMenu(pMenuName,
                               pMenuText,
                              Me.____ParentHolder.themeForDisplay
                              )



        With ____ParentHolder.themeForDisplay

            p.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            p.Top = Me.getNextTopPosition()
            p.Left = Me.____posIndicator.Left + Me.____posIndicator.Width + .InnerItem___IndicatorIndent
            p.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            p.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            p.Size = New Size(Me.Width - p.Left,
                            .InnerItem___Height
                            )
            'p.Top = CInt(((Me.____MenuHeight - p.Height) / 2) + Me.getNextTopPosition())




            Me.Controls.Add(p)
            Me.____MenuItems.Add(pMenuName, p)


            Me.____posIndicator.Height = Me.____MenuItems.Count * .InnerItem___Height
            Me.Height = Me.____posIndicator.Height + .InnerItem___MarginBottom

        End With


        AddHandler p.SelectionChanged, AddressOf p_SelectionChanged

        Return p
    End Function



    Private Sub p_SelectionChanged(pInnerMenu As InnerMenu)
        If Me.IsMenuExpanded Then
            Dim informAvoidRecursive = Me.ExpandedItem
            Me._____ExpandedItem = Nothing
            Me.____posIndicator.hideIndicator()
            informAvoidRecursive.IsSelected = False
        End If

        If pInnerMenu.IsSelected Then
            Me._____ExpandedItem = pInnerMenu

            With Me.____ParentHolder.themeForDisplay

                Me.____posIndicator.SetIndicator(
                    Me.____MenuItems.Keys.ToList().IndexOf(pInnerMenu.Name) * .InnerItem___Height,
                                                  .InnerItem___Height)

            End With

        End If



    End Sub


#End Region








End Class



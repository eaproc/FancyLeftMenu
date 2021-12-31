Imports System.Drawing
Imports System.Windows.Forms





    '   Unchecking of item is Disabled Automatically
'
'   
'
'   Allows Real Top Menu to have Virtual Sub Menus
'   Allows Virtual Top Menus and Virtual Sub Menus
'


    ''' <summary>
    ''' Non Resizable Left Menu Manager
    ''' </summary>
    ''' <remarks></remarks>
    Public Class FancyLeftMenuManager



#Region "Properties"

        Private _____pnlDisplay As Control

        Private _____themeForDisplay As Themes.IFancyMenuTheme__v1
        Public ReadOnly Property themeForDisplay As Themes.IFancyMenuTheme__v1
            Get
                Return Me._____themeForDisplay
            End Get
        End Property



        ' ''   Container Settings
        ''Private _____MarginTop As Int32


        ' ''   Each Menu Top Settings
        ' ''   Width 100%
        ''Private _____MenuTop__Height As Int32
        ''Private _____MenuTop__ImageIndent As Int32
        ''Private _____MenuTop__TextIndent As Int32
        ''Private _____MenuTop__Font As Font
        ''Private _____MenuTop__ForeColor As Color
        ''Private _____MenuTop__HighlightForeColor As Color
        ''Private _____MenuTop__BackColor As Color
        ''Private _____MenuTop__HighlightBackColor As Color
        ''Private _____MenuTop__SelectionBackColor As Color
        ''Private _____MenuTop__SelectionForeColor As Color




    Private _____MenuTops As Dictionary(Of String, TopMenuItem)

    Private _____VirtualTopMenus As Dictionary(Of String, VirtualTopMenu)



    Private _____ExpandedItem As TopMenuItem
    Private _____HiglightedItem As TopMenuItem


    Public ReadOnly Property ExpandedItem As TopMenuItem
        Get
            Return Me._____ExpandedItem
        End Get
    End Property


    Public ReadOnly Property IsMenuExpanded As Boolean
        Get
            Return Me.ExpandedItem IsNot Nothing
        End Get
    End Property


    ''' <summary>
    ''' Throws exception if not found
    ''' </summary>
    ''' <param name="pMenuName"></param>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Default Public ReadOnly Property Menu(pMenuName As String) As TopMenuItem
        Get
            If Not Me._____MenuTops.ContainsKey(pMenuName) Then Throw New Exception(String.Format(
                    "{0} menu name was not found in collection.", pMenuName)
                )
            Return Me._____MenuTops(pMenuName)
        End Get
    End Property


    Public ReadOnly Property VirtualMenu(pMenuName As String) As VirtualTopMenu
        Get
            If Not Me._____VirtualTopMenus.ContainsKey(pMenuName) Then Throw New Exception(String.Format(
                    "{0} menu name was not found in collection.", pMenuName)
                )
            Return Me._____VirtualTopMenus(pMenuName)
        End Get
    End Property


    Public ReadOnly Property Menus As IEnumerable(Of TopMenuItem)
        Get
            Return Me._____MenuTops.Values
        End Get
    End Property


    Public ReadOnly Property VirtualTopMenus As IEnumerable(Of VirtualTopMenu)
        Get
            Return Me._____VirtualTopMenus.Values.ToList()
        End Get
    End Property




#End Region






#Region "Constructors"

    Public Sub New(pPnlDisplay As Control)
        Me.New(pPnlDisplay, New Themes.DefaultFancyMenuTheme__v1())
    End Sub


    ''' <summary>
    ''' Initialize
    ''' </summary>
    ''' <param name="pPnlDisplay">The Panel that will be used to display all items</param>
    ''' <remarks></remarks>
    Public Sub New(pPnlDisplay As Control,
                   pTheme As Themes.IFancyMenuTheme__v1)

        If pTheme Is Nothing Then pTheme = New Themes.DefaultFancyMenuTheme__v1()

        Me._____pnlDisplay = pPnlDisplay
        Me._____pnlDisplay.BackColor = pTheme.MenuArea___BackColor

        Me._____MenuTops = New Dictionary(Of String, TopMenuItem)()
        Me._____VirtualTopMenus = New Dictionary(Of String, VirtualTopMenu)()


        Me._____themeForDisplay = pTheme


        'Me._____MarginTop = 30

        ''   #79869a => 121,134,154


        ''   Each Menu Top Settings
        ''   Width 100%
        '_____MenuTop__Height = 52
        '_____MenuTop__ImageIndent = 20
        '_____MenuTop__TextIndent = 15
        '_____MenuTop__Font = pItemFont

        '_____MenuTop__BackColor = Me._____pnlDisplay.BackColor
        '_____MenuTop__ForeColor = Color.DimGray

        '_____MenuTop__HighlightForeColor = Color.White
        '_____MenuTop__HighlightBackColor = Color.Gray

        '_____MenuTop__SelectionBackColor = Color.DarkGray
        '_____MenuTop__SelectionForeColor = Color.White






    End Sub






#End Region






#Region "Enums and Consts"




#End Region



#Region "Events"

    Public Event VirtualTopMenuSelected(pVirtualTopMenu As VirtualTopMenu)
    Public Event VirtualSubMenuSelected(pSubMenu As String)

#End Region



#Region "Methods"

    Private Sub pMenu_SelectionChanged(pTopMenu As TopMenuItem)
        If pTopMenu.IsExpanded Then Me._____ExpandedItem = pTopMenu

    End Sub

    Private Sub pMenu_SelectionChanging(pTopMenu As TopMenuItem, pIsExpanding As Boolean)
        '   On Changing, if it is expanding and there is other item expanded collapse it first
        '
        If pIsExpanding AndAlso Me.IsMenuExpanded Then
            Me.ExpandedItem.SetCollapse()
            Me._____ExpandedItem = Nothing

        ElseIf Not pIsExpanding AndAlso Me.IsMenuExpanded AndAlso
            Me.ExpandedItem.Name.ToLower() = (pTopMenu.Name).ToLower() Then
            'The same menu that was expanded is now collapsing
            Me._____ExpandedItem = Nothing

        End If

    End Sub


    ''' <summary>
    ''' Uses default Icon
    ''' </summary>
    ''' <param name="pMenuName"></param>
    ''' <param name="pMenuText"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function AddMenu(pMenuName As String,
                    pMenuText As String
                    ) As TopMenuItem
        Return Me.AddMenu(pMenuName, pMenuText, Me.themeForDisplay.TopItem___Icon)
    End Function

    Public Function AddMenu(pMenuName As String,
                       pMenuText As String,
                       pMenuImage As Image) As TopMenuItem



        '   You can not add new Menu when a menu is expanded
        If Me.IsMenuExpanded Then Return Nothing


        'Dim pMenu As New TopMenuItem(pMenuName,
        '                                           Me._____MenuTop__Font,
        '                                           Me._____pnlDisplay.Width,
        '                                            Me._____MenuTop__Height,
        '                                              Me._____MenuTop__ForeColor,
        '                                              Me._____MenuTop__HighlightForeColor,
        '                                              Color.Black
        '                                           )
        Dim pMenu As New TopMenuItem(pMenuName, pMenuText, pMenuImage, Me.themeForDisplay)
        With pMenu
            .Size = New Size(Me._____pnlDisplay.Width, Me.themeForDisplay.TopItem___Height)
            .Location = Me.getNextLocation()
            '.SetText(pMenuText)
            '.SetImage(pMenuImage)
            '.SetImageIndent(Me._____MenuTop__ImageIndent)
            '.SetTextIndent(Me._____MenuTop__TextIndent)
            '.SetColor(Me._____MenuTop__ForeColor)
            '.SetBackColor(Me._____MenuTop__BackColor)
            '.SetHighlightForeColor(Me._____MenuTop__HighlightForeColor)
            '.SetHighlightBackColor(Me._____MenuTop__HighlightBackColor)
            '.SetSelectionColor(Me._____MenuTop__SelectionBackColor,
            '                   Me._____MenuTop__SelectionForeColor)


        End With


        AddHandler pMenu.SelectionChanging, AddressOf Me.pMenu_SelectionChanging
        AddHandler pMenu.SelectionChanged, AddressOf Me.pMenu_SelectionChanged
        AddHandler pMenu.ShiftMenusUpPlease, AddressOf pMenu_ShiftMenusUpPlease
        AddHandler pMenu.ShiftMenusBelowPlease, AddressOf pMenu_ShiftMenusBelowPlease
        AddHandler pMenu.MenuHighlighted, AddressOf pMenu_MenuHighlighted




        Me._____MenuTops.Add(pMenuName, pMenu)
        Me._____pnlDisplay.Controls.Add(pMenu)

        Return pMenu
    End Function


    Private Function getNextLocation() As Point
        If Me._____MenuTops.Count = 0 Then Return New Point(0, Me.themeForDisplay.MenuArea___PadTop)
        Return New Point(0, Me._____MenuTops.Last().Value.Location.Y + Me.themeForDisplay.TopItem___Height)
    End Function



    Private Sub pMenu_ShiftMenusUpPlease(pTopMenu As TopMenuItem)
        For iIndex As Int32 = Me._____MenuTops.Keys.ToList().IndexOf(pTopMenu.Name) + 1 To Me._____MenuTops.Keys.Count - 1
            Dim beFore As TopMenuItem = Me._____MenuTops.ElementAt(iIndex - 1).Value
            Dim this As TopMenuItem = Me._____MenuTops.ElementAt(iIndex).Value

            this.Location = New Point(0, beFore.Location.Y + beFore.Height)

        Next
    End Sub


    Private Sub pMenu_ShiftMenusBelowPlease(pTopMenu As TopMenuItem)
        For iIndex As Int32 = Me._____MenuTops.Keys.ToList().IndexOf(pTopMenu.Name) + 1 To Me._____MenuTops.Keys.Count - 1
            Dim beFore As TopMenuItem = Me._____MenuTops.ElementAt(iIndex - 1).Value
            Dim this As TopMenuItem = Me._____MenuTops.ElementAt(iIndex).Value

            this.Location = New Point(0, beFore.Location.Y + beFore.Height)

        Next
    End Sub



    Public Sub SelectMenuPath(pTopMenu As String,
                              Optional ByVal pSubMenu As String = Nothing)

        Dim pMnu As TopMenuItem = Nothing
        Try
            pMnu = Menu(pTopMenu)
        Catch
            ' Ignore if not found
        End Try

        If pMnu IsNot Nothing Then
            pMnu.SelectMenu()
            If pSubMenu IsNot Nothing AndAlso pMnu.hasMenu(pSubMenu) Then
                pMnu.getMenu(pSubMenu).selectMenu()

            ElseIf pSubMenu IsNot Nothing AndAlso pMnu.hasVirtualSubMenu(pSubMenu) Then
                RaiseEvent VirtualSubMenuSelected(pSubMenu)
            End If


        ElseIf Me.hasVirtualMenu(pTopMenu) Then
            Dim p = Me.VirtualMenu(pMenuName:=pTopMenu)
            RaiseEvent VirtualTopMenuSelected(p)

            If pSubMenu IsNot Nothing AndAlso p.hasVirtualSubMenu(pSubMenu) Then
                RaiseEvent VirtualSubMenuSelected(pSubMenu)
            End If

        End If


    End Sub


    Private Sub pMenu_MenuHighlighted(pTopMenu As TopMenuItem)
        If Not Me._____HiglightedItem Is Nothing AndAlso Me._____HiglightedItem.Name <> pTopMenu.Name AndAlso
            Not Me._____HiglightedItem.IsExpanded Then
            Me._____HiglightedItem.StopHighlighting()
        End If
        _____HiglightedItem = pTopMenu
    End Sub




#Region "Virtual Menus"

    Public Function hasVirtualMenu(pMenuName As String) As Boolean
        Return  Me._____VirtualTopMenus.ContainsKey(pMenuName) 
    End Function

    Public Function addVirtualMenu(pMenuName As String) As VirtualTopMenu
        If Me.hasVirtualMenu(pMenuName) Then Return Nothing
        Dim p As New VirtualTopMenu(pMenuName)
        Me._____VirtualTopMenus.Add(pMenuName, p)
        Return p
    End Function


    Public Sub removeVirtualMenu(pMenuName As String)
        If Me.hasVirtualMenu(pMenuName) Then Me._____VirtualTopMenus.Remove(pMenuName)
    End Sub


#End Region



#End Region

   








    End Class




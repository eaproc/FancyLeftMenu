Imports System.Drawing



    Public Class TopMenuItem

#Region "Properties"

        'Private ____TargetHeight As Int32

        'Private ____HighlightBackColor As Color
        'Private ____HighlightForeColor As Color

        'Private ____SelectionBackColor As Color
        'Private ____SelectionForeColor As Color

        'Private ____BackColor As Color
        'Private ____ForeColor As Color



        'Private ____TextIndent As Int32
        'Private ____ImageIndent As Int32




        Private _____themeForDisplay As Themes.IFancyMenuTheme__v1
        Public ReadOnly Property themeForDisplay As Themes.IFancyMenuTheme__v1
            Get
                Return Me._____themeForDisplay
            End Get
        End Property



        Private ____IsSelected As Boolean
        Private Property IsSelected As Boolean
            Get
                Return Me.____IsSelected
            End Get
            Set(value As Boolean)
                Me.____IsSelected = value
                RaiseEvent SelectionChanged(Me)
            End Set
        End Property


        Public ReadOnly Property IsExpanded As Boolean
            Get
                Return Me.IsSelected
            End Get
        End Property




    Private ____InnerMenuItemHolder As InnerMenuItemContainer

        Public ReadOnly Property MenuText As String
            Get
                Return Me.lblMenuText.Text
            End Get
        End Property




        Private Property _____IsInitialized As Boolean
        Private Property _____IsExpanding As Boolean
        Private Property _____IsCollapsing As Boolean


    Private ______CustomCircularNotificationStyle As ICircularNotificationStyle
    Public ReadOnly Property CustomCircularNotificationStyle As ICircularNotificationStyle
        Get
            Return Me.______CustomCircularNotificationStyle
        End Get
    End Property





#Region "Virtual Submenus"





    Private ________SubMenus As List(Of String)

    Public ReadOnly Property SubMenus As IEnumerable(Of String)
        Get
            Return Me.________SubMenus
        End Get
    End Property






#End Region



#End Region


#Region "Events"

        Public Event SelectionChanged(pTopMenu As TopMenuItem)
        Public Event SelectionChanging(pTopMenu As TopMenuItem, pIsExpanding As Boolean)
        '   On Changing, if it is expanding and there is other item expanded collapse it first
        '
        Public Event ShiftMenusBelowPlease(pTopMenu As TopMenuItem)
        Public Event ShiftMenusUpPlease(pTopMenu As TopMenuItem)

    Public Event MenuHighlighted(pTopMenu As TopMenuItem)


#End Region



#Region "Constructors"


        Private Sub New()

            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            Me.CircularNotification.Visible = False
        Me.______CustomCircularNotificationStyle = Nothing

        End Sub




        Public Sub New(pName As String,
                        pMenuText As String,
                           pMenuImage As Image,
                     pTheme As Themes.IFancyMenuTheme__v1
                     )
            Me.New()

            'Me.____TargetHeight = PHeight
            'Me.Size = New Size(PWidth, PHeight)
            Me.Name = pName
            Me.lblMenuText.Font = pTheme.TopItem___Font

            Me._____themeForDisplay = pTheme



            With pTheme
                Me.SetForeColor(.TopItem___ForeColor)
                Me.SetBackColor(.TopItem___BackColor)
                Me.SetText(pMenuText)
                Me.SetImage(pMenuImage)
                Me.SetImageIndent(.TopItem___ImageIndent)
            End With




            Me.____InnerMenuItemHolder = New InnerMenuItemContainer(Me)

            Me.Controls.Add(Me.____InnerMenuItemHolder)



            Me._____IsInitialized = True
        End Sub

        'Public Sub New(pName As String,
        '               pFont As Font,
        '               PWidth As Int32,
        '               PHeight As Int32,
        '               pInnerItemForeColor As Color,
        '               pInnerItemHighlightForeColor As Color,
        '               pInnerItemSelectForeColor As Color)
        '    Me.New()

        '    Me.____TargetHeight = PHeight
        '    Me.Size = New Size(PWidth, PHeight)
        '    Me.Name = pName
        '    Me.lblMenuText.Font = pFont

        '    '   Place Items Vertically Centered

        '    Me.lblMenuText.Location = New Point(0,
        '                                     CInt((Me.Height - Me.lblMenuText.Height) / 2)
        '                                     )
        '    Me.picMenuIcon.Location = New Point(0,
        '                                     Me.lblMenuText.Top + Me.lblMenuText.Height - Me.picMenuIcon.Height
        '                                     )



        '    Me.____InnerMenuItemHolder = New InnerMenuItemContainer(Me,
        '                                                            New Font(pFont.FontFamily, pFont.Size - 1),
        '                                                             Color.LightGray,
        '                                                             pInnerItemForeColor,
        '                                                             pInnerItemHighlightForeColor,
        '                                                             pInnerItemSelectForeColor
        '                                                            )

        '    Me.____InnerMenuItemHolder.Location = New Point(0, PHeight)
        '    Me.____InnerMenuItemHolder.Width = PWidth

        '    Me.Controls.Add(Me.____InnerMenuItemHolder)

        'End Sub



#End Region



#Region "Methods"

    Public Sub setCustomCircularNotificationStyle(pVal As ICircularNotificationStyle)
        Me.______CustomCircularNotificationStyle = pVal
        Me.TopMenuItem_Resize(Me, Nothing)
    End Sub

        Public Sub SetNotificationVisibility(pVal As Boolean)
            Me.CircularNotification.Visible = pVal
        End Sub

        Public Sub SetNotificationText(pVal As String)
            Me.CircularNotification.Text = pVal
        End Sub


        Public Function hasMenu(pMnuName As String) As Boolean
            Try

                Return Me.____InnerMenuItemHolder.Menu(pMnuName) IsNot Nothing
            Catch ex As Exception
                Return False
            End Try
        End Function

        Public Function getMenu(pMnuName As String) As InnerMenu
            Return Me.____InnerMenuItemHolder.Menu(pMnuName)
        End Function



        Public Sub SetCollapse()
            Me.BackColor = Me.themeForDisplay.TopItem___BackColor
            Me.lblMenuText.BackColor = Me.themeForDisplay.TopItem___BackColor
            Me.lblMenuText.ForeColor = Me.themeForDisplay.TopItem___ForeColor
            Me.picMenuIcon.BackColor = Me.themeForDisplay.TopItem___BackColor
            lblMenuText.Font = Me.themeForDisplay.TopItem___Font

            Me.IsSelected = False


            If Me.____InnerMenuItemHolder.hasMenus Then
                If Me.____InnerMenuItemHolder.IsMenuExpanded Then
                    Me.____InnerMenuItemHolder.ExpandedItem.IsSelected = False
                End If
                Me._____IsCollapsing = True

                Me.Height = Me.themeForDisplay.TopItem___Height
                RaiseEvent ShiftMenusUpPlease(Me)

                Me._____IsCollapsing = False

            End If

        End Sub




        Private Sub SetExpanded()
            Me.BackColor = Me.themeForDisplay.TopItem___SelectionBackColor
            Me.lblMenuText.BackColor = Me.themeForDisplay.TopItem___SelectionBackColor
            Me.lblMenuText.ForeColor = Me.themeForDisplay.TopItem___SelectionForeColor
            lblMenuText.Font = Me.themeForDisplay.TopItem___SelectedFont
            Me.picMenuIcon.BackColor = Me.themeForDisplay.TopItem___SelectionBackColor


            If Me.____InnerMenuItemHolder.hasMenus Then

                Me._____IsExpanding = True
                Me.Height = Me.themeForDisplay.TopItem___Height + Me.____InnerMenuItemHolder.Height
                RaiseEvent ShiftMenusBelowPlease(Me)
                Me._____IsExpanding = False

            End If


        End Sub

        Private Sub KeepHighlighting()
            Me.BackColor = Me.themeForDisplay.TopItem___HighlightBackColor
            Me.lblMenuText.BackColor = Me.themeForDisplay.TopItem___HighlightBackColor
            Me.lblMenuText.ForeColor = Me.themeForDisplay.TopItem___HighlightForeColor
            Me.picMenuIcon.BackColor = Me.themeForDisplay.TopItem___HighlightBackColor
        Me.lblMenuText.Font = Me.themeForDisplay.TopItem___HighlightedFont
        RaiseEvent MenuHighlighted(Me)
    End Sub

    Friend Sub StopHighlighting()
        Me.BackColor = Me.themeForDisplay.TopItem___BackColor
        Me.lblMenuText.BackColor = Me.themeForDisplay.TopItem___BackColor
        Me.lblMenuText.ForeColor = Me.themeForDisplay.TopItem___ForeColor
        Me.picMenuIcon.BackColor = Me.themeForDisplay.TopItem___BackColor
        Me.lblMenuText.Font = Me.themeForDisplay.TopItem___Font
    End Sub





        Public Sub SetText(pMenuText As String)
            Me.lblMenuText.Text = pMenuText
        End Sub

        Public Sub SetImage(pMenuImage As Image)
            Me.picMenuIcon.Image = pMenuImage
        End Sub

        Private Sub SetImageIndent(MenuTop__ImageIndent As Integer)
            Me.picMenuIcon.Location = New Point(MenuTop__ImageIndent,
                                                Me.picMenuIcon.Top
                                                )
            Me.SetTextIndent(Me.themeForDisplay.TopItem___TextIndent)
        End Sub

        Private Sub SetTextIndent(MenuTop__TextIndent As Integer)
            Me.lblMenuText.Location = New Point(Me.picMenuIcon.Left + Me.picMenuIcon.Width + MenuTop__TextIndent,
                                                Me.lblMenuText.Location.Y)
        End Sub

        Private Sub SetForeColor(MenuTop__ForeColor As Color)
            Me.lblMenuText.ForeColor = MenuTop__ForeColor
        End Sub

        Private Sub SetBackColor(MenuTop__BackColor As Color)
            Me.BackColor = MenuTop__BackColor
            lblMenuText.BackColor = Me.BackColor
            picMenuIcon.BackColor = Me.BackColor
        End Sub










    Public Sub SelectMenu()
        Me.____IsSelected = False           ' To indicate am turning it on
        Me.TopMenuItem_Click(Me, Nothing)
    End Sub







        Public Function addMenu(pMenuName As String, pMenuText As String) As InnerMenu

            Return Me.____InnerMenuItemHolder.addMenu(pMenuName, pMenuText)


        End Function



#Region "Virtual SubMenus"


    Public Sub AddVirtualSubMenu(pName As String)
        If Not Me.________SubMenus.Contains(pName, New IEqualityComparerIgnoreCase()) Then Me.________SubMenus.Add(pName)
    End Sub

    Public Sub RemoveVirtualSubMenu(pName As String)
        If Not Me.________SubMenus.Contains(pName, New IEqualityComparerIgnoreCase()) Then Me.________SubMenus.Remove(pName)
    End Sub


    Public Function hasVirtualSubMenu(pName As String) As Boolean
        Return Me.________SubMenus.Contains(pName, New IEqualityComparerIgnoreCase())
    End Function

    Public Sub ClearVirtualSubMenus()
        Me.________SubMenus.Clear()
    End Sub

#End Region


#End Region






        Private Sub TopMenuItem_Click(sender As Object, e As EventArgs) Handles Me.Click, lblMenuText.Click, picMenuIcon.Click
            '   If this is from user 
            '   and this Item is clicked already, don't allow uncheck
            If e IsNot Nothing AndAlso Me.IsSelected Then
                '   First uncheck it
                Me.IsSelected = False

            End If

            RaiseEvent SelectionChanging(Me, Not Me.IsSelected)

            If Not Me.IsSelected Then
                Me.SetExpanded()
                Me.IsSelected = True
            Else
                Me.SetCollapse()

            End If


        End Sub





        Private Sub TopMenuItem_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter,
            picMenuIcon.MouseEnter, lblMenuText.MouseEnter

            If Not Me.IsSelected Then Me.KeepHighlighting()

        End Sub


        Private Sub lblMenuText_MouseHover(sender As Object, e As EventArgs) Handles lblMenuText.MouseHover,
            picMenuIcon.MouseHover, Me.MouseHover
            'If Not Me.IsSelected Then Me.KeepHighlighting()
    End Sub


    Private Sub TopMenuItem_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave
        '   Make sure the mouse has really left
        Dim p = Me.PointToClient(System.Windows.Forms.Control.MousePosition)
        Dim q = Me.Size
        If p.X < 1 OrElse p.Y < 1 OrElse
            p.X > q.Width OrElse p.Y > q.Height Then
            'Debug.Print("I think  you have really left the control")
            If Not Me.IsSelected Then Me.StopHighlighting()

        End If
    End Sub






        Private Sub TopMenuItem_Resize(sender As Object, e As EventArgs) Handles Me.Resize
            If Me._____IsInitialized AndAlso Not Me._____IsExpanding AndAlso Not Me._____IsCollapsing Then
                '   Place Items Vertically Centered

                Me.lblMenuText.Location = New Point(0,
                                                 CInt((Me.Height - Me.lblMenuText.Height) / 2)
                                                 )
                Me.picMenuIcon.Location = New Point(0,
                                                 Me.lblMenuText.Top + Me.lblMenuText.Height - Me.picMenuIcon.Height
                                                 )


                Me.____InnerMenuItemHolder.Location = New Point(0, Me.Height)
                Me.____InnerMenuItemHolder.Width = Me.Width


                Me.SetImageIndent(Me.themeForDisplay.TopItem___ImageIndent)



            With CircularNotification
                If Me.CustomCircularNotificationStyle Is Nothing Then
                    .BackColor = Color.FromArgb(232, 1, 45)
                    .ForeColor = Color.White
                    .Font = New Font(Me.lblMenuText.Font.FontFamily,
                                     Me.lblMenuText.Font.Size - 4)
                Else
                    .BackColor = Me.CustomCircularNotificationStyle.BackColor
                    .ForeColor = Me.CustomCircularNotificationStyle.ForeColor
                    .Font = Me.CustomCircularNotificationStyle.Font
                End If

                .Size = New Size(30, 30)
                .Location = New Point(Me.Width - .Width - 5,
                                        CInt((Me.Height - .Height) / 2)
                                        )
                With .Appearance.TextOptions
                    .HAlignment = DevExpress.Utils.HorzAlignment.Center
                    .VAlignment = DevExpress.Utils.VertAlignment.Center
                End With
            End With



            End If
    End Sub









    End Class






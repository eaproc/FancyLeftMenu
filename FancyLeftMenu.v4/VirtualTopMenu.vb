
Public Class VirtualTopMenu




#Region "Constructors"

    Public Sub New(pMenuName As String)

        Me.________Name = pMenuName
        Me.________SubMenus = New List(Of String)()

    End Sub

#End Region






#Region "Properties"


    Private ________SubMenus As List(Of String)
    Private ________Name As String
    Public ReadOnly Property Name As String
        Get
            Return Me.________Name
        End Get
    End Property


    Public ReadOnly Property SubMenus As IEnumerable(Of String)
        Get
            Return Me.________SubMenus
        End Get
    End Property




    Default ReadOnly Property SubMenu(pMenuName As String) As String
        Get
            If Me.hasVirtualSubMenu(pMenuName) Then Return pMenuName
            Return String.Empty
        End Get
    End Property






#End Region




#Region "Methods"



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





End Class

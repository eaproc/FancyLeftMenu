




Public Interface IMenuHandler


    Property LastNavigatedPassedParameters As Object()



    Sub SetTopLargeTitle(pTitle As String)

    Sub ForceCloseApplication()


    Sub SelectMenuPath(pTopMenu As String,
                             Optional ByVal pSubMenu As String = Nothing)


    Sub setNavigatedPassedParameters(ParamArray pParams() As Object)

    Sub clearNavigatedPassedParameters()


End Interface




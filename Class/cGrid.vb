''' <summary>
''' mapwindow 래스터 레이어를 이용해서 레이어 영역에 대한 다양한 정보 생성
''' </summary>
''' <remarks></remarks>
Public Class cGrid

    'Private mGrid As MapWinGIS.Grid

    'Sub New(ingrid As MapWinGIS.Grid)
    '    mGrid = ingrid
    'End Sub

    'Public ReadOnly Property bottom As Double
    '    Get
    '        Return (mGrid.Header.YllCenter - mGrid.Header.dY / 2)
    '    End Get
    'End Property

    'Public ReadOnly Property top As Double
    '    Get
    '        Return (mGrid.Header.YllCenter - mGrid.Header.dY / 2 + mGrid.Header.NumberRows * mGrid.Header.dY)
    '    End Get
    'End Property

    'Public ReadOnly Property left As Double
    '    Get
    '        Return (mGrid.Header.XllCenter - mGrid.Header.dX / 2)
    '    End Get
    'End Property

    'Public ReadOnly Property right As Double
    '    Get
    '        Return (mGrid.Header.XllCenter - mGrid.Header.dX / 2 + mGrid.Header.NumberCols * mGrid.Header.dX)
    '    End Get
    'End Property

    'Public ReadOnly Property ExtentWidth As Double
    '    Get
    '        Return right - left
    '    End Get
    'End Property

    'Public ReadOnly Property ExtentHeight As Double
    '    Get
    '        Return top - bottom
    '    End Get
    'End Property

    'Public ReadOnly Property cellSize As Double
    '    Get
    '        Return mGrid.Header.dX
    '    End Get
    'End Property


    'Public Shared Function CheckTwoGridLayerExtent(ByVal GridBase As MapWinGIS.Grid, _
    '                                               ByVal GridTarget As MapWinGIS.Grid) As Boolean
    '    Dim oGridExtBase As New cGrid(GridBase)
    '    Dim oGridExtTarget As New cGrid(GridTarget)
    '    If GridBase.Header.NumberCols <> GridTarget.Header.NumberCols Then Return False
    '    If GridBase.Header.NumberRows <> GridTarget.Header.NumberRows Then Return False
    '    If CSng(oGridExtBase.bottom) <> CSng(oGridExtTarget.bottom) Then Return False
    '    If CSng(oGridExtBase.top) <> CSng(oGridExtTarget.top) Then Return False
    '    If CSng(oGridExtBase.left) <> CSng(oGridExtTarget.left) Then Return False
    '    If CSng(oGridExtBase.right) <> CSng(oGridExtTarget.right) Then Return False
    '    Return True
    'End Function


    'Public Shared Function CreateNewGrid(baseGrid As MapWinGIS.Grid, _
    '                                     fpn As String, dataType As MapWinGIS.GridDataType, _
    '                                     defaultValue As Integer) As MapWinGIS.Grid
    '    Dim dG As New MapWinGIS.Grid ' 빈 데이터셑 생성
    '    'Dim hG As New MapWinGIS.GridHeader ' 빈 해더 생성
    '    dG.CreateNew(fpn, baseGrid.Header, dataType, defaultValue, _
    '                        True, MapWinGIS.GridFileType.GeoTiff)
    '    dG.Save()
    '    Return dG
    'End Function
End Class

Imports System.Text

Public Class fGRMToolsCreateSoilGridLayer
    Private mDtStaticSoilAtt As New Data.DataTable
    Private mSoilAttribute() As SoilPhaseAttribute
    Private mSoilPhaseVAT As SoilVAT
    Private mintSoilAttInVAT As Integer
    Private mSoilTextureVAT As SoilVAT
    Private mSoilDepthVAT As SoilVAT
    Private Const mCONSTDefaultSoilTexture As String = "양토"
    Private Const mCONSTDefaultSoilDepth As String = "보통"


    Private Structure SoilVAT
        Public GridValue As ArrayList
        Public SoilPhaseName As ArrayList
        Public SoilTextureName As ArrayList
        Public SoilDepthName As ArrayList
    End Structure

    Private Structure SoilPhaseAttribute
        Public Order As Integer
        Public SoilPhaseName As String
        Public SoilTextureName As String
        Public SoilDepthName As String
        Public bNormal As Boolean
    End Structure


    Private Sub frmGRMToolsCreateSoilGridLayer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If cMap.mwAppMain Is Nothing OrElse _
            String.IsNullOrEmpty(cMap.mwAppMain.Project.FileName) = True OrElse _
            cMap.mwAppMain.Layers.NumLayers = 0 Then
            MsgBox("Open workspace and map first!!!!       ", MsgBoxStyle.Critical, cGRM.BuildInfo.ProductName)
            Throw New ArgumentException
        End If

        Call InitializeComboBox()
        Call SetSoilDataTable()

        If mDtStaticSoilAtt.Rows.Count < 1 Then
            MsgBox("There is no records in soil phase static database!   ", , cGRM.BuildInfo.ProductName)
            Me.Close()
        End If
    End Sub


    Sub SetSoilDataTable()
        'Dim cmdString As String = "select * from SoilPhase"
        'Dim DBAdapter As New OleDbDataAdapter(cmdString, cGRM.OdbCnnStatic.ConnectionString)
        'DBAdapter.Fill(mDtStaticSoilAtt)
        Dim tmpStaticdb As New GRMStaticDB
        tmpStaticdb.ReadXml(cGRM.PathNameGRMStaticDB)
        mDtStaticSoilAtt = tmpStaticdb.SoilPhase
    End Sub


    Private Sub InitializeComboBox()
        Dim lyrLayer As MapWindow.Interfaces.Layer
        Me.cmbSoilLayer.Items.Clear()
        Me.cmbSoilLayer.Text = ""
        Me.cmbBaseGridLayer.Items.Clear()

        If Me.rbUsingGridLayer.Checked = True Then
            For Each lyrLayer In cMap.mwAppMain.Layers
                Select Case lyrLayer.LayerType
                    Case MapWindow.Interfaces.eLayerType.Grid, MapWindow.Interfaces.eLayerType.Image
                        Me.cmbSoilLayer.Items.Add(lyrLayer.Name)
                        Me.cmbBaseGridLayer.Items.Add(lyrLayer.Name)
                    Case Else
                End Select
            Next
        End If

        If Me.rbUsingPolygonLayer.Checked = True Then
            For Each lyrLayer In cMap.mwAppMain.Layers
                Select Case lyrLayer.LayerType
                    Case MapWindow.Interfaces.eLayerType.PolygonShapefile
                        cmbSoilLayer.Items.Add(lyrLayer.Name)
                    Case Else
                End Select
            Next
        End If
    End Sub


    Private Sub rbPolygonLayer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbUsingPolygonLayer.CheckedChanged
        Call SetUIWithSourceType()
        Call InitializeComboBox()
    End Sub

    Private Sub rbUsingGridLayer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbUsingGridLayer.CheckedChanged
        Call SetUIWithSourceType()
        Call InitializeComboBox()
    End Sub

    Sub SetUIWithSourceType()
        Me.btLoadSoilPhaseVAT.Enabled = rbUsingGridLayer.Checked
        Me.txtSoilPhaseVATPathName.Enabled = rbUsingGridLayer.Checked
        Me.cmbSoilPhaseField.Enabled = rbUsingPolygonLayer.Checked
    End Sub


    Private Sub cmbSoilLayer_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSoilLayer.SelectedIndexChanged

        Try
            Dim layerNameHead As String
            layerNameHead = cComTools.getHeadFromString(Trim(Me.cmbSoilLayer.Text), ".")
            Me.txtSoilTextureLayerName.Text = layerNameHead & "_Texture"
            Me.txtSoilDepthLayerName.Text = layerNameHead & "_Depth"
            If Me.rbUsingPolygonLayer.Checked = True Then
                If Me.cmbSoilLayer.Text <> "" Then
                    Me.cmbSoilPhaseField.Items.Clear()
                    Me.cmbSoilPhaseField.Text = ""
                    Dim sf As New MapWinGIS.Shapefile
                    sf = cMap.GetMWShapeFileWithLayerName(cMap.mwAppMain, Me.cmbSoilLayer.Text.Trim)
                    Me.cmbSoilPhaseField.DataSource = cMap.GetFieldNameList(sf)
                    'For Each EachField In oPolygonRecordset.Fields
                    '    If EachField.Type = gmFieldType.gmFieldTypeChar Then
                    '        .Add(EachField.Name)
                    '    End If
                    'Next
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, , cGRM.BuildInfo.ProductName)
        End Try
    End Sub

    Private Sub chkSoilTextureLayer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCreateSoilTextureLayer.CheckedChanged
        If Me.chkCreateSoilTextureLayer.Checked = True Then
            Me.txtSoilTextureLayerName.Enabled = True
        Else
            Me.txtSoilTextureLayerName.Enabled = False
        End If
    End Sub

    Private Sub chkSoilDepthLayer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCreateSoilDepthLayer.CheckedChanged
        If Me.chkCreateSoilDepthLayer.Checked = True Then
            Me.txtSoilDepthLayerName.Enabled = True
        Else
            Me.txtSoilDepthLayerName.Enabled = False
        End If
    End Sub

    Private Sub btClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btClose.Click
        Me.Close()

    End Sub


    Private Sub btLoadSoilPhaseVAT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btLoadSoilPhaseVAT.Click
        Dim dlg As New OpenFileDialog
        Dim row As GRMProject.ProjectSettingsRow = CType(cProject.Current.PrjFile.ProjectSettings.Rows(0), GRMProject.ProjectSettingsRow)

        With dlg
            .Title = "Select soil map VAT file"
            .FileName = ""
            If row.ProjectFile <> "" Then
                .InitialDirectory = IO.Path.GetDirectoryName(row.ProjectFile)
            Else
                .InitialDirectory = My.Application.Info.DirectoryPath
            End If
            .Filter = "VAT files (*.vat)|*.vat"
        End With
        If dlg.ShowDialog() = DialogResult.OK Then
            Me.txtSoilPhaseVATPathName.Text = dlg.FileName.Trim
        End If
    End Sub


    Private Sub btOpenDestinationFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btOpenDestinationFolder.Click
        Dim fb As New FolderBrowserDialog
        If fb.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.txtDestinationFolderPath.Text = fb.SelectedPath
        End If
    End Sub

    Private Sub btMakeSoilGrids_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btMakeSoilGrids.Click
        If Trim(Me.cmbSoilLayer.Text) = "" Then
            MsgBox("Soil layer is not selected!   ", MsgBoxStyle.Exclamation, cGRM.BuildInfo.ProductName)
            Exit Sub
        End If

        If rbUsingPolygonLayer.Checked AndAlso Trim(Me.cmbSoilPhaseField.Text) = "" Then
            MsgBox("Soil phase field is not selected!   ", MsgBoxStyle.Exclamation, cGRM.BuildInfo.ProductName)
            Exit Sub
        End If

        If rbUsingGridLayer.Checked AndAlso Trim(txtSoilPhaseVATPathName.Text) = "" Then
            MsgBox("Soil phase VAT file is not selected!   ", MsgBoxStyle.Exclamation, cGRM.BuildInfo.ProductName)
            Exit Sub
        End If

        If Trim(Me.cmbBaseGridLayer.Text) = "" Then
            MsgBox("Base extent grid layer is not selected!   ", MsgBoxStyle.Exclamation, cGRM.BuildInfo.ProductName)
            Exit Sub
        End If

        If Trim(Me.txtDestinationFolderPath.Text) = "" Then
            MsgBox("Output destination folder is not entered!   ", MsgBoxStyle.Exclamation, cGRM.BuildInfo.ProductName)
            Exit Sub
        End If

        If chkCreateSoilDepthLayer.Checked = False AndAlso chkCreateSoilTextureLayer.Checked = False Then
            MsgBox("At least one of the output grid layers must be checked.   ", MsgBoxStyle.Exclamation, cGRM.BuildInfo.ProductName)
            Exit Sub
        End If

        If chkCreateSoilTextureLayer.Checked AndAlso Trim(Me.txtSoilTextureLayerName.Text) = "" Then
            MsgBox("Output Soil texture grid layer name is not entered.   ", MsgBoxStyle.Exclamation, cGRM.BuildInfo.ProductName)
            Exit Sub
        End If

        If chkCreateSoilDepthLayer.Checked AndAlso Trim(Me.txtSoilDepthLayerName.Text) = "" Then
            MsgBox("Output Soil depth grid layer name is not entered.   ", MsgBoxStyle.Exclamation, cGRM.BuildInfo.ProductName)
            Exit Sub
        End If

        MakeSoilGridLayer()

    End Sub

    Private Sub MakeSoilGridLayer()
        Dim map As MapWindow.Interfaces.IMapWin
        map = cMap.mwAppMain
        Dim BExGridLayerName As String = Trim(Me.cmbBaseGridLayer.Text)
        Dim baseGrid As New MapWinGIS.Grid 'GridDataset
        Dim cellSize As Integer
        Dim fpnBG As String = map.Layers( _
            cMap.GetMWLayerHandleWithLayerName(map, BExGridLayerName)).FileName
        baseGrid.Open(fpnBG, MapWinGIS.GridDataType.UnknownDataType, _
                         True, MapWinGIS.GridFileType.UseExtension)
        cellSize = CInt(baseGrid.Header.dX)
        Dim soilLayerNameSource As String = Trim(Me.cmbSoilLayer.Text)
        Dim soilTextureGridLayerName As String = Trim(Me.txtSoilTextureLayerName.Text)
        Dim soilDepthGridLayerName As String = Trim(Me.txtSoilDepthLayerName.Text)
        Dim gridFPN_texture As String
        Dim gridFPN_depth As String
        gridFPN_texture = Trim(Me.txtDestinationFolderPath.Text) + "\" + soilTextureGridLayerName + ".tif"
        gridFPN_depth = Trim(Me.txtDestinationFolderPath.Text) + "\" + soilDepthGridLayerName + ".tif"

        If Me.rbUsingPolygonLayer.Checked = True Then ' 폴리곤에서 그리드 만들고
            MakeSoilGridLayerWithPolygonShpFile(map, soilLayerNameSource, cellSize, _
                                                gridFPN_texture, gridFPN_depth)
        Else
            MakeSoilGridLayerWithSoilPhaseRaster(map, baseGrid, cellSize, soilLayerNameSource, _
                                                  gridFPN_texture, gridFPN_depth)
        End If
        MsgBox("Making grid layers are completed.    ", MsgBoxStyle.Information, cGRM.BuildInfo.ProductName)
    End Sub

    Private Sub MakeSoilGridLayerWithPolygonShpFile(map As MapWindow.Interfaces.IMapWin, _
                                                    soilLayerNameSource As String, _
                                                    resultCellSize As Integer, _
                                                    result_gridFPN_Texture As String, _
                                                    result_gridFPN_Depth As String)
        Dim ofrmPrograssBar As New fProgressBar
        ofrmPrograssBar.GRMToolsPrograssBar.Maximum = 1
        ofrmPrograssBar.GRMToolsPrograssBar.Style = ProgressBarStyle.Blocks
        ofrmPrograssBar.Text = "Create soil grid layers"
        ofrmPrograssBar.Show()
        System.Windows.Forms.Application.DoEvents()
        Try
            Dim STFieldName As String
            Dim SDFieldName As String
            Dim SPhFieldName As String = Trim(Me.cmbSoilPhaseField.Text)
            Dim soilshp As New MapWinGIS.Shapefile
            soilshp = cMap.GetMWShapeFileWithLayerName(map, soilLayerNameSource)
            STFieldName = cMap.GetNewFieldNameToAddToShapeFile(soilshp, "tmpT")
            If STFieldName = "-1" Then Exit Sub
            SDFieldName = cMap.GetNewFieldNameToAddToShapeFile(soilshp, "tmpD")
            If SDFieldName = "-1" Then Exit Sub
            soilshp.StartEditingShapes()
            soilshp.EditAddField(STFieldName, MapWinGIS.FieldType.INTEGER_FIELD, 0, 10)
            soilshp.EditAddField(SDFieldName, MapWinGIS.FieldType.INTEGER_FIELD, 0, 10)
            soilshp.Save()
            soilshp.StopEditingShapes(True, True)

            ofrmPrograssBar.GRMToolsPrograssBar.Value = 1
            ofrmPrograssBar.labGRMToolsPrograssBar.Text = "Updating soil fields..."
            UpdateSoilTextureAndDepthField(soilshp, SPhFieldName, _
                                            STFieldName, SDFieldName, _
                                            Trim(Me.txtDestinationFolderPath.Text))
            'Dim ocVectorToGrid As New GMTools2009.cVectorToGrid
            Dim mwUtil As New MapWinGIS.Utils
            ofrmPrograssBar.GRMToolsPrograssBar.Value = 1
            ofrmPrograssBar.labGRMToolsPrograssBar.Text = "Making soil texture grid layer..."
            System.Windows.Forms.Application.DoEvents()
            If Me.chkCreateSoilTextureLayer.Checked = True Then
                Dim stgrid As New MapWinGIS.Grid
                cGdal.PolygonToRasterByFieldName(soilshp, _
                                                          STFieldName, result_gridFPN_Texture, _
                                                          cGdal.GdalFormat.GTiff, _
                                                          cGdal.GdalDataType.GDT_CInt32, _
                                                          resultCellSize, -9999, False)
                stgrid.Open(result_gridFPN_Texture, MapWinGIS.GridDataType.UnknownDataType, _
                             True, MapWinGIS.GridFileType.UseExtension)
                map.Layers.Add(stgrid)
            End If
            ofrmPrograssBar.GRMToolsPrograssBar.Value = 1
            ofrmPrograssBar.labGRMToolsPrograssBar.Text = "Making soil depth grid layer..."
            System.Windows.Forms.Application.DoEvents()
            If Me.chkCreateSoilDepthLayer.Checked = True Then
                Dim sdgrid As New MapWinGIS.Grid
                cGdal.PolygonToRasterByFieldName(soilshp, _
                                            SDFieldName, result_gridFPN_Depth, _
                                            cGdal.GdalFormat.GTiff, _
                                            cGdal.GdalDataType.GDT_CInt32, _
                                            resultCellSize, -9999, False)
                sdgrid.Open(result_gridFPN_Depth, MapWinGIS.GridDataType.UnknownDataType, _
                            True, MapWinGIS.GridFileType.UseExtension)
                map.Layers.Add(sdgrid)
            End If
            ofrmPrograssBar.Close()
            System.Windows.Forms.Application.DoEvents()
        Catch ex As Exception
            ofrmPrograssBar.Close()
        End Try
    End Sub

    Private Sub MakeSoilGridLayerWithSoilPhaseRaster(map As MapWindow.Interfaces.IMapWin, _
                                                     basegrid As MapWinGIS.Grid, _
                                                     cellsize As Integer, _
                                                     soilLayerNameSource As String, _
                                                     gridFPN_texture As String, _
                                                     gridFPN_depth As String)
        Dim ofrmPrograssBar As New fProgressBar
        If File.Exists(Trim(Me.txtSoilPhaseVATPathName.Text)) = False Then
            MsgBox("Soil phase VAT file is invalid.    ", MsgBoxStyle.Exclamation, cGRM.BuildInfo.ProductName)
            ofrmPrograssBar.Close()
            Exit Sub
        End If
        '토양상 그리드 레이어에서 토성, 토양심 그리드 만들고
        Call ReadAndSetSoilPhaseTextureDepthAttribute()
        Dim soilPhaseName As String
        Dim valueToPut As Integer
        Dim fpnSPhase As String
        fpnSPhase = map.Layers(cMap.GetMWLayerHandleWithLayerName(map, soilLayerNameSource)).FileName
        If Me.chkCreateSoilTextureLayer.Checked = True Then
            cGdal.ClipGridAndResample(basegrid, fpnSPhase, gridFPN_texture, _
                                       cellsize, cGdal.GdalResamplingMethod.near, _
                                       cGdal.GdalFormat.GTiff, cGdal.GdalDataType.GDT_CInt32)
            Dim gridST As New MapWinGIS.Grid
            gridST.Open(gridFPN_texture, MapWinGIS.GridDataType.UnknownDataType, _
                          True, MapWinGIS.GridFileType.UseExtension)
            Dim soilTextureName As String
            mSoilTextureVAT.GridValue = New ArrayList
            mSoilTextureVAT.SoilPhaseName = New ArrayList
            Dim cellCount As Integer = 0
            Dim cellCountTotal As Integer = gridST.Header.NumberCols * gridST.Header.NumberRows
            ofrmPrograssBar.GRMToolsPrograssBar.Maximum = cellCountTotal
            ofrmPrograssBar.GRMToolsPrograssBar.Style = ProgressBarStyle.Blocks
            ofrmPrograssBar.labGRMToolsPrograssBar.Text = "Creating soil grid layers..."
            ofrmPrograssBar.Text = "Create soil grid layers"
            ofrmPrograssBar.Show()
            System.Windows.Forms.Application.DoEvents()
            For rowy As Integer = 0 To gridST.Header.NumberRows - 1
                For colx As Integer = 0 To gridST.Header.NumberCols - 1
                    Dim pValue As Integer = CInt(gridST.Value(colx, rowy))
                    If pValue <> -9999 Then
                        soilPhaseName = ""
                        soilTextureName = ""
                        Call GetSoilPhaseAndTextureName(pValue, soilPhaseName, soilTextureName)
                        If soilPhaseName = "미지정" Then
                            Dim msgResultYesOrNo As New MsgBoxResult
                            msgResultYesOrNo = MsgBox(soilPhaseName + " attribute is founded in " + soilLayerNameSource + _
                                                      " during making soil texture layer.   " + vbCrLf + _
                                                      "Grid value in " + soilLayerNameSource + " is " + CStr(pValue) + "." + vbCrLf + _
                                                      "Grid position: ColX=" + CStr(colx) + ", RowY=" + CStr(rowy) + vbCrLf + _
                                                    "Stop this process?     ", MsgBoxStyle.Exclamation Or MsgBoxStyle.YesNo, _
                                                    cGRM.BuildInfo.ProductName)
                            If msgResultYesOrNo = MsgBoxResult.Yes Then
                                ofrmPrograssBar.Close()
                                Exit Sub
                            End If
                        Else
                            If soilTextureName = "세사양토" Then soilTextureName = "사양토"
                            If soilTextureName = "양질세사토" OrElse soilTextureName = "양질조사토" Then soilTextureName = "양질사토"
                            valueToPut = SetSoilTextureVATAndGetGridValue(soilTextureName)
                            gridST.Value(colx, rowy) = valueToPut
                            '.PutValue(intColX, intRowY, intValueToPut) '그리드의 값을 이것으로 업데이트
                        End If
                    End If
                    cellCount += 1
                    If cellCount Mod 1000 = 0 Then
                        ofrmPrograssBar.GRMToolsPrograssBar.Value = cellCount
                        ofrmPrograssBar.labGRMToolsPrograssBar.Text = "Processing " & _
                            CStr(cellCount) & "/" & CStr(cellCountTotal) & " cell..."
                        System.Windows.Forms.Application.DoEvents()
                    End If
                Next

            Next
            '여기서 save 하는 과정 필요?
            Call SaveSoilTextureVATFile(gridFPN_texture)
            map.Layers.Add(gridST)
            ofrmPrograssBar.Close()
            System.Windows.Forms.Application.DoEvents()
        End If

        If Me.chkCreateSoilDepthLayer.Checked = True Then
            cGdal.ClipGridAndResample(basegrid, fpnSPhase, gridFPN_depth, _
                                       cellsize, cGdal.GdalResamplingMethod.near, _
                                       cGdal.GdalFormat.GTiff, cGdal.GdalDataType.GDT_CInt32)
            Dim gridSD As New MapWinGIS.Grid
            gridSD.Open(gridFPN_depth, MapWinGIS.GridDataType.UnknownDataType, _
                          True, MapWinGIS.GridFileType.UseExtension)
            System.Windows.Forms.Application.DoEvents()
            Dim soilDepth As String
            mSoilDepthVAT.GridValue = New ArrayList
            mSoilDepthVAT.SoilPhaseName = New ArrayList
            Dim cellCount As Integer = 0
            Dim cellCountTotal As Integer = gridSD.Header.NumberCols * gridSD.Header.NumberRows
            ofrmPrograssBar.GRMToolsPrograssBar.Maximum = cellCountTotal
            ofrmPrograssBar.GRMToolsPrograssBar.Style = ProgressBarStyle.Blocks
            ofrmPrograssBar.labGRMToolsPrograssBar.Text = "Creating soil grid layers..."
            ofrmPrograssBar.Text = "Create soil grid layers"
            ofrmPrograssBar.Show()
            For rowY As Integer = 0 To gridSD.Header.NumberRows - 1
                For colX As Integer = 0 To gridSD.Header.NumberCols - 1
                    Dim pValue As Integer = CInt(gridSD.Value(colX, rowY))
                    If pValue <> -9999 Then
                        soilPhaseName = ""
                        soilDepth = ""
                        Call GetSoilPhaseAndDepthName(pValue, soilPhaseName, soilDepth)

                        If soilPhaseName = "미지정" Then
                            Dim msgResultYesOrNo As New MsgBoxResult
                            msgResultYesOrNo = MsgBox(soilPhaseName + " attribute is founded in " + _
                                                      soilLayerNameSource + " during making soil depth layer.    " + vbCrLf + _
                                                      "Grid value in " + soilLayerNameSource + " is " + CStr(pValue) + "." + vbCrLf + _
                                                      "Grid position: ColX=" + CStr(colX) + ", RowY=" + CStr(rowY) + vbCrLf + _
                                                    "Stop this process?     ", MsgBoxStyle.Exclamation Or MsgBoxStyle.YesNo, _
                                                    cGRM.BuildInfo.ProductName)
                            If msgResultYesOrNo = MsgBoxResult.Yes Then
                                ofrmPrograssBar.Close()
                                Exit Sub
                            End If
                        Else
                            valueToPut = SetSoilDepthVATAndGetGridValue(soilDepth)
                            gridSD.Value(colX, rowY) = valueToPut '그리드의 값을 이것으로 업데이트
                        End If
                    End If
                    cellCount += 1
                    If cellCount Mod 1000 = 0 Then
                        ofrmPrograssBar.GRMToolsPrograssBar.Value = cellCount
                        'ofrmPrograssBar.labProgress.Text = "Creating soil depth layer..."
                        ofrmPrograssBar.labGRMToolsPrograssBar.Text = "Processing " & CStr(cellCount) & _
                                "/" & CStr(cellCountTotal) & " cell..."
                        System.Windows.Forms.Application.DoEvents()
                    End If
                Next
            Next
            '여기서 save 하는 과정 필요?
            Call SaveSoilDepthVATFile(gridFPN_depth)
            map.Layers.Add(gridSD)
            ofrmPrograssBar.Close()
            System.Windows.Forms.Application.DoEvents()
        End If
    End Sub

    Sub SaveSoilTextureVATFile(ByVal resultGridFileName As String)
        Dim intFNum As Integer = FreeFile()
        Dim strFNP As String = Trim(Me.txtDestinationFolderPath.Text) + "\" + IO.Path.GetFileNameWithoutExtension(resultGridFileName) + ".VAT"
        Dim strOutPutLine As String
        Dim intN As Integer

        If IO.File.Exists(strFNP) = True Then
            File.Delete(strFNP)
        End If
        strOutPutLine = CStr(mSoilTextureVAT.GridValue.Count) + vbCrLf
        IO.File.AppendAllText(strFNP, strOutPutLine, Encoding.Default)
        For intN = 0 To mSoilTextureVAT.GridValue.Count - 1
            IO.File.AppendAllText(strFNP, CStr(mSoilTextureVAT.GridValue.Item(intN)) + "," + CStr(mSoilTextureVAT.SoilPhaseName.Item(intN)) & vbCrLf, Encoding.Default)
        Next
    End Sub

    Sub SaveSoilDepthVATFile(ByVal resultGridFileName As String)

        Dim intFNum As Integer = FreeFile()
        Dim strFNP As String = Trim(Me.txtDestinationFolderPath.Text) + "\" + IO.Path.GetFileNameWithoutExtension(resultGridFileName) + ".VAT"
        Dim strOutPutLine As String
        Dim intN As Integer

        If IO.File.Exists(strFNP) = True Then
            File.Delete(strFNP)
        End If
        strOutPutLine = CStr(mSoilDepthVAT.GridValue.Count) + vbCrLf
        IO.File.AppendAllText(strFNP, strOutPutLine, Encoding.Default)
        For intN = 0 To mSoilDepthVAT.GridValue.Count - 1
            IO.File.AppendAllText(strFNP, CStr(mSoilDepthVAT.GridValue.Item(intN)) + "," + CStr(mSoilDepthVAT.SoilPhaseName.Item(intN)) & vbCrLf, Encoding.Default)
        Next
    End Sub



    Function SetSoilTextureVATAndGetGridValue(ByVal strSoilTextureNameInput As String) As Integer
        Dim intN As Integer
        Dim intGridValueToAdd As Integer = 0
        For intN = 0 To mSoilTextureVAT.GridValue.Count - 1

            If CStr(mSoilTextureVAT.SoilPhaseName.Item(intN)) = strSoilTextureNameInput Then
                SetSoilTextureVATAndGetGridValue = CInt(mSoilTextureVAT.GridValue.Item(intN))
                Exit Function
            End If
            intGridValueToAdd += 1
        Next
        mSoilTextureVAT.GridValue.Add(CStr(intGridValueToAdd + 1)) ' 마지막 값에 1을 더한다
        mSoilTextureVAT.SoilPhaseName.Add(strSoilTextureNameInput)
        SetSoilTextureVATAndGetGridValue = intGridValueToAdd + 1
    End Function


    Function SetSoilDepthVATAndGetGridValue(ByVal strSoilDepthNameInput As String) As Integer
        Dim intN As Integer
        Dim intGridValueToAdd As Integer = 0
        For intN = 0 To mSoilDepthVAT.GridValue.Count - 1
            If CStr(mSoilDepthVAT.SoilPhaseName.Item(intN)) = strSoilDepthNameInput Then
                SetSoilDepthVATAndGetGridValue = CInt(mSoilDepthVAT.GridValue.Item(intN))
                Exit Function
            End If
            intGridValueToAdd += 1
        Next
        mSoilDepthVAT.GridValue.Add(CStr(intGridValueToAdd + 1)) ' 마지막 값에 1을 더한다
        mSoilDepthVAT.SoilPhaseName.Add(strSoilDepthNameInput)
        SetSoilDepthVATAndGetGridValue = intGridValueToAdd + 1
    End Function

    Function GetSoilAttributeWithDataset(ByVal strSoilPhaseInput As String, ByVal strAttributeToGet As String) As String
        If strSoilPhaseInput = "미지정" Then
            GetSoilAttributeWithDataset = "미지정"
        Else
            For intN As Integer = 0 To mDtStaticSoilAtt.Rows.Count - 1
                If CStr(mDtStaticSoilAtt.Rows(intN).Item("SoilPhase")) = strSoilPhaseInput Then
                    Return mDtStaticSoilAtt.Rows(intN).Item(strAttributeToGet).ToString
                End If
            Next
        End If
        Return "미지정"
    End Function



    Sub GetSoilPhaseAndTextureName(ByVal intGridValueInput As Integer, ByRef strSoilPhaseName As String, ByRef strSoilSeriesName As String)
        For intN As Integer = 0 To mintSoilAttInVAT - 1
            If CInt(mSoilPhaseVAT.GridValue.Item(intN)) = intGridValueInput Then
                strSoilPhaseName = CStr(mSoilPhaseVAT.SoilPhaseName.Item(intN))
                strSoilSeriesName = CStr(mSoilPhaseVAT.SoilTextureName.Item(intN))
                Exit Sub
            End If
        Next
        strSoilPhaseName = "미지정"
        strSoilSeriesName = "미지정"
    End Sub


    Sub GetSoilPhaseAndDepthName(ByVal intGridValueInput As Integer, ByRef strSoilPhaseName As String, ByRef strSoilDepthName As String)
        For intN As Integer = 0 To mintSoilAttInVAT - 1
            If CInt(mSoilPhaseVAT.GridValue.Item(intN)) = intGridValueInput Then
                strSoilPhaseName = CStr(mSoilPhaseVAT.SoilPhaseName.Item(intN))
                strSoilDepthName = CStr(mSoilPhaseVAT.SoilDepthName.Item(intN))
                Exit Sub
            End If
        Next
        strSoilPhaseName = "미지정"
        strSoilDepthName = "미지정"
    End Sub


    Sub ReadAndSetSoilPhaseTextureDepthAttribute()

        Dim strVATPathName As String = Trim(Me.txtSoilPhaseVATPathName.Text)
        Dim oSReader As New StreamReader(strVATPathName, Encoding.Default)

        Dim intCountSPhaseInVAT As Integer = CInt(oSReader.ReadLine())

        Dim strL As String
        Dim strGridValue As String
        Dim strSPhaseAtt As String
        Dim intCountSP As Integer = 0

        mintSoilAttInVAT = intCountSPhaseInVAT

        mSoilPhaseVAT.GridValue = New ArrayList
        mSoilPhaseVAT.SoilPhaseName = New ArrayList
        mSoilPhaseVAT.SoilTextureName = New ArrayList
        mSoilPhaseVAT.SoilDepthName = New ArrayList

        Do Until oSReader.EndOfStream
            strL = oSReader.ReadLine()
            If Len(strL) = 0 Then
                Exit Do
            End If
            strGridValue = cComTools.getHeadFromString(strL, ",")
            strSPhaseAtt = cComTools.getTailFromString(strL, ",")
            If strGridValue = "-9999" Then
            Else
                mSoilPhaseVAT.GridValue.Add(strGridValue)
                mSoilPhaseVAT.SoilPhaseName.Add(strSPhaseAtt)
                mSoilPhaseVAT.SoilTextureName.Add(GetSoilAttributeWithDataset(strSPhaseAtt, "SoilTexture"))
                mSoilPhaseVAT.SoilDepthName.Add(GetSoilAttributeWithDataset(strSPhaseAtt, "SoilDepth"))
            End If
        Loop
    End Sub

    Private Sub UpdateSoilTextureAndDepthField(ByVal soilSHPfile As MapWinGIS.Shapefile, _
                                               ByVal soilPhaseFieldName As String, _
                                               ByVal soilTextureFieldName As String, _
                                               ByVal soilDepthFieldName As String, _
                                               ByVal targetPath As String)
        Try
            Dim fieldIndexSoilPhase As Integer
            Dim fieldIndexSoilTexture As Integer
            Dim fieldIndexSoilDepthField As Integer

            fieldIndexSoilPhase = cMap.GetFieldIndexByName(soilSHPfile, soilPhaseFieldName)
            fieldIndexSoilTexture = cMap.GetFieldIndexByName(soilSHPfile, soilTextureFieldName)
            fieldIndexSoilDepthField = cMap.GetFieldIndexByName(soilSHPfile, soilDepthFieldName)
            ReDim mSoilAttribute(soilSHPfile.NumShapes - 1)

            MyBase.Cursor = Cursors.WaitCursor : Windows.Forms.Application.DoEvents()

            Dim ofrmPrograssBar As New fProgressBar
            ofrmPrograssBar.GRMToolsPrograssBar.Maximum = soilSHPfile.NumShapes
            ofrmPrograssBar.GRMToolsPrograssBar.Style = ProgressBarStyle.Blocks
            ofrmPrograssBar.labGRMToolsPrograssBar.Text = "Updating 0/" & CStr(soilSHPfile.NumShapes) & " soil attribute..."
            ofrmPrograssBar.Text = "Updating soil attribute"

            ofrmPrograssBar.Show()
            System.Windows.Forms.Application.DoEvents()
            Dim soilTextureNameToApp As String
            Dim MissingPhase As New ArrayList
            Dim NullPhase As New ArrayList
            Dim missingPhaseTextFPN As String = IO.Path.Combine(targetPath, "MissingSoilPhase.txt")
            If IO.File.Exists(missingPhaseTextFPN) = True Then
                IO.File.Delete(missingPhaseTextFPN)
            End If

            soilSHPfile.StartEditingTable()
            For n1 As Integer = 0 To soilSHPfile.NumShapes - 1
                mSoilAttribute(n1).Order = n1 + 1
                mSoilAttribute(n1).SoilPhaseName = soilSHPfile.CellValue(fieldIndexSoilPhase, n1).ToString  'GM_cursor.GetFieldIndex(mstrSoilPhaseFieldName))
                mSoilAttribute(n1).bNormal = False
                For n2 As Integer = 0 To mDtStaticSoilAtt.Rows.Count - 1
                    If mDtStaticSoilAtt.Rows(n2).Item("SoilPhase").ToString = mSoilAttribute(n1).SoilPhaseName Then
                        soilTextureNameToApp = Trim(mDtStaticSoilAtt.Rows(n2).Item("SoilTexture").ToString)
                        If soilTextureNameToApp = "세사양토" Then
                            soilTextureNameToApp = "사양토" '이것을 입력
                        End If
                        If soilTextureNameToApp = "양질세사토" Or soilTextureNameToApp = "양질조사토" Then
                            soilTextureNameToApp = "양질사토" '이것을 입력
                        End If
                        soilSHPfile.EditCellValue(fieldIndexSoilTexture, n1, soilTextureNameToApp)
                        soilSHPfile.EditCellValue(fieldIndexSoilDepthField, n1, _
                                                  Trim(mDtStaticSoilAtt.Rows(n2).Item("SoilDepth").ToString))
                        mSoilAttribute(n1).bNormal = True
                        Exit For
                    End If
                Next n2
                If mSoilAttribute(n1).bNormal = False Then
                    MissingPhase.Add(mSoilAttribute(n1).SoilPhaseName)
                    If mSoilAttribute(n1).SoilPhaseName = "" Then
                        NullPhase.Add(n1)
                    End If
                    soilSHPfile.EditCellValue(fieldIndexSoilTexture, n1, mCONSTDefaultSoilTexture)
                    soilSHPfile.EditCellValue(fieldIndexSoilDepthField, n1, _
                                              mCONSTDefaultSoilDepth)
                End If
                If n1 Mod 100 = 0 Then
                    ofrmPrograssBar.GRMToolsPrograssBar.Value = n1 '+ 1
                    ofrmPrograssBar.labGRMToolsPrograssBar.Text = "Updating " & CStr(n1) & _
                                   "/" & CStr(soilSHPfile.NumShapes) & " soil attribute..."
                    System.Windows.Forms.Application.DoEvents()

                End If
            Next n1
            soilSHPfile.StopEditingTable(True)
            soilSHPfile.Save()
            ofrmPrograssBar.Close()

            MyBase.Cursor = Cursors.Default : Windows.Forms.Application.DoEvents()
            If MissingPhase.Count > 0 Then
                MsgBox("Missing soil phase count in " & soilSHPfile.Filename & _
                       " layer : " & MissingPhase.Count & "." & vbCrLf & _
                       " (Soil phase null value count : " & NullPhase.Count & ".)" & vbCrLf & _
                       " Soil texture is assigned to [Loam] " & vbCrLf & _
                       " and soil depth is assigned to [Moderately Deep or Moderately Shallow]" & vbCrLf & _
                       " Missing soil phase value is saved in a text file. " & vbCrLf & _
                       missingPhaseTextFPN, _
                         MsgBoxStyle.Information, cGRM.BuildInfo.ProductName)
                IO.File.AppendAllText(missingPhaseTextFPN, "Total missing soil phase value : " & MissingPhase.Count & vbCrLf)
                IO.File.AppendAllText(missingPhaseTextFPN, "Total null soil phase value : " & NullPhase.Count & vbCrLf)
                For n As Integer = 0 To MissingPhase.Count - 1
                    IO.File.AppendAllText(missingPhaseTextFPN, MissingPhase(n).ToString & vbCrLf)
                Next
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
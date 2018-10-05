Imports System.IO

Public Class cGdal
    Private Shared mGdalPath As String = My.Application.Info.DirectoryPath & "\GDAL"
    Public Enum GdalFormat
        GTiff     ' GeoTIFF
        AAIGrid ' Arc/Info ASCII Grid
        GRIB
    End Enum

    Public Enum GdalResamplingMethod
        near
        bilinear
        cubic
        cubicspline
        lanczox
        average
        mode
    End Enum

    Public Enum GdalDataType
        GDT_Unknown
        GDT_Byte
        GDT_UInt16
        GDT_Int16
        GDT_UInt32
        GDT_Int32
        GDT_Float32
        GDT_Float64
        GDT_CInt16
        GDT_CInt32
        GDT_CFloat32
        GDT_CFloat64
        'Byte/Int16/UInt16/UInt32/Int32/Float32/Float64/CInt16/CInt32/CFloat32/CFloat64
    End Enum

    ''' <summary>
    ''' shapefile의 포인트를 이용해서 idw 보간 후 , geotiff로 레이어 생성
    ''' </summary>
    ''' <param name="pntshapefilePN"></param>
    ''' <param name="baseGridHeader"></param>
    ''' <param name="targetFPN"></param>
    ''' <param name="valueFieldName"></param>
    ''' <param name="inversePower"></param>
    ''' <param name="smoothingfactor"></param>
    ''' <param name="searchRadius"></param>
    ''' <remarks></remarks>
    Public Shared Sub MakeIDWGrid(pntshapefilePN As String, valueFieldName As String,
                                  baseGridHeader As cAscRasterHeader, targetFPN As String,
                                  inversePower As Integer, smoothingfactor As Double,
                                  searchRadius As Single, outformat As GdalFormat) 'As MapWinGIS.Grid
        Try
            If targetFPN = "" OrElse pntshapefilePN = "" OrElse baseGridHeader Is Nothing Then Exit Sub
            Dim nWidth As Integer = baseGridHeader.numberCols
            Dim nHeight As Integer = baseGridHeader.numberRows
            Dim cellSize As Single = CSng(baseGridHeader.cellsize)
            Dim ext As New cRasterExtent(baseGridHeader)
            'GetResamplingColAndRow(baseGrid, dCellSize, nWidth, nHeight)
            'Dim gridExt As New cTextFileReaderASC ( cGrid(baseGrid)
            'Dim formatName As String = GetGdalFormatName(outformat)
            Dim gdalPN As String = Path.Combine(mGdalPath, "gdal_grid.exe")
            Dim pGdalGrid As New Process()
            pGdalGrid.StartInfo.FileName = gdalPN
            'pGdalGrid.StartInfo.UseShellExecute = False
            pGdalGrid.StartInfo.Arguments = " -zfield " + cComTools.SetDQ(valueFieldName) +
                                                     " -a invdist:power=" + inversePower.ToString + ":smoothing=" + smoothingfactor.ToString +
                                                             ":radius1=" + searchRadius.ToString + ":radius2=" + searchRadius.ToString +
                                                    " -txe " + ext.left.ToString + " " + ext.right.ToString +
                                                    " -tye " + ext.bottom.ToString + " " + ext.top.ToString +
                                                     " -outsize " + nWidth.ToString + " " + nHeight.ToString +
                                                     " -l " + Path.GetFileNameWithoutExtension(pntshapefilePN) +
                                                     " -of " + cComTools.SetDQ(outformat.ToString) +
                                                     " --config GDAL_FILENAME_IS_UTF8 NO" +
                                                     " " + cComTools.SetDQ(pntshapefilePN) +
                                                     " " + cComTools.SetDQ(targetFPN)
            pGdalGrid.StartInfo.WindowStyle = ProcessWindowStyle.Normal
            pGdalGrid.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            pGdalGrid.Start()
            pGdalGrid.WaitForExit()
            pGdalGrid.Dispose()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Shared Sub GetResamplingColAndRow(sourceGridHeader As cAscRasterHeader, outcellsize As Integer, ByRef dCol As Integer, ByRef dRow As Integer)
        If sourceGridHeader Is Nothing Then Exit Sub
        Dim dWidthDistanceIn As Double = 0.0
        Dim dHeightDistanceIn As Double = 0.0
        'Dim ogrid As New cGrid(sourceGrid)
        Dim ext As New cRasterExtent(sourceGridHeader)
        dWidthDistanceIn = ext.extentWidth
        dHeightDistanceIn = ext.extentHeight
        Dim dWidthDistanceOut As Double  ' 가로는 원본과 일치시키는 방식
        Dim dHeightDistanceOut As Double
        '즉 안전하게 '버림'으로 처리후에..
        Dim nColsOut As Integer = CInt(Math.Floor(dWidthDistanceIn / outcellsize))
        Dim nColsTmpOut As Integer = nColsOut + 1
        Dim nRowsOut As Integer = CInt(Math.Floor(dHeightDistanceIn / outcellsize))
        Dim nRowsTmpOut As Integer = nRowsOut + 1
        ' nColsTmpOut, nRowsTmp cell 중심이 애초 grid 영역 내부인지 아닌지 로 check
        If (((nColsTmpOut - 1) * sourceGridHeader.cellsize + (sourceGridHeader.cellsize / 2)) < dWidthDistanceIn) Then nColsOut = nColsTmpOut
        If (((nRowsTmpOut - 1) * sourceGridHeader.cellsize + (sourceGridHeader.cellsize / 2)) < dHeightDistanceIn) Then nRowsOut = nRowsTmpOut
        '검증용. 동일하지 않으면 오류
        dHeightDistanceOut = nRowsOut * outcellsize
        dWidthDistanceOut = nColsOut * outcellsize
        Dim dRowsCellSizeOut As Double = dHeightDistanceOut / nRowsOut
        If outcellsize <> dRowsCellSizeOut Then
            MsgBox("Resampling cell sizes have some error", MsgBoxStyle.Exclamation)
            dCol = 0
            dRow = 0
            Exit Sub
        End If
        dCol = nColsOut
        dRow = nRowsOut
    End Sub

    Public Shared Function GetGdalDataTypeNameToApply(inFormat As cGdal.GdalDataType) As String
        'Byte/Int16/UInt16/UInt32/Int32/Float32/Float64/CInt16/CInt32/CFloat32/CFloat64
        Select Case inFormat
            Case GdalDataType.GDT_Byte
                Return "Byte"
            Case GdalDataType.GDT_Int16
                Return "Int16"
            Case GdalDataType.GDT_Int32
                Return "Int32"
            Case GdalDataType.GDT_Float32
                Return "Float32"
            Case GdalDataType.GDT_Float64
                Return "Float64"
            Case Else
                Return ""
        End Select
    End Function

    Public Shared Function GetGdalResamplingMethodByText(method As String) As cGdal.GdalResamplingMethod
        Select Case method
            Case GdalResamplingMethod.bilinear.ToString
                Return GdalResamplingMethod.bilinear
            Case GdalResamplingMethod.near.ToString
                Return GdalResamplingMethod.near
        End Select
        Return Nothing
    End Function

    Public Shared Function GetGdalFileFormatByText(formatName As String) As cGdal.GdalFormat
        Select Case formatName
            Case GdalFormat.AAIGrid.ToString
                Return GdalFormat.AAIGrid
            Case GdalFormat.GTiff.ToString
                Return GdalFormat.GTiff
            Case GdalFormat.GRIB.ToString
                Return GdalFormat.GRIB
        End Select

        Return Nothing
    End Function

    Public Shared Function ConvertASCIItoGTIFF(sourceFPN As String, resultFPN As String, resultDataType As cGdal.GdalDataType) As Boolean
        Try
            If resultFPN = "" OrElse sourceFPN = "" Then
                MsgBox("Invalid source/result file name. ", MsgBoxStyle.Exclamation)
                Return False
                Exit Function
            End If
            '부동소수점 single 지정해도 double로 나온다..
            Dim dtypeName As String = GetGdalDataTypeNameToApply(resultDataType)
            Dim strGdalPath As String = Path.Combine(mGdalPath, "gdal_translate.exe")
            Dim pGdalGrid As New Process()
            pGdalGrid.StartInfo.FileName = strGdalPath
            pGdalGrid.StartInfo.Arguments = " -of GTiff" +
                                                    " -ot " + cComTools.SetDQ(dtypeName) +
                                                     " -a_nodata " + CStr(-9999) +
                                                     " --config GDAL_FILENAME_IS_UTF8 NO" +
                                                     " " + cComTools.SetDQ(sourceFPN) +
                                                     " " + cComTools.SetDQ(resultFPN)
            pGdalGrid.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            pGdalGrid.Start()
            pGdalGrid.WaitForExit()
            pGdalGrid.Dispose()
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Shared Function ConvertGtiffAndGribToASCII(sourceFPN As String, resultFPN As String, bandN As Integer, resultDataType As cGdal.GdalDataType) As Boolean
        Try
            If resultFPN = "" OrElse sourceFPN = "" Then
                MsgBox("Invalid source/result file name. ", MsgBoxStyle.Exclamation)
                Return False
                Exit Function
            End If
            '부동소수점 single 지정해도 double로 나온다..
            Dim dtypeName As String = GetGdalDataTypeNameToApply(resultDataType)
            Dim strGdalPath As String = Path.Combine(mGdalPath, "gdal_translate.exe")
            Dim pGdalGrid As New Process()
            pGdalGrid.StartInfo.FileName = strGdalPath
            pGdalGrid.StartInfo.Arguments = " -of AAIGrid" + " -b " + bandN.ToString +
                                                    " -ot " + cComTools.SetDQ(dtypeName) +
                                                     " -a_nodata " + CStr(-9999) +
                                                     " --config GDAL_FILENAME_IS_UTF8 NO" +
                                                     " " + cComTools.SetDQ(sourceFPN) +
                                                     " " + cComTools.SetDQ(resultFPN)
            pGdalGrid.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            pGdalGrid.Start()
            pGdalGrid.WaitForExit()
            pGdalGrid.Dispose()
            cTextFile.ReplaceTextInTextFile(resultFPN, vbLf, vbCrLf)
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function


    'Public Shared Function ConvertGRIBtoASCII(sourceFPN As String, resultFPN As String, bandN As Integer, resultDataType As cGdal.GdalDataType) As Boolean
    '    Try
    '        If resultFPN = "" OrElse sourceFPN = "" Then
    '            MsgBox("Invalid source/result file name. ", MsgBoxStyle.Exclamation)
    '            Return False
    '            Exit Function
    '        End If
    '        '부동소수점 single 지정해도 double로 나온다..
    '        Dim dtypeName As String = GetGdalDataTypeNameToApply(resultDataType)
    '        Dim strGdalPath As String = Path.Combine(mGdalPath, "gdal_translate.exe")
    '        Dim pGdalGrid As New Process()
    '        pGdalGrid.StartInfo.FileName = strGdalPath
    '        pGdalGrid.StartInfo.Arguments = " -of AAIGrid" + " -b " + bandN.ToString +
    '                                                " -ot " + cComTools.SetDQ(dtypeName) +
    '                                                 " -a_nodata " + CStr(-9999) +
    '                                                 " --config GDAL_FILENAME_IS_UTF8 NO" +
    '                                                 " " + cComTools.SetDQ(sourceFPN) +
    '                                                 " " + cComTools.SetDQ(resultFPN)
    '        pGdalGrid.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
    '        pGdalGrid.Start()
    '        pGdalGrid.WaitForExit()
    '        pGdalGrid.Dispose()
    '        cTextFile.ReplaceTextInTextFile(resultFPN, vbLf, vbCrLf)
    '        Return True
    '    Catch ex As Exception
    '        Throw ex
    '        Return False
    '    End Try
    'End Function


    ''' <summary>
    ''' 클리핑이 주목적, 셀크기와 위치가 다를 경우 resampling도 한다.
    ''' </summary>
    ''' <param name="basegridHeader"></param>
    ''' <param name="gridSourceFPN"></param>
    ''' <param name="resultFPN"></param>
    ''' <param name="outCellSize"></param>
    ''' <param name="outFormat"></param>
    ''' <remarks></remarks>
    Public Shared Sub ClipGridAndResample(basegridHeader As cAscRasterHeader, gridSourceFPN As String,
                                 resultFPN As String, outCellSize As Single,
                                 resampleMethod As cGdal.GdalResamplingMethod,
                                 outFormat As cGdal.GdalFormat,
                                 outDataType As cGdal.GdalDataType)
        Try
            If resultFPN = "" OrElse basegridHeader Is Nothing OrElse gridSourceFPN = "" OrElse outCellSize <= 0 Then Exit Sub
            'Dim nWidth As Integer = basegridHeader.numberCols
            'Dim nHeight As Integer = basegridHeader.numberRows
            Dim cellSize As Single = CSng(outCellSize) ' CSng(basegrid.Header.cellsize)
            Dim dType As String = GetGdalDataTypeNameToApply(outDataType)
            Dim ext As New cRasterExtent(basegridHeader)

            '여기서.. ascii 출력이 안된다...
            Dim formatName As String = GdalFormat.GTiff.ToString
            Dim fpnTemp As String = resultFPN
            If outFormat = GdalFormat.AAIGrid Then
                fpnTemp = Replace(resultFPN, ".asc", ".tif")
            End If

            Dim strGdalPath As String = Path.Combine(mGdalPath, "gdalwarp.exe")
            Dim prGdalGrid As New Process()
            prGdalGrid.StartInfo.FileName = strGdalPath
            prGdalGrid.StartInfo.Arguments = " -te " + ext.left.ToString + " " + ext.bottom.ToString + " " _
                                                               + ext.right.ToString + " " + ext.top.ToString +
                                                     " -tr " + cellSize.ToString + " " + cellSize.ToString +
                                                     " -dstnodata " + CStr(-9999) +
                                                     " -of " + cComTools.SetDQ(formatName) +
                                                     " -ot " + cComTools.SetDQ(dType) +
                                                     " --config GDAL_FILENAME_IS_UTF8 NO" +
                                                     " " + cComTools.SetDQ(gridSourceFPN) +
                                                     " " + cComTools.SetDQ(fpnTemp)
            prGdalGrid.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            prGdalGrid.Start()
            prGdalGrid.WaitForExit()
            prGdalGrid.Dispose()

            If outFormat = GdalFormat.AAIGrid Then
                cGdal.ConvertGtiffAndGribToASCII(fpnTemp, resultFPN, 1, outDataType)
                cFile.DeleteFileFriends(resultFPN)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Public Shared Sub GridResample(basegridHeader As cAscRasterHeader, gridSourceFPN As String,
                              resultFPN As String, outCellSize As Single,
                              resmaplingMethod As cGdal.GdalResamplingMethod,
                              outFormat As cGdal.GdalFormat,
                              outDataType As cGdal.GdalDataType)
        Try
            If resultFPN = "" OrElse basegridHeader Is Nothing OrElse gridSourceFPN = "" OrElse outCellSize <= 0 Then Exit Sub
            Dim cellSize As Single = outCellSize
            Dim dType As String = GetGdalDataTypeNameToApply(outDataType)
            Dim ext As New cRasterExtent(basegridHeader)

            '여기서..ascii 출력이 안된다... 그래서 tiff로 작업하고, ascii로 바꾼다.
            Dim formatName As String = GdalFormat.GTiff.ToString
            Dim fpnTemp As String = resultFPN
            If outFormat = GdalFormat.AAIGrid Then
                fpnTemp = Replace(resultFPN, ".asc", ".tif")
            End If
            Dim GdalPath As String = Path.Combine(mGdalPath, "gdalwarp.exe")
            Dim prGdalGrid As New Process()
            prGdalGrid.StartInfo.FileName = GdalPath
            prGdalGrid.StartInfo.Arguments = " -te " + ext.left.ToString + " " + ext.bottom.ToString + " " +
                                                                 ext.right.ToString + " " + ext.top.ToString +
                                                     " -tr " + cellSize.ToString + " " + cellSize.ToString +
                                                     " -r " + resmaplingMethod.ToString +
                                                     " -dstnodata " + CStr(-9999) +
                                                     " -of " + cComTools.SetDQ(formatName) +
                                                     " -ot " + cComTools.SetDQ(dType) +
                                                     " --config GDAL_FILENAME_IS_UTF8 NO" +
                                                     " " + cComTools.SetDQ(gridSourceFPN) +
                                                     " " + cComTools.SetDQ(fpnTemp)
            prGdalGrid.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            prGdalGrid.Start()
            prGdalGrid.WaitForExit()
            prGdalGrid.Dispose()
            If outFormat = GdalFormat.AAIGrid Then
                cGdal.ConvertGtiffAndGribToASCII(fpnTemp, resultFPN, 1, outDataType)
                cFile.DeleteFileFriends(resultFPN)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Exclamation)
        End Try
    End Sub


    Public Shared Sub PolygonToRasterByFieldName(inshpFPN As String,
                                                       sourceFieldName As String,
                                                       resultFPN As String,
                                                       outFormat As cGdal.GdalFormat,
                                                       outDataType As cGdal.GdalDataType,
                                                       cellsize As Integer,
                                                       NoDataValue As Integer,
                                                       bUseAreaRatioMethod As Boolean)
        Try
            Dim fpnTemp As String = resultFPN
            Dim GdalPath As String = Path.Combine(mGdalPath, "gdal_rasterize.exe")
            Dim psGdalRasterize As New Process()
            Dim psinfo As New ProcessStartInfo
            psinfo.FileName = GdalPath
            psinfo.Arguments = " -a " + sourceFieldName +
                               " -of " + outFormat.ToString +
                             " -ot " + outDataType.ToString +
                              " -tr " + cellsize.ToString + " " + cellsize.ToString +
                              " -l " + System.IO.Path.GetFileNameWithoutExtension(inshpFPN) +
                              " -a_nodata " + NoDataValue.ToString +
                              " --config GDAL_FILENAME_IS_UTF8 NO" +
                              " " + inshpFPN + " " + resultFPN
            psinfo.WindowStyle = ProcessWindowStyle.Normal
            psinfo.WindowStyle = ProcessWindowStyle.Hidden
            psGdalRasterize.StartInfo = psinfo
            psGdalRasterize.Start()
            psGdalRasterize.WaitForExit()
            psGdalRasterize.Dispose()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class

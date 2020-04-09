Imports System.IO
Imports System.Text
Imports gentle

Public Class fCalculator

    Private mMathArg As String
    Private mMathArgEle() As String
    Private mfpnOut As String
    Private mNodataAsZeroASCa As Boolean = False
    Private mNodataAsZeroASCb As Boolean = False
    Private mNodataAsZeroASCc As Boolean = False
    Private mDecimalN As Integer = -1
    Private mStopProgress As Boolean = False
    Private WithEvents mfPrograssBar As fProgressBar


    Private Sub fCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub


    Private Sub btSelectAscFileA_Click(sender As Object, e As EventArgs) Handles btSelectAscFileA.Click

        If Me.chkMultiFiles.Checked Then
            Dim mfb As New FolderBrowserDialog
            If mfb.ShowDialog() = DialogResult.OK Then
                tbInFileA.Text = mfb.SelectedPath
            End If
        Else
            Dim mfb As New OpenFileDialog
            If mfb.ShowDialog() = DialogResult.OK Then
                tbInFileA.Text = mfb.FileName
            End If
        End If
    End Sub

    Private Sub btSelectAscFileB_Click(sender As Object, e As EventArgs) Handles btSelectAscFileB.Click
        Dim fb As New OpenFileDialog
        If fb.ShowDialog() = DialogResult.OK Then
            tbInFileB.Text = fb.FileName
        End If
    End Sub

    Private Sub btSelectAscFileC_Click(sender As Object, e As EventArgs) Handles btSelectAscFileC.Click
        Dim fb As New OpenFileDialog
        If fb.ShowDialog() = DialogResult.OK Then
            tbInFileC.Text = fb.FileName
        End If
    End Sub

    Private Sub btResultFPN_Click(sender As Object, e As EventArgs) Handles btResultFPN.Click


        If Me.chkMultiFiles.Checked Then
            Dim fb As New FolderBrowserDialog
            If fb.ShowDialog() = DialogResult.OK Then
                If Me.tbResultFPN.Text.Trim.ToLower = Me.tbInFileA.Text.Trim.ToLower Then
                    MsgBox(String.Format("Destination folder is equal to the source file folder. Select another folder."), MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
                tbResultFPN.Text = fb.SelectedPath
            End If
        Else
            Dim fb As New SaveFileDialog
            fb.DefaultExt = "asc"
            fb.Filter = "ESRI ASCII text files (*.asc)|*.asc|All files (*.*)|*.*"
            If fb.ShowDialog() = DialogResult.OK Then
                tbResultFPN.Text = fb.FileName
            End If
        End If


    End Sub

    Private Sub btStartCalc_Click(sender As Object, e As EventArgs) Handles btStartCalc.Click
        If Me.tbInFileA.Text.Trim = "" OrElse Me.tbResultFPN.Text.Trim = "" Then
            MsgBox(String.Format("Input files or an output file are not defined."), MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim mAscA As cAscRasterReader
        Dim mAscB As cAscRasterReader
        Dim mAscC As cAscRasterReader
        mfPrograssBar = New fProgressBar
        mStopProgress = False
        Try
            mMathArg = Me.tbEq.Text.Trim
            mMathArgEle = mMathArg.Split({" ", ",", "(", ")", "+", "-", "*", "/", "^", "=", ">", "<", ">=", "<="}, StringSplitOptions.RemoveEmptyEntries)
            mNodataAsZeroASCa = Me.chkNodataToZeroASC1.Checked
            mNodataAsZeroASCb = Me.chkNodataToZeroASC2.Checked
            mNodataAsZeroASCc = Me.chkNodataToZeroASC3.Checked
            Dim ifFirstAsc(,) As Double = Nothing
            Dim ifSecondAsc(,) As Double = Nothing
            Dim ifTrueAsc(,) As Double = Nothing
            Dim ifFalseAsc(,) As Double = Nothing
            Dim ifFirstV As Double
            Dim ifSecondV As Double
            Dim ifTrueV As Double
            Dim ifFalseV As Double
            Dim bIf1IsASC As Boolean = False
            Dim bIf2IsASC As Boolean = False
            Dim bIftrueIsASC As Boolean = False
            Dim bIffalseIsASC As Boolean = False
            Dim baseASC As cAscRasterReader = Nothing
            Dim lstFileA As New List(Of String)
            Dim FilePathForMultiFiles As String = ""
            Dim mfolderPathOut As String = ""
            If Me.chkMultiFiles.Checked Then
                Dim naCom As New NaturalComparer
                FilePathForMultiFiles = Me.tbInFileA.Text.Trim
                If Directory.Exists(FilePathForMultiFiles) Then
                    lstFileA = Directory.GetFiles(FilePathForMultiFiles).ToList
                    lstFileA.Sort(naCom)
                Else
                    MsgBox(String.Format("Source file folder was not selected."), MsgBoxStyle.Exclamation)
                    Exit Sub
                End If

                If Directory.Exists(Me.tbResultFPN.Text.Trim) Then
                    If Me.tbResultFPN.Text.Trim.ToLower = FilePathForMultiFiles.ToLower Then
                        MsgBox(String.Format("Destination folder is equal to the source file folder. Select another folder."), MsgBoxStyle.Exclamation)
                        Exit Sub
                    End If
                    mfolderPathOut = Me.tbResultFPN.Text.Trim
                Else
                    MsgBox(String.Format("Destination folder is not exist."), MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
            Else
                lstFileA.Add(tbInFileA.Text.Trim)
                mfpnOut = Me.tbResultFPN.Text.Trim
                If (Me.tbInFileA.Text.Trim <> "" AndAlso Me.tbInFileA.Text.Trim = mfpnOut.Trim()) OrElse
                    (Me.tbInFileB.Text.Trim <> "" AndAlso Me.tbInFileB.Text.Trim = mfpnOut.Trim()) OrElse
                    (Me.tbInFileB.Text.Trim <> "" AndAlso Me.tbInFileB.Text.Trim = mfpnOut.Trim()) Then
                    MsgBox(String.Format("The output file is same as an input file. Rename output file."), MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
                If File.Exists(mfpnOut) Then File.Delete(mfpnOut)
            End If

            Dim strProcessingMsg As String = ""
            mfPrograssBar.GRMToolsPrograssBar.Maximum = lstFileA.Count
            mfPrograssBar.GRMToolsPrograssBar.Style = ProgressBarStyle.Blocks
            mfPrograssBar.labGRMToolsPrograssBar.Text = "Processing 0/" & CStr(lstFileA.Count) & " file..."
            mfPrograssBar.Text = "Processing files"
            mfPrograssBar.Show()
            System.Windows.Forms.Application.DoEvents()

            For fn As Integer = 0 To lstFileA.Count - 1
                If File.Exists(lstFileA(fn).Trim) = True Then
                    mAscA = New cAscRasterReader(lstFileA(fn).Trim)
                    baseASC = mAscA
                    If Me.chkMultiFiles.Checked Then
                        mfpnOut = Path.Combine(mfolderPathOut, Path.GetFileName(lstFileA(fn).Trim))
                        If (File.Exists(mfpnOut)) Then File.Delete(mfpnOut)
                    End If
                End If
                If File.Exists(tbInFileB.Text.Trim) = True Then
                    mAscB = New cAscRasterReader(tbInFileB.Text.Trim)
                    If mAscA IsNot Nothing AndAlso cAscRasterReader.CheckTwoGridLayerExtentUsingRowAndColNum(mAscA, mAscB) = False Then
                        MsgBox(String.Format("File {0} and {1} have different region with each other.", "A", "B"), MsgBoxStyle.Information)
                        mfPrograssBar.Close()
                        Exit Sub
                    End If
                    If baseASC Is Nothing Then baseASC = mAscB
                End If
                If File.Exists(tbInFileC.Text.Trim) = True Then
                    mAscC = New cAscRasterReader(tbInFileC.Text.Trim)
                    If mAscA IsNot Nothing AndAlso cAscRasterReader.CheckTwoGridLayerExtentUsingRowAndColNum(mAscA, mAscC) = False Then
                        MsgBox(String.Format("File {0} and {1} have different region with each other.", "A", "C"), MsgBoxStyle.Information)
                        mfPrograssBar.Close()
                        Exit Sub
                    End If
                    If mAscB IsNot Nothing AndAlso cAscRasterReader.CheckTwoGridLayerExtentUsingRowAndColNum(mAscB, mAscC) = False Then
                        MsgBox(String.Format("File {0} and {1} have different region with each other.", "B", "C"), MsgBoxStyle.Information)
                        mfPrograssBar.Close()
                        Exit Sub
                    End If
                    If baseASC Is Nothing Then baseASC = mAscC
                End If

                If Me.tbDecimalPartN.Text.Trim() <> "" Then
                    mDecimalN = CInt(Me.tbDecimalPartN.Text)
                End If

                Dim headerStringAll As String = baseASC.HeaderStringAll
                Dim nColx As Integer = baseASC.Header.numberCols
                Dim nRowy As Integer = baseASC.Header.numberRows
                Dim nv As Double = baseASC.Header.nodataValue
                Dim resultArr(baseASC.Header.numberCols - 1, baseASC.Header.numberRows - 1) As Double
                If mMathArgEle(0).ToLower = "if" Then
                    Dim ArgTwoPart As String() = mMathArg.Split({"(", ")"}, StringSplitOptions.RemoveEmptyEntries)
                    Dim elementsInif As String() = ArgTwoPart(1).Split({","}, StringSplitOptions.RemoveEmptyEntries)
                    Dim elementsInCondition As String() = elementsInif(0).Split({" ", "=", ">", "<", ">=", "<="}, StringSplitOptions.RemoveEmptyEntries)
                    'Dim elementsInTrue As String() = elementsInif(1).Split({"+", "-", "*", "/", "^"}, StringSplitOptions.RemoveEmptyEntries)
                    'Dim elementsInFalse As String() = elementsInif(2).Split({" ", "+", "-", "*", "/", "^"}, StringSplitOptions.RemoveEmptyEntries)
                    Dim elementsInTrue As String() = cCalculator.SplitElementsInAlgebraicEquation(elementsInif(1), {"+", "-", "*", "/", "^"})
                    Dim elementsInFalse As String() = cCalculator.SplitElementsInAlgebraicEquation(elementsInif(2), {" ", "+", "-", "*", "/", "^"})

                    '===== condition  부분
                    Dim vc As Double = 0
                    Dim operatorInCondition As String = cCalculator.getOperatorFromString(elementsInif(0))
                    If Double.TryParse(elementsInCondition(0), vc) = True Then
                        ifFirstV = vc
                    Else
                        If elementsInCondition(0).ToLower = "a" Then ifFirstAsc = mAscA.ValuesFromTL
                        If elementsInCondition(0).ToLower = "b" Then ifFirstAsc = mAscB.ValuesFromTL
                        If elementsInCondition(0).ToLower = "c" Then ifFirstAsc = mAscC.ValuesFromTL
                        bIf1IsASC = True
                    End If
                    If Double.TryParse(elementsInCondition(1), vc) = True Then
                        ifSecondV = vc
                    Else
                        If elementsInCondition(1).ToLower = "a" Then ifSecondAsc = mAscA.ValuesFromTL
                        If elementsInCondition(1).ToLower = "b" Then ifSecondAsc = mAscB.ValuesFromTL
                        If elementsInCondition(1).ToLower = "c" Then ifSecondAsc = mAscC.ValuesFromTL
                        bIf2IsASC = True
                    End If
                    '======================================

                    '===== true 부분
                    If elementsInTrue.Length = 1 Then 'A . 하나만 있는 경우
                        If Double.TryParse(elementsInTrue(0), vc) = True Then
                            ifTrueV = vc
                        Else
                            If elementsInTrue(0).ToLower = "a" Then ifTrueAsc = mAscA.ValuesFromTL
                            If elementsInTrue(0).ToLower = "b" Then ifTrueAsc = mAscB.ValuesFromTL
                            If elementsInTrue(0).ToLower = "c" Then ifTrueAsc = mAscC.ValuesFromTL
                            bIftrueIsASC = True
                        End If
                    End If

                    If elementsInTrue.Length = 2 Then ' A +2 두개 항목 연산하는 경우
                        Dim t1V As Double = 0
                        Dim t1ASC(,) As Double = Nothing
                        Dim bt1ASC As Boolean = False
                        Dim t2V As Double = 0
                        Dim t2ASC(,) As Double = Nothing
                        Dim bt2ASC As Boolean = False
                        Dim bASC1noDataZero As Boolean = False
                        Dim bASC2noDataZero As Boolean = False
                        Dim operatorInTrue As String = cCalculator.getOperatorFromString(elementsInif(1))
                        If Double.TryParse(elementsInTrue(0), vc) = True Then
                            t1V = vc
                        Else
                            If elementsInTrue(0).ToLower = "a" Then
                                t1ASC = mAscA.ValuesFromTL
                                bASC1noDataZero = mNodataAsZeroASCa
                            End If
                            If elementsInTrue(0).ToLower = "b" Then
                                t1ASC = mAscB.ValuesFromTL
                                bASC1noDataZero = mNodataAsZeroASCb
                            End If
                            If elementsInTrue(0).ToLower = "c" Then
                                t1ASC = mAscC.ValuesFromTL
                                bASC1noDataZero = mNodataAsZeroASCc
                            End If
                            bt1ASC = True
                        End If

                        If Double.TryParse(elementsInTrue(1), vc) = True Then
                            t2V = vc
                        Else
                            If elementsInTrue(1).ToLower = "a" Then
                                t2ASC = mAscA.ValuesFromTL
                                bASC2noDataZero = mNodataAsZeroASCa
                            End If
                            If elementsInTrue(1).ToLower = "b" Then
                                t2ASC = mAscB.ValuesFromTL
                                bASC2noDataZero = mNodataAsZeroASCb
                            End If
                            If elementsInTrue(1).ToLower = "c" Then
                                t2ASC = mAscC.ValuesFromTL
                                bASC2noDataZero = mNodataAsZeroASCc
                            End If
                            bt2ASC = True
                        End If
                        '이 경우 true 값은 무조건 array 이다.
                        ifTrueAsc = cCalculator.calculate2DArryUsing2TermAlgebra(operatorInTrue, bt1ASC, bt2ASC,
                                                                                 bASC1noDataZero, bASC2noDataZero, t1ASC,
                                                                                 t2ASC, t1V, t2V, nv)
                        bIftrueIsASC = True
                    End If
                    '===============================================

                    '===== false 부분
                    If elementsInFalse.Length = 1 Then 'A . 하나만 있는 경우
                        If Double.TryParse(elementsInFalse(0), vc) = True Then
                            ifFalseV = vc
                        Else
                            If elementsInFalse(0).ToLower = "a" Then ifFalseAsc = mAscA.ValuesFromTL
                            If elementsInFalse(0).ToLower = "b" Then ifFalseAsc = mAscB.ValuesFromTL
                            If elementsInFalse(0).ToLower = "c" Then ifFalseAsc = mAscC.ValuesFromTL
                            bIffalseIsASC = True
                        End If
                    End If

                    If elementsInFalse.Length = 2 Then 'A +1. 두개 항목 연산하는 경우
                        Dim operatorInFalse As String = cCalculator.getOperatorFromString(elementsInif(2))
                        Dim f1V As Double = 0
                        Dim f1ASC(,) As Double = Nothing
                        Dim bf1ASC As Boolean = False
                        Dim f2V As Double = 0
                        Dim f2ASC(,) As Double = Nothing
                        Dim bf2ASC As Boolean = False
                        Dim bASC1noDataZero As Boolean = False
                        Dim bASC2noDataZero As Boolean = False
                        If Double.TryParse(elementsInFalse(0), vc) = True Then
                            f1V = vc
                        Else
                            If elementsInFalse(0).ToLower = "a" Then
                                f1ASC = mAscA.ValuesFromTL
                                bASC1noDataZero = mNodataAsZeroASCa
                            End If
                            If elementsInFalse(0).ToLower = "b" Then
                                f1ASC = mAscB.ValuesFromTL
                                bASC1noDataZero = mNodataAsZeroASCb
                            End If
                            If elementsInFalse(0).ToLower = "c" Then
                                f1ASC = mAscC.ValuesFromTL
                                bASC1noDataZero = mNodataAsZeroASCc
                            End If
                            bf1ASC = True
                        End If

                        If Double.TryParse(elementsInFalse(1), vc) = True Then
                            f2V = vc
                        Else
                            If elementsInFalse(1).ToLower = "a" Then
                                f2ASC = mAscA.ValuesFromTL
                                bASC2noDataZero = mNodataAsZeroASCa
                            End If
                            If elementsInFalse(1).ToLower = "b" Then
                                f2ASC = mAscB.ValuesFromTL
                                bASC2noDataZero = mNodataAsZeroASCb
                            End If
                            If elementsInFalse(1).ToLower = "c" Then
                                f2ASC = mAscC.ValuesFromTL
                                bASC2noDataZero = mNodataAsZeroASCc
                            End If
                            bf2ASC = True
                        End If
                        '이경우 false 값은 무조건 array 이다.
                        ifFalseAsc = cCalculator.calculate2DArryUsing2TermAlgebra(operatorInFalse, bf1ASC,
                                                                                  bf2ASC, bASC1noDataZero, bASC2noDataZero,
                                                                                  f1ASC, f2ASC, f1V, f2V, nv)
                        bIffalseIsASC = True

                    End If
                    resultArr = cCalculator.calculate2DArryUsingCondition(operatorInCondition, bIf1IsASC,
                                                                          bIf2IsASC, bIftrueIsASC, bIffalseIsASC,
                                                         ifFirstAsc, ifSecondAsc, ifTrueAsc, ifFalseAsc,
                                                          ifFirstV, ifSecondV, ifTrueV, ifFalseV, nv)
                Else
                    '    a + B  / pow, A, 0.5  / abs, A
                    If Trim(mMathArgEle(0)).ToLower = "pow" OrElse Trim(mMathArgEle(0)).ToLower = "abs" Then
                        Dim ftype As cData.MathFunctionType
                        Dim expV As Double
                        If Trim(mMathArgEle(0)).ToLower = "pow" Then
                            If mMathArgEle.Length <> 3 Then
                                MsgBox("Just 3 elements are allowed in math.pow calculation.   ", MsgBoxStyle.Information)
                                mfPrograssBar.Close()
                                Exit Sub
                            End If
                            ftype = cData.MathFunctionType.Pow
                            expV = CDbl(mMathArgEle(2))
                        ElseIf Trim(mMathArgEle(0)).ToLower = "abs" Then
                            If mMathArgEle.Length <> 2 Then
                                MsgBox("Just 2  elements are allowed in math.abs calculation.   ", MsgBoxStyle.Information)
                                mfPrograssBar.Close()
                                Exit Sub
                            End If
                            ftype = cData.MathFunctionType.Abs
                            expV = 1
                        End If
                        resultArr = cCalculator.calculate2DArryUsingMathFunction(mAscA.ValuesFromTL, ftype, expV)
                    Else
                        '        a + B
                        If mMathArgEle.Length > 2 Then
                            MsgBox("Just 2 elements and one operator are allowed in algebraic expression.   ", MsgBoxStyle.Information)
                            mfPrograssBar.Close()
                            Exit Sub
                        End If
                        Dim vc As Double = 0
                        Dim bASC1noDataZero As Boolean = False
                        Dim bASC2noDataZero As Boolean = False
                        If Double.TryParse(mMathArgEle(0), vc) = True Then
                            ifFirstV = vc
                        Else
                            If mMathArgEle(0).ToLower = "a" Then
                                ifFirstAsc = mAscA.ValuesFromTL
                                bASC1noDataZero = mNodataAsZeroASCa
                            End If
                            If mMathArgEle(0).ToLower = "b" Then
                                ifFirstAsc = mAscB.ValuesFromTL
                                bASC1noDataZero = mNodataAsZeroASCb
                            End If
                            If mMathArgEle(0).ToLower = "c" Then
                                ifFirstAsc = mAscC.ValuesFromTL
                                bASC1noDataZero = mNodataAsZeroASCc
                            End If
                            bIf1IsASC = True
                        End If
                        If Double.TryParse(mMathArgEle(1), vc) = True Then
                            ifSecondV = vc
                        Else
                            If mMathArgEle(1).ToLower = "a" Then
                                ifSecondAsc = mAscA.ValuesFromTL
                                bASC2noDataZero = mNodataAsZeroASCa
                            End If
                            If mMathArgEle(1).ToLower = "b" Then
                                ifSecondAsc = mAscB.ValuesFromTL
                                bASC2noDataZero = mNodataAsZeroASCb
                            End If
                            If mMathArgEle(1).ToLower = "c" Then
                                ifSecondAsc = mAscC.ValuesFromTL
                                bASC2noDataZero = mNodataAsZeroASCc
                            End If
                            bIf2IsASC = True
                        End If

                        Dim operatorInString As String = cCalculator.getOperatorFromString(mMathArg)
                        resultArr = cCalculator.calculate2DArryUsing2TermAlgebra(operatorInString, bIf1IsASC, bIf2IsASC,
                                                                             bASC1noDataZero, bASC2noDataZero, ifFirstAsc,
                                                                             ifSecondAsc, ifFirstV, ifSecondV)
                    End If
                End If
                cTextFile.MakeASCTextFile(mfpnOut, headerStringAll, resultArr, mDecimalN, mAscA.Header.nodataValue)
                Dim prjFPNSource As String = Path.Combine(Path.GetDirectoryName(lstFileA(fn).Trim),
                                                          Path.GetFileNameWithoutExtension(lstFileA(fn).Trim) + ".prj")
                If File.Exists(prjFPNSource) = True Then
                    Dim prjFPNout As String = Path.Combine(Path.GetDirectoryName(mfpnOut),
                                                           Path.GetFileNameWithoutExtension(mfpnOut) + ".prj")
                    If File.Exists(prjFPNout) = True Then
                        File.Delete(prjFPNout)
                    End If
                    File.Copy(prjFPNSource, prjFPNout)
                End If

                resultArr = Nothing
                If mAscA IsNot Nothing Then mAscA.Dispose()
                If mAscB IsNot Nothing Then mAscB.Dispose()
                If mAscC IsNot Nothing Then mAscC.Dispose()
                GC.Collect()

                mfPrograssBar.GRMToolsPrograssBar.Value = fn + 1
                mfPrograssBar.labGRMToolsPrograssBar.Text = strProcessingMsg + " " + CStr(fn + 1) + "/" & CStr(lstFileA.Count) & " file..."
                System.Windows.Forms.Application.DoEvents()
                If mStopProgress = True Then
                    MsgBox("Process was stopped..   ", MsgBoxStyle.Exclamation)
                    mfPrograssBar.Close()
                    Exit Sub
                End If
            Next
            mfPrograssBar.Close()
            MsgBox("Calculation was completed.   ", MsgBoxStyle.Information)
        Catch ex As Exception
            If mAscA IsNot Nothing Then mAscA.Dispose()
            If mAscB IsNot Nothing Then mAscB.Dispose()
            If mAscC IsNot Nothing Then mAscC.Dispose()
            GC.Collect()
            MsgBox(String.Format("An Error was occured. "), MsgBoxStyle.Exclamation)
            mfPrograssBar.Close()
            Exit Sub
        End Try
    End Sub


    Private Sub mProcess_StopProcess(ByVal sender As fProgressBar) Handles mfPrograssBar.StopProcess
        mStopProgress = True
    End Sub


    Private Sub btClose_Click(sender As Object, e As EventArgs) Handles btClose.Click
        MyBase.Close()
    End Sub

    Private Sub btHeip_Click(sender As Object, e As EventArgs) Handles btHeip.Click
        Dim str As String
        str = " - The algebraic equation has to contain 2 values (or variables) and one operator." + vbCrLf
        str = str + " - In conditional expression, [condition] term has to contain 2 values (or variables) and one condtion operator." + vbCrLf
        str = str + "   And also, [true] and [false] terms can contain up to 2 values (or variables) and one operator in each other." + vbCrLf
        str = str + " - Available operators are +, -, *, /, ^, >, <, =, >=, or <=." + vbCrLf
        str = str + " - Available math. operators are 'pow' and 'abs'." + vbCrLf
        str = str + " - Files have to be applied using the characters A(or a), B(or b), or C(or c)." + vbCrLf
        str = str + " - Only A raster file(s) can be used in math. calculation." + vbCrLf
        str = str + " - Calculating nodata values as 0 is just applied to the algrebraic eqations (algrebraic eqs. in conditional expression are included)." + vbCrLf
        str = str + "   If 'Calculate nodata as 0' option is checked, the nodata values in ascii raster files are converted into '0' automatically, " + vbCrLf
        str = str + "       and applied to calculation. " + vbCrLf
        str = str + "   All ascii raster files have to have the same nodata value." + vbCrLf
        str = str + "" + vbCrLf
        str = str + " (Usages)   (*** FoN means 'raster file or number'.). F means 'raster file'. N means 'number'." + vbCrLf
        str = str + "   - [FoN][operator][FoN]" + vbCrLf
        str = str + "   - if(condition, true value, false value)" + vbCrLf
        str = str + "     if([FoN][condition operator][FoN], [FoN][operator][FoN], [FoN][operator][FoN])" + vbCrLf
        str = str + "   - [math operator](F, N)" + vbCrLf
        str = str + "" + vbCrLf
        str = str + " (Examples)" + vbCrLf
        str = str + "   - A+1, A-B, A*B, A/2, A^3, etc." + vbCrLf
        str = str + "   - if(A>1, 0, B), if(A>=1, C, B), if(a<B, b, c), if(A<B, B+1, C^2), if(A<B, B, C+1), if(A<B, B+C, B-C), etc." + vbCrLf
        str = str + "   - pow(A, 0.5), pow(A, 3), abs(A), etc." + vbCrLf
        Dim fh As New fHelp
        fh.tbTextToShow.Text = str
        fh.tbTextToShow.Select(Len(str), 0)
        fh.Show()
    End Sub

    Private Sub tbResultFPN_TextChanged(sender As Object, e As EventArgs) Handles tbResultFPN.TextChanged

    End Sub

    Private Sub chkMultiFiles_CheckedChanged(sender As Object, e As EventArgs) Handles chkMultiFiles.CheckedChanged
        SetUI()
    End Sub

    Private Sub SetUI()
        Me.btSelectAscFileA.Text = "Select a file"
        Me.btResultFPN.Text = "Result file"
        If Me.chkMultiFiles.Checked Then
            Me.btSelectAscFileA.Text = "Select a folder"
            Me.btResultFPN.Text = "Destination folder"
        End If
    End Sub
End Class
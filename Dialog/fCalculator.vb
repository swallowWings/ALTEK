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

    Private Sub fCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btSelectAscFileA_Click(sender As Object, e As EventArgs) Handles btSelectAscFileA.Click
        Dim fb As New OpenFileDialog
        If fb.ShowDialog() = DialogResult.OK Then
            tbInFileA.Text = fb.FileName
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
        Dim fb As New SaveFileDialog
        If fb.ShowDialog() = DialogResult.OK Then
            tbResultFPN.Text = fb.FileName
        End If
    End Sub

    Private Sub btStartCalc_Click(sender As Object, e As EventArgs) Handles btStartCalc.Click
        Dim mAscA As cAscRasterReader
        Dim mAscB As cAscRasterReader
        Dim mAscC As cAscRasterReader
        Try
            mfpnOut = Me.tbResultFPN.Text.Trim
            If File.Exists(mfpnOut) Then File.Delete(mfpnOut)
            mMathArg = Me.tbEq.Text.Trim
            mMathArgEle = mMathArg.Split({" ", ",", "(", ")"}, StringSplitOptions.RemoveEmptyEntries)
            mNodataAsZeroASCa = Me.chkNodataToZeroASC1.Checked
            mNodataAsZeroASCb = Me.chkNodataToZeroASC2.Checked
            mNodataAsZeroASCc = Me.chkNodataToZeroASC3.Checked
            'Dim bIf As Boolean = False
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
            Dim bIffalseIASC As Boolean = False
            Dim baseASC As cAscRasterReader = Nothing
            If File.Exists(tbInFileA.Text.Trim) = True Then
                mAscA = New cAscRasterReader(tbInFileA.Text.Trim)
                baseASC = mAscA
            End If
            If File.Exists(tbInFileB.Text.Trim) = True Then
                mAscB = New cAscRasterReader(tbInFileB.Text.Trim)
                If mAscA IsNot Nothing AndAlso cAscRasterReader.CheckTwoGridLayerExtentUsingRowAndColNum(mAscA, mAscB) = False Then
                    MsgBox(String.Format("File {0} and {1} have different region with each other.", "A", "B"), MsgBoxStyle.Information)
                    Exit Sub
                End If
                If baseASC Is Nothing Then baseASC = mAscB
            End If
            If File.Exists(tbInFileC.Text.Trim) = True Then
                mAscC = New cAscRasterReader(tbInFileC.Text.Trim)
                If mAscA IsNot Nothing AndAlso cAscRasterReader.CheckTwoGridLayerExtentUsingRowAndColNum(mAscA, mAscC) = False Then
                    MsgBox(String.Format("File {0} and {1} have different region with each other.", "A", "C"), MsgBoxStyle.Information)
                    Exit Sub
                End If
                If mAscB IsNot Nothing AndAlso cAscRasterReader.CheckTwoGridLayerExtentUsingRowAndColNum(mAscB, mAscC) = False Then
                    MsgBox(String.Format("File {0} and {1} have different region with each other.", "B", "C"), MsgBoxStyle.Information)
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
                If mMathArgEle.Length > 10 Then
                    MsgBox("Maximum 9 elements are allowed in conditional expression.   ", MsgBoxStyle.Information)
                    Exit Sub
                End If
                'bIf = True
                Dim vc As Double = 0
                If Double.TryParse(mMathArgEle(1), vc) = True Then
                    ifFirstV = vc
                Else
                    If mMathArgEle(1).ToLower = "a" Then ifFirstAsc = mAscA.ValuesFromTL
                    If mMathArgEle(1).ToLower = "b" Then ifFirstAsc = mAscB.ValuesFromTL
                    If mMathArgEle(1).ToLower = "c" Then ifFirstAsc = mAscC.ValuesFromTL
                    bIf1IsASC = True
                End If
                If Double.TryParse(mMathArgEle(3), vc) = True Then
                    ifSecondV = vc
                Else
                    If mMathArgEle(3).ToLower = "a" Then ifSecondAsc = mAscA.ValuesFromTL
                    If mMathArgEle(3).ToLower = "b" Then ifSecondAsc = mAscB.ValuesFromTL
                    If mMathArgEle(3).ToLower = "c" Then ifSecondAsc = mAscC.ValuesFromTL
                    bIf2IsASC = True
                End If
                If mMathArgEle.Length = 6 Then
                    '        If (a < -9999, B, C)
                    '        0   1 2    3    4    5
                    If Double.TryParse(mMathArgEle(4), vc) = True Then
                        ifTrueV = vc
                    Else
                        If mMathArgEle(4).ToLower = "a" Then ifTrueAsc = mAscA.ValuesFromTL
                        If mMathArgEle(4).ToLower = "b" Then ifTrueAsc = mAscB.ValuesFromTL
                        If mMathArgEle(4).ToLower = "c" Then ifTrueAsc = mAscC.ValuesFromTL
                        bIftrueIsASC = True
                    End If
                    If Double.TryParse(mMathArgEle(5), vc) = True Then
                        ifFalseV = vc
                    Else
                        If mMathArgEle(5).ToLower = "a" Then ifFalseAsc = mAscA.ValuesFromTL
                        If mMathArgEle(5).ToLower = "b" Then ifFalseAsc = mAscB.ValuesFromTL
                        If mMathArgEle(5).ToLower = "c" Then ifFalseAsc = mAscC.ValuesFromTL
                        bIffalseIASC = True
                    End If
                End If

                If mMathArgEle.Length = 8 Then
                    If cCalculator.checkIsAlgebraicOperator(mMathArgEle(5)) = True Then
                        '        If (a < -9999,  B + 1,  C)
                        '        0   1 2    3     4  5  6  7

                        Dim t1V As Double = 0
                        Dim t1ASC(,) As Double = Nothing
                        Dim bt1ASC As Boolean = False
                        Dim t2V As Double = 0
                        Dim t2ASC(,) As Double = Nothing
                        Dim bt2ASC As Boolean = False
                        Dim bASC1noDataZero As Boolean = False
                        Dim bASC2noDataZero As Boolean = False

                        If Double.TryParse(mMathArgEle(4), vc) = True Then
                            t1V = vc
                        Else
                            If mMathArgEle(4).ToLower = "a" Then
                                t1ASC = mAscA.ValuesFromTL
                                bASC1noDataZero = mNodataAsZeroASCa
                            End If
                            If mMathArgEle(4).ToLower = "b" Then
                                t1ASC = mAscB.ValuesFromTL
                                bASC1noDataZero = mNodataAsZeroASCb
                            End If
                            If mMathArgEle(4).ToLower = "c" Then
                                t1ASC = mAscC.ValuesFromTL
                                bASC1noDataZero = mNodataAsZeroASCc
                            End If
                            bt1ASC = True
                        End If

                        If Double.TryParse(mMathArgEle(6), vc) = True Then
                            t2V = vc
                        Else
                            If mMathArgEle(6).ToLower = "a" Then
                                t2ASC = mAscA.ValuesFromTL
                                bASC2noDataZero = mNodataAsZeroASCa
                            End If
                            If mMathArgEle(6).ToLower = "b" Then
                                t2ASC = mAscB.ValuesFromTL
                                bASC2noDataZero = mNodataAsZeroASCb
                            End If
                            If mMathArgEle(6).ToLower = "c" Then
                                t2ASC = mAscC.ValuesFromTL
                                bASC2noDataZero = mNodataAsZeroASCc
                            End If
                            bt2ASC = True
                        End If
                        '이 경우 true 값은 무조건 array 이다.
                        ifTrueAsc = cCalculator.calculate2DArryUsing2TermAlgebra(mMathArgEle(5), bt1ASC, bt2ASC, bASC1noDataZero, bASC2noDataZero, t1ASC, t2ASC, t1V, t2V, nv)
                        bIftrueIsASC = True
                        If Double.TryParse(mMathArgEle(7), vc) = True Then
                            ifFalseV = vc
                        Else
                            If mMathArgEle(7).ToLower = "a" Then ifFalseAsc = mAscA.ValuesFromTL
                            If mMathArgEle(7).ToLower = "b" Then ifFalseAsc = mAscB.ValuesFromTL
                            If mMathArgEle(7).ToLower = "c" Then ifFalseAsc = mAscC.ValuesFromTL
                            bIffalseIASC = True
                        End If
                    End If

                    If cCalculator.checkIsAlgebraicOperator(mMathArgEle(6)) = True Then
                        '        If (a < -9999,  B, C  +  1)
                        '        0   1 2    3     4   5  6  7
                        Dim f1V As Double = 0
                        Dim f1ASC(,) As Double = Nothing
                        Dim bf1ASC As Boolean = False
                        Dim f2V As Double = 0
                        Dim f2ASC(,) As Double = Nothing
                        Dim bf2ASC As Boolean = False
                        Dim bASC1noDataZero As Boolean = False
                        Dim bASC2noDataZero As Boolean = False


                        If Double.TryParse(mMathArgEle(4), vc) = True Then
                            ifTrueV = vc
                        Else
                            If mMathArgEle(4).ToLower = "a" Then ifTrueAsc = mAscA.ValuesFromTL
                            If mMathArgEle(4).ToLower = "b" Then ifTrueAsc = mAscB.ValuesFromTL
                            If mMathArgEle(4).ToLower = "c" Then ifTrueAsc = mAscC.ValuesFromTL
                            bIftrueIsASC = True
                        End If

                        If Double.TryParse(mMathArgEle(5), vc) = True Then
                            f1V = vc
                        Else
                            If mMathArgEle(5).ToLower = "a" Then
                                f1ASC = mAscA.ValuesFromTL
                                bASC1noDataZero = mNodataAsZeroASCa
                            End If
                            If mMathArgEle(5).ToLower = "b" Then
                                f1ASC = mAscB.ValuesFromTL
                                bASC1noDataZero = mNodataAsZeroASCb
                            End If
                            If mMathArgEle(5).ToLower = "c" Then
                                f1ASC = mAscC.ValuesFromTL
                                bASC1noDataZero = mNodataAsZeroASCc
                            End If
                            bf1ASC = True
                        End If

                        If Double.TryParse(mMathArgEle(7), vc) = True Then
                            f2V = vc
                        Else
                            If mMathArgEle(7).ToLower = "a" Then
                                f2ASC = mAscA.ValuesFromTL
                                bASC2noDataZero = mNodataAsZeroASCa
                            End If
                            If mMathArgEle(7).ToLower = "b" Then
                                f2ASC = mAscB.ValuesFromTL
                                bASC2noDataZero = mNodataAsZeroASCb
                            End If
                            If mMathArgEle(7).ToLower = "c" Then
                                f2ASC = mAscC.ValuesFromTL
                                bASC2noDataZero = mNodataAsZeroASCc
                            End If
                            bf2ASC = True
                        End If
                        '이경우 false 값은 무조건 array 이다.
                        ifFalseAsc = cCalculator.calculate2DArryUsing2TermAlgebra(mMathArgEle(6), bf1ASC, bf2ASC, bASC1noDataZero, bASC2noDataZero, f1ASC, f2ASC, f1V, f2V, nv)
                        bIffalseIASC = True
                    End If
                End If

                If mMathArgEle.Length = 10 Then
                    '        If (a < -9999,  B + 1,  C - 2)
                    '        0   1 2    3     4  5  6  7 8 9
                    Dim t1V As Double = 0
                    Dim t1ASC(,) As Double = Nothing
                    Dim bt1ASC As Boolean = False
                    Dim t2V As Double = 0
                    Dim t2ASC(,) As Double = Nothing
                    Dim bt2ASC As Boolean = False
                    Dim f1V As Double = 0
                    Dim f1ASC(,) As Double = Nothing
                    Dim bf1ASC As Boolean = False
                    Dim f2V As Double = 0
                    Dim f2ASC(,) As Double = Nothing
                    Dim bf2ASC As Boolean = False

                    Dim bASC1noDataZero As Boolean = False
                    Dim bASC2noDataZero As Boolean = False

                    If Double.TryParse(mMathArgEle(4), vc) = True Then
                        t1V = vc
                    Else
                        If mMathArgEle(4).ToLower = "a" Then
                            t1ASC = mAscA.ValuesFromTL
                            bASC1noDataZero = mNodataAsZeroASCa
                        End If
                        If mMathArgEle(4).ToLower = "b" Then
                            t1ASC = mAscB.ValuesFromTL
                            bASC1noDataZero = mNodataAsZeroASCb
                        End If
                        If mMathArgEle(4).ToLower = "c" Then
                            t1ASC = mAscC.ValuesFromTL
                            bASC1noDataZero = mNodataAsZeroASCc
                        End If
                        bt1ASC = True
                    End If

                    If Double.TryParse(mMathArgEle(6), vc) = True Then
                        t2V = vc
                    Else
                        If mMathArgEle(6).ToLower = "a" Then
                            t2ASC = mAscA.ValuesFromTL
                            bASC2noDataZero = mNodataAsZeroASCa
                        End If
                        If mMathArgEle(6).ToLower = "b" Then
                            t2ASC = mAscB.ValuesFromTL
                            bASC2noDataZero = mNodataAsZeroASCb
                        End If
                        If mMathArgEle(6).ToLower = "c" Then
                            t2ASC = mAscC.ValuesFromTL
                            bASC2noDataZero = mNodataAsZeroASCc
                        End If
                        bt2ASC = True
                    End If
                    '이 경우 true 값은 무조건 array 이다.
                    ifTrueAsc = cCalculator.calculate2DArryUsing2TermAlgebra(mMathArgEle(5), bt1ASC, bt2ASC, bASC2noDataZero, bASC2noDataZero, t1ASC, t2ASC, t1V, t2V, nv)
                    bIftrueIsASC = True

                    If Double.TryParse(mMathArgEle(7), vc) = True Then
                        f1V = vc
                    Else
                        If mMathArgEle(7).ToLower = "a" Then
                            f1ASC = mAscA.ValuesFromTL
                            bASC1noDataZero = mNodataAsZeroASCa
                        End If
                        If mMathArgEle(7).ToLower = "b" Then
                            f1ASC = mAscB.ValuesFromTL
                            bASC1noDataZero = mNodataAsZeroASCb
                        End If
                        If mMathArgEle(7).ToLower = "c" Then
                            f1ASC = mAscC.ValuesFromTL
                            bASC1noDataZero = mNodataAsZeroASCc
                        End If
                        bf1ASC = True
                    End If

                    If Double.TryParse(mMathArgEle(9), vc) = True Then
                        f2V = vc
                    Else
                        If mMathArgEle(9).ToLower = "a" Then
                            f2ASC = mAscA.ValuesFromTL
                            bASC2noDataZero = mNodataAsZeroASCa
                        End If
                        If mMathArgEle(9).ToLower = "b" Then
                            f2ASC = mAscB.ValuesFromTL
                            bASC2noDataZero = mNodataAsZeroASCb
                        End If
                        If mMathArgEle(9).ToLower = "c" Then
                            f2ASC = mAscC.ValuesFromTL
                            bASC2noDataZero = mNodataAsZeroASCc
                        End If
                        bf2ASC = True
                    End If
                    '이경우 false 값은 무조건 array 이다.
                    ifFalseAsc = cCalculator.calculate2DArryUsing2TermAlgebra(mMathArgEle(8), bf1ASC, bf2ASC, bASC1noDataZero, bASC2noDataZero, f1ASC, f2ASC, f1V, f2V, nv)
                    bIffalseIASC = True
                End If

                resultArr = cCalculator.calculate2DArryUsingCondition(mMathArgEle(2), bIf1IsASC, bIf2IsASC, bIftrueIsASC, bIffalseIASC,
                                                     ifFirstAsc, ifSecondAsc, ifTrueAsc, ifFalseAsc,
                                                      ifFirstV, ifSecondV, ifTrueV, ifFalseV, nv)
            Else
                '        a + B
                '        0  1 2 
                If mMathArgEle.Length > 3 Then
                    MsgBox("Just 3 arguments elements are allowed in algebraic expression.   ", MsgBoxStyle.Information)
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
                If Double.TryParse(mMathArgEle(2), vc) = True Then
                    ifSecondV = vc
                Else
                    If mMathArgEle(2).ToLower = "a" Then
                        ifSecondAsc = mAscA.ValuesFromTL
                        bASC2noDataZero = mNodataAsZeroASCa
                    End If
                    If mMathArgEle(2).ToLower = "b" Then
                        ifSecondAsc = mAscB.ValuesFromTL
                        bASC2noDataZero = mNodataAsZeroASCb
                    End If
                    If mMathArgEle(2).ToLower = "c" Then
                        ifSecondAsc = mAscC.ValuesFromTL
                        bASC2noDataZero = mNodataAsZeroASCc
                    End If
                    bIf2IsASC = True
                End If

                resultArr = cCalculator.calculate2DArryUsing2TermAlgebra(mMathArgEle(1), bIf1IsASC, bIf2IsASC, bASC1noDataZero, bASC2noDataZero, ifFirstAsc, ifSecondAsc, ifFirstV, ifSecondV)
            End If
            cTextFile.MakeASCTextFile(mfpnOut, headerStringAll, resultArr, mDecimalN, mAscA.Header.nodataValue)
            resultArr = Nothing
            MsgBox("Calculation was completed.   ", MsgBoxStyle.Information)
            If mAscA IsNot Nothing Then mAscA.Dispose()
            If mAscB IsNot Nothing Then mAscB.Dispose()
            If mAscC IsNot Nothing Then mAscC.Dispose()
            GC.Collect()
        Catch ex As Exception
            If mAscA IsNot Nothing Then mAscA.Dispose()
            If mAscB IsNot Nothing Then mAscB.Dispose()
            If mAscC IsNot Nothing Then mAscC.Dispose()
            GC.Collect()
        End Try
    End Sub

    Private Sub btClose_Click(sender As Object, e As EventArgs) Handles btClose.Click
        MyBase.Close()
    End Sub

    Private Sub btHeip_Click(sender As Object, e As EventArgs) Handles btHeip.Click
        Dim str As String
        str = " - The algebraic equation has to contain 2 values (or variables) and one operator." + vbCrLf
        str = str + " - In conditional expression, [condition] term has to contain 2 values (or variables) and one condtion operator." + vbCrLf
        str = str + "   And also, [true] and [false] terms have to contain 2 values (or variables) and one operator in each other." + vbCrLf
        str = str + " - In the algebraic and conditional expressions, the [operator] and [file or number] have to be separated with a space." + vbCrLf
        str = str + " - Available operators are +, -, *, /, >, <, =, >=, or <=." + vbCrLf
        str = str + " - Files have to be applied using the characters A(or a), B(or b), or C(or c)." + vbCrLf
        str = str + " - Calculating nodata values as 0 is just applied to the algrebraic eqs. (algrebraic eqs. in conditional expression are included)," + vbCrLf
        str = str + "   nodata values in ascii raster files are converted into '0' automatically, and applied to calculation." + vbCrLf
        str = str + "   All ascii raster files have to have the same nodata value." + vbCrLf
        str = str + "" + vbCrLf
        str = str + " (Usages)  " + vbCrLf
        str = str + "   - [file or number][a space][operator][a space][file or number]" + vbCrLf
        str = str + "   - if(condition, true value, false value)" + vbCrLf
        str = str + "     if ([file or number][a space][condition][a space][file or number], " + vbCrLf
        str = str + "         [file or number][a space][operator][a space][file or number], [file or number][a space][operator][a space][file or number])" + vbCrLf
        str = str + "" + vbCrLf
        str = str + " (Examples)" + vbCrLf
        str = str + "   - A + 1       A - B             A * B          A / 2" + vbCrLf
        str = str + "   - if(A > 1, 0, B)    if(A >= 1, C, B)   if(a < B, b, c)   if(A < B, B + 1, C)   if(A < B, B, C + 1)   if(A < B, B + C, B - C)" + vbCrLf
        Dim fh As New fHelp
        fh.tbTextToShow.Text = str
        fh.tbTextToShow.Select(Len(str), 0)
        fh.Show()
    End Sub

    Private Sub tbResultFPN_TextChanged(sender As Object, e As EventArgs) Handles tbResultFPN.TextChanged

    End Sub
End Class
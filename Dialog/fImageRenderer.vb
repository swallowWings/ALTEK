Public Class fImageRenderer

    Private rendereType As cImg.RendererType
    Private distRenderer As cImg

    Private Sub fImageRenderer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If rbRisk.Checked Then
            rendereType = cImg.RendererType.Risk
        Else
            rendereType = cImg.RendererType.WaterDepth
        End If

        Call DrawRendererClass(rendereType)
        Me.nudMax.Enabled = False
        Me.nudMin.Enabled = False
        InitEqualintervalclassText()
    End Sub

    Private Sub InitEqualintervalclassText()
        Me.lb_ei_min.Text = " = x"
        Me.lb_ei_c1.Text = " < x <"
        Me.lb_ei_c2.Text = " ≤ x <"
        Me.lb_ei_c3.Text = " ≤ x <"
        Me.lb_ei_c4.Text = " ≤ x <"
        Me.lb_ei_c5.Text = " ≤ x <"
        Me.lb_ei_c6.Text = " ≤ x <"
        Me.lb_ei_c7.Text = " ≤ x <"
        Me.lb_ei_c8.Text = " ≤ x <"
        Me.lb_ei_c9.Text = " ≤ x <"
        Me.lb_ei_c10.Text = " ≤ x <"
        Me.lb_ei_c11.Text = " ≤ x <"
        Me.lb_ei_c12.Text = " ≤ x <"
        Me.lb_ei_c13.Text = " ≤ x <"
        Me.lb_ei_c14.Text = " ≤ x <"
        Me.lb_ei_c15.Text = " ≤ x <"
        Me.lb_ei_c16.Text = " ≤ x <"
        Me.lb_ei_c17.Text = " ≤ x <"
        Me.lb_ei_c18.Text = " ≤ x <"
        Me.lb_ei_c19.Text = " ≤ x <"
        Me.lb_ei_c20.Text = " ≤ x <"
        Me.lb_ei_max.Text = " ≤ x"
    End Sub

    Private Sub DrawRendererClass(rendererType As cImg.RendererType)
        distRenderer = New cImg(rendererType)
        '0 to 1
        pb_0_1_000.BackColor = distRenderer.iniColor(0)
        pb_0_1_000To005.BackColor = distRenderer.iniColor(1)
        pb_0_1_005.BackColor = distRenderer.iniColor(2)
        pb_0_1_010.BackColor = distRenderer.iniColor(3)
        pb_0_1_015.BackColor = distRenderer.iniColor(4)
        pb_0_1_020.BackColor = distRenderer.iniColor(5)
        pb_0_1_025.BackColor = distRenderer.iniColor(6)
        pb_0_1_030.BackColor = distRenderer.iniColor(7)
        pb_0_1_035.BackColor = distRenderer.iniColor(8)
        pb_0_1_040.BackColor = distRenderer.iniColor(9)
        pb_0_1_045.BackColor = distRenderer.iniColor(10)
        pb_0_1_050.BackColor = distRenderer.iniColor(11)
        pb_0_1_055.BackColor = distRenderer.iniColor(12)
        pb_0_1_060.BackColor = distRenderer.iniColor(13)
        pb_0_1_065.BackColor = distRenderer.iniColor(14)
        pb_0_1_070.BackColor = distRenderer.iniColor(15)
        pb_0_1_075.BackColor = distRenderer.iniColor(16)
        pb_0_1_080.BackColor = distRenderer.iniColor(17)
        pb_0_1_085.BackColor = distRenderer.iniColor(18)
        pb_0_1_090.BackColor = distRenderer.iniColor(19)
        pb_0_1_095.BackColor = distRenderer.iniColor(20)
        pb_0_1_100.BackColor = distRenderer.iniColor(21)

        '0 to 100
        pb_0_100_000.BackColor = distRenderer.iniColor(0)
        pb_0_100_000To005.BackColor = distRenderer.iniColor(1)
        pb_0_100_005.BackColor = distRenderer.iniColor(2)
        pb_0_100_010.BackColor = distRenderer.iniColor(3)
        pb_0_100_015.BackColor = distRenderer.iniColor(4)
        pb_0_100_020.BackColor = distRenderer.iniColor(5)
        pb_0_100_025.BackColor = distRenderer.iniColor(6)
        pb_0_100_030.BackColor = distRenderer.iniColor(7)
        pb_0_100_035.BackColor = distRenderer.iniColor(8)
        pb_0_100_040.BackColor = distRenderer.iniColor(9)
        pb_0_100_045.BackColor = distRenderer.iniColor(10)
        pb_0_100_050.BackColor = distRenderer.iniColor(11)
        pb_0_100_055.BackColor = distRenderer.iniColor(12)
        pb_0_100_060.BackColor = distRenderer.iniColor(13)
        pb_0_100_065.BackColor = distRenderer.iniColor(14)
        pb_0_100_070.BackColor = distRenderer.iniColor(15)
        pb_0_100_075.BackColor = distRenderer.iniColor(16)
        pb_0_100_080.BackColor = distRenderer.iniColor(17)
        pb_0_100_085.BackColor = distRenderer.iniColor(18)
        pb_0_100_090.BackColor = distRenderer.iniColor(19)
        pb_0_100_095.BackColor = distRenderer.iniColor(20)
        pb_0_100_100.BackColor = distRenderer.iniColor(21)

        '0 to 200
        pb_0_200_000.BackColor = distRenderer.iniColor(0)
        pb_0_200_000to2.BackColor = distRenderer.iniColor(1)
        pb_0_200_002.BackColor = distRenderer.iniColor(2)
        pb_0_200_005.BackColor = distRenderer.iniColor(3)
        pb_0_200_010.BackColor = distRenderer.iniColor(4)
        pb_0_200_015.BackColor = distRenderer.iniColor(5)
        pb_0_200_020.BackColor = distRenderer.iniColor(6)
        pb_0_200_025.BackColor = distRenderer.iniColor(7)
        pb_0_200_030.BackColor = distRenderer.iniColor(8)
        pb_0_200_035.BackColor = distRenderer.iniColor(9)
        pb_0_200_040.BackColor = distRenderer.iniColor(10)
        pb_0_200_045.BackColor = distRenderer.iniColor(11)
        pb_0_200_050.BackColor = distRenderer.iniColor(12)
        pb_0_200_060.BackColor = distRenderer.iniColor(13)
        pb_0_200_070.BackColor = distRenderer.iniColor(14)
        pb_0_200_080.BackColor = distRenderer.iniColor(15)
        pb_0_200_090.BackColor = distRenderer.iniColor(16)
        pb_0_200_100.BackColor = distRenderer.iniColor(17)
        pb_0_200_120.BackColor = distRenderer.iniColor(18)
        pb_0_200_140.BackColor = distRenderer.iniColor(19)
        pb_0_200_160.BackColor = distRenderer.iniColor(20)
        pb_0_200_200.BackColor = distRenderer.iniColor(21)

        '0 to 500
        pb_0_500_000.BackColor = distRenderer.iniColor(0)
        pb_0_500_000to5.BackColor = distRenderer.iniColor(1)
        pb_0_500_005.BackColor = distRenderer.iniColor(2)
        pb_0_500_010.BackColor = distRenderer.iniColor(3)
        pb_0_500_015.BackColor = distRenderer.iniColor(4)
        pb_0_500_020.BackColor = distRenderer.iniColor(5)
        pb_0_500_025.BackColor = distRenderer.iniColor(6)
        pb_0_500_030.BackColor = distRenderer.iniColor(7)
        pb_0_500_040.BackColor = distRenderer.iniColor(8)
        pb_0_500_050.BackColor = distRenderer.iniColor(9)
        pb_0_500_060.BackColor = distRenderer.iniColor(10)
        pb_0_500_070.BackColor = distRenderer.iniColor(11)
        pb_0_500_080.BackColor = distRenderer.iniColor(12)
        pb_0_500_100.BackColor = distRenderer.iniColor(13)
        pb_0_500_120.BackColor = distRenderer.iniColor(14)
        pb_0_500_140.BackColor = distRenderer.iniColor(15)
        pb_0_500_160.BackColor = distRenderer.iniColor(16)
        pb_0_500_200.BackColor = distRenderer.iniColor(17)
        pb_0_500_250.BackColor = distRenderer.iniColor(18)
        pb_0_500_300.BackColor = distRenderer.iniColor(19)
        pb_0_500_400.BackColor = distRenderer.iniColor(20)
        pb_0_500_500.BackColor = distRenderer.iniColor(21)

        '0 to 500
        pb_ei_min.BackColor = distRenderer.iniColor(0)
        pb_ei_c1.BackColor = distRenderer.iniColor(1)
        pb_ei_c2.BackColor = distRenderer.iniColor(2)
        pb_ei_c3.BackColor = distRenderer.iniColor(3)
        pb_ei_c4.BackColor = distRenderer.iniColor(4)
        pb_ei_c5.BackColor = distRenderer.iniColor(5)
        pb_ei_c6.BackColor = distRenderer.iniColor(6)
        pb_ei_c7.BackColor = distRenderer.iniColor(7)
        pb_ei_c8.BackColor = distRenderer.iniColor(8)
        pb_ei_c9.BackColor = distRenderer.iniColor(9)
        pb_ei_c10.BackColor = distRenderer.iniColor(10)
        pb_ei_c11.BackColor = distRenderer.iniColor(11)
        pb_ei_c12.BackColor = distRenderer.iniColor(12)
        pb_ei_c13.BackColor = distRenderer.iniColor(13)
        pb_ei_c14.BackColor = distRenderer.iniColor(14)
        pb_ei_c15.BackColor = distRenderer.iniColor(15)
        pb_ei_c16.BackColor = distRenderer.iniColor(16)
        pb_ei_c17.BackColor = distRenderer.iniColor(17)
        pb_ei_c18.BackColor = distRenderer.iniColor(18)
        pb_ei_c19.BackColor = distRenderer.iniColor(19)
        pb_ei_c20.BackColor = distRenderer.iniColor(20)
        pb_ei_max.BackColor = distRenderer.iniColor(21)
    End Sub

    Private Sub btOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btOK.Click
        DialogResult = Windows.Forms.DialogResult.OK
        Close()
    End Sub

    Private Sub btCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancel.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
        Close()
    End Sub

    Private Sub rbRisk_CheckedChanged(sender As Object, e As EventArgs) Handles rbRisk.CheckedChanged
        Call DrawRendererClass(cImg.RendererType.Risk)
    End Sub

    Private Sub rbDepth_CheckedChanged(sender As Object, e As EventArgs) Handles rbDepth.CheckedChanged
        Call DrawRendererClass(cImg.RendererType.WaterDepth)
    End Sub


    Private Sub rbEqualinterval_CheckedChanged(sender As Object, e As EventArgs) Handles rbEqualinterval.CheckedChanged
        If Me.rbEqualinterval.Checked Then
            Me.nudMax.Enabled = True
            Me.nudMin.Enabled = True
        Else
            Me.nudMax.Enabled = False
            Me.nudMin.Enabled = False
        End If
    End Sub

    Private Sub nudMin_ValueChanged(sender As Object, e As EventArgs) Handles nudMin.ValueChanged, nudMin.TextChanged
        If nudMin.Value < nudMax.Value Then
            changeRendererClassValue()
        End If
    End Sub

    Private Sub nudMax_ValueChanged(sender As Object, e As EventArgs) Handles nudMax.ValueChanged, nudMax.TextChanged
        If nudMin.Value < nudMax.Value Then
            changeRendererClassValue()
        End If
    End Sub

    Private Sub changeRendererClassValue()
        Dim minv As Single = CSng(Me.nudMin.Value)
        Dim maxv As Single = CSng(Me.nudMax.Value)
        Dim multiple As Single = 400 / maxv
        Dim upBound As Single
        Dim lowBound As Single
        Dim incremental As Single = (maxv - minv) / 20
        Me.lb_ei_min.Text = minv.ToString + " = x"
        lowBound = minv
        upBound = lowBound + incremental
        Me.lb_ei_c1.Text = lowBound.ToString("F2") + " < x <" + upBound.ToString("F2")
        lowBound = upBound
        upBound = lowBound + incremental
        Me.lb_ei_c2.Text = lowBound.ToString("F2") + " ≤ x <" + upBound.ToString("F2")
        lowBound = upBound
        upBound = lowBound + incremental
        Me.lb_ei_c3.Text = lowBound.ToString("F2") + " ≤ x <" + upBound.ToString("F2")
        lowBound = upBound
        upBound = lowBound + incremental
        Me.lb_ei_c4.Text = lowBound.ToString("F2") + " ≤ x <" + upBound.ToString("F2")
        lowBound = upBound
        upBound = lowBound + incremental
        Me.lb_ei_c5.Text = lowBound.ToString("F2") + " ≤ x <" + upBound.ToString("F2")
        lowBound = upBound
        upBound = lowBound + incremental
        Me.lb_ei_c6.Text = lowBound.ToString("F2") + " ≤ x <" + upBound.ToString("F2")
        lowBound = upBound
        upBound = lowBound + incremental
        Me.lb_ei_c7.Text = lowBound.ToString("F2") + " ≤ x <" + upBound.ToString("F2")
        lowBound = upBound
        upBound = lowBound + incremental
        Me.lb_ei_c8.Text = lowBound.ToString("F2") + " ≤ x <" + upBound.ToString("F2")
        lowBound = upBound
        upBound = lowBound + incremental
        Me.lb_ei_c9.Text = lowBound.ToString("F2") + " ≤ x <" + upBound.ToString("F2")
        lowBound = upBound
        upBound = lowBound + incremental
        Me.lb_ei_c10.Text = lowBound.ToString("F2") + " ≤ x <" + upBound.ToString("F2")
        lowBound = upBound
        upBound = lowBound + incremental
        Me.lb_ei_c11.Text = lowBound.ToString("F2") + " ≤ x <" + upBound.ToString("F2")
        lowBound = upBound
        upBound = lowBound + incremental
        Me.lb_ei_c12.Text = lowBound.ToString("F2") + " ≤ x <" + upBound.ToString("F2")
        lowBound = upBound
        upBound = lowBound + incremental
        Me.lb_ei_c13.Text = lowBound.ToString("F2") + " ≤ x <" + upBound.ToString("F2")
        lowBound = upBound
        upBound = lowBound + incremental
        Me.lb_ei_c14.Text = lowBound.ToString("F2") + " ≤ x <" + upBound.ToString("F2")
        lowBound = upBound
        upBound = lowBound + incremental
        Me.lb_ei_c15.Text = lowBound.ToString("F2") + " ≤ x <" + upBound.ToString("F2")
        lowBound = upBound
        upBound = lowBound + incremental
        Me.lb_ei_c16.Text = lowBound.ToString("F2") + " ≤ x <" + upBound.ToString("F2")
        lowBound = upBound
        upBound = lowBound + incremental
        Me.lb_ei_c17.Text = lowBound.ToString("F2") + " ≤ x <" + upBound.ToString("F2")
        lowBound = upBound
        upBound = lowBound + incremental
        Me.lb_ei_c18.Text = lowBound.ToString("F2") + " ≤ x <" + upBound.ToString("F2")
        lowBound = upBound
        upBound = lowBound + incremental
        Me.lb_ei_c19.Text = lowBound.ToString("F2") + " ≤ x <" + upBound.ToString("F2")
        lowBound = upBound
        upBound = lowBound + incremental
        Me.lb_ei_c20.Text = lowBound.ToString("F2") + " ≤ x <" + upBound.ToString("F2")
        lowBound = upBound
        upBound = lowBound + incremental
        Me.lb_ei_max.Text = lowBound.ToString("F2") + " ≤ x"
    End Sub


End Class
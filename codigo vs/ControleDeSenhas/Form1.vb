Public Class frmControleSenha

    Dim valor As Integer
    Dim milhar As Integer
    Dim centena As Integer
    Dim dezena As Integer
    Dim unidade As Integer

    Private Sub btnIncrementar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIncrementar.Click
        Dim valor As Integer

        valor = CInt(lblAtualizaSenhaN.Text) + 1

        If valor >= 999 Then
            valor = 999
        End If

        lblAtualizaSenhaN.Text = valor.ToString

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo ErroAbertura
        Dim x As Integer
        SerialPort1.Open()
        SerialPort2.Open()
        Exit Sub
ErroAbertura:
        x = MsgBox("Erro ao abrir a porta serial. Verifique...", MsgBoxStyle.OkOnly, "Erro de Hardware")
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Dim i As Integer

        'Recebimento do PIC 1
        If SerialPort1.BytesToRead > 0 Then
            txtMsgRecebida.Text = ""
            txtMsgRecebida.Text = SerialPort1.ReadExisting
            If Len(txtMsgRecebida.Text) > 0 Then
                If Mid(txtMsgRecebida.Text, 3, 1) = "1" Then
                    i = Mid(txtMsgRecebida.Text, 4, 3)
                    lblSenhaN.Text = i
                    lblAtualizaSenhaN.Text = i
                End If
                If Mid(txtMsgRecebida.Text, 3, 1) = "2" Then
                    i = Mid(txtMsgRecebida.Text, 4, 3)
                    lblSenhaP.Text = i
                    lblAtualizaSenhaP.Text = i
                End If
            End If
        End If

    End Sub

    Private Sub btnIncPrioritario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIncPrioritario.Click
        Dim valor As Integer

        valor = CInt(lblAtualizaSenhaP.Text) + 1

        If valor >= 999 Then
            valor = 999
        End If

        lblAtualizaSenhaP.Text = valor.ToString
    End Sub

    Private Sub btnRepetir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRepetir.Click

        Dim serial2 As Boolean

        'txtMensagem.Text = 4000
        'valor = txtMensagem.Text * 1

        'If serial2 = True Then
        'txtMensagem.Clear()
        'End If

        'If serial2 = True Then
        'txtMensagem.Text = txtMensagem.Text & Trim(Str(milhar))
        'End If


    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        lblAtualizaSenhaN.Text = "0"
    End Sub

    Private Sub btnResetPr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResetPr.Click
        lblAtualizaSenhaP.Text = "0"
    End Sub

    Private Sub btnResetAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResetAll.Click
        lblAtualizaSenhaN.Text = "0"
        lblAtualizaSenhaP.Text = "0"
    End Sub

    Private Sub btnN1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnN1.Click
        If txtValorNormal.Text.Length < 3 Then
            txtValorNormal.Text = txtValorNormal.Text + "1"
        End If

    End Sub

    Private Sub btnN2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnN2.Click
        If txtValorNormal.Text.Length < 3 Then
            txtValorNormal.Text = txtValorNormal.Text + "2"
        End If
    End Sub

    Private Sub btnN3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnN3.Click
        If txtValorNormal.Text.Length < 3 Then
            txtValorNormal.Text = txtValorNormal.Text + "3"
        End If
    End Sub

    Private Sub btnN4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnN4.Click
        If txtValorNormal.Text.Length < 3 Then
            txtValorNormal.Text = txtValorNormal.Text + "4"
        End If
    End Sub

    Private Sub btnN5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnN5.Click
        If txtValorNormal.Text.Length < 3 Then
            txtValorNormal.Text = txtValorNormal.Text + "5"
        End If
    End Sub

    Private Sub btnN6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnN6.Click
        If txtValorNormal.Text.Length < 3 Then
            txtValorNormal.Text = txtValorNormal.Text + "6"
        End If
    End Sub

    Private Sub btnN7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnN7.Click
        If txtValorNormal.Text.Length < 3 Then
            txtValorNormal.Text = txtValorNormal.Text + "7"
        End If
    End Sub

    Private Sub btnN8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnN8.Click
        If txtValorNormal.Text.Length < 3 Then
            txtValorNormal.Text = txtValorNormal.Text + "8"
        End If
    End Sub

    Private Sub btnN9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnN9.Click
        If txtValorNormal.Text.Length < 3 Then
            txtValorNormal.Text = txtValorNormal.Text + "9"
        End If
    End Sub

    Private Sub btnN0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnN0.Click
        If txtValorNormal.Text.Length < 3 Then
            txtValorNormal.Text = txtValorNormal.Text + "0"
        End If
    End Sub

    Private Sub btnNAtt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNAtt.Click

        lblAtualizaSenhaN.Text = txtValorNormal.Text

        txtValorNormal.Text = ""
    End Sub

    Private Sub btnP1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnP1.Click
        If txtValorPrt.Text.Length < 3 Then
            txtValorPrt.Text = txtValorPrt.Text + "1"
        End If

    End Sub

    Private Sub btnP2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnP2.Click
        If txtValorPrt.Text.Length < 3 Then
            txtValorPrt.Text = txtValorPrt.Text + "2"
        End If
    End Sub

    Private Sub btnP3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnP3.Click
        If txtValorPrt.Text.Length < 3 Then
            txtValorPrt.Text = txtValorPrt.Text + "3"
        End If
    End Sub

    Private Sub btnP4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnP4.Click
        If txtValorPrt.Text.Length < 3 Then
            txtValorPrt.Text = txtValorPrt.Text + "4"
        End If
    End Sub

    Private Sub btnP5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnP5.Click
        If txtValorPrt.Text.Length < 3 Then
            txtValorPrt.Text = txtValorPrt.Text + "5"
        End If
    End Sub

    Private Sub btnP6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnP6.Click
        If txtValorPrt.Text.Length < 3 Then
            txtValorPrt.Text = txtValorPrt.Text + "6"
        End If
    End Sub

    Private Sub btnP7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnP7.Click
        If txtValorPrt.Text.Length < 3 Then
            txtValorPrt.Text = txtValorPrt.Text + "7"
        End If
    End Sub

    Private Sub btnP8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnP8.Click
        If txtValorPrt.Text.Length < 3 Then
            txtValorPrt.Text = txtValorPrt.Text + "8"
        End If
    End Sub

    Private Sub btnP9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnP9.Click
        If txtValorPrt.Text.Length < 3 Then
            txtValorPrt.Text = txtValorPrt.Text + "9"
        End If
    End Sub

    Private Sub btnP0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnP0.Click
        If txtValorPrt.Text.Length < 3 Then
            txtValorPrt.Text = txtValorPrt.Text + "0"
        End If
    End Sub

    Private Sub btnPAtt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPAtt.Click
        lblAtualizaSenhaP.Text = txtValorPrt.Text

        txtValorPrt.Text = ""
    End Sub

    Private Sub btnApagaTextoN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApagaTextoN.Click
        If txtValorNormal.Text.Length <> 0 Then
            txtValorNormal.Text = txtValorNormal.Text.Remove(txtValorNormal.Text.Length - 1, 1)
        End If
    End Sub

    Private Sub btnEnviaSenhaN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviaSenhaN.Click
        If SerialPort2.IsOpen() = True Then
            lblSenhaN.Text = lblAtualizaSenhaN.Text
        End If
    End Sub

    Private Sub btnEnviaSenhaP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviaSenhaP.Click
        If SerialPort2.IsOpen() = True Then
            lblSenhaP.Text = lblAtualizaSenhaP.Text
        End If
    End Sub

    Private Sub btnApagaTextoP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApagaTextoP.Click
        If txtValorPrt.Text.Length <> 0 Then
            txtValorPrt.Text = txtValorPrt.Text.Remove(txtValorPrt.Text.Length - 1, 1)
        End If
    End Sub

    Private Sub btnDecrNormal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDecrNormal.Click
        Dim valor As Integer

        valor = CInt(lblAtualizaSenhaN.Text) - 1

        If valor <= 0 Then
            valor = 0
        End If

        lblAtualizaSenhaN.Text = valor.ToString
    End Sub

    Private Sub btnDecrPriorit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDecrPriorit.Click
        Dim valor As Integer

        valor = CInt(lblAtualizaSenhaP.Text) - 1

        If valor <= 0 Then
            valor = 0
        End If

        lblAtualizaSenhaP.Text = valor.ToString
    End Sub

    Private Sub lblAtualizaSenhaN_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblAtualizaSenhaN.TextChanged
        Dim valor As Integer

        valor = CInt(lblAtualizaSenhaN.Text)

        If valor <= 0 Then
            btnDecrNormal.Enabled = False
        Else
            btnDecrNormal.Enabled = True
        End If

        If valor >= 999 Then
            btnIncrementar.Enabled = False
        Else
            btnIncrementar.Enabled = True
        End If

    End Sub

    Private Sub lblAtualizaSenhaP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblAtualizaSenhaP.TextChanged
        Dim valorP As Integer

        valorP = CInt(lblAtualizaSenhaP.Text)

        If valorP <= 0 Then
            btnDecrPriorit.Enabled = False
        Else
            btnDecrPriorit.Enabled = True
        End If

        If valorP >= 999 Then
            btnIncPrioritario.Enabled = False
        Else
            btnIncPrioritario.Enabled = True
        End If
    End Sub

    Private Sub btnCopiaSenhaN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopiaSenhaN.Click
        lblAtualizaSenhaN.Text = lblSenhaN.Text
    End Sub

    Private Sub btnCopiaSenhaP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopiaSenhaP.Click
        lblAtualizaSenhaP.Text = lblSenhaP.Text
    End Sub

    Private Sub EvAtualizaSenhaN(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSenhaN.TextChanged
        Dim senha As Integer

        senha = 1000 + CInt(lblSenhaN.Text)

        If (SerialPort2.IsOpen() = True) Then
            Timer2.Enabled = True
            valor = senha
            milhar = valor \ 1000
            centena = (valor - milhar * 1000) \ 100
            dezena = ((valor - (milhar * 1000)) - (centena * 100)) \ 10
            unidade = valor - (milhar * 1000) - (centena * 100) - (dezena * 10)

            txtMensagem.Text = Trim(Str(senha)) + "/"
        End If

        If (SerialPort1.IsOpen() = True) Then
            Timer2.Enabled = True
            valor = senha

            milhar = valor \ 1000
            centena = (valor - milhar * 1000) \ 100
            dezena = ((valor - (milhar * 1000)) - (centena * 100)) \ 10
            unidade = valor - (milhar * 1000) - (centena * 100) - (dezena * 10)

            txtMsgRecebida.Text = Trim(Str(senha)) + "/"
        End If

    End Sub

    Private Sub EvAtualizarSenhaP(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSenhaP.TextChanged
        Dim senha As Integer

        senha = 2000 + CInt(lblSenhaP.Text)

        If SerialPort2.IsOpen() = True Then
            Timer2.Enabled = True
            valor = senha
            milhar = valor \ 1000
            centena = (valor - milhar * 1000) \ 100
            dezena = ((valor - (milhar * 1000)) - (centena * 100)) \ 10
            unidade = valor - (milhar * 1000) - (centena * 100) - (dezena * 10)

            txtMensagem.Text = Trim(Str(senha)) + "/"
        End If

        If SerialPort1.IsOpen() = True Then
            Timer2.Enabled = True
            valor = senha

            milhar = valor \ 1000
            centena = (valor - milhar * 1000) \ 100
            dezena = ((valor - (milhar * 1000)) - (centena * 100)) \ 10
            unidade = valor - (milhar * 1000) - (centena * 100) - (dezena * 10)

            txtMsgRecebida.Text = Trim(Str(senha)) + "/"
        End If

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick

        SerialPort2.Write(Trim(Str(milhar)))
        SerialPort1.Write(Trim(Str(milhar)))
        Timer2.Enabled = False
        Timer3.Enabled = True
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick

        SerialPort2.Write(Trim(Str(centena)))
        SerialPort1.Write(Trim(Str(centena)))
        Timer3.Enabled = False
        Timer4.Enabled = True
    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick

        SerialPort2.Write(Trim(Str(dezena)))
        SerialPort1.Write(Trim(Str(dezena)))
        Timer4.Enabled = False
        Timer5.Enabled = True
    End Sub

    Private Sub Timer5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer5.Tick

        SerialPort2.Write(Trim(Str(unidade)))
        SerialPort1.Write(Trim(Str(unidade)))
        Timer5.Enabled = False
        Timer6.Enabled = True
    End Sub

    Private Sub Timer6_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer6.Tick

        SerialPort2.Write("/")
        SerialPort1.Write("/")
        Timer6.Enabled = False
    End Sub
End Class

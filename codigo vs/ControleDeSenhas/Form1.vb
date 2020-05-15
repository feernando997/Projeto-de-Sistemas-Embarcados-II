Public Class Form1


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
        x = MsgBox("Erro ao abrir a porta serial COM4. Verifique...", MsgBoxStyle.OkOnly, "Erro de Hardware")
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        On Error GoTo saidaTimer

        Dim x As Integer
        Dim i As Integer

        'Recebimento do PIC 1
        If SerialPort1.BytesToRead > 0 Then
            txtMsgRecebida.Text = ""
            txtMsgRecebida.Text = SerialPort1.ReadExisting
            If Len(txtMsgRecebida.Text) > 0 Then
                If Mid(txtMsgRecebida.Text, 1, 1) = "1" Then
                    i = Mid(txtMsgRecebida.Text, 5, 3)
                    lblSenhaN.Text = i
                    lblAtualizaSenhaN.Text = i
                End If
                If Mid(txtMsgRecebida.Text, 1, 1) = "2" Then
                    i = Mid(txtMsgRecebida.Text, 5, 3)
                    lblSenhaP.Text = i
                    lblAtualizaSenhaP.Text = i
                End If
            End If
        End If

        Exit Sub
saidaTimer:
        x = MsgBox("Erro ao ler porta COM3", MsgBoxStyle.OkOnly, "Erro de Hardware")
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
        If SerialPort2.IsOpen() = True Then
            SerialPort2.Write("RP")
        End If
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

            If lblAtualizaSenhaN.Text.Length = 1 Then
                SerialPort2.Write("100" + lblAtualizaSenhaN.Text + "/")
            End If

            If lblAtualizaSenhaN.Text.Length = 2 Then
                SerialPort2.Write("10" + lblAtualizaSenhaN.Text + "/")
            End If

            If lblAtualizaSenhaN.Text.Length = 3 Then
                SerialPort2.Write("1" + lblAtualizaSenhaN.Text + "/")
            End If

            txtMensagem.Text = "1" + lblAtualizaSenhaN.Text + "/"
            lblSenhaN.Text = lblAtualizaSenhaN.Text
        End If
    End Sub

    Private Sub btnEnviaSenhaP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviaSenhaP.Click
        If SerialPort2.IsOpen() = True Then
            If lblAtualizaSenhaP.Text.Length = 1 Then
                SerialPort2.Write("200" + lblAtualizaSenhaP.Text + "/")
            End If

            If lblAtualizaSenhaP.Text.Length = 2 Then
                SerialPort2.Write("20" + lblAtualizaSenhaP.Text + "/")
            End If

            If lblAtualizaSenhaP.Text.Length = 3 Then
                SerialPort2.Write("2" + lblAtualizaSenhaP.Text + "/")
            End If

            txtMensagem.Text = "2" + lblAtualizaSenhaP.Text + "/"
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
        If SerialPort2.IsOpen() = True Then
            If lblSenhaN.Text.Length = 1 Then
                SerialPort2.Write("100" + lblSenhaN.Text + "/")
            End If
            If lblSenhaN.Text.Length = 2 Then
                SerialPort2.Write("10" + lblSenhaN.Text + "/")
            End If
            If lblSenhaN.Text.Length = 3 Then
                SerialPort2.Write("1" + lblSenhaN.Text + "/")
            End If
        End If
    End Sub

    Private Sub EvAtualizarSenhaP(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSenhaP.TextChanged
        If SerialPort2.IsOpen() = True Then
            If lblSenhaP.Text.Length = 1 Then
                SerialPort2.Write("200" + lblSenhaP.Text + "/")
            End If
            If lblSenhaP.Text.Length = 2 Then
                SerialPort2.Write("20" + lblSenhaP.Text + "/")
            End If
            If lblSenhaP.Text.Length = 3 Then
                SerialPort2.Write("2" + lblSenhaP.Text + "/")
            End If
        End If
    End Sub
End Class

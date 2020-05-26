<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmControleSenha
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmControleSenha))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnDecrPriorit = New System.Windows.Forms.Button()
        Me.btnDecrNormal = New System.Windows.Forms.Button()
        Me.btnRepetir = New System.Windows.Forms.Button()
        Me.btnIncPrioritario = New System.Windows.Forms.Button()
        Me.btnIncrementar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnResetAll = New System.Windows.Forms.Button()
        Me.btnResetPr = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnCopiaSenhaP = New System.Windows.Forms.Button()
        Me.btnCopiaSenhaN = New System.Windows.Forms.Button()
        Me.lblSenhaP = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblSenhaN = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnP0 = New System.Windows.Forms.Button()
        Me.btnN0 = New System.Windows.Forms.Button()
        Me.btnApagaTextoP = New System.Windows.Forms.Button()
        Me.btnApagaTextoN = New System.Windows.Forms.Button()
        Me.btnPAtt = New System.Windows.Forms.Button()
        Me.btnP9 = New System.Windows.Forms.Button()
        Me.txtValorPrt = New System.Windows.Forms.TextBox()
        Me.txtValorNormal = New System.Windows.Forms.TextBox()
        Me.btnP8 = New System.Windows.Forms.Button()
        Me.btnP7 = New System.Windows.Forms.Button()
        Me.btnP6 = New System.Windows.Forms.Button()
        Me.btnP5 = New System.Windows.Forms.Button()
        Me.btnP4 = New System.Windows.Forms.Button()
        Me.btnP3 = New System.Windows.Forms.Button()
        Me.btnP2 = New System.Windows.Forms.Button()
        Me.btnP1 = New System.Windows.Forms.Button()
        Me.btnNAtt = New System.Windows.Forms.Button()
        Me.btnN9 = New System.Windows.Forms.Button()
        Me.btnN8 = New System.Windows.Forms.Button()
        Me.btnN7 = New System.Windows.Forms.Button()
        Me.btnN6 = New System.Windows.Forms.Button()
        Me.btnN5 = New System.Windows.Forms.Button()
        Me.btnN4 = New System.Windows.Forms.Button()
        Me.btnN3 = New System.Windows.Forms.Button()
        Me.btnN2 = New System.Windows.Forms.Button()
        Me.btnN1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnEnviaSenhaP = New System.Windows.Forms.Button()
        Me.btnEnviaSenhaN = New System.Windows.Forms.Button()
        Me.lblAtualizaSenhaP = New System.Windows.Forms.Label()
        Me.lblAtualizaSenhaN = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SerialPort2 = New System.IO.Ports.SerialPort(Me.components)
        Me.txtMensagem = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtMsgRecebida = New System.Windows.Forms.TextBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer6 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer7 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnDecrPriorit)
        Me.GroupBox1.Controls.Add(Me.btnDecrNormal)
        Me.GroupBox1.Controls.Add(Me.btnRepetir)
        Me.GroupBox1.Controls.Add(Me.btnIncPrioritario)
        Me.GroupBox1.Controls.Add(Me.btnIncrementar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(220, 117)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Incrementos"
        '
        'btnDecrPriorit
        '
        Me.btnDecrPriorit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDecrPriorit.Location = New System.Drawing.Point(89, 48)
        Me.btnDecrPriorit.Name = "btnDecrPriorit"
        Me.btnDecrPriorit.Size = New System.Drawing.Size(123, 23)
        Me.btnDecrPriorit.TabIndex = 6
        Me.btnDecrPriorit.Text = "Decrementar prioritario"
        Me.btnDecrPriorit.UseVisualStyleBackColor = True
        '
        'btnDecrNormal
        '
        Me.btnDecrNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDecrNormal.Location = New System.Drawing.Point(6, 48)
        Me.btnDecrNormal.Name = "btnDecrNormal"
        Me.btnDecrNormal.Size = New System.Drawing.Size(81, 23)
        Me.btnDecrNormal.TabIndex = 5
        Me.btnDecrNormal.Text = "Decrementar"
        Me.btnDecrNormal.UseVisualStyleBackColor = True
        '
        'btnRepetir
        '
        Me.btnRepetir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRepetir.Location = New System.Drawing.Point(71, 77)
        Me.btnRepetir.Name = "btnRepetir"
        Me.btnRepetir.Size = New System.Drawing.Size(75, 23)
        Me.btnRepetir.TabIndex = 4
        Me.btnRepetir.Text = "Repetir"
        Me.btnRepetir.UseVisualStyleBackColor = True
        '
        'btnIncPrioritario
        '
        Me.btnIncPrioritario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIncPrioritario.Location = New System.Drawing.Point(89, 19)
        Me.btnIncPrioritario.Name = "btnIncPrioritario"
        Me.btnIncPrioritario.Size = New System.Drawing.Size(123, 23)
        Me.btnIncPrioritario.TabIndex = 1
        Me.btnIncPrioritario.Text = "Incrementar prioritário"
        Me.btnIncPrioritario.UseVisualStyleBackColor = True
        '
        'btnIncrementar
        '
        Me.btnIncrementar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIncrementar.Location = New System.Drawing.Point(6, 19)
        Me.btnIncrementar.Name = "btnIncrementar"
        Me.btnIncrementar.Size = New System.Drawing.Size(81, 23)
        Me.btnIncrementar.TabIndex = 0
        Me.btnIncrementar.Text = "Incrementar"
        Me.btnIncrementar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnResetAll)
        Me.GroupBox2.Controls.Add(Me.btnResetPr)
        Me.GroupBox2.Controls.Add(Me.btnReset)
        Me.GroupBox2.Location = New System.Drawing.Point(238, 237)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(306, 122)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resets"
        '
        'btnResetAll
        '
        Me.btnResetAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResetAll.Location = New System.Drawing.Point(91, 76)
        Me.btnResetAll.Name = "btnResetAll"
        Me.btnResetAll.Size = New System.Drawing.Size(101, 23)
        Me.btnResetAll.TabIndex = 2
        Me.btnResetAll.Text = "Resetar tudo"
        Me.btnResetAll.UseVisualStyleBackColor = True
        '
        'btnResetPr
        '
        Me.btnResetPr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResetPr.Location = New System.Drawing.Point(149, 37)
        Me.btnResetPr.Name = "btnResetPr"
        Me.btnResetPr.Size = New System.Drawing.Size(140, 23)
        Me.btnResetPr.TabIndex = 1
        Me.btnResetPr.Text = "Resetar senha prioritária"
        Me.btnResetPr.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Location = New System.Drawing.Point(6, 37)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(137, 23)
        Me.btnReset.TabIndex = 0
        Me.btnReset.Text = "Resetar senha normal"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnCopiaSenhaP)
        Me.GroupBox3.Controls.Add(Me.btnCopiaSenhaN)
        Me.GroupBox3.Controls.Add(Me.lblSenhaP)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.lblSenhaN)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(238, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(418, 219)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Senhas"
        '
        'btnCopiaSenhaP
        '
        Me.btnCopiaSenhaP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCopiaSenhaP.Location = New System.Drawing.Point(201, 161)
        Me.btnCopiaSenhaP.Name = "btnCopiaSenhaP"
        Me.btnCopiaSenhaP.Size = New System.Drawing.Size(75, 23)
        Me.btnCopiaSenhaP.TabIndex = 5
        Me.btnCopiaSenhaP.Text = "<<<<<<<<<"
        Me.btnCopiaSenhaP.UseVisualStyleBackColor = True
        '
        'btnCopiaSenhaN
        '
        Me.btnCopiaSenhaN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCopiaSenhaN.Location = New System.Drawing.Point(35, 161)
        Me.btnCopiaSenhaN.Name = "btnCopiaSenhaN"
        Me.btnCopiaSenhaN.Size = New System.Drawing.Size(75, 23)
        Me.btnCopiaSenhaN.TabIndex = 4
        Me.btnCopiaSenhaN.Text = "<<<<<<<<<"
        Me.btnCopiaSenhaN.UseVisualStyleBackColor = True
        '
        'lblSenhaP
        '
        Me.lblSenhaP.AutoSize = True
        Me.lblSenhaP.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSenhaP.Location = New System.Drawing.Point(188, 85)
        Me.lblSenhaP.Name = "lblSenhaP"
        Me.lblSenhaP.Size = New System.Drawing.Size(68, 73)
        Me.lblSenhaP.TabIndex = 3
        Me.lblSenhaP.Text = "0"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(195, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(205, 42)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "PRIORITÁRIO"
        '
        'lblSenhaN
        '
        Me.lblSenhaN.AutoSize = True
        Me.lblSenhaN.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSenhaN.Location = New System.Drawing.Point(20, 85)
        Me.lblSenhaN.Name = "lblSenhaN"
        Me.lblSenhaN.Size = New System.Drawing.Size(68, 73)
        Me.lblSenhaN.TabIndex = 1
        Me.lblSenhaN.Text = "0"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NORMAL"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnP0)
        Me.GroupBox4.Controls.Add(Me.btnN0)
        Me.GroupBox4.Controls.Add(Me.btnApagaTextoP)
        Me.GroupBox4.Controls.Add(Me.btnApagaTextoN)
        Me.GroupBox4.Controls.Add(Me.btnPAtt)
        Me.GroupBox4.Controls.Add(Me.btnP9)
        Me.GroupBox4.Controls.Add(Me.txtValorPrt)
        Me.GroupBox4.Controls.Add(Me.txtValorNormal)
        Me.GroupBox4.Controls.Add(Me.btnP8)
        Me.GroupBox4.Controls.Add(Me.btnP7)
        Me.GroupBox4.Controls.Add(Me.btnP6)
        Me.GroupBox4.Controls.Add(Me.btnP5)
        Me.GroupBox4.Controls.Add(Me.btnP4)
        Me.GroupBox4.Controls.Add(Me.btnP3)
        Me.GroupBox4.Controls.Add(Me.btnP2)
        Me.GroupBox4.Controls.Add(Me.btnP1)
        Me.GroupBox4.Controls.Add(Me.btnNAtt)
        Me.GroupBox4.Controls.Add(Me.btnN9)
        Me.GroupBox4.Controls.Add(Me.btnN8)
        Me.GroupBox4.Controls.Add(Me.btnN7)
        Me.GroupBox4.Controls.Add(Me.btnN6)
        Me.GroupBox4.Controls.Add(Me.btnN5)
        Me.GroupBox4.Controls.Add(Me.btnN4)
        Me.GroupBox4.Controls.Add(Me.btnN3)
        Me.GroupBox4.Controls.Add(Me.btnN2)
        Me.GroupBox4.Controls.Add(Me.btnN1)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 237)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(216, 181)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Atualizar valor"
        '
        'btnP0
        '
        Me.btnP0.Location = New System.Drawing.Point(183, 149)
        Me.btnP0.Name = "btnP0"
        Me.btnP0.Size = New System.Drawing.Size(22, 23)
        Me.btnP0.TabIndex = 27
        Me.btnP0.Text = "0"
        Me.btnP0.UseVisualStyleBackColor = True
        '
        'btnN0
        '
        Me.btnN0.Location = New System.Drawing.Point(67, 149)
        Me.btnN0.Name = "btnN0"
        Me.btnN0.Size = New System.Drawing.Size(23, 23)
        Me.btnN0.TabIndex = 26
        Me.btnN0.Text = "0"
        Me.btnN0.UseVisualStyleBackColor = True
        '
        'btnApagaTextoP
        '
        Me.btnApagaTextoP.Location = New System.Drawing.Point(182, 32)
        Me.btnApagaTextoP.Name = "btnApagaTextoP"
        Me.btnApagaTextoP.Size = New System.Drawing.Size(23, 23)
        Me.btnApagaTextoP.TabIndex = 25
        Me.btnApagaTextoP.Text = "<"
        Me.btnApagaTextoP.UseVisualStyleBackColor = True
        '
        'btnApagaTextoN
        '
        Me.btnApagaTextoN.Location = New System.Drawing.Point(67, 32)
        Me.btnApagaTextoN.Name = "btnApagaTextoN"
        Me.btnApagaTextoN.Size = New System.Drawing.Size(23, 23)
        Me.btnApagaTextoN.TabIndex = 24
        Me.btnApagaTextoN.Text = "<"
        Me.btnApagaTextoN.UseVisualStyleBackColor = True
        '
        'btnPAtt
        '
        Me.btnPAtt.Location = New System.Drawing.Point(124, 149)
        Me.btnPAtt.Name = "btnPAtt"
        Me.btnPAtt.Size = New System.Drawing.Size(52, 23)
        Me.btnPAtt.TabIndex = 23
        Me.btnPAtt.Text = "Atualiza"
        Me.btnPAtt.UseVisualStyleBackColor = True
        '
        'btnP9
        '
        Me.btnP9.Location = New System.Drawing.Point(183, 120)
        Me.btnP9.Name = "btnP9"
        Me.btnP9.Size = New System.Drawing.Size(22, 23)
        Me.btnP9.TabIndex = 22
        Me.btnP9.Text = "9"
        Me.btnP9.UseVisualStyleBackColor = True
        '
        'txtValorPrt
        '
        Me.txtValorPrt.Enabled = False
        Me.txtValorPrt.Location = New System.Drawing.Point(124, 34)
        Me.txtValorPrt.Name = "txtValorPrt"
        Me.txtValorPrt.Size = New System.Drawing.Size(52, 20)
        Me.txtValorPrt.TabIndex = 1
        '
        'txtValorNormal
        '
        Me.txtValorNormal.Enabled = False
        Me.txtValorNormal.Location = New System.Drawing.Point(9, 34)
        Me.txtValorNormal.Name = "txtValorNormal"
        Me.txtValorNormal.Size = New System.Drawing.Size(52, 20)
        Me.txtValorNormal.TabIndex = 0
        '
        'btnP8
        '
        Me.btnP8.Location = New System.Drawing.Point(153, 120)
        Me.btnP8.Name = "btnP8"
        Me.btnP8.Size = New System.Drawing.Size(23, 23)
        Me.btnP8.TabIndex = 21
        Me.btnP8.Text = "8"
        Me.btnP8.UseVisualStyleBackColor = True
        '
        'btnP7
        '
        Me.btnP7.Location = New System.Drawing.Point(124, 120)
        Me.btnP7.Name = "btnP7"
        Me.btnP7.Size = New System.Drawing.Size(22, 23)
        Me.btnP7.TabIndex = 20
        Me.btnP7.Text = "7"
        Me.btnP7.UseVisualStyleBackColor = True
        '
        'btnP6
        '
        Me.btnP6.Location = New System.Drawing.Point(182, 90)
        Me.btnP6.Name = "btnP6"
        Me.btnP6.Size = New System.Drawing.Size(23, 23)
        Me.btnP6.TabIndex = 19
        Me.btnP6.Text = "6"
        Me.btnP6.UseVisualStyleBackColor = True
        '
        'btnP5
        '
        Me.btnP5.Location = New System.Drawing.Point(153, 90)
        Me.btnP5.Name = "btnP5"
        Me.btnP5.Size = New System.Drawing.Size(23, 23)
        Me.btnP5.TabIndex = 18
        Me.btnP5.Text = "5"
        Me.btnP5.UseVisualStyleBackColor = True
        '
        'btnP4
        '
        Me.btnP4.Location = New System.Drawing.Point(124, 90)
        Me.btnP4.Name = "btnP4"
        Me.btnP4.Size = New System.Drawing.Size(22, 23)
        Me.btnP4.TabIndex = 17
        Me.btnP4.Text = "4"
        Me.btnP4.UseVisualStyleBackColor = True
        '
        'btnP3
        '
        Me.btnP3.Location = New System.Drawing.Point(182, 60)
        Me.btnP3.Name = "btnP3"
        Me.btnP3.Size = New System.Drawing.Size(23, 23)
        Me.btnP3.TabIndex = 16
        Me.btnP3.Text = "3"
        Me.btnP3.UseVisualStyleBackColor = True
        '
        'btnP2
        '
        Me.btnP2.Location = New System.Drawing.Point(153, 60)
        Me.btnP2.Name = "btnP2"
        Me.btnP2.Size = New System.Drawing.Size(23, 23)
        Me.btnP2.TabIndex = 15
        Me.btnP2.Text = "2"
        Me.btnP2.UseVisualStyleBackColor = True
        '
        'btnP1
        '
        Me.btnP1.Location = New System.Drawing.Point(124, 60)
        Me.btnP1.Name = "btnP1"
        Me.btnP1.Size = New System.Drawing.Size(22, 23)
        Me.btnP1.TabIndex = 14
        Me.btnP1.Text = "1"
        Me.btnP1.UseVisualStyleBackColor = True
        '
        'btnNAtt
        '
        Me.btnNAtt.Location = New System.Drawing.Point(9, 149)
        Me.btnNAtt.Name = "btnNAtt"
        Me.btnNAtt.Size = New System.Drawing.Size(52, 23)
        Me.btnNAtt.TabIndex = 13
        Me.btnNAtt.Text = "Atualiza"
        Me.btnNAtt.UseVisualStyleBackColor = True
        '
        'btnN9
        '
        Me.btnN9.Location = New System.Drawing.Point(67, 120)
        Me.btnN9.Name = "btnN9"
        Me.btnN9.Size = New System.Drawing.Size(23, 23)
        Me.btnN9.TabIndex = 12
        Me.btnN9.Text = "9"
        Me.btnN9.UseVisualStyleBackColor = True
        '
        'btnN8
        '
        Me.btnN8.Location = New System.Drawing.Point(38, 120)
        Me.btnN8.Name = "btnN8"
        Me.btnN8.Size = New System.Drawing.Size(23, 23)
        Me.btnN8.TabIndex = 11
        Me.btnN8.Text = "8"
        Me.btnN8.UseVisualStyleBackColor = True
        '
        'btnN7
        '
        Me.btnN7.Location = New System.Drawing.Point(9, 120)
        Me.btnN7.Name = "btnN7"
        Me.btnN7.Size = New System.Drawing.Size(22, 23)
        Me.btnN7.TabIndex = 10
        Me.btnN7.Text = "7"
        Me.btnN7.UseVisualStyleBackColor = True
        '
        'btnN6
        '
        Me.btnN6.Location = New System.Drawing.Point(67, 90)
        Me.btnN6.Name = "btnN6"
        Me.btnN6.Size = New System.Drawing.Size(23, 23)
        Me.btnN6.TabIndex = 9
        Me.btnN6.Text = "6"
        Me.btnN6.UseVisualStyleBackColor = True
        '
        'btnN5
        '
        Me.btnN5.Location = New System.Drawing.Point(38, 90)
        Me.btnN5.Name = "btnN5"
        Me.btnN5.Size = New System.Drawing.Size(23, 23)
        Me.btnN5.TabIndex = 8
        Me.btnN5.Text = "5"
        Me.btnN5.UseVisualStyleBackColor = True
        '
        'btnN4
        '
        Me.btnN4.Location = New System.Drawing.Point(9, 90)
        Me.btnN4.Name = "btnN4"
        Me.btnN4.Size = New System.Drawing.Size(22, 23)
        Me.btnN4.TabIndex = 7
        Me.btnN4.Text = "4"
        Me.btnN4.UseVisualStyleBackColor = True
        '
        'btnN3
        '
        Me.btnN3.Location = New System.Drawing.Point(67, 60)
        Me.btnN3.Name = "btnN3"
        Me.btnN3.Size = New System.Drawing.Size(23, 23)
        Me.btnN3.TabIndex = 6
        Me.btnN3.Text = "3"
        Me.btnN3.UseVisualStyleBackColor = True
        '
        'btnN2
        '
        Me.btnN2.Location = New System.Drawing.Point(38, 60)
        Me.btnN2.Name = "btnN2"
        Me.btnN2.Size = New System.Drawing.Size(23, 23)
        Me.btnN2.TabIndex = 5
        Me.btnN2.Text = "2"
        Me.btnN2.UseVisualStyleBackColor = True
        '
        'btnN1
        '
        Me.btnN1.Location = New System.Drawing.Point(9, 60)
        Me.btnN1.Name = "btnN1"
        Me.btnN1.Size = New System.Drawing.Size(22, 23)
        Me.btnN1.TabIndex = 4
        Me.btnN1.Text = "1"
        Me.btnN1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(121, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Prioritario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Normal"
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM3"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnEnviaSenhaP)
        Me.GroupBox5.Controls.Add(Me.btnEnviaSenhaN)
        Me.GroupBox5.Controls.Add(Me.lblAtualizaSenhaP)
        Me.GroupBox5.Controls.Add(Me.lblAtualizaSenhaN)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 135)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(216, 96)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Senhas a serem atualizadas"
        '
        'btnEnviaSenhaP
        '
        Me.btnEnviaSenhaP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnviaSenhaP.Location = New System.Drawing.Point(117, 66)
        Me.btnEnviaSenhaP.Name = "btnEnviaSenhaP"
        Me.btnEnviaSenhaP.Size = New System.Drawing.Size(75, 23)
        Me.btnEnviaSenhaP.TabIndex = 5
        Me.btnEnviaSenhaP.Text = "Enviar"
        Me.btnEnviaSenhaP.UseVisualStyleBackColor = True
        '
        'btnEnviaSenhaN
        '
        Me.btnEnviaSenhaN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnviaSenhaN.Location = New System.Drawing.Point(12, 66)
        Me.btnEnviaSenhaN.Name = "btnEnviaSenhaN"
        Me.btnEnviaSenhaN.Size = New System.Drawing.Size(75, 23)
        Me.btnEnviaSenhaN.TabIndex = 4
        Me.btnEnviaSenhaN.Text = "Enviar"
        Me.btnEnviaSenhaN.UseVisualStyleBackColor = True
        '
        'lblAtualizaSenhaP
        '
        Me.lblAtualizaSenhaP.AutoSize = True
        Me.lblAtualizaSenhaP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAtualizaSenhaP.Location = New System.Drawing.Point(114, 41)
        Me.lblAtualizaSenhaP.Name = "lblAtualizaSenhaP"
        Me.lblAtualizaSenhaP.Size = New System.Drawing.Size(16, 17)
        Me.lblAtualizaSenhaP.TabIndex = 3
        Me.lblAtualizaSenhaP.Text = "0"
        '
        'lblAtualizaSenhaN
        '
        Me.lblAtualizaSenhaN.AutoSize = True
        Me.lblAtualizaSenhaN.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAtualizaSenhaN.Location = New System.Drawing.Point(9, 41)
        Me.lblAtualizaSenhaN.Name = "lblAtualizaSenhaN"
        Me.lblAtualizaSenhaN.Size = New System.Drawing.Size(16, 17)
        Me.lblAtualizaSenhaN.TabIndex = 2
        Me.lblAtualizaSenhaN.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(114, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 17)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "PRIORITÁRIO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "NORMAL"
        '
        'SerialPort2
        '
        Me.SerialPort2.PortName = "COM4"
        '
        'txtMensagem
        '
        Me.txtMensagem.Location = New System.Drawing.Point(325, 365)
        Me.txtMensagem.Name = "txtMensagem"
        Me.txtMensagem.Size = New System.Drawing.Size(215, 20)
        Me.txtMensagem.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(260, 368)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Mensagem"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(243, 396)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Msg Recebida"
        '
        'txtMsgRecebida
        '
        Me.txtMsgRecebida.Location = New System.Drawing.Point(325, 393)
        Me.txtMsgRecebida.Name = "txtMsgRecebida"
        Me.txtMsgRecebida.Size = New System.Drawing.Size(215, 20)
        Me.txtMsgRecebida.TabIndex = 8
        '
        'Timer2
        '
        '
        'Timer3
        '
        '
        'Timer4
        '
        '
        'Timer5
        '
        '
        'Timer6
        '
        '
        'frmControleSenha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 430)
        Me.Controls.Add(Me.txtMsgRecebida)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtMensagem)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmControleSenha"
        Me.Text = "Controle de Senha"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnRepetir As System.Windows.Forms.Button
    Friend WithEvents btnIncPrioritario As System.Windows.Forms.Button
    Friend WithEvents btnIncrementar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnResetAll As System.Windows.Forms.Button
    Friend WithEvents btnResetPr As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblSenhaN As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtValorPrt As System.Windows.Forms.TextBox
    Friend WithEvents txtValorNormal As System.Windows.Forms.TextBox
    Friend WithEvents btnPAtt As System.Windows.Forms.Button
    Friend WithEvents btnP9 As System.Windows.Forms.Button
    Friend WithEvents btnP8 As System.Windows.Forms.Button
    Friend WithEvents btnP7 As System.Windows.Forms.Button
    Friend WithEvents btnP6 As System.Windows.Forms.Button
    Friend WithEvents btnP5 As System.Windows.Forms.Button
    Friend WithEvents btnP4 As System.Windows.Forms.Button
    Friend WithEvents btnP3 As System.Windows.Forms.Button
    Friend WithEvents btnP2 As System.Windows.Forms.Button
    Friend WithEvents btnP1 As System.Windows.Forms.Button
    Friend WithEvents btnNAtt As System.Windows.Forms.Button
    Friend WithEvents btnN9 As System.Windows.Forms.Button
    Friend WithEvents btnN8 As System.Windows.Forms.Button
    Friend WithEvents btnN7 As System.Windows.Forms.Button
    Friend WithEvents btnN6 As System.Windows.Forms.Button
    Friend WithEvents btnN5 As System.Windows.Forms.Button
    Friend WithEvents btnN4 As System.Windows.Forms.Button
    Friend WithEvents btnN3 As System.Windows.Forms.Button
    Friend WithEvents btnN2 As System.Windows.Forms.Button
    Friend WithEvents btnN1 As System.Windows.Forms.Button
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblSenhaP As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents btnEnviaSenhaP As System.Windows.Forms.Button
    Friend WithEvents btnEnviaSenhaN As System.Windows.Forms.Button
    Friend WithEvents lblAtualizaSenhaP As System.Windows.Forms.Label
    Friend WithEvents lblAtualizaSenhaN As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnApagaTextoP As System.Windows.Forms.Button
    Friend WithEvents btnApagaTextoN As System.Windows.Forms.Button
    Friend WithEvents btnDecrPriorit As System.Windows.Forms.Button
    Friend WithEvents btnDecrNormal As System.Windows.Forms.Button
    Friend WithEvents btnP0 As System.Windows.Forms.Button
    Friend WithEvents btnN0 As System.Windows.Forms.Button
    Friend WithEvents btnCopiaSenhaP As System.Windows.Forms.Button
    Friend WithEvents btnCopiaSenhaN As System.Windows.Forms.Button
    Friend WithEvents SerialPort2 As System.IO.Ports.SerialPort
    Friend WithEvents txtMensagem As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtMsgRecebida As System.Windows.Forms.TextBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents Timer5 As System.Windows.Forms.Timer
    Friend WithEvents Timer6 As System.Windows.Forms.Timer
    Friend WithEvents Timer7 As System.Windows.Forms.Timer

End Class

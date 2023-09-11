<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TerMulCisco
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TerMulCisco))
        Me.TxtBoxTransmite = New System.Windows.Forms.TextBox()
        Me.Txtbox_Recibe = New System.Windows.Forms.TextBox()
        Me.BtnTransmitir = New System.Windows.Forms.Button()
        Me.BaudRateBox = New System.Windows.Forms.ComboBox()
        Me.BaudRateLabel = New System.Windows.Forms.Label()
        Me.COMPortsBox = New System.Windows.Forms.ComboBox()
        Me.ComPortLabel = New System.Windows.Forms.Label()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.BreakButton = New System.Windows.Forms.Button()
        Me.RTSLamp = New System.Windows.Forms.Button()
        Me.DTRLamp = New System.Windows.Forms.Button()
        Me.DSRLamp = New System.Windows.Forms.Button()
        Me.CTSLamp = New System.Windows.Forms.Button()
        Me.ParityBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FlowControlBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BitsBox = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnGuardarPlantilla = New System.Windows.Forms.Button()
        Me.BtnGuardarEnCisco = New System.Windows.Forms.Button()
        Me.BtnCargarIOS = New System.Windows.Forms.Button()
        Me.BtnEliminarIOS = New System.Windows.Forms.Button()
        Me.BtnYes = New System.Windows.Forms.Button()
        Me.BtnNo = New System.Windows.Forms.Button()
        Me.BtnEraseStartup = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnCopy_Tftp_Cisco = New System.Windows.Forms.Button()
        Me.BtnEliminarPlantilla = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Btn_ComandoShVer = New System.Windows.Forms.Button()
        Me.Btn_comandoShRun = New System.Windows.Forms.Button()
        Me.Btn_ComandoDirFlahs = New System.Windows.Forms.Button()
        Me.Btn_ComandoConfTer = New System.Windows.Forms.Button()
        Me.OpenFD = New System.Windows.Forms.OpenFileDialog()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModeloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem11 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem12 = New System.Windows.Forms.ToolStripMenuItem()
        Me.STToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModoBásicoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShVerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShFlashToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EraseFlashToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModoEnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShRunToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DirFlashToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShVerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyTftpiosbinFlashToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowIpInterfaceBriefToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BootSystemFlashToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyRunningconfigStartupconfigToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CoyRunStartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyRunningconfigTftpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteFlashToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EraseFlashToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModoConfTerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfTerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServiceDhcpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IntF4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IntEth0ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IpAddress192168112552552550ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NoShutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EndToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargarIOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IPADDRESS19216811ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IPSUBNETMASK2552552550ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DEFAULTGATEWAY19216811ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TFTPSERVER19216812ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TFTPFILEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TFTPDNLDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SETToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TFTPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RutaIOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComandosCiscoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnReload = New System.Windows.Forms.Button()
        Me.BtnEnable = New System.Windows.Forms.Button()
        Me.FBDir = New System.Windows.Forms.FolderBrowserDialog()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.BarraEstado = New System.Windows.Forms.StatusStrip()
        Me.BarraEstadoTftp = New System.Windows.Forms.ToolStripStatusLabel()
        Me.BarraEstadoRutaTFTP = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.BarraEstado.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtBoxTransmite
        '
        Me.TxtBoxTransmite.AutoCompleteCustomSource.AddRange(New String() {"sh run", "sh ver ", "reboot", "reset", "enable", "dir ", "dir flash", "conf ter", "exit", "yes", "no", "y ", "n", "delete flash:", "erase flash:", "copy running-config started-config", "IP_ADDRESS=192.168.1.1", "DEFAULT_GETAWAY=192.168.1.1", "TFTP=192.168.1.2", "TFTP_FILE=", "TFTPDNLD"})
        Me.TxtBoxTransmite.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TxtBoxTransmite.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TxtBoxTransmite.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBoxTransmite.Location = New System.Drawing.Point(12, 353)
        Me.TxtBoxTransmite.Name = "TxtBoxTransmite"
        Me.TxtBoxTransmite.Size = New System.Drawing.Size(429, 22)
        Me.TxtBoxTransmite.TabIndex = 0
        '
        'Txtbox_Recibe
        '
        Me.Txtbox_Recibe.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtbox_Recibe.Location = New System.Drawing.Point(12, 58)
        Me.Txtbox_Recibe.Multiline = True
        Me.Txtbox_Recibe.Name = "Txtbox_Recibe"
        Me.Txtbox_Recibe.ReadOnly = True
        Me.Txtbox_Recibe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txtbox_Recibe.Size = New System.Drawing.Size(669, 259)
        Me.Txtbox_Recibe.TabIndex = 1
        '
        'BtnTransmitir
        '
        Me.BtnTransmitir.Location = New System.Drawing.Point(449, 353)
        Me.BtnTransmitir.Name = "BtnTransmitir"
        Me.BtnTransmitir.Size = New System.Drawing.Size(63, 25)
        Me.BtnTransmitir.TabIndex = 2
        Me.BtnTransmitir.Text = "Enviar"
        Me.BtnTransmitir.UseVisualStyleBackColor = True
        '
        'BaudRateBox
        '
        Me.BaudRateBox.Enabled = False
        Me.BaudRateBox.FormattingEnabled = True
        Me.BaudRateBox.Location = New System.Drawing.Point(224, 32)
        Me.BaudRateBox.Name = "BaudRateBox"
        Me.BaudRateBox.Size = New System.Drawing.Size(58, 21)
        Me.BaudRateBox.TabIndex = 5
        '
        'BaudRateLabel
        '
        Me.BaudRateLabel.AutoSize = True
        Me.BaudRateLabel.Enabled = False
        Me.BaudRateLabel.Location = New System.Drawing.Point(144, 35)
        Me.BaudRateLabel.Name = "BaudRateLabel"
        Me.BaudRateLabel.Size = New System.Drawing.Size(75, 13)
        Me.BaudRateLabel.TabIndex = 6
        Me.BaudRateLabel.Text = "Bit Rate (bit/s)"
        '
        'COMPortsBox
        '
        Me.COMPortsBox.FormattingEnabled = True
        Me.COMPortsBox.Location = New System.Drawing.Point(47, 32)
        Me.COMPortsBox.Name = "COMPortsBox"
        Me.COMPortsBox.Size = New System.Drawing.Size(85, 21)
        Me.COMPortsBox.TabIndex = 7
        '
        'ComPortLabel
        '
        Me.ComPortLabel.AutoSize = True
        Me.ComPortLabel.Enabled = False
        Me.ComPortLabel.Location = New System.Drawing.Point(13, 35)
        Me.ComPortLabel.Name = "ComPortLabel"
        Me.ComPortLabel.Size = New System.Drawing.Size(31, 13)
        Me.ComPortLabel.TabIndex = 8
        Me.ComPortLabel.Text = "COM"
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(12, 323)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(56, 23)
        Me.ClearButton.TabIndex = 9
        Me.ClearButton.Text = "Limpiar"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'BreakButton
        '
        Me.BreakButton.Location = New System.Drawing.Point(137, 323)
        Me.BreakButton.Name = "BreakButton"
        Me.BreakButton.Size = New System.Drawing.Size(93, 23)
        Me.BreakButton.TabIndex = 10
        Me.BreakButton.Text = "Int arranque"
        Me.BreakButton.UseVisualStyleBackColor = True
        '
        'RTSLamp
        '
        Me.RTSLamp.Location = New System.Drawing.Point(395, 323)
        Me.RTSLamp.Name = "RTSLamp"
        Me.RTSLamp.Size = New System.Drawing.Size(39, 23)
        Me.RTSLamp.TabIndex = 11
        Me.RTSLamp.Text = "RTS"
        Me.RTSLamp.UseVisualStyleBackColor = True
        '
        'DTRLamp
        '
        Me.DTRLamp.Location = New System.Drawing.Point(350, 323)
        Me.DTRLamp.Name = "DTRLamp"
        Me.DTRLamp.Size = New System.Drawing.Size(39, 23)
        Me.DTRLamp.TabIndex = 12
        Me.DTRLamp.Text = "DTR"
        Me.DTRLamp.UseVisualStyleBackColor = True
        '
        'DSRLamp
        '
        Me.DSRLamp.Location = New System.Drawing.Point(241, 323)
        Me.DSRLamp.Name = "DSRLamp"
        Me.DSRLamp.Size = New System.Drawing.Size(39, 24)
        Me.DSRLamp.TabIndex = 13
        Me.DSRLamp.Text = "DSR"
        Me.DSRLamp.UseVisualStyleBackColor = True
        '
        'CTSLamp
        '
        Me.CTSLamp.Location = New System.Drawing.Point(286, 323)
        Me.CTSLamp.Name = "CTSLamp"
        Me.CTSLamp.Size = New System.Drawing.Size(39, 23)
        Me.CTSLamp.TabIndex = 14
        Me.CTSLamp.Text = "CTS"
        Me.CTSLamp.UseVisualStyleBackColor = True
        '
        'ParityBox
        '
        Me.ParityBox.Enabled = False
        Me.ParityBox.FormattingEnabled = True
        Me.ParityBox.Location = New System.Drawing.Point(436, 32)
        Me.ParityBox.Name = "ParityBox"
        Me.ParityBox.Size = New System.Drawing.Size(65, 21)
        Me.ParityBox.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.Location = New System.Drawing.Point(397, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Parity"
        '
        'FlowControlBox
        '
        Me.FlowControlBox.Enabled = False
        Me.FlowControlBox.FormattingEnabled = True
        Me.FlowControlBox.Location = New System.Drawing.Point(628, 30)
        Me.FlowControlBox.Name = "FlowControlBox"
        Me.FlowControlBox.Size = New System.Drawing.Size(53, 21)
        Me.FlowControlBox.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Enabled = False
        Me.Label2.Location = New System.Drawing.Point(504, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Software Flow Control "
        '
        'BitsBox
        '
        Me.BitsBox.Enabled = False
        Me.BitsBox.FormattingEnabled = True
        Me.BitsBox.Location = New System.Drawing.Point(341, 32)
        Me.BitsBox.Name = "BitsBox"
        Me.BitsBox.Size = New System.Drawing.Size(50, 21)
        Me.BitsBox.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Location = New System.Drawing.Point(285, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Data Bits"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(73, 323)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(59, 23)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnGuardarPlantilla
        '
        Me.BtnGuardarPlantilla.Location = New System.Drawing.Point(6, 16)
        Me.BtnGuardarPlantilla.Name = "BtnGuardarPlantilla"
        Me.BtnGuardarPlantilla.Size = New System.Drawing.Size(96, 23)
        Me.BtnGuardarPlantilla.TabIndex = 22
        Me.BtnGuardarPlantilla.Text = "Guardar flash"
        Me.BtnGuardarPlantilla.UseVisualStyleBackColor = True
        '
        'BtnGuardarEnCisco
        '
        Me.BtnGuardarEnCisco.Location = New System.Drawing.Point(6, 45)
        Me.BtnGuardarEnCisco.Name = "BtnGuardarEnCisco"
        Me.BtnGuardarEnCisco.Size = New System.Drawing.Size(96, 23)
        Me.BtnGuardarEnCisco.TabIndex = 22
        Me.BtnGuardarEnCisco.Text = "Guardar a cisco"
        Me.BtnGuardarEnCisco.UseVisualStyleBackColor = True
        '
        'BtnCargarIOS
        '
        Me.BtnCargarIOS.Location = New System.Drawing.Point(6, 13)
        Me.BtnCargarIOS.Name = "BtnCargarIOS"
        Me.BtnCargarIOS.Size = New System.Drawing.Size(96, 23)
        Me.BtnCargarIOS.TabIndex = 22
        Me.BtnCargarIOS.Text = "Cargar"
        Me.BtnCargarIOS.UseVisualStyleBackColor = True
        '
        'BtnEliminarIOS
        '
        Me.BtnEliminarIOS.Location = New System.Drawing.Point(7, 42)
        Me.BtnEliminarIOS.Name = "BtnEliminarIOS"
        Me.BtnEliminarIOS.Size = New System.Drawing.Size(96, 23)
        Me.BtnEliminarIOS.TabIndex = 22
        Me.BtnEliminarIOS.Text = "Eliminar"
        Me.BtnEliminarIOS.UseVisualStyleBackColor = True
        '
        'BtnYes
        '
        Me.BtnYes.Location = New System.Drawing.Point(518, 353)
        Me.BtnYes.Name = "BtnYes"
        Me.BtnYes.Size = New System.Drawing.Size(25, 25)
        Me.BtnYes.TabIndex = 22
        Me.BtnYes.Text = "Y"
        Me.BtnYes.UseVisualStyleBackColor = True
        '
        'BtnNo
        '
        Me.BtnNo.Location = New System.Drawing.Point(548, 353)
        Me.BtnNo.Name = "BtnNo"
        Me.BtnNo.Size = New System.Drawing.Size(26, 25)
        Me.BtnNo.TabIndex = 22
        Me.BtnNo.Text = "N"
        Me.BtnNo.UseVisualStyleBackColor = True
        '
        'BtnEraseStartup
        '
        Me.BtnEraseStartup.Location = New System.Drawing.Point(464, 394)
        Me.BtnEraseStartup.Name = "BtnEraseStartup"
        Me.BtnEraseStartup.Size = New System.Drawing.Size(120, 24)
        Me.BtnEraseStartup.TabIndex = 22
        Me.BtnEraseStartup.Text = "erase startup-config"
        Me.BtnEraseStartup.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnCopy_Tftp_Cisco)
        Me.GroupBox1.Controls.Add(Me.BtnEliminarPlantilla)
        Me.GroupBox1.Controls.Add(Me.BtnGuardarEnCisco)
        Me.GroupBox1.Controls.Add(Me.BtnGuardarPlantilla)
        Me.GroupBox1.Location = New System.Drawing.Point(689, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(110, 132)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Plantilla"
        '
        'BtnCopy_Tftp_Cisco
        '
        Me.BtnCopy_Tftp_Cisco.Location = New System.Drawing.Point(7, 103)
        Me.BtnCopy_Tftp_Cisco.Name = "BtnCopy_Tftp_Cisco"
        Me.BtnCopy_Tftp_Cisco.Size = New System.Drawing.Size(95, 23)
        Me.BtnCopy_Tftp_Cisco.TabIndex = 26
        Me.BtnCopy_Tftp_Cisco.Text = "TFTP a CISCO"
        Me.BtnCopy_Tftp_Cisco.UseVisualStyleBackColor = True
        '
        'BtnEliminarPlantilla
        '
        Me.BtnEliminarPlantilla.Location = New System.Drawing.Point(7, 74)
        Me.BtnEliminarPlantilla.Name = "BtnEliminarPlantilla"
        Me.BtnEliminarPlantilla.Size = New System.Drawing.Size(94, 23)
        Me.BtnEliminarPlantilla.TabIndex = 23
        Me.BtnEliminarPlantilla.Text = "Eliminar"
        Me.BtnEliminarPlantilla.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnCargarIOS)
        Me.GroupBox2.Controls.Add(Me.BtnEliminarIOS)
        Me.GroupBox2.Location = New System.Drawing.Point(689, 166)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(111, 73)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = " IOS"
        '
        'Btn_ComandoShVer
        '
        Me.Btn_ComandoShVer.Location = New System.Drawing.Point(6, 19)
        Me.Btn_ComandoShVer.Name = "Btn_ComandoShVer"
        Me.Btn_ComandoShVer.Size = New System.Drawing.Size(48, 20)
        Me.Btn_ComandoShVer.TabIndex = 27
        Me.Btn_ComandoShVer.Text = "sh ver"
        Me.Btn_ComandoShVer.UseVisualStyleBackColor = True
        '
        'Btn_comandoShRun
        '
        Me.Btn_comandoShRun.Location = New System.Drawing.Point(5, 14)
        Me.Btn_comandoShRun.Name = "Btn_comandoShRun"
        Me.Btn_comandoShRun.Size = New System.Drawing.Size(55, 23)
        Me.Btn_comandoShRun.TabIndex = 27
        Me.Btn_comandoShRun.Text = "sh run"
        Me.Btn_comandoShRun.UseVisualStyleBackColor = True
        '
        'Btn_ComandoDirFlahs
        '
        Me.Btn_ComandoDirFlahs.Location = New System.Drawing.Point(63, 14)
        Me.Btn_ComandoDirFlahs.Name = "Btn_ComandoDirFlahs"
        Me.Btn_ComandoDirFlahs.Size = New System.Drawing.Size(55, 23)
        Me.Btn_ComandoDirFlahs.TabIndex = 27
        Me.Btn_ComandoDirFlahs.Text = "dir flash"
        Me.Btn_ComandoDirFlahs.UseVisualStyleBackColor = True
        '
        'Btn_ComandoConfTer
        '
        Me.Btn_ComandoConfTer.Location = New System.Drawing.Point(10, 14)
        Me.Btn_ComandoConfTer.Name = "Btn_ComandoConfTer"
        Me.Btn_ComandoConfTer.Size = New System.Drawing.Size(75, 23)
        Me.Btn_ComandoConfTer.TabIndex = 27
        Me.Btn_ComandoConfTer.Text = "conf ter"
        Me.Btn_ComandoConfTer.UseVisualStyleBackColor = True
        '
        'OpenFD
        '
        Me.OpenFD.FileName = "*.bin"
        Me.OpenFD.Title = "Seleccione fichero"
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(580, 354)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(48, 23)
        Me.BtnExit.TabIndex = 28
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Btn_comandoShRun)
        Me.GroupBox5.Controls.Add(Me.Btn_ComandoDirFlahs)
        Me.GroupBox5.Location = New System.Drawing.Point(184, 382)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(123, 42)
        Me.GroupBox5.TabIndex = 29
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Modo En"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Btn_ComandoConfTer)
        Me.GroupBox6.Location = New System.Drawing.Point(310, 381)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(104, 42)
        Me.GroupBox6.TabIndex = 30
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Modo Conf Ter"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.ModeloToolStripMenuItem, Me.ModoBásicoToolStripMenuItem, Me.ModoEnToolStripMenuItem, Me.ModoConfTerToolStripMenuItem, Me.AyudaToolStripMenuItem, Me.TFTPToolStripMenuItem, Me.AyudaToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(806, 24)
        Me.MenuStrip1.TabIndex = 31
        Me.MenuStrip1.Text = "MenuPrincipal"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'ModeloToolStripMenuItem
        '
        Me.ModeloToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4, Me.ToolStripMenuItem5, Me.ToolStripMenuItem6, Me.ToolStripMenuItem7, Me.ToolStripMenuItem8, Me.ToolStripMenuItem9, Me.ToolStripMenuItem10, Me.ToolStripMenuItem11, Me.ToolStripMenuItem12, Me.STToolStripMenuItem})
        Me.ModeloToolStripMenuItem.Name = "ModeloToolStripMenuItem"
        Me.ModeloToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ModeloToolStripMenuItem.Text = "Modelo"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(111, 22)
        Me.ToolStripMenuItem2.Text = "877"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(111, 22)
        Me.ToolStripMenuItem3.Text = "871"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(111, 22)
        Me.ToolStripMenuItem4.Text = "851"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(111, 22)
        Me.ToolStripMenuItem5.Text = "857"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(111, 22)
        Me.ToolStripMenuItem6.Text = "837"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(111, 22)
        Me.ToolStripMenuItem7.Text = "827"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(111, 22)
        Me.ToolStripMenuItem8.Text = "805"
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(111, 22)
        Me.ToolStripMenuItem9.Text = "801"
        '
        'ToolStripMenuItem10
        '
        Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        Me.ToolStripMenuItem10.Size = New System.Drawing.Size(111, 22)
        Me.ToolStripMenuItem10.Text = "1801"
        '
        'ToolStripMenuItem11
        '
        Me.ToolStripMenuItem11.Name = "ToolStripMenuItem11"
        Me.ToolStripMenuItem11.Size = New System.Drawing.Size(111, 22)
        Me.ToolStripMenuItem11.Text = "1841"
        '
        'ToolStripMenuItem12
        '
        Me.ToolStripMenuItem12.Name = "ToolStripMenuItem12"
        Me.ToolStripMenuItem12.Size = New System.Drawing.Size(111, 22)
        Me.ToolStripMenuItem12.Text = "1720"
        '
        'STToolStripMenuItem
        '
        Me.STToolStripMenuItem.Name = "STToolStripMenuItem"
        Me.STToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.STToolStripMenuItem.Text = "2801ST"
        '
        'ModoBásicoToolStripMenuItem
        '
        Me.ModoBásicoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShVerToolStripMenuItem1, Me.AyudaToolStripMenuItem2, Me.ShFlashToolStripMenuItem, Me.EraseFlashToolStripMenuItem})
        Me.ModoBásicoToolStripMenuItem.Name = "ModoBásicoToolStripMenuItem"
        Me.ModoBásicoToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.ModoBásicoToolStripMenuItem.Text = "Modo Básico"
        '
        'ShVerToolStripMenuItem1
        '
        Me.ShVerToolStripMenuItem1.Name = "ShVerToolStripMenuItem1"
        Me.ShVerToolStripMenuItem1.Size = New System.Drawing.Size(135, 22)
        Me.ShVerToolStripMenuItem1.Text = "sh ver"
        '
        'AyudaToolStripMenuItem2
        '
        Me.AyudaToolStripMenuItem2.Name = "AyudaToolStripMenuItem2"
        Me.AyudaToolStripMenuItem2.Size = New System.Drawing.Size(135, 22)
        Me.AyudaToolStripMenuItem2.Text = "ayuda"
        '
        'ShFlashToolStripMenuItem
        '
        Me.ShFlashToolStripMenuItem.Name = "ShFlashToolStripMenuItem"
        Me.ShFlashToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.ShFlashToolStripMenuItem.Text = "sh flash"
        '
        'EraseFlashToolStripMenuItem
        '
        Me.EraseFlashToolStripMenuItem.Name = "EraseFlashToolStripMenuItem"
        Me.EraseFlashToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.EraseFlashToolStripMenuItem.Text = "no comand"
        '
        'ModoEnToolStripMenuItem
        '
        Me.ModoEnToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShRunToolStripMenuItem, Me.DirFlashToolStripMenuItem, Me.ShVerToolStripMenuItem, Me.CopyTftpiosbinFlashToolStripMenuItem, Me.ShowIpInterfaceBriefToolStripMenuItem, Me.BootSystemFlashToolStripMenuItem, Me.CopyRunningconfigStartupconfigToolStripMenuItem, Me.CoyRunStartToolStripMenuItem, Me.CopyRunningconfigTftpToolStripMenuItem, Me.DeleteFlashToolStripMenuItem, Me.EraseFlashToolStripMenuItem1})
        Me.ModoEnToolStripMenuItem.Name = "ModoEnToolStripMenuItem"
        Me.ModoEnToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.ModoEnToolStripMenuItem.Text = "Modo en"
        '
        'ShRunToolStripMenuItem
        '
        Me.ShRunToolStripMenuItem.Name = "ShRunToolStripMenuItem"
        Me.ShRunToolStripMenuItem.Size = New System.Drawing.Size(265, 22)
        Me.ShRunToolStripMenuItem.Text = "sh run"
        '
        'DirFlashToolStripMenuItem
        '
        Me.DirFlashToolStripMenuItem.Name = "DirFlashToolStripMenuItem"
        Me.DirFlashToolStripMenuItem.Size = New System.Drawing.Size(265, 22)
        Me.DirFlashToolStripMenuItem.Text = "dir flash"
        '
        'ShVerToolStripMenuItem
        '
        Me.ShVerToolStripMenuItem.Name = "ShVerToolStripMenuItem"
        Me.ShVerToolStripMenuItem.Size = New System.Drawing.Size(265, 22)
        Me.ShVerToolStripMenuItem.Text = "sh ver"
        '
        'CopyTftpiosbinFlashToolStripMenuItem
        '
        Me.CopyTftpiosbinFlashToolStripMenuItem.Name = "CopyTftpiosbinFlashToolStripMenuItem"
        Me.CopyTftpiosbinFlashToolStripMenuItem.Size = New System.Drawing.Size(265, 22)
        Me.CopyTftpiosbinFlashToolStripMenuItem.Text = "copy tftp:<ios.bin> flash"
        '
        'ShowIpInterfaceBriefToolStripMenuItem
        '
        Me.ShowIpInterfaceBriefToolStripMenuItem.Name = "ShowIpInterfaceBriefToolStripMenuItem"
        Me.ShowIpInterfaceBriefToolStripMenuItem.Size = New System.Drawing.Size(265, 22)
        Me.ShowIpInterfaceBriefToolStripMenuItem.Text = "show ip interface brief"
        '
        'BootSystemFlashToolStripMenuItem
        '
        Me.BootSystemFlashToolStripMenuItem.Name = "BootSystemFlashToolStripMenuItem"
        Me.BootSystemFlashToolStripMenuItem.Size = New System.Drawing.Size(265, 22)
        Me.BootSystemFlashToolStripMenuItem.Text = "reboot"
        '
        'CopyRunningconfigStartupconfigToolStripMenuItem
        '
        Me.CopyRunningconfigStartupconfigToolStripMenuItem.Name = "CopyRunningconfigStartupconfigToolStripMenuItem"
        Me.CopyRunningconfigStartupconfigToolStripMenuItem.Size = New System.Drawing.Size(265, 22)
        Me.CopyRunningconfigStartupconfigToolStripMenuItem.Text = "Copy running-config startup-config"
        '
        'CoyRunStartToolStripMenuItem
        '
        Me.CoyRunStartToolStripMenuItem.Name = "CoyRunStartToolStripMenuItem"
        Me.CoyRunStartToolStripMenuItem.Size = New System.Drawing.Size(265, 22)
        Me.CoyRunStartToolStripMenuItem.Text = "Copy run start"
        '
        'CopyRunningconfigTftpToolStripMenuItem
        '
        Me.CopyRunningconfigTftpToolStripMenuItem.Name = "CopyRunningconfigTftpToolStripMenuItem"
        Me.CopyRunningconfigTftpToolStripMenuItem.Size = New System.Drawing.Size(265, 22)
        Me.CopyRunningconfigTftpToolStripMenuItem.Text = "Copy running-config tftp:"
        '
        'DeleteFlashToolStripMenuItem
        '
        Me.DeleteFlashToolStripMenuItem.Name = "DeleteFlashToolStripMenuItem"
        Me.DeleteFlashToolStripMenuItem.Size = New System.Drawing.Size(265, 22)
        Me.DeleteFlashToolStripMenuItem.Text = "Delete Flash:"
        '
        'EraseFlashToolStripMenuItem1
        '
        Me.EraseFlashToolStripMenuItem1.Name = "EraseFlashToolStripMenuItem1"
        Me.EraseFlashToolStripMenuItem1.Size = New System.Drawing.Size(265, 22)
        Me.EraseFlashToolStripMenuItem1.Text = "Erase Flash:"
        '
        'ModoConfTerToolStripMenuItem
        '
        Me.ModoConfTerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConfTerToolStripMenuItem, Me.ServiceDhcpToolStripMenuItem, Me.IntF4ToolStripMenuItem, Me.IntEth0ToolStripMenuItem, Me.IpAddress192168112552552550ToolStripMenuItem, Me.NoShutToolStripMenuItem, Me.EndToolStripMenuItem})
        Me.ModoConfTerToolStripMenuItem.Name = "ModoConfTerToolStripMenuItem"
        Me.ModoConfTerToolStripMenuItem.Size = New System.Drawing.Size(100, 20)
        Me.ModoConfTerToolStripMenuItem.Text = "Modo Conf Ter"
        '
        'ConfTerToolStripMenuItem
        '
        Me.ConfTerToolStripMenuItem.Name = "ConfTerToolStripMenuItem"
        Me.ConfTerToolStripMenuItem.Size = New System.Drawing.Size(259, 22)
        Me.ConfTerToolStripMenuItem.Text = "conf ter"
        '
        'ServiceDhcpToolStripMenuItem
        '
        Me.ServiceDhcpToolStripMenuItem.Name = "ServiceDhcpToolStripMenuItem"
        Me.ServiceDhcpToolStripMenuItem.Size = New System.Drawing.Size(259, 22)
        Me.ServiceDhcpToolStripMenuItem.Text = "service dhcp"
        '
        'IntF4ToolStripMenuItem
        '
        Me.IntF4ToolStripMenuItem.Name = "IntF4ToolStripMenuItem"
        Me.IntF4ToolStripMenuItem.Size = New System.Drawing.Size(259, 22)
        Me.IntF4ToolStripMenuItem.Text = "int F4"
        '
        'IntEth0ToolStripMenuItem
        '
        Me.IntEth0ToolStripMenuItem.Name = "IntEth0ToolStripMenuItem"
        Me.IntEth0ToolStripMenuItem.Size = New System.Drawing.Size(259, 22)
        Me.IntEth0ToolStripMenuItem.Text = "int eth0"
        '
        'IpAddress192168112552552550ToolStripMenuItem
        '
        Me.IpAddress192168112552552550ToolStripMenuItem.Name = "IpAddress192168112552552550ToolStripMenuItem"
        Me.IpAddress192168112552552550ToolStripMenuItem.Size = New System.Drawing.Size(259, 22)
        Me.IpAddress192168112552552550ToolStripMenuItem.Text = "ip address 192.168.1.1 255.255.255.0"
        '
        'NoShutToolStripMenuItem
        '
        Me.NoShutToolStripMenuItem.Name = "NoShutToolStripMenuItem"
        Me.NoShutToolStripMenuItem.Size = New System.Drawing.Size(259, 22)
        Me.NoShutToolStripMenuItem.Text = "no shut"
        '
        'EndToolStripMenuItem
        '
        Me.EndToolStripMenuItem.Name = "EndToolStripMenuItem"
        Me.EndToolStripMenuItem.Size = New System.Drawing.Size(259, 22)
        Me.EndToolStripMenuItem.Text = "end"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CargarIOSToolStripMenuItem, Me.IPADDRESS19216811ToolStripMenuItem, Me.IPSUBNETMASK2552552550ToolStripMenuItem, Me.DEFAULTGATEWAY19216811ToolStripMenuItem, Me.TFTPSERVER19216812ToolStripMenuItem, Me.TFTPFILEToolStripMenuItem, Me.TFTPDNLDToolStripMenuItem, Me.ResetToolStripMenuItem, Me.SETToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(104, 20)
        Me.AyudaToolStripMenuItem.Text = "Modo Rommon"
        '
        'CargarIOSToolStripMenuItem
        '
        Me.CargarIOSToolStripMenuItem.Name = "CargarIOSToolStripMenuItem"
        Me.CargarIOSToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.CargarIOSToolStripMenuItem.Text = "CARGAR IOS AUTOMATICO "
        '
        'IPADDRESS19216811ToolStripMenuItem
        '
        Me.IPADDRESS19216811ToolStripMenuItem.Name = "IPADDRESS19216811ToolStripMenuItem"
        Me.IPADDRESS19216811ToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.IPADDRESS19216811ToolStripMenuItem.Text = "IP_ADDRESS=192.168.1.1"
        '
        'IPSUBNETMASK2552552550ToolStripMenuItem
        '
        Me.IPSUBNETMASK2552552550ToolStripMenuItem.Name = "IPSUBNETMASK2552552550ToolStripMenuItem"
        Me.IPSUBNETMASK2552552550ToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.IPSUBNETMASK2552552550ToolStripMenuItem.Text = "IP_SUBNET_MASK=255.255.255.0"
        '
        'DEFAULTGATEWAY19216811ToolStripMenuItem
        '
        Me.DEFAULTGATEWAY19216811ToolStripMenuItem.Name = "DEFAULTGATEWAY19216811ToolStripMenuItem"
        Me.DEFAULTGATEWAY19216811ToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.DEFAULTGATEWAY19216811ToolStripMenuItem.Text = "DEFAULT_GATEWAY=192.168.1.1"
        '
        'TFTPSERVER19216812ToolStripMenuItem
        '
        Me.TFTPSERVER19216812ToolStripMenuItem.Name = "TFTPSERVER19216812ToolStripMenuItem"
        Me.TFTPSERVER19216812ToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.TFTPSERVER19216812ToolStripMenuItem.Text = "TFTP_SERVER=192.168.1.2"
        '
        'TFTPFILEToolStripMenuItem
        '
        Me.TFTPFILEToolStripMenuItem.Name = "TFTPFILEToolStripMenuItem"
        Me.TFTPFILEToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.TFTPFILEToolStripMenuItem.Text = "TFTP_FILE"
        '
        'TFTPDNLDToolStripMenuItem
        '
        Me.TFTPDNLDToolStripMenuItem.Name = "TFTPDNLDToolStripMenuItem"
        Me.TFTPDNLDToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.TFTPDNLDToolStripMenuItem.Text = "TFTPDNLD"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.ResetToolStripMenuItem.Text = "RESET"
        '
        'SETToolStripMenuItem
        '
        Me.SETToolStripMenuItem.Name = "SETToolStripMenuItem"
        Me.SETToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.SETToolStripMenuItem.Text = "SET"
        '
        'TFTPToolStripMenuItem
        '
        Me.TFTPToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RutaIOSToolStripMenuItem})
        Me.TFTPToolStripMenuItem.Name = "TFTPToolStripMenuItem"
        Me.TFTPToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.TFTPToolStripMenuItem.Text = "TFTP"
        '
        'RutaIOSToolStripMenuItem
        '
        Me.RutaIOSToolStripMenuItem.Name = "RutaIOSToolStripMenuItem"
        Me.RutaIOSToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.RutaIOSToolStripMenuItem.Text = "Ruta IOS"
        '
        'AyudaToolStripMenuItem1
        '
        Me.AyudaToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComandosCiscoToolStripMenuItem, Me.AcercaDeToolStripMenuItem})
        Me.AyudaToolStripMenuItem1.Name = "AyudaToolStripMenuItem1"
        Me.AyudaToolStripMenuItem1.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem1.Text = "Ayuda"
        '
        'ComandosCiscoToolStripMenuItem
        '
        Me.ComandosCiscoToolStripMenuItem.Name = "ComandosCiscoToolStripMenuItem"
        Me.ComandosCiscoToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.ComandosCiscoToolStripMenuItem.Text = "Comandos cisco"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de Cistermax"
        '
        'BtnReload
        '
        Me.BtnReload.Location = New System.Drawing.Point(58, 19)
        Me.BtnReload.Name = "BtnReload"
        Me.BtnReload.Size = New System.Drawing.Size(45, 20)
        Me.BtnReload.TabIndex = 32
        Me.BtnReload.Text = "reload"
        Me.BtnReload.UseVisualStyleBackColor = True
        '
        'BtnEnable
        '
        Me.BtnEnable.Location = New System.Drawing.Point(108, 19)
        Me.BtnEnable.Name = "BtnEnable"
        Me.BtnEnable.Size = New System.Drawing.Size(54, 20)
        Me.BtnEnable.TabIndex = 33
        Me.BtnEnable.Text = "enable"
        Me.BtnEnable.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Btn_ComandoShVer)
        Me.GroupBox4.Controls.Add(Me.BtnEnable)
        Me.GroupBox4.Controls.Add(Me.BtnReload)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 381)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(170, 44)
        Me.GroupBox4.TabIndex = 34
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Basico"
        '
        'BarraEstado
        '
        Me.BarraEstado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BarraEstadoTftp, Me.BarraEstadoRutaTFTP})
        Me.BarraEstado.Location = New System.Drawing.Point(0, 430)
        Me.BarraEstado.Name = "BarraEstado"
        Me.BarraEstado.Size = New System.Drawing.Size(806, 22)
        Me.BarraEstado.TabIndex = 36
        Me.BarraEstado.Text = "BarraEstado"
        '
        'BarraEstadoTftp
        '
        Me.BarraEstadoTftp.BackColor = System.Drawing.Color.Red
        Me.BarraEstadoTftp.Name = "BarraEstadoTftp"
        Me.BarraEstadoTftp.Size = New System.Drawing.Size(50, 17)
        Me.BarraEstadoTftp.Text = "Tftp ON"
        '
        'BarraEstadoRutaTFTP
        '
        Me.BarraEstadoRutaTFTP.Name = "BarraEstadoRutaTFTP"
        Me.BarraEstadoRutaTFTP.Size = New System.Drawing.Size(0, 17)
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(690, 249)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(101, 169)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 37
        Me.PictureBox1.TabStop = False
        '
        'TerMulCisco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(806, 452)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BarraEstado)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.BtnEraseStartup)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnNo)
        Me.Controls.Add(Me.BtnYes)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BitsBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FlowControlBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ParityBox)
        Me.Controls.Add(Me.CTSLamp)
        Me.Controls.Add(Me.DSRLamp)
        Me.Controls.Add(Me.DTRLamp)
        Me.Controls.Add(Me.RTSLamp)
        Me.Controls.Add(Me.BreakButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.ComPortLabel)
        Me.Controls.Add(Me.COMPortsBox)
        Me.Controls.Add(Me.BaudRateLabel)
        Me.Controls.Add(Me.BaudRateBox)
        Me.Controls.Add(Me.BtnTransmitir)
        Me.Controls.Add(Me.Txtbox_Recibe)
        Me.Controls.Add(Me.TxtBoxTransmite)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "TerMulCisco"
        Me.Text = "Cistermax Terminal multi CISCO"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.BarraEstado.ResumeLayout(False)
        Me.BarraEstado.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtBoxTransmite As System.Windows.Forms.TextBox
    Friend WithEvents Txtbox_Recibe As System.Windows.Forms.TextBox
    Friend WithEvents BtnTransmitir As System.Windows.Forms.Button
    Friend WithEvents BaudRateBox As System.Windows.Forms.ComboBox
    Friend WithEvents BaudRateLabel As System.Windows.Forms.Label
    Friend WithEvents COMPortsBox As System.Windows.Forms.ComboBox
    Friend WithEvents ComPortLabel As System.Windows.Forms.Label
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents BreakButton As System.Windows.Forms.Button
    Friend WithEvents RTSLamp As System.Windows.Forms.Button
    Friend WithEvents DTRLamp As System.Windows.Forms.Button
    Friend WithEvents DSRLamp As System.Windows.Forms.Button
    Friend WithEvents CTSLamp As System.Windows.Forms.Button
    Friend WithEvents ParityBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FlowControlBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Friend WithEvents BitsBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BtnGuardarPlantilla As System.Windows.Forms.Button
    Friend WithEvents BtnGuardarEnCisco As System.Windows.Forms.Button
    Friend WithEvents BtnCargarIOS As System.Windows.Forms.Button
    Friend WithEvents BtnEliminarIOS As System.Windows.Forms.Button
    Friend WithEvents BtnYes As System.Windows.Forms.Button
    Friend WithEvents BtnNo As System.Windows.Forms.Button
    Friend WithEvents BtnEraseStartup As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_ComandoShVer As System.Windows.Forms.Button
    Friend WithEvents Btn_comandoShRun As System.Windows.Forms.Button
    Friend WithEvents Btn_ComandoDirFlahs As System.Windows.Forms.Button
    Friend WithEvents Btn_ComandoConfTer As System.Windows.Forms.Button
    Friend WithEvents OpenFD As System.Windows.Forms.OpenFileDialog
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnEliminarPlantilla As System.Windows.Forms.Button
    Friend WithEvents BtnCopy_Tftp_Cisco As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModeloToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModoBásicoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModoEnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModoConfTerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IPADDRESS19216811ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IPSUBNETMASK2552552550ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DEFAULTGATEWAY19216811ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TFTPSERVER19216812ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TFTPFILEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TFTPDNLDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShVerToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShRunToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DirFlashToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShVerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfTerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem10 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem11 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem12 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents STToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyTftpiosbinFlashToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowIpInterfaceBriefToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ServiceDhcpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnReload As System.Windows.Forms.Button
    Friend WithEvents ComandosCiscoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnEnable As System.Windows.Forms.Button
    Friend WithEvents TFTPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RutaIOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShFlashToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EraseFlashToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BootSystemFlashToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyRunningconfigStartupconfigToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CoyRunStartToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyRunningconfigTftpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IntF4ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IntEth0ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IpAddress192168112552552550ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NoShutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EndToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FBDir As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents CargarIOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents ResetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarraEstado As System.Windows.Forms.StatusStrip
    Friend WithEvents BarraEstadoTftp As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents DeleteFlashToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EraseFlashToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarraEstadoRutaTFTP As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents SETToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class

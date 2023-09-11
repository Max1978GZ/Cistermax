'
Imports System
Imports System.IO.Ports
Imports System.Threading
Imports System.Threading.Thread
Imports System.Text.RegularExpressions
Imports OBJ_TFTP


Public Class TerMulCisco

    Dim SpaceCount As Byte = 0

    Dim str As String = ""

    Dim tftp As New INICIOTFTp

    Dim WithEvents COMPort As New SerialPort

    Private Sub Receiver(ByVal sender As Object, ByVal e As SerialDataReceivedEventArgs) Handles COMPort.DataReceived
        Do
          
            str = COMPort.ReadExisting()

            Me.Invoke(New MethodInvoker(AddressOf Display))

        Loop Until (COMPort.BytesToRead = 0)
        COMPort.DiscardInBuffer()
        COMPort.DiscardOutBuffer()
       
    End Sub

    Private Sub Display()
        Txtbox_Recibe.Text = Txtbox_Recibe.Text.Replace("--More--         ", "")
        Txtbox_Recibe.AppendText(str)
        COMPort.DiscardNull = True

    End Sub



    Private Sub Btn_Transmitir(ByVal sender As Object, ByVal e As EventArgs) Handles BtnTransmitir.Click
        Me.Transmitir_Comando()
        Me.TxtBoxTransmite.Focus()
    End Sub

    Private Sub PortSelection(ByVal sender As Object, ByVal e As EventArgs) Handles COMPortsBox.SelectedIndexChanged
        RTSLamp.BackColor = Color.Gray
        DTRLamp.BackColor = Color.Gray
        If COMPort.IsOpen Then
            COMPort.RtsEnable = False
            COMPort.DtrEnable = False
            ClosePort()
            Application.DoEvents()
            Sleep(200)
        End If
        COMPort.PortName = COMPortsBox.Text
        COMPort.BaudRate = 9600
        COMPort.WriteTimeout = 1000
        COMPort.ReadBufferSize = 16384
        Try
            COMPort.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        BaudRateBox.Text = COMPort.BaudRate.ToString
        BitsBox.Text = COMPort.DataBits.ToString
        ParityBox.Text = COMPort.Parity.ToString
        FlowControlBox.Text = COMPort.Handshake.ToString
        If COMPort.IsOpen Then
            COMPort.RtsEnable = True
            RTSLamp.BackColor = Color.LightGreen
            COMPort.DtrEnable = True
            DTRLamp.BackColor = Color.LightGreen
        End If
    End Sub

    Private Sub MaxiTesterLoad(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Me.tftp.BasePath = System.IO.Directory.GetCurrentDirectory
        'Me.tftp.Start(System.IO.Directory.GetCurrentDirectory)
        Me.BarraEstadoRutaTFTP.Text = Me.tftp.BasePath

        Me.TFTP_ACTIVO(True)

        Me.TxtBoxTransmite.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        For Each COMString As String In My.Computer.Ports.SerialPortNames
            COMPortsBox.Items.Add(COMString)
        Next
        COMPortsBox.Sorted = True
        Try
            COMPortsBox.SelectedIndex = 0
        Catch
            Me.Text = Me.Text & " No hay puertos Serie :("

        End Try

        BaudRateBox.Items.Add("9600")
        BaudRateBox.SelectedIndex = 0 ' para que coja la velocidad por defecto
        BitsBox.Items.Add("8")
        ParityBox.Items.Add("None")
        ParityBox.Items.Add("Odd")
        ParityBox.Items.Add("Even")
        ParityBox.Items.Add("Mark")
        ParityBox.Items.Add("Space")
        FlowControlBox.Items.Add("None")
        FlowControlBox.Items.Add("RequestToSend")
        FlowControlBox.Items.Add("RequestToSendXOnXOff")
        FlowControlBox.Items.Add("XOnXOff")
        RTSLamp.BackColor = Color.Red
        DTRLamp.BackColor = Color.Red
        CTSLamp.BackColor = Color.Red
        DSRLamp.BackColor = Color.Red
    End Sub


  

    Private Sub ClosePort()
        If COMPort.IsOpen Then COMPort.Close()
    End Sub

  

    Private Sub MaxiTesterClosing(ByVal sender As Object, ByVal e As ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If MessageBox.Show("¿ Realmente quieres cerrar Cistermax ?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        Else

            Dim t As New Thread(AddressOf ClosePort)
            t.Start()
        End If
    End Sub

    '

    Private Sub ClearReceivedText(ByVal sender As Object, ByVal e As EventArgs) Handles ClearButton.Click
        Txtbox_Recibe.Text = ""
        SpaceCount = 0
        Me.TxtBoxTransmite.Focus()
    End Sub



    Private Sub SendBreak(ByVal sender As Object, ByVal e As EventArgs) Handles BreakButton.Click
        If COMPort.IsOpen Then
            COMPort.BreakState = True
            Sleep((11000 / COMPort.BaudRate) + 10)
            COMPort.BreakState = False
        Else
            MsgBox("No hay puerto COM seleccionado")
        End If
        Me.TxtBoxTransmite.Focus()
    End Sub



    Private Sub BaudRateSelection(ByVal sender As Object, ByVal e As EventArgs) Handles BaudRateBox.SelectedIndexChanged
        COMPort.BaudRate = CInt(BaudRateBox.Text)
    End Sub



    Private Sub DataBitsSelection(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BitsBox.SelectedIndexChanged
        COMPort.DataBits = CInt(BitsBox.Text)
    End Sub



    Private Sub ParitySelection(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ParityBox.SelectedIndexChanged
        COMPort.Parity = CType([Enum].Parse(GetType(Parity), ParityBox.Text), Parity)
    End Sub



    Private Sub SoftwareFlowControlSelection(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlowControlBox.SelectedIndexChanged
        COMPort.Handshake = CType([Enum].Parse(GetType(Handshake), FlowControlBox.Text), Handshake)
    End Sub


    Private Sub ModemLamps(ByVal sender As Object, ByVal e As SerialPinChangedEventArgs) Handles COMPort.PinChanged
        If COMPort.DsrHolding Then
            DSRLamp.BackColor = Color.LightGreen
        Else
            DSRLamp.BackColor = Color.Gray
        End If
        If COMPort.CtsHolding Then
            CTSLamp.BackColor = Color.LightGreen
        Else
            CTSLamp.BackColor = Color.Gray
        End If
    End Sub



    Private Sub SaveText(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim SaveFileDialog1 As New SaveFileDialog()
        SaveFileDialog1.Filter = "Fichero de Texto (*.txt)|*.txt"
        SaveFileDialog1.Title = "Guardar como"
        If SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK _
            And SaveFileDialog1.FileName.Length > 0 Then
            My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, Txtbox_Recibe.Text, False) ' Overwrite file
        End If
        Me.TxtBoxTransmite.Focus()
    End Sub

    Private Sub BtnYes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnYes.Click

        Me.TxtBoxTransmite.Text = "y"
        Me.Transmitir_Comando()
        Me.TxtBoxTransmite.Focus()

    End Sub

    Private Sub Transmitir_Comando()

        SpaceCount = 0
        Dim TextString As String
        If COMPort.IsOpen Then
            TextString = TxtBoxTransmite.Text

            Try
                Dim a As New System.Text.UTF8Encoding
                COMPort.Encoding = a
                COMPort.Write(TextString & Microsoft.VisualBasic.vbCr)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Puerto COM cerrado")
        End If
        TxtBoxTransmite.Text = ""


    End Sub


    Private Sub BtnGuardarPlantilla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardarPlantilla.Click
        Me.TxtBoxTransmite.Text = "en"
        Me.Transmitir_Comando()
        Me.TxtBoxTransmite.Text = "copy running-config flash:conf" & System.DateTime.Now.ToShortDateString.ToString.Replace("/", "") & ".txt"
        Me.Transmitir_Comando()
        Me.TxtBoxTransmite.Focus()

    End Sub

    Private Sub BtnEliminarIOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminarIOS.Click
        Me.Transmitir_Comando()
        Me.TxtBoxTransmite.Text = "enable"
        Me.TxtBoxTransmite.Focus()
        Me.Transmitir_Comando()
        Me.TxtBoxTransmite.Text = "delete flash:"
        Me.Transmitir_Comando()
        Me.TxtBoxTransmite.Focus()
    End Sub


    Private Sub BtnEraseStartup_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEraseStartup.Click

        Me.TxtBoxTransmite.Text = "erase startup-config"
        Me.Transmitir_Comando()
        Me.TxtBoxTransmite.Focus()

    End Sub


    

    Private Sub Btn_ComandoShVer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_ComandoShVer.Click
        Me.TxtBoxTransmite.Text = "sh ver"
        Me.Transmitir_Comando()
        Me.TxtBoxTransmite.Focus()
    End Sub

    Private Sub Btn_comandoShRun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_comandoShRun.Click
        Me.TxtBoxTransmite.Text = "en"
        Me.Transmitir_Comando()

        Me.TxtBoxTransmite.Text = "sh run"
        Me.Transmitir_Comando()
        Me.TxtBoxTransmite.Focus()
    End Sub

    Private Sub Btn_ComandoDirFlahs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_ComandoDirFlahs.Click
        Me.TxtBoxTransmite.Text = "en"
        Me.Transmitir_Comando()

        Me.TxtBoxTransmite.Text = "dir"
        Me.Transmitir_Comando()
        Me.TxtBoxTransmite.Focus()
    End Sub

    Private Sub Btn_ComandoConfTer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_ComandoConfTer.Click
        Me.TxtBoxTransmite.Text = "en"
        Me.Transmitir_Comando()
        Me.TxtBoxTransmite.Text = "conf ter"
        Me.Transmitir_Comando()
        Me.TxtBoxTransmite.Focus()
    End Sub

    Private Sub BtnNo_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNo.Click
        Me.TxtBoxTransmite.Text = "n"
        Me.Transmitir_Comando()
        Me.TxtBoxTransmite.Focus()
    End Sub

    Private Sub BtnWanUP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.TxtBoxTransmite.Text = "conf ter"
        Me.Transmitir_Comando()
        Me.TxtBoxTransmite.Text = "sh interface "
        Me.Transmitir_Comando()
        Me.TxtBoxTransmite.Text = "no shut"
        Me.Transmitir_Comando()

    End Sub


    Private Sub BtnGuardarEnCisco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardarEnCisco.Click
        Me.OpenFD.Title = "Seleccione el fichero de configuracion para el cisco"
        Me.OpenFD.FileName = "*.txt"
        ' entramos en modo configuracion si no estamos 
        Me.TxtBoxTransmite.Text = "en"
        Me.Transmitir_Comando()
        Me.TxtBoxTransmite.Text = "conf ter"
        Me.Transmitir_Comando()
        System.Threading.Thread.Sleep(100)

        If Me.OpenFD.ShowDialog() = DialogResult.OK Then
            Dim file As New IO.StreamReader(Me.OpenFD.FileName)

            While (Not file.EndOfStream)

                Me.TxtBoxTransmite.Text = file.ReadLine()
                System.Threading.Thread.Sleep(10)
                Me.Transmitir_Comando()
                'System.Threading.Thread.Sleep(10)
                'Me.Transmitir_Comando()

            End While
            Me.TxtBoxTransmite.Text = "wr" 'guardamos la plantilla de configuracion
            Me.Transmitir_Comando()
            MsgBox("Plantilla cargada y  guardada")
        End If
        Me.TxtBoxTransmite.Focus()

    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.TxtBoxTransmite.Text = "exit"
        Me.Transmitir_Comando()
        Me.TxtBoxTransmite.Focus()
    End Sub

    Private Sub BtnEliminarPlantilla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminarPlantilla.Click
        'entramos en modo configuracion si no estamos 
        Me.TxtBoxTransmite.Text = "en"
        Me.Transmitir_Comando()
        ' eliminamos la plantilla del sistema
        Me.TxtBoxTransmite.Text = "erase startup-config"
        Me.Transmitir_Comando()
        Me.TxtBoxTransmite.Focus()

    End Sub

   

  

    Private Sub IPADDRESS19216811ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IPADDRESS19216811ToolStripMenuItem.Click
        Me.Transmitir_Comando()
        System.Threading.Thread.Sleep(200)
        Me.TxtBoxTransmite.Text = "IP_ADDRESS=192.168.1.1"
        Me.Transmitir_Comando()
        System.Threading.Thread.Sleep(200)
    End Sub

    Private Sub IPSUBNETMASK2552552550ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IPSUBNETMASK2552552550ToolStripMenuItem.Click
        Me.TxtBoxTransmite.Text = "IP_SUBNET_MASK=255.255.255.0"
        Me.Transmitir_Comando()
        System.Threading.Thread.Sleep(200)
    End Sub

    Private Sub DEFAULTGATEWAY19216811ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DEFAULTGATEWAY19216811ToolStripMenuItem.Click
        Me.TxtBoxTransmite.Text = "DEFAULT_GATEWAY=192.168.1.1"
        Me.Transmitir_Comando()
        System.Threading.Thread.Sleep(200)
    End Sub

    Private Sub TFTPSERVER19216812ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TFTPSERVER19216812ToolStripMenuItem.Click
        System.Threading.Thread.Sleep(200)
        Me.TxtBoxTransmite.Text = "TFTP_SERVER=192.168.1.2"
        Me.Transmitir_Comando()
        System.Threading.Thread.Sleep(200)
    End Sub

    Private Sub TFTPDNLDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TFTPDNLDToolStripMenuItem.Click
        System.Threading.Thread.Sleep(200)
        Me.TxtBoxTransmite.Text = "tftpdnld"
        Me.Transmitir_Comando()
    End Sub

    Private Sub CopyTftpiosbinFlashToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyTftpiosbinFlashToolStripMenuItem.Click
        MsgBox(" Conecte el cable de Ethernet de su PC con el Servidor TFTP al CISCO en su conexion ethernet FE4." & Microsoft.VisualBasic.vbLf _
              & "Configure la tarjeta de red con la " & Microsoft.VisualBasic.vbLf _
              & " IP_PC = 192.168.1.2 " & Microsoft.VisualBasic.vbLf _
              & " Mascara = 255.255.255.0 " & Microsoft.VisualBasic.vbLf _
              & " Gategay = 192.168.1.1" & Microsoft.VisualBasic.vbLf _
              & "Debes tener suficiente espacio en la flash para la IOS, sino borra archivos", MsgBoxStyle.Exclamation, "Atencion lee y configura")
        Me.OpenFD.Title = "Seleccione fichero con la IOS a cargar en el CISCO"
        Me.OpenFD.FileName = "*.bin"
        If OpenFD.ShowDialog() = DialogResult.OK Then
            Me.Transmitir_Comando()
            System.Threading.Thread.Sleep(200)
            Me.TxtBoxTransmite.Text = "conf ter"
            Me.Transmitir_Comando()
            System.Threading.Thread.Sleep(200)
            Me.TxtBoxTransmite.Text = "int F4"
            Me.Transmitir_Comando()
            System.Threading.Thread.Sleep(200)
            Me.TxtBoxTransmite.Text = "ip address 192.168.1.1 255.255.255.0"
            Me.Transmitir_Comando()
            System.Threading.Thread.Sleep(200)
            Me.TxtBoxTransmite.Text = "no shut"
            Me.Transmitir_Comando()
            System.Threading.Thread.Sleep(200)
            Me.TxtBoxTransmite.Text = "exit"
            Me.Transmitir_Comando()
            System.Threading.Thread.Sleep(200)
            Me.TxtBoxTransmite.Text = "exit"
            Me.Transmitir_Comando()
            System.Threading.Thread.Sleep(200)
            Me.TxtBoxTransmite.Text = "copy tftp:" + System.IO.Path.GetFileName(OpenFD.FileName) & " flash"    ' poner el nombre de la IOS
            Me.Transmitir_Comando()

        End If
    End Sub

    Private Sub TFTPFILEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TFTPFILEToolStripMenuItem.Click
        Me.OpenFD.Title = "Seleccione fichero con la IOS a cargar en el CISCO"
        Me.OpenFD.FileName = "*.bin"
        If OpenFD.ShowDialog() = DialogResult.OK Then
            Me.Transmitir_Comando()
            System.Threading.Thread.Sleep(200)
            Me.TxtBoxTransmite.Text = "TFTP_FILE=" + System.IO.Path.GetFileName(OpenFD.FileName)
            Me.Transmitir_Comando()
        End If
    End Sub

    Private Sub ServiceDhcpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ServiceDhcpToolStripMenuItem.Click
        System.Threading.Thread.Sleep(100)
        Me.TxtBoxTransmite.Text = "service dhcp"
        Me.Transmitir_Comando()
        System.Threading.Thread.Sleep(100)
    End Sub

    Private Sub BtnReload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReload.Click
        System.Threading.Thread.Sleep(200)
        Me.TxtBoxTransmite.Text = "reload"
        Me.Transmitir_Comando()
        System.Threading.Thread.Sleep(200)
        Me.TxtBoxTransmite.Focus()
    End Sub



    Private Sub TerMulCisco_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.tftp.Stop()
        Me.BarraEstadoTftp.Text = "TFTP OFF"
        Try
            Dim log As New System.IO.StreamWriter(System.IO.Directory.GetCurrentDirectory & "\log.txt", True)
            log.WriteLine(Me.Txtbox_Recibe.Text)
            log.Close()
        Catch ex As Exception
            MsgBox("no se ha podido crear el archivo de log")
        End Try
    End Sub

    Private Sub RutaIOSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RutaIOSToolStripMenuItem.Click
        If Me.FBDir.ShowDialog = DialogResult.OK Then
            Me.tftp.BasePath = Me.FBDir.SelectedPath
            Me.BarraEstadoRutaTFTP.Text = Me.tftp.BasePath
        End If
    End Sub

    Private Sub CargarIOSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CargarIOSToolStripMenuItem.Click
        MsgBox(" Conecte el cable de Ethernet de su PC con el Servidor TFTP al CISCO en su conexion ethernet." & Microsoft.VisualBasic.vbLf _
                      & "Configure la tarjeta de red con la " & Microsoft.VisualBasic.vbLf _
                      & " IP_PC = 192.168.1.2 " & Microsoft.VisualBasic.vbLf _
                      & " Mascara = 255.255.255.0 " & Microsoft.VisualBasic.vbLf _
                      & " Gategay = 192.168.1.1", MsgBoxStyle.Exclamation, "Atencion lee y configura")
        Me.OpenFD.Title = "Seleccione fichero con la IOS a cargar en el CISCO"
        Me.OpenFD.FileName = "*.bin"
        If OpenFD.ShowDialog() = DialogResult.OK Then
            Me.Transmitir_Comando()
            System.Threading.Thread.Sleep(200)
            Me.TxtBoxTransmite.Text = "IP_ADDRESS=192.168.1.1"
            Me.Transmitir_Comando()
            System.Threading.Thread.Sleep(200)
            Me.TxtBoxTransmite.Text = "IP_SUBNET_MASK=255.255.255.0"
            Me.Transmitir_Comando()
            System.Threading.Thread.Sleep(200)
            Me.TxtBoxTransmite.Text = "DEFAULT_GATEWAY=192.168.1.1"
            Me.Transmitir_Comando()
            System.Threading.Thread.Sleep(200)
            Me.TxtBoxTransmite.Text = "TFTP_SERVER=192.168.1.2"
            Me.Transmitir_Comando()
            System.Threading.Thread.Sleep(200)
            Me.TxtBoxTransmite.Text = "TFTP_FILE=" + System.IO.Path.GetFileName(OpenFD.FileName) ' poner el nombre de la IOS
            Me.BarraEstadoRutaTFTP.Text = System.IO.Path.GetDirectoryName(OpenFD.FileName)
            Me.tftp.BasePath = System.IO.Path.GetDirectoryName(OpenFD.FileName)
            Me.Transmitir_Comando()
            System.Threading.Thread.Sleep(200)
            Me.TxtBoxTransmite.Text = "tftpdnld"
            Me.Transmitir_Comando()
        End If

    End Sub

    

    Private Sub ResetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetToolStripMenuItem.Click
        Me.TxtBoxTransmite.Text = "reset"
        Me.Transmitir_Comando()
    End Sub



    Private Sub BtnEnable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEnable.Click
        Me.TxtBoxTransmite.Text = "enable"
        Me.Transmitir_Comando()
        Me.TxtBoxTransmite.Focus()
    End Sub

    Private Sub ConfTerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfTerToolStripMenuItem.Click
        Me.TxtBoxTransmite.Text = "conf ter"
        Me.Transmitir_Comando()
    End Sub

    Private Sub IntF4ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IntF4ToolStripMenuItem.Click
        Me.TxtBoxTransmite.Text = "INT F4"
        Me.Transmitir_Comando()
    End Sub

    Private Sub IntEth0ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IntEth0ToolStripMenuItem.Click
        Me.TxtBoxTransmite.Text = "INT eth0"
        Me.Transmitir_Comando()
    End Sub

    Private Sub IpAddress192168112552552550ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IpAddress192168112552552550ToolStripMenuItem.Click
        Me.TxtBoxTransmite.Text = "ip address 192.168.1.1 255.255.255.0"
        Me.Transmitir_Comando()
    End Sub

    Private Sub NoShutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NoShutToolStripMenuItem.Click
        Me.TxtBoxTransmite.Text = "no shut"
        Me.Transmitir_Comando()
    End Sub

    Private Sub EndToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EndToolStripMenuItem.Click
        Me.TxtBoxTransmite.Text = "end"
        Me.Transmitir_Comando()
    End Sub

    Private Sub ShRunToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShRunToolStripMenuItem.Click
        Me.TxtBoxTransmite.Text = "sh run"
        Me.Transmitir_Comando()
    End Sub

    Private Sub DirFlashToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DirFlashToolStripMenuItem.Click
        Me.TxtBoxTransmite.Text = "dir"
        Me.Transmitir_Comando()
    End Sub

    Private Sub ShVerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShVerToolStripMenuItem.Click
        Me.TxtBoxTransmite.Text = "sh ver"
        Me.Transmitir_Comando()
    End Sub

    Private Sub ShowIpInterfaceBriefToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowIpInterfaceBriefToolStripMenuItem.Click
        Me.TxtBoxTransmite.Text = "sh ip interface brief"
        Me.Transmitir_Comando()
    End Sub

    Private Sub BootSystemFlashToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BootSystemFlashToolStripMenuItem.Click
        Me.TxtBoxTransmite.Text = ""
        Me.Transmitir_Comando()
    End Sub

    Private Sub CopyRunningconfigStartupconfigToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyRunningconfigStartupconfigToolStripMenuItem.Click
        Me.TxtBoxTransmite.Text = "copy running-config startup-config"
        Me.Transmitir_Comando()
    End Sub

    Private Sub CoyRunStartToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CoyRunStartToolStripMenuItem.Click
        Me.TxtBoxTransmite.Text = "copy run start"
        Me.Transmitir_Comando()
    End Sub

    Private Sub CopyRunningconfigTftpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyRunningconfigTftpToolStripMenuItem.Click
        Me.TxtBoxTransmite.Text = "copy running-config tftp"
        Me.Transmitir_Comando()
    End Sub

    Private Sub DeleteFlashToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteFlashToolStripMenuItem.Click
        Me.TxtBoxTransmite.Text = "delete flash"
        Me.Transmitir_Comando()
    End Sub

    Private Sub EraseFlashToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EraseFlashToolStripMenuItem1.Click
        Me.TxtBoxTransmite.Text = "erase flash"
        Me.Transmitir_Comando()
    End Sub

    Private Sub SETToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SETToolStripMenuItem.Click
        Me.TxtBoxTransmite.Text = "set"
        Me.Transmitir_Comando()
    End Sub

    Private Sub ShVerToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShVerToolStripMenuItem1.Click
        Me.TxtBoxTransmite.Text = "sh ver"
        Me.Transmitir_Comando()
    End Sub

    Private Sub ShFlashToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShFlashToolStripMenuItem.Click
        Me.TxtBoxTransmite.Text = "sh flash"
        Me.Transmitir_Comando()
    End Sub

    Private Sub AyudaToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AyudaToolStripMenuItem2.Click
        Me.TxtBoxTransmite.Text = "?"
        Me.Transmitir_Comando()

    End Sub

    Private Sub BarraEstadoTftp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BarraEstadoTftp.Click
        If Me.BarraEstadoTftp.BackColor = Color.Red Then
            TFTP_ACTIVO(True)
        Else
            TFTP_ACTIVO(False)
        End If

    End Sub


    Public Sub TFTP_ACTIVO(ByVal bool As Boolean)

        If Not bool Then
            Me.BarraEstadoTftp.Text = "TFTP OFF"
            Me.tftp.Stop()
            Me.BarraEstadoTftp.BackColor = Color.Red
        Else
            Me.BarraEstadoTftp.Text = "TFTP ON"
            Me.tftp.Start()
            Me.BarraEstadoTftp.BackColor = Color.Green
        End If

    End Sub

   

  
   
    Private Sub NoHayAyudaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComandosCiscoToolStripMenuItem.Click
        Dim f As New FrmAyuda
        f.ShowDialog()
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcercaDeToolStripMenuItem.Click
        Dim f As New FrmAcercade
        f.Show()

    End Sub

    
  

 


    Private Sub TxtBoxTransmite_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtBoxTransmite.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.TxtBoxTransmite.Focus()
            Me.Transmitir_Comando()

        End If
    End Sub


  
  
    Private Sub BtnCopy_Tftp_Cisco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCopy_Tftp_Cisco.Click

    End Sub
End Class
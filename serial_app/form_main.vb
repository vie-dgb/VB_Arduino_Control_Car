Imports System.IO.Ports

Public Class form_main
    'array checkbox and shape
    Dim chb_array As List(Of CheckBox) = New List(Of CheckBox)
    Dim shp_array As List(Of PowerPacks.OvalShape) = New List(Of PowerPacks.OvalShape)

    'array for serial mode
    Dim baud_array() As String = {"600", "1200", "2400", "4800", "9600", "14400", "19200", "38400", "56000", "57600", "115200"}
    Dim parity_array() As IO.Ports.Parity = {IO.Ports.Parity.None, IO.Ports.Parity.Even, IO.Ports.Parity.Odd, IO.Ports.Parity.Mark}
    Dim data_bit_array() As String = {"7", "8"}
    Dim stop_bit_array() As IO.Ports.StopBits = {IO.Ports.StopBits.One, IO.Ports.StopBits.Two}

    Dim dataByte As Byte
    Dim _port_com As String
    Dim _port_baud As String
    Dim _port_parity As IO.Ports.Parity
    Dim _port_stopbit As IO.Ports.StopBits
    Dim _port_data_size As String

    'enum effect led
    Enum effect_led
        mode_1
        mode_2
        mode_3
        mode_4
        mode_5
    End Enum
    Dim _mode_effect As effect_led
    Dim _mode_cnt_eff As Byte

    'main form function
    Private Sub form_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'add array control checkbox and shape
        chb_array.AddRange({chb_bit0, chb_bit1, chb_bit2, chb_bit3, chb_bit4, chb_bit5, chb_bit6, chb_bit7})
        shp_array.AddRange({shp_led0, shp_led1, shp_led2, shp_led3, shp_led4, shp_led5, shp_led6, shp_led7})

        'add baud rate item
        For baud_cnt As Integer = 0 To (baud_array.Count() - 1)
            Dim item_baud_inner As New ToolStripMenuItem(baud_array(baud_cnt))
            item_baud_inner.Name = "baud_inner_" & baud_array(baud_cnt)
            'add item
            AddHandler item_baud_inner.Click, AddressOf baud_inner_Clicked
            tstr_baud.DropDownItems.Add(item_baud_inner)
        Next

        'add parity item
        For parity_cnt As Integer = 0 To (parity_array.Count() - 1)
            Dim item_parity_inner As New ToolStripMenuItem(parity_array(parity_cnt).ToString)
            item_parity_inner.Name = "parity_inner_" & Convert.ToString(parity_cnt)
            'add item
            AddHandler item_parity_inner.Click, AddressOf parity_inner_Clicked
            tstr_parity.DropDownItems.Add(item_parity_inner)
        Next

        'add stop bit item
        For stopbit_cnt As Integer = 0 To (stop_bit_array.Count() - 1)
            Dim item_stopbit_inner As New ToolStripMenuItem(stop_bit_array(stopbit_cnt).ToString)
            item_stopbit_inner.Name = "stopbit_inner_" & Convert.ToString(stopbit_cnt)
            'add item
            AddHandler item_stopbit_inner.Click, AddressOf stopbit_inner_Clicked
            tstr_stopbit.DropDownItems.Add(item_stopbit_inner)
        Next

        'add data bit size
        For databit_cnt As Integer = 0 To (data_bit_array.Count() - 1)
            Dim item_databit_inner As New ToolStripMenuItem(data_bit_array(databit_cnt).ToString)
            item_databit_inner.Name = "databit_inner_" & Convert.ToString(databit_cnt)
            'add item
            AddHandler item_databit_inner.Click, AddressOf databit_inner_Clicked
            tstr_dataSize.DropDownItems.Add(item_databit_inner)
        Next

        _port_com = "COM__"
        _port_baud = "9600"
        _port_parity = IO.Ports.Parity.None
        _port_data_size = "8"
        tbx_tab2_timeDelay.Text = Val(trkbar_timeDelay.Value)
        cbb_effect_led.SelectedIndex() = 0
        update_status_line()
        btn_tab1_send.Enabled = False
        btn_tab1_clear.Enabled = False
        btn_tab2_effect.Enabled = False
        tbx_tab2_maxDelay.Text = trkbar_timeDelay.Maximum
        tbx_tab2_minDelay.Text = trkbar_timeDelay.Minimum
    End Sub

    'event of item baud inner click
    Private Sub baud_inner_Clicked(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim DropDowntxt As String = DirectCast(sender, ToolStripItem).Text
        _port_baud = DropDowntxt
        _SerialPort.BaudRate = _port_baud
        update_status_line()
    End Sub

    'event of item parity inner click
    Private Sub parity_inner_Clicked(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim DropDownindex As String = DirectCast(sender, ToolStripItem).Name
        _port_parity = parity_array(Val(Strings.Right(DropDownindex, 1)))
        _SerialPort.Parity = _port_parity
        update_status_line()
    End Sub

    'event of item stop bit inner click
    Private Sub stopbit_inner_Clicked(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim DropDownindex As String = DirectCast(sender, ToolStripItem).Name
        _port_stopbit = stop_bit_array(Val(Strings.Right(DropDownindex, 1)))
        _SerialPort.StopBits = _port_stopbit
        update_status_line()
    End Sub

    'event of item data bit inner click
    Private Sub databit_inner_Clicked(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim DropDowntxt As String = DirectCast(sender, ToolStripItem).Text
        _port_data_size = DropDowntxt
        _SerialPort.DataBits = _port_data_size
        update_status_line()
    End Sub

    'event of item COM port inner click
    Private Sub comport_inner_Clicked(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim DropDowntxt As String = DirectCast(sender, ToolStripItem).Text
        _port_com = DropDowntxt
        _SerialPort.PortName = _port_com
        update_status_line()
    End Sub

    'envent send button in tab 1
    Private Sub btn_tab1_send_Click(sender As Object, e As EventArgs) Handles btn_tab1_send.Click
        checkbit(dataByte)
        update_led(dataByte)
        update_textbox(dataByte)
        serial_write_byte(dataByte)
    End Sub

    'envent clear button in tab 1
    Private Sub btn_tab1_clear_Click(sender As Object, e As EventArgs) Handles btn_tab1_clear.Click
        dataByte = &H0
        update_bit(dataByte)
        update_led(dataByte)
        update_textbox(dataByte)
        serial_write_byte(dataByte)
    End Sub

    'event run/stop effect in tab 2
    Private Sub btn_tab2_effect_Click(sender As Object, e As EventArgs) Handles btn_tab2_effect.Click
        Dim abc As Byte = Convert.ToByte(cbb_effect_led.SelectedIndex) + &H_30
        Dim arr_effect() As Byte = New Byte() {&H_73, &H_53, &H_4C, &H_45, abc, &H_74}
        _SerialPort.Write(arr_effect, 0, 6)
    End Sub

    'event scroll bar of scroll bar delay(tab 2)
    Private Sub trkbar_timeDelay_Scroll(sender As Object, e As ScrollEventArgs) Handles trkbar_timeDelay.Scroll
        tbx_tab2_timeDelay.Text = trkbar_timeDelay.Value
    End Sub

    'event textbox change of text box delay(tab 2)
    Private Sub tbx_tab2_timeDelay_TextChanged(sender As Object, e As EventArgs) Handles tbx_tab2_timeDelay.TextChanged
        trkbar_timeDelay.Value = Val(tbx_tab2_timeDelay.Text)
    End Sub

    'event textbox change of time delay(tab 2)
    Private Sub tbx_tab2_minDelay_TextChanged(sender As Object, e As EventArgs) Handles tbx_tab2_minDelay.TextChanged
        If (trkbar_timeDelay.Value - Val(tbx_tab2_minDelay.Text)) < 10 Or (Val(tbx_tab2_minDelay.Text) < 0) Then
            MsgBox("Error", vbOKOnly + vbInformation, "Noti")
        Else
            trkbar_timeDelay.Minimum = Val(tbx_tab2_minDelay.Text)
        End If
    End Sub

    'event textbox change of time delay(tab 2)
    Private Sub tbx_tab2_maxDelay_TextChanged(sender As Object, e As EventArgs) Handles tbx_tab2_maxDelay.TextChanged
        If (Val(tbx_tab2_maxDelay.Text) > 5000) Or (Len(tbx_tab2_maxDelay.Text) < 0) Then
            MsgBox("Error", vbOKOnly + vbInformation, "Noti")
        Else
            trkbar_timeDelay.Maximum = Val(tbx_tab2_maxDelay.Text)
            trkbar_timeDelay.Value = trkbar_timeDelay.Maximum / 2
            tbx_tab2_timeDelay.Text = trkbar_timeDelay.Value
        End If
    End Sub

    'event click of menu trip setup
    Private Sub tstr_menu_setup_Click(sender As Object, e As EventArgs) Handles tstr_menu_setup.Click
        Dim COMPortList As ArrayList = New ArrayList()
        COMPortList.Clear()
        COMPortList.AddRange(IO.Ports.SerialPort.GetPortNames)
        sortCOMPortList(COMPortList)
        tstr_Comport.DropDownItems.Clear()

        For com_port_cnt As Integer = 0 To (COMPortList.Count() - 1)
            Dim item_comport_inner As New ToolStripMenuItem(COMPortList.Item(com_port_cnt).ToString)
            item_comport_inner.Name = "comport_inner_" & Convert.ToString(com_port_cnt)
            'add item
            AddHandler item_comport_inner.Click, AddressOf comport_inner_Clicked
            tstr_Comport.DropDownItems.Add(item_comport_inner)
        Next
    End Sub

    'event click of menu strip connect
    Private Sub tstr_connect_Click(sender As Object, e As EventArgs) Handles tstr_connect.Click
        Dim MsgConnect, StyleMsgConnect As String
        StyleMsgConnect = vbOKOnly + vbInformation
        If _SerialPort.IsOpen = False Then
            _SerialPort.PortName = _port_com
            Try
                _SerialPort.Open()
                MsgConnect = "Connect successfully."
                tstr_connect.Text = "Connected"
                btn_tab1_send.Enabled = True
                btn_tab1_clear.Enabled = True
                btn_tab2_effect.Enabled = True
            Catch ex As Exception
                MsgConnect = "COM Port used or not found, select another port."
            End Try
            MsgBox(MsgConnect, StyleMsgConnect, "Noti")
        Else
            _SerialPort.Close()
            tstr_connect.Text = "Disconnected"
            btn_tab1_send.Enabled = False
            btn_tab1_clear.Enabled = False
            btn_tab2_effect.Enabled = False
        End If
    End Sub

    'update status line function
    Sub update_status_line()
        tstr_status_line.Text = "[ " & _SerialPort.PortName.ToString & " - " & _SerialPort.BaudRate.ToString & " - " & _SerialPort.Parity.ToString
        tstr_status_line.Text = tstr_status_line.Text & " - " & _SerialPort.DataBits.ToString & " - " & _SerialPort.StopBits.ToString & " ]"
    End Sub

    'check bit in check box function
    Sub checkbit(ByRef dataCheck As Byte)
        dataCheck = 0
        For cntBit As Integer = 0 To (chb_array.Count() - 1)
            If chb_array.Item(cntBit).Checked = True Then
                dataCheck = dataCheck + (2 ^ cntBit)
            End If
        Next
    End Sub

    'update bit in check box function
    Sub update_bit(ByVal dataUp_chb As Byte)
        Dim resultBit As Byte
        For cntBit As Integer = 0 To (chb_array.Count() - 1)
            resultBit = (dataUp_chb >> cntBit) And &B_0000_0001
            If resultBit = 1 Then
                chb_array.Item(cntBit).Checked = True
            Else
                chb_array.Item(cntBit).Checked = False
            End If
        Next
    End Sub

    'update textbox function
    Sub update_textbox(ByVal dataTxb As Byte)
        'update bin textbox
        If Len(Convert.ToString(dataTxb, 2)) < 8 Then
            tbx_tab1_binVal.Text = "0"
            For i As Integer = 1 To (7 - Len(Convert.ToString(dataTxb, 2)))
                tbx_tab1_binVal.Text = "0" & tbx_tab1_binVal.Text
            Next
        End If
        tbx_tab1_binVal.Text = tbx_tab1_binVal.Text & Convert.ToString(dataTxb, 2)
        'update hex textbox
        If Len(Convert.ToString(dataTxb, 16)) < 2 Then
            tbx_tab1_hexVal.Text = "0"
            tbx_tab1_hexVal.Text = tbx_tab1_hexVal.Text & UCase(Convert.ToString(dataTxb, 16))
        Else
            tbx_tab1_hexVal.Text = UCase(Convert.ToString(dataTxb, 16))
        End If
        'update dec textbox
        tbx_tab1_decVal.Text = Convert.ToString(dataTxb, 10)
        tbx_tab1_octVal.Text = Convert.ToString(dataTxb, 8)
        tbx_tab1_ascii.Text = Strings.ChrW(dataTxb)
    End Sub

    'update led function
    Sub update_led(ByVal dataLed As Byte)
        Dim resultBit As Byte
        For cntLed As Integer = 0 To (shp_array.Count() - 1)
            resultBit = (dataLed >> cntLed) And &B_0000_0001
            If (resultBit = 1) And (shp_array.Item(cntLed).FillColor = Color.Gray) Then
                shp_array.Item(cntLed).FillColor = Color.Red
            ElseIf (resultBit = 0) And (shp_array.Item(cntLed).FillColor = Color.Red) Then
                shp_array.Item(cntLed).FillColor = Color.Gray
            End If
        Next
    End Sub

    'serial write byte function
    Sub serial_write_byte(ByVal byteSend As Byte)
        _SerialPort.Write(New Byte() {byteSend}, 0, 1)
    End Sub

    'sort name COM port
    Public Sub sortCOMPortList(ByRef comList As ArrayList)
        comList.Sort()
        Dim i As Integer = 0
        Dim tempPortList As ArrayList = New ArrayList()
        Do
            If Len(comList.Item(i)) = 4 Then
                tempPortList.Add(comList.Item(i))
                comList.RemoveAt(i)
            Else
                i = i + 1
            End If
        Loop While i < comList.Count
        tempPortList.AddRange(comList)
        comList = tempPortList
    End Sub


    '---------------Serial receive data-------------------------'
    Private Delegate Sub SerialDelegate(ByVal Buffer() As Byte)
    Private adre As New SerialDelegate(AddressOf DisplayData)
    ' serial port received data event
    Private Sub _SerialPort_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles _SerialPort.DataReceived
        Dim bytes As Integer = _SerialPort.BytesToRead
        Dim comBuffer As Byte() = New Byte(bytes - 1) {}
        _SerialPort.Read(comBuffer, 0, bytes)
        Me.Invoke(adre, comBuffer)
    End Sub
    'declare buff and index
    Dim buffTemp(20) As Byte
    Dim rstate As Integer = 0
    Dim buffIndex As Integer = 0
    Dim rxFlagEnd As Boolean = False
    ' function call by envent data received
    Private Sub DisplayData(ByVal sdata() As Byte)
        Dim lstbyte As Byte = &H_00
        For tempIndex As Integer = 0 To (sdata.Count - 1)
            If rstate = 0 Then
                buffIndex = 0
                If sdata(tempIndex) = &H_73 Then
                    buffTemp(buffIndex) = sdata(tempIndex)
                    lstbyte = sdata(tempIndex)
                    buffIndex = buffIndex + 1
                    rstate = 1
                End If
            Else
                If (sdata(tempIndex) = &H_74) And (lstbyte <> &H_65) Then
                    rstate = 0
                    buffTemp(buffIndex) = sdata(tempIndex)
                    lstbyte = sdata(tempIndex)
                    buffIndex = buffIndex + 1
                    buffTemp(buffIndex) = &H_00
                    rxFlagEnd = True
                ElseIf (sdata(tempIndex) = &H_73) And (lstbyte <> &H_65) Then
                    buffIndex = 0
                    buffTemp(buffIndex) = sdata(tempIndex)
                    lstbyte = sdata(tempIndex)
                    buffIndex = buffIndex + 1
                Else
                    buffTemp(buffIndex) = sdata(tempIndex)
                    lstbyte = sdata(tempIndex)
                    buffIndex = buffIndex + 1
                End If
            End If
        Next

        If rxFlagEnd = True Then
            'update to rich textbox
            Dim printTempStr As String = ""
            For cntPrint As Integer = 0 To (buffIndex - 1)
                printTempStr = printTempStr & " | " & UCase(Convert.ToString(buffTemp(cntPrint), 16)) & " | "
            Next
            rtbx_tab3_readHex.AppendText(Environment.NewLine & printTempStr)
            rtbx_tab3_readAscii.AppendText(Environment.NewLine & System.Text.Encoding.ASCII.GetString(buffTemp, 0, buffIndex))

            'check command
            Dim checkCommand As String = System.Text.Encoding.ASCII.GetString(buffTemp, 1, 3)
            If checkCommand = "REP" Then
                update_led(buffTemp(4))
                update_textbox(buffTemp(4))
                update_bit(buffTemp(4))
            End If
            rxFlagEnd = False
        End If
    End Sub
End Class

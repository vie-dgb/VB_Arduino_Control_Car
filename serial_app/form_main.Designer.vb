<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form_main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_main))
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.rectan_Stepper_state = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.shp_led0 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.shp_led1 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.shp_led2 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.shp_led3 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.shp_led4 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.shp_led5 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.shp_led6 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.shp_led7 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.lb_led7 = New System.Windows.Forms.Label()
        Me.lb_led6 = New System.Windows.Forms.Label()
        Me.lb_led4 = New System.Windows.Forms.Label()
        Me.lb_led5 = New System.Windows.Forms.Label()
        Me.lb_led0 = New System.Windows.Forms.Label()
        Me.lb_led1 = New System.Windows.Forms.Label()
        Me.lb_led2 = New System.Windows.Forms.Label()
        Me.lb_led3 = New System.Windows.Forms.Label()
        Me.menu_strip = New System.Windows.Forms.MenuStrip()
        Me.tstr_menu_setup = New System.Windows.Forms.ToolStripMenuItem()
        Me.tstr_Comport = New System.Windows.Forms.ToolStripMenuItem()
        Me.tstr_baud = New System.Windows.Forms.ToolStripMenuItem()
        Me.tstr_dataSize = New System.Windows.Forms.ToolStripMenuItem()
        Me.tstr_parity = New System.Windows.Forms.ToolStripMenuItem()
        Me.tstr_stopbit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tstr_connect = New System.Windows.Forms.ToolStripMenuItem()
        Me.tstr_status_line = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutMeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me._SerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.lb_stepDirection = New System.Windows.Forms.Label()
        Me.lb_stepState = New System.Windows.Forms.Label()
        Me.lb_step_run = New System.Windows.Forms.Label()
        Me.lb_step_dir = New System.Windows.Forms.Label()
        Me.tabCtrl_main_cli = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tbx_tab3_writeCli = New System.Windows.Forms.TextBox()
        Me.lb_tab3_writeCli = New System.Windows.Forms.Label()
        Me.rtbx_tab3_readAscii = New System.Windows.Forms.RichTextBox()
        Me.rtbx_tab3_readHex = New System.Windows.Forms.RichTextBox()
        Me.chb_tab3_autoScroll = New System.Windows.Forms.CheckBox()
        Me.btn_tab3_clear = New System.Windows.Forms.Button()
        Me.rtbx_tab3_readAll = New System.Windows.Forms.RichTextBox()
        Me.lb_tab3_All = New System.Windows.Forms.Label()
        Me.lb_tab3_cHex = New System.Windows.Forms.Label()
        Me.lb_tab3_cAscii = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tabCtrl_main_stepCtrl = New System.Windows.Forms.TabPage()
        Me.btn_tab4_UpStaStep = New System.Windows.Forms.Button()
        Me.btn_tab4_RunStep = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btn_tab4_ReDir = New System.Windows.Forms.Button()
        Me.btn_tab4_UpDirStep = New System.Windows.Forms.Button()
        Me.tbx_tab4_timeStepper = New System.Windows.Forms.TextBox()
        Me.lb_tab4_timeStepper = New System.Windows.Forms.Label()
        Me.trkbar_timeStepper = New MetroFramework.Controls.MetroTrackBar()
        Me.tabCtrl_main_effect = New System.Windows.Forms.TabPage()
        Me.picbx_tab2_logo = New System.Windows.Forms.PictureBox()
        Me.cbb_effect_led = New System.Windows.Forms.ComboBox()
        Me.lb_tab2_effectLed = New System.Windows.Forms.Label()
        Me.btn_tab2_effect = New System.Windows.Forms.Button()
        Me.trkbar_timeDelay = New MetroFramework.Controls.MetroTrackBar()
        Me.lb_tab2_timeDelay = New System.Windows.Forms.Label()
        Me.tbx_tab2_timeDelay = New System.Windows.Forms.TextBox()
        Me.chb_tab2_respState = New System.Windows.Forms.CheckBox()
        Me.tabCtrl_main_chb = New System.Windows.Forms.TabPage()
        Me.chb_bit0 = New System.Windows.Forms.CheckBox()
        Me.chb_bit1 = New System.Windows.Forms.CheckBox()
        Me.chb_bit2 = New System.Windows.Forms.CheckBox()
        Me.chb_bit3 = New System.Windows.Forms.CheckBox()
        Me.chb_bit7 = New System.Windows.Forms.CheckBox()
        Me.chb_bit6 = New System.Windows.Forms.CheckBox()
        Me.chb_bit5 = New System.Windows.Forms.CheckBox()
        Me.chb_bit4 = New System.Windows.Forms.CheckBox()
        Me.btn_tab1_send = New System.Windows.Forms.Button()
        Me.tbx_tab1_hexVal = New System.Windows.Forms.TextBox()
        Me.tbx_tab1_binVal = New System.Windows.Forms.TextBox()
        Me.tbx_tab1_decVal = New System.Windows.Forms.TextBox()
        Me.lb_tab1_binVal = New System.Windows.Forms.Label()
        Me.lb_tab1_hexVal = New System.Windows.Forms.Label()
        Me.lb_tab1_decVal = New System.Windows.Forms.Label()
        Me.picbx_tab1_logo = New System.Windows.Forms.PictureBox()
        Me.btn_tab1_clear = New System.Windows.Forms.Button()
        Me.tbx_tab1_ascii = New System.Windows.Forms.TextBox()
        Me.tbx_tab1_octVal = New System.Windows.Forms.TextBox()
        Me.lb_tab1_octVal = New System.Windows.Forms.Label()
        Me.lb_tab1_ascii = New System.Windows.Forms.Label()
        Me.tabCtrl_main = New System.Windows.Forms.TabControl()
        Me.menu_strip.SuspendLayout()
        Me.tabCtrl_main_cli.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabCtrl_main_stepCtrl.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabCtrl_main_effect.SuspendLayout()
        CType(Me.picbx_tab2_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabCtrl_main_chb.SuspendLayout()
        CType(Me.picbx_tab1_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabCtrl_main.SuspendLayout()
        Me.SuspendLayout()
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.rectan_Stepper_state, Me.shp_led0, Me.shp_led1, Me.shp_led2, Me.shp_led3, Me.shp_led4, Me.shp_led5, Me.shp_led6, Me.shp_led7})
        Me.ShapeContainer1.Size = New System.Drawing.Size(782, 503)
        Me.ShapeContainer1.TabIndex = 1
        Me.ShapeContainer1.TabStop = False
        '
        'rectan_Stepper_state
        '
        Me.rectan_Stepper_state.FillColor = System.Drawing.Color.Silver
        Me.rectan_Stepper_state.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.rectan_Stepper_state.Location = New System.Drawing.Point(270, 180)
        Me.rectan_Stepper_state.Name = "rectan_Stepper_state"
        Me.rectan_Stepper_state.Size = New System.Drawing.Size(75, 23)
        '
        'shp_led0
        '
        Me.shp_led0.FillColor = System.Drawing.Color.Gray
        Me.shp_led0.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.shp_led0.Location = New System.Drawing.Point(673, 70)
        Me.shp_led0.Name = "shp_led0"
        Me.shp_led0.Size = New System.Drawing.Size(30, 30)
        '
        'shp_led1
        '
        Me.shp_led1.FillColor = System.Drawing.Color.Gray
        Me.shp_led1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.shp_led1.Location = New System.Drawing.Point(590, 70)
        Me.shp_led1.Name = "shp_led1"
        Me.shp_led1.Size = New System.Drawing.Size(30, 30)
        '
        'shp_led2
        '
        Me.shp_led2.FillColor = System.Drawing.Color.Gray
        Me.shp_led2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.shp_led2.Location = New System.Drawing.Point(507, 70)
        Me.shp_led2.Name = "shp_led2"
        Me.shp_led2.Size = New System.Drawing.Size(30, 30)
        '
        'shp_led3
        '
        Me.shp_led3.FillColor = System.Drawing.Color.Gray
        Me.shp_led3.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.shp_led3.Location = New System.Drawing.Point(424, 70)
        Me.shp_led3.Name = "shp_led3"
        Me.shp_led3.Size = New System.Drawing.Size(30, 30)
        '
        'shp_led4
        '
        Me.shp_led4.FillColor = System.Drawing.Color.Gray
        Me.shp_led4.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.shp_led4.Location = New System.Drawing.Point(341, 70)
        Me.shp_led4.Name = "shp_led4"
        Me.shp_led4.Size = New System.Drawing.Size(30, 30)
        '
        'shp_led5
        '
        Me.shp_led5.FillColor = System.Drawing.Color.Gray
        Me.shp_led5.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.shp_led5.Location = New System.Drawing.Point(258, 70)
        Me.shp_led5.Name = "shp_led5"
        Me.shp_led5.Size = New System.Drawing.Size(30, 30)
        '
        'shp_led6
        '
        Me.shp_led6.FillColor = System.Drawing.Color.Gray
        Me.shp_led6.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.shp_led6.Location = New System.Drawing.Point(175, 70)
        Me.shp_led6.Name = "shp_led6"
        Me.shp_led6.Size = New System.Drawing.Size(30, 30)
        '
        'shp_led7
        '
        Me.shp_led7.FillColor = System.Drawing.Color.Gray
        Me.shp_led7.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.shp_led7.Location = New System.Drawing.Point(92, 70)
        Me.shp_led7.Name = "shp_led7"
        Me.shp_led7.Size = New System.Drawing.Size(30, 30)
        '
        'lb_led7
        '
        Me.lb_led7.AutoSize = True
        Me.lb_led7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_led7.Location = New System.Drawing.Point(88, 120)
        Me.lb_led7.Name = "lb_led7"
        Me.lb_led7.Size = New System.Drawing.Size(52, 17)
        Me.lb_led7.TabIndex = 2
        Me.lb_led7.Text = "LED 7"
        '
        'lb_led6
        '
        Me.lb_led6.AutoSize = True
        Me.lb_led6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_led6.Location = New System.Drawing.Point(171, 120)
        Me.lb_led6.Name = "lb_led6"
        Me.lb_led6.Size = New System.Drawing.Size(52, 17)
        Me.lb_led6.TabIndex = 3
        Me.lb_led6.Text = "LED 6"
        '
        'lb_led4
        '
        Me.lb_led4.AutoSize = True
        Me.lb_led4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_led4.Location = New System.Drawing.Point(337, 120)
        Me.lb_led4.Name = "lb_led4"
        Me.lb_led4.Size = New System.Drawing.Size(52, 17)
        Me.lb_led4.TabIndex = 5
        Me.lb_led4.Text = "LED 4"
        '
        'lb_led5
        '
        Me.lb_led5.AutoSize = True
        Me.lb_led5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_led5.Location = New System.Drawing.Point(254, 120)
        Me.lb_led5.Name = "lb_led5"
        Me.lb_led5.Size = New System.Drawing.Size(52, 17)
        Me.lb_led5.TabIndex = 4
        Me.lb_led5.Text = "LED 5"
        '
        'lb_led0
        '
        Me.lb_led0.AutoSize = True
        Me.lb_led0.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_led0.Location = New System.Drawing.Point(669, 120)
        Me.lb_led0.Name = "lb_led0"
        Me.lb_led0.Size = New System.Drawing.Size(52, 17)
        Me.lb_led0.TabIndex = 9
        Me.lb_led0.Text = "LED 0"
        '
        'lb_led1
        '
        Me.lb_led1.AutoSize = True
        Me.lb_led1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_led1.Location = New System.Drawing.Point(586, 120)
        Me.lb_led1.Name = "lb_led1"
        Me.lb_led1.Size = New System.Drawing.Size(52, 17)
        Me.lb_led1.TabIndex = 8
        Me.lb_led1.Text = "LED 1"
        '
        'lb_led2
        '
        Me.lb_led2.AutoSize = True
        Me.lb_led2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_led2.Location = New System.Drawing.Point(503, 120)
        Me.lb_led2.Name = "lb_led2"
        Me.lb_led2.Size = New System.Drawing.Size(52, 17)
        Me.lb_led2.TabIndex = 7
        Me.lb_led2.Text = "LED 2"
        '
        'lb_led3
        '
        Me.lb_led3.AutoSize = True
        Me.lb_led3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_led3.Location = New System.Drawing.Point(420, 120)
        Me.lb_led3.Name = "lb_led3"
        Me.lb_led3.Size = New System.Drawing.Size(52, 17)
        Me.lb_led3.TabIndex = 6
        Me.lb_led3.Text = "LED 3"
        '
        'menu_strip
        '
        Me.menu_strip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.menu_strip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tstr_menu_setup, Me.tstr_connect, Me.tstr_status_line, Me.AboutMeToolStripMenuItem})
        Me.menu_strip.Location = New System.Drawing.Point(0, 0)
        Me.menu_strip.Name = "menu_strip"
        Me.menu_strip.Size = New System.Drawing.Size(782, 28)
        Me.menu_strip.TabIndex = 10
        Me.menu_strip.Text = "menu_strip"
        '
        'tstr_menu_setup
        '
        Me.tstr_menu_setup.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tstr_Comport, Me.tstr_baud, Me.tstr_dataSize, Me.tstr_parity, Me.tstr_stopbit})
        Me.tstr_menu_setup.Name = "tstr_menu_setup"
        Me.tstr_menu_setup.Size = New System.Drawing.Size(61, 24)
        Me.tstr_menu_setup.Text = "Setup"
        '
        'tstr_Comport
        '
        Me.tstr_Comport.Name = "tstr_Comport"
        Me.tstr_Comport.Size = New System.Drawing.Size(157, 26)
        Me.tstr_Comport.Text = "COM port"
        '
        'tstr_baud
        '
        Me.tstr_baud.Name = "tstr_baud"
        Me.tstr_baud.Size = New System.Drawing.Size(157, 26)
        Me.tstr_baud.Text = "Baud"
        '
        'tstr_dataSize
        '
        Me.tstr_dataSize.Name = "tstr_dataSize"
        Me.tstr_dataSize.Size = New System.Drawing.Size(157, 26)
        Me.tstr_dataSize.Text = "Data size"
        '
        'tstr_parity
        '
        Me.tstr_parity.Name = "tstr_parity"
        Me.tstr_parity.Size = New System.Drawing.Size(157, 26)
        Me.tstr_parity.Text = "Parity"
        '
        'tstr_stopbit
        '
        Me.tstr_stopbit.Name = "tstr_stopbit"
        Me.tstr_stopbit.Size = New System.Drawing.Size(157, 26)
        Me.tstr_stopbit.Text = "Stop bit"
        '
        'tstr_connect
        '
        Me.tstr_connect.Name = "tstr_connect"
        Me.tstr_connect.Size = New System.Drawing.Size(113, 24)
        Me.tstr_connect.Text = "Disconnected"
        '
        'tstr_status_line
        '
        Me.tstr_status_line.Name = "tstr_status_line"
        Me.tstr_status_line.Size = New System.Drawing.Size(85, 24)
        Me.tstr_status_line.Text = "State line"
        '
        'AboutMeToolStripMenuItem
        '
        Me.AboutMeToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.AboutMeToolStripMenuItem.Name = "AboutMeToolStripMenuItem"
        Me.AboutMeToolStripMenuItem.Size = New System.Drawing.Size(89, 24)
        Me.AboutMeToolStripMenuItem.Text = "About me"
        '
        '_SerialPort
        '
        '
        'lb_stepDirection
        '
        Me.lb_stepDirection.AutoSize = True
        Me.lb_stepDirection.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_stepDirection.Location = New System.Drawing.Point(420, 183)
        Me.lb_stepDirection.Name = "lb_stepDirection"
        Me.lb_stepDirection.Size = New System.Drawing.Size(98, 20)
        Me.lb_stepDirection.TabIndex = 13
        Me.lb_stepDirection.Text = "Direction :"
        '
        'lb_stepState
        '
        Me.lb_stepState.AutoSize = True
        Me.lb_stepState.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_stepState.Location = New System.Drawing.Point(70, 183)
        Me.lb_stepState.Name = "lb_stepState"
        Me.lb_stepState.Size = New System.Drawing.Size(136, 20)
        Me.lb_stepState.TabIndex = 14
        Me.lb_stepState.Text = "Stepper State :"
        '
        'lb_step_run
        '
        Me.lb_step_run.AutoSize = True
        Me.lb_step_run.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_step_run.Location = New System.Drawing.Point(217, 183)
        Me.lb_step_run.Name = "lb_step_run"
        Me.lb_step_run.Size = New System.Drawing.Size(45, 20)
        Me.lb_step_run.TabIndex = 15
        Me.lb_step_run.Text = "OFF"
        '
        'lb_step_dir
        '
        Me.lb_step_dir.AutoSize = True
        Me.lb_step_dir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_step_dir.Location = New System.Drawing.Point(529, 183)
        Me.lb_step_dir.Name = "lb_step_dir"
        Me.lb_step_dir.Size = New System.Drawing.Size(39, 20)
        Me.lb_step_dir.TabIndex = 16
        Me.lb_step_dir.Text = "CW"
        '
        'tabCtrl_main_cli
        '
        Me.tabCtrl_main_cli.Controls.Add(Me.Label1)
        Me.tabCtrl_main_cli.Controls.Add(Me.lb_tab3_cAscii)
        Me.tabCtrl_main_cli.Controls.Add(Me.lb_tab3_cHex)
        Me.tabCtrl_main_cli.Controls.Add(Me.lb_tab3_All)
        Me.tabCtrl_main_cli.Controls.Add(Me.rtbx_tab3_readAll)
        Me.tabCtrl_main_cli.Controls.Add(Me.rtbx_tab3_readHex)
        Me.tabCtrl_main_cli.Controls.Add(Me.rtbx_tab3_readAscii)
        Me.tabCtrl_main_cli.Controls.Add(Me.tbx_tab3_writeCli)
        Me.tabCtrl_main_cli.Controls.Add(Me.btn_tab3_clear)
        Me.tabCtrl_main_cli.Controls.Add(Me.chb_tab3_autoScroll)
        Me.tabCtrl_main_cli.Controls.Add(Me.lb_tab3_writeCli)
        Me.tabCtrl_main_cli.Controls.Add(Me.PictureBox1)
        Me.tabCtrl_main_cli.Location = New System.Drawing.Point(4, 25)
        Me.tabCtrl_main_cli.Name = "tabCtrl_main_cli"
        Me.tabCtrl_main_cli.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCtrl_main_cli.Size = New System.Drawing.Size(774, 251)
        Me.tabCtrl_main_cli.TabIndex = 2
        Me.tabCtrl_main_cli.Text = "Command Line"
        Me.tabCtrl_main_cli.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.serial_app.My.Resources.Resources.mylogo
        Me.PictureBox1.Location = New System.Drawing.Point(689, 143)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(77, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'tbx_tab3_writeCli
        '
        Me.tbx_tab3_writeCli.Location = New System.Drawing.Point(160, 24)
        Me.tbx_tab3_writeCli.Name = "tbx_tab3_writeCli"
        Me.tbx_tab3_writeCli.Size = New System.Drawing.Size(166, 22)
        Me.tbx_tab3_writeCli.TabIndex = 19
        '
        'lb_tab3_writeCli
        '
        Me.lb_tab3_writeCli.AutoSize = True
        Me.lb_tab3_writeCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_tab3_writeCli.Location = New System.Drawing.Point(8, 24)
        Me.lb_tab3_writeCli.Name = "lb_tab3_writeCli"
        Me.lb_tab3_writeCli.Size = New System.Drawing.Size(146, 20)
        Me.lb_tab3_writeCli.TabIndex = 20
        Me.lb_tab3_writeCli.Text = "Write command:"
        '
        'rtbx_tab3_readAscii
        '
        Me.rtbx_tab3_readAscii.Location = New System.Drawing.Point(8, 102)
        Me.rtbx_tab3_readAscii.Name = "rtbx_tab3_readAscii"
        Me.rtbx_tab3_readAscii.Size = New System.Drawing.Size(145, 143)
        Me.rtbx_tab3_readAscii.TabIndex = 21
        Me.rtbx_tab3_readAscii.Text = ""
        '
        'rtbx_tab3_readHex
        '
        Me.rtbx_tab3_readHex.Location = New System.Drawing.Point(159, 102)
        Me.rtbx_tab3_readHex.Name = "rtbx_tab3_readHex"
        Me.rtbx_tab3_readHex.Size = New System.Drawing.Size(226, 141)
        Me.rtbx_tab3_readHex.TabIndex = 23
        Me.rtbx_tab3_readHex.Text = ""
        '
        'chb_tab3_autoScroll
        '
        Me.chb_tab3_autoScroll.AutoSize = True
        Me.chb_tab3_autoScroll.Location = New System.Drawing.Point(586, 26)
        Me.chb_tab3_autoScroll.Name = "chb_tab3_autoScroll"
        Me.chb_tab3_autoScroll.Size = New System.Drawing.Size(98, 21)
        Me.chb_tab3_autoScroll.TabIndex = 24
        Me.chb_tab3_autoScroll.Text = "Auto Scroll"
        Me.chb_tab3_autoScroll.UseVisualStyleBackColor = True
        '
        'btn_tab3_clear
        '
        Me.btn_tab3_clear.Location = New System.Drawing.Point(689, 24)
        Me.btn_tab3_clear.Name = "btn_tab3_clear"
        Me.btn_tab3_clear.Size = New System.Drawing.Size(75, 23)
        Me.btn_tab3_clear.TabIndex = 25
        Me.btn_tab3_clear.Text = "Clear"
        Me.btn_tab3_clear.UseVisualStyleBackColor = True
        '
        'rtbx_tab3_readAll
        '
        Me.rtbx_tab3_readAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbx_tab3_readAll.Location = New System.Drawing.Point(391, 102)
        Me.rtbx_tab3_readAll.Name = "rtbx_tab3_readAll"
        Me.rtbx_tab3_readAll.Size = New System.Drawing.Size(276, 143)
        Me.rtbx_tab3_readAll.TabIndex = 26
        Me.rtbx_tab3_readAll.Text = ""
        '
        'lb_tab3_All
        '
        Me.lb_tab3_All.AutoSize = True
        Me.lb_tab3_All.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_tab3_All.Location = New System.Drawing.Point(490, 79)
        Me.lb_tab3_All.Name = "lb_tab3_All"
        Me.lb_tab3_All.Size = New System.Drawing.Size(74, 20)
        Me.lb_tab3_All.TabIndex = 27
        Me.lb_tab3_All.Text = "All read"
        '
        'lb_tab3_cHex
        '
        Me.lb_tab3_cHex.AutoSize = True
        Me.lb_tab3_cHex.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_tab3_cHex.Location = New System.Drawing.Point(205, 79)
        Me.lb_tab3_cHex.Name = "lb_tab3_cHex"
        Me.lb_tab3_cHex.Size = New System.Drawing.Size(121, 20)
        Me.lb_tab3_cHex.TabIndex = 28
        Me.lb_tab3_cHex.Text = "Correct Hexa"
        '
        'lb_tab3_cAscii
        '
        Me.lb_tab3_cAscii.AutoSize = True
        Me.lb_tab3_cAscii.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_tab3_cAscii.Location = New System.Drawing.Point(11, 79)
        Me.lb_tab3_cAscii.Name = "lb_tab3_cAscii"
        Me.lb_tab3_cAscii.Size = New System.Drawing.Size(125, 20)
        Me.lb_tab3_cAscii.TabIndex = 29
        Me.lb_tab3_cAscii.Text = "Correct ASCII"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(344, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 20)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "<HLP> see command"
        '
        'tabCtrl_main_stepCtrl
        '
        Me.tabCtrl_main_stepCtrl.Controls.Add(Me.trkbar_timeStepper)
        Me.tabCtrl_main_stepCtrl.Controls.Add(Me.lb_tab4_timeStepper)
        Me.tabCtrl_main_stepCtrl.Controls.Add(Me.tbx_tab4_timeStepper)
        Me.tabCtrl_main_stepCtrl.Controls.Add(Me.btn_tab4_UpDirStep)
        Me.tabCtrl_main_stepCtrl.Controls.Add(Me.btn_tab4_ReDir)
        Me.tabCtrl_main_stepCtrl.Controls.Add(Me.PictureBox2)
        Me.tabCtrl_main_stepCtrl.Controls.Add(Me.btn_tab4_RunStep)
        Me.tabCtrl_main_stepCtrl.Controls.Add(Me.btn_tab4_UpStaStep)
        Me.tabCtrl_main_stepCtrl.Location = New System.Drawing.Point(4, 25)
        Me.tabCtrl_main_stepCtrl.Name = "tabCtrl_main_stepCtrl"
        Me.tabCtrl_main_stepCtrl.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCtrl_main_stepCtrl.Size = New System.Drawing.Size(774, 251)
        Me.tabCtrl_main_stepCtrl.TabIndex = 3
        Me.tabCtrl_main_stepCtrl.Text = "Control Stepper"
        Me.tabCtrl_main_stepCtrl.UseVisualStyleBackColor = True
        '
        'btn_tab4_UpStaStep
        '
        Me.btn_tab4_UpStaStep.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_tab4_UpStaStep.Location = New System.Drawing.Point(25, 80)
        Me.btn_tab4_UpStaStep.Name = "btn_tab4_UpStaStep"
        Me.btn_tab4_UpStaStep.Size = New System.Drawing.Size(133, 39)
        Me.btn_tab4_UpStaStep.TabIndex = 10
        Me.btn_tab4_UpStaStep.Text = "State Stepper"
        Me.btn_tab4_UpStaStep.UseVisualStyleBackColor = True
        '
        'btn_tab4_RunStep
        '
        Me.btn_tab4_RunStep.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_tab4_RunStep.Location = New System.Drawing.Point(25, 35)
        Me.btn_tab4_RunStep.Name = "btn_tab4_RunStep"
        Me.btn_tab4_RunStep.Size = New System.Drawing.Size(133, 39)
        Me.btn_tab4_RunStep.TabIndex = 11
        Me.btn_tab4_RunStep.Text = "Run Step"
        Me.btn_tab4_RunStep.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.serial_app.My.Resources.Resources.mylogo
        Me.PictureBox2.Location = New System.Drawing.Point(689, 143)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(77, 100)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'btn_tab4_ReDir
        '
        Me.btn_tab4_ReDir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_tab4_ReDir.Location = New System.Drawing.Point(171, 35)
        Me.btn_tab4_ReDir.Name = "btn_tab4_ReDir"
        Me.btn_tab4_ReDir.Size = New System.Drawing.Size(156, 39)
        Me.btn_tab4_ReDir.TabIndex = 20
        Me.btn_tab4_ReDir.Text = "Reverse Direction"
        Me.btn_tab4_ReDir.UseVisualStyleBackColor = True
        '
        'btn_tab4_UpDirStep
        '
        Me.btn_tab4_UpDirStep.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_tab4_UpDirStep.Location = New System.Drawing.Point(171, 80)
        Me.btn_tab4_UpDirStep.Name = "btn_tab4_UpDirStep"
        Me.btn_tab4_UpDirStep.Size = New System.Drawing.Size(157, 39)
        Me.btn_tab4_UpDirStep.TabIndex = 21
        Me.btn_tab4_UpDirStep.Text = "State Direction"
        Me.btn_tab4_UpDirStep.UseVisualStyleBackColor = True
        '
        'tbx_tab4_timeStepper
        '
        Me.tbx_tab4_timeStepper.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_tab4_timeStepper.Location = New System.Drawing.Point(171, 150)
        Me.tbx_tab4_timeStepper.Name = "tbx_tab4_timeStepper"
        Me.tbx_tab4_timeStepper.Size = New System.Drawing.Size(121, 27)
        Me.tbx_tab4_timeStepper.TabIndex = 25
        Me.tbx_tab4_timeStepper.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lb_tab4_timeStepper
        '
        Me.lb_tab4_timeStepper.AutoSize = True
        Me.lb_tab4_timeStepper.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_tab4_timeStepper.Location = New System.Drawing.Point(96, 153)
        Me.lb_tab4_timeStepper.Name = "lb_tab4_timeStepper"
        Me.lb_tab4_timeStepper.Size = New System.Drawing.Size(69, 20)
        Me.lb_tab4_timeStepper.TabIndex = 26
        Me.lb_tab4_timeStepper.Text = "Delay :"
        '
        'trkbar_timeStepper
        '
        Me.trkbar_timeStepper.BackColor = System.Drawing.Color.Transparent
        Me.trkbar_timeStepper.Location = New System.Drawing.Point(98, 195)
        Me.trkbar_timeStepper.Maximum = 1000
        Me.trkbar_timeStepper.Minimum = 100
        Me.trkbar_timeStepper.Name = "trkbar_timeStepper"
        Me.trkbar_timeStepper.Size = New System.Drawing.Size(194, 23)
        Me.trkbar_timeStepper.TabIndex = 27
        Me.trkbar_timeStepper.Text = "Time Delay"
        Me.trkbar_timeStepper.Value = 150
        '
        'tabCtrl_main_effect
        '
        Me.tabCtrl_main_effect.Controls.Add(Me.chb_tab2_respState)
        Me.tabCtrl_main_effect.Controls.Add(Me.tbx_tab2_timeDelay)
        Me.tabCtrl_main_effect.Controls.Add(Me.lb_tab2_timeDelay)
        Me.tabCtrl_main_effect.Controls.Add(Me.trkbar_timeDelay)
        Me.tabCtrl_main_effect.Controls.Add(Me.btn_tab2_effect)
        Me.tabCtrl_main_effect.Controls.Add(Me.lb_tab2_effectLed)
        Me.tabCtrl_main_effect.Controls.Add(Me.cbb_effect_led)
        Me.tabCtrl_main_effect.Controls.Add(Me.picbx_tab2_logo)
        Me.tabCtrl_main_effect.Location = New System.Drawing.Point(4, 25)
        Me.tabCtrl_main_effect.Name = "tabCtrl_main_effect"
        Me.tabCtrl_main_effect.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCtrl_main_effect.Size = New System.Drawing.Size(774, 251)
        Me.tabCtrl_main_effect.TabIndex = 1
        Me.tabCtrl_main_effect.Text = "Effect mode"
        Me.tabCtrl_main_effect.UseVisualStyleBackColor = True
        '
        'picbx_tab2_logo
        '
        Me.picbx_tab2_logo.Image = Global.serial_app.My.Resources.Resources.mylogo
        Me.picbx_tab2_logo.Location = New System.Drawing.Point(689, 143)
        Me.picbx_tab2_logo.Name = "picbx_tab2_logo"
        Me.picbx_tab2_logo.Size = New System.Drawing.Size(77, 100)
        Me.picbx_tab2_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picbx_tab2_logo.TabIndex = 17
        Me.picbx_tab2_logo.TabStop = False
        '
        'cbb_effect_led
        '
        Me.cbb_effect_led.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbb_effect_led.FormattingEnabled = True
        Me.cbb_effect_led.Items.AddRange(New Object() {"Off", "Mode 1", "Mode 2", "Mode 3", "Mode 4", "Mode 5"})
        Me.cbb_effect_led.Location = New System.Drawing.Point(100, 45)
        Me.cbb_effect_led.Name = "cbb_effect_led"
        Me.cbb_effect_led.Size = New System.Drawing.Size(121, 28)
        Me.cbb_effect_led.TabIndex = 18
        '
        'lb_tab2_effectLed
        '
        Me.lb_tab2_effectLed.AutoSize = True
        Me.lb_tab2_effectLed.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_tab2_effectLed.Location = New System.Drawing.Point(21, 48)
        Me.lb_tab2_effectLed.Name = "lb_tab2_effectLed"
        Me.lb_tab2_effectLed.Size = New System.Drawing.Size(71, 20)
        Me.lb_tab2_effectLed.TabIndex = 19
        Me.lb_tab2_effectLed.Text = "Effect :"
        '
        'btn_tab2_effect
        '
        Me.btn_tab2_effect.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_tab2_effect.Location = New System.Drawing.Point(266, 39)
        Me.btn_tab2_effect.Name = "btn_tab2_effect"
        Me.btn_tab2_effect.Size = New System.Drawing.Size(102, 39)
        Me.btn_tab2_effect.TabIndex = 20
        Me.btn_tab2_effect.Text = "Run effect"
        Me.btn_tab2_effect.UseVisualStyleBackColor = True
        '
        'trkbar_timeDelay
        '
        Me.trkbar_timeDelay.BackColor = System.Drawing.Color.Transparent
        Me.trkbar_timeDelay.Location = New System.Drawing.Point(27, 184)
        Me.trkbar_timeDelay.Maximum = 5000
        Me.trkbar_timeDelay.Minimum = 100
        Me.trkbar_timeDelay.Name = "trkbar_timeDelay"
        Me.trkbar_timeDelay.Size = New System.Drawing.Size(194, 23)
        Me.trkbar_timeDelay.TabIndex = 22
        Me.trkbar_timeDelay.Text = "Time Delay"
        Me.trkbar_timeDelay.Value = 2500
        '
        'lb_tab2_timeDelay
        '
        Me.lb_tab2_timeDelay.AutoSize = True
        Me.lb_tab2_timeDelay.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_tab2_timeDelay.Location = New System.Drawing.Point(23, 124)
        Me.lb_tab2_timeDelay.Name = "lb_tab2_timeDelay"
        Me.lb_tab2_timeDelay.Size = New System.Drawing.Size(69, 20)
        Me.lb_tab2_timeDelay.TabIndex = 23
        Me.lb_tab2_timeDelay.Text = "Delay :"
        '
        'tbx_tab2_timeDelay
        '
        Me.tbx_tab2_timeDelay.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_tab2_timeDelay.Location = New System.Drawing.Point(100, 121)
        Me.tbx_tab2_timeDelay.Name = "tbx_tab2_timeDelay"
        Me.tbx_tab2_timeDelay.Size = New System.Drawing.Size(121, 27)
        Me.tbx_tab2_timeDelay.TabIndex = 24
        Me.tbx_tab2_timeDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'chb_tab2_respState
        '
        Me.chb_tab2_respState.AutoSize = True
        Me.chb_tab2_respState.Location = New System.Drawing.Point(266, 126)
        Me.chb_tab2_respState.Name = "chb_tab2_respState"
        Me.chb_tab2_respState.Size = New System.Drawing.Size(152, 21)
        Me.chb_tab2_respState.TabIndex = 25
        Me.chb_tab2_respState.Text = "Response led state"
        Me.chb_tab2_respState.UseVisualStyleBackColor = True
        '
        'tabCtrl_main_chb
        '
        Me.tabCtrl_main_chb.Controls.Add(Me.lb_tab1_ascii)
        Me.tabCtrl_main_chb.Controls.Add(Me.lb_tab1_octVal)
        Me.tabCtrl_main_chb.Controls.Add(Me.tbx_tab1_octVal)
        Me.tabCtrl_main_chb.Controls.Add(Me.tbx_tab1_ascii)
        Me.tabCtrl_main_chb.Controls.Add(Me.tbx_tab1_decVal)
        Me.tabCtrl_main_chb.Controls.Add(Me.tbx_tab1_binVal)
        Me.tabCtrl_main_chb.Controls.Add(Me.tbx_tab1_hexVal)
        Me.tabCtrl_main_chb.Controls.Add(Me.btn_tab1_clear)
        Me.tabCtrl_main_chb.Controls.Add(Me.picbx_tab1_logo)
        Me.tabCtrl_main_chb.Controls.Add(Me.lb_tab1_decVal)
        Me.tabCtrl_main_chb.Controls.Add(Me.lb_tab1_hexVal)
        Me.tabCtrl_main_chb.Controls.Add(Me.lb_tab1_binVal)
        Me.tabCtrl_main_chb.Controls.Add(Me.btn_tab1_send)
        Me.tabCtrl_main_chb.Controls.Add(Me.chb_bit4)
        Me.tabCtrl_main_chb.Controls.Add(Me.chb_bit5)
        Me.tabCtrl_main_chb.Controls.Add(Me.chb_bit6)
        Me.tabCtrl_main_chb.Controls.Add(Me.chb_bit7)
        Me.tabCtrl_main_chb.Controls.Add(Me.chb_bit3)
        Me.tabCtrl_main_chb.Controls.Add(Me.chb_bit2)
        Me.tabCtrl_main_chb.Controls.Add(Me.chb_bit1)
        Me.tabCtrl_main_chb.Controls.Add(Me.chb_bit0)
        Me.tabCtrl_main_chb.Location = New System.Drawing.Point(4, 25)
        Me.tabCtrl_main_chb.Name = "tabCtrl_main_chb"
        Me.tabCtrl_main_chb.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCtrl_main_chb.Size = New System.Drawing.Size(774, 251)
        Me.tabCtrl_main_chb.TabIndex = 0
        Me.tabCtrl_main_chb.Text = "Check Box"
        Me.tabCtrl_main_chb.UseVisualStyleBackColor = True
        '
        'chb_bit0
        '
        Me.chb_bit0.AutoSize = True
        Me.chb_bit0.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chb_bit0.Location = New System.Drawing.Point(687, 40)
        Me.chb_bit0.Name = "chb_bit0"
        Me.chb_bit0.Size = New System.Drawing.Size(71, 24)
        Me.chb_bit0.TabIndex = 1
        Me.chb_bit0.Text = "Bit 0"
        Me.chb_bit0.UseVisualStyleBackColor = True
        '
        'chb_bit1
        '
        Me.chb_bit1.AutoSize = True
        Me.chb_bit1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chb_bit1.Location = New System.Drawing.Point(593, 40)
        Me.chb_bit1.Name = "chb_bit1"
        Me.chb_bit1.Size = New System.Drawing.Size(71, 24)
        Me.chb_bit1.TabIndex = 2
        Me.chb_bit1.Text = "Bit 1"
        Me.chb_bit1.UseVisualStyleBackColor = True
        '
        'chb_bit2
        '
        Me.chb_bit2.AutoSize = True
        Me.chb_bit2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chb_bit2.Location = New System.Drawing.Point(499, 40)
        Me.chb_bit2.Name = "chb_bit2"
        Me.chb_bit2.Size = New System.Drawing.Size(71, 24)
        Me.chb_bit2.TabIndex = 3
        Me.chb_bit2.Text = "Bit 2"
        Me.chb_bit2.UseVisualStyleBackColor = True
        '
        'chb_bit3
        '
        Me.chb_bit3.AutoSize = True
        Me.chb_bit3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chb_bit3.Location = New System.Drawing.Point(405, 40)
        Me.chb_bit3.Name = "chb_bit3"
        Me.chb_bit3.Size = New System.Drawing.Size(71, 24)
        Me.chb_bit3.TabIndex = 4
        Me.chb_bit3.Text = "Bit 3"
        Me.chb_bit3.UseVisualStyleBackColor = True
        '
        'chb_bit7
        '
        Me.chb_bit7.AutoSize = True
        Me.chb_bit7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chb_bit7.Location = New System.Drawing.Point(29, 40)
        Me.chb_bit7.Name = "chb_bit7"
        Me.chb_bit7.Size = New System.Drawing.Size(71, 24)
        Me.chb_bit7.TabIndex = 5
        Me.chb_bit7.Text = "Bit 7"
        Me.chb_bit7.UseVisualStyleBackColor = True
        '
        'chb_bit6
        '
        Me.chb_bit6.AutoSize = True
        Me.chb_bit6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chb_bit6.Location = New System.Drawing.Point(123, 40)
        Me.chb_bit6.Name = "chb_bit6"
        Me.chb_bit6.Size = New System.Drawing.Size(71, 24)
        Me.chb_bit6.TabIndex = 6
        Me.chb_bit6.Text = "Bit 6"
        Me.chb_bit6.UseVisualStyleBackColor = True
        '
        'chb_bit5
        '
        Me.chb_bit5.AutoSize = True
        Me.chb_bit5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chb_bit5.Location = New System.Drawing.Point(217, 40)
        Me.chb_bit5.Name = "chb_bit5"
        Me.chb_bit5.Size = New System.Drawing.Size(71, 24)
        Me.chb_bit5.TabIndex = 7
        Me.chb_bit5.Text = "Bit 5"
        Me.chb_bit5.UseVisualStyleBackColor = True
        '
        'chb_bit4
        '
        Me.chb_bit4.AutoSize = True
        Me.chb_bit4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chb_bit4.Location = New System.Drawing.Point(311, 40)
        Me.chb_bit4.Name = "chb_bit4"
        Me.chb_bit4.Size = New System.Drawing.Size(71, 24)
        Me.chb_bit4.TabIndex = 8
        Me.chb_bit4.Text = "Bit 4"
        Me.chb_bit4.UseVisualStyleBackColor = True
        '
        'btn_tab1_send
        '
        Me.btn_tab1_send.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_tab1_send.Location = New System.Drawing.Point(476, 103)
        Me.btn_tab1_send.Name = "btn_tab1_send"
        Me.btn_tab1_send.Size = New System.Drawing.Size(94, 39)
        Me.btn_tab1_send.TabIndex = 9
        Me.btn_tab1_send.Text = "Send"
        Me.btn_tab1_send.UseVisualStyleBackColor = True
        '
        'tbx_tab1_hexVal
        '
        Me.tbx_tab1_hexVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_tab1_hexVal.Location = New System.Drawing.Point(90, 150)
        Me.tbx_tab1_hexVal.Name = "tbx_tab1_hexVal"
        Me.tbx_tab1_hexVal.Size = New System.Drawing.Size(97, 27)
        Me.tbx_tab1_hexVal.TabIndex = 10
        Me.tbx_tab1_hexVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbx_tab1_binVal
        '
        Me.tbx_tab1_binVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_tab1_binVal.Location = New System.Drawing.Point(90, 100)
        Me.tbx_tab1_binVal.Name = "tbx_tab1_binVal"
        Me.tbx_tab1_binVal.Size = New System.Drawing.Size(97, 27)
        Me.tbx_tab1_binVal.TabIndex = 11
        Me.tbx_tab1_binVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbx_tab1_decVal
        '
        Me.tbx_tab1_decVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_tab1_decVal.Location = New System.Drawing.Point(90, 200)
        Me.tbx_tab1_decVal.Name = "tbx_tab1_decVal"
        Me.tbx_tab1_decVal.Size = New System.Drawing.Size(97, 27)
        Me.tbx_tab1_decVal.TabIndex = 12
        Me.tbx_tab1_decVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lb_tab1_binVal
        '
        Me.lb_tab1_binVal.AutoSize = True
        Me.lb_tab1_binVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_tab1_binVal.Location = New System.Drawing.Point(23, 103)
        Me.lb_tab1_binVal.Name = "lb_tab1_binVal"
        Me.lb_tab1_binVal.Size = New System.Drawing.Size(49, 20)
        Me.lb_tab1_binVal.TabIndex = 13
        Me.lb_tab1_binVal.Text = "Bin :"
        '
        'lb_tab1_hexVal
        '
        Me.lb_tab1_hexVal.AutoSize = True
        Me.lb_tab1_hexVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_tab1_hexVal.Location = New System.Drawing.Point(22, 153)
        Me.lb_tab1_hexVal.Name = "lb_tab1_hexVal"
        Me.lb_tab1_hexVal.Size = New System.Drawing.Size(54, 20)
        Me.lb_tab1_hexVal.TabIndex = 14
        Me.lb_tab1_hexVal.Text = "Hex :"
        '
        'lb_tab1_decVal
        '
        Me.lb_tab1_decVal.AutoSize = True
        Me.lb_tab1_decVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_tab1_decVal.Location = New System.Drawing.Point(22, 203)
        Me.lb_tab1_decVal.Name = "lb_tab1_decVal"
        Me.lb_tab1_decVal.Size = New System.Drawing.Size(55, 20)
        Me.lb_tab1_decVal.TabIndex = 15
        Me.lb_tab1_decVal.Text = "Dec :"
        '
        'picbx_tab1_logo
        '
        Me.picbx_tab1_logo.Image = Global.serial_app.My.Resources.Resources.mylogo
        Me.picbx_tab1_logo.Location = New System.Drawing.Point(689, 143)
        Me.picbx_tab1_logo.Name = "picbx_tab1_logo"
        Me.picbx_tab1_logo.Size = New System.Drawing.Size(77, 100)
        Me.picbx_tab1_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picbx_tab1_logo.TabIndex = 16
        Me.picbx_tab1_logo.TabStop = False
        '
        'btn_tab1_clear
        '
        Me.btn_tab1_clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_tab1_clear.Location = New System.Drawing.Point(476, 166)
        Me.btn_tab1_clear.Name = "btn_tab1_clear"
        Me.btn_tab1_clear.Size = New System.Drawing.Size(94, 35)
        Me.btn_tab1_clear.TabIndex = 17
        Me.btn_tab1_clear.Text = "Clear"
        Me.btn_tab1_clear.UseVisualStyleBackColor = True
        '
        'tbx_tab1_ascii
        '
        Me.tbx_tab1_ascii.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_tab1_ascii.Location = New System.Drawing.Point(311, 150)
        Me.tbx_tab1_ascii.Name = "tbx_tab1_ascii"
        Me.tbx_tab1_ascii.Size = New System.Drawing.Size(97, 27)
        Me.tbx_tab1_ascii.TabIndex = 18
        Me.tbx_tab1_ascii.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbx_tab1_octVal
        '
        Me.tbx_tab1_octVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_tab1_octVal.Location = New System.Drawing.Point(311, 100)
        Me.tbx_tab1_octVal.Name = "tbx_tab1_octVal"
        Me.tbx_tab1_octVal.Size = New System.Drawing.Size(97, 27)
        Me.tbx_tab1_octVal.TabIndex = 19
        Me.tbx_tab1_octVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lb_tab1_octVal
        '
        Me.lb_tab1_octVal.AutoSize = True
        Me.lb_tab1_octVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_tab1_octVal.Location = New System.Drawing.Point(235, 103)
        Me.lb_tab1_octVal.Name = "lb_tab1_octVal"
        Me.lb_tab1_octVal.Size = New System.Drawing.Size(51, 20)
        Me.lb_tab1_octVal.TabIndex = 20
        Me.lb_tab1_octVal.Text = "Oct :"
        '
        'lb_tab1_ascii
        '
        Me.lb_tab1_ascii.AutoSize = True
        Me.lb_tab1_ascii.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_tab1_ascii.Location = New System.Drawing.Point(234, 153)
        Me.lb_tab1_ascii.Name = "lb_tab1_ascii"
        Me.lb_tab1_ascii.Size = New System.Drawing.Size(63, 20)
        Me.lb_tab1_ascii.TabIndex = 21
        Me.lb_tab1_ascii.Text = "Ascii :"
        '
        'tabCtrl_main
        '
        Me.tabCtrl_main.Controls.Add(Me.tabCtrl_main_chb)
        Me.tabCtrl_main.Controls.Add(Me.tabCtrl_main_effect)
        Me.tabCtrl_main.Controls.Add(Me.tabCtrl_main_stepCtrl)
        Me.tabCtrl_main.Controls.Add(Me.tabCtrl_main_cli)
        Me.tabCtrl_main.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tabCtrl_main.Location = New System.Drawing.Point(0, 223)
        Me.tabCtrl_main.Multiline = True
        Me.tabCtrl_main.Name = "tabCtrl_main"
        Me.tabCtrl_main.SelectedIndex = 0
        Me.tabCtrl_main.Size = New System.Drawing.Size(782, 280)
        Me.tabCtrl_main.TabIndex = 0
        '
        'form_main
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(782, 503)
        Me.Controls.Add(Me.lb_step_dir)
        Me.Controls.Add(Me.lb_step_run)
        Me.Controls.Add(Me.lb_stepState)
        Me.Controls.Add(Me.lb_stepDirection)
        Me.Controls.Add(Me.lb_led0)
        Me.Controls.Add(Me.lb_led1)
        Me.Controls.Add(Me.lb_led2)
        Me.Controls.Add(Me.lb_led3)
        Me.Controls.Add(Me.lb_led4)
        Me.Controls.Add(Me.lb_led5)
        Me.Controls.Add(Me.lb_led6)
        Me.Controls.Add(Me.lb_led7)
        Me.Controls.Add(Me.menu_strip)
        Me.Controls.Add(Me.tabCtrl_main)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form_main"
        Me.Text = "Test serial port"
        Me.menu_strip.ResumeLayout(False)
        Me.menu_strip.PerformLayout()
        Me.tabCtrl_main_cli.ResumeLayout(False)
        Me.tabCtrl_main_cli.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabCtrl_main_stepCtrl.ResumeLayout(False)
        Me.tabCtrl_main_stepCtrl.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabCtrl_main_effect.ResumeLayout(False)
        Me.tabCtrl_main_effect.PerformLayout()
        CType(Me.picbx_tab2_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabCtrl_main_chb.ResumeLayout(False)
        Me.tabCtrl_main_chb.PerformLayout()
        CType(Me.picbx_tab1_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabCtrl_main.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents shp_led0 As PowerPacks.OvalShape
    Friend WithEvents shp_led1 As PowerPacks.OvalShape
    Friend WithEvents shp_led2 As PowerPacks.OvalShape
    Friend WithEvents shp_led3 As PowerPacks.OvalShape
    Friend WithEvents shp_led4 As PowerPacks.OvalShape
    Friend WithEvents shp_led5 As PowerPacks.OvalShape
    Friend WithEvents shp_led6 As PowerPacks.OvalShape
    Friend WithEvents shp_led7 As PowerPacks.OvalShape
    Friend WithEvents lb_led7 As Label
    Friend WithEvents lb_led6 As Label
    Friend WithEvents lb_led4 As Label
    Friend WithEvents lb_led5 As Label
    Friend WithEvents lb_led0 As Label
    Friend WithEvents lb_led1 As Label
    Friend WithEvents lb_led2 As Label
    Friend WithEvents lb_led3 As Label
    Friend WithEvents menu_strip As MenuStrip
    Friend WithEvents tstr_menu_setup As ToolStripMenuItem
    Friend WithEvents _SerialPort As IO.Ports.SerialPort
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents tstr_Comport As ToolStripMenuItem
    Friend WithEvents tstr_baud As ToolStripMenuItem
    Friend WithEvents tstr_dataSize As ToolStripMenuItem
    Friend WithEvents tstr_parity As ToolStripMenuItem
    Friend WithEvents tstr_connect As ToolStripMenuItem
    Friend WithEvents tstr_status_line As ToolStripMenuItem
    Friend WithEvents tstr_stopbit As ToolStripMenuItem
    Friend WithEvents AboutMeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents rectan_Stepper_state As PowerPacks.RectangleShape
    Friend WithEvents lb_stepDirection As Label
    Friend WithEvents lb_stepState As Label
    Friend WithEvents lb_step_run As Label
    Friend WithEvents lb_step_dir As Label
    Friend WithEvents tabCtrl_main_cli As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents lb_tab3_cAscii As Label
    Friend WithEvents lb_tab3_cHex As Label
    Friend WithEvents lb_tab3_All As Label
    Friend WithEvents rtbx_tab3_readAll As RichTextBox
    Friend WithEvents rtbx_tab3_readHex As RichTextBox
    Friend WithEvents rtbx_tab3_readAscii As RichTextBox
    Friend WithEvents tbx_tab3_writeCli As TextBox
    Friend WithEvents btn_tab3_clear As Button
    Friend WithEvents chb_tab3_autoScroll As CheckBox
    Friend WithEvents lb_tab3_writeCli As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tabCtrl_main_stepCtrl As TabPage
    Friend WithEvents trkbar_timeStepper As MetroFramework.Controls.MetroTrackBar
    Friend WithEvents lb_tab4_timeStepper As Label
    Friend WithEvents tbx_tab4_timeStepper As TextBox
    Friend WithEvents btn_tab4_UpDirStep As Button
    Friend WithEvents btn_tab4_ReDir As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btn_tab4_RunStep As Button
    Friend WithEvents btn_tab4_UpStaStep As Button
    Friend WithEvents tabCtrl_main_effect As TabPage
    Friend WithEvents chb_tab2_respState As CheckBox
    Friend WithEvents tbx_tab2_timeDelay As TextBox
    Friend WithEvents lb_tab2_timeDelay As Label
    Friend WithEvents trkbar_timeDelay As MetroFramework.Controls.MetroTrackBar
    Friend WithEvents btn_tab2_effect As Button
    Friend WithEvents lb_tab2_effectLed As Label
    Friend WithEvents cbb_effect_led As ComboBox
    Friend WithEvents picbx_tab2_logo As PictureBox
    Friend WithEvents tabCtrl_main_chb As TabPage
    Friend WithEvents lb_tab1_ascii As Label
    Friend WithEvents lb_tab1_octVal As Label
    Friend WithEvents tbx_tab1_octVal As TextBox
    Friend WithEvents tbx_tab1_ascii As TextBox
    Friend WithEvents tbx_tab1_decVal As TextBox
    Friend WithEvents tbx_tab1_binVal As TextBox
    Friend WithEvents tbx_tab1_hexVal As TextBox
    Friend WithEvents btn_tab1_clear As Button
    Friend WithEvents picbx_tab1_logo As PictureBox
    Friend WithEvents lb_tab1_decVal As Label
    Friend WithEvents lb_tab1_hexVal As Label
    Friend WithEvents lb_tab1_binVal As Label
    Friend WithEvents btn_tab1_send As Button
    Friend WithEvents chb_bit4 As CheckBox
    Friend WithEvents chb_bit5 As CheckBox
    Friend WithEvents chb_bit6 As CheckBox
    Friend WithEvents chb_bit7 As CheckBox
    Friend WithEvents chb_bit3 As CheckBox
    Friend WithEvents chb_bit2 As CheckBox
    Friend WithEvents chb_bit1 As CheckBox
    Friend WithEvents chb_bit0 As CheckBox
    Friend WithEvents tabCtrl_main As TabControl
End Class

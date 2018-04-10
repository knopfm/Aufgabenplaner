<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Aufgabenplaner
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuMS = New System.Windows.Forms.MenuStrip()
        Me.AufgabenTSM = New System.Windows.Forms.ToolStripMenuItem()
        Me.NeuTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServerTSM = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerbindenTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.HilfeTSM = New System.Windows.Forms.ToolStripMenuItem()
        Me.HilfeTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.EinstellungenTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfoTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusSS = New System.Windows.Forms.StatusStrip()
        Me.StatusLBL = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MainTLP = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.innerDetailsTLP = New System.Windows.Forms.TableLayoutPanel()
        Me.TaskNameL = New System.Windows.Forms.Label()
        Me.TaskNameTB = New System.Windows.Forms.TextBox()
        Me.TaskUserCB = New System.Windows.Forms.ComboBox()
        Me.TaskUserL = New System.Windows.Forms.Label()
        Me.TaskDescriptionL = New System.Windows.Forms.Label()
        Me.TaskDescriptionTB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CalenderTLP = New System.Windows.Forms.TableLayoutPanel()
        Me.CalenderWeek4L = New System.Windows.Forms.Label()
        Me.CalenderWeek2L = New System.Windows.Forms.Label()
        Me.CalenderWeek3L = New System.Windows.Forms.Label()
        Me.CalenderWeek1L = New System.Windows.Forms.Label()
        Me.Day1L = New System.Windows.Forms.Label()
        Me.Day2L = New System.Windows.Forms.Label()
        Me.Day3L = New System.Windows.Forms.Label()
        Me.Day4L = New System.Windows.Forms.Label()
        Me.Day5L = New System.Windows.Forms.Label()
        Me.Day6L = New System.Windows.Forms.Label()
        Me.Day7L = New System.Windows.Forms.Label()
        Me.CalenderControlTLP = New System.Windows.Forms.TableLayoutPanel()
        Me.CalenderControlLeftBT = New System.Windows.Forms.Button()
        Me.CalenderControlRightBT = New System.Windows.Forms.Button()
        Me.CalenderMonthLL = New System.Windows.Forms.LinkLabel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuMS.SuspendLayout()
        Me.StatusSS.SuspendLayout()
        Me.MainTLP.SuspendLayout()
        Me.innerDetailsTLP.SuspendLayout()
        Me.CalenderTLP.SuspendLayout()
        Me.CalenderControlTLP.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuMS
        '
        Me.MenuMS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AufgabenTSM, Me.ServerTSM, Me.HilfeTSM})
        Me.MenuMS.Location = New System.Drawing.Point(0, 0)
        Me.MenuMS.Name = "MenuMS"
        Me.MenuMS.Size = New System.Drawing.Size(784, 24)
        Me.MenuMS.TabIndex = 0
        Me.MenuMS.Text = "MenuStrip1"
        '
        'AufgabenTSM
        '
        Me.AufgabenTSM.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NeuTSMI})
        Me.AufgabenTSM.Name = "AufgabenTSM"
        Me.AufgabenTSM.Size = New System.Drawing.Size(71, 20)
        Me.AufgabenTSM.Text = "&Aufgaben"
        '
        'NeuTSMI
        '
        Me.NeuTSMI.Name = "NeuTSMI"
        Me.NeuTSMI.Size = New System.Drawing.Size(96, 22)
        Me.NeuTSMI.Text = "&Neu"
        '
        'ServerTSM
        '
        Me.ServerTSM.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerbindenTSMI})
        Me.ServerTSM.Name = "ServerTSM"
        Me.ServerTSM.Size = New System.Drawing.Size(51, 20)
        Me.ServerTSM.Text = "Server"
        '
        'VerbindenTSMI
        '
        Me.VerbindenTSMI.Name = "VerbindenTSMI"
        Me.VerbindenTSMI.Size = New System.Drawing.Size(127, 22)
        Me.VerbindenTSMI.Text = "Verb&inden"
        '
        'HilfeTSM
        '
        Me.HilfeTSM.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HilfeTSMI, Me.EinstellungenTSMI, Me.InfoTSMI})
        Me.HilfeTSM.Name = "HilfeTSM"
        Me.HilfeTSM.Size = New System.Drawing.Size(44, 20)
        Me.HilfeTSM.Text = "&Hilfe"
        '
        'HilfeTSMI
        '
        Me.HilfeTSMI.Name = "HilfeTSMI"
        Me.HilfeTSMI.Size = New System.Drawing.Size(145, 22)
        Me.HilfeTSMI.Text = "&Hilfe"
        '
        'EinstellungenTSMI
        '
        Me.EinstellungenTSMI.Name = "EinstellungenTSMI"
        Me.EinstellungenTSMI.Size = New System.Drawing.Size(145, 22)
        Me.EinstellungenTSMI.Text = "&Einstellungen"
        '
        'InfoTSMI
        '
        Me.InfoTSMI.Name = "InfoTSMI"
        Me.InfoTSMI.Size = New System.Drawing.Size(145, 22)
        Me.InfoTSMI.Text = "&Info"
        '
        'StatusSS
        '
        Me.StatusSS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusLBL})
        Me.StatusSS.Location = New System.Drawing.Point(0, 539)
        Me.StatusSS.Name = "StatusSS"
        Me.StatusSS.Size = New System.Drawing.Size(784, 22)
        Me.StatusSS.TabIndex = 1
        Me.StatusSS.Text = "StatusStrip1"
        '
        'StatusLBL
        '
        Me.StatusLBL.Name = "StatusLBL"
        Me.StatusLBL.Size = New System.Drawing.Size(32, 17)
        Me.StatusLBL.Text = "Error"
        '
        'MainTLP
        '
        Me.MainTLP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MainTLP.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset
        Me.MainTLP.ColumnCount = 3
        Me.MainTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.MainTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.MainTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.MainTLP.Controls.Add(Me.Label4, 0, 1)
        Me.MainTLP.Controls.Add(Me.innerDetailsTLP, 1, 1)
        Me.MainTLP.Controls.Add(Me.CalenderTLP, 0, 0)
        Me.MainTLP.Controls.Add(Me.Label1, 1, 0)
        Me.MainTLP.Controls.Add(Me.Label2, 2, 0)
        Me.MainTLP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainTLP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainTLP.Location = New System.Drawing.Point(0, 24)
        Me.MainTLP.Margin = New System.Windows.Forms.Padding(0)
        Me.MainTLP.Name = "MainTLP"
        Me.MainTLP.RowCount = 2
        Me.MainTLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.MainTLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.MainTLP.Size = New System.Drawing.Size(784, 515)
        Me.MainTLP.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 257)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Erinnerungen"
        '
        'innerDetailsTLP
        '
        Me.innerDetailsTLP.ColumnCount = 4
        Me.MainTLP.SetColumnSpan(Me.innerDetailsTLP, 2)
        Me.innerDetailsTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.innerDetailsTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.34298!))
        Me.innerDetailsTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.391608!))
        Me.innerDetailsTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.29604!))
        Me.innerDetailsTLP.Controls.Add(Me.TaskNameL, 0, 0)
        Me.innerDetailsTLP.Controls.Add(Me.TaskNameTB, 1, 0)
        Me.innerDetailsTLP.Controls.Add(Me.TaskUserCB, 1, 1)
        Me.innerDetailsTLP.Controls.Add(Me.TaskUserL, 0, 1)
        Me.innerDetailsTLP.Controls.Add(Me.TaskDescriptionL, 0, 2)
        Me.innerDetailsTLP.Controls.Add(Me.TaskDescriptionTB, 1, 2)
        Me.innerDetailsTLP.Controls.Add(Me.Label3, 3, 0)
        Me.innerDetailsTLP.Controls.Add(Me.Label6, 3, 1)
        Me.innerDetailsTLP.Controls.Add(Me.Label7, 3, 2)
        Me.innerDetailsTLP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.innerDetailsTLP.Location = New System.Drawing.Point(261, 257)
        Me.innerDetailsTLP.Margin = New System.Windows.Forms.Padding(0)
        Me.innerDetailsTLP.Name = "innerDetailsTLP"
        Me.innerDetailsTLP.RowCount = 3
        Me.innerDetailsTLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.innerDetailsTLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.innerDetailsTLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.innerDetailsTLP.Size = New System.Drawing.Size(519, 254)
        Me.innerDetailsTLP.TabIndex = 6
        '
        'TaskNameL
        '
        Me.TaskNameL.AutoSize = True
        Me.TaskNameL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TaskNameL.Location = New System.Drawing.Point(3, 0)
        Me.TaskNameL.Name = "TaskNameL"
        Me.TaskNameL.Size = New System.Drawing.Size(84, 26)
        Me.TaskNameL.TabIndex = 0
        Me.TaskNameL.Text = "Aufgabe:"
        Me.TaskNameL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TaskNameTB
        '
        Me.TaskNameTB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TaskNameTB.Location = New System.Drawing.Point(93, 3)
        Me.TaskNameTB.Name = "TaskNameTB"
        Me.TaskNameTB.Size = New System.Drawing.Size(227, 20)
        Me.TaskNameTB.TabIndex = 1
        '
        'TaskUserCB
        '
        Me.TaskUserCB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TaskUserCB.FormattingEnabled = True
        Me.TaskUserCB.Location = New System.Drawing.Point(93, 29)
        Me.TaskUserCB.Name = "TaskUserCB"
        Me.TaskUserCB.Size = New System.Drawing.Size(227, 21)
        Me.TaskUserCB.TabIndex = 2
        '
        'TaskUserL
        '
        Me.TaskUserL.AutoSize = True
        Me.TaskUserL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TaskUserL.Location = New System.Drawing.Point(3, 26)
        Me.TaskUserL.Name = "TaskUserL"
        Me.TaskUserL.Size = New System.Drawing.Size(84, 26)
        Me.TaskUserL.TabIndex = 3
        Me.TaskUserL.Text = "User:"
        Me.TaskUserL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TaskDescriptionL
        '
        Me.TaskDescriptionL.AutoSize = True
        Me.TaskDescriptionL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TaskDescriptionL.Location = New System.Drawing.Point(3, 52)
        Me.TaskDescriptionL.Name = "TaskDescriptionL"
        Me.TaskDescriptionL.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.TaskDescriptionL.Size = New System.Drawing.Size(84, 202)
        Me.TaskDescriptionL.TabIndex = 4
        Me.TaskDescriptionL.Text = "Beschreibung:"
        Me.TaskDescriptionL.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TaskDescriptionTB
        '
        Me.TaskDescriptionTB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TaskDescriptionTB.Location = New System.Drawing.Point(93, 55)
        Me.TaskDescriptionTB.Multiline = True
        Me.TaskDescriptionTB.Name = "TaskDescriptionTB"
        Me.TaskDescriptionTB.Size = New System.Drawing.Size(227, 196)
        Me.TaskDescriptionTB.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(361, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "StartTag"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(361, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Endtag"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(361, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Status Type Prioriät"
        '
        'CalenderTLP
        '
        Me.CalenderTLP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CalenderTLP.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.CalenderTLP.ColumnCount = 8
        Me.CalenderTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.CalenderTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.CalenderTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.CalenderTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.CalenderTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.CalenderTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.CalenderTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.CalenderTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.CalenderTLP.Controls.Add(Me.CalenderWeek4L, 0, 5)
        Me.CalenderTLP.Controls.Add(Me.CalenderWeek2L, 0, 3)
        Me.CalenderTLP.Controls.Add(Me.CalenderWeek3L, 0, 4)
        Me.CalenderTLP.Controls.Add(Me.CalenderWeek1L, 0, 2)
        Me.CalenderTLP.Controls.Add(Me.Day1L, 1, 1)
        Me.CalenderTLP.Controls.Add(Me.Day2L, 2, 1)
        Me.CalenderTLP.Controls.Add(Me.Day3L, 3, 1)
        Me.CalenderTLP.Controls.Add(Me.Day4L, 4, 1)
        Me.CalenderTLP.Controls.Add(Me.Day5L, 5, 1)
        Me.CalenderTLP.Controls.Add(Me.Day6L, 6, 1)
        Me.CalenderTLP.Controls.Add(Me.Day7L, 7, 1)
        Me.CalenderTLP.Controls.Add(Me.CalenderControlTLP, 0, 0)
        Me.CalenderTLP.Controls.Add(Me.Label5, 7, 2)
        Me.CalenderTLP.Controls.Add(Me.Button1, 7, 3)
        Me.CalenderTLP.Controls.Add(Me.LinkLabel1, 0, 6)
        Me.CalenderTLP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CalenderTLP.Location = New System.Drawing.Point(2, 2)
        Me.CalenderTLP.Margin = New System.Windows.Forms.Padding(0)
        Me.CalenderTLP.Name = "CalenderTLP"
        Me.CalenderTLP.RowCount = 7
        Me.CalenderTLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.CalenderTLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.CalenderTLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.CalenderTLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.CalenderTLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.CalenderTLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.CalenderTLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.CalenderTLP.Size = New System.Drawing.Size(257, 253)
        Me.CalenderTLP.TabIndex = 3
        '
        'CalenderWeek4L
        '
        Me.CalenderWeek4L.AutoSize = True
        Me.CalenderWeek4L.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.CalenderWeek4L.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CalenderWeek4L.ForeColor = System.Drawing.Color.White
        Me.CalenderWeek4L.Location = New System.Drawing.Point(1, 185)
        Me.CalenderWeek4L.Margin = New System.Windows.Forms.Padding(0)
        Me.CalenderWeek4L.Name = "CalenderWeek4L"
        Me.CalenderWeek4L.Size = New System.Drawing.Size(22, 42)
        Me.CalenderWeek4L.TabIndex = 6
        Me.CalenderWeek4L.Text = "4"
        Me.CalenderWeek4L.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CalenderWeek2L
        '
        Me.CalenderWeek2L.AutoSize = True
        Me.CalenderWeek2L.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.CalenderWeek2L.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CalenderWeek2L.ForeColor = System.Drawing.Color.White
        Me.CalenderWeek2L.Location = New System.Drawing.Point(1, 99)
        Me.CalenderWeek2L.Margin = New System.Windows.Forms.Padding(0)
        Me.CalenderWeek2L.Name = "CalenderWeek2L"
        Me.CalenderWeek2L.Size = New System.Drawing.Size(22, 42)
        Me.CalenderWeek2L.TabIndex = 3
        Me.CalenderWeek2L.Text = "2"
        Me.CalenderWeek2L.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CalenderWeek3L
        '
        Me.CalenderWeek3L.AutoSize = True
        Me.CalenderWeek3L.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.CalenderWeek3L.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CalenderWeek3L.ForeColor = System.Drawing.Color.White
        Me.CalenderWeek3L.Location = New System.Drawing.Point(1, 142)
        Me.CalenderWeek3L.Margin = New System.Windows.Forms.Padding(0)
        Me.CalenderWeek3L.Name = "CalenderWeek3L"
        Me.CalenderWeek3L.Size = New System.Drawing.Size(22, 42)
        Me.CalenderWeek3L.TabIndex = 4
        Me.CalenderWeek3L.Text = "3"
        Me.CalenderWeek3L.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CalenderWeek1L
        '
        Me.CalenderWeek1L.AutoSize = True
        Me.CalenderWeek1L.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.CalenderWeek1L.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CalenderWeek1L.ForeColor = System.Drawing.Color.White
        Me.CalenderWeek1L.Location = New System.Drawing.Point(1, 56)
        Me.CalenderWeek1L.Margin = New System.Windows.Forms.Padding(0)
        Me.CalenderWeek1L.Name = "CalenderWeek1L"
        Me.CalenderWeek1L.Size = New System.Drawing.Size(22, 42)
        Me.CalenderWeek1L.TabIndex = 5
        Me.CalenderWeek1L.Text = "1"
        Me.CalenderWeek1L.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Day1L
        '
        Me.Day1L.AutoSize = True
        Me.Day1L.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Day1L.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Day1L.Location = New System.Drawing.Point(24, 39)
        Me.Day1L.Margin = New System.Windows.Forms.Padding(0)
        Me.Day1L.Name = "Day1L"
        Me.Day1L.Size = New System.Drawing.Size(31, 16)
        Me.Day1L.TabIndex = 7
        Me.Day1L.Text = "Mo"
        Me.Day1L.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Day2L
        '
        Me.Day2L.AutoSize = True
        Me.Day2L.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Day2L.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Day2L.Location = New System.Drawing.Point(56, 39)
        Me.Day2L.Margin = New System.Windows.Forms.Padding(0)
        Me.Day2L.Name = "Day2L"
        Me.Day2L.Size = New System.Drawing.Size(31, 16)
        Me.Day2L.TabIndex = 8
        Me.Day2L.Text = "Di"
        Me.Day2L.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Day3L
        '
        Me.Day3L.AutoSize = True
        Me.Day3L.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Day3L.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Day3L.Location = New System.Drawing.Point(88, 39)
        Me.Day3L.Margin = New System.Windows.Forms.Padding(0)
        Me.Day3L.Name = "Day3L"
        Me.Day3L.Size = New System.Drawing.Size(31, 16)
        Me.Day3L.TabIndex = 9
        Me.Day3L.Text = "Mi"
        Me.Day3L.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Day4L
        '
        Me.Day4L.AutoSize = True
        Me.Day4L.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Day4L.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Day4L.Location = New System.Drawing.Point(120, 39)
        Me.Day4L.Margin = New System.Windows.Forms.Padding(0)
        Me.Day4L.Name = "Day4L"
        Me.Day4L.Size = New System.Drawing.Size(31, 16)
        Me.Day4L.TabIndex = 10
        Me.Day4L.Text = "Do"
        Me.Day4L.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Day5L
        '
        Me.Day5L.AutoSize = True
        Me.Day5L.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Day5L.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Day5L.Location = New System.Drawing.Point(152, 39)
        Me.Day5L.Margin = New System.Windows.Forms.Padding(0)
        Me.Day5L.Name = "Day5L"
        Me.Day5L.Size = New System.Drawing.Size(31, 16)
        Me.Day5L.TabIndex = 11
        Me.Day5L.Text = "Fr"
        Me.Day5L.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Day6L
        '
        Me.Day6L.AutoSize = True
        Me.Day6L.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Day6L.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Day6L.Location = New System.Drawing.Point(184, 39)
        Me.Day6L.Margin = New System.Windows.Forms.Padding(0)
        Me.Day6L.Name = "Day6L"
        Me.Day6L.Size = New System.Drawing.Size(31, 16)
        Me.Day6L.TabIndex = 12
        Me.Day6L.Text = "Sa"
        Me.Day6L.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Day7L
        '
        Me.Day7L.AutoSize = True
        Me.Day7L.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Day7L.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Day7L.Location = New System.Drawing.Point(216, 39)
        Me.Day7L.Margin = New System.Windows.Forms.Padding(0)
        Me.Day7L.Name = "Day7L"
        Me.Day7L.Size = New System.Drawing.Size(38, 16)
        Me.Day7L.TabIndex = 13
        Me.Day7L.Text = "So"
        Me.Day7L.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CalenderControlTLP
        '
        Me.CalenderControlTLP.ColumnCount = 3
        Me.CalenderTLP.SetColumnSpan(Me.CalenderControlTLP, 8)
        Me.CalenderControlTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.CalenderControlTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.CalenderControlTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.CalenderControlTLP.Controls.Add(Me.CalenderControlLeftBT, 0, 0)
        Me.CalenderControlTLP.Controls.Add(Me.CalenderControlRightBT, 2, 0)
        Me.CalenderControlTLP.Controls.Add(Me.CalenderMonthLL, 1, 0)
        Me.CalenderControlTLP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CalenderControlTLP.Location = New System.Drawing.Point(1, 1)
        Me.CalenderControlTLP.Margin = New System.Windows.Forms.Padding(0)
        Me.CalenderControlTLP.Name = "CalenderControlTLP"
        Me.CalenderControlTLP.RowCount = 1
        Me.CalenderControlTLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.CalenderControlTLP.Size = New System.Drawing.Size(253, 37)
        Me.CalenderControlTLP.TabIndex = 14
        '
        'CalenderControlLeftBT
        '
        Me.CalenderControlLeftBT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CalenderControlLeftBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CalenderControlLeftBT.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalenderControlLeftBT.Location = New System.Drawing.Point(3, 3)
        Me.CalenderControlLeftBT.Name = "CalenderControlLeftBT"
        Me.CalenderControlLeftBT.Size = New System.Drawing.Size(31, 31)
        Me.CalenderControlLeftBT.TabIndex = 0
        Me.CalenderControlLeftBT.Text = "◄"
        Me.CalenderControlLeftBT.UseVisualStyleBackColor = True
        '
        'CalenderControlRightBT
        '
        Me.CalenderControlRightBT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CalenderControlRightBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CalenderControlRightBT.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalenderControlRightBT.Location = New System.Drawing.Point(219, 3)
        Me.CalenderControlRightBT.Name = "CalenderControlRightBT"
        Me.CalenderControlRightBT.Size = New System.Drawing.Size(31, 31)
        Me.CalenderControlRightBT.TabIndex = 1
        Me.CalenderControlRightBT.Text = "►"
        Me.CalenderControlRightBT.UseVisualStyleBackColor = True
        '
        'CalenderMonthLL
        '
        Me.CalenderMonthLL.AutoSize = True
        Me.CalenderMonthLL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CalenderMonthLL.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalenderMonthLL.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.CalenderMonthLL.Location = New System.Drawing.Point(37, 0)
        Me.CalenderMonthLL.Margin = New System.Windows.Forms.Padding(0)
        Me.CalenderMonthLL.Name = "CalenderMonthLL"
        Me.CalenderMonthLL.Size = New System.Drawing.Size(179, 37)
        Me.CalenderMonthLL.TabIndex = 2
        Me.CalenderMonthLL.TabStop = True
        Me.CalenderMonthLL.Text = "Januar 2000"
        Me.CalenderMonthLL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(219, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 26)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Kalender"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(219, 102)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(28, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "AddAufgabe"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.CalenderTLP.SetColumnSpan(Me.LinkLabel1, 8)
        Me.LinkLabel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel1.Location = New System.Drawing.Point(1, 228)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(253, 22)
        Me.LinkLabel1.TabIndex = 15
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Heute 01.04.2018"
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(264, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Heute"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(524, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Morgen"
        '
        'Aufgabenplaner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.MainTLP)
        Me.Controls.Add(Me.StatusSS)
        Me.Controls.Add(Me.MenuMS)
        Me.MainMenuStrip = Me.MenuMS
        Me.Name = "Aufgabenplaner"
        Me.Text = "Aufgabenplaner"
        Me.MenuMS.ResumeLayout(False)
        Me.MenuMS.PerformLayout()
        Me.StatusSS.ResumeLayout(False)
        Me.StatusSS.PerformLayout()
        Me.MainTLP.ResumeLayout(False)
        Me.MainTLP.PerformLayout()
        Me.innerDetailsTLP.ResumeLayout(False)
        Me.innerDetailsTLP.PerformLayout()
        Me.CalenderTLP.ResumeLayout(False)
        Me.CalenderTLP.PerformLayout()
        Me.CalenderControlTLP.ResumeLayout(False)
        Me.CalenderControlTLP.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuMS As System.Windows.Forms.MenuStrip
    Friend WithEvents AufgabenTSM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HilfeTSM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NeuTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusSS As System.Windows.Forms.StatusStrip
    Friend WithEvents StatusLBL As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ServerTSM As ToolStripMenuItem
    Friend WithEvents VerbindenTSMI As ToolStripMenuItem
    Friend WithEvents MainTLP As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CalenderTLP As TableLayoutPanel
    Friend WithEvents CalenderWeek4L As Label
    Friend WithEvents CalenderWeek2L As Label
    Friend WithEvents CalenderWeek3L As Label
    Friend WithEvents CalenderWeek1L As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Day1L As Label
    Friend WithEvents Day2L As Label
    Friend WithEvents Day3L As Label
    Friend WithEvents Day4L As Label
    Friend WithEvents Day5L As Label
    Friend WithEvents Day6L As Label
    Friend WithEvents Day7L As Label
    Friend WithEvents HilfeTSMI As ToolStripMenuItem
    Friend WithEvents EinstellungenTSMI As ToolStripMenuItem
    Friend WithEvents InfoTSMI As ToolStripMenuItem
    Friend WithEvents CalenderControlTLP As TableLayoutPanel
    Friend WithEvents CalenderControlLeftBT As Button
    Friend WithEvents CalenderControlRightBT As Button
    Friend WithEvents CalenderMonthLL As LinkLabel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents innerDetailsTLP As TableLayoutPanel
    Private WithEvents TaskNameL As Label
    Friend WithEvents TaskNameTB As TextBox
    Friend WithEvents TaskUserCB As ComboBox
    Friend WithEvents TaskUserL As Label
    Friend WithEvents TaskDescriptionL As Label
    Friend WithEvents TaskDescriptionTB As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class

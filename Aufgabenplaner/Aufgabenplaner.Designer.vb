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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Calender1 = New Calender()
        Me.MenuMS.SuspendLayout()
        Me.StatusSS.SuspendLayout()
        Me.MainTLP.SuspendLayout()
        Me.innerDetailsTLP.SuspendLayout()
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
        Me.MainTLP.Controls.Add(Me.Label1, 1, 0)
        Me.MainTLP.Controls.Add(Me.Label2, 2, 0)
        Me.MainTLP.Controls.Add(Me.Calender1, 0, 0)
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
        Me.TaskUserL.Text = "Benutzer:"
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
        'Calender1
        '
        Me.Calender1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Calender1.Location = New System.Drawing.Point(2, 2)
        Me.Calender1.Margin = New System.Windows.Forms.Padding(0)
        Me.Calender1.Name = "Calender1"
        Me.Calender1.Size = New System.Drawing.Size(257, 253)
        Me.Calender1.TabIndex = 7
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
    Friend WithEvents HilfeTSMI As ToolStripMenuItem
    Friend WithEvents EinstellungenTSMI As ToolStripMenuItem
    Friend WithEvents InfoTSMI As ToolStripMenuItem
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
    Friend WithEvents Calender1 As Calender
End Class

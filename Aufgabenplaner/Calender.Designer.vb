<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calender
    Inherits System.Windows.Forms.UserControl

    'UserControl überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Week4L = New System.Windows.Forms.Label()
        Me.Week2L = New System.Windows.Forms.Label()
        Me.Week3L = New System.Windows.Forms.Label()
        Me.Week1L = New System.Windows.Forms.Label()
        Me.Day1L = New System.Windows.Forms.Label()
        Me.Day2L = New System.Windows.Forms.Label()
        Me.Day3L = New System.Windows.Forms.Label()
        Me.Day4L = New System.Windows.Forms.Label()
        Me.Day5L = New System.Windows.Forms.Label()
        Me.Day6L = New System.Windows.Forms.Label()
        Me.Day7L = New System.Windows.Forms.Label()
        Me.LastMonthBT = New System.Windows.Forms.Button()
        Me.NextMonthBT = New System.Windows.Forms.Button()
        Me.CalenderMonthLL = New System.Windows.Forms.LinkLabel()
        Me.CalenderTopTLP = New System.Windows.Forms.TableLayoutPanel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TodayLL = New System.Windows.Forms.LinkLabel()
        Me.CalenderTLP = New System.Windows.Forms.TableLayoutPanel()
        Me.CalenderTopTLP.SuspendLayout()
        Me.CalenderTLP.SuspendLayout()
        Me.SuspendLayout()
        '
        'Week4L
        '
        Me.Week4L.AutoSize = True
        Me.Week4L.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Week4L.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Week4L.ForeColor = System.Drawing.Color.White
        Me.Week4L.Location = New System.Drawing.Point(1, 215)
        Me.Week4L.Margin = New System.Windows.Forms.Padding(0)
        Me.Week4L.Name = "Week4L"
        Me.Week4L.Size = New System.Drawing.Size(22, 52)
        Me.Week4L.TabIndex = 6
        Me.Week4L.Text = "4"
        Me.Week4L.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Week2L
        '
        Me.Week2L.AutoSize = True
        Me.Week2L.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Week2L.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Week2L.ForeColor = System.Drawing.Color.White
        Me.Week2L.Location = New System.Drawing.Point(1, 109)
        Me.Week2L.Margin = New System.Windows.Forms.Padding(0)
        Me.Week2L.Name = "Week2L"
        Me.Week2L.Size = New System.Drawing.Size(22, 52)
        Me.Week2L.TabIndex = 3
        Me.Week2L.Text = "2"
        Me.Week2L.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Week3L
        '
        Me.Week3L.AutoSize = True
        Me.Week3L.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Week3L.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Week3L.ForeColor = System.Drawing.Color.White
        Me.Week3L.Location = New System.Drawing.Point(1, 162)
        Me.Week3L.Margin = New System.Windows.Forms.Padding(0)
        Me.Week3L.Name = "Week3L"
        Me.Week3L.Size = New System.Drawing.Size(22, 52)
        Me.Week3L.TabIndex = 4
        Me.Week3L.Text = "3"
        Me.Week3L.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Week1L
        '
        Me.Week1L.AutoSize = True
        Me.Week1L.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Week1L.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Week1L.ForeColor = System.Drawing.Color.White
        Me.Week1L.Location = New System.Drawing.Point(1, 56)
        Me.Week1L.Margin = New System.Windows.Forms.Padding(0)
        Me.Week1L.Name = "Week1L"
        Me.Week1L.Size = New System.Drawing.Size(22, 52)
        Me.Week1L.TabIndex = 5
        Me.Week1L.Text = "1"
        Me.Week1L.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Day1L
        '
        Me.Day1L.AutoSize = True
        Me.Day1L.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Day1L.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Day1L.Location = New System.Drawing.Point(24, 39)
        Me.Day1L.Margin = New System.Windows.Forms.Padding(0)
        Me.Day1L.Name = "Day1L"
        Me.Day1L.Size = New System.Drawing.Size(40, 16)
        Me.Day1L.TabIndex = 7
        Me.Day1L.Text = "Mo"
        Me.Day1L.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Day2L
        '
        Me.Day2L.AutoSize = True
        Me.Day2L.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Day2L.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Day2L.Location = New System.Drawing.Point(65, 39)
        Me.Day2L.Margin = New System.Windows.Forms.Padding(0)
        Me.Day2L.Name = "Day2L"
        Me.Day2L.Size = New System.Drawing.Size(40, 16)
        Me.Day2L.TabIndex = 8
        Me.Day2L.Text = "Di"
        Me.Day2L.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Day3L
        '
        Me.Day3L.AutoSize = True
        Me.Day3L.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Day3L.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Day3L.Location = New System.Drawing.Point(106, 39)
        Me.Day3L.Margin = New System.Windows.Forms.Padding(0)
        Me.Day3L.Name = "Day3L"
        Me.Day3L.Size = New System.Drawing.Size(40, 16)
        Me.Day3L.TabIndex = 9
        Me.Day3L.Text = "Mi"
        Me.Day3L.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Day4L
        '
        Me.Day4L.AutoSize = True
        Me.Day4L.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Day4L.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Day4L.Location = New System.Drawing.Point(147, 39)
        Me.Day4L.Margin = New System.Windows.Forms.Padding(0)
        Me.Day4L.Name = "Day4L"
        Me.Day4L.Size = New System.Drawing.Size(40, 16)
        Me.Day4L.TabIndex = 10
        Me.Day4L.Text = "Do"
        Me.Day4L.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Day5L
        '
        Me.Day5L.AutoSize = True
        Me.Day5L.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Day5L.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Day5L.Location = New System.Drawing.Point(188, 39)
        Me.Day5L.Margin = New System.Windows.Forms.Padding(0)
        Me.Day5L.Name = "Day5L"
        Me.Day5L.Size = New System.Drawing.Size(40, 16)
        Me.Day5L.TabIndex = 11
        Me.Day5L.Text = "Fr"
        Me.Day5L.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Day6L
        '
        Me.Day6L.AutoSize = True
        Me.Day6L.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Day6L.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Day6L.Location = New System.Drawing.Point(229, 39)
        Me.Day6L.Margin = New System.Windows.Forms.Padding(0)
        Me.Day6L.Name = "Day6L"
        Me.Day6L.Size = New System.Drawing.Size(40, 16)
        Me.Day6L.TabIndex = 12
        Me.Day6L.Text = "Sa"
        Me.Day6L.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Day7L
        '
        Me.Day7L.AutoSize = True
        Me.Day7L.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Day7L.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Day7L.Location = New System.Drawing.Point(270, 39)
        Me.Day7L.Margin = New System.Windows.Forms.Padding(0)
        Me.Day7L.Name = "Day7L"
        Me.Day7L.Size = New System.Drawing.Size(47, 16)
        Me.Day7L.TabIndex = 13
        Me.Day7L.Text = "So"
        Me.Day7L.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LastMonthBT
        '
        Me.LastMonthBT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LastMonthBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LastMonthBT.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastMonthBT.Location = New System.Drawing.Point(3, 3)
        Me.LastMonthBT.Name = "LastMonthBT"
        Me.LastMonthBT.Size = New System.Drawing.Size(31, 31)
        Me.LastMonthBT.TabIndex = 0
        Me.LastMonthBT.Text = "◄"
        Me.LastMonthBT.UseVisualStyleBackColor = True
        '
        'NextMonthBT
        '
        Me.NextMonthBT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NextMonthBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NextMonthBT.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NextMonthBT.Location = New System.Drawing.Point(282, 3)
        Me.NextMonthBT.Name = "NextMonthBT"
        Me.NextMonthBT.Size = New System.Drawing.Size(31, 31)
        Me.NextMonthBT.TabIndex = 1
        Me.NextMonthBT.Text = "►"
        Me.NextMonthBT.UseVisualStyleBackColor = True
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
        Me.CalenderMonthLL.Size = New System.Drawing.Size(242, 37)
        Me.CalenderMonthLL.TabIndex = 2
        Me.CalenderMonthLL.TabStop = True
        Me.CalenderMonthLL.Text = "Januar 2000"
        Me.CalenderMonthLL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CalenderTopTLP
        '
        Me.CalenderTopTLP.ColumnCount = 3
        Me.CalenderTLP.SetColumnSpan(Me.CalenderTopTLP, 8)
        Me.CalenderTopTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.CalenderTopTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.CalenderTopTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.CalenderTopTLP.Controls.Add(Me.LastMonthBT, 0, 0)
        Me.CalenderTopTLP.Controls.Add(Me.NextMonthBT, 2, 0)
        Me.CalenderTopTLP.Controls.Add(Me.CalenderMonthLL, 1, 0)
        Me.CalenderTopTLP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CalenderTopTLP.Location = New System.Drawing.Point(1, 1)
        Me.CalenderTopTLP.Margin = New System.Windows.Forms.Padding(0)
        Me.CalenderTopTLP.Name = "CalenderTopTLP"
        Me.CalenderTopTLP.RowCount = 1
        Me.CalenderTopTLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.CalenderTopTLP.Size = New System.Drawing.Size(316, 37)
        Me.CalenderTopTLP.TabIndex = 14
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(273, 56)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 26)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Kalender"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(273, 112)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(28, 23)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "AddAufgabe"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TodayLL
        '
        Me.TodayLL.AutoSize = True
        Me.CalenderTLP.SetColumnSpan(Me.TodayLL, 8)
        Me.TodayLL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TodayLL.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.TodayLL.Location = New System.Drawing.Point(1, 268)
        Me.TodayLL.Margin = New System.Windows.Forms.Padding(0)
        Me.TodayLL.Name = "TodayLL"
        Me.TodayLL.Size = New System.Drawing.Size(316, 22)
        Me.TodayLL.TabIndex = 15
        Me.TodayLL.TabStop = True
        Me.TodayLL.Text = "Heute 01.04.2018"
        Me.TodayLL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.CalenderTLP.Controls.Add(Me.TodayLL, 0, 6)
        Me.CalenderTLP.Controls.Add(Me.Week4L, 0, 5)
        Me.CalenderTLP.Controls.Add(Me.Week2L, 0, 3)
        Me.CalenderTLP.Controls.Add(Me.Week3L, 0, 4)
        Me.CalenderTLP.Controls.Add(Me.Week1L, 0, 2)
        Me.CalenderTLP.Controls.Add(Me.Day1L, 1, 1)
        Me.CalenderTLP.Controls.Add(Me.Day2L, 2, 1)
        Me.CalenderTLP.Controls.Add(Me.Day3L, 3, 1)
        Me.CalenderTLP.Controls.Add(Me.Day4L, 4, 1)
        Me.CalenderTLP.Controls.Add(Me.Day5L, 5, 1)
        Me.CalenderTLP.Controls.Add(Me.Day6L, 6, 1)
        Me.CalenderTLP.Controls.Add(Me.Day7L, 7, 1)
        Me.CalenderTLP.Controls.Add(Me.CalenderTopTLP, 0, 0)
        Me.CalenderTLP.Controls.Add(Me.Label12, 7, 2)
        Me.CalenderTLP.Controls.Add(Me.Button3, 7, 3)
        Me.CalenderTLP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CalenderTLP.Location = New System.Drawing.Point(0, 0)
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
        Me.CalenderTLP.Size = New System.Drawing.Size(320, 293)
        Me.CalenderTLP.TabIndex = 3
        '
        'Calender
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.CalenderTLP)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "Calender"
        Me.Size = New System.Drawing.Size(320, 293)
        Me.CalenderTopTLP.ResumeLayout(False)
        Me.CalenderTopTLP.PerformLayout()
        Me.CalenderTLP.ResumeLayout(False)
        Me.CalenderTLP.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Week4L As Label
    Friend WithEvents Week2L As Label
    Friend WithEvents Week3L As Label
    Friend WithEvents Week1L As Label
    Friend WithEvents Day1L As Label
    Friend WithEvents Day2L As Label
    Friend WithEvents Day3L As Label
    Friend WithEvents Day4L As Label
    Friend WithEvents Day5L As Label
    Friend WithEvents Day6L As Label
    Friend WithEvents Day7L As Label
    Friend WithEvents LastMonthBT As Button
    Friend WithEvents NextMonthBT As Button
    Friend WithEvents CalenderMonthLL As LinkLabel
    Friend WithEvents CalenderTopTLP As TableLayoutPanel
    Friend WithEvents CalenderTLP As TableLayoutPanel
    Friend WithEvents Label12 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents TodayLL As LinkLabel
End Class

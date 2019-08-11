<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReporteProyecto
    Inherits DevComponents.DotNetBar.Metro.MetroForm

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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.DataInt = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.DataEnd = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BTN1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.DataInt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.DataEnd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(904, 624)
        Me.Panel1.TabIndex = 0
        '
        'Panel6
        '
        Me.Panel6.AutoScroll = True
        Me.Panel6.Controls.Add(Me.CrystalReportViewer1)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 100)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(904, 524)
        Me.Panel6.TabIndex = 1
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(904, 524)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(904, 100)
        Me.Panel2.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.AutoScroll = True
        Me.Panel5.Controls.Add(Me.DataInt)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(400, 100)
        Me.Panel5.TabIndex = 1
        '
        'DataInt
        '
        Me.DataInt.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.DataInt.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.DataInt.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DataInt.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.DataInt.ButtonDropDown.Visible = True
        Me.DataInt.ForeColor = System.Drawing.Color.Black
        Me.DataInt.IsPopupCalendarOpen = False
        Me.DataInt.Location = New System.Drawing.Point(67, 35)
        '
        '
        '
        '
        '
        '
        Me.DataInt.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DataInt.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.DataInt.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.DataInt.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.DataInt.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.DataInt.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.DataInt.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.DataInt.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.DataInt.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.DataInt.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DataInt.MonthCalendar.DisplayMonth = New Date(2019, 8, 1, 0, 0, 0, 0)
        Me.DataInt.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        '
        '
        '
        Me.DataInt.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.DataInt.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.DataInt.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.DataInt.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DataInt.MonthCalendar.TodayButtonVisible = True
        Me.DataInt.Name = "DataInt"
        Me.DataInt.Size = New System.Drawing.Size(200, 22)
        Me.DataInt.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.DataInt.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.AutoScroll = True
        Me.Panel4.Controls.Add(Me.DataEnd)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(400, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(304, 100)
        Me.Panel4.TabIndex = 1
        '
        'DataEnd
        '
        Me.DataEnd.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.DataEnd.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.DataEnd.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DataEnd.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.DataEnd.ButtonDropDown.Visible = True
        Me.DataEnd.ForeColor = System.Drawing.Color.Black
        Me.DataEnd.IsPopupCalendarOpen = False
        Me.DataEnd.Location = New System.Drawing.Point(61, 36)
        '
        '
        '
        '
        '
        '
        Me.DataEnd.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DataEnd.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.DataEnd.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.DataEnd.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.DataEnd.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.DataEnd.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.DataEnd.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.DataEnd.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.DataEnd.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.DataEnd.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DataEnd.MonthCalendar.DisplayMonth = New Date(2019, 8, 1, 0, 0, 0, 0)
        Me.DataEnd.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        '
        '
        '
        Me.DataEnd.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.DataEnd.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.DataEnd.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.DataEnd.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DataEnd.MonthCalendar.TodayButtonVisible = True
        Me.DataEnd.Name = "DataEnd"
        Me.DataEnd.Size = New System.Drawing.Size(200, 22)
        Me.DataEnd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.DataEnd.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.AutoScroll = True
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Panel3.Controls.Add(Me.BTN1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.ForeColor = System.Drawing.Color.Black
        Me.Panel3.Location = New System.Drawing.Point(704, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 100)
        Me.Panel3.TabIndex = 1
        '
        'BTN1
        '
        Me.BTN1.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.BTN1.FlatAppearance.BorderSize = 0
        Me.BTN1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN1.ForeColor = System.Drawing.Color.Black
        Me.BTN1.Location = New System.Drawing.Point(26, 35)
        Me.BTN1.Name = "BTN1"
        Me.BTN1.Size = New System.Drawing.Size(144, 23)
        Me.BTN1.TabIndex = 0
        Me.BTN1.Text = "GenerarReporte"
        Me.BTN1.UseVisualStyleBackColor = False
        '
        'FormReporteProyecto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 624)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "FormReporteProyecto"
        Me.Text = "MetroForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.DataInt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.DataEnd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents DataInt As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents DataEnd As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents BTN1 As Button
End Class

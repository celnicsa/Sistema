<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateTurn
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
        Me.components = New System.ComponentModel.Container()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.TxtBHEnd = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TxtBHStart = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.BtnCaptureEntrace = New DevComponents.DotNetBar.ButtonX()
        Me.BtnCaptureEnd = New DevComponents.DotNetBar.ButtonX()
        Me.TimeSelectHour = New DevComponents.Editors.DateTimeAdv.TimeSelector()
        Me.BtnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.TxtBName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.BtnUpdateTurno = New DevComponents.DotNetBar.ButtonX()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.PanelEx1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.Color.WhiteSmoke
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.TxtBHEnd)
        Me.PanelEx1.Controls.Add(Me.TxtBHStart)
        Me.PanelEx1.Controls.Add(Me.BtnCaptureEntrace)
        Me.PanelEx1.Controls.Add(Me.BtnCaptureEnd)
        Me.PanelEx1.Controls.Add(Me.TimeSelectHour)
        Me.PanelEx1.Controls.Add(Me.BtnCancel)
        Me.PanelEx1.Controls.Add(Me.LabelX3)
        Me.PanelEx1.Controls.Add(Me.LabelX2)
        Me.PanelEx1.Controls.Add(Me.TxtBName)
        Me.PanelEx1.Controls.Add(Me.LabelX1)
        Me.PanelEx1.Controls.Add(Me.BtnUpdateTurno)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(530, 218)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.Color = System.Drawing.Color.WhiteSmoke
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 39
        '
        'TxtBHEnd
        '
        '
        '
        '
        Me.TxtBHEnd.Border.Class = "TextBoxBorder"
        Me.TxtBHEnd.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtBHEnd.DisabledBackColor = System.Drawing.Color.White
        Me.TxtBHEnd.Location = New System.Drawing.Point(203, 155)
        Me.TxtBHEnd.Name = "TxtBHEnd"
        Me.TxtBHEnd.PreventEnterBeep = True
        Me.TxtBHEnd.ReadOnly = True
        Me.TxtBHEnd.Size = New System.Drawing.Size(100, 22)
        Me.TxtBHEnd.TabIndex = 49
        '
        'TxtBHStart
        '
        '
        '
        '
        Me.TxtBHStart.Border.Class = "TextBoxBorder"
        Me.TxtBHStart.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtBHStart.DisabledBackColor = System.Drawing.Color.White
        Me.TxtBHStart.Location = New System.Drawing.Point(203, 98)
        Me.TxtBHStart.Name = "TxtBHStart"
        Me.TxtBHStart.PreventEnterBeep = True
        Me.TxtBHStart.ReadOnly = True
        Me.TxtBHStart.Size = New System.Drawing.Size(100, 22)
        Me.TxtBHStart.TabIndex = 48
        '
        'BtnCaptureEntrace
        '
        Me.BtnCaptureEntrace.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnCaptureEntrace.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnCaptureEntrace.Font = New System.Drawing.Font("Agency FB", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCaptureEntrace.Location = New System.Drawing.Point(12, 179)
        Me.BtnCaptureEntrace.Name = "BtnCaptureEntrace"
        Me.BtnCaptureEntrace.Size = New System.Drawing.Size(94, 20)
        Me.BtnCaptureEntrace.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnCaptureEntrace.TabIndex = 47
        Me.BtnCaptureEntrace.Text = "Establecer Entrada"
        '
        'BtnCaptureEnd
        '
        Me.BtnCaptureEnd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnCaptureEnd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnCaptureEnd.Font = New System.Drawing.Font("Agency FB", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCaptureEnd.Location = New System.Drawing.Point(112, 179)
        Me.BtnCaptureEnd.Name = "BtnCaptureEnd"
        Me.BtnCaptureEnd.Size = New System.Drawing.Size(85, 20)
        Me.BtnCaptureEnd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnCaptureEnd.TabIndex = 46
        Me.BtnCaptureEnd.Text = "Establecer Salida"
        '
        'TimeSelectHour
        '
        Me.TimeSelectHour.AutoSize = True
        '
        '
        '
        Me.TimeSelectHour.BackgroundStyle.Class = "ItemPanel"
        Me.TimeSelectHour.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TimeSelectHour.ContainerControlProcessDialogKey = True
        Me.TimeSelectHour.ForeColor = System.Drawing.Color.Black
        Me.TimeSelectHour.HourText = "Horas"
        Me.TimeSelectHour.Location = New System.Drawing.Point(12, 12)
        Me.TimeSelectHour.MinuteText = "Minutos"
        Me.TimeSelectHour.Name = "TimeSelectHour"
        Me.TimeSelectHour.OkButtonVisible = False
        Me.TimeSelectHour.SelectorType = DevComponents.Editors.DateTimeAdv.eTimeSelectorType.MonthCalendarStyle
        Me.TimeSelectHour.Size = New System.Drawing.Size(185, 161)
        Me.TimeSelectHour.TimeFormat = DevComponents.Editors.DateTimeAdv.eTimeSelectorFormat.Time24H
        '
        'BtnCancel
        '
        Me.BtnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnCancel.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.Location = New System.Drawing.Point(356, 179)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnCancel.TabIndex = 45
        Me.BtnCancel.Text = "Cancelar"
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.ForeColor = System.Drawing.Color.Black
        Me.LabelX3.Location = New System.Drawing.Point(203, 126)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(44, 23)
        Me.LabelX3.TabIndex = 43
        Me.LabelX3.Text = "Salida"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.ForeColor = System.Drawing.Color.Black
        Me.LabelX2.Location = New System.Drawing.Point(203, 69)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(52, 23)
        Me.LabelX2.TabIndex = 42
        Me.LabelX2.Text = "Entrada"
        '
        'TxtBName
        '
        '
        '
        '
        Me.TxtBName.Border.Class = "TextBoxBorder"
        Me.TxtBName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtBName.DisabledBackColor = System.Drawing.Color.White
        Me.TxtBName.Location = New System.Drawing.Point(203, 41)
        Me.TxtBName.MaxLength = 35
        Me.TxtBName.Name = "TxtBName"
        Me.TxtBName.PreventEnterBeep = True
        Me.TxtBName.Size = New System.Drawing.Size(197, 22)
        Me.TxtBName.TabIndex = 41
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(203, 12)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(228, 23)
        Me.LabelX1.TabIndex = 40
        Me.LabelX1.Text = "Digite el Nuevo Titulo del Cargo a Modificar:"
        '
        'BtnUpdateTurno
        '
        Me.BtnUpdateTurno.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnUpdateTurno.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnUpdateTurno.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdateTurno.Location = New System.Drawing.Point(440, 179)
        Me.BtnUpdateTurno.Name = "BtnUpdateTurno"
        Me.BtnUpdateTurno.Size = New System.Drawing.Size(75, 23)
        Me.BtnUpdateTurno.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnUpdateTurno.TabIndex = 39
        Me.BtnUpdateTurno.Text = "Aceptar"
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2010Blue
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer)))
        '
        'UpdateTurn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 218)
        Me.Controls.Add(Me.PanelEx1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "UpdateTurn"
        Me.Text = "Actualizando Turno"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents TxtBHEnd As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TxtBHStart As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents BtnCaptureEntrace As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnCaptureEnd As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TimeSelectHour As DevComponents.Editors.DateTimeAdv.TimeSelector
    Friend WithEvents BtnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TxtBName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents BtnUpdateTurno As DevComponents.DotNetBar.ButtonX
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
End Class

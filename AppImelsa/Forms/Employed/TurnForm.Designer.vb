<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TurnForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TurnForm))
        Dim Background1 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.SuperValidator1 = New DevComponents.DotNetBar.Validator.SuperValidator()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter()
        Me.TxtBHEnd = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TxtBHStar = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TxtBCode = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TxtBName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.BtnUpdateTurno = New DevComponents.DotNetBar.ButtonX()
        Me.BtnDeleteTurno = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.BtnCaptureEntrace = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.BtnCaptureEnd = New DevComponents.DotNetBar.ButtonX()
        Me.TimeSelectHour = New DevComponents.Editors.DateTimeAdv.TimeSelector()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.BtnInsertTurno = New DevComponents.DotNetBar.ButtonX()
        Me.GridCargos = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2010Blue
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer)))
        '
        'SuperValidator1
        '
        Me.SuperValidator1.ContainerControl = Me
        Me.SuperValidator1.ErrorProvider = Me.ErrorProvider1
        Me.SuperValidator1.Highlighter = Me.Highlighter1
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.Icon = CType(resources.GetObject("ErrorProvider1.Icon"), System.Drawing.Icon)
        '
        'Highlighter1
        '
        Me.Highlighter1.ContainerControl = Me
        '
        'TxtBHEnd
        '
        '
        '
        '
        Me.TxtBHEnd.Border.Class = "TextBoxBorder"
        Me.TxtBHEnd.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtBHEnd.DisabledBackColor = System.Drawing.Color.White
        Me.TxtBHEnd.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Highlighter1.SetHighlightOnFocus(Me.TxtBHEnd, True)
        Me.TxtBHEnd.Location = New System.Drawing.Point(63, 122)
        Me.TxtBHEnd.Name = "TxtBHEnd"
        Me.TxtBHEnd.PreventEnterBeep = True
        Me.TxtBHEnd.ReadOnly = True
        Me.TxtBHEnd.Size = New System.Drawing.Size(117, 22)
        Me.TxtBHEnd.TabIndex = 52
        '
        'TxtBHStar
        '
        '
        '
        '
        Me.TxtBHStar.Border.Class = "TextBoxBorder"
        Me.TxtBHStar.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtBHStar.DisabledBackColor = System.Drawing.Color.White
        Me.TxtBHStar.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Highlighter1.SetHighlightOnFocus(Me.TxtBHStar, True)
        Me.TxtBHStar.Location = New System.Drawing.Point(63, 82)
        Me.TxtBHStar.Name = "TxtBHStar"
        Me.TxtBHStar.PreventEnterBeep = True
        Me.TxtBHStar.ReadOnly = True
        Me.TxtBHStar.Size = New System.Drawing.Size(117, 22)
        Me.TxtBHStar.TabIndex = 51
        '
        'TxtBCode
        '
        '
        '
        '
        Me.TxtBCode.Border.Class = "TextBoxBorder"
        Me.TxtBCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtBCode.DisabledBackColor = System.Drawing.Color.White
        Me.TxtBCode.Enabled = False
        Me.TxtBCode.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Highlighter1.SetHighlightOnFocus(Me.TxtBCode, True)
        Me.TxtBCode.Location = New System.Drawing.Point(63, 5)
        Me.TxtBCode.MaxLength = 14
        Me.TxtBCode.Name = "TxtBCode"
        Me.TxtBCode.PreventEnterBeep = True
        Me.TxtBCode.Size = New System.Drawing.Size(117, 22)
        Me.TxtBCode.TabIndex = 47
        Me.TxtBCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtBName
        '
        '
        '
        '
        Me.TxtBName.Border.Class = "TextBoxBorder"
        Me.TxtBName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtBName.DisabledBackColor = System.Drawing.Color.White
        Me.TxtBName.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Highlighter1.SetHighlightOnFocus(Me.TxtBName, True)
        Me.TxtBName.Location = New System.Drawing.Point(63, 40)
        Me.TxtBName.MaxLength = 35
        Me.TxtBName.Name = "TxtBName"
        Me.TxtBName.PreventEnterBeep = True
        Me.TxtBName.Size = New System.Drawing.Size(117, 22)
        Me.TxtBName.TabIndex = 43
        '
        'BtnUpdateTurno
        '
        Me.BtnUpdateTurno.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnUpdateTurno.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnUpdateTurno.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdateTurno.Location = New System.Drawing.Point(624, 216)
        Me.BtnUpdateTurno.Name = "BtnUpdateTurno"
        Me.BtnUpdateTurno.Size = New System.Drawing.Size(87, 21)
        Me.BtnUpdateTurno.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnUpdateTurno.TabIndex = 32
        Me.BtnUpdateTurno.Text = "Actualizar"
        '
        'BtnDeleteTurno
        '
        Me.BtnDeleteTurno.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnDeleteTurno.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnDeleteTurno.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeleteTurno.Location = New System.Drawing.Point(718, 216)
        Me.BtnDeleteTurno.Name = "BtnDeleteTurno"
        Me.BtnDeleteTurno.Size = New System.Drawing.Size(87, 21)
        Me.BtnDeleteTurno.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnDeleteTurno.TabIndex = 30
        Me.BtnDeleteTurno.Text = "Eliminar"
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.ForeColor = System.Drawing.Color.Black
        Me.LabelX3.Location = New System.Drawing.Point(14, 121)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(34, 21)
        Me.LabelX3.TabIndex = 45
        Me.LabelX3.Text = "Salida"
        '
        'BtnCaptureEntrace
        '
        Me.BtnCaptureEntrace.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnCaptureEntrace.Font = New System.Drawing.Font("Agency FB", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCaptureEntrace.Location = New System.Drawing.Point(234, 195)
        Me.BtnCaptureEntrace.Name = "BtnCaptureEntrace"
        Me.BtnCaptureEntrace.Size = New System.Drawing.Size(93, 18)
        Me.BtnCaptureEntrace.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnCaptureEntrace.TabIndex = 50
        Me.BtnCaptureEntrace.Text = "Establecer Entrada"
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.ForeColor = System.Drawing.Color.Black
        Me.LabelX2.Location = New System.Drawing.Point(14, 80)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(43, 21)
        Me.LabelX2.TabIndex = 44
        Me.LabelX2.Text = "Entrada"
        '
        'BtnCaptureEnd
        '
        Me.BtnCaptureEnd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnCaptureEnd.Font = New System.Drawing.Font("Agency FB", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCaptureEnd.Location = New System.Drawing.Point(333, 195)
        Me.BtnCaptureEnd.Name = "BtnCaptureEnd"
        Me.BtnCaptureEnd.Size = New System.Drawing.Size(86, 18)
        Me.BtnCaptureEnd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnCaptureEnd.TabIndex = 49
        Me.BtnCaptureEnd.Text = "Establecer Salida"
        '
        'TimeSelectHour
        '
        Me.TimeSelectHour.AutoSize = True
        '
        '
        '
        Me.TimeSelectHour.BackgroundStyle.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TimeSelectHour.BackgroundStyle.Class = "ItemPanel"
        Me.TimeSelectHour.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TimeSelectHour.ContainerControlProcessDialogKey = True
        Me.TimeSelectHour.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeSelectHour.ForeColor = System.Drawing.Color.Black
        Me.TimeSelectHour.HourText = "Horas"
        Me.TimeSelectHour.Location = New System.Drawing.Point(234, 26)
        Me.TimeSelectHour.MinuteText = "Minutos"
        Me.TimeSelectHour.Name = "TimeSelectHour"
        Me.TimeSelectHour.OkButtonVisible = False
        Me.TimeSelectHour.SelectorType = DevComponents.Editors.DateTimeAdv.eTimeSelectorType.MonthCalendarStyle
        Me.TimeSelectHour.Size = New System.Drawing.Size(185, 161)
        Me.TimeSelectHour.TimeFormat = DevComponents.Editors.DateTimeAdv.eTimeSelectorFormat.Time24H
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(14, 40)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(43, 21)
        Me.LabelX1.TabIndex = 42
        Me.LabelX1.Text = "Nombre"
        '
        'LabelX4
        '
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.ForeColor = System.Drawing.Color.Black
        Me.LabelX4.Location = New System.Drawing.Point(14, 3)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(43, 21)
        Me.LabelX4.TabIndex = 46
        Me.LabelX4.Text = "Codigo"
        '
        'BtnInsertTurno
        '
        Me.BtnInsertTurno.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnInsertTurno.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInsertTurno.Location = New System.Drawing.Point(111, 169)
        Me.BtnInsertTurno.Name = "BtnInsertTurno"
        Me.BtnInsertTurno.Size = New System.Drawing.Size(87, 21)
        Me.BtnInsertTurno.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnInsertTurno.TabIndex = 41
        Me.BtnInsertTurno.Text = "Agregar"
        '
        'GridCargos
        '
        Me.GridCargos.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.GridCargos.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
        Me.GridCargos.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridCargos.ForeColor = System.Drawing.Color.Black
        Me.GridCargos.Location = New System.Drawing.Point(442, 48)
        Me.GridCargos.Name = "GridCargos"
        '
        '
        '
        Me.GridCargos.PrimaryGrid.AllowEdit = False
        '
        '
        '
        Me.GridCargos.PrimaryGrid.Caption.BackgroundImage = Global.AppImelsa.My.Resources.Resources.Anadir
        Background1.Color1 = System.Drawing.Color.DodgerBlue
        Background1.Color2 = System.Drawing.Color.DodgerBlue
        Me.GridCargos.PrimaryGrid.DefaultVisualStyles.AlternateRowCellStyles.Default.Background = Background1
        Me.GridCargos.PrimaryGrid.InitialSelection = DevComponents.DotNetBar.SuperGrid.RelativeSelection.Row
        Me.GridCargos.PrimaryGrid.MultiSelect = False
        Me.GridCargos.PrimaryGrid.PrimaryColumnIndex = 2236962
        Me.GridCargos.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row
        Me.GridCargos.Size = New System.Drawing.Size(362, 137)
        Me.GridCargos.TabIndex = 55
        Me.GridCargos.Text = "SuperGridControl1"
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX6.ForeColor = System.Drawing.Color.Black
        Me.LabelX6.Location = New System.Drawing.Point(705, 19)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(105, 23)
        Me.LabelX6.TabIndex = 54
        Me.LabelX6.Text = "Registro de Turnos"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.GroupPanel1.CanvasColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.LabelX4)
        Me.GroupPanel1.Controls.Add(Me.LabelX1)
        Me.GroupPanel1.Controls.Add(Me.TxtBName)
        Me.GroupPanel1.Controls.Add(Me.TxtBHEnd)
        Me.GroupPanel1.Controls.Add(Me.TxtBCode)
        Me.GroupPanel1.Controls.Add(Me.LabelX2)
        Me.GroupPanel1.Controls.Add(Me.BtnInsertTurno)
        Me.GroupPanel1.Controls.Add(Me.TxtBHStar)
        Me.GroupPanel1.Controls.Add(Me.LabelX3)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel1.Location = New System.Drawing.Point(8, 12)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(218, 225)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 56
        Me.GroupPanel1.Text = "Agregar Nuevo Turno"
        '
        'TurnForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(816, 254)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.GridCargos)
        Me.Controls.Add(Me.LabelX6)
        Me.Controls.Add(Me.BtnCaptureEntrace)
        Me.Controls.Add(Me.BtnUpdateTurno)
        Me.Controls.Add(Me.BtnDeleteTurno)
        Me.Controls.Add(Me.BtnCaptureEnd)
        Me.Controls.Add(Me.TimeSelectHour)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "TurnForm"
        Me.Text = "Agregar y Visualizar Turno"
        Me.TransparencyKey = System.Drawing.Color.Silver
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents SuperValidator1 As DevComponents.DotNetBar.Validator.SuperValidator
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents BtnUpdateTurno As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnDeleteTurno As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TxtBHEnd As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TxtBHStar As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents BtnCaptureEntrace As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents BtnCaptureEnd As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TxtBCode As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TimeSelectHour As DevComponents.Editors.DateTimeAdv.TimeSelector
    Friend WithEvents TxtBName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents BtnInsertTurno As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GridCargos As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
End Class

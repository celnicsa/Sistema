<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddPrestamoForm
    Inherits DevComponents.DotNetBar.Metro.MetroForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddPrestamoForm))
        Me.ProgressSteps1 = New DevComponents.DotNetBar.ProgressSteps()
        Me.ProgressOne = New DevComponents.DotNetBar.StepItem()
        Me.PSliderEmployed = New DevComponents.DotNetBar.Controls.PageSlider()
        Me.PageSliderPage1 = New DevComponents.DotNetBar.Controls.PageSliderPage()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.GLoadEmployed = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.TxtBCuota = New DevComponents.Editors.DoubleInput()
        Me.TxtBMonto = New DevComponents.Editors.DoubleInput()
        Me.DateInput = New System.Windows.Forms.DateTimePicker()
        Me.ReflectionLabel1 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.TxtBCode = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.BtnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.BtnAccept = New DevComponents.DotNetBar.ButtonX()
        Me.SuperValidator1 = New DevComponents.DotNetBar.Validator.SuperValidator()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.PSliderEmployed.SuspendLayout()
        Me.PageSliderPage1.SuspendLayout()
        CType(Me.TxtBCuota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtBMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProgressSteps1
        '
        Me.ProgressSteps1.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        '
        '
        '
        Me.ProgressSteps1.BackgroundStyle.Class = "ProgressSteps"
        Me.ProgressSteps1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ProgressSteps1.ContainerControlProcessDialogKey = True
        Me.ProgressSteps1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ProgressSteps1.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProgressSteps1.ForeColor = System.Drawing.Color.Black
        Me.ProgressSteps1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ProgressOne})
        Me.ProgressSteps1.Location = New System.Drawing.Point(0, 0)
        Me.ProgressSteps1.Name = "ProgressSteps1"
        Me.ProgressSteps1.Size = New System.Drawing.Size(846, 29)
        Me.ProgressSteps1.TabIndex = 173
        '
        'ProgressOne
        '
        Me.ProgressOne.BackColors = New System.Drawing.Color() {System.Drawing.Color.Gainsboro, System.Drawing.Color.White}
        Me.ProgressOne.Name = "ProgressOne"
        Me.ProgressOne.Symbol = "58903"
        Me.ProgressOne.SymbolColor = System.Drawing.Color.DarkSlateGray
        Me.ProgressOne.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material
        Me.ProgressOne.SymbolSize = 15.0!
        Me.ProgressOne.Text = "Nuevo Prestamo"
        '
        'PSliderEmployed
        '
        Me.PSliderEmployed.AllowDrop = True
        Me.PSliderEmployed.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.PSliderEmployed.Controls.Add(Me.PageSliderPage1)
        Me.PSliderEmployed.ForeColor = System.Drawing.Color.Black
        Me.PSliderEmployed.Location = New System.Drawing.Point(12, 53)
        Me.PSliderEmployed.MouseDragEnabled = False
        Me.PSliderEmployed.Name = "PSliderEmployed"
        Me.PSliderEmployed.NextPageVisibleMargin = 0
        Me.PSliderEmployed.PageMouseDragEnabled = False
        Me.PSliderEmployed.ScrollBarVisibility = DevComponents.DotNetBar.Controls.eScrollBarVisibility.Hidden
        Me.PSliderEmployed.SelectedPage = Me.PageSliderPage1
        Me.PSliderEmployed.Size = New System.Drawing.Size(808, 299)
        Me.PSliderEmployed.TabIndex = 176
        Me.PSliderEmployed.Text = "PageSlider1"
        Me.PSliderEmployed.TouchEnabled = DevComponents.DotNetBar.Controls.eTouchHandling.No
        '
        'PageSliderPage1
        '
        Me.PageSliderPage1.AllowDrop = True
        Me.PageSliderPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.PageSliderPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PageSliderPage1.Controls.Add(Me.LabelX3)
        Me.PageSliderPage1.Controls.Add(Me.GLoadEmployed)
        Me.PageSliderPage1.Controls.Add(Me.TxtBCuota)
        Me.PageSliderPage1.Controls.Add(Me.TxtBMonto)
        Me.PageSliderPage1.Controls.Add(Me.DateInput)
        Me.PageSliderPage1.Controls.Add(Me.ReflectionLabel1)
        Me.PageSliderPage1.Controls.Add(Me.LabelX1)
        Me.PageSliderPage1.Controls.Add(Me.LabelX2)
        Me.PageSliderPage1.Controls.Add(Me.TxtBCode)
        Me.PageSliderPage1.Controls.Add(Me.LabelX5)
        Me.PageSliderPage1.Controls.Add(Me.LabelX6)
        Me.PageSliderPage1.ForeColor = System.Drawing.Color.Black
        Me.PageSliderPage1.Location = New System.Drawing.Point(4, 8)
        Me.PageSliderPage1.Name = "PageSliderPage1"
        Me.PageSliderPage1.Size = New System.Drawing.Size(752, 287)
        Me.PageSliderPage1.TabIndex = 3
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.ForeColor = System.Drawing.Color.Black
        Me.LabelX3.Location = New System.Drawing.Point(255, 56)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(189, 23)
        Me.LabelX3.TabIndex = 178
        Me.LabelX3.Text = "Seleccione Un Empleado Solicitante"
        '
        'GLoadEmployed
        '
        Me.GLoadEmployed.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.GLoadEmployed.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
        Me.GLoadEmployed.ForeColor = System.Drawing.Color.Black
        Me.GLoadEmployed.Location = New System.Drawing.Point(255, 84)
        Me.GLoadEmployed.Name = "GLoadEmployed"
        '
        '
        '
        Me.GLoadEmployed.PrimaryGrid.AllowEdit = False
        Me.GLoadEmployed.PrimaryGrid.InitialSelection = DevComponents.DotNetBar.SuperGrid.RelativeSelection.Row
        Me.GLoadEmployed.PrimaryGrid.MultiSelect = False
        Me.GLoadEmployed.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row
        Me.GLoadEmployed.Size = New System.Drawing.Size(453, 145)
        Me.GLoadEmployed.TabIndex = 177
        Me.GLoadEmployed.Text = "GLoadEmployed"
        '
        'TxtBCuota
        '
        Me.TxtBCuota.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TxtBCuota.BackgroundStyle.BackColor = System.Drawing.Color.White
        Me.TxtBCuota.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.TxtBCuota.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtBCuota.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.TxtBCuota.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBCuota.ForeColor = System.Drawing.Color.Black
        Me.Highlighter1.SetHighlightOnFocus(Me.TxtBCuota, True)
        Me.TxtBCuota.Increment = 1.0R
        Me.TxtBCuota.Location = New System.Drawing.Point(80, 146)
        Me.TxtBCuota.Name = "TxtBCuota"
        Me.TxtBCuota.ShowUpDown = True
        Me.TxtBCuota.Size = New System.Drawing.Size(138, 22)
        Me.TxtBCuota.TabIndex = 176
        '
        'TxtBMonto
        '
        Me.TxtBMonto.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TxtBMonto.BackgroundStyle.BackColor = System.Drawing.Color.White
        Me.TxtBMonto.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.TxtBMonto.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtBMonto.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.TxtBMonto.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBMonto.ForeColor = System.Drawing.Color.Black
        Me.Highlighter1.SetHighlightOnFocus(Me.TxtBMonto, True)
        Me.TxtBMonto.Increment = 1.0R
        Me.TxtBMonto.Location = New System.Drawing.Point(80, 102)
        Me.TxtBMonto.Name = "TxtBMonto"
        Me.TxtBMonto.ShowUpDown = True
        Me.TxtBMonto.Size = New System.Drawing.Size(138, 22)
        Me.TxtBMonto.TabIndex = 175
        '
        'DateInput
        '
        Me.DateInput.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.DateInput.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateInput.ForeColor = System.Drawing.Color.Black
        Me.DateInput.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Highlighter1.SetHighlightOnFocus(Me.DateInput, True)
        Me.DateInput.Location = New System.Drawing.Point(80, 187)
        Me.DateInput.Name = "DateInput"
        Me.DateInput.Size = New System.Drawing.Size(138, 22)
        Me.DateInput.TabIndex = 174
        '
        'ReflectionLabel1
        '
        Me.ReflectionLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        '
        '
        '
        Me.ReflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionLabel1.Font = New System.Drawing.Font("Agency FB", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReflectionLabel1.ForeColor = System.Drawing.Color.Black
        Me.ReflectionLabel1.Location = New System.Drawing.Point(15, 6)
        Me.ReflectionLabel1.Name = "ReflectionLabel1"
        Me.ReflectionLabel1.Size = New System.Drawing.Size(161, 29)
        Me.ReflectionLabel1.TabIndex = 171
        Me.ReflectionLabel1.Text = "<b><font size=""+5""><i>Datos</i><font color=""#003333""> del Prestamo</font></font><" &
    "/b>"
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
        Me.LabelX1.Location = New System.Drawing.Point(32, 101)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(42, 23)
        Me.LabelX1.TabIndex = 148
        Me.LabelX1.Text = "Monto"
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
        Me.LabelX2.Location = New System.Drawing.Point(32, 145)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(42, 23)
        Me.LabelX2.TabIndex = 151
        Me.LabelX2.Text = "Cuota"
        '
        'TxtBCode
        '
        '
        '
        '
        Me.TxtBCode.Border.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial
        Me.TxtBCode.Border.Class = "TextBoxBorder"
        Me.TxtBCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtBCode.DisabledBackColor = System.Drawing.Color.White
        Me.TxtBCode.Enabled = False
        Me.TxtBCode.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Highlighter1.SetHighlightOnFocus(Me.TxtBCode, True)
        Me.TxtBCode.Location = New System.Drawing.Point(80, 58)
        Me.TxtBCode.Name = "TxtBCode"
        Me.TxtBCode.PreventEnterBeep = True
        Me.TxtBCode.Size = New System.Drawing.Size(98, 22)
        Me.TxtBCode.TabIndex = 170
        Me.TxtBCode.Text = "C2013-0001"
        Me.TxtBCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelX5
        '
        Me.LabelX5.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.ForeColor = System.Drawing.Color.Black
        Me.LabelX5.Location = New System.Drawing.Point(24, 58)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(50, 23)
        Me.LabelX5.TabIndex = 169
        Me.LabelX5.Text = "Codigo"
        Me.LabelX5.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LabelX6
        '
        Me.LabelX6.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX6.ForeColor = System.Drawing.Color.Black
        Me.LabelX6.Location = New System.Drawing.Point(32, 187)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(42, 23)
        Me.LabelX6.TabIndex = 160
        Me.LabelX6.Text = "Fecha"
        '
        'BtnCancel
        '
        Me.BtnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnCancel.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.Location = New System.Drawing.Point(664, 373)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnCancel.TabIndex = 175
        Me.BtnCancel.Text = "Cancelar"
        '
        'BtnAccept
        '
        Me.BtnAccept.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnAccept.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnAccept.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAccept.Location = New System.Drawing.Point(745, 373)
        Me.BtnAccept.Name = "BtnAccept"
        Me.BtnAccept.Size = New System.Drawing.Size(75, 23)
        Me.BtnAccept.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnAccept.TabIndex = 174
        Me.BtnAccept.Text = "Aceptar"
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
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2010Blue
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.WhiteSmoke, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(198, Byte), Integer)))
        '
        'AddPrestamoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(846, 403)
        Me.Controls.Add(Me.PSliderEmployed)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnAccept)
        Me.Controls.Add(Me.ProgressSteps1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "AddPrestamoForm"
        Me.Text = "Nuevo Prestamo"
        Me.PSliderEmployed.ResumeLayout(False)
        Me.PageSliderPage1.ResumeLayout(False)
        CType(Me.TxtBCuota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtBMonto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ProgressSteps1 As DevComponents.DotNetBar.ProgressSteps
    Friend WithEvents ProgressOne As DevComponents.DotNetBar.StepItem
    Friend WithEvents PSliderEmployed As DevComponents.DotNetBar.Controls.PageSlider
    Friend WithEvents PageSliderPage1 As DevComponents.DotNetBar.Controls.PageSliderPage
    Friend WithEvents ReflectionLabel1 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TxtBCode As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents BtnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnAccept As DevComponents.DotNetBar.ButtonX
    Friend WithEvents DateInput As DateTimePicker
    Friend WithEvents TxtBCuota As DevComponents.Editors.DoubleInput
    Friend WithEvents TxtBMonto As DevComponents.Editors.DoubleInput
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GLoadEmployed As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
    Friend WithEvents SuperValidator1 As DevComponents.DotNetBar.Validator.SuperValidator
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
End Class

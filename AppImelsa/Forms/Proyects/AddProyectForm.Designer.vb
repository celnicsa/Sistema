<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddProyectForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddProyectForm))
        Me.TxtBName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.DateInputInit = New System.Windows.Forms.DateTimePicker()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.DateInputEnd = New System.Windows.Forms.DateTimePicker()
        Me.TxtBUbicacion = New DevComponents.DotNetBar.Controls.RichTextBoxEx()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.TxtBDesc = New DevComponents.DotNetBar.Controls.RichTextBoxEx()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.BtnAccept = New DevComponents.DotNetBar.ButtonX()
        Me.BtnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtBCode = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.bar1 = New DevComponents.DotNetBar.Bar()
        Me.labelItem1 = New DevComponents.DotNetBar.LabelItem()
        Me.CProgress = New DevComponents.DotNetBar.CircularProgressItem()
        Me.ProgressSteps1 = New DevComponents.DotNetBar.ProgressSteps()
        Me.ProgressOne = New DevComponents.DotNetBar.StepItem()
        Me.PSliderEmployed = New DevComponents.DotNetBar.Controls.PageSlider()
        Me.PageSliderPage1 = New DevComponents.DotNetBar.Controls.PageSliderPage()
        Me.TxtBPresupuesto = New DevComponents.Editors.DoubleInput()
        Me.CmBClient = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ReflectionLabel1 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.SuperValidator1 = New DevComponents.DotNetBar.Validator.SuperValidator()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.bar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PSliderEmployed.SuspendLayout()
        Me.PageSliderPage1.SuspendLayout()
        CType(Me.TxtBPresupuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtBName
        '
        Me.TxtBName.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        '
        '
        '
        Me.TxtBName.Border.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial
        Me.TxtBName.Border.Class = "TextBoxBorder"
        Me.TxtBName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtBName.DisabledBackColor = System.Drawing.Color.White
        Me.TxtBName.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Highlighter1.SetHighlightOnFocus(Me.TxtBName, True)
        Me.TxtBName.Location = New System.Drawing.Point(107, 54)
        Me.TxtBName.MaxLength = 15
        Me.TxtBName.Name = "TxtBName"
        Me.TxtBName.PreventEnterBeep = True
        Me.TxtBName.Size = New System.Drawing.Size(173, 22)
        Me.TxtBName.TabIndex = 0
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
        Me.LabelX1.Location = New System.Drawing.Point(23, 54)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(78, 23)
        Me.LabelX1.TabIndex = 148
        Me.LabelX1.Text = "Titulo/Nombre"
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
        Me.LabelX2.Location = New System.Drawing.Point(23, 89)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(71, 23)
        Me.LabelX2.TabIndex = 151
        Me.LabelX2.Text = "Presupuesto"
        '
        'DateInputInit
        '
        Me.DateInputInit.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.DateInputInit.ForeColor = System.Drawing.Color.Black
        Me.DateInputInit.Location = New System.Drawing.Point(124, 27)
        Me.DateInputInit.Name = "DateInputInit"
        Me.DateInputInit.Size = New System.Drawing.Size(200, 22)
        Me.DateInputInit.TabIndex = 5
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
        Me.LabelX3.Location = New System.Drawing.Point(20, 23)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(77, 23)
        Me.LabelX3.TabIndex = 156
        Me.LabelX3.Text = "Fecha de Inicio"
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
        Me.LabelX4.Location = New System.Drawing.Point(20, 54)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(98, 23)
        Me.LabelX4.TabIndex = 158
        Me.LabelX4.Text = "Fecha Culminación"
        '
        'DateInputEnd
        '
        Me.DateInputEnd.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.DateInputEnd.ForeColor = System.Drawing.Color.Black
        Me.DateInputEnd.Location = New System.Drawing.Point(124, 55)
        Me.DateInputEnd.Name = "DateInputEnd"
        Me.DateInputEnd.Size = New System.Drawing.Size(200, 22)
        Me.DateInputEnd.TabIndex = 6
        '
        'TxtBUbicacion
        '
        Me.TxtBUbicacion.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TxtBUbicacion.BackgroundStyle.Class = "RichTextBoxBorder"
        Me.TxtBUbicacion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtBUbicacion.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBUbicacion.ForeColor = System.Drawing.Color.Black
        Me.Highlighter1.SetHighlightOnFocus(Me.TxtBUbicacion, True)
        Me.TxtBUbicacion.Location = New System.Drawing.Point(107, 135)
        Me.TxtBUbicacion.Name = "TxtBUbicacion"
        Me.TxtBUbicacion.Rtf = "{\rtf1\ansi\ansicpg1252\deff0\deflang19466{\fonttbl{\f0\fnil\fcharset0 Arial Narr" &
    "ow;}}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "\viewkind4\uc1\pard\f0\fs20\par" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.TxtBUbicacion.Size = New System.Drawing.Size(261, 56)
        Me.TxtBUbicacion.TabIndex = 2
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
        Me.LabelX6.Location = New System.Drawing.Point(23, 135)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(63, 23)
        Me.LabelX6.TabIndex = 160
        Me.LabelX6.Text = "Ubicacion"
        '
        'LabelX7
        '
        Me.LabelX7.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX7.ForeColor = System.Drawing.Color.Black
        Me.LabelX7.Location = New System.Drawing.Point(23, 217)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(68, 23)
        Me.LabelX7.TabIndex = 162
        Me.LabelX7.Text = "Descripcion"
        '
        'TxtBDesc
        '
        Me.TxtBDesc.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TxtBDesc.BackgroundStyle.Class = "RichTextBoxBorder"
        Me.TxtBDesc.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtBDesc.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBDesc.ForeColor = System.Drawing.Color.Black
        Me.Highlighter1.SetHighlightOnFocus(Me.TxtBDesc, True)
        Me.TxtBDesc.Location = New System.Drawing.Point(107, 217)
        Me.TxtBDesc.Name = "TxtBDesc"
        Me.TxtBDesc.Rtf = "{\rtf1\ansi\ansicpg1252\deff0\deflang19466{\fonttbl{\f0\fnil\fcharset0 Arial Narr" &
    "ow;}}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "\viewkind4\uc1\pard\f0\fs20\par" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.TxtBDesc.Size = New System.Drawing.Size(261, 56)
        Me.TxtBDesc.TabIndex = 3
        '
        'LabelX8
        '
        Me.LabelX8.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX8.ForeColor = System.Drawing.Color.Black
        Me.LabelX8.Location = New System.Drawing.Point(378, 66)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(81, 23)
        Me.LabelX8.TabIndex = 163
        Me.LabelX8.Text = "Solicitado Por"
        '
        'BtnAccept
        '
        Me.BtnAccept.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnAccept.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnAccept.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAccept.Location = New System.Drawing.Point(780, 398)
        Me.BtnAccept.Name = "BtnAccept"
        Me.BtnAccept.Size = New System.Drawing.Size(75, 23)
        Me.BtnAccept.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnAccept.TabIndex = 165
        Me.BtnAccept.Text = "Aceptar"
        '
        'BtnCancel
        '
        Me.BtnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnCancel.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.Location = New System.Drawing.Point(699, 398)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnCancel.TabIndex = 166
        Me.BtnCancel.Text = "Cancelar"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.LabelX3)
        Me.GroupBox1.Controls.Add(Me.DateInputInit)
        Me.GroupBox1.Controls.Add(Me.DateInputEnd)
        Me.GroupBox1.Controls.Add(Me.LabelX4)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(378, 112)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(342, 109)
        Me.GroupBox1.TabIndex = 167
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fechas"
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
        Me.TxtBCode.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBCode.Location = New System.Drawing.Point(644, 18)
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
        Me.LabelX5.Location = New System.Drawing.Point(670, 37)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(50, 22)
        Me.LabelX5.TabIndex = 169
        Me.LabelX5.Text = "Codigo"
        Me.LabelX5.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'bar1
        '
        Me.bar1.AccessibleDescription = "bar1 (bar1)"
        Me.bar1.AccessibleName = "bar1"
        Me.bar1.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me.bar1.AntiAlias = True
        Me.bar1.BarType = DevComponents.DotNetBar.eBarType.StatusBar
        Me.bar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bar1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.bar1.IsMaximized = False
        Me.bar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.labelItem1, Me.CProgress})
        Me.bar1.Location = New System.Drawing.Point(0, 427)
        Me.bar1.Name = "bar1"
        Me.bar1.Size = New System.Drawing.Size(862, 28)
        Me.bar1.Stretch = True
        Me.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.bar1.TabIndex = 171
        Me.bar1.TabStop = False
        Me.bar1.Text = "bar1"
        '
        'labelItem1
        '
        Me.labelItem1.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far
        Me.labelItem1.Name = "labelItem1"
        Me.labelItem1.Text = "Esperando"
        '
        'CProgress
        '
        Me.CProgress.Name = "CProgress"
        Me.CProgress.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Spoke
        Me.CProgress.ProgressColor = System.Drawing.Color.DarkOrange
        Me.CProgress.TextPosition = DevComponents.DotNetBar.eTextPosition.Bottom
        Me.CProgress.Value = 45
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
        Me.ProgressSteps1.Size = New System.Drawing.Size(862, 37)
        Me.ProgressSteps1.TabIndex = 172
        '
        'ProgressOne
        '
        Me.ProgressOne.BackColors = New System.Drawing.Color() {System.Drawing.Color.Gainsboro, System.Drawing.Color.White}
        Me.ProgressOne.Name = "ProgressOne"
        Me.ProgressOne.Symbol = "58903"
        Me.ProgressOne.SymbolColor = System.Drawing.Color.DarkSlateGray
        Me.ProgressOne.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material
        Me.ProgressOne.SymbolSize = 15.0!
        Me.ProgressOne.Text = "Nuevo Proyecto"
        '
        'PSliderEmployed
        '
        Me.PSliderEmployed.AllowDrop = True
        Me.PSliderEmployed.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.PSliderEmployed.Controls.Add(Me.PageSliderPage1)
        Me.PSliderEmployed.ForeColor = System.Drawing.Color.Black
        Me.ErrorProvider1.SetIconAlignment(Me.PSliderEmployed, System.Windows.Forms.ErrorIconAlignment.MiddleLeft)
        Me.PSliderEmployed.Location = New System.Drawing.Point(12, 33)
        Me.PSliderEmployed.MouseDragEnabled = False
        Me.PSliderEmployed.Name = "PSliderEmployed"
        Me.PSliderEmployed.NextPageVisibleMargin = 0
        Me.PSliderEmployed.PageMouseDragEnabled = False
        Me.PSliderEmployed.ScrollBarVisibility = DevComponents.DotNetBar.Controls.eScrollBarVisibility.Hidden
        Me.PSliderEmployed.SelectedPage = Me.PageSliderPage1
        Me.PSliderEmployed.Size = New System.Drawing.Size(805, 349)
        Me.PSliderEmployed.TabIndex = 173
        Me.PSliderEmployed.Text = "PageSlider1"
        Me.PSliderEmployed.TouchEnabled = DevComponents.DotNetBar.Controls.eTouchHandling.No
        '
        'PageSliderPage1
        '
        Me.PageSliderPage1.AllowDrop = True
        Me.PageSliderPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.PageSliderPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PageSliderPage1.Controls.Add(Me.TxtBPresupuesto)
        Me.PageSliderPage1.Controls.Add(Me.CmBClient)
        Me.PageSliderPage1.Controls.Add(Me.ReflectionLabel1)
        Me.PageSliderPage1.Controls.Add(Me.LabelX1)
        Me.PageSliderPage1.Controls.Add(Me.TxtBName)
        Me.PageSliderPage1.Controls.Add(Me.LabelX2)
        Me.PageSliderPage1.Controls.Add(Me.TxtBCode)
        Me.PageSliderPage1.Controls.Add(Me.LabelX5)
        Me.PageSliderPage1.Controls.Add(Me.LabelX8)
        Me.PageSliderPage1.Controls.Add(Me.TxtBUbicacion)
        Me.PageSliderPage1.Controls.Add(Me.LabelX6)
        Me.PageSliderPage1.Controls.Add(Me.GroupBox1)
        Me.PageSliderPage1.Controls.Add(Me.TxtBDesc)
        Me.PageSliderPage1.Controls.Add(Me.LabelX7)
        Me.PageSliderPage1.ForeColor = System.Drawing.Color.Black
        Me.PageSliderPage1.Location = New System.Drawing.Point(4, 8)
        Me.PageSliderPage1.Name = "PageSliderPage1"
        Me.PageSliderPage1.Size = New System.Drawing.Size(749, 337)
        Me.PageSliderPage1.TabIndex = 3
        '
        'TxtBPresupuesto
        '
        Me.TxtBPresupuesto.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TxtBPresupuesto.BackgroundStyle.BackColor = System.Drawing.Color.White
        Me.TxtBPresupuesto.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.TxtBPresupuesto.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtBPresupuesto.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.TxtBPresupuesto.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBPresupuesto.ForeColor = System.Drawing.Color.Black
        Me.Highlighter1.SetHighlightOnFocus(Me.TxtBPresupuesto, True)
        Me.TxtBPresupuesto.Increment = 1.0R
        Me.TxtBPresupuesto.Location = New System.Drawing.Point(107, 90)
        Me.TxtBPresupuesto.Name = "TxtBPresupuesto"
        Me.TxtBPresupuesto.ShowUpDown = True
        Me.TxtBPresupuesto.Size = New System.Drawing.Size(142, 22)
        Me.TxtBPresupuesto.TabIndex = 1
        '
        'CmBClient
        '
        Me.CmBClient.DisplayMember = "Text"
        Me.CmBClient.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmBClient.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmBClient.FormattingEnabled = True
        Me.Highlighter1.SetHighlightOnFocus(Me.CmBClient, True)
        Me.CmBClient.ItemHeight = 16
        Me.CmBClient.Location = New System.Drawing.Point(455, 67)
        Me.CmBClient.Name = "CmBClient"
        Me.CmBClient.Size = New System.Drawing.Size(121, 22)
        Me.CmBClient.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CmBClient.TabIndex = 4
        '
        'ReflectionLabel1
        '
        Me.ReflectionLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        '
        '
        '
        Me.ReflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionLabel1.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReflectionLabel1.ForeColor = System.Drawing.Color.Black
        Me.ReflectionLabel1.Location = New System.Drawing.Point(15, 6)
        Me.ReflectionLabel1.Name = "ReflectionLabel1"
        Me.ReflectionLabel1.Size = New System.Drawing.Size(161, 42)
        Me.ReflectionLabel1.TabIndex = 171
        Me.ReflectionLabel1.Text = "<b><font size=""+6""><i>Datos</i><font color=""#003333""> del Proyecto</font></font><" &
    "/b>"
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
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer)))
        '
        'AddProyectForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 455)
        Me.Controls.Add(Me.PSliderEmployed)
        Me.Controls.Add(Me.ProgressSteps1)
        Me.Controls.Add(Me.bar1)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnAccept)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "AddProyectForm"
        Me.Text = "Nuevo Proyecto"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.bar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PSliderEmployed.ResumeLayout(False)
        Me.PageSliderPage1.ResumeLayout(False)
        CType(Me.TxtBPresupuesto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TxtBName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents DateInputInit As DateTimePicker
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents DateInputEnd As DateTimePicker
    Friend WithEvents TxtBUbicacion As DevComponents.DotNetBar.Controls.RichTextBoxEx
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TxtBDesc As DevComponents.DotNetBar.Controls.RichTextBoxEx
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents BtnAccept As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtBCode As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Private WithEvents bar1 As DevComponents.DotNetBar.Bar
    Private WithEvents labelItem1 As DevComponents.DotNetBar.LabelItem
    Private WithEvents CProgress As DevComponents.DotNetBar.CircularProgressItem
    Friend WithEvents ProgressSteps1 As DevComponents.DotNetBar.ProgressSteps
    Friend WithEvents ProgressOne As DevComponents.DotNetBar.StepItem
    Friend WithEvents PSliderEmployed As DevComponents.DotNetBar.Controls.PageSlider
    Friend WithEvents PageSliderPage1 As DevComponents.DotNetBar.Controls.PageSliderPage
    Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
    Friend WithEvents SuperValidator1 As DevComponents.DotNetBar.Validator.SuperValidator
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents ReflectionLabel1 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents CmBClient As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents TxtBPresupuesto As DevComponents.Editors.DoubleInput
End Class

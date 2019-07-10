<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProyectForm
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
        Dim Background1 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProyectForm))
        Me.BtnUpdateEmployed = New DevComponents.DotNetBar.ButtonX()
        Me.BtnDeleteEmployed = New DevComponents.DotNetBar.ButtonX()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.GridProyect = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.ReflectionLabel1 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.ReflectionLabel2 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.RbtnIden = New System.Windows.Forms.RadioButton()
        Me.RbtnCode = New System.Windows.Forms.RadioButton()
        Me.RbtnName = New System.Windows.Forms.RadioButton()
        Me.RbtnAll = New System.Windows.Forms.RadioButton()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.PanelEx3 = New DevComponents.DotNetBar.PanelEx()
        Me.ChBDateEnd = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.ChBDateInit = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.DinputEnd_2 = New System.Windows.Forms.DateTimePicker()
        Me.DinputEnd_1 = New System.Windows.Forms.DateTimePicker()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.DinputInit_2 = New System.Windows.Forms.DateTimePicker()
        Me.DinputInit_1 = New System.Windows.Forms.DateTimePicker()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.CmBEstado = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.BtnSearch = New DevComponents.DotNetBar.ButtonX()
        Me.TxtBSearch = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.BtnGenerarReport = New DevComponents.DotNetBar.ButtonX()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnLoadTable = New DevComponents.DotNetBar.ButtonX()
        Me.BtnNewEmployed = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx2.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.PanelEx3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnUpdateEmployed
        '
        Me.BtnUpdateEmployed.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnUpdateEmployed.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnUpdateEmployed.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdateEmployed.Location = New System.Drawing.Point(942, 457)
        Me.BtnUpdateEmployed.Name = "BtnUpdateEmployed"
        Me.BtnUpdateEmployed.Size = New System.Drawing.Size(75, 23)
        Me.BtnUpdateEmployed.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnUpdateEmployed.TabIndex = 29
        Me.BtnUpdateEmployed.Text = "Actualizar"
        '
        'BtnDeleteEmployed
        '
        Me.BtnDeleteEmployed.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnDeleteEmployed.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnDeleteEmployed.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeleteEmployed.Location = New System.Drawing.Point(1023, 457)
        Me.BtnDeleteEmployed.Name = "BtnDeleteEmployed"
        Me.BtnDeleteEmployed.Size = New System.Drawing.Size(75, 23)
        Me.BtnDeleteEmployed.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnDeleteEmployed.TabIndex = 28
        Me.BtnDeleteEmployed.Text = "Eliminar"
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2010Blue
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer)))
        '
        'GridProyect
        '
        Me.GridProyect.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.GridProyect.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
        Me.GridProyect.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridProyect.ForeColor = System.Drawing.Color.Black
        Me.GridProyect.Location = New System.Drawing.Point(265, 170)
        Me.GridProyect.Name = "GridProyect"
        '
        '
        '
        Me.GridProyect.PrimaryGrid.AllowEdit = False
        '
        '
        '
        Me.GridProyect.PrimaryGrid.Caption.BackgroundImage = Global.AppImelsa.My.Resources.Resources.Anadir
        Background1.Color1 = System.Drawing.Color.DodgerBlue
        Background1.Color2 = System.Drawing.Color.DodgerBlue
        Me.GridProyect.PrimaryGrid.DefaultVisualStyles.AlternateRowCellStyles.Default.Background = Background1
        Me.GridProyect.PrimaryGrid.InitialSelection = DevComponents.DotNetBar.SuperGrid.RelativeSelection.Row
        Me.GridProyect.PrimaryGrid.MultiSelect = False
        Me.GridProyect.PrimaryGrid.PrimaryColumnIndex = 2236962
        Me.GridProyect.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row
        Me.GridProyect.Size = New System.Drawing.Size(832, 273)
        Me.GridProyect.TabIndex = 39
        Me.GridProyect.Text = "SuperGridControl1"
        '
        'ReflectionLabel1
        '
        Me.ReflectionLabel1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.ReflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionLabel1.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReflectionLabel1.ForeColor = System.Drawing.Color.Black
        Me.ReflectionLabel1.Location = New System.Drawing.Point(729, 12)
        Me.ReflectionLabel1.Name = "ReflectionLabel1"
        Me.ReflectionLabel1.Size = New System.Drawing.Size(364, 35)
        Me.ReflectionLabel1.TabIndex = 40
        Me.ReflectionLabel1.Text = "<b><font size=""+6""><i>Construcciones Eléctricas de Nicaragua SA.</i><font color=""" &
    "#222222""></font><font color=""#003333""></font></font></b>"
        '
        'ReflectionLabel2
        '
        Me.ReflectionLabel2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.ReflectionLabel2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionLabel2.Font = New System.Drawing.Font("Agency FB", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReflectionLabel2.ForeColor = System.Drawing.Color.Black
        Me.ReflectionLabel2.Location = New System.Drawing.Point(878, 53)
        Me.ReflectionLabel2.Name = "ReflectionLabel2"
        Me.ReflectionLabel2.Size = New System.Drawing.Size(221, 23)
        Me.ReflectionLabel2.TabIndex = 41
        Me.ReflectionLabel2.Text = "<b><font size=""+6""><i>Registro y</i><font color=""#222222""> Control </font><font c" &
    "olor=""#003333"">de Proyectos</font></font></b>"
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.GroupPanel2)
        Me.PanelEx2.Controls.Add(Me.GroupPanel1)
        Me.PanelEx2.Controls.Add(Me.LabelX2)
        Me.PanelEx2.Controls.Add(Me.BtnSearch)
        Me.PanelEx2.Controls.Add(Me.TxtBSearch)
        Me.PanelEx2.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx2.Location = New System.Drawing.Point(12, 12)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(232, 481)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 46
        '
        'GroupPanel2
        '
        Me.GroupPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.GroupPanel2.CanvasColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.RbtnIden)
        Me.GroupPanel2.Controls.Add(Me.RbtnCode)
        Me.GroupPanel2.Controls.Add(Me.RbtnName)
        Me.GroupPanel2.Controls.Add(Me.RbtnAll)
        Me.GroupPanel2.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel2.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel2.Location = New System.Drawing.Point(12, 94)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(202, 132)
        '
        '
        '
        Me.GroupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel2.Style.BackColorGradientAngle = 90
        Me.GroupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderBottomWidth = 1
        Me.GroupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderLeftWidth = 1
        Me.GroupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderRightWidth = 1
        Me.GroupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderTopWidth = 1
        Me.GroupPanel2.Style.CornerDiameter = 4
        Me.GroupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel2.TabIndex = 39
        Me.GroupPanel2.Text = "Aplicar Busqueda Por"
        '
        'RbtnIden
        '
        Me.RbtnIden.AutoSize = True
        Me.RbtnIden.BackColor = System.Drawing.Color.Transparent
        Me.RbtnIden.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbtnIden.ForeColor = System.Drawing.Color.Black
        Me.RbtnIden.Location = New System.Drawing.Point(20, 51)
        Me.RbtnIden.Name = "RbtnIden"
        Me.RbtnIden.Size = New System.Drawing.Size(54, 22)
        Me.RbtnIden.TabIndex = 3
        Me.RbtnIden.Text = "Cliente"
        Me.RbtnIden.UseVisualStyleBackColor = False
        '
        'RbtnCode
        '
        Me.RbtnCode.AutoSize = True
        Me.RbtnCode.BackColor = System.Drawing.Color.Transparent
        Me.RbtnCode.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbtnCode.ForeColor = System.Drawing.Color.Black
        Me.RbtnCode.Location = New System.Drawing.Point(20, 3)
        Me.RbtnCode.Name = "RbtnCode"
        Me.RbtnCode.Size = New System.Drawing.Size(54, 22)
        Me.RbtnCode.TabIndex = 2
        Me.RbtnCode.Text = "Codigo"
        Me.RbtnCode.UseVisualStyleBackColor = False
        '
        'RbtnName
        '
        Me.RbtnName.AutoSize = True
        Me.RbtnName.BackColor = System.Drawing.Color.Transparent
        Me.RbtnName.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbtnName.ForeColor = System.Drawing.Color.Black
        Me.RbtnName.Location = New System.Drawing.Point(20, 27)
        Me.RbtnName.Name = "RbtnName"
        Me.RbtnName.Size = New System.Drawing.Size(60, 22)
        Me.RbtnName.TabIndex = 0
        Me.RbtnName.Text = "Nombre"
        Me.RbtnName.UseVisualStyleBackColor = False
        '
        'RbtnAll
        '
        Me.RbtnAll.AutoSize = True
        Me.RbtnAll.BackColor = System.Drawing.Color.Transparent
        Me.RbtnAll.Checked = True
        Me.RbtnAll.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbtnAll.ForeColor = System.Drawing.Color.Black
        Me.RbtnAll.Location = New System.Drawing.Point(20, 75)
        Me.RbtnAll.Name = "RbtnAll"
        Me.RbtnAll.Size = New System.Drawing.Size(71, 22)
        Me.RbtnAll.TabIndex = 1
        Me.RbtnAll.TabStop = True
        Me.RbtnAll.Text = "Ver Todos"
        Me.RbtnAll.UseVisualStyleBackColor = False
        '
        'GroupPanel1
        '
        Me.GroupPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.GroupPanel1.CanvasColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.PanelEx3)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel1.Location = New System.Drawing.Point(14, 232)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(200, 199)
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
        Me.GroupPanel1.TabIndex = 38
        Me.GroupPanel1.Text = "Filtrar"
        '
        'PanelEx3
        '
        Me.PanelEx3.AutoScroll = True
        Me.PanelEx3.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx3.Controls.Add(Me.ChBDateEnd)
        Me.PanelEx3.Controls.Add(Me.ChBDateInit)
        Me.PanelEx3.Controls.Add(Me.DinputEnd_2)
        Me.PanelEx3.Controls.Add(Me.DinputEnd_1)
        Me.PanelEx3.Controls.Add(Me.LabelX5)
        Me.PanelEx3.Controls.Add(Me.LabelX6)
        Me.PanelEx3.Controls.Add(Me.LabelX8)
        Me.PanelEx3.Controls.Add(Me.DinputInit_2)
        Me.PanelEx3.Controls.Add(Me.DinputInit_1)
        Me.PanelEx3.Controls.Add(Me.LabelX4)
        Me.PanelEx3.Controls.Add(Me.LabelX3)
        Me.PanelEx3.Controls.Add(Me.LabelX1)
        Me.PanelEx3.Controls.Add(Me.CmBEstado)
        Me.PanelEx3.Controls.Add(Me.LabelX7)
        Me.PanelEx3.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx3.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx3.Margin = New System.Windows.Forms.Padding(5)
        Me.PanelEx3.Name = "PanelEx3"
        Me.PanelEx3.ScrollBarAppearance = DevComponents.DotNetBar.eScrollBarAppearance.ApplicationScroll
        Me.PanelEx3.Size = New System.Drawing.Size(194, 174)
        Me.PanelEx3.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx3.Style.GradientAngle = 90
        Me.PanelEx3.TabIndex = 3
        '
        'ChBDateEnd
        '
        '
        '
        '
        Me.ChBDateEnd.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ChBDateEnd.CheckBoxPosition = DevComponents.DotNetBar.eCheckBoxPosition.Bottom
        Me.ChBDateEnd.CheckSignSize = New System.Drawing.Size(15, 15)
        Me.ChBDateEnd.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChBDateEnd.ForeColor = System.Drawing.Color.Black
        Me.ChBDateEnd.Location = New System.Drawing.Point(150, 129)
        Me.ChBDateEnd.Name = "ChBDateEnd"
        Me.ChBDateEnd.Size = New System.Drawing.Size(24, 23)
        Me.ChBDateEnd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ChBDateEnd.TabIndex = 23
        '
        'ChBDateInit
        '
        '
        '
        '
        Me.ChBDateInit.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ChBDateInit.CheckBoxPosition = DevComponents.DotNetBar.eCheckBoxPosition.Bottom
        Me.ChBDateInit.CheckSignSize = New System.Drawing.Size(15, 15)
        Me.ChBDateInit.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChBDateInit.ForeColor = System.Drawing.Color.Black
        Me.ChBDateInit.Location = New System.Drawing.Point(150, 43)
        Me.ChBDateInit.Name = "ChBDateInit"
        Me.ChBDateInit.Size = New System.Drawing.Size(24, 23)
        Me.ChBDateInit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ChBDateInit.TabIndex = 22
        '
        'DinputEnd_2
        '
        Me.DinputEnd_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.DinputEnd_2.CalendarFont = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DinputEnd_2.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DinputEnd_2.ForeColor = System.Drawing.Color.Black
        Me.DinputEnd_2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DinputEnd_2.Location = New System.Drawing.Point(45, 185)
        Me.DinputEnd_2.Name = "DinputEnd_2"
        Me.DinputEnd_2.Size = New System.Drawing.Size(130, 22)
        Me.DinputEnd_2.TabIndex = 21
        '
        'DinputEnd_1
        '
        Me.DinputEnd_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.DinputEnd_1.CalendarFont = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DinputEnd_1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DinputEnd_1.ForeColor = System.Drawing.Color.Black
        Me.DinputEnd_1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DinputEnd_1.Location = New System.Drawing.Point(45, 156)
        Me.DinputEnd_1.Name = "DinputEnd_1"
        Me.DinputEnd_1.Size = New System.Drawing.Size(130, 22)
        Me.DinputEnd_1.TabIndex = 20
        Me.DinputEnd_1.Value = New Date(2010, 2, 1, 0, 0, 0, 0)
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.ForeColor = System.Drawing.Color.Black
        Me.LabelX5.Location = New System.Drawing.Point(27, 184)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(23, 23)
        Me.LabelX5.TabIndex = 19
        Me.LabelX5.Text = "A"
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.ForeColor = System.Drawing.Color.Black
        Me.LabelX6.Location = New System.Drawing.Point(27, 155)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(23, 23)
        Me.LabelX6.TabIndex = 18
        Me.LabelX6.Text = "De"
        '
        'LabelX8
        '
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.ForeColor = System.Drawing.Color.Black
        Me.LabelX8.Location = New System.Drawing.Point(8, 129)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(104, 23)
        Me.LabelX8.TabIndex = 17
        Me.LabelX8.Text = "Fecha de Culminación"
        '
        'DinputInit_2
        '
        Me.DinputInit_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.DinputInit_2.CalendarFont = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DinputInit_2.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DinputInit_2.ForeColor = System.Drawing.Color.Black
        Me.DinputInit_2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DinputInit_2.Location = New System.Drawing.Point(45, 101)
        Me.DinputInit_2.Name = "DinputInit_2"
        Me.DinputInit_2.Size = New System.Drawing.Size(130, 22)
        Me.DinputInit_2.TabIndex = 16
        '
        'DinputInit_1
        '
        Me.DinputInit_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.DinputInit_1.CalendarFont = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DinputInit_1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DinputInit_1.ForeColor = System.Drawing.Color.Black
        Me.DinputInit_1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DinputInit_1.Location = New System.Drawing.Point(45, 72)
        Me.DinputInit_1.Name = "DinputInit_1"
        Me.DinputInit_1.Size = New System.Drawing.Size(130, 22)
        Me.DinputInit_1.TabIndex = 15
        Me.DinputInit_1.Value = New Date(2010, 1, 1, 0, 0, 0, 0)
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.ForeColor = System.Drawing.Color.Black
        Me.LabelX4.Location = New System.Drawing.Point(27, 100)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(23, 23)
        Me.LabelX4.TabIndex = 14
        Me.LabelX4.Text = "A"
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.ForeColor = System.Drawing.Color.Black
        Me.LabelX3.Location = New System.Drawing.Point(27, 71)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(23, 23)
        Me.LabelX3.TabIndex = 13
        Me.LabelX3.Text = "De"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(8, 45)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(81, 23)
        Me.LabelX1.TabIndex = 12
        Me.LabelX1.Text = "Fecha de Inicio"
        '
        'CmBEstado
        '
        Me.CmBEstado.DisplayMember = "Text"
        Me.CmBEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmBEstado.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmBEstado.FormattingEnabled = True
        Me.CmBEstado.ItemHeight = 16
        Me.CmBEstado.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem2, Me.ComboItem3})
        Me.CmBEstado.Location = New System.Drawing.Point(45, 13)
        Me.CmBEstado.Name = "CmBEstado"
        Me.CmBEstado.Size = New System.Drawing.Size(121, 22)
        Me.CmBEstado.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CmBEstado.TabIndex = 11
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "Indiferente"
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "Activo"
        '
        'ComboItem3
        '
        Me.ComboItem3.Text = "Innactivo"
        '
        'LabelX7
        '
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.ForeColor = System.Drawing.Color.Black
        Me.LabelX7.Location = New System.Drawing.Point(8, 13)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(33, 23)
        Me.LabelX7.TabIndex = 10
        Me.LabelX7.Text = "Estado"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.ForeColor = System.Drawing.Color.Black
        Me.LabelX2.Location = New System.Drawing.Point(12, 43)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(36, 23)
        Me.LabelX2.TabIndex = 15
        Me.LabelX2.Text = "Buscar"
        '
        'BtnSearch
        '
        Me.BtnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.BtnSearch.Image = CType(resources.GetObject("BtnSearch.Image"), System.Drawing.Image)
        Me.BtnSearch.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.BtnSearch.Location = New System.Drawing.Point(189, 44)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(25, 27)
        Me.BtnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnSearch.TabIndex = 14
        '
        'TxtBSearch
        '
        '
        '
        '
        Me.TxtBSearch.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TxtBSearch.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TxtBSearch.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TxtBSearch.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TxtBSearch.Border.Class = "TextBoxBorder"
        Me.TxtBSearch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtBSearch.DisabledBackColor = System.Drawing.Color.White
        Me.TxtBSearch.Location = New System.Drawing.Point(54, 46)
        Me.TxtBSearch.Name = "TxtBSearch"
        Me.TxtBSearch.PreventEnterBeep = True
        Me.TxtBSearch.Size = New System.Drawing.Size(129, 22)
        Me.TxtBSearch.TabIndex = 16
        '
        'BtnGenerarReport
        '
        Me.BtnGenerarReport.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnGenerarReport.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGenerarReport.Location = New System.Drawing.Point(836, 457)
        Me.BtnGenerarReport.Name = "BtnGenerarReport"
        Me.BtnGenerarReport.Size = New System.Drawing.Size(100, 23)
        Me.BtnGenerarReport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnGenerarReport.TabIndex = 55
        Me.BtnGenerarReport.Text = "Generar Reporte"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.PictureBox1.ForeColor = System.Drawing.Color.Black
        Me.PictureBox1.Image = Global.AppImelsa.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(265, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(119, 148)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 51
        Me.PictureBox1.TabStop = False
        '
        'BtnLoadTable
        '
        Me.BtnLoadTable.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnLoadTable.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.BtnLoadTable.FadeEffect = False
        Me.BtnLoadTable.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLoadTable.Image = Global.AppImelsa.My.Resources.Resources.Icp
        Me.BtnLoadTable.Location = New System.Drawing.Point(1003, 131)
        Me.BtnLoadTable.Name = "BtnLoadTable"
        Me.BtnLoadTable.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.BtnLoadTable.Size = New System.Drawing.Size(90, 29)
        Me.BtnLoadTable.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013
        Me.BtnLoadTable.TabIndex = 30
        Me.BtnLoadTable.Text = "Refrescar"
        Me.BtnLoadTable.TextColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        '
        'BtnNewEmployed
        '
        Me.BtnNewEmployed.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnNewEmployed.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.BtnNewEmployed.FadeEffect = False
        Me.BtnNewEmployed.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNewEmployed.Image = Global.AppImelsa.My.Resources.Resources.Ic
        Me.BtnNewEmployed.Location = New System.Drawing.Point(878, 131)
        Me.BtnNewEmployed.Name = "BtnNewEmployed"
        Me.BtnNewEmployed.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.BtnNewEmployed.Size = New System.Drawing.Size(107, 29)
        Me.BtnNewEmployed.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013
        Me.BtnNewEmployed.TabIndex = 22
        Me.BtnNewEmployed.Text = "Nuevo Proyecto"
        Me.BtnNewEmployed.TextColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        '
        'ProyectForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1123, 505)
        Me.Controls.Add(Me.BtnGenerarReport)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PanelEx2)
        Me.Controls.Add(Me.ReflectionLabel1)
        Me.Controls.Add(Me.ReflectionLabel2)
        Me.Controls.Add(Me.GridProyect)
        Me.Controls.Add(Me.BtnLoadTable)
        Me.Controls.Add(Me.BtnUpdateEmployed)
        Me.Controls.Add(Me.BtnDeleteEmployed)
        Me.Controls.Add(Me.BtnNewEmployed)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(5, 5)
        Me.Name = "ProyectForm"
        Me.Text = "MetroForm"
        Me.PanelEx2.ResumeLayout(False)
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel2.PerformLayout()
        Me.GroupPanel1.ResumeLayout(False)
        Me.PanelEx3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnLoadTable As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnUpdateEmployed As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnDeleteEmployed As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnNewEmployed As DevComponents.DotNetBar.ButtonX
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents GridProyect As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents ReflectionLabel1 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents ReflectionLabel2 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents RbtnIden As RadioButton
    Friend WithEvents RbtnCode As RadioButton
    Friend WithEvents RbtnName As RadioButton
    Friend WithEvents RbtnAll As RadioButton
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents PanelEx3 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents BtnSearch As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TxtBSearch As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents CmBEstado As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents DinputInit_2 As DateTimePicker
    Friend WithEvents DinputInit_1 As DateTimePicker
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents DinputEnd_2 As DateTimePicker
    Friend WithEvents DinputEnd_1 As DateTimePicker
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ChBDateInit As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents ChBDateEnd As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnGenerarReport As DevComponents.DotNetBar.ButtonX
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EmployedForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmployedForm))
        Dim Background1 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.BtnNewEmployed = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.RbtnIden = New System.Windows.Forms.RadioButton()
        Me.RbtnCode = New System.Windows.Forms.RadioButton()
        Me.RbtnName = New System.Windows.Forms.RadioButton()
        Me.RbtnAll = New System.Windows.Forms.RadioButton()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.PanelEx3 = New DevComponents.DotNetBar.PanelEx()
        Me.BtnUpdateTurno = New DevComponents.DotNetBar.ButtonX()
        Me.BtnUpdateCargo = New DevComponents.DotNetBar.ButtonX()
        Me.CmBTurno = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.CmBSexo = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.CmBCargo = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.RangeSlider1 = New DevComponents.DotNetBar.Controls.RangeSlider()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.BtnSearch = New DevComponents.DotNetBar.ButtonX()
        Me.TxtBSearch = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.GridEmployed = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.ReflectionLabel1 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.ReflectionLabel2 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.BtnUpdateEmployed = New DevComponents.DotNetBar.ButtonX()
        Me.BtnDeleteEmployed = New DevComponents.DotNetBar.ButtonX()
        Me.BtnRefresh = New DevComponents.DotNetBar.ButtonX()
        Me.SuperValidator1 = New DevComponents.DotNetBar.Validator.SuperValidator()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.PanelEx1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx2.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.PanelEx3.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.AutoSize = True
        Me.PanelEx1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PanelEx1.CanvasColor = System.Drawing.Color.WhiteSmoke
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.PictureBox1)
        Me.PanelEx1.Controls.Add(Me.ButtonX1)
        Me.PanelEx1.Controls.Add(Me.BtnNewEmployed)
        Me.PanelEx1.Controls.Add(Me.PanelEx2)
        Me.PanelEx1.Controls.Add(Me.GridEmployed)
        Me.PanelEx1.Controls.Add(Me.ReflectionLabel1)
        Me.PanelEx1.Controls.Add(Me.ReflectionLabel2)
        Me.PanelEx1.Controls.Add(Me.BtnUpdateEmployed)
        Me.PanelEx1.Controls.Add(Me.BtnDeleteEmployed)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.MarkupUsesStyleAlignment = True
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(1123, 505)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.Color = System.Drawing.Color.WhiteSmoke
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.ForeColor = System.Drawing.Color.Black
        Me.PictureBox1.Image = Global.AppImelsa.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(265, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(119, 136)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 50
        Me.PictureBox1.TabStop = False
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.ButtonX1.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX1.Image = Global.AppImelsa.My.Resources.Resources.ix
        Me.ButtonX1.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.ButtonX1.Location = New System.Drawing.Point(1003, 131)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(94, 33)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 46
        Me.ButtonX1.Text = "Refrescar"
        '
        'BtnNewEmployed
        '
        Me.BtnNewEmployed.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnNewEmployed.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.BtnNewEmployed.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNewEmployed.Image = Global.AppImelsa.My.Resources.Resources.Ic
        Me.BtnNewEmployed.Location = New System.Drawing.Point(878, 131)
        Me.BtnNewEmployed.Name = "BtnNewEmployed"
        Me.BtnNewEmployed.Size = New System.Drawing.Size(119, 33)
        Me.BtnNewEmployed.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnNewEmployed.TabIndex = 42
        Me.BtnNewEmployed.Text = "Nuevo Empleado"
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer))
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
        Me.PanelEx2.TabIndex = 38
        '
        'GroupPanel2
        '
        Me.GroupPanel2.BackColor = System.Drawing.Color.White
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.RbtnIden)
        Me.GroupPanel2.Controls.Add(Me.RbtnCode)
        Me.GroupPanel2.Controls.Add(Me.RbtnName)
        Me.GroupPanel2.Controls.Add(Me.RbtnAll)
        Me.GroupPanel2.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel2.Location = New System.Drawing.Point(12, 94)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(202, 132)
        '
        '
        '
        Me.GroupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel2.Style.BackColorGradientAngle = 90
        Me.GroupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
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
        Me.RbtnIden.ForeColor = System.Drawing.Color.Black
        Me.RbtnIden.Location = New System.Drawing.Point(20, 51)
        Me.RbtnIden.Name = "RbtnIden"
        Me.RbtnIden.Size = New System.Drawing.Size(54, 22)
        Me.RbtnIden.TabIndex = 3
        Me.RbtnIden.Text = "Cedula"
        Me.RbtnIden.UseVisualStyleBackColor = False
        '
        'RbtnCode
        '
        Me.RbtnCode.AutoSize = True
        Me.RbtnCode.BackColor = System.Drawing.Color.Transparent
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
        Me.GroupPanel1.BackColor = System.Drawing.Color.White
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.PanelEx3)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
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
        Me.PanelEx3.Controls.Add(Me.BtnUpdateTurno)
        Me.PanelEx3.Controls.Add(Me.BtnUpdateCargo)
        Me.PanelEx3.Controls.Add(Me.CmBTurno)
        Me.PanelEx3.Controls.Add(Me.LabelX9)
        Me.PanelEx3.Controls.Add(Me.CmBSexo)
        Me.PanelEx3.Controls.Add(Me.CmBCargo)
        Me.PanelEx3.Controls.Add(Me.LabelX8)
        Me.PanelEx3.Controls.Add(Me.LabelX7)
        Me.PanelEx3.Controls.Add(Me.LabelX3)
        Me.PanelEx3.Controls.Add(Me.RangeSlider1)
        Me.PanelEx3.Controls.Add(Me.LabelX1)
        Me.PanelEx3.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx3.Location = New System.Drawing.Point(0, 0)
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
        'BtnUpdateTurno
        '
        Me.BtnUpdateTurno.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnUpdateTurno.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.BtnUpdateTurno.Image = Global.AppImelsa.My.Resources.Resources.ix
        Me.BtnUpdateTurno.ImageFixedSize = New System.Drawing.Size(16, 16)
        Me.BtnUpdateTurno.Location = New System.Drawing.Point(166, 133)
        Me.BtnUpdateTurno.Name = "BtnUpdateTurno"
        Me.BtnUpdateTurno.Size = New System.Drawing.Size(25, 27)
        Me.BtnUpdateTurno.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnUpdateTurno.TabIndex = 17
        '
        'BtnUpdateCargo
        '
        Me.BtnUpdateCargo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnUpdateCargo.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.BtnUpdateCargo.Image = Global.AppImelsa.My.Resources.Resources.ix
        Me.BtnUpdateCargo.ImageFixedSize = New System.Drawing.Size(16, 16)
        Me.BtnUpdateCargo.Location = New System.Drawing.Point(166, 102)
        Me.BtnUpdateCargo.Name = "BtnUpdateCargo"
        Me.BtnUpdateCargo.Size = New System.Drawing.Size(25, 27)
        Me.BtnUpdateCargo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnUpdateCargo.TabIndex = 16
        '
        'CmBTurno
        '
        Me.CmBTurno.DisplayMember = "Text"
        Me.CmBTurno.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmBTurno.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmBTurno.FormattingEnabled = True
        Me.CmBTurno.ItemHeight = 16
        Me.CmBTurno.Location = New System.Drawing.Point(45, 135)
        Me.CmBTurno.Name = "CmBTurno"
        Me.CmBTurno.Size = New System.Drawing.Size(121, 22)
        Me.CmBTurno.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CmBTurno.TabIndex = 11
        '
        'LabelX9
        '
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.ForeColor = System.Drawing.Color.Black
        Me.LabelX9.Location = New System.Drawing.Point(8, 134)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(33, 23)
        Me.LabelX9.TabIndex = 10
        Me.LabelX9.Text = "Turno"
        '
        'CmBSexo
        '
        Me.CmBSexo.DisplayMember = "Text"
        Me.CmBSexo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmBSexo.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmBSexo.FormattingEnabled = True
        Me.CmBSexo.ItemHeight = 16
        Me.CmBSexo.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem2, Me.ComboItem3})
        Me.CmBSexo.Location = New System.Drawing.Point(45, 76)
        Me.CmBSexo.Name = "CmBSexo"
        Me.CmBSexo.Size = New System.Drawing.Size(121, 22)
        Me.CmBSexo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CmBSexo.TabIndex = 9
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "Indiferente"
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "Masculino"
        '
        'ComboItem3
        '
        Me.ComboItem3.Text = "Femenino"
        '
        'CmBCargo
        '
        Me.CmBCargo.DisplayMember = "Text"
        Me.CmBCargo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmBCargo.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmBCargo.FormattingEnabled = True
        Me.CmBCargo.ItemHeight = 16
        Me.CmBCargo.Location = New System.Drawing.Point(45, 105)
        Me.CmBCargo.Name = "CmBCargo"
        Me.CmBCargo.Size = New System.Drawing.Size(121, 22)
        Me.CmBCargo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CmBCargo.TabIndex = 8
        '
        'LabelX8
        '
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.ForeColor = System.Drawing.Color.Black
        Me.LabelX8.Location = New System.Drawing.Point(8, 105)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(33, 23)
        Me.LabelX8.TabIndex = 7
        Me.LabelX8.Text = "Cargo"
        '
        'LabelX7
        '
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.ForeColor = System.Drawing.Color.Black
        Me.LabelX7.Location = New System.Drawing.Point(8, 73)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(33, 23)
        Me.LabelX7.TabIndex = 3
        Me.LabelX7.Text = "Sexo"
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.ForeColor = System.Drawing.Color.Black
        Me.LabelX3.Location = New System.Drawing.Point(86, 13)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(102, 23)
        Me.LabelX3.TabIndex = 2
        Me.LabelX3.Text = "Min: - Max:"
        '
        'RangeSlider1
        '
        '
        '
        '
        Me.RangeSlider1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RangeSlider1.FocusCuesEnabled = False
        Me.RangeSlider1.Font = New System.Drawing.Font("Agency FB", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RangeSlider1.ForeColor = System.Drawing.Color.Black
        Me.RangeSlider1.Location = New System.Drawing.Point(23, 42)
        Me.RangeSlider1.Maximum = 60
        Me.RangeSlider1.Minimum = 18
        Me.RangeSlider1.Name = "RangeSlider1"
        Me.RangeSlider1.RangeTooltipFormat = "Min: {0} - Max: {1}"
        Me.RangeSlider1.Size = New System.Drawing.Size(148, 25)
        Me.RangeSlider1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013
        Me.RangeSlider1.TabIndex = 0
        Me.RangeSlider1.Value = New DevComponents.DotNetBar.RangeValue(18, 60)
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(8, 13)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(33, 23)
        Me.LabelX1.TabIndex = 1
        Me.LabelX1.Text = "Edad"
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
        Me.TxtBSearch.Font = New System.Drawing.Font("Agency FB", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Highlighter1.SetHighlightOnFocus(Me.TxtBSearch, True)
        Me.TxtBSearch.Location = New System.Drawing.Point(54, 46)
        Me.TxtBSearch.Name = "TxtBSearch"
        Me.TxtBSearch.PreventEnterBeep = True
        Me.TxtBSearch.Size = New System.Drawing.Size(129, 23)
        Me.TxtBSearch.TabIndex = 16
        '
        'GridEmployed
        '
        Me.GridEmployed.BackColor = System.Drawing.Color.White
        Me.GridEmployed.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
        Me.GridEmployed.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridEmployed.ForeColor = System.Drawing.Color.Black
        Me.GridEmployed.Location = New System.Drawing.Point(265, 170)
        Me.GridEmployed.Name = "GridEmployed"
        '
        '
        '
        Me.GridEmployed.PrimaryGrid.AllowEdit = False
        '
        '
        '
        Me.GridEmployed.PrimaryGrid.Caption.BackgroundImage = Global.AppImelsa.My.Resources.Resources.Anadir
        Background1.Color1 = System.Drawing.Color.DodgerBlue
        Background1.Color2 = System.Drawing.Color.DodgerBlue
        Me.GridEmployed.PrimaryGrid.DefaultVisualStyles.AlternateRowCellStyles.Default.Background = Background1
        Me.GridEmployed.PrimaryGrid.InitialSelection = DevComponents.DotNetBar.SuperGrid.RelativeSelection.Row
        Me.GridEmployed.PrimaryGrid.MultiSelect = False
        Me.GridEmployed.PrimaryGrid.PrimaryColumnIndex = 2236962
        Me.GridEmployed.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row
        Me.GridEmployed.Size = New System.Drawing.Size(832, 273)
        Me.GridEmployed.TabIndex = 37
        Me.GridEmployed.Text = "SuperGridControl1"
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
        Me.ReflectionLabel1.Location = New System.Drawing.Point(722, 12)
        Me.ReflectionLabel1.Name = "ReflectionLabel1"
        Me.ReflectionLabel1.Size = New System.Drawing.Size(376, 35)
        Me.ReflectionLabel1.TabIndex = 34
        Me.ReflectionLabel1.Text = "<b><font size=""+6""><i>Construcciones Electronicas de Nicaragua  .SA</i><font colo" &
    "r=""#222222""></font><font color=""#003333""></font></font></b>"
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
        Me.ReflectionLabel2.Location = New System.Drawing.Point(884, 53)
        Me.ReflectionLabel2.Name = "ReflectionLabel2"
        Me.ReflectionLabel2.Size = New System.Drawing.Size(213, 23)
        Me.ReflectionLabel2.TabIndex = 35
        Me.ReflectionLabel2.Text = "<b><font size=""+6""><i>Registro y</i><font color=""#222222""> Control </font><font c" &
    "olor=""#003333"">de Empleados</font></font></b>"
        '
        'BtnUpdateEmployed
        '
        Me.BtnUpdateEmployed.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnUpdateEmployed.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnUpdateEmployed.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdateEmployed.Location = New System.Drawing.Point(942, 457)
        Me.BtnUpdateEmployed.Name = "BtnUpdateEmployed"
        Me.BtnUpdateEmployed.Size = New System.Drawing.Size(75, 23)
        Me.BtnUpdateEmployed.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnUpdateEmployed.TabIndex = 20
        Me.BtnUpdateEmployed.Text = "Ver Pefil"
        '
        'BtnDeleteEmployed
        '
        Me.BtnDeleteEmployed.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnDeleteEmployed.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnDeleteEmployed.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeleteEmployed.Location = New System.Drawing.Point(1023, 457)
        Me.BtnDeleteEmployed.Name = "BtnDeleteEmployed"
        Me.BtnDeleteEmployed.Size = New System.Drawing.Size(75, 23)
        Me.BtnDeleteEmployed.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnDeleteEmployed.TabIndex = 19
        Me.BtnDeleteEmployed.Text = "Eliminar"
        '
        'BtnRefresh
        '
        Me.BtnRefresh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnRefresh.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.BtnRefresh.FadeEffect = False
        Me.BtnRefresh.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRefresh.Location = New System.Drawing.Point(344, 103)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.BtnRefresh.Size = New System.Drawing.Size(90, 29)
        Me.BtnRefresh.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013
        Me.BtnRefresh.TabIndex = 21
        Me.BtnRefresh.Text = "Refrescar"
        Me.BtnRefresh.TextColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
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
        'EmployedForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1123, 505)
        Me.Controls.Add(Me.PanelEx1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(5, 5)
        Me.Name = "EmployedForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Registro de Empleados / IMELSA"
        Me.PanelEx1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx2.ResumeLayout(False)
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel2.PerformLayout()
        Me.GroupPanel1.ResumeLayout(False)
        Me.PanelEx3.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents TxtBSearch As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents BtnSearch As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnDeleteEmployed As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnRefresh As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ReflectionLabel1 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents ReflectionLabel2 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
    Friend WithEvents SuperValidator1 As DevComponents.DotNetBar.Validator.SuperValidator
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents GridEmployed As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents RbtnAll As RadioButton
    Friend WithEvents RbtnName As RadioButton
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents RbtnIden As RadioButton
    Friend WithEvents RbtnCode As RadioButton
    Friend WithEvents BtnNewEmployed As DevComponents.DotNetBar.ButtonX
    Friend WithEvents RangeSlider1 As DevComponents.DotNetBar.Controls.RangeSlider
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnUpdateEmployed As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents PanelEx3 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents CmBSexo As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents CmBCargo As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents CmBTurno As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents BtnUpdateTurno As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnUpdateCargo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents PictureBox1 As PictureBox
End Class

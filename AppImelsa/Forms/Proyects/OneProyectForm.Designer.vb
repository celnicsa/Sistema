<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OneProyectForm
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
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.SideNav1 = New DevComponents.DotNetBar.Controls.SideNav()
        Me.SideNavPanel1 = New DevComponents.DotNetBar.Controls.SideNavPanel()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX()
        Me.TxtBDesc = New DevComponents.DotNetBar.Controls.RichTextBoxEx()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.TxtBPresupuesto = New DevComponents.Editors.DoubleInput()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.ChBState = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.TxtBName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TxtBCode = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.TxtBClient = New DevComponents.DotNetBar.LabelX()
        Me.TxtBAddres = New DevComponents.DotNetBar.Controls.RichTextBoxEx()
        Me.DateInputInit = New System.Windows.Forms.DateTimePicker()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.DateInputEnd = New System.Windows.Forms.DateTimePicker()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.Bar1 = New DevComponents.DotNetBar.Bar()
        Me.ProgressItem = New DevComponents.DotNetBar.CircularProgressItem()
        Me.LabelProcess = New DevComponents.DotNetBar.LabelItem()
        Me.BtnSave = New DevComponents.DotNetBar.ButtonX()
        Me.BtnAccept = New DevComponents.DotNetBar.ButtonX()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SideNavItem1 = New DevComponents.DotNetBar.Controls.SideNavItem()
        Me.Separator1 = New DevComponents.DotNetBar.Separator()
        Me.SideNavItem2 = New DevComponents.DotNetBar.Controls.SideNavItem()
        Me.SideNav1.SuspendLayout()
        Me.SideNavPanel1.SuspendLayout()
        Me.PanelEx1.SuspendLayout()
        Me.PanelEx2.SuspendLayout()
        CType(Me.TxtBPresupuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2010Blue
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.WhiteSmoke, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer)))
        '
        'SideNav1
        '
        Me.SideNav1.Controls.Add(Me.SideNavPanel1)
        Me.SideNav1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SideNav1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SideNav1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SideNavItem1, Me.Separator1, Me.SideNavItem2})
        Me.SideNav1.Location = New System.Drawing.Point(0, 0)
        Me.SideNav1.Name = "SideNav1"
        Me.SideNav1.Padding = New System.Windows.Forms.Padding(1)
        Me.SideNav1.Size = New System.Drawing.Size(775, 391)
        Me.SideNav1.TabIndex = 0
        Me.SideNav1.Text = "SideNav1"
        '
        'SideNavPanel1
        '
        Me.SideNavPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.SideNavPanel1.Controls.Add(Me.PanelEx1)
        Me.SideNavPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SideNavPanel1.ForeColor = System.Drawing.Color.Black
        Me.SideNavPanel1.Location = New System.Drawing.Point(133, 36)
        Me.SideNavPanel1.Name = "SideNavPanel1"
        Me.SideNavPanel1.Size = New System.Drawing.Size(637, 354)
        Me.SideNavPanel1.TabIndex = 2
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.PanelEx2)
        Me.PanelEx1.Controls.Add(Me.Bar1)
        Me.PanelEx1.Controls.Add(Me.BtnSave)
        Me.PanelEx1.Controls.Add(Me.BtnAccept)
        Me.PanelEx1.Controls.Add(Me.PictureBox1)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(637, 354)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.Color = System.Drawing.Color.WhiteSmoke
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'PanelEx2
        '
        Me.PanelEx2.AutoScroll = True
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.LabelX10)
        Me.PanelEx2.Controls.Add(Me.TxtBDesc)
        Me.PanelEx2.Controls.Add(Me.LabelX9)
        Me.PanelEx2.Controls.Add(Me.TxtBPresupuesto)
        Me.PanelEx2.Controls.Add(Me.LabelX1)
        Me.PanelEx2.Controls.Add(Me.LabelX8)
        Me.PanelEx2.Controls.Add(Me.ChBState)
        Me.PanelEx2.Controls.Add(Me.LabelX2)
        Me.PanelEx2.Controls.Add(Me.TxtBName)
        Me.PanelEx2.Controls.Add(Me.TxtBCode)
        Me.PanelEx2.Controls.Add(Me.LabelX4)
        Me.PanelEx2.Controls.Add(Me.LabelX7)
        Me.PanelEx2.Controls.Add(Me.TxtBClient)
        Me.PanelEx2.Controls.Add(Me.TxtBAddres)
        Me.PanelEx2.Controls.Add(Me.DateInputInit)
        Me.PanelEx2.Controls.Add(Me.LabelX6)
        Me.PanelEx2.Controls.Add(Me.DateInputEnd)
        Me.PanelEx2.Controls.Add(Me.LabelX5)
        Me.PanelEx2.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx2.Location = New System.Drawing.Point(15, 16)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.ScrollBarAppearance = DevComponents.DotNetBar.eScrollBarAppearance.ApplicationScroll
        Me.PanelEx2.Size = New System.Drawing.Size(409, 289)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.Color = System.Drawing.Color.WhiteSmoke
        Me.PanelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 225
        '
        'LabelX10
        '
        Me.LabelX10.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX10.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX10.ForeColor = System.Drawing.Color.Black
        Me.LabelX10.Location = New System.Drawing.Point(11, 320)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.Size = New System.Drawing.Size(71, 14)
        Me.LabelX10.TabIndex = 228
        Me.LabelX10.Text = "Descripcion"
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
        Me.TxtBDesc.Location = New System.Drawing.Point(100, 320)
        Me.TxtBDesc.Name = "TxtBDesc"
        Me.TxtBDesc.Rtf = "{\rtf1\ansi\ansicpg1252\deff0\deflang19466{\fonttbl{\f0\fnil\fcharset0 Arial Narr" &
    "ow;}}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "\viewkind4\uc1\pard\f0\fs20\par" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.TxtBDesc.Size = New System.Drawing.Size(202, 43)
        Me.TxtBDesc.TabIndex = 229
        '
        'LabelX9
        '
        Me.LabelX9.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX9.ForeColor = System.Drawing.Color.Black
        Me.LabelX9.Location = New System.Drawing.Point(103, 365)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(116, 23)
        Me.LabelX9.TabIndex = 227
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
        Me.TxtBPresupuesto.Increment = 1.0R
        Me.TxtBPresupuesto.Location = New System.Drawing.Point(103, 137)
        Me.TxtBPresupuesto.Name = "TxtBPresupuesto"
        Me.TxtBPresupuesto.ShowUpDown = True
        Me.TxtBPresupuesto.Size = New System.Drawing.Size(107, 22)
        Me.TxtBPresupuesto.TabIndex = 226
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
        Me.LabelX1.Location = New System.Drawing.Point(14, 17)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(71, 23)
        Me.LabelX1.TabIndex = 209
        Me.LabelX1.Text = "Codigo"
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
        Me.LabelX8.Location = New System.Drawing.Point(11, 137)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(71, 23)
        Me.LabelX8.TabIndex = 225
        Me.LabelX8.Text = "Presupuesto"
        '
        'ChBState
        '
        '
        '
        '
        Me.ChBState.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ChBState.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChBState.ForeColor = System.Drawing.Color.Black
        Me.ChBState.Location = New System.Drawing.Point(286, 95)
        Me.ChBState.Name = "ChBState"
        Me.ChBState.Size = New System.Drawing.Size(62, 23)
        Me.ChBState.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ChBState.TabIndex = 224
        Me.ChBState.Text = "Activo"
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
        Me.LabelX2.Location = New System.Drawing.Point(14, 93)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(83, 23)
        Me.LabelX2.TabIndex = 210
        Me.LabelX2.Text = "Nombre / Titulo"
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
        Me.TxtBName.Location = New System.Drawing.Point(103, 96)
        Me.TxtBName.Name = "TxtBName"
        Me.TxtBName.PreventEnterBeep = True
        Me.TxtBName.Size = New System.Drawing.Size(177, 22)
        Me.TxtBName.TabIndex = 211
        '
        'TxtBCode
        '
        Me.TxtBCode.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.TxtBCode.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtBCode.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBCode.ForeColor = System.Drawing.Color.Black
        Me.TxtBCode.Location = New System.Drawing.Point(91, 17)
        Me.TxtBCode.Name = "TxtBCode"
        Me.TxtBCode.Size = New System.Drawing.Size(116, 23)
        Me.TxtBCode.TabIndex = 212
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
        Me.LabelX4.Location = New System.Drawing.Point(14, 54)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(71, 23)
        Me.LabelX4.TabIndex = 213
        Me.LabelX4.Text = "Cliente"
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
        Me.LabelX7.Location = New System.Drawing.Point(11, 264)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(71, 14)
        Me.LabelX7.TabIndex = 219
        Me.LabelX7.Text = "Ubicacion"
        '
        'TxtBClient
        '
        Me.TxtBClient.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.TxtBClient.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtBClient.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBClient.ForeColor = System.Drawing.Color.Black
        Me.TxtBClient.Location = New System.Drawing.Point(91, 54)
        Me.TxtBClient.Name = "TxtBClient"
        Me.TxtBClient.Size = New System.Drawing.Size(116, 23)
        Me.TxtBClient.TabIndex = 214
        '
        'TxtBAddres
        '
        Me.TxtBAddres.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TxtBAddres.BackgroundStyle.Class = "RichTextBoxBorder"
        Me.TxtBAddres.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtBAddres.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBAddres.ForeColor = System.Drawing.Color.Black
        Me.TxtBAddres.Location = New System.Drawing.Point(100, 264)
        Me.TxtBAddres.Name = "TxtBAddres"
        Me.TxtBAddres.Rtf = "{\rtf1\ansi\ansicpg1252\deff0\deflang19466{\fonttbl{\f0\fnil\fcharset0 Arial Narr" &
    "ow;}}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "\viewkind4\uc1\pard\f0\fs20\par" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.TxtBAddres.Size = New System.Drawing.Size(202, 43)
        Me.TxtBAddres.TabIndex = 220
        '
        'DateInputInit
        '
        Me.DateInputInit.BackColor = System.Drawing.Color.White
        Me.DateInputInit.ForeColor = System.Drawing.Color.Black
        Me.DateInputInit.Location = New System.Drawing.Point(100, 181)
        Me.DateInputInit.Name = "DateInputInit"
        Me.DateInputInit.Size = New System.Drawing.Size(200, 22)
        Me.DateInputInit.TabIndex = 215
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
        Me.LabelX6.Location = New System.Drawing.Point(11, 218)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(83, 23)
        Me.LabelX6.TabIndex = 218
        Me.LabelX6.Text = "F. Culminacion"
        '
        'DateInputEnd
        '
        Me.DateInputEnd.BackColor = System.Drawing.Color.White
        Me.DateInputEnd.ForeColor = System.Drawing.Color.Black
        Me.DateInputEnd.Location = New System.Drawing.Point(100, 218)
        Me.DateInputEnd.Name = "DateInputEnd"
        Me.DateInputEnd.Size = New System.Drawing.Size(200, 22)
        Me.DateInputEnd.TabIndex = 216
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
        Me.LabelX5.Location = New System.Drawing.Point(11, 181)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(71, 23)
        Me.LabelX5.TabIndex = 217
        Me.LabelX5.Text = "F. de Inicio"
        '
        'Bar1
        '
        Me.Bar1.AccessibleDescription = "Bar1 (Bar1)"
        Me.Bar1.AccessibleName = "Bar1"
        Me.Bar1.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me.Bar1.AntiAlias = True
        Me.Bar1.BarType = DevComponents.DotNetBar.eBarType.StatusBar
        Me.Bar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Bar1.DockSide = DevComponents.DotNetBar.eDockSide.Document
        Me.Bar1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bar1.ImageSize = DevComponents.DotNetBar.eBarImageSize.Medium
        Me.Bar1.IsMaximized = False
        Me.Bar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ProgressItem, Me.LabelProcess})
        Me.Bar1.Location = New System.Drawing.Point(0, 326)
        Me.Bar1.Name = "Bar1"
        Me.Bar1.Size = New System.Drawing.Size(637, 28)
        Me.Bar1.Stretch = True
        Me.Bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bar1.TabIndex = 223
        Me.Bar1.TabStop = False
        Me.Bar1.Text = "Bar1"
        '
        'ProgressItem
        '
        Me.ProgressItem.Name = "ProgressItem"
        Me.ProgressItem.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Spoke
        Me.ProgressItem.ProgressColor = System.Drawing.Color.DarkOrange
        '
        'LabelProcess
        '
        Me.LabelProcess.Name = "LabelProcess"
        Me.LabelProcess.Text = "Esperando"
        '
        'BtnSave
        '
        Me.BtnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnSave.Location = New System.Drawing.Point(465, 282)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 23)
        Me.BtnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnSave.TabIndex = 222
        Me.BtnSave.Text = "Guardar"
        '
        'BtnAccept
        '
        Me.BtnAccept.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnAccept.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnAccept.Location = New System.Drawing.Point(546, 282)
        Me.BtnAccept.Name = "BtnAccept"
        Me.BtnAccept.Size = New System.Drawing.Size(75, 23)
        Me.BtnAccept.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnAccept.TabIndex = 221
        Me.BtnAccept.Text = "Aceptar"
        '
        'PictureBox1
        '
        Me.PictureBox1.ForeColor = System.Drawing.Color.Black
        Me.PictureBox1.Image = Global.AppImelsa.My.Resources.Resources.LogoIme
        Me.PictureBox1.Location = New System.Drawing.Point(480, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 125)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 44
        Me.PictureBox1.TabStop = False
        '
        'SideNavItem1
        '
        Me.SideNavItem1.IsSystemMenu = True
        Me.SideNavItem1.Name = "SideNavItem1"
        Me.SideNavItem1.Symbol = ""
        Me.SideNavItem1.Text = "Perfil de Proyecto"
        '
        'Separator1
        '
        Me.Separator1.FixedSize = New System.Drawing.Size(3, 1)
        Me.Separator1.Name = "Separator1"
        Me.Separator1.Padding.Bottom = 2
        Me.Separator1.Padding.Left = 6
        Me.Separator1.Padding.Right = 6
        Me.Separator1.Padding.Top = 2
        Me.Separator1.SeparatorOrientation = DevComponents.DotNetBar.eDesignMarkerOrientation.Vertical
        '
        'SideNavItem2
        '
        Me.SideNavItem2.Checked = True
        Me.SideNavItem2.Name = "SideNavItem2"
        Me.SideNavItem2.Panel = Me.SideNavPanel1
        Me.SideNavItem2.Symbol = ""
        Me.SideNavItem2.Text = "Datos Generales"
        '
        'OneProyectForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(775, 391)
        Me.Controls.Add(Me.SideNav1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "OneProyectForm"
        Me.Text = "Perfil de Proyecto"
        Me.SideNav1.ResumeLayout(False)
        Me.SideNav1.PerformLayout()
        Me.SideNavPanel1.ResumeLayout(False)
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx2.ResumeLayout(False)
        CType(Me.TxtBPresupuesto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents SideNav1 As DevComponents.DotNetBar.Controls.SideNav
    Friend WithEvents SideNavPanel1 As DevComponents.DotNetBar.Controls.SideNavPanel
    Private WithEvents SideNavItem1 As DevComponents.DotNetBar.Controls.SideNavItem
    Friend WithEvents Separator1 As DevComponents.DotNetBar.Separator
    Private WithEvents SideNavItem2 As DevComponents.DotNetBar.Controls.SideNavItem
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TxtBCode As DevComponents.DotNetBar.LabelX
    Friend WithEvents TxtBName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TxtBClient As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents DateInputEnd As DateTimePicker
    Friend WithEvents DateInputInit As DateTimePicker
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TxtBAddres As DevComponents.DotNetBar.Controls.RichTextBoxEx
    Friend WithEvents BtnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnAccept As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Bar1 As DevComponents.DotNetBar.Bar
    Friend WithEvents ProgressItem As DevComponents.DotNetBar.CircularProgressItem
    Friend WithEvents LabelProcess As DevComponents.DotNetBar.LabelItem
    Friend WithEvents ChBState As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TxtBPresupuesto As DevComponents.Editors.DoubleInput
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TxtBDesc As DevComponents.DotNetBar.Controls.RichTextBoxEx
End Class

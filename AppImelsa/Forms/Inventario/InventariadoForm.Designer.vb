<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InventariadoForm
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
        Dim Background1 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InventariadoForm))
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ReflectionLabel1 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.ReflectionLabel2 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.BtnLoadTable = New DevComponents.DotNetBar.ButtonX()
        Me.GridArticulo = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonX()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextCodeArt = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TextStock = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TextDesc = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TextName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.BtnInsertArticulo = New DevComponents.DotNetBar.ButtonX()
        Me.TextCodeCat = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.BtnReportCaller = New DevComponents.DotNetBar.ButtonX()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.ButtonX2.FadeEffect = False
        Me.ButtonX2.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX2.Image = Global.AppImelsa.My.Resources.Resources.Icp
        Me.ButtonX2.Location = New System.Drawing.Point(147, 47)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.ButtonX2.Size = New System.Drawing.Size(78, 29)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013
        Me.ButtonX2.TabIndex = 62
        Me.ButtonX2.Text = "Refrescar"
        Me.ButtonX2.TextColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.ButtonX1.FadeEffect = False
        Me.ButtonX1.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX1.Image = Global.AppImelsa.My.Resources.Resources.look
        Me.ButtonX1.Location = New System.Drawing.Point(147, 12)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.ButtonX1.Size = New System.Drawing.Size(107, 29)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013
        Me.ButtonX1.TabIndex = 61
        Me.ButtonX1.Text = "Ver Categorias"
        Me.ButtonX1.TextColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.ForeColor = System.Drawing.Color.Black
        Me.PictureBox1.Image = Global.AppImelsa.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(22, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(119, 148)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 60
        Me.PictureBox1.TabStop = False
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
        Me.ReflectionLabel1.Location = New System.Drawing.Point(341, 12)
        Me.ReflectionLabel1.Name = "ReflectionLabel1"
        Me.ReflectionLabel1.Size = New System.Drawing.Size(364, 35)
        Me.ReflectionLabel1.TabIndex = 57
        Me.ReflectionLabel1.Text = "<b><font size=""+6""><i>Construcciones Electricas de Nicaragua SA.</i><font color=""" &
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
        Me.ReflectionLabel2.Location = New System.Drawing.Point(341, 72)
        Me.ReflectionLabel2.Name = "ReflectionLabel2"
        Me.ReflectionLabel2.Size = New System.Drawing.Size(186, 23)
        Me.ReflectionLabel2.TabIndex = 59
        Me.ReflectionLabel2.Text = "<b><font size=""+6""><i></i><font color=""#222222""> Inventariado de Materiales </fon" &
    "t><font color=""#003333""></font></font></b>"
        '
        'BtnLoadTable
        '
        Me.BtnLoadTable.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnLoadTable.BackColor = System.Drawing.Color.Transparent
        Me.BtnLoadTable.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.BtnLoadTable.FadeEffect = False
        Me.BtnLoadTable.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLoadTable.Image = Global.AppImelsa.My.Resources.Resources.elimin1
        Me.BtnLoadTable.Location = New System.Drawing.Point(147, 82)
        Me.BtnLoadTable.Name = "BtnLoadTable"
        Me.BtnLoadTable.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.BtnLoadTable.Size = New System.Drawing.Size(116, 29)
        Me.BtnLoadTable.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013
        Me.BtnLoadTable.TabIndex = 58
        Me.BtnLoadTable.Text = "Eliminar Articulo"
        Me.BtnLoadTable.TextColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        '
        'GridArticulo
        '
        Me.GridArticulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.GridArticulo.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
        Me.GridArticulo.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridArticulo.ForeColor = System.Drawing.Color.Black
        Me.GridArticulo.Location = New System.Drawing.Point(341, 210)
        Me.GridArticulo.Name = "GridArticulo"
        '
        '
        '
        Me.GridArticulo.PrimaryGrid.AllowEdit = False
        '
        '
        '
        Me.GridArticulo.PrimaryGrid.Caption.BackgroundImage = Global.AppImelsa.My.Resources.Resources.Anadir
        Background1.Color1 = System.Drawing.Color.DodgerBlue
        Background1.Color2 = System.Drawing.Color.DodgerBlue
        Me.GridArticulo.PrimaryGrid.DefaultVisualStyles.AlternateRowCellStyles.Default.Background = Background1
        Me.GridArticulo.PrimaryGrid.InitialSelection = DevComponents.DotNetBar.SuperGrid.RelativeSelection.Row
        Me.GridArticulo.PrimaryGrid.MultiSelect = False
        Me.GridArticulo.PrimaryGrid.PrimaryColumnIndex = 2236962
        Me.GridArticulo.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row
        Me.GridArticulo.Size = New System.Drawing.Size(752, 273)
        Me.GridArticulo.TabIndex = 55
        Me.GridArticulo.Text = "SuperGridControl1"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.GroupPanel1.CanvasColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.ButtonX3)
        Me.GroupPanel1.Controls.Add(Me.ComboBox1)
        Me.GroupPanel1.Controls.Add(Me.TextCodeArt)
        Me.GroupPanel1.Controls.Add(Me.TextStock)
        Me.GroupPanel1.Controls.Add(Me.TextDesc)
        Me.GroupPanel1.Controls.Add(Me.TextName)
        Me.GroupPanel1.Controls.Add(Me.LabelX6)
        Me.GroupPanel1.Controls.Add(Me.LabelX5)
        Me.GroupPanel1.Controls.Add(Me.LabelX4)
        Me.GroupPanel1.Controls.Add(Me.LabelX3)
        Me.GroupPanel1.Controls.Add(Me.LabelX1)
        Me.GroupPanel1.Controls.Add(Me.LabelX2)
        Me.GroupPanel1.Controls.Add(Me.BtnInsertArticulo)
        Me.GroupPanel1.Controls.Add(Me.TextCodeCat)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel1.Location = New System.Drawing.Point(12, 175)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(307, 308)
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
        Me.GroupPanel1.TabIndex = 63
        Me.GroupPanel1.Text = "Agregar Nuevo Articulo"
        '
        'ButtonX3
        '
        Me.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX3.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX3.Location = New System.Drawing.Point(171, 225)
        Me.ButtonX3.Name = "ButtonX3"
        Me.ButtonX3.Size = New System.Drawing.Size(112, 34)
        Me.ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX3.TabIndex = 175
        Me.ButtonX3.Text = "Modificar"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.ComboBox1.ForeColor = System.Drawing.Color.Black
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(117, 85)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(166, 28)
        Me.ComboBox1.TabIndex = 174
        '
        'TextCodeArt
        '
        Me.TextCodeArt.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TextCodeArt.Border.Class = "TextBoxBorder"
        Me.TextCodeArt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextCodeArt.DisabledBackColor = System.Drawing.Color.White
        Me.TextCodeArt.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextCodeArt.ForeColor = System.Drawing.Color.Black
        Me.TextCodeArt.Location = New System.Drawing.Point(117, 22)
        Me.TextCodeArt.MaxLength = 85
        Me.TextCodeArt.Name = "TextCodeArt"
        Me.TextCodeArt.PreventEnterBeep = True
        Me.TextCodeArt.Size = New System.Drawing.Size(166, 22)
        Me.TextCodeArt.TabIndex = 27
        '
        'TextStock
        '
        Me.TextStock.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TextStock.Border.Class = "TextBoxBorder"
        Me.TextStock.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextStock.DisabledBackColor = System.Drawing.Color.White
        Me.TextStock.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextStock.ForeColor = System.Drawing.Color.Black
        Me.TextStock.Location = New System.Drawing.Point(117, 177)
        Me.TextStock.MaxLength = 85
        Me.TextStock.Name = "TextStock"
        Me.TextStock.PreventEnterBeep = True
        Me.TextStock.Size = New System.Drawing.Size(166, 22)
        Me.TextStock.TabIndex = 26
        '
        'TextDesc
        '
        Me.TextDesc.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TextDesc.Border.Class = "TextBoxBorder"
        Me.TextDesc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextDesc.DisabledBackColor = System.Drawing.Color.White
        Me.TextDesc.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextDesc.ForeColor = System.Drawing.Color.Black
        Me.TextDesc.Location = New System.Drawing.Point(117, 149)
        Me.TextDesc.MaxLength = 85
        Me.TextDesc.Name = "TextDesc"
        Me.TextDesc.PreventEnterBeep = True
        Me.TextDesc.Size = New System.Drawing.Size(166, 22)
        Me.TextDesc.TabIndex = 25
        '
        'TextName
        '
        Me.TextName.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TextName.Border.Class = "TextBoxBorder"
        Me.TextName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextName.DisabledBackColor = System.Drawing.Color.White
        Me.TextName.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextName.ForeColor = System.Drawing.Color.Black
        Me.TextName.Location = New System.Drawing.Point(117, 120)
        Me.TextName.MaxLength = 85
        Me.TextName.Name = "TextName"
        Me.TextName.PreventEnterBeep = True
        Me.TextName.Size = New System.Drawing.Size(166, 22)
        Me.TextName.TabIndex = 24
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
        Me.LabelX6.Location = New System.Drawing.Point(7, 177)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(112, 23)
        Me.LabelX6.TabIndex = 22
        Me.LabelX6.Text = "Stock"
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
        Me.LabelX5.Location = New System.Drawing.Point(7, 148)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(112, 23)
        Me.LabelX5.TabIndex = 20
        Me.LabelX5.Text = "Descripcion"
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
        Me.LabelX4.Location = New System.Drawing.Point(7, 117)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(112, 23)
        Me.LabelX4.TabIndex = 18
        Me.LabelX4.Text = "Nombre de articulo"
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
        Me.LabelX3.Location = New System.Drawing.Point(7, 86)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(112, 23)
        Me.LabelX3.TabIndex = 16
        Me.LabelX3.Text = "Codigo de Proyecto"
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
        Me.LabelX1.Location = New System.Drawing.Point(7, 19)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(104, 23)
        Me.LabelX1.TabIndex = 11
        Me.LabelX1.Text = "Codigo de Articulo"
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
        Me.LabelX2.Location = New System.Drawing.Point(7, 50)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(104, 23)
        Me.LabelX2.TabIndex = 13
        Me.LabelX2.Text = "Codigo de Categoria"
        '
        'BtnInsertArticulo
        '
        Me.BtnInsertArticulo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnInsertArticulo.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInsertArticulo.Location = New System.Drawing.Point(7, 225)
        Me.BtnInsertArticulo.Name = "BtnInsertArticulo"
        Me.BtnInsertArticulo.Size = New System.Drawing.Size(112, 34)
        Me.BtnInsertArticulo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnInsertArticulo.TabIndex = 15
        Me.BtnInsertArticulo.Text = "Agregar"
        '
        'TextCodeCat
        '
        Me.TextCodeCat.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TextCodeCat.Border.Class = "TextBoxBorder"
        Me.TextCodeCat.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextCodeCat.DisabledBackColor = System.Drawing.Color.White
        Me.TextCodeCat.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextCodeCat.ForeColor = System.Drawing.Color.Black
        Me.TextCodeCat.Location = New System.Drawing.Point(117, 54)
        Me.TextCodeCat.MaxLength = 85
        Me.TextCodeCat.Name = "TextCodeCat"
        Me.TextCodeCat.PreventEnterBeep = True
        Me.TextCodeCat.Size = New System.Drawing.Size(166, 22)
        Me.TextCodeCat.TabIndex = 14
        '
        'BtnReportCaller
        '
        Me.BtnReportCaller.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnReportCaller.BackColor = System.Drawing.Color.Transparent
        Me.BtnReportCaller.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.BtnReportCaller.FadeEffect = False
        Me.BtnReportCaller.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReportCaller.Image = Global.AppImelsa.My.Resources.Resources.elimin1
        Me.BtnReportCaller.Location = New System.Drawing.Point(147, 117)
        Me.BtnReportCaller.Name = "BtnReportCaller"
        Me.BtnReportCaller.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.BtnReportCaller.Size = New System.Drawing.Size(116, 29)
        Me.BtnReportCaller.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013
        Me.BtnReportCaller.TabIndex = 64
        Me.BtnReportCaller.Text = "Generar Reporte"
        Me.BtnReportCaller.TextColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        '
        'InventariadoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BottomLeftCornerSize = 0
        Me.BottomRightCornerSize = 0
        Me.ClientSize = New System.Drawing.Size(1105, 505)
        Me.Controls.Add(Me.BtnReportCaller)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.ButtonX2)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ReflectionLabel1)
        Me.Controls.Add(Me.ReflectionLabel2)
        Me.Controls.Add(Me.BtnLoadTable)
        Me.Controls.Add(Me.GridArticulo)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "InventariadoForm"
        Me.Text = "Control de Articulos"
        Me.TopLeftCornerSize = 0
        Me.TopRightCornerSize = 0
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ReflectionLabel1 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents ReflectionLabel2 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents BtnLoadTable As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GridArticulo As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents ButtonX3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextCodeArt As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TextStock As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TextDesc As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TextName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents BtnInsertArticulo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TextCodeCat As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents BtnReportCaller As DevComponents.DotNetBar.ButtonX
End Class

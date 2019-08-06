<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InventarioForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim Background1 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InventarioForm))
        Me.GridClient = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.ReflectionLabel1 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.ReflectionLabel2 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.BtnDeleteClient = New DevComponents.DotNetBar.ButtonX()
        Me.BtnUpdateClient = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RbtnIden = New System.Windows.Forms.RadioButton()
        Me.RbtnCode = New System.Windows.Forms.RadioButton()
        Me.RbtnName = New System.Windows.Forms.RadioButton()
        Me.RbtnAll = New System.Windows.Forms.RadioButton()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.BtnSearch = New DevComponents.DotNetBar.ButtonX()
        Me.TxtBSearch = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.BtnCategoria = New DevComponents.DotNetBar.ButtonX()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnLoadTable = New DevComponents.DotNetBar.ButtonX()
        Me.BtnNewClient = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx2.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridClient
        '
        Me.GridClient.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.GridClient.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
        Me.GridClient.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridClient.ForeColor = System.Drawing.Color.Black
        Me.GridClient.Location = New System.Drawing.Point(330, 168)
        Me.GridClient.Name = "GridClient"
        '
        '
        '
        Me.GridClient.PrimaryGrid.AllowEdit = False
        '
        '
        '
        Me.GridClient.PrimaryGrid.Caption.BackgroundImage = Global.AppImelsa.My.Resources.Resources.Anadir
        Background1.Color1 = System.Drawing.Color.DodgerBlue
        Background1.Color2 = System.Drawing.Color.DodgerBlue
        Me.GridClient.PrimaryGrid.DefaultVisualStyles.AlternateRowCellStyles.Default.Background = Background1
        Me.GridClient.PrimaryGrid.InitialSelection = DevComponents.DotNetBar.SuperGrid.RelativeSelection.Row
        Me.GridClient.PrimaryGrid.MultiSelect = False
        Me.GridClient.PrimaryGrid.PrimaryColumnIndex = 2236962
        Me.GridClient.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row
        Me.GridClient.Size = New System.Drawing.Size(832, 273)
        Me.GridClient.TabIndex = 51
        Me.GridClient.Text = "SuperGridControl1"
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
        Me.ReflectionLabel1.Location = New System.Drawing.Point(797, 34)
        Me.ReflectionLabel1.Name = "ReflectionLabel1"
        Me.ReflectionLabel1.Size = New System.Drawing.Size(364, 35)
        Me.ReflectionLabel1.TabIndex = 48
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
        Me.ReflectionLabel2.Location = New System.Drawing.Point(1000, 92)
        Me.ReflectionLabel2.Name = "ReflectionLabel2"
        Me.ReflectionLabel2.Size = New System.Drawing.Size(161, 23)
        Me.ReflectionLabel2.TabIndex = 50
        Me.ReflectionLabel2.Text = "<b><font size=""+6""><i>Inventariado de articulos</i><font color=""#222222""></font><" &
    "font color=""#003333""></font></font></b>"
        '
        'BtnDeleteClient
        '
        Me.BtnDeleteClient.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnDeleteClient.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnDeleteClient.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeleteClient.Location = New System.Drawing.Point(1032, 452)
        Me.BtnDeleteClient.Name = "BtnDeleteClient"
        Me.BtnDeleteClient.Size = New System.Drawing.Size(129, 23)
        Me.BtnDeleteClient.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnDeleteClient.TabIndex = 53
        Me.BtnDeleteClient.Text = "Eliminar"
        '
        'BtnUpdateClient
        '
        Me.BtnUpdateClient.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnUpdateClient.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnUpdateClient.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdateClient.Location = New System.Drawing.Point(891, 452)
        Me.BtnUpdateClient.Name = "BtnUpdateClient"
        Me.BtnUpdateClient.Size = New System.Drawing.Size(135, 23)
        Me.BtnUpdateClient.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnUpdateClient.TabIndex = 54
        Me.BtnUpdateClient.Text = "Ver Perfil"
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.GroupPanel2)
        Me.PanelEx2.Controls.Add(Me.LabelX2)
        Me.PanelEx2.Controls.Add(Me.BtnSearch)
        Me.PanelEx2.Controls.Add(Me.TxtBSearch)
        Me.PanelEx2.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx2.Location = New System.Drawing.Point(22, 12)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(232, 481)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 58
        '
        'GroupPanel2
        '
        Me.GroupPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.GroupPanel2.CanvasColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.RadioButton1)
        Me.GroupPanel2.Controls.Add(Me.RbtnIden)
        Me.GroupPanel2.Controls.Add(Me.RbtnCode)
        Me.GroupPanel2.Controls.Add(Me.RbtnName)
        Me.GroupPanel2.Controls.Add(Me.RbtnAll)
        Me.GroupPanel2.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel2.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel2.Location = New System.Drawing.Point(12, 94)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(202, 173)
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
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton1.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.ForeColor = System.Drawing.Color.Black
        Me.RadioButton1.Location = New System.Drawing.Point(20, 79)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(66, 22)
        Me.RadioButton1.TabIndex = 4
        Me.RadioButton1.Text = "Proyecto"
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'RbtnIden
        '
        Me.RbtnIden.AutoSize = True
        Me.RbtnIden.BackColor = System.Drawing.Color.Transparent
        Me.RbtnIden.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbtnIden.ForeColor = System.Drawing.Color.Black
        Me.RbtnIden.Location = New System.Drawing.Point(20, 51)
        Me.RbtnIden.Name = "RbtnIden"
        Me.RbtnIden.Size = New System.Drawing.Size(67, 22)
        Me.RbtnIden.TabIndex = 3
        Me.RbtnIden.Text = "Categoria"
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
        Me.RbtnAll.Location = New System.Drawing.Point(20, 107)
        Me.RbtnAll.Name = "RbtnAll"
        Me.RbtnAll.Size = New System.Drawing.Size(71, 22)
        Me.RbtnAll.TabIndex = 1
        Me.RbtnAll.TabStop = True
        Me.RbtnAll.Text = "Ver Todos"
        Me.RbtnAll.UseVisualStyleBackColor = False
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
        Me.TxtBSearch.Location = New System.Drawing.Point(54, 46)
        Me.TxtBSearch.Name = "TxtBSearch"
        Me.TxtBSearch.PreventEnterBeep = True
        Me.TxtBSearch.Size = New System.Drawing.Size(129, 23)
        Me.TxtBSearch.TabIndex = 16
        '
        'BtnCategoria
        '
        Me.BtnCategoria.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnCategoria.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.BtnCategoria.FadeEffect = False
        Me.BtnCategoria.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCategoria.Image = Global.AppImelsa.My.Resources.Resources.Ic
        Me.BtnCategoria.Location = New System.Drawing.Point(455, 56)
        Me.BtnCategoria.Name = "BtnCategoria"
        Me.BtnCategoria.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.BtnCategoria.Size = New System.Drawing.Size(124, 29)
        Me.BtnCategoria.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013
        Me.BtnCategoria.TabIndex = 62
        Me.BtnCategoria.Text = "Añadir Categoria"
        Me.BtnCategoria.TextColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        '
        'PictureBox1
        '
        Me.PictureBox1.ForeColor = System.Drawing.Color.Black
        Me.PictureBox1.Image = Global.AppImelsa.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(330, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(119, 148)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 52
        Me.PictureBox1.TabStop = False
        '
        'BtnLoadTable
        '
        Me.BtnLoadTable.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnLoadTable.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.BtnLoadTable.FadeEffect = False
        Me.BtnLoadTable.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLoadTable.Image = Global.AppImelsa.My.Resources.Resources.Icp
        Me.BtnLoadTable.Location = New System.Drawing.Point(1072, 131)
        Me.BtnLoadTable.Name = "BtnLoadTable"
        Me.BtnLoadTable.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.BtnLoadTable.Size = New System.Drawing.Size(90, 29)
        Me.BtnLoadTable.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013
        Me.BtnLoadTable.TabIndex = 49
        Me.BtnLoadTable.Text = "Refrescar"
        Me.BtnLoadTable.TextColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        '
        'BtnNewClient
        '
        Me.BtnNewClient.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnNewClient.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.BtnNewClient.FadeEffect = False
        Me.BtnNewClient.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNewClient.Image = Global.AppImelsa.My.Resources.Resources.Ic
        Me.BtnNewClient.Location = New System.Drawing.Point(959, 131)
        Me.BtnNewClient.Name = "BtnNewClient"
        Me.BtnNewClient.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.BtnNewClient.Size = New System.Drawing.Size(107, 29)
        Me.BtnNewClient.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013
        Me.BtnNewClient.TabIndex = 47
        Me.BtnNewClient.Text = "Nuevo Articulo"
        Me.BtnNewClient.TextColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.ButtonX1.FadeEffect = False
        Me.ButtonX1.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX1.Image = Global.AppImelsa.My.Resources.Resources.Ic
        Me.ButtonX1.Location = New System.Drawing.Point(455, 21)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.ButtonX1.Size = New System.Drawing.Size(107, 29)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013
        Me.ButtonX1.TabIndex = 63
        Me.ButtonX1.Text = "Ver Categoria"
        Me.ButtonX1.TextColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        '
        'InventarioForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1206, 512)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.BtnCategoria)
        Me.Controls.Add(Me.PanelEx2)
        Me.Controls.Add(Me.BtnDeleteClient)
        Me.Controls.Add(Me.BtnUpdateClient)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GridClient)
        Me.Controls.Add(Me.ReflectionLabel1)
        Me.Controls.Add(Me.ReflectionLabel2)
        Me.Controls.Add(Me.BtnLoadTable)
        Me.Controls.Add(Me.BtnNewClient)
        Me.Name = "InventarioForm"
        Me.Text = "Inventario"
        Me.PanelEx2.ResumeLayout(False)
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GridClient As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents ReflectionLabel1 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents ReflectionLabel2 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents BtnLoadTable As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnNewClient As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnDeleteClient As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnUpdateClient As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents RbtnCode As RadioButton
    Friend WithEvents RbtnName As RadioButton
    Friend WithEvents RbtnAll As RadioButton
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents BtnSearch As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TxtBSearch As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents RbtnIden As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents BtnCategoria As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
End Class

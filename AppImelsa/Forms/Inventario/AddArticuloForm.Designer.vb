<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddArticuloForm
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
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
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
        Me.BtnInsertEscolaridad = New DevComponents.DotNetBar.ButtonX()
        Me.TextCodeCat = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupPanel1
        '
        Me.GroupPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.GroupPanel1.CanvasColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
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
        Me.GroupPanel1.Controls.Add(Me.BtnInsertEscolaridad)
        Me.GroupPanel1.Controls.Add(Me.TextCodeCat)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel1.Location = New System.Drawing.Point(12, 12)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(328, 285)
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
        Me.GroupPanel1.TabIndex = 22
        Me.GroupPanel1.Text = "Agregar Nuevo Articulo"
        '
        'TextCodeArt
        '
        '
        '
        '
        Me.TextCodeArt.Border.Class = "TextBoxBorder"
        Me.TextCodeArt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextCodeArt.DisabledBackColor = System.Drawing.Color.White
        Me.TextCodeArt.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextCodeArt.Location = New System.Drawing.Point(117, 22)
        Me.TextCodeArt.MaxLength = 85
        Me.TextCodeArt.Name = "TextCodeArt"
        Me.TextCodeArt.PreventEnterBeep = True
        Me.TextCodeArt.Size = New System.Drawing.Size(193, 22)
        Me.TextCodeArt.TabIndex = 27
        '
        'TextStock
        '
        '
        '
        '
        Me.TextStock.Border.Class = "TextBoxBorder"
        Me.TextStock.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextStock.DisabledBackColor = System.Drawing.Color.White
        Me.TextStock.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextStock.Location = New System.Drawing.Point(117, 177)
        Me.TextStock.MaxLength = 85
        Me.TextStock.Name = "TextStock"
        Me.TextStock.PreventEnterBeep = True
        Me.TextStock.Size = New System.Drawing.Size(193, 22)
        Me.TextStock.TabIndex = 26
        '
        'TextDesc
        '
        '
        '
        '
        Me.TextDesc.Border.Class = "TextBoxBorder"
        Me.TextDesc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextDesc.DisabledBackColor = System.Drawing.Color.White
        Me.TextDesc.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextDesc.Location = New System.Drawing.Point(117, 149)
        Me.TextDesc.MaxLength = 85
        Me.TextDesc.Name = "TextDesc"
        Me.TextDesc.PreventEnterBeep = True
        Me.TextDesc.Size = New System.Drawing.Size(193, 22)
        Me.TextDesc.TabIndex = 25
        '
        'TextName
        '
        '
        '
        '
        Me.TextName.Border.Class = "TextBoxBorder"
        Me.TextName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextName.DisabledBackColor = System.Drawing.Color.White
        Me.TextName.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextName.Location = New System.Drawing.Point(117, 120)
        Me.TextName.MaxLength = 85
        Me.TextName.Name = "TextName"
        Me.TextName.PreventEnterBeep = True
        Me.TextName.Size = New System.Drawing.Size(193, 22)
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
        'BtnInsertEscolaridad
        '
        Me.BtnInsertEscolaridad.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnInsertEscolaridad.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInsertEscolaridad.Location = New System.Drawing.Point(38, 220)
        Me.BtnInsertEscolaridad.Name = "BtnInsertEscolaridad"
        Me.BtnInsertEscolaridad.Size = New System.Drawing.Size(220, 36)
        Me.BtnInsertEscolaridad.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnInsertEscolaridad.TabIndex = 15
        Me.BtnInsertEscolaridad.Text = "Agregar"
        '
        'TextCodeCat
        '
        '
        '
        '
        Me.TextCodeCat.Border.Class = "TextBoxBorder"
        Me.TextCodeCat.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextCodeCat.DisabledBackColor = System.Drawing.Color.White
        Me.TextCodeCat.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextCodeCat.Location = New System.Drawing.Point(117, 54)
        Me.TextCodeCat.MaxLength = 85
        Me.TextCodeCat.Name = "TextCodeCat"
        Me.TextCodeCat.PreventEnterBeep = True
        Me.TextCodeCat.Size = New System.Drawing.Size(193, 22)
        Me.TextCodeCat.TabIndex = 14
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.ComboBox1.ForeColor = System.Drawing.Color.Black
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(117, 85)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(193, 28)
        Me.ComboBox1.TabIndex = 174
        '
        'AddArticuloForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 305)
        Me.Controls.Add(Me.GroupPanel1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "AddArticuloForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Articulo"
        Me.GroupPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents BtnInsertEscolaridad As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TextCodeCat As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TextStock As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TextDesc As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TextName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TextCodeArt As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ComboBox1 As ComboBox
End Class

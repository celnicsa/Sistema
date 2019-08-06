<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CategoriaForm
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
        Me.GridCategorias = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextCodigo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.TextNombre = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.TextDesc = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.ReflectionLabel1 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.BtnAddClient = New DevComponents.DotNetBar.ButtonX()
        Me.ReflectionLabel2 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.BtnUpdateClient = New DevComponents.DotNetBar.ButtonX()
        Me.BtnDeleteCategoria = New DevComponents.DotNetBar.ButtonX()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridCategorias
        '
        Me.GridCategorias.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.GridCategorias.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
        Me.GridCategorias.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridCategorias.ForeColor = System.Drawing.Color.Black
        Me.GridCategorias.Location = New System.Drawing.Point(285, 145)
        Me.GridCategorias.Name = "GridCategorias"
        '
        '
        '
        Me.GridCategorias.PrimaryGrid.AllowEdit = False
        '
        '
        '
        Me.GridCategorias.PrimaryGrid.Caption.BackgroundImage = Global.AppImelsa.My.Resources.Resources.Anadir
        Background1.Color1 = System.Drawing.Color.DodgerBlue
        Background1.Color2 = System.Drawing.Color.DodgerBlue
        Me.GridCategorias.PrimaryGrid.DefaultVisualStyles.AlternateRowCellStyles.Default.Background = Background1
        Me.GridCategorias.PrimaryGrid.InitialSelection = DevComponents.DotNetBar.SuperGrid.RelativeSelection.Row
        Me.GridCategorias.PrimaryGrid.MultiSelect = False
        Me.GridCategorias.PrimaryGrid.PrimaryColumnIndex = 2236962
        Me.GridCategorias.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row
        Me.GridCategorias.Size = New System.Drawing.Size(510, 225)
        Me.GridCategorias.TabIndex = 48
        Me.GridCategorias.Text = "SuperGridControl1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.BtnDeleteCategoria)
        Me.Panel1.Controls.Add(Me.BtnUpdateClient)
        Me.Panel1.Controls.Add(Me.ReflectionLabel1)
        Me.Panel1.Controls.Add(Me.TextDesc)
        Me.Panel1.Controls.Add(Me.BtnAddClient)
        Me.Panel1.Controls.Add(Me.LabelX3)
        Me.Panel1.Controls.Add(Me.TextNombre)
        Me.Panel1.Controls.Add(Me.LabelX2)
        Me.Panel1.Controls.Add(Me.TextCodigo)
        Me.Panel1.Controls.Add(Me.LabelX1)
        Me.Panel1.Location = New System.Drawing.Point(12, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(249, 345)
        Me.Panel1.TabIndex = 49
        '
        'TextCodigo
        '
        Me.TextCodigo.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        '
        '
        '
        Me.TextCodigo.Border.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial
        Me.TextCodigo.Border.Class = "TextBoxBorder"
        Me.TextCodigo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextCodigo.DisabledBackColor = System.Drawing.Color.White
        Me.TextCodigo.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextCodigo.Location = New System.Drawing.Point(12, 85)
        Me.TextCodigo.MaxLength = 15
        Me.TextCodigo.Name = "TextCodigo"
        Me.TextCodigo.PreventEnterBeep = True
        Me.TextCodigo.Size = New System.Drawing.Size(224, 22)
        Me.TextCodigo.TabIndex = 148
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
        Me.LabelX1.Location = New System.Drawing.Point(12, 56)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(98, 23)
        Me.LabelX1.TabIndex = 147
        Me.LabelX1.Text = "Codigo Categoria"
        '
        'TextNombre
        '
        Me.TextNombre.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        '
        '
        '
        Me.TextNombre.Border.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial
        Me.TextNombre.Border.Class = "TextBoxBorder"
        Me.TextNombre.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextNombre.DisabledBackColor = System.Drawing.Color.White
        Me.TextNombre.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextNombre.Location = New System.Drawing.Point(12, 142)
        Me.TextNombre.MaxLength = 15
        Me.TextNombre.Name = "TextNombre"
        Me.TextNombre.PreventEnterBeep = True
        Me.TextNombre.Size = New System.Drawing.Size(224, 22)
        Me.TextNombre.TabIndex = 150
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
        Me.LabelX2.Location = New System.Drawing.Point(12, 113)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(98, 23)
        Me.LabelX2.TabIndex = 149
        Me.LabelX2.Text = "Nombre Categoria"
        '
        'TextDesc
        '
        Me.TextDesc.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        '
        '
        '
        Me.TextDesc.Border.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial
        Me.TextDesc.Border.Class = "TextBoxBorder"
        Me.TextDesc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextDesc.DisabledBackColor = System.Drawing.Color.White
        Me.TextDesc.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextDesc.Location = New System.Drawing.Point(12, 199)
        Me.TextDesc.MaxLength = 15
        Me.TextDesc.Name = "TextDesc"
        Me.TextDesc.PreventEnterBeep = True
        Me.TextDesc.Size = New System.Drawing.Size(224, 22)
        Me.TextDesc.TabIndex = 152
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
        Me.LabelX3.Location = New System.Drawing.Point(12, 170)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(129, 23)
        Me.LabelX3.TabIndex = 151
        Me.LabelX3.Text = "Descripcion Categoria"
        '
        'ReflectionLabel1
        '
        Me.ReflectionLabel1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.ReflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionLabel1.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReflectionLabel1.ForeColor = System.Drawing.Color.Black
        Me.ReflectionLabel1.Location = New System.Drawing.Point(12, 3)
        Me.ReflectionLabel1.Name = "ReflectionLabel1"
        Me.ReflectionLabel1.Size = New System.Drawing.Size(202, 50)
        Me.ReflectionLabel1.TabIndex = 153
        Me.ReflectionLabel1.Text = "<b><font size=""+6""><i></i><font color=""#003333""> Datos Categoria</font></font></b" &
    ">"
        '
        'BtnAddClient
        '
        Me.BtnAddClient.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnAddClient.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnAddClient.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddClient.Location = New System.Drawing.Point(12, 244)
        Me.BtnAddClient.Name = "BtnAddClient"
        Me.BtnAddClient.Size = New System.Drawing.Size(108, 39)
        Me.BtnAddClient.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnAddClient.TabIndex = 50
        Me.BtnAddClient.Text = "Añadir Categoria"
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
        Me.ReflectionLabel2.Location = New System.Drawing.Point(641, 81)
        Me.ReflectionLabel2.Name = "ReflectionLabel2"
        Me.ReflectionLabel2.Size = New System.Drawing.Size(154, 23)
        Me.ReflectionLabel2.TabIndex = 52
        Me.ReflectionLabel2.Text = "<b><font size=""+6""><i></i><font color=""#222222""> Control De Categorias </font><fo" &
    "nt color=""#003333""></font></font></b>"
        '
        'BtnUpdateClient
        '
        Me.BtnUpdateClient.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnUpdateClient.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnUpdateClient.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdateClient.Location = New System.Drawing.Point(126, 244)
        Me.BtnUpdateClient.Name = "BtnUpdateClient"
        Me.BtnUpdateClient.Size = New System.Drawing.Size(110, 39)
        Me.BtnUpdateClient.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnUpdateClient.TabIndex = 53
        Me.BtnUpdateClient.Text = "Modificar Categoria"
        '
        'BtnDeleteCategoria
        '
        Me.BtnDeleteCategoria.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnDeleteCategoria.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnDeleteCategoria.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeleteCategoria.Location = New System.Drawing.Point(78, 289)
        Me.BtnDeleteCategoria.Name = "BtnDeleteCategoria"
        Me.BtnDeleteCategoria.Size = New System.Drawing.Size(98, 39)
        Me.BtnDeleteCategoria.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnDeleteCategoria.TabIndex = 154
        Me.BtnDeleteCategoria.Text = "Eliminar Categoria"
        '
        'PictureBox1
        '
        Me.PictureBox1.ForeColor = System.Drawing.Color.Black
        Me.PictureBox1.Image = Global.AppImelsa.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(297, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(91, 114)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 53
        Me.PictureBox1.TabStop = False
        '
        'CategoriaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(813, 382)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ReflectionLabel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GridCategorias)
        Me.Name = "CategoriaForm"
        Me.Text = "CategoriaForm"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GridCategorias As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextDesc As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TextNombre As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TextCodigo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ReflectionLabel1 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents BtnAddClient As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnDeleteCategoria As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnUpdateClient As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ReflectionLabel2 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents PictureBox1 As PictureBox
End Class

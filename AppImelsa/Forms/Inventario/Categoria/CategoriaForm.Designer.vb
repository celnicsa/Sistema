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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GridCategoria = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnEliminarCategoria = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnAddCategoria = New DevComponents.DotNetBar.ButtonX()
        Me.TextDesc = New System.Windows.Forms.TextBox()
        Me.TextName = New System.Windows.Forms.TextBox()
        Me.TextCodigo = New System.Windows.Forms.TextBox()
        Me.ReflectionLabel2 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.ForeColor = System.Drawing.Color.Black
        Me.PictureBox1.Image = Global.AppImelsa.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(805, 60)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(119, 148)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 54
        Me.PictureBox1.TabStop = False
        '
        'GridCategoria
        '
        Me.GridCategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.GridCategoria.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
        Me.GridCategoria.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridCategoria.ForeColor = System.Drawing.Color.Black
        Me.GridCategoria.Location = New System.Drawing.Point(283, 12)
        Me.GridCategoria.Name = "GridCategoria"
        '
        '
        '
        Me.GridCategoria.PrimaryGrid.AllowEdit = False
        '
        '
        '
        Me.GridCategoria.PrimaryGrid.Caption.BackgroundImage = Global.AppImelsa.My.Resources.Resources.Anadir
        Background1.Color1 = System.Drawing.Color.DodgerBlue
        Background1.Color2 = System.Drawing.Color.DodgerBlue
        Me.GridCategoria.PrimaryGrid.DefaultVisualStyles.AlternateRowCellStyles.Default.Background = Background1
        Me.GridCategoria.PrimaryGrid.InitialSelection = DevComponents.DotNetBar.SuperGrid.RelativeSelection.Row
        Me.GridCategoria.PrimaryGrid.MultiSelect = False
        Me.GridCategoria.PrimaryGrid.PrimaryColumnIndex = 2236962
        Me.GridCategoria.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row
        Me.GridCategoria.Size = New System.Drawing.Size(472, 281)
        Me.GridCategoria.TabIndex = 53
        Me.GridCategoria.Text = "SuperGridControl1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.BtnEliminarCategoria)
        Me.Panel1.Controls.Add(Me.ButtonX1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.BtnAddCategoria)
        Me.Panel1.Controls.Add(Me.TextDesc)
        Me.Panel1.Controls.Add(Me.TextName)
        Me.Panel1.Controls.Add(Me.TextCodigo)
        Me.Panel1.Controls.Add(Me.ReflectionLabel2)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(265, 281)
        Me.Panel1.TabIndex = 55
        '
        'BtnEliminarCategoria
        '
        Me.BtnEliminarCategoria.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnEliminarCategoria.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnEliminarCategoria.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminarCategoria.Location = New System.Drawing.Point(82, 242)
        Me.BtnEliminarCategoria.Name = "BtnEliminarCategoria"
        Me.BtnEliminarCategoria.Size = New System.Drawing.Size(111, 23)
        Me.BtnEliminarCategoria.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnEliminarCategoria.TabIndex = 163
        Me.BtnEliminarCategoria.Text = "Eliminar Categoria"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX1.Location = New System.Drawing.Point(135, 213)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(111, 23)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 162
        Me.ButtonX1.Text = "Modificar Categoria"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(177, 21)
        Me.Label3.TabIndex = 161
        Me.Label3.Text = "Descripcion Categoria"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 21)
        Me.Label2.TabIndex = 160
        Me.Label2.Text = "Nombre Categoria"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 21)
        Me.Label1.TabIndex = 159
        Me.Label1.Text = "Codigo Categoria"
        '
        'BtnAddCategoria
        '
        Me.BtnAddCategoria.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnAddCategoria.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnAddCategoria.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddCategoria.Location = New System.Drawing.Point(18, 213)
        Me.BtnAddCategoria.Name = "BtnAddCategoria"
        Me.BtnAddCategoria.Size = New System.Drawing.Size(111, 23)
        Me.BtnAddCategoria.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnAddCategoria.TabIndex = 158
        Me.BtnAddCategoria.Text = "Añadir Categoria"
        '
        'TextDesc
        '
        Me.TextDesc.Location = New System.Drawing.Point(18, 176)
        Me.TextDesc.Name = "TextDesc"
        Me.TextDesc.Size = New System.Drawing.Size(221, 20)
        Me.TextDesc.TabIndex = 157
        '
        'TextName
        '
        Me.TextName.Location = New System.Drawing.Point(18, 119)
        Me.TextName.Name = "TextName"
        Me.TextName.Size = New System.Drawing.Size(221, 20)
        Me.TextName.TabIndex = 156
        '
        'TextCodigo
        '
        Me.TextCodigo.Location = New System.Drawing.Point(18, 63)
        Me.TextCodigo.Name = "TextCodigo"
        Me.TextCodigo.Size = New System.Drawing.Size(221, 20)
        Me.TextCodigo.TabIndex = 155
        '
        'ReflectionLabel2
        '
        Me.ReflectionLabel2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.ReflectionLabel2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionLabel2.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReflectionLabel2.ForeColor = System.Drawing.Color.Black
        Me.ReflectionLabel2.Location = New System.Drawing.Point(18, 3)
        Me.ReflectionLabel2.Name = "ReflectionLabel2"
        Me.ReflectionLabel2.Size = New System.Drawing.Size(175, 42)
        Me.ReflectionLabel2.TabIndex = 154
        Me.ReflectionLabel2.Text = "<b><font size=""+6""><i>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "</i><font color=""#003333""> AñadirCategoria" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "</font></font" &
    "></b>"
        '
        'CategoriaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(946, 306)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GridCategoria)
        Me.Name = "CategoriaForm"
        Me.Text = "CategoriaForm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GridCategoria As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextDesc As TextBox
    Friend WithEvents TextName As TextBox
    Friend WithEvents TextCodigo As TextBox
    Friend WithEvents ReflectionLabel2 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents BtnAddCategoria As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnEliminarCategoria As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
End Class

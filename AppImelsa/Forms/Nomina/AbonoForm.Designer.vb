<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AbonoForm
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
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelSaldo = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelMonto = New DevComponents.DotNetBar.LabelX()
        Me.LabelCode = New DevComponents.DotNetBar.LabelX()
        Me.LabelEmployed = New DevComponents.DotNetBar.LabelX()
        Me.GridAbono = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.ReflectionLabel1 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.BtnClose = New DevComponents.DotNetBar.ButtonX()
        Me.BtnUpdateAbono = New DevComponents.DotNetBar.ButtonX()
        Me.BtnDeleteAbono = New DevComponents.DotNetBar.ButtonX()
        Me.BtnAddAbono = New DevComponents.DotNetBar.ButtonX()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.PanelEx1.SuspendLayout()
        Me.PanelEx2.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.PanelEx2)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(858, 316)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.Color = System.Drawing.Color.WhiteSmoke
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 15
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.GroupPanel1)
        Me.PanelEx2.Controls.Add(Me.GridAbono)
        Me.PanelEx2.Controls.Add(Me.ReflectionLabel1)
        Me.PanelEx2.Controls.Add(Me.BtnClose)
        Me.PanelEx2.Controls.Add(Me.BtnUpdateAbono)
        Me.PanelEx2.Controls.Add(Me.BtnDeleteAbono)
        Me.PanelEx2.Controls.Add(Me.BtnAddAbono)
        Me.PanelEx2.Controls.Add(Me.PictureBox1)
        Me.PanelEx2.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx2.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(858, 316)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.Color = System.Drawing.Color.WhiteSmoke
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 15
        '
        'GroupPanel1
        '
        Me.GroupPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.GroupPanel1.CanvasColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.LabelX1)
        Me.GroupPanel1.Controls.Add(Me.LabelX2)
        Me.GroupPanel1.Controls.Add(Me.LabelX3)
        Me.GroupPanel1.Controls.Add(Me.LabelSaldo)
        Me.GroupPanel1.Controls.Add(Me.LabelX4)
        Me.GroupPanel1.Controls.Add(Me.LabelMonto)
        Me.GroupPanel1.Controls.Add(Me.LabelCode)
        Me.GroupPanel1.Controls.Add(Me.LabelEmployed)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Location = New System.Drawing.Point(12, 12)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(322, 116)
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
        Me.GroupPanel1.TabIndex = 48
        Me.GroupPanel1.Text = "Datos del Prestamo"
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(15, 13)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(57, 21)
        Me.LabelX1.TabIndex = 48
        Me.LabelX1.Text = "Codigo:"
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.ForeColor = System.Drawing.Color.Black
        Me.LabelX2.Location = New System.Drawing.Point(15, 40)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(57, 21)
        Me.LabelX2.TabIndex = 49
        Me.LabelX2.Text = "Empleado:"
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.ForeColor = System.Drawing.Color.Black
        Me.LabelX3.Location = New System.Drawing.Point(14, 67)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(58, 21)
        Me.LabelX3.TabIndex = 50
        Me.LabelX3.Text = "Monto:"
        '
        'LabelSaldo
        '
        Me.LabelSaldo.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelSaldo.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.LabelSaldo.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.LabelSaldo.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.LabelSaldo.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.LabelSaldo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelSaldo.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSaldo.ForeColor = System.Drawing.Color.Black
        Me.LabelSaldo.Location = New System.Drawing.Point(225, 13)
        Me.LabelSaldo.Name = "LabelSaldo"
        Me.LabelSaldo.Size = New System.Drawing.Size(99, 21)
        Me.LabelSaldo.TabIndex = 55
        '
        'LabelX4
        '
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.ForeColor = System.Drawing.Color.Black
        Me.LabelX4.Location = New System.Drawing.Point(179, 13)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(40, 21)
        Me.LabelX4.TabIndex = 51
        Me.LabelX4.Text = "Saldo:"
        '
        'LabelMonto
        '
        Me.LabelMonto.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelMonto.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.LabelMonto.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.LabelMonto.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.LabelMonto.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.LabelMonto.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelMonto.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMonto.ForeColor = System.Drawing.Color.Black
        Me.LabelMonto.Location = New System.Drawing.Point(76, 69)
        Me.LabelMonto.Name = "LabelMonto"
        Me.LabelMonto.Size = New System.Drawing.Size(87, 21)
        Me.LabelMonto.TabIndex = 54
        '
        'LabelCode
        '
        Me.LabelCode.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelCode.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.LabelCode.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.LabelCode.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.LabelCode.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.LabelCode.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelCode.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCode.ForeColor = System.Drawing.Color.Black
        Me.LabelCode.Location = New System.Drawing.Point(76, 13)
        Me.LabelCode.Name = "LabelCode"
        Me.LabelCode.Size = New System.Drawing.Size(87, 21)
        Me.LabelCode.TabIndex = 52
        '
        'LabelEmployed
        '
        Me.LabelEmployed.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelEmployed.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.LabelEmployed.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.LabelEmployed.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.LabelEmployed.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.LabelEmployed.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelEmployed.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEmployed.ForeColor = System.Drawing.Color.Black
        Me.LabelEmployed.Location = New System.Drawing.Point(76, 40)
        Me.LabelEmployed.Name = "LabelEmployed"
        Me.LabelEmployed.Size = New System.Drawing.Size(164, 21)
        Me.LabelEmployed.TabIndex = 53
        '
        'GridAbono
        '
        Me.GridAbono.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.GridAbono.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
        Me.GridAbono.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridAbono.ForeColor = System.Drawing.Color.Black
        Me.GridAbono.Location = New System.Drawing.Point(375, 112)
        Me.GridAbono.Name = "GridAbono"
        '
        '
        '
        Me.GridAbono.PrimaryGrid.AllowEdit = False
        '
        '
        '
        Me.GridAbono.PrimaryGrid.Caption.BackgroundImage = Global.AppImelsa.My.Resources.Resources.Anadir
        Background1.Color1 = System.Drawing.Color.WhiteSmoke
        Background1.Color2 = System.Drawing.Color.Gainsboro
        Me.GridAbono.PrimaryGrid.DefaultVisualStyles.AlternateRowCellStyles.Default.Background = Background1
        Me.GridAbono.PrimaryGrid.InitialSelection = DevComponents.DotNetBar.SuperGrid.RelativeSelection.Row
        Me.GridAbono.PrimaryGrid.MultiSelect = False
        Me.GridAbono.PrimaryGrid.PrimaryColumnIndex = 2236962
        Me.GridAbono.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row
        Me.GridAbono.PrimaryGrid.UseAlternateRowStyle = True
        Me.GridAbono.Size = New System.Drawing.Size(471, 173)
        Me.GridAbono.TabIndex = 39
        Me.GridAbono.Text = "SuperGridControl1"
        '
        'ReflectionLabel1
        '
        Me.ReflectionLabel1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.ReflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionLabel1.Font = New System.Drawing.Font("Agency FB", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReflectionLabel1.ForeColor = System.Drawing.Color.Black
        Me.ReflectionLabel1.Location = New System.Drawing.Point(535, 23)
        Me.ReflectionLabel1.Name = "ReflectionLabel1"
        Me.ReflectionLabel1.Size = New System.Drawing.Size(311, 32)
        Me.ReflectionLabel1.TabIndex = 35
        Me.ReflectionLabel1.Text = "<b><font size=""+6""><i>Construcicones Eléctricas de Nicaragua SA.</i><font color=""" &
    "#222222""></font><font color=""#003333""></font></font></b>"
        '
        'BtnClose
        '
        Me.BtnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnClose.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Location = New System.Drawing.Point(17, 224)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(322, 21)
        Me.BtnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnClose.TabIndex = 24
        Me.BtnClose.Text = "Cerrar"
        '
        'BtnUpdateAbono
        '
        Me.BtnUpdateAbono.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnUpdateAbono.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnUpdateAbono.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdateAbono.Location = New System.Drawing.Point(17, 197)
        Me.BtnUpdateAbono.Name = "BtnUpdateAbono"
        Me.BtnUpdateAbono.Size = New System.Drawing.Size(322, 21)
        Me.BtnUpdateAbono.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnUpdateAbono.TabIndex = 23
        Me.BtnUpdateAbono.Text = "Modificar Abono"
        '
        'BtnDeleteAbono
        '
        Me.BtnDeleteAbono.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnDeleteAbono.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnDeleteAbono.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeleteAbono.Location = New System.Drawing.Point(17, 171)
        Me.BtnDeleteAbono.Name = "BtnDeleteAbono"
        Me.BtnDeleteAbono.Size = New System.Drawing.Size(322, 21)
        Me.BtnDeleteAbono.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnDeleteAbono.TabIndex = 22
        Me.BtnDeleteAbono.Text = "Revertir Abono"
        '
        'BtnAddAbono
        '
        Me.BtnAddAbono.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnAddAbono.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnAddAbono.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddAbono.Location = New System.Drawing.Point(17, 144)
        Me.BtnAddAbono.Name = "BtnAddAbono"
        Me.BtnAddAbono.Size = New System.Drawing.Size(322, 21)
        Me.BtnAddAbono.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnAddAbono.TabIndex = 21
        Me.BtnAddAbono.Text = "Agregar Abono"
        '
        'PictureBox1
        '
        Me.PictureBox1.ForeColor = System.Drawing.Color.Black
        Me.PictureBox1.Image = Global.AppImelsa.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(375, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(77, 83)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2010Blue
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer)))
        '
        'AbonoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(858, 316)
        Me.Controls.Add(Me.PanelEx1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "AbonoForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Abonos"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx2.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ReflectionLabel1 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents BtnClose As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnUpdateAbono As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnDeleteAbono As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnAddAbono As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GridAbono As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelSaldo As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelMonto As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelCode As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelEmployed As DevComponents.DotNetBar.LabelX
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
End Class

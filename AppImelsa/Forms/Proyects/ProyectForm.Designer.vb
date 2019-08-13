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
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.titulo = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ReflectionLabel1 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ReflectionLabel2 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GridProyect = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnProUnico = New DevComponents.DotNetBar.ButtonX()
        Me.BtnGenerarReport = New DevComponents.DotNetBar.ButtonX()
        Me.BtnLoadTable = New DevComponents.DotNetBar.ButtonX()
        Me.BtnDeleteEmployed = New DevComponents.DotNetBar.ButtonX()
        Me.BtnUpdateEmployed = New DevComponents.DotNetBar.ButtonX()
        Me.BtnNewEmployed = New DevComponents.DotNetBar.ButtonX()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.RbtnIden = New System.Windows.Forms.RadioButton()
        Me.RbtnCode = New System.Windows.Forms.RadioButton()
        Me.RbtnName = New System.Windows.Forms.RadioButton()
        Me.RbtnAll = New System.Windows.Forms.RadioButton()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
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
        Me.TxtBSearch = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.BtnSearch = New DevComponents.DotNetBar.ButtonX()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.cont = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.titulo.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.PanelEx3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.cont.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerColorTint = System.Drawing.Color.Gray
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2012Light
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer)))
        '
        'titulo
        '
        Me.titulo.AutoSize = True
        Me.titulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.titulo.Controls.Add(Me.Panel2)
        Me.titulo.Controls.Add(Me.Panel1)
        Me.titulo.Controls.Add(Me.PictureBox1)
        Me.titulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.titulo.ForeColor = System.Drawing.Color.Black
        Me.titulo.Location = New System.Drawing.Point(10, 10)
        Me.titulo.MaximumSize = New System.Drawing.Size(0, 100)
        Me.titulo.MinimumSize = New System.Drawing.Size(1254, 100)
        Me.titulo.Name = "titulo"
        Me.titulo.Padding = New System.Windows.Forms.Padding(0, 10, 10, 10)
        Me.titulo.Size = New System.Drawing.Size(1254, 100)
        Me.titulo.TabIndex = 59
        '
        'Panel2
        '
        Me.Panel2.AutoSize = True
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Panel2.Controls.Add(Me.ReflectionLabel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(259, 10)
        Me.Panel2.MaximumSize = New System.Drawing.Size(0, 80)
        Me.Panel2.MinimumSize = New System.Drawing.Size(587, 80)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel2.Size = New System.Drawing.Size(587, 80)
        Me.Panel2.TabIndex = 63
        '
        'ReflectionLabel1
        '
        Me.ReflectionLabel1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.ReflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionLabel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReflectionLabel1.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReflectionLabel1.ForeColor = System.Drawing.Color.Black
        Me.ReflectionLabel1.Location = New System.Drawing.Point(10, 10)
        Me.ReflectionLabel1.Name = "ReflectionLabel1"
        Me.ReflectionLabel1.Size = New System.Drawing.Size(567, 60)
        Me.ReflectionLabel1.TabIndex = 40
        Me.ReflectionLabel1.Text = "<b><font size=""+6""><i>Construcciones  Electricas de Nicaragua SA.</i></font></b>"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Panel1.Controls.Add(Me.ReflectionLabel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(842, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(402, 80)
        Me.Panel1.TabIndex = 52
        '
        'ReflectionLabel2
        '
        Me.ReflectionLabel2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.ReflectionLabel2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionLabel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReflectionLabel2.Font = New System.Drawing.Font("Agency FB", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReflectionLabel2.ForeColor = System.Drawing.Color.Black
        Me.ReflectionLabel2.Location = New System.Drawing.Point(0, 0)
        Me.ReflectionLabel2.Name = "ReflectionLabel2"
        Me.ReflectionLabel2.Size = New System.Drawing.Size(402, 80)
        Me.ReflectionLabel2.TabIndex = 41
        Me.ReflectionLabel2.Text = "<b><font size=""+6"">Registro y Control de Proyectos</font></b>"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.ForeColor = System.Drawing.Color.Black
        Me.PictureBox1.Image = Global.AppImelsa.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(0, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(259, 80)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 51
        Me.PictureBox1.TabStop = False
        '
        'GridProyect
        '
        Me.GridProyect.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.GridProyect.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridProyect.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
        Me.GridProyect.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridProyect.ForeColor = System.Drawing.Color.Black
        Me.GridProyect.Location = New System.Drawing.Point(0, 0)
        Me.GridProyect.MinimumSize = New System.Drawing.Size(973, 359)
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
        Me.GridProyect.Size = New System.Drawing.Size(999, 518)
        Me.GridProyect.TabIndex = 39
        Me.GridProyect.Text = "SuperGridControl1"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.TableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.TableLayoutPanel1.ColumnCount = 6
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.022!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.24202!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 151.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.BtnProUnico, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnGenerarReport, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnLoadTable, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnDeleteEmployed, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnUpdateEmployed, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnNewEmployed, 3, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.ForeColor = System.Drawing.Color.Black
        Me.TableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(255, 518)
        Me.TableLayoutPanel1.MaximumSize = New System.Drawing.Size(0, 65)
        Me.TableLayoutPanel1.MinimumSize = New System.Drawing.Size(915, 62)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.Padding = New System.Windows.Forms.Padding(3)
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(999, 62)
        Me.TableLayoutPanel1.TabIndex = 37
        '
        'BtnProUnico
        '
        Me.BtnProUnico.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnProUnico.BackColor = System.Drawing.Color.Coral
        Me.BtnProUnico.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.BtnProUnico.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.BtnProUnico.Location = New System.Drawing.Point(340, 6)
        Me.BtnProUnico.Name = "BtnProUnico"
        Me.BtnProUnico.Size = New System.Drawing.Size(130, 50)
        Me.BtnProUnico.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnProUnico.TabIndex = 56
        Me.BtnProUnico.Text = "Generar Reporte " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "De Un Proyecto" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'BtnGenerarReport
        '
        Me.BtnGenerarReport.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnGenerarReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnGenerarReport.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.BtnGenerarReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.BtnGenerarReport.Location = New System.Drawing.Point(173, 6)
        Me.BtnGenerarReport.Name = "BtnGenerarReport"
        Me.BtnGenerarReport.Size = New System.Drawing.Size(130, 50)
        Me.BtnGenerarReport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnGenerarReport.TabIndex = 55
        Me.BtnGenerarReport.Text = "Generar Lista " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Proyectos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'BtnLoadTable
        '
        Me.BtnLoadTable.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnLoadTable.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnLoadTable.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.BtnLoadTable.FadeEffect = False
        Me.BtnLoadTable.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLoadTable.Image = Global.AppImelsa.My.Resources.Resources.Icp
        Me.BtnLoadTable.Location = New System.Drawing.Point(6, 6)
        Me.BtnLoadTable.Name = "BtnLoadTable"
        Me.BtnLoadTable.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.BtnLoadTable.Size = New System.Drawing.Size(130, 50)
        Me.BtnLoadTable.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013
        Me.BtnLoadTable.TabIndex = 30
        Me.BtnLoadTable.Text = "Refrescar"
        Me.BtnLoadTable.TextColor = System.Drawing.Color.Black
        '
        'BtnDeleteEmployed
        '
        Me.BtnDeleteEmployed.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnDeleteEmployed.BackColor = System.Drawing.Color.Red
        Me.BtnDeleteEmployed.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.BtnDeleteEmployed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDeleteEmployed.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeleteEmployed.Location = New System.Drawing.Point(844, 6)
        Me.BtnDeleteEmployed.Name = "BtnDeleteEmployed"
        Me.BtnDeleteEmployed.Size = New System.Drawing.Size(130, 50)
        Me.BtnDeleteEmployed.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnDeleteEmployed.TabIndex = 28
        Me.BtnDeleteEmployed.Text = "Eliminar"
        '
        'BtnUpdateEmployed
        '
        Me.BtnUpdateEmployed.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnUpdateEmployed.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnUpdateEmployed.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.BtnUpdateEmployed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnUpdateEmployed.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdateEmployed.Location = New System.Drawing.Point(675, 6)
        Me.BtnUpdateEmployed.Name = "BtnUpdateEmployed"
        Me.BtnUpdateEmployed.Size = New System.Drawing.Size(130, 50)
        Me.BtnUpdateEmployed.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnUpdateEmployed.TabIndex = 29
        Me.BtnUpdateEmployed.Text = "Actualizar"
        '
        'BtnNewEmployed
        '
        Me.BtnNewEmployed.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnNewEmployed.BackColor = System.Drawing.Color.Lime
        Me.BtnNewEmployed.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.BtnNewEmployed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNewEmployed.FadeEffect = False
        Me.BtnNewEmployed.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNewEmployed.Location = New System.Drawing.Point(507, 6)
        Me.BtnNewEmployed.Name = "BtnNewEmployed"
        Me.BtnNewEmployed.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.BtnNewEmployed.Size = New System.Drawing.Size(130, 50)
        Me.BtnNewEmployed.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013
        Me.BtnNewEmployed.TabIndex = 22
        Me.BtnNewEmployed.Text = "Nuevo Proyecto"
        Me.BtnNewEmployed.TextColor = System.Drawing.Color.Black
        '
        'Panel3
        '
        Me.Panel3.AutoSize = True
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Panel3.Controls.Add(Me.GroupPanel2)
        Me.Panel3.Controls.Add(Me.LabelX2)
        Me.Panel3.Controls.Add(Me.GroupPanel1)
        Me.Panel3.Controls.Add(Me.TxtBSearch)
        Me.Panel3.Controls.Add(Me.BtnSearch)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.ForeColor = System.Drawing.Color.Black
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.MaximumSize = New System.Drawing.Size(255, 0)
        Me.Panel3.MinimumSize = New System.Drawing.Size(255, 580)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(255, 580)
        Me.Panel3.TabIndex = 66
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
        Me.GroupPanel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.GroupPanel2.Location = New System.Drawing.Point(21, 97)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(211, 132)
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
        Me.RbtnIden.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.RbtnIden.ForeColor = System.Drawing.Color.Black
        Me.RbtnIden.Location = New System.Drawing.Point(21, 52)
        Me.RbtnIden.Name = "RbtnIden"
        Me.RbtnIden.Size = New System.Drawing.Size(67, 20)
        Me.RbtnIden.TabIndex = 3
        Me.RbtnIden.Text = "Cliente"
        Me.RbtnIden.UseVisualStyleBackColor = False
        '
        'RbtnCode
        '
        Me.RbtnCode.AutoSize = True
        Me.RbtnCode.BackColor = System.Drawing.Color.Transparent
        Me.RbtnCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.RbtnCode.ForeColor = System.Drawing.Color.Black
        Me.RbtnCode.Location = New System.Drawing.Point(21, 4)
        Me.RbtnCode.Name = "RbtnCode"
        Me.RbtnCode.Size = New System.Drawing.Size(70, 20)
        Me.RbtnCode.TabIndex = 2
        Me.RbtnCode.Text = "Codigo"
        Me.RbtnCode.UseVisualStyleBackColor = False
        '
        'RbtnName
        '
        Me.RbtnName.AutoSize = True
        Me.RbtnName.BackColor = System.Drawing.Color.Transparent
        Me.RbtnName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.RbtnName.ForeColor = System.Drawing.Color.Black
        Me.RbtnName.Location = New System.Drawing.Point(21, 28)
        Me.RbtnName.Name = "RbtnName"
        Me.RbtnName.Size = New System.Drawing.Size(75, 20)
        Me.RbtnName.TabIndex = 0
        Me.RbtnName.Text = "Nombre"
        Me.RbtnName.UseVisualStyleBackColor = False
        '
        'RbtnAll
        '
        Me.RbtnAll.AutoSize = True
        Me.RbtnAll.BackColor = System.Drawing.Color.Transparent
        Me.RbtnAll.Checked = True
        Me.RbtnAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.RbtnAll.ForeColor = System.Drawing.Color.Black
        Me.RbtnAll.Location = New System.Drawing.Point(21, 76)
        Me.RbtnAll.Name = "RbtnAll"
        Me.RbtnAll.Size = New System.Drawing.Size(90, 20)
        Me.RbtnAll.TabIndex = 1
        Me.RbtnAll.TabStop = True
        Me.RbtnAll.Text = "Ver Todos"
        Me.RbtnAll.UseVisualStyleBackColor = False
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.LabelX2.ForeColor = System.Drawing.Color.Black
        Me.LabelX2.Location = New System.Drawing.Point(8, 47)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(63, 23)
        Me.LabelX2.TabIndex = 15
        Me.LabelX2.Text = "Buscar"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.GroupPanel1.CanvasColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.PanelEx3)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.GroupPanel1.Location = New System.Drawing.Point(21, 275)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(211, 265)
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
        Me.PanelEx3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.PanelEx3.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx3.Margin = New System.Windows.Forms.Padding(5)
        Me.PanelEx3.Name = "PanelEx3"
        Me.PanelEx3.ScrollBarAppearance = DevComponents.DotNetBar.eScrollBarAppearance.ApplicationScroll
        Me.PanelEx3.Size = New System.Drawing.Size(205, 240)
        Me.PanelEx3.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
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
        Me.LabelX5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LabelX5.ForeColor = System.Drawing.Color.Black
        Me.LabelX5.Location = New System.Drawing.Point(19, 183)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(51, 23)
        Me.LabelX5.TabIndex = 19
        Me.LabelX5.Text = "A"
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LabelX6.ForeColor = System.Drawing.Color.Black
        Me.LabelX6.Location = New System.Drawing.Point(19, 154)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(51, 23)
        Me.LabelX6.TabIndex = 18
        Me.LabelX6.Text = "De"
        '
        'LabelX8
        '
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LabelX8.ForeColor = System.Drawing.Color.Black
        Me.LabelX8.Location = New System.Drawing.Point(0, 128)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(132, 23)
        Me.LabelX8.TabIndex = 17
        Me.LabelX8.Text = "Fecha de Culminaci�n"
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
        Me.LabelX4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LabelX4.ForeColor = System.Drawing.Color.Black
        Me.LabelX4.Location = New System.Drawing.Point(19, 99)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(51, 23)
        Me.LabelX4.TabIndex = 14
        Me.LabelX4.Text = "A"
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LabelX3.ForeColor = System.Drawing.Color.Black
        Me.LabelX3.Location = New System.Drawing.Point(19, 70)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(51, 23)
        Me.LabelX3.TabIndex = 13
        Me.LabelX3.Text = "De"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(0, 44)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(109, 23)
        Me.LabelX1.TabIndex = 12
        Me.LabelX1.Text = "Fecha de Inicio"
        '
        'CmBEstado
        '
        Me.CmBEstado.DisplayMember = "Text"
        Me.CmBEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmBEstado.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmBEstado.ForeColor = System.Drawing.Color.Black
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
        Me.LabelX7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LabelX7.ForeColor = System.Drawing.Color.Black
        Me.LabelX7.Location = New System.Drawing.Point(0, 12)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(61, 23)
        Me.LabelX7.TabIndex = 10
        Me.LabelX7.Text = "Estado"
        '
        'TxtBSearch
        '
        Me.TxtBSearch.BackColor = System.Drawing.Color.White
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
        Me.TxtBSearch.ForeColor = System.Drawing.Color.Black
        Me.TxtBSearch.Location = New System.Drawing.Point(72, 49)
        Me.TxtBSearch.Name = "TxtBSearch"
        Me.TxtBSearch.PreventEnterBeep = True
        Me.TxtBSearch.Size = New System.Drawing.Size(129, 22)
        Me.TxtBSearch.TabIndex = 16
        '
        'BtnSearch
        '
        Me.BtnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.BtnSearch.Image = CType(resources.GetObject("BtnSearch.Image"), System.Drawing.Image)
        Me.BtnSearch.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.BtnSearch.Location = New System.Drawing.Point(207, 46)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(25, 27)
        Me.BtnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnSearch.TabIndex = 14
        '
        'Panel4
        '
        Me.Panel4.AutoSize = True
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Panel4.Controls.Add(Me.cont)
        Me.Panel4.Controls.Add(Me.titulo)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.ForeColor = System.Drawing.Color.Black
        Me.Panel4.Location = New System.Drawing.Point(10, 10)
        Me.Panel4.MinimumSize = New System.Drawing.Size(1274, 700)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel4.Size = New System.Drawing.Size(1274, 700)
        Me.Panel4.TabIndex = 64
        '
        'cont
        '
        Me.cont.AutoSize = True
        Me.cont.Controls.Add(Me.Panel5)
        Me.cont.Controls.Add(Me.TableLayoutPanel1)
        Me.cont.Controls.Add(Me.Panel3)
        Me.cont.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cont.Location = New System.Drawing.Point(10, 110)
        Me.cont.MinimumSize = New System.Drawing.Size(1254, 580)
        Me.cont.Name = "cont"
        Me.cont.Size = New System.Drawing.Size(1254, 580)
        Me.cont.TabIndex = 67
        '
        'Panel5
        '
        Me.Panel5.AutoSize = True
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.Controls.Add(Me.GridProyect)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(255, 0)
        Me.Panel5.MinimumSize = New System.Drawing.Size(999, 518)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(999, 518)
        Me.Panel5.TabIndex = 67
        '
        'ProyectForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1294, 720)
        Me.Controls.Add(Me.Panel4)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(5, 5)
        Me.MinimumSize = New System.Drawing.Size(1294, 720)
        Me.Name = "ProyectForm"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Text = "MetroForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.titulo.ResumeLayout(False)
        Me.titulo.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel2.PerformLayout()
        Me.GroupPanel1.ResumeLayout(False)
        Me.PanelEx3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.cont.ResumeLayout(False)
        Me.cont.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents titulo As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ReflectionLabel1 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ReflectionLabel2 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents BtnProUnico As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnGenerarReport As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnLoadTable As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnDeleteEmployed As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnUpdateEmployed As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnNewEmployed As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GridProyect As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents RbtnIden As RadioButton
    Friend WithEvents RbtnCode As RadioButton
    Friend WithEvents RbtnName As RadioButton
    Friend WithEvents RbtnAll As RadioButton
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents PanelEx3 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ChBDateEnd As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents ChBDateInit As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents DinputEnd_2 As DateTimePicker
    Friend WithEvents DinputEnd_1 As DateTimePicker
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents DinputInit_2 As DateTimePicker
    Friend WithEvents DinputInit_1 As DateTimePicker
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents CmBEstado As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TxtBSearch As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents BtnSearch As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Panel4 As Panel
    Friend WithEvents cont As Panel
    Friend WithEvents Panel5 As Panel
End Class

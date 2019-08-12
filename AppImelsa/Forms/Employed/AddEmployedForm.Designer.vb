<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddEmployedForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddEmployedForm))
        Me.BtnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.PSliderEmployed = New DevComponents.DotNetBar.Controls.PageSlider()
        Me.PageSliderPage1 = New DevComponents.DotNetBar.Controls.PageSliderPage()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.LabelX15 = New DevComponents.DotNetBar.LabelX()
        Me.BtnLoadPhoto = New DevComponents.DotNetBar.ButtonX()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DateInputBirth = New System.Windows.Forms.DateTimePicker()
        Me.TxtBCode = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX()
        Me.RbtnMale = New System.Windows.Forms.RadioButton()
        Me.RbtnFemenine = New System.Windows.Forms.RadioButton()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.TxtBAddres = New DevComponents.DotNetBar.Controls.RichTextBoxEx()
        Me.TxtBInss = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TxtBIden = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TxtBLastName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TxtBName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.ReflectionLabel1 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.PageSliderPage2 = New DevComponents.DotNetBar.Controls.PageSliderPage()
        Me.ListBoxProyect = New System.Windows.Forms.ListBox()
        Me.LabelX14 = New DevComponents.DotNetBar.LabelX()
        Me.BtnAddSalario = New DevComponents.DotNetBar.ButtonX()
        Me.ListBoxSalario = New System.Windows.Forms.ListBox()
        Me.LabelX11 = New DevComponents.DotNetBar.LabelX()
        Me.BtnAddCargo = New DevComponents.DotNetBar.ButtonX()
        Me.BtnAddTurn = New DevComponents.DotNetBar.ButtonX()
        Me.ListBoxCargo = New System.Windows.Forms.ListBox()
        Me.LabelX12 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX13 = New DevComponents.DotNetBar.LabelX()
        Me.CmBTurno = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ReflectionLabel3 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.PageSliderPage3 = New DevComponents.DotNetBar.Controls.PageSliderPage()
        Me.BtnRemoveEmail = New DevComponents.DotNetBar.ButtonX()
        Me.BtnRemovePhone = New DevComponents.DotNetBar.ButtonX()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.ListBoxEmail = New DevComponents.DotNetBar.ListBoxAdv()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.ListBoxTel = New DevComponents.DotNetBar.ListBoxAdv()
        Me.TxtBEmail = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TxtBPhone = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.BtnAddEmail = New DevComponents.DotNetBar.ButtonX()
        Me.BtnAddPhone = New DevComponents.DotNetBar.ButtonX()
        Me.ReflectionLabel2 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.BtnAccept = New DevComponents.DotNetBar.ButtonX()
        Me.BtnBack = New DevComponents.DotNetBar.ButtonX()
        Me.BtnNext = New DevComponents.DotNetBar.ButtonX()
        Me.ProgressSteps1 = New DevComponents.DotNetBar.ProgressSteps()
        Me.ProgressOne = New DevComponents.DotNetBar.StepItem()
        Me.ProgressTwo = New DevComponents.DotNetBar.StepItem()
        Me.ProgressTree = New DevComponents.DotNetBar.StepItem()
        Me.SuperValidator1 = New DevComponents.DotNetBar.Validator.SuperValidator()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter()
        Me.labelItem1 = New DevComponents.DotNetBar.LabelItem()
        Me.CProgress = New DevComponents.DotNetBar.CircularProgressItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.PSliderEmployed.SuspendLayout()
        Me.PageSliderPage1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PageSliderPage2.SuspendLayout()
        Me.PageSliderPage3.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnCancel
        '
        Me.BtnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnCancel.BackColor = System.Drawing.Color.LightSkyBlue
        Me.BtnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnCancel.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.Location = New System.Drawing.Point(532, 385)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnCancel.TabIndex = 13
        Me.BtnCancel.Text = "Cancelar"
        '
        'PSliderEmployed
        '
        Me.PSliderEmployed.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.PSliderEmployed.Controls.Add(Me.PageSliderPage1)
        Me.PSliderEmployed.Controls.Add(Me.PageSliderPage2)
        Me.PSliderEmployed.Controls.Add(Me.PageSliderPage3)
        Me.PSliderEmployed.ForeColor = System.Drawing.Color.Black
        Me.PSliderEmployed.Location = New System.Drawing.Point(12, 43)
        Me.PSliderEmployed.MouseDragEnabled = False
        Me.PSliderEmployed.Name = "PSliderEmployed"
        Me.PSliderEmployed.NextPageVisibleMargin = 0
        Me.PSliderEmployed.PageMouseDragEnabled = False
        Me.PSliderEmployed.ScrollBarVisibility = DevComponents.DotNetBar.Controls.eScrollBarVisibility.Hidden
        Me.PSliderEmployed.SelectedPage = Me.PageSliderPage3
        Me.PSliderEmployed.Size = New System.Drawing.Size(805, 331)
        Me.PSliderEmployed.TabIndex = 11
        Me.PSliderEmployed.Text = "PageSlider1"
        Me.PSliderEmployed.TouchEnabled = DevComponents.DotNetBar.Controls.eTouchHandling.No
        '
        'PageSliderPage1
        '
        Me.PageSliderPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.PageSliderPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PageSliderPage1.Controls.Add(Me.ComboBox1)
        Me.PageSliderPage1.Controls.Add(Me.LabelX15)
        Me.PageSliderPage1.Controls.Add(Me.BtnLoadPhoto)
        Me.PageSliderPage1.Controls.Add(Me.PictureBox1)
        Me.PageSliderPage1.Controls.Add(Me.DateInputBirth)
        Me.PageSliderPage1.Controls.Add(Me.TxtBCode)
        Me.PageSliderPage1.Controls.Add(Me.LabelX5)
        Me.PageSliderPage1.Controls.Add(Me.LabelX10)
        Me.PageSliderPage1.Controls.Add(Me.RbtnMale)
        Me.PageSliderPage1.Controls.Add(Me.RbtnFemenine)
        Me.PageSliderPage1.Controls.Add(Me.LabelX7)
        Me.PageSliderPage1.Controls.Add(Me.TxtBAddres)
        Me.PageSliderPage1.Controls.Add(Me.TxtBInss)
        Me.PageSliderPage1.Controls.Add(Me.TxtBIden)
        Me.PageSliderPage1.Controls.Add(Me.TxtBLastName)
        Me.PageSliderPage1.Controls.Add(Me.TxtBName)
        Me.PageSliderPage1.Controls.Add(Me.LabelX6)
        Me.PageSliderPage1.Controls.Add(Me.LabelX3)
        Me.PageSliderPage1.Controls.Add(Me.LabelX2)
        Me.PageSliderPage1.Controls.Add(Me.LabelX1)
        Me.PageSliderPage1.Controls.Add(Me.ReflectionLabel1)
        Me.PageSliderPage1.ForeColor = System.Drawing.Color.Black
        Me.PageSliderPage1.Location = New System.Drawing.Point(-1590, 8)
        Me.PageSliderPage1.Name = "PageSliderPage1"
        Me.PageSliderPage1.Size = New System.Drawing.Size(749, 319)
        Me.PageSliderPage1.TabIndex = 3
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.ComboBox1.ForeColor = System.Drawing.Color.Black
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(98, 225)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(144, 21)
        Me.ComboBox1.TabIndex = 173
        '
        'LabelX15
        '
        Me.LabelX15.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX15.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX15.ForeColor = System.Drawing.Color.Black
        Me.LabelX15.Location = New System.Drawing.Point(17, 225)
        Me.LabelX15.Name = "LabelX15"
        Me.LabelX15.Size = New System.Drawing.Size(75, 23)
        Me.LabelX15.TabIndex = 172
        Me.LabelX15.Text = "Escolaridad"
        '
        'BtnLoadPhoto
        '
        Me.BtnLoadPhoto.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnLoadPhoto.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLoadPhoto.Location = New System.Drawing.Point(660, 118)
        Me.BtnLoadPhoto.Name = "BtnLoadPhoto"
        Me.BtnLoadPhoto.Size = New System.Drawing.Size(51, 18)
        Me.BtnLoadPhoto.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnLoadPhoto.TabIndex = 171
        Me.BtnLoadPhoto.Text = "Cargar"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.ForeColor = System.Drawing.Color.Black
        Me.PictureBox1.Location = New System.Drawing.Point(640, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(89, 96)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 170
        Me.PictureBox1.TabStop = False
        '
        'DateInputBirth
        '
        Me.DateInputBirth.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.DateInputBirth.CalendarMonthBackground = System.Drawing.Color.Aquamarine
        Me.DateInputBirth.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateInputBirth.ForeColor = System.Drawing.Color.Black
        Me.DateInputBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Highlighter1.SetHighlightOnFocus(Me.DateInputBirth, True)
        Me.DateInputBirth.Location = New System.Drawing.Point(286, 78)
        Me.DateInputBirth.Name = "DateInputBirth"
        Me.DateInputBirth.Size = New System.Drawing.Size(170, 20)
        Me.DateInputBirth.TabIndex = 169
        '
        'TxtBCode
        '
        '
        '
        '
        Me.TxtBCode.Border.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial
        Me.TxtBCode.Border.Class = "TextBoxBorder"
        Me.TxtBCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtBCode.DisabledBackColor = System.Drawing.Color.White
        Me.TxtBCode.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBCode.Location = New System.Drawing.Point(98, 71)
        Me.TxtBCode.Name = "TxtBCode"
        Me.TxtBCode.PreventEnterBeep = True
        Me.TxtBCode.Size = New System.Drawing.Size(144, 22)
        Me.TxtBCode.TabIndex = 168
        Me.TxtBCode.Text = "C2013-0001"
        Me.TxtBCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.LabelX5.Location = New System.Drawing.Point(36, 71)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(50, 23)
        Me.LabelX5.TabIndex = 167
        Me.LabelX5.Text = "Codigo"
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
        Me.LabelX10.Location = New System.Drawing.Point(286, 113)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.Size = New System.Drawing.Size(89, 23)
        Me.LabelX10.TabIndex = 166
        Me.LabelX10.Text = "Sexo/Genero"
        '
        'RbtnMale
        '
        Me.RbtnMale.AutoSize = True
        Me.RbtnMale.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.RbtnMale.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbtnMale.ForeColor = System.Drawing.Color.Black
        Me.RbtnMale.Location = New System.Drawing.Point(369, 142)
        Me.RbtnMale.Name = "RbtnMale"
        Me.RbtnMale.Size = New System.Drawing.Size(66, 22)
        Me.RbtnMale.TabIndex = 165
        Me.RbtnMale.Text = "Masculino"
        Me.RbtnMale.UseVisualStyleBackColor = False
        '
        'RbtnFemenine
        '
        Me.RbtnFemenine.AutoSize = True
        Me.RbtnFemenine.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.RbtnFemenine.Checked = True
        Me.RbtnFemenine.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RbtnFemenine.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbtnFemenine.ForeColor = System.Drawing.Color.Black
        Me.RbtnFemenine.Location = New System.Drawing.Point(298, 142)
        Me.RbtnFemenine.Name = "RbtnFemenine"
        Me.RbtnFemenine.Size = New System.Drawing.Size(65, 22)
        Me.RbtnFemenine.TabIndex = 164
        Me.RbtnFemenine.TabStop = True
        Me.RbtnFemenine.Text = "Femenino"
        Me.RbtnFemenine.UseVisualStyleBackColor = False
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
        Me.LabelX7.Location = New System.Drawing.Point(286, 52)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(140, 23)
        Me.LabelX7.TabIndex = 163
        Me.LabelX7.Text = "Fecha de Nacimiento"
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
        Me.Highlighter1.SetHighlightOnFocus(Me.TxtBAddres, True)
        Me.TxtBAddres.Location = New System.Drawing.Point(286, 201)
        Me.TxtBAddres.MaxLength = 133
        Me.TxtBAddres.Name = "TxtBAddres"
        Me.TxtBAddres.Rtf = "{\rtf1\ansi\ansicpg1252\deff0\deflang19466{\fonttbl{\f0\fnil\fcharset0 Arial Narr" &
    "ow;}}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "\viewkind4\uc1\pard\f0\fs20\par" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.TxtBAddres.Size = New System.Drawing.Size(223, 49)
        Me.TxtBAddres.TabIndex = 162
        '
        'TxtBInss
        '
        Me.TxtBInss.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        '
        '
        '
        Me.TxtBInss.Border.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial
        Me.TxtBInss.Border.Class = "TextBoxBorder"
        Me.TxtBInss.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtBInss.DisabledBackColor = System.Drawing.Color.White
        Me.TxtBInss.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Highlighter1.SetHighlightOnFocus(Me.TxtBInss, True)
        Me.TxtBInss.Location = New System.Drawing.Point(98, 222)
        Me.TxtBInss.MaxLength = 9
        Me.TxtBInss.Name = "TxtBInss"
        Me.TxtBInss.PreventEnterBeep = True
        Me.TxtBInss.Size = New System.Drawing.Size(144, 22)
        Me.TxtBInss.TabIndex = 161
        '
        'TxtBIden
        '
        Me.TxtBIden.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        '
        '
        '
        Me.TxtBIden.Border.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial
        Me.TxtBIden.Border.Class = "TextBoxBorder"
        Me.TxtBIden.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtBIden.DisabledBackColor = System.Drawing.Color.White
        Me.TxtBIden.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Highlighter1.SetHighlightOnFocus(Me.TxtBIden, True)
        Me.TxtBIden.Location = New System.Drawing.Point(98, 181)
        Me.TxtBIden.MaxLength = 19
        Me.TxtBIden.Name = "TxtBIden"
        Me.TxtBIden.PreventEnterBeep = True
        Me.TxtBIden.Size = New System.Drawing.Size(144, 22)
        Me.TxtBIden.TabIndex = 160
        '
        'TxtBLastName
        '
        Me.TxtBLastName.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        '
        '
        '
        Me.TxtBLastName.Border.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial
        Me.TxtBLastName.Border.Class = "TextBoxBorder"
        Me.TxtBLastName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtBLastName.DisabledBackColor = System.Drawing.Color.White
        Me.TxtBLastName.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Highlighter1.SetHighlightOnFocus(Me.TxtBLastName, True)
        Me.TxtBLastName.Location = New System.Drawing.Point(98, 145)
        Me.TxtBLastName.MaxLength = 40
        Me.TxtBLastName.Name = "TxtBLastName"
        Me.TxtBLastName.PreventEnterBeep = True
        Me.TxtBLastName.Size = New System.Drawing.Size(144, 22)
        Me.TxtBLastName.TabIndex = 159
        '
        'TxtBName
        '
        Me.TxtBName.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        '
        '
        '
        Me.TxtBName.Border.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial
        Me.TxtBName.Border.Class = "TextBoxBorder"
        Me.TxtBName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtBName.DisabledBackColor = System.Drawing.Color.White
        Me.TxtBName.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Highlighter1.SetHighlightOnFocus(Me.TxtBName, True)
        Me.TxtBName.Location = New System.Drawing.Point(98, 107)
        Me.TxtBName.MaxLength = 90
        Me.TxtBName.Name = "TxtBName"
        Me.TxtBName.PreventEnterBeep = True
        Me.TxtBName.Size = New System.Drawing.Size(144, 22)
        Me.TxtBName.TabIndex = 158
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
        Me.LabelX6.Location = New System.Drawing.Point(286, 174)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(77, 23)
        Me.LabelX6.TabIndex = 157
        Me.LabelX6.Text = "Dirección"
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
        Me.LabelX3.Location = New System.Drawing.Point(36, 181)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(50, 23)
        Me.LabelX3.TabIndex = 155
        Me.LabelX3.Text = "Cedula"
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
        Me.LabelX2.Location = New System.Drawing.Point(36, 143)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(56, 23)
        Me.LabelX2.TabIndex = 154
        Me.LabelX2.Text = "Apellido"
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
        Me.LabelX1.Location = New System.Drawing.Point(36, 105)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(56, 23)
        Me.LabelX1.TabIndex = 153
        Me.LabelX1.Text = "Nombre"
        '
        'ReflectionLabel1
        '
        Me.ReflectionLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        '
        '
        '
        Me.ReflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionLabel1.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReflectionLabel1.ForeColor = System.Drawing.Color.Black
        Me.ReflectionLabel1.Location = New System.Drawing.Point(12, 4)
        Me.ReflectionLabel1.Name = "ReflectionLabel1"
        Me.ReflectionLabel1.Size = New System.Drawing.Size(143, 42)
        Me.ReflectionLabel1.TabIndex = 152
        Me.ReflectionLabel1.Text = "<b><font size="" +6""><i>Datos</i><font color=""#003333""> Generales</font></font></b>" &
    ""
        '
        'PageSliderPage2
        '
        Me.PageSliderPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.PageSliderPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PageSliderPage2.Controls.Add(Me.ListBoxProyect)
        Me.PageSliderPage2.Controls.Add(Me.LabelX14)
        Me.PageSliderPage2.Controls.Add(Me.BtnAddSalario)
        Me.PageSliderPage2.Controls.Add(Me.ListBoxSalario)
        Me.PageSliderPage2.Controls.Add(Me.LabelX11)
        Me.PageSliderPage2.Controls.Add(Me.BtnAddCargo)
        Me.PageSliderPage2.Controls.Add(Me.BtnAddTurn)
        Me.PageSliderPage2.Controls.Add(Me.ListBoxCargo)
        Me.PageSliderPage2.Controls.Add(Me.LabelX12)
        Me.PageSliderPage2.Controls.Add(Me.LabelX13)
        Me.PageSliderPage2.Controls.Add(Me.CmBTurno)
        Me.PageSliderPage2.Controls.Add(Me.ReflectionLabel3)
        Me.PageSliderPage2.ForeColor = System.Drawing.Color.Black
        Me.PageSliderPage2.Location = New System.Drawing.Point(-793, 8)
        Me.PageSliderPage2.Name = "PageSliderPage2"
        Me.PageSliderPage2.Size = New System.Drawing.Size(749, 319)
        Me.PageSliderPage2.TabIndex = 6
        '
        'ListBoxProyect
        '
        Me.ListBoxProyect.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.ListBoxProyect.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxProyect.ForeColor = System.Drawing.Color.Black
        Me.ListBoxProyect.FormattingEnabled = True
        Me.ListBoxProyect.ItemHeight = 16
        Me.ListBoxProyect.Location = New System.Drawing.Point(442, 66)
        Me.ListBoxProyect.Name = "ListBoxProyect"
        Me.ListBoxProyect.Size = New System.Drawing.Size(150, 84)
        Me.ListBoxProyect.TabIndex = 164
        '
        'LabelX14
        '
        Me.LabelX14.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX14.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX14.ForeColor = System.Drawing.Color.Black
        Me.LabelX14.Location = New System.Drawing.Point(347, 62)
        Me.LabelX14.Name = "LabelX14"
        Me.LabelX14.Size = New System.Drawing.Size(89, 23)
        Me.LabelX14.TabIndex = 163
        Me.LabelX14.Text = "Asignar Proyecto"
        '
        'BtnAddSalario
        '
        Me.BtnAddSalario.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnAddSalario.BackColor = System.Drawing.Color.SeaGreen
        Me.BtnAddSalario.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.BtnAddSalario.Image = CType(resources.GetObject("BtnAddSalario.Image"), System.Drawing.Image)
        Me.BtnAddSalario.Location = New System.Drawing.Point(598, 165)
        Me.BtnAddSalario.Name = "BtnAddSalario"
        Me.BtnAddSalario.Size = New System.Drawing.Size(22, 21)
        Me.BtnAddSalario.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnAddSalario.TabIndex = 162
        '
        'ListBoxSalario
        '
        Me.ListBoxSalario.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.ListBoxSalario.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxSalario.ForeColor = System.Drawing.Color.Black
        Me.ListBoxSalario.FormattingEnabled = True
        Me.ListBoxSalario.ItemHeight = 16
        Me.ListBoxSalario.Location = New System.Drawing.Point(442, 165)
        Me.ListBoxSalario.Name = "ListBoxSalario"
        Me.ListBoxSalario.Size = New System.Drawing.Size(150, 100)
        Me.ListBoxSalario.TabIndex = 161
        '
        'LabelX11
        '
        Me.LabelX11.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX11.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX11.ForeColor = System.Drawing.Color.Black
        Me.LabelX11.Location = New System.Drawing.Point(347, 161)
        Me.LabelX11.Name = "LabelX11"
        Me.LabelX11.Size = New System.Drawing.Size(71, 23)
        Me.LabelX11.TabIndex = 160
        Me.LabelX11.Text = "Salario Base"
        '
        'BtnAddCargo
        '
        Me.BtnAddCargo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnAddCargo.BackColor = System.Drawing.Color.SeaGreen
        Me.BtnAddCargo.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.BtnAddCargo.Image = CType(resources.GetObject("BtnAddCargo.Image"), System.Drawing.Image)
        Me.BtnAddCargo.Location = New System.Drawing.Point(256, 130)
        Me.BtnAddCargo.Name = "BtnAddCargo"
        Me.BtnAddCargo.Size = New System.Drawing.Size(22, 21)
        Me.BtnAddCargo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnAddCargo.TabIndex = 159
        '
        'BtnAddTurn
        '
        Me.BtnAddTurn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnAddTurn.BackColor = System.Drawing.Color.SeaGreen
        Me.BtnAddTurn.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.BtnAddTurn.Image = CType(resources.GetObject("BtnAddTurn.Image"), System.Drawing.Image)
        Me.BtnAddTurn.Location = New System.Drawing.Point(256, 72)
        Me.BtnAddTurn.Name = "BtnAddTurn"
        Me.BtnAddTurn.Size = New System.Drawing.Size(22, 21)
        Me.BtnAddTurn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnAddTurn.TabIndex = 158
        '
        'ListBoxCargo
        '
        Me.ListBoxCargo.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.ListBoxCargo.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxCargo.ForeColor = System.Drawing.Color.Black
        Me.ListBoxCargo.FormattingEnabled = True
        Me.ListBoxCargo.ItemHeight = 16
        Me.ListBoxCargo.Location = New System.Drawing.Point(110, 130)
        Me.ListBoxCargo.Name = "ListBoxCargo"
        Me.ListBoxCargo.Size = New System.Drawing.Size(140, 116)
        Me.ListBoxCargo.TabIndex = 157
        '
        'LabelX12
        '
        Me.LabelX12.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX12.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX12.ForeColor = System.Drawing.Color.Black
        Me.LabelX12.Location = New System.Drawing.Point(75, 70)
        Me.LabelX12.Name = "LabelX12"
        Me.LabelX12.Size = New System.Drawing.Size(29, 23)
        Me.LabelX12.TabIndex = 154
        Me.LabelX12.Text = "Turno"
        '
        'LabelX13
        '
        Me.LabelX13.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX13.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX13.ForeColor = System.Drawing.Color.Black
        Me.LabelX13.Location = New System.Drawing.Point(75, 127)
        Me.LabelX13.Name = "LabelX13"
        Me.LabelX13.Size = New System.Drawing.Size(43, 23)
        Me.LabelX13.TabIndex = 156
        Me.LabelX13.Text = "Cargo"
        '
        'CmBTurno
        '
        Me.CmBTurno.DisplayMember = "Text"
        Me.CmBTurno.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmBTurno.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmBTurno.FormattingEnabled = True
        Me.CmBTurno.ItemHeight = 16
        Me.CmBTurno.Location = New System.Drawing.Point(110, 71)
        Me.CmBTurno.Name = "CmBTurno"
        Me.CmBTurno.Size = New System.Drawing.Size(140, 22)
        Me.CmBTurno.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CmBTurno.TabIndex = 155
        '
        'ReflectionLabel3
        '
        Me.ReflectionLabel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        '
        '
        '
        Me.ReflectionLabel3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionLabel3.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReflectionLabel3.ForeColor = System.Drawing.Color.Black
        Me.ReflectionLabel3.Location = New System.Drawing.Point(12, 4)
        Me.ReflectionLabel3.Name = "ReflectionLabel3"
        Me.ReflectionLabel3.Size = New System.Drawing.Size(143, 42)
        Me.ReflectionLabel3.TabIndex = 153
        Me.ReflectionLabel3.Text = "<b><font size="" +6""><i>Datos</i><font color=""#003333""> Laborales</font></font></b>" &
    ""
        '
        'PageSliderPage3
        '
        Me.PageSliderPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.PageSliderPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PageSliderPage3.Controls.Add(Me.BtnRemoveEmail)
        Me.PageSliderPage3.Controls.Add(Me.BtnRemovePhone)
        Me.PageSliderPage3.Controls.Add(Me.GroupPanel2)
        Me.PageSliderPage3.Controls.Add(Me.GroupPanel1)
        Me.PageSliderPage3.Controls.Add(Me.TxtBEmail)
        Me.PageSliderPage3.Controls.Add(Me.TxtBPhone)
        Me.PageSliderPage3.Controls.Add(Me.LabelX9)
        Me.PageSliderPage3.Controls.Add(Me.LabelX8)
        Me.PageSliderPage3.Controls.Add(Me.BtnAddEmail)
        Me.PageSliderPage3.Controls.Add(Me.BtnAddPhone)
        Me.PageSliderPage3.Controls.Add(Me.ReflectionLabel2)
        Me.PageSliderPage3.ForeColor = System.Drawing.Color.Black
        Me.PageSliderPage3.Location = New System.Drawing.Point(4, 8)
        Me.PageSliderPage3.Name = "PageSliderPage3"
        Me.PageSliderPage3.Size = New System.Drawing.Size(749, 319)
        Me.PageSliderPage3.TabIndex = 5
        '
        'BtnRemoveEmail
        '
        Me.BtnRemoveEmail.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnRemoveEmail.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnRemoveEmail.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRemoveEmail.Image = CType(resources.GetObject("BtnRemoveEmail.Image"), System.Drawing.Image)
        Me.BtnRemoveEmail.Location = New System.Drawing.Point(441, 261)
        Me.BtnRemoveEmail.Name = "BtnRemoveEmail"
        Me.BtnRemoveEmail.Size = New System.Drawing.Size(72, 23)
        Me.BtnRemoveEmail.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnRemoveEmail.TabIndex = 163
        Me.BtnRemoveEmail.Text = "Remover"
        '
        'BtnRemovePhone
        '
        Me.BtnRemovePhone.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnRemovePhone.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnRemovePhone.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRemovePhone.Image = CType(resources.GetObject("BtnRemovePhone.Image"), System.Drawing.Image)
        Me.BtnRemovePhone.Location = New System.Drawing.Point(112, 259)
        Me.BtnRemovePhone.Name = "BtnRemovePhone"
        Me.BtnRemovePhone.Size = New System.Drawing.Size(72, 23)
        Me.BtnRemovePhone.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnRemovePhone.TabIndex = 162
        Me.BtnRemovePhone.Text = "Remover"
        '
        'GroupPanel2
        '
        Me.GroupPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.GroupPanel2.CanvasColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2013
        Me.GroupPanel2.Controls.Add(Me.ListBoxEmail)
        Me.GroupPanel2.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel2.DrawTitleBox = False
        Me.GroupPanel2.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel2.Location = New System.Drawing.Point(381, 87)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(216, 168)
        '
        '
        '
        Me.GroupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel2.Style.BackColorGradientAngle = 90
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
        Me.GroupPanel2.TabIndex = 161
        Me.GroupPanel2.Text = "Emails"
        '
        'ListBoxEmail
        '
        Me.ListBoxEmail.AutoScroll = True
        Me.ListBoxEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        '
        '
        '
        Me.ListBoxEmail.BackgroundStyle.BackColor = System.Drawing.Color.White
        Me.ListBoxEmail.BackgroundStyle.Class = "ListBoxAdv"
        Me.ListBoxEmail.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ListBoxEmail.CheckStateMember = Nothing
        Me.ListBoxEmail.ContainerControlProcessDialogKey = True
        Me.ListBoxEmail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBoxEmail.DragDropSupport = True
        Me.ListBoxEmail.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxEmail.ForeColor = System.Drawing.Color.Black
        Me.ListBoxEmail.Location = New System.Drawing.Point(0, 0)
        Me.ListBoxEmail.Name = "ListBoxEmail"
        Me.ListBoxEmail.Size = New System.Drawing.Size(210, 142)
        Me.ListBoxEmail.TabIndex = 2
        Me.ListBoxEmail.Text = "ListBoxAdv1"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.GroupPanel1.CanvasColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2013
        Me.GroupPanel1.Controls.Add(Me.ListBoxTel)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.DrawTitleBox = False
        Me.GroupPanel1.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel1.Location = New System.Drawing.Point(63, 85)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(172, 168)
        '
        '
        '
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
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
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 157
        Me.GroupPanel1.Text = "Telefonos"
        '
        'ListBoxTel
        '
        Me.ListBoxTel.AutoScroll = True
        Me.ListBoxTel.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        '
        '
        '
        Me.ListBoxTel.BackgroundStyle.BackColor = System.Drawing.Color.White
        Me.ListBoxTel.BackgroundStyle.Class = "ListBoxAdv"
        Me.ListBoxTel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ListBoxTel.CheckStateMember = Nothing
        Me.ListBoxTel.ContainerControlProcessDialogKey = True
        Me.ListBoxTel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBoxTel.DragDropSupport = True
        Me.ListBoxTel.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxTel.ForeColor = System.Drawing.Color.Black
        Me.ListBoxTel.Location = New System.Drawing.Point(0, 0)
        Me.ListBoxTel.Name = "ListBoxTel"
        Me.ListBoxTel.Size = New System.Drawing.Size(166, 142)
        Me.ListBoxTel.TabIndex = 2
        Me.ListBoxTel.Text = "ListBoxAdv1"
        '
        'TxtBEmail
        '
        '
        '
        '
        Me.TxtBEmail.Border.Class = "TextBoxBorder"
        Me.TxtBEmail.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtBEmail.DisabledBackColor = System.Drawing.Color.White
        Me.TxtBEmail.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBEmail.Location = New System.Drawing.Point(419, 58)
        Me.TxtBEmail.MaxLength = 30
        Me.TxtBEmail.Name = "TxtBEmail"
        Me.TxtBEmail.PreventEnterBeep = True
        Me.TxtBEmail.Size = New System.Drawing.Size(100, 22)
        Me.TxtBEmail.TabIndex = 160
        '
        'TxtBPhone
        '
        '
        '
        '
        Me.TxtBPhone.Border.Class = "TextBoxBorder"
        Me.TxtBPhone.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtBPhone.DisabledBackColor = System.Drawing.Color.White
        Me.TxtBPhone.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBPhone.Location = New System.Drawing.Point(118, 57)
        Me.TxtBPhone.Name = "TxtBPhone"
        Me.TxtBPhone.PreventEnterBeep = True
        Me.TxtBPhone.Size = New System.Drawing.Size(100, 22)
        Me.TxtBPhone.TabIndex = 156
        '
        'LabelX9
        '
        Me.LabelX9.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX9.ForeColor = System.Drawing.Color.Black
        Me.LabelX9.Location = New System.Drawing.Point(359, 57)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(54, 23)
        Me.LabelX9.TabIndex = 159
        Me.LabelX9.Text = "Dir. Email"
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
        Me.LabelX8.Location = New System.Drawing.Point(44, 56)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(68, 23)
        Me.LabelX8.TabIndex = 155
        Me.LabelX8.Text = "N° Telefonico"
        '
        'BtnAddEmail
        '
        Me.BtnAddEmail.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnAddEmail.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnAddEmail.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddEmail.Image = CType(resources.GetObject("BtnAddEmail.Image"), System.Drawing.Image)
        Me.BtnAddEmail.Location = New System.Drawing.Point(525, 57)
        Me.BtnAddEmail.Name = "BtnAddEmail"
        Me.BtnAddEmail.Size = New System.Drawing.Size(72, 23)
        Me.BtnAddEmail.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnAddEmail.TabIndex = 158
        Me.BtnAddEmail.Text = "Agregar"
        '
        'BtnAddPhone
        '
        Me.BtnAddPhone.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnAddPhone.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnAddPhone.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddPhone.Image = CType(resources.GetObject("BtnAddPhone.Image"), System.Drawing.Image)
        Me.BtnAddPhone.Location = New System.Drawing.Point(224, 55)
        Me.BtnAddPhone.Name = "BtnAddPhone"
        Me.BtnAddPhone.Size = New System.Drawing.Size(72, 23)
        Me.BtnAddPhone.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnAddPhone.TabIndex = 154
        Me.BtnAddPhone.Text = "Agregar"
        '
        'ReflectionLabel2
        '
        Me.ReflectionLabel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        '
        '
        '
        Me.ReflectionLabel2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionLabel2.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReflectionLabel2.ForeColor = System.Drawing.Color.Black
        Me.ReflectionLabel2.Location = New System.Drawing.Point(16, 5)
        Me.ReflectionLabel2.Name = "ReflectionLabel2"
        Me.ReflectionLabel2.Size = New System.Drawing.Size(175, 42)
        Me.ReflectionLabel2.TabIndex = 153
        Me.ReflectionLabel2.Text = "<b><font size="" +6""><i>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "</i><font color=""#003333""> Contactos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "</font></font></b>"
        '
        'BtnAccept
        '
        Me.BtnAccept.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnAccept.BackColor = System.Drawing.Color.LightSkyBlue
        Me.BtnAccept.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnAccept.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAccept.Location = New System.Drawing.Point(775, 385)
        Me.BtnAccept.Name = "BtnAccept"
        Me.BtnAccept.Size = New System.Drawing.Size(75, 23)
        Me.BtnAccept.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnAccept.TabIndex = 10
        Me.BtnAccept.Text = "Aceptar"
        '
        'BtnBack
        '
        Me.BtnBack.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnBack.BackColor = System.Drawing.Color.LightSkyBlue
        Me.BtnBack.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnBack.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBack.Location = New System.Drawing.Point(613, 385)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(75, 23)
        Me.BtnBack.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnBack.TabIndex = 9
        Me.BtnBack.Text = "Atras"
        '
        'BtnNext
        '
        Me.BtnNext.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnNext.BackColor = System.Drawing.Color.LightSkyBlue
        Me.BtnNext.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnNext.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNext.Location = New System.Drawing.Point(694, 385)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(75, 23)
        Me.BtnNext.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnNext.TabIndex = 8
        Me.BtnNext.Text = "Siguiente"
        '
        'ProgressSteps1
        '
        Me.ProgressSteps1.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        '
        '
        '
        Me.ProgressSteps1.BackgroundStyle.Class = "ProgressSteps"
        Me.ProgressSteps1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ProgressSteps1.ContainerControlProcessDialogKey = True
        Me.ProgressSteps1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ProgressSteps1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProgressSteps1.ForeColor = System.Drawing.Color.Black
        Me.ProgressSteps1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ProgressOne, Me.ProgressTwo, Me.ProgressTree})
        Me.ProgressSteps1.Location = New System.Drawing.Point(0, 0)
        Me.ProgressSteps1.Name = "ProgressSteps1"
        Me.ProgressSteps1.Size = New System.Drawing.Size(862, 29)
        Me.ProgressSteps1.TabIndex = 7
        '
        'ProgressOne
        '
        Me.ProgressOne.BackColors = New System.Drawing.Color() {System.Drawing.Color.WhiteSmoke, System.Drawing.Color.White}
        Me.ProgressOne.Name = "ProgressOne"
        Me.ProgressOne.Symbol = ""
        Me.ProgressOne.SymbolColor = System.Drawing.Color.DarkSlateGray
        Me.ProgressOne.SymbolSize = 15.0!
        Me.ProgressOne.Text = "Datos  Generales"
        '
        'ProgressTwo
        '
        Me.ProgressTwo.BackColors = New System.Drawing.Color() {System.Drawing.Color.WhiteSmoke, System.Drawing.Color.White}
        Me.ProgressTwo.Name = "ProgressTwo"
        Me.ProgressTwo.Symbol = "59640"
        Me.ProgressTwo.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material
        Me.ProgressTwo.SymbolSize = 15.0!
        Me.ProgressTwo.Text = "Datos LAborales"
        '
        'ProgressTree
        '
        Me.ProgressTree.BackColors = New System.Drawing.Color() {System.Drawing.Color.WhiteSmoke, System.Drawing.Color.White}
        Me.ProgressTree.Name = "ProgressTree"
        Me.ProgressTree.Symbol = "57520"
        Me.ProgressTree.SymbolColor = System.Drawing.Color.DarkSlateGray
        Me.ProgressTree.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material
        Me.ProgressTree.SymbolSize = 15.0!
        Me.ProgressTree.Text = "Contactos"
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
        'labelItem1
        '
        Me.labelItem1.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far
        Me.labelItem1.Name = "labelItem1"
        Me.labelItem1.Text = "Esperando"
        '
        'CProgress
        '
        Me.CProgress.Name = "CProgress"
        Me.CProgress.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Spoke
        Me.CProgress.ProgressColor = System.Drawing.Color.DarkOrange
        Me.CProgress.TextPosition = DevComponents.DotNetBar.eTextPosition.Bottom
        Me.CProgress.Value = 45
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2010Blue
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer)))
        '
        'AddEmployedForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(862, 420)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.PSliderEmployed)
        Me.Controls.Add(Me.BtnAccept)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.BtnNext)
        Me.Controls.Add(Me.ProgressSteps1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "AddEmployedForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo Empleado"
        Me.PSliderEmployed.ResumeLayout(False)
        Me.PageSliderPage1.ResumeLayout(False)
        Me.PageSliderPage1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PageSliderPage2.ResumeLayout(False)
        Me.PageSliderPage3.ResumeLayout(False)
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PSliderEmployed As DevComponents.DotNetBar.Controls.PageSlider
    Friend WithEvents PageSliderPage1 As DevComponents.DotNetBar.Controls.PageSliderPage
    Friend WithEvents ReflectionLabel1 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents PageSliderPage3 As DevComponents.DotNetBar.Controls.PageSliderPage
    Friend WithEvents BtnRemoveEmail As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnRemovePhone As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents ListBoxEmail As DevComponents.DotNetBar.ListBoxAdv
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents ListBoxTel As DevComponents.DotNetBar.ListBoxAdv
    Friend WithEvents TxtBEmail As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TxtBPhone As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents BtnAddEmail As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnAddPhone As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ReflectionLabel2 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents BtnAccept As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnBack As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnNext As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ProgressSteps1 As DevComponents.DotNetBar.ProgressSteps
    Friend WithEvents ProgressOne As DevComponents.DotNetBar.StepItem
    Friend WithEvents ProgressTree As DevComponents.DotNetBar.StepItem
    Friend WithEvents ProgressTwo As DevComponents.DotNetBar.StepItem
    Friend WithEvents PageSliderPage2 As DevComponents.DotNetBar.Controls.PageSliderPage
    Friend WithEvents ReflectionLabel3 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents DateInputBirth As DateTimePicker
    Friend WithEvents TxtBCode As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents RbtnMale As RadioButton
    Friend WithEvents RbtnFemenine As RadioButton
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TxtBAddres As DevComponents.DotNetBar.Controls.RichTextBoxEx
    Friend WithEvents TxtBInss As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TxtBIden As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TxtBLastName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TxtBName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ListBoxProyect As ListBox
    Friend WithEvents LabelX14 As DevComponents.DotNetBar.LabelX
    Friend WithEvents BtnAddSalario As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ListBoxSalario As ListBox
    Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
    Friend WithEvents BtnAddCargo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnAddTurn As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ListBoxCargo As ListBox
    Friend WithEvents LabelX12 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX13 As DevComponents.DotNetBar.LabelX
    Friend WithEvents CmBTurno As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
    Friend WithEvents SuperValidator1 As DevComponents.DotNetBar.Validator.SuperValidator
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Private WithEvents labelItem1 As DevComponents.DotNetBar.LabelItem
    Private WithEvents CProgress As DevComponents.DotNetBar.CircularProgressItem
    Friend WithEvents BtnLoadPhoto As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents LabelX15 As DevComponents.DotNetBar.LabelX
End Class
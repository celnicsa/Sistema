<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddClientForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddClientForm))
        Me.ProgressSteps1 = New DevComponents.DotNetBar.ProgressSteps()
        Me.ProgressOne = New DevComponents.DotNetBar.StepItem()
        Me.ProgressTwo = New DevComponents.DotNetBar.StepItem()
        Me.BtnNext = New DevComponents.DotNetBar.ButtonX()
        Me.BtnBack = New DevComponents.DotNetBar.ButtonX()
        Me.BtnAccept = New DevComponents.DotNetBar.ButtonX()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.PSliderClient = New DevComponents.DotNetBar.Controls.PageSlider()
        Me.PageSliderPage1 = New DevComponents.DotNetBar.Controls.PageSliderPage()
        Me.ReflectionLabel1 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.RbtnRuc = New System.Windows.Forms.RadioButton()
        Me.RbtnCedula = New System.Windows.Forms.RadioButton()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.TxtBAddres = New DevComponents.DotNetBar.Controls.RichTextBoxEx()
        Me.TxtBPerfil = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TxtIden = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TxtBName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.TxtBCode = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
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
        Me.bar1 = New DevComponents.DotNetBar.Bar()
        Me.labelItem1 = New DevComponents.DotNetBar.LabelItem()
        Me.CProgress = New DevComponents.DotNetBar.CircularProgressItem()
        Me.SuperValidator1 = New DevComponents.DotNetBar.Validator.SuperValidator()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter()
        Me.BtnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.PSliderClient.SuspendLayout()
        Me.PageSliderPage1.SuspendLayout()
        Me.PageSliderPage3.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.bar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.ProgressSteps1.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProgressSteps1.ForeColor = System.Drawing.Color.Black
        Me.ProgressSteps1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ProgressOne, Me.ProgressTwo})
        Me.ProgressSteps1.Location = New System.Drawing.Point(0, 0)
        Me.ProgressSteps1.Name = "ProgressSteps1"
        Me.ProgressSteps1.Size = New System.Drawing.Size(862, 37)
        Me.ProgressSteps1.TabIndex = 0
        '
        'ProgressOne
        '
        Me.ProgressOne.BackColors = New System.Drawing.Color() {System.Drawing.Color.Gainsboro, System.Drawing.Color.White}
        Me.ProgressOne.Name = "ProgressOne"
        Me.ProgressOne.Symbol = ""
        Me.ProgressOne.SymbolColor = System.Drawing.Color.DarkSlateGray
        Me.ProgressOne.SymbolSize = 15.0!
        Me.ProgressOne.Text = "Datos  Generales"
        '
        'ProgressTwo
        '
        Me.ProgressTwo.BackColors = New System.Drawing.Color() {System.Drawing.Color.Gainsboro, System.Drawing.Color.White}
        Me.ProgressTwo.Name = "ProgressTwo"
        Me.ProgressTwo.Symbol = "57520"
        Me.ProgressTwo.SymbolColor = System.Drawing.Color.DarkSlateGray
        Me.ProgressTwo.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material
        Me.ProgressTwo.SymbolSize = 15.0!
        Me.ProgressTwo.Text = "Contactos"
        '
        'BtnNext
        '
        Me.BtnNext.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnNext.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnNext.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNext.Location = New System.Drawing.Point(694, 398)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(75, 23)
        Me.BtnNext.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnNext.TabIndex = 1
        Me.BtnNext.Text = "Siguiente"
        '
        'BtnBack
        '
        Me.BtnBack.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnBack.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnBack.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBack.Location = New System.Drawing.Point(613, 398)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(75, 23)
        Me.BtnBack.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnBack.TabIndex = 2
        Me.BtnBack.Text = "Atras"
        '
        'BtnAccept
        '
        Me.BtnAccept.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnAccept.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnAccept.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAccept.Location = New System.Drawing.Point(775, 398)
        Me.BtnAccept.Name = "BtnAccept"
        Me.BtnAccept.Size = New System.Drawing.Size(75, 23)
        Me.BtnAccept.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnAccept.TabIndex = 3
        Me.BtnAccept.Text = "Aceptar"
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2010Blue
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer)))
        '
        'PSliderClient
        '
        Me.PSliderClient.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.PSliderClient.Controls.Add(Me.PageSliderPage1)
        Me.PSliderClient.Controls.Add(Me.PageSliderPage3)
        Me.PSliderClient.ForeColor = System.Drawing.Color.Black
        Me.PSliderClient.Location = New System.Drawing.Point(12, 43)
        Me.PSliderClient.Name = "PSliderClient"
        Me.PSliderClient.NextPageVisibleMargin = 0
        Me.PSliderClient.PageMouseDragEnabled = False
        Me.PSliderClient.ScrollBarVisibility = DevComponents.DotNetBar.Controls.eScrollBarVisibility.Hidden
        Me.PSliderClient.SelectedPage = Me.PageSliderPage1
        Me.PSliderClient.Size = New System.Drawing.Size(805, 349)
        Me.PSliderClient.TabIndex = 4
        Me.PSliderClient.Text = "PageSlider1"
        Me.PSliderClient.TouchEnabled = DevComponents.DotNetBar.Controls.eTouchHandling.No
        '
        'PageSliderPage1
        '
        Me.PageSliderPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.PageSliderPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PageSliderPage1.Controls.Add(Me.ReflectionLabel1)
        Me.PageSliderPage1.Controls.Add(Me.RbtnRuc)
        Me.PageSliderPage1.Controls.Add(Me.RbtnCedula)
        Me.PageSliderPage1.Controls.Add(Me.LabelX3)
        Me.PageSliderPage1.Controls.Add(Me.TxtBAddres)
        Me.PageSliderPage1.Controls.Add(Me.TxtBPerfil)
        Me.PageSliderPage1.Controls.Add(Me.TxtIden)
        Me.PageSliderPage1.Controls.Add(Me.TxtBName)
        Me.PageSliderPage1.Controls.Add(Me.LabelX6)
        Me.PageSliderPage1.Controls.Add(Me.LabelX4)
        Me.PageSliderPage1.Controls.Add(Me.LabelX2)
        Me.PageSliderPage1.Controls.Add(Me.LabelX1)
        Me.PageSliderPage1.Controls.Add(Me.TxtBCode)
        Me.PageSliderPage1.Controls.Add(Me.LabelX5)
        Me.PageSliderPage1.ForeColor = System.Drawing.Color.Black
        Me.PageSliderPage1.Location = New System.Drawing.Point(4, 8)
        Me.PageSliderPage1.Name = "PageSliderPage1"
        Me.PageSliderPage1.Size = New System.Drawing.Size(749, 337)
        Me.PageSliderPage1.TabIndex = 3
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
        Me.ReflectionLabel1.Location = New System.Drawing.Point(17, 5)
        Me.ReflectionLabel1.Name = "ReflectionLabel1"
        Me.ReflectionLabel1.Size = New System.Drawing.Size(143, 42)
        Me.ReflectionLabel1.TabIndex = 152
        Me.ReflectionLabel1.Text = "<b><font size=""+6""><i>Datos</i><font color=""#003333""> Generales</font></font></b>" &
    ""
        '
        'RbtnRuc
        '
        Me.RbtnRuc.AutoSize = True
        Me.RbtnRuc.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.RbtnRuc.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbtnRuc.ForeColor = System.Drawing.Color.Black
        Me.RbtnRuc.Location = New System.Drawing.Point(239, 98)
        Me.RbtnRuc.Name = "RbtnRuc"
        Me.RbtnRuc.Size = New System.Drawing.Size(57, 24)
        Me.RbtnRuc.TabIndex = 148
        Me.RbtnRuc.Text = "N° Ruc"
        Me.RbtnRuc.UseVisualStyleBackColor = False
        '
        'RbtnCedula
        '
        Me.RbtnCedula.AutoSize = True
        Me.RbtnCedula.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.RbtnCedula.Checked = True
        Me.RbtnCedula.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbtnCedula.ForeColor = System.Drawing.Color.Black
        Me.RbtnCedula.Location = New System.Drawing.Point(178, 98)
        Me.RbtnCedula.Name = "RbtnCedula"
        Me.RbtnCedula.Size = New System.Drawing.Size(55, 24)
        Me.RbtnCedula.TabIndex = 147
        Me.RbtnCedula.TabStop = True
        Me.RbtnCedula.Text = "Cedula"
        Me.RbtnCedula.UseVisualStyleBackColor = False
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
        Me.LabelX3.Location = New System.Drawing.Point(62, 98)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(110, 23)
        Me.LabelX3.TabIndex = 149
        Me.LabelX3.Text = "Tipo de Identificación"
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
        Me.TxtBAddres.Location = New System.Drawing.Point(178, 236)
        Me.TxtBAddres.MaxLength = 133
        Me.TxtBAddres.Name = "TxtBAddres"
        Me.TxtBAddres.Rtf = "{\rtf1\ansi\ansicpg1252\deff0\deflang19466{\fonttbl{\f0\fnil\fcharset0 Arial Narr" &
    "ow;}}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "{\colortbl ;\red0\green0\blue0;}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "\viewkind4\uc1\pard\cf1\f0\fs20\par" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.TxtBAddres.Size = New System.Drawing.Size(281, 64)
        Me.TxtBAddres.TabIndex = 151
        '
        'TxtBPerfil
        '
        Me.TxtBPerfil.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        '
        '
        '
        Me.TxtBPerfil.Border.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial
        Me.TxtBPerfil.Border.Class = "TextBoxBorder"
        Me.TxtBPerfil.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtBPerfil.DisabledBackColor = System.Drawing.Color.White
        Me.TxtBPerfil.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Highlighter1.SetHighlightOnFocus(Me.TxtBPerfil, True)
        Me.TxtBPerfil.Location = New System.Drawing.Point(178, 188)
        Me.TxtBPerfil.MaxLength = 80
        Me.TxtBPerfil.Name = "TxtBPerfil"
        Me.TxtBPerfil.PreventEnterBeep = True
        Me.TxtBPerfil.Size = New System.Drawing.Size(202, 22)
        Me.TxtBPerfil.TabIndex = 150
        '
        'TxtIden
        '
        Me.TxtIden.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        '
        '
        '
        Me.TxtIden.Border.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial
        Me.TxtIden.Border.Class = "TextBoxBorder"
        Me.TxtIden.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtIden.DisabledBackColor = System.Drawing.Color.White
        Me.TxtIden.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Highlighter1.SetHighlightOnFocus(Me.TxtIden, True)
        Me.TxtIden.Location = New System.Drawing.Point(178, 141)
        Me.TxtIden.MaxLength = 18
        Me.TxtIden.Name = "TxtIden"
        Me.TxtIden.PreventEnterBeep = True
        Me.TxtIden.Size = New System.Drawing.Size(202, 22)
        Me.TxtIden.TabIndex = 149
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
        Me.TxtBName.Location = New System.Drawing.Point(178, 57)
        Me.TxtBName.MaxLength = 15
        Me.TxtBName.Name = "TxtBName"
        Me.TxtBName.PreventEnterBeep = True
        Me.TxtBName.Size = New System.Drawing.Size(202, 22)
        Me.TxtBName.TabIndex = 146
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
        Me.LabelX6.Location = New System.Drawing.Point(62, 236)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(56, 23)
        Me.LabelX6.TabIndex = 144
        Me.LabelX6.Text = "Dirección"
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
        Me.LabelX4.Location = New System.Drawing.Point(62, 187)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(74, 23)
        Me.LabelX4.TabIndex = 143
        Me.LabelX4.Text = "Mision Social"
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
        Me.LabelX2.Location = New System.Drawing.Point(62, 140)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(74, 23)
        Me.LabelX2.TabIndex = 142
        Me.LabelX2.Text = "Identificación"
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
        Me.LabelX1.Location = New System.Drawing.Point(62, 56)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(98, 23)
        Me.LabelX1.TabIndex = 141
        Me.LabelX1.Text = "Nombre del Cliente"
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
        Me.TxtBCode.Location = New System.Drawing.Point(632, 21)
        Me.TxtBCode.Name = "TxtBCode"
        Me.TxtBCode.PreventEnterBeep = True
        Me.TxtBCode.Size = New System.Drawing.Size(83, 22)
        Me.TxtBCode.TabIndex = 145
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
        Me.LabelX5.Location = New System.Drawing.Point(652, 41)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(50, 23)
        Me.LabelX5.TabIndex = 135
        Me.LabelX5.Text = "Codigo"
        Me.LabelX5.TextAlignment = System.Drawing.StringAlignment.Center
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
        Me.PageSliderPage3.Location = New System.Drawing.Point(801, 8)
        Me.PageSliderPage3.Name = "PageSliderPage3"
        Me.PageSliderPage3.Size = New System.Drawing.Size(749, 337)
        Me.PageSliderPage3.TabIndex = 5
        '
        'BtnRemoveEmail
        '
        Me.BtnRemoveEmail.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnRemoveEmail.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnRemoveEmail.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRemoveEmail.Image = CType(resources.GetObject("BtnRemoveEmail.Image"), System.Drawing.Image)
        Me.BtnRemoveEmail.Location = New System.Drawing.Point(457, 284)
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
        Me.BtnRemovePhone.Location = New System.Drawing.Point(134, 287)
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
        Me.GroupPanel2.Location = New System.Drawing.Point(378, 113)
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
        Me.GroupPanel1.Location = New System.Drawing.Point(83, 113)
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
        Me.Highlighter1.SetHighlightOnFocus(Me.TxtBEmail, True)
        Me.TxtBEmail.Location = New System.Drawing.Point(378, 78)
        Me.TxtBEmail.MaxLength = 30
        Me.TxtBEmail.Name = "TxtBEmail"
        Me.TxtBEmail.PreventEnterBeep = True
        Me.TxtBEmail.Size = New System.Drawing.Size(136, 22)
        Me.TxtBEmail.TabIndex = 153
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
        Me.Highlighter1.SetHighlightOnFocus(Me.TxtBPhone, True)
        Me.TxtBPhone.Location = New System.Drawing.Point(83, 78)
        Me.TxtBPhone.Name = "TxtBPhone"
        Me.TxtBPhone.PreventEnterBeep = True
        Me.TxtBPhone.Size = New System.Drawing.Size(133, 22)
        Me.TxtBPhone.TabIndex = 152
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
        Me.LabelX9.Location = New System.Drawing.Point(378, 53)
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
        Me.LabelX8.Location = New System.Drawing.Point(83, 53)
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
        Me.BtnAddEmail.Location = New System.Drawing.Point(520, 78)
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
        Me.BtnAddPhone.Location = New System.Drawing.Point(222, 78)
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
        Me.ReflectionLabel2.Text = "<b><font size=""+6""><i>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "</i><font color=""#003333""> Contactos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "</font></font></b>"
        '
        'bar1
        '
        Me.bar1.AccessibleDescription = "bar1 (bar1)"
        Me.bar1.AccessibleName = "bar1"
        Me.bar1.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me.bar1.AntiAlias = True
        Me.bar1.BarType = DevComponents.DotNetBar.eBarType.StatusBar
        Me.bar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bar1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.bar1.IsMaximized = False
        Me.bar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.labelItem1, Me.CProgress})
        Me.bar1.Location = New System.Drawing.Point(0, 427)
        Me.bar1.Name = "bar1"
        Me.bar1.Size = New System.Drawing.Size(862, 28)
        Me.bar1.Stretch = True
        Me.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.bar1.TabIndex = 5
        Me.bar1.TabStop = False
        Me.bar1.Text = "bar1"
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
        'BtnCancel
        '
        Me.BtnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnCancel.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.Location = New System.Drawing.Point(532, 398)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnCancel.TabIndex = 6
        Me.BtnCancel.Text = "Cancelar"
        '
        'AddClientForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 455)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.bar1)
        Me.Controls.Add(Me.PSliderClient)
        Me.Controls.Add(Me.BtnAccept)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.BtnNext)
        Me.Controls.Add(Me.ProgressSteps1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "AddClientForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Nuevo Cliente"
        Me.PSliderClient.ResumeLayout(False)
        Me.PageSliderPage1.ResumeLayout(False)
        Me.PageSliderPage1.PerformLayout()
        Me.PageSliderPage3.ResumeLayout(False)
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        CType(Me.bar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ProgressSteps1 As DevComponents.DotNetBar.ProgressSteps
    Friend WithEvents ProgressOne As DevComponents.DotNetBar.StepItem
    Friend WithEvents ProgressTwo As DevComponents.DotNetBar.StepItem
    Friend WithEvents BtnNext As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnBack As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnAccept As DevComponents.DotNetBar.ButtonX
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents PSliderClient As DevComponents.DotNetBar.Controls.PageSlider
    Friend WithEvents PageSliderPage1 As DevComponents.DotNetBar.Controls.PageSliderPage
    Friend WithEvents TxtBCode As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ReflectionLabel1 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents RbtnRuc As RadioButton
    Friend WithEvents RbtnCedula As RadioButton
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TxtBAddres As DevComponents.DotNetBar.Controls.RichTextBoxEx
    Friend WithEvents TxtBPerfil As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TxtIden As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TxtBName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents PageSliderPage3 As DevComponents.DotNetBar.Controls.PageSliderPage
    Friend WithEvents ReflectionLabel2 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Private WithEvents bar1 As DevComponents.DotNetBar.Bar
    Private WithEvents labelItem1 As DevComponents.DotNetBar.LabelItem
    Private WithEvents CProgress As DevComponents.DotNetBar.CircularProgressItem
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
    Friend WithEvents SuperValidator1 As DevComponents.DotNetBar.Validator.SuperValidator
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
    Friend WithEvents BtnCancel As DevComponents.DotNetBar.ButtonX
End Class

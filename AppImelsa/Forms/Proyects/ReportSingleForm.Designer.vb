<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReportSingleForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportSingleForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbDatos = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.BTNgenerar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1264, 681)
        Me.Panel1.TabIndex = 0
        '
        'Panel6
        '
        Me.Panel6.AutoScroll = True
        Me.Panel6.AutoSize = True
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Panel6.Controls.Add(Me.BTNgenerar)
        Me.Panel6.Controls.Add(Me.Panel2)
        Me.Panel6.Controls.Add(Me.CrystalReportViewer1)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.ForeColor = System.Drawing.Color.Black
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1264, 681)
        Me.Panel6.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lbDatos)
        Me.Panel2.Controls.Add(Me.LabelX1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1264, 100)
        Me.Panel2.TabIndex = 1
        '
        'lbDatos
        '
        Me.lbDatos.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        '
        '
        '
        Me.lbDatos.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbDatos.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDatos.ForeColor = System.Drawing.Color.White
        Me.lbDatos.Location = New System.Drawing.Point(0, 54)
        Me.lbDatos.Name = "lbDatos"
        Me.lbDatos.PaddingLeft = 10
        Me.lbDatos.Size = New System.Drawing.Size(1264, 46)
        Me.lbDatos.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.lbDatos.TabIndex = 1
        Me.lbDatos.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelX1.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.Color.White
        Me.LabelX1.Location = New System.Drawing.Point(0, 0)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.PaddingLeft = 10
        Me.LabelX1.Size = New System.Drawing.Size(1264, 54)
        Me.LabelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.LabelX1.TabIndex = 2
        Me.LabelX1.Text = "Reporte Generado del Proyecto:"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CrystalReportViewer1.ForeColor = System.Drawing.Color.Black
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 163)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1264, 518)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'BTNgenerar
        '
        Me.BTNgenerar.BackColor = System.Drawing.Color.RoyalBlue
        Me.BTNgenerar.FlatAppearance.BorderSize = 0
        Me.BTNgenerar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue
        Me.BTNgenerar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.BTNgenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNgenerar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNgenerar.ForeColor = System.Drawing.Color.White
        Me.BTNgenerar.Location = New System.Drawing.Point(510, 106)
        Me.BTNgenerar.Name = "BTNgenerar"
        Me.BTNgenerar.Size = New System.Drawing.Size(263, 49)
        Me.BTNgenerar.TabIndex = 2
        Me.BTNgenerar.Text = "Generar Reporte"
        Me.BTNgenerar.UseVisualStyleBackColor = False
        '
        'ReportSingleForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1280, 720)
        Me.Name = "ReportSingleForm"
        Me.Text = "MetroForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbDatos As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Private WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents BTNgenerar As Button
End Class
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewAttendance
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewAttendance))
        Me.AttendanceBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Rkvbprot2DataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._rk_vbpro_t2DataSet1 = New AutomatedAttendanceSystemVB._rk_vbpro_t2DataSet1()
        Me.button1 = New System.Windows.Forms.Button()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.AttendanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AttendDataSet4 = New AutomatedAttendanceSystemVB.attendDataSet4()
        Me.AttendanceTableAdapter = New AutomatedAttendanceSystemVB.attendDataSet4TableAdapters.attendanceTableAdapter()
        Me._rk_vbpro_t2DataSet = New AutomatedAttendanceSystemVB._rk_vbpro_t2DataSet()
        Me.Rkvbprot2DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AttennBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AttennTableAdapter = New AutomatedAttendanceSystemVB._rk_vbpro_t2DataSetTableAdapters.AttennTableAdapter()
        Me.AttennBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AttennBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AttendanceTableAdapter1 = New AutomatedAttendanceSystemVB._rk_vbpro_t2DataSet1TableAdapters.AttendanceTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.AttendanceBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rkvbprot2DataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._rk_vbpro_t2DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AttendanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AttendDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._rk_vbpro_t2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rkvbprot2DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AttennBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AttennBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AttennBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AttendanceBindingSource1
        '
        Me.AttendanceBindingSource1.DataMember = "Attendance"
        Me.AttendanceBindingSource1.DataSource = Me.Rkvbprot2DataSet1BindingSource
        '
        'Rkvbprot2DataSet1BindingSource
        '
        Me.Rkvbprot2DataSet1BindingSource.DataSource = Me._rk_vbpro_t2DataSet1
        Me.Rkvbprot2DataSet1BindingSource.Position = 0
        '
        '_rk_vbpro_t2DataSet1
        '
        Me._rk_vbpro_t2DataSet1.DataSetName = "_rk_vbpro_t2DataSet1"
        Me._rk_vbpro_t2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'button1
        '
        Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.Location = New System.Drawing.Point(262, 142)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(73, 27)
        Me.button1.TabIndex = 111
        Me.button1.Text = "Search"
        Me.button1.UseVisualStyleBackColor = True
        '
        'textBox1
        '
        Me.textBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox1.Location = New System.Drawing.Point(262, 93)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(144, 22)
        Me.textBox1.TabIndex = 110
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(128, 96)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(117, 16)
        Me.label1.TabIndex = 109
        Me.label1.Text = "Enter Student Id"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.SaddleBrown
        Me.label3.Location = New System.Drawing.Point(153, 39)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(312, 25)
        Me.label3.TabIndex = 107
        Me.label3.Text = "View Attendance Information"
        '
        'AttendanceBindingSource
        '
        Me.AttendanceBindingSource.DataMember = "attendance"
        Me.AttendanceBindingSource.DataSource = Me.AttendDataSet4
        '
        'AttendDataSet4
        '
        Me.AttendDataSet4.DataSetName = "attendDataSet4"
        Me.AttendDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AttendanceTableAdapter
        '
        Me.AttendanceTableAdapter.ClearBeforeFill = True
        '
        '_rk_vbpro_t2DataSet
        '
        Me._rk_vbpro_t2DataSet.DataSetName = "_rk_vbpro_t2DataSet"
        Me._rk_vbpro_t2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Rkvbprot2DataSetBindingSource
        '
        Me.Rkvbprot2DataSetBindingSource.DataSource = Me._rk_vbpro_t2DataSet
        Me.Rkvbprot2DataSetBindingSource.Position = 0
        '
        'AttennBindingSource
        '
        Me.AttennBindingSource.DataMember = "Attenn"
        Me.AttennBindingSource.DataSource = Me.Rkvbprot2DataSetBindingSource
        '
        'AttennTableAdapter
        '
        Me.AttennTableAdapter.ClearBeforeFill = True
        '
        'AttennBindingSource1
        '
        Me.AttennBindingSource1.DataMember = "Attenn"
        Me.AttennBindingSource1.DataSource = Me.Rkvbprot2DataSetBindingSource
        '
        'AttennBindingSource2
        '
        Me.AttennBindingSource2.DataMember = "Attenn"
        Me.AttennBindingSource2.DataSource = Me.Rkvbprot2DataSetBindingSource
        '
        'AttendanceTableAdapter1
        '
        Me.AttendanceTableAdapter1.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(157, 175)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(308, 234)
        Me.DataGridView1.TabIndex = 112
        '
        'ViewAttendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(626, 435)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.label3)
        Me.Name = "ViewAttendance"
        Me.Text = "ViewAttendance"
        CType(Me.AttendanceBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rkvbprot2DataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._rk_vbpro_t2DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AttendanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AttendDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._rk_vbpro_t2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rkvbprot2DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AttennBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AttennBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AttennBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents button1 As Button
    Private WithEvents textBox1 As TextBox
    Private WithEvents label1 As Label
    Private WithEvents label3 As Label
    Friend WithEvents AttendDataSet4 As attendDataSet4
    Friend WithEvents AttendanceBindingSource As BindingSource
    Friend WithEvents AttendanceTableAdapter As attendDataSet4TableAdapters.attendanceTableAdapter
    Friend WithEvents Rkvbprot2DataSetBindingSource As BindingSource
    Friend WithEvents _rk_vbpro_t2DataSet As _rk_vbpro_t2DataSet
    Friend WithEvents AttennBindingSource As BindingSource
    Friend WithEvents AttennTableAdapter As _rk_vbpro_t2DataSetTableAdapters.AttennTableAdapter
    Friend WithEvents Rkvbprot2DataSet1BindingSource As BindingSource
    Friend WithEvents _rk_vbpro_t2DataSet1 As _rk_vbpro_t2DataSet1
    Friend WithEvents AttennBindingSource1 As BindingSource
    Friend WithEvents AttennBindingSource2 As BindingSource
    Friend WithEvents AttendanceBindingSource1 As BindingSource
    Friend WithEvents AttendanceTableAdapter1 As _rk_vbpro_t2DataSet1TableAdapters.AttendanceTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
End Class

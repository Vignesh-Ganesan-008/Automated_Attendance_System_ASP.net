<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewTeacher
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewTeacher))
        Me.TeacherBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me._rk_vbpro_t2DataSet = New AutomatedAttendanceSystemVB._rk_vbpro_t2DataSet()
        Me.TeacherBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AttendDataSet3 = New AutomatedAttendanceSystemVB.attendDataSet3()
        Me.button1 = New System.Windows.Forms.Button()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.TeacherTableAdapter = New AutomatedAttendanceSystemVB.attendDataSet3TableAdapters.teacherTableAdapter()
        Me._rk_vbpro_t2DataSet1 = New AutomatedAttendanceSystemVB._rk_vbpro_t2DataSet1()
        Me.AttendanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AttendanceTableAdapter = New AutomatedAttendanceSystemVB._rk_vbpro_t2DataSet1TableAdapters.AttendanceTableAdapter()
        Me.TeacherBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TeacherTableAdapter1 = New AutomatedAttendanceSystemVB._rk_vbpro_t2DataSet1TableAdapters.TeacherTableAdapter()
        Me.TeacherTableAdapter2 = New AutomatedAttendanceSystemVB._rk_vbpro_t2DataSetTableAdapters.TeacherTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.TeacherBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._rk_vbpro_t2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeacherBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AttendDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._rk_vbpro_t2DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AttendanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeacherBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TeacherBindingSource2
        '
        Me.TeacherBindingSource2.DataMember = "Teacher"
        Me.TeacherBindingSource2.DataSource = Me._rk_vbpro_t2DataSet
        '
        '_rk_vbpro_t2DataSet
        '
        Me._rk_vbpro_t2DataSet.DataSetName = "_rk_vbpro_t2DataSet"
        Me._rk_vbpro_t2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TeacherBindingSource
        '
        Me.TeacherBindingSource.DataMember = "teacher"
        Me.TeacherBindingSource.DataSource = Me.AttendDataSet3
        '
        'AttendDataSet3
        '
        Me.AttendDataSet3.DataSetName = "attendDataSet3"
        Me.AttendDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'button1
        '
        Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.Location = New System.Drawing.Point(266, 138)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(73, 27)
        Me.button1.TabIndex = 111
        Me.button1.Text = "Search"
        Me.button1.UseVisualStyleBackColor = True
        '
        'textBox1
        '
        Me.textBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox1.Location = New System.Drawing.Point(266, 89)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(144, 22)
        Me.textBox1.TabIndex = 110
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(132, 92)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(123, 16)
        Me.label1.TabIndex = 109
        Me.label1.Text = "Enter Teacher Id"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.SaddleBrown
        Me.label3.Location = New System.Drawing.Point(157, 35)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(279, 25)
        Me.label3.TabIndex = 107
        Me.label3.Text = "View Teacher Information"
        '
        'TeacherTableAdapter
        '
        Me.TeacherTableAdapter.ClearBeforeFill = True
        '
        '_rk_vbpro_t2DataSet1
        '
        Me._rk_vbpro_t2DataSet1.DataSetName = "_rk_vbpro_t2DataSet1"
        Me._rk_vbpro_t2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AttendanceBindingSource
        '
        Me.AttendanceBindingSource.DataMember = "Attendance"
        Me.AttendanceBindingSource.DataSource = Me._rk_vbpro_t2DataSet1
        '
        'AttendanceTableAdapter
        '
        Me.AttendanceTableAdapter.ClearBeforeFill = True
        '
        'TeacherBindingSource1
        '
        Me.TeacherBindingSource1.DataMember = "Teacher"
        Me.TeacherBindingSource1.DataSource = Me._rk_vbpro_t2DataSet1
        '
        'TeacherTableAdapter1
        '
        Me.TeacherTableAdapter1.ClearBeforeFill = True
        '
        'TeacherTableAdapter2
        '
        Me.TeacherTableAdapter2.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 231)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(605, 150)
        Me.DataGridView1.TabIndex = 112
        '
        'ViewTeacher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(623, 430)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.label3)
        Me.Name = "ViewTeacher"
        Me.Text = "ViewTeacher"
        CType(Me.TeacherBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._rk_vbpro_t2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeacherBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AttendDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._rk_vbpro_t2DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AttendanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeacherBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents button1 As Button
    Private WithEvents textBox1 As TextBox
    Private WithEvents label1 As Label
    Private WithEvents label3 As Label
    Friend WithEvents AttendDataSet3 As attendDataSet3
    Friend WithEvents TeacherBindingSource As BindingSource
    Friend WithEvents TeacherTableAdapter As attendDataSet3TableAdapters.teacherTableAdapter
    Friend WithEvents _rk_vbpro_t2DataSet1 As _rk_vbpro_t2DataSet1
    Friend WithEvents AttendanceBindingSource As BindingSource
    Friend WithEvents AttendanceTableAdapter As _rk_vbpro_t2DataSet1TableAdapters.AttendanceTableAdapter
    Friend WithEvents TeacherBindingSource1 As BindingSource
    Friend WithEvents TeacherTableAdapter1 As _rk_vbpro_t2DataSet1TableAdapters.TeacherTableAdapter
    Friend WithEvents _rk_vbpro_t2DataSet As _rk_vbpro_t2DataSet
    Friend WithEvents TeacherBindingSource2 As BindingSource
    Friend WithEvents TeacherTableAdapter2 As _rk_vbpro_t2DataSetTableAdapters.TeacherTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
End Class

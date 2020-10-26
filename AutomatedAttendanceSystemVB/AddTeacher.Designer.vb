<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddTeacher
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddTeacher))
        Me.button3 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.label11 = New System.Windows.Forms.Label()
        Me.textBox9 = New System.Windows.Forms.TextBox()
        Me.textBox8 = New System.Windows.Forms.TextBox()
        Me.textBox7 = New System.Windows.Forms.TextBox()
        Me.textBox6 = New System.Windows.Forms.TextBox()
        Me.textBox5 = New System.Windows.Forms.TextBox()
        Me.textBox4 = New System.Windows.Forms.TextBox()
        Me.textBox3 = New System.Windows.Forms.TextBox()
        Me.radioButton2 = New System.Windows.Forms.RadioButton()
        Me.radioButton1 = New System.Windows.Forms.RadioButton()
        Me.textBox2 = New System.Windows.Forms.TextBox()
        Me.label10 = New System.Windows.Forms.Label()
        Me.label9 = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.TeacherBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AttendDataSet1 = New AutomatedAttendanceSystemVB.attendDataSet1()
        Me.TeacherTableAdapter = New AutomatedAttendanceSystemVB.attendDataSet1TableAdapters.teacherTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.TeacherBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AttendDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'button3
        '
        Me.button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button3.Location = New System.Drawing.Point(422, 409)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(83, 27)
        Me.button3.TabIndex = 135
        Me.button3.Text = "Delete"
        Me.button3.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.Location = New System.Drawing.Point(76, 409)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(73, 27)
        Me.button1.TabIndex = 132
        Me.button1.Text = "Add"
        Me.button1.UseVisualStyleBackColor = True
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label11.Location = New System.Drawing.Point(336, 348)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(53, 16)
        Me.label11.TabIndex = 131
        Me.label11.Text = "Salary"
        '
        'textBox9
        '
        Me.textBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox9.Location = New System.Drawing.Point(410, 345)
        Me.textBox9.Name = "textBox9"
        Me.textBox9.Size = New System.Drawing.Size(144, 22)
        Me.textBox9.TabIndex = 130
        '
        'textBox8
        '
        Me.textBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox8.Location = New System.Drawing.Point(410, 286)
        Me.textBox8.Name = "textBox8"
        Me.textBox8.Size = New System.Drawing.Size(144, 22)
        Me.textBox8.TabIndex = 129
        '
        'textBox7
        '
        Me.textBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox7.Location = New System.Drawing.Point(410, 227)
        Me.textBox7.Name = "textBox7"
        Me.textBox7.Size = New System.Drawing.Size(144, 22)
        Me.textBox7.TabIndex = 128
        '
        'textBox6
        '
        Me.textBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox6.Location = New System.Drawing.Point(410, 171)
        Me.textBox6.Name = "textBox6"
        Me.textBox6.Size = New System.Drawing.Size(144, 22)
        Me.textBox6.TabIndex = 127
        '
        'textBox5
        '
        Me.textBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox5.Location = New System.Drawing.Point(410, 115)
        Me.textBox5.Name = "textBox5"
        Me.textBox5.Size = New System.Drawing.Size(144, 22)
        Me.textBox5.TabIndex = 126
        '
        'textBox4
        '
        Me.textBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox4.Location = New System.Drawing.Point(124, 348)
        Me.textBox4.Name = "textBox4"
        Me.textBox4.Size = New System.Drawing.Size(144, 22)
        Me.textBox4.TabIndex = 125
        '
        'textBox3
        '
        Me.textBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox3.Location = New System.Drawing.Point(124, 286)
        Me.textBox3.Name = "textBox3"
        Me.textBox3.Size = New System.Drawing.Size(144, 22)
        Me.textBox3.TabIndex = 124
        '
        'radioButton2
        '
        Me.radioButton2.AutoSize = True
        Me.radioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioButton2.Location = New System.Drawing.Point(205, 228)
        Me.radioButton2.Name = "radioButton2"
        Me.radioButton2.Size = New System.Drawing.Size(78, 20)
        Me.radioButton2.TabIndex = 123
        Me.radioButton2.Text = "Female"
        Me.radioButton2.UseVisualStyleBackColor = True
        '
        'radioButton1
        '
        Me.radioButton1.AutoSize = True
        Me.radioButton1.Checked = True
        Me.radioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioButton1.Location = New System.Drawing.Point(124, 228)
        Me.radioButton1.Name = "radioButton1"
        Me.radioButton1.Size = New System.Drawing.Size(60, 20)
        Me.radioButton1.TabIndex = 122
        Me.radioButton1.TabStop = True
        Me.radioButton1.Text = "Male"
        Me.radioButton1.UseVisualStyleBackColor = True
        '
        'textBox2
        '
        Me.textBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox2.Location = New System.Drawing.Point(124, 171)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(144, 22)
        Me.textBox2.TabIndex = 121
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label10.Location = New System.Drawing.Point(313, 289)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(76, 16)
        Me.label10.TabIndex = 120
        Me.label10.Text = "Password"
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label9.Location = New System.Drawing.Point(353, 230)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(36, 16)
        Me.label9.TabIndex = 119
        Me.label9.Text = "Age"
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.Location = New System.Drawing.Point(329, 118)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(66, 16)
        Me.label8.TabIndex = 118
        Me.label8.Text = "Address"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.Location = New System.Drawing.Point(64, 351)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(47, 16)
        Me.label7.TabIndex = 117
        Me.label7.Text = "Email"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(51, 289)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(60, 16)
        Me.label6.TabIndex = 116
        Me.label6.Text = "Contact"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.Location = New System.Drawing.Point(329, 174)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(60, 16)
        Me.label5.TabIndex = 115
        Me.label5.Text = "Subject"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(52, 230)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(59, 16)
        Me.label4.TabIndex = 114
        Me.label4.Text = "Gender"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(62, 174)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(49, 16)
        Me.label2.TabIndex = 113
        Me.label2.Text = "Name"
        '
        'textBox1
        '
        Me.textBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox1.Location = New System.Drawing.Point(124, 112)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(144, 22)
        Me.textBox1.TabIndex = 112
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(28, 115)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(83, 16)
        Me.label1.TabIndex = 111
        Me.label1.Text = "Teacher Id"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.SaddleBrown
        Me.label3.Location = New System.Drawing.Point(140, 33)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(270, 25)
        Me.label3.TabIndex = 109
        Me.label3.Text = "Add Teacher Information"
        '
        'TeacherBindingSource
        '
        Me.TeacherBindingSource.DataMember = "teacher"
        Me.TeacherBindingSource.DataSource = Me.AttendDataSet1
        '
        'AttendDataSet1
        '
        Me.AttendDataSet1.DataSetName = "attendDataSet1"
        Me.AttendDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TeacherTableAdapter
        '
        Me.TeacherTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(264, 409)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(73, 27)
        Me.Button2.TabIndex = 136
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 465)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(592, 190)
        Me.DataGridView1.TabIndex = 137
        '
        'AddTeacher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(616, 667)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.label11)
        Me.Controls.Add(Me.textBox9)
        Me.Controls.Add(Me.textBox8)
        Me.Controls.Add(Me.textBox7)
        Me.Controls.Add(Me.textBox6)
        Me.Controls.Add(Me.textBox5)
        Me.Controls.Add(Me.textBox4)
        Me.Controls.Add(Me.textBox3)
        Me.Controls.Add(Me.radioButton2)
        Me.Controls.Add(Me.radioButton1)
        Me.Controls.Add(Me.textBox2)
        Me.Controls.Add(Me.label10)
        Me.Controls.Add(Me.label9)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.label3)
        Me.Name = "AddTeacher"
        Me.Text = "AddTeacher"
        CType(Me.TeacherBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AttendDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents button3 As Button
    Private WithEvents button1 As Button
    Private WithEvents label11 As Label
    Private WithEvents textBox9 As TextBox
    Private WithEvents textBox8 As TextBox
    Private WithEvents textBox7 As TextBox
    Private WithEvents textBox6 As TextBox
    Private WithEvents textBox5 As TextBox
    Private WithEvents textBox4 As TextBox
    Private WithEvents textBox3 As TextBox
    Private WithEvents radioButton2 As RadioButton
    Private WithEvents radioButton1 As RadioButton
    Private WithEvents textBox2 As TextBox
    Private WithEvents label10 As Label
    Private WithEvents label9 As Label
    Private WithEvents label8 As Label
    Private WithEvents label7 As Label
    Private WithEvents label6 As Label
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents label2 As Label
    Private WithEvents textBox1 As TextBox
    Private WithEvents label1 As Label
    Private WithEvents label3 As Label
    Friend WithEvents AttendDataSet1 As attendDataSet1
    Friend WithEvents TeacherBindingSource As BindingSource
    Friend WithEvents TeacherTableAdapter As attendDataSet1TableAdapters.teacherTableAdapter
    Private WithEvents Button2 As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class

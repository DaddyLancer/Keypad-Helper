<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnNum0 = New System.Windows.Forms.Button()
        Me.btnNumLock = New System.Windows.Forms.Button()
        Me.btnNumDec = New System.Windows.Forms.Button()
        Me.btnNum8 = New System.Windows.Forms.Button()
        Me.btnNum7 = New System.Windows.Forms.Button()
        Me.btnNumEnter = New System.Windows.Forms.Button()
        Me.btnNum9 = New System.Windows.Forms.Button()
        Me.btnNumAsterisk = New System.Windows.Forms.Button()
        Me.btnNumDivide = New System.Windows.Forms.Button()
        Me.btnNumMinus = New System.Windows.Forms.Button()
        Me.btnNum6 = New System.Windows.Forms.Button()
        Me.btnNum5 = New System.Windows.Forms.Button()
        Me.btnNum1 = New System.Windows.Forms.Button()
        Me.btnNumPlus = New System.Windows.Forms.Button()
        Me.btnNum4 = New System.Windows.Forms.Button()
        Me.btnNum2 = New System.Windows.Forms.Button()
        Me.btnNum3 = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.chkExcel = New System.Windows.Forms.RadioButton()
        Me.chkNotepad = New System.Windows.Forms.RadioButton()
        Me.txtFeed = New System.Windows.Forms.TextBox()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtExcel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtWorkbook = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtSheet = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.result = New System.Data.DataSet()
        Me.GroupBox1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.result, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnNum0)
        Me.GroupBox1.Controls.Add(Me.btnNumLock)
        Me.GroupBox1.Controls.Add(Me.btnNumDec)
        Me.GroupBox1.Controls.Add(Me.btnNum8)
        Me.GroupBox1.Controls.Add(Me.btnNum7)
        Me.GroupBox1.Controls.Add(Me.btnNumEnter)
        Me.GroupBox1.Controls.Add(Me.btnNum9)
        Me.GroupBox1.Controls.Add(Me.btnNumAsterisk)
        Me.GroupBox1.Controls.Add(Me.btnNumDivide)
        Me.GroupBox1.Controls.Add(Me.btnNumMinus)
        Me.GroupBox1.Controls.Add(Me.btnNum6)
        Me.GroupBox1.Controls.Add(Me.btnNum5)
        Me.GroupBox1.Controls.Add(Me.btnNum1)
        Me.GroupBox1.Controls.Add(Me.btnNumPlus)
        Me.GroupBox1.Controls.Add(Me.btnNum4)
        Me.GroupBox1.Controls.Add(Me.btnNum2)
        Me.GroupBox1.Controls.Add(Me.btnNum3)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(234, 302)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Numpad"
        '
        'btnNum0
        '
        Me.btnNum0.Font = New System.Drawing.Font("TechnicBold", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnNum0.Location = New System.Drawing.Point(6, 243)
        Me.btnNum0.Name = "btnNum0"
        Me.btnNum0.Size = New System.Drawing.Size(106, 50)
        Me.btnNum0.TabIndex = 15
        Me.btnNum0.Text = "0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Insert"
        Me.btnNum0.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnNum0.UseVisualStyleBackColor = True
        '
        'btnNumLock
        '
        Me.btnNumLock.Font = New System.Drawing.Font("TechnicBold", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnNumLock.Location = New System.Drawing.Point(6, 19)
        Me.btnNumLock.Name = "btnNumLock"
        Me.btnNumLock.Size = New System.Drawing.Size(50, 50)
        Me.btnNumLock.TabIndex = 9
        Me.btnNumLock.Text = "Num" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Lock"
        Me.btnNumLock.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnNumLock.UseVisualStyleBackColor = True
        '
        'btnNumDec
        '
        Me.btnNumDec.Font = New System.Drawing.Font("TechnicBold", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnNumDec.Location = New System.Drawing.Point(118, 243)
        Me.btnNumDec.Name = "btnNumDec"
        Me.btnNumDec.Size = New System.Drawing.Size(50, 50)
        Me.btnNumDec.TabIndex = 17
        Me.btnNumDec.Text = "," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Del"
        Me.btnNumDec.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnNumDec.UseVisualStyleBackColor = True
        '
        'btnNum8
        '
        Me.btnNum8.Font = New System.Drawing.Font("TechnicBold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnNum8.Location = New System.Drawing.Point(62, 75)
        Me.btnNum8.Name = "btnNum8"
        Me.btnNum8.Size = New System.Drawing.Size(50, 50)
        Me.btnNum8.TabIndex = 7
        Me.btnNum8.Text = "8"
        Me.btnNum8.UseVisualStyleBackColor = True
        '
        'btnNum7
        '
        Me.btnNum7.Font = New System.Drawing.Font("TechnicBold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnNum7.Location = New System.Drawing.Point(6, 75)
        Me.btnNum7.Name = "btnNum7"
        Me.btnNum7.Size = New System.Drawing.Size(50, 50)
        Me.btnNum7.TabIndex = 6
        Me.btnNum7.Text = "7" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnNum7.UseVisualStyleBackColor = True
        '
        'btnNumEnter
        '
        Me.btnNumEnter.Font = New System.Drawing.Font("TechnicBold", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnNumEnter.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnNumEnter.Location = New System.Drawing.Point(174, 189)
        Me.btnNumEnter.Name = "btnNumEnter"
        Me.btnNumEnter.Size = New System.Drawing.Size(50, 106)
        Me.btnNumEnter.TabIndex = 16
        Me.btnNumEnter.Text = "Return"
        Me.btnNumEnter.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnNumEnter.UseVisualStyleBackColor = True
        '
        'btnNum9
        '
        Me.btnNum9.Font = New System.Drawing.Font("TechnicBold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnNum9.Location = New System.Drawing.Point(118, 75)
        Me.btnNum9.Name = "btnNum9"
        Me.btnNum9.Size = New System.Drawing.Size(50, 50)
        Me.btnNum9.TabIndex = 8
        Me.btnNum9.Text = "9" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnNum9.UseVisualStyleBackColor = True
        '
        'btnNumAsterisk
        '
        Me.btnNumAsterisk.Font = New System.Drawing.Font("TechnicBold", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnNumAsterisk.Location = New System.Drawing.Point(62, 19)
        Me.btnNumAsterisk.Name = "btnNumAsterisk"
        Me.btnNumAsterisk.Size = New System.Drawing.Size(50, 50)
        Me.btnNumAsterisk.TabIndex = 11
        Me.btnNumAsterisk.Text = "*"
        Me.btnNumAsterisk.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnNumAsterisk.UseVisualStyleBackColor = True
        '
        'btnNumDivide
        '
        Me.btnNumDivide.Font = New System.Drawing.Font("TechnicBold", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnNumDivide.Location = New System.Drawing.Point(118, 19)
        Me.btnNumDivide.Name = "btnNumDivide"
        Me.btnNumDivide.Size = New System.Drawing.Size(50, 50)
        Me.btnNumDivide.TabIndex = 10
        Me.btnNumDivide.Text = "/"
        Me.btnNumDivide.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnNumDivide.UseVisualStyleBackColor = True
        '
        'btnNumMinus
        '
        Me.btnNumMinus.Font = New System.Drawing.Font("TechnicBold", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnNumMinus.Location = New System.Drawing.Point(174, 19)
        Me.btnNumMinus.Name = "btnNumMinus"
        Me.btnNumMinus.Size = New System.Drawing.Size(50, 50)
        Me.btnNumMinus.TabIndex = 12
        Me.btnNumMinus.Text = "-"
        Me.btnNumMinus.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnNumMinus.UseVisualStyleBackColor = True
        '
        'btnNum6
        '
        Me.btnNum6.Font = New System.Drawing.Font("TechnicBold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnNum6.Location = New System.Drawing.Point(118, 131)
        Me.btnNum6.Name = "btnNum6"
        Me.btnNum6.Size = New System.Drawing.Size(50, 50)
        Me.btnNum6.TabIndex = 5
        Me.btnNum6.Text = "6"
        Me.btnNum6.UseVisualStyleBackColor = True
        '
        'btnNum5
        '
        Me.btnNum5.Font = New System.Drawing.Font("TechnicBold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnNum5.Location = New System.Drawing.Point(62, 131)
        Me.btnNum5.Name = "btnNum5"
        Me.btnNum5.Size = New System.Drawing.Size(50, 50)
        Me.btnNum5.TabIndex = 1
        Me.btnNum5.Text = "5"
        Me.btnNum5.UseVisualStyleBackColor = True
        '
        'btnNum1
        '
        Me.btnNum1.Font = New System.Drawing.Font("TechnicBold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnNum1.Location = New System.Drawing.Point(6, 187)
        Me.btnNum1.Name = "btnNum1"
        Me.btnNum1.Size = New System.Drawing.Size(50, 50)
        Me.btnNum1.TabIndex = 0
        Me.btnNum1.Text = "1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnNum1.UseVisualStyleBackColor = True
        '
        'btnNumPlus
        '
        Me.btnNumPlus.Font = New System.Drawing.Font("TechnicBold", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnNumPlus.Location = New System.Drawing.Point(174, 75)
        Me.btnNumPlus.Name = "btnNumPlus"
        Me.btnNumPlus.Size = New System.Drawing.Size(50, 106)
        Me.btnNumPlus.TabIndex = 13
        Me.btnNumPlus.Text = "+"
        Me.btnNumPlus.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnNumPlus.UseVisualStyleBackColor = True
        '
        'btnNum4
        '
        Me.btnNum4.Font = New System.Drawing.Font("TechnicBold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnNum4.Location = New System.Drawing.Point(6, 131)
        Me.btnNum4.Name = "btnNum4"
        Me.btnNum4.Size = New System.Drawing.Size(50, 50)
        Me.btnNum4.TabIndex = 3
        Me.btnNum4.Text = "4"
        Me.btnNum4.UseVisualStyleBackColor = True
        '
        'btnNum2
        '
        Me.btnNum2.Font = New System.Drawing.Font("TechnicBold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnNum2.Location = New System.Drawing.Point(62, 187)
        Me.btnNum2.Name = "btnNum2"
        Me.btnNum2.Size = New System.Drawing.Size(50, 50)
        Me.btnNum2.TabIndex = 1
        Me.btnNum2.Text = "2"
        Me.btnNum2.UseVisualStyleBackColor = True
        '
        'btnNum3
        '
        Me.btnNum3.Font = New System.Drawing.Font("TechnicBold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnNum3.Location = New System.Drawing.Point(118, 187)
        Me.btnNum3.Name = "btnNum3"
        Me.btnNum3.Size = New System.Drawing.Size(50, 50)
        Me.btnNum3.TabIndex = 2
        Me.btnNum3.Text = "3" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnNum3.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(250, 84)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(83, 23)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "Start Logging"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'chkExcel
        '
        Me.chkExcel.AutoSize = True
        Me.chkExcel.Location = New System.Drawing.Point(251, 54)
        Me.chkExcel.Name = "chkExcel"
        Me.chkExcel.Size = New System.Drawing.Size(82, 17)
        Me.chkExcel.TabIndex = 2
        Me.chkExcel.Text = "Excel Sheet"
        Me.chkExcel.UseVisualStyleBackColor = True
        '
        'chkNotepad
        '
        Me.chkNotepad.AutoSize = True
        Me.chkNotepad.Checked = True
        Me.chkNotepad.Location = New System.Drawing.Point(251, 31)
        Me.chkNotepad.Name = "chkNotepad"
        Me.chkNotepad.Size = New System.Drawing.Size(60, 17)
        Me.chkNotepad.TabIndex = 3
        Me.chkNotepad.TabStop = True
        Me.chkNotepad.Text = "Internal"
        Me.chkNotepad.UseVisualStyleBackColor = True
        '
        'txtFeed
        '
        Me.txtFeed.Location = New System.Drawing.Point(252, 140)
        Me.txtFeed.Multiline = True
        Me.txtFeed.Name = "txtFeed"
        Me.txtFeed.ReadOnly = True
        Me.txtFeed.Size = New System.Drawing.Size(81, 164)
        Me.txtFeed.TabIndex = 4
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(250, 113)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(81, 23)
        Me.btnOpen.TabIndex = 5
        Me.btnOpen.Text = "Open File"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel3, Me.txtExcel, Me.ToolStripStatusLabel1, Me.txtWorkbook, Me.ToolStripStatusLabel2, Me.txtSheet})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 324)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.StatusStrip1.Size = New System.Drawing.Size(1051, 22)
        Me.StatusStrip1.TabIndex = 7
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(91, 17)
        Me.ToolStripStatusLabel3.Text = "Excel Running: "
        '
        'txtExcel
        '
        Me.txtExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.txtExcel.Name = "txtExcel"
        Me.txtExcel.Size = New System.Drawing.Size(33, 17)
        Me.txtExcel.Text = "Excel"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(69, 17)
        Me.ToolStripStatusLabel1.Text = "Workbook:"
        '
        'txtWorkbook
        '
        Me.txtWorkbook.Name = "txtWorkbook"
        Me.txtWorkbook.Size = New System.Drawing.Size(62, 17)
        Me.txtWorkbook.Text = "Workbook"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(40, 17)
        Me.ToolStripStatusLabel2.Text = "Sheet"
        '
        'txtSheet
        '
        Me.txtSheet.Name = "txtSheet"
        Me.txtSheet.Size = New System.Drawing.Size(36, 17)
        Me.txtSheet.Text = "Sheet"
        '
        'Timer1
        '
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        Me.DataGridView1.DataSource = Me.result
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 16)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(678, 257)
        Me.DataGridView1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(339, 31)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(684, 276)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Excel Info"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        '
        'result
        '
        Me.result.DataSetName = "NewDataSet"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1051, 346)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.txtFeed)
        Me.Controls.Add(Me.chkNotepad)
        Me.Controls.Add(Me.chkExcel)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.result, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnNum0 As Button
    Friend WithEvents btnNumLock As Button
    Friend WithEvents btnNumDec As Button
    Friend WithEvents btnNum8 As Button
    Friend WithEvents btnNum7 As Button
    Friend WithEvents btnNumEnter As Button
    Friend WithEvents btnNum9 As Button
    Friend WithEvents btnNumMinus As Button
    Friend WithEvents btnNum6 As Button
    Friend WithEvents btnNumAsterisk As Button
    Friend WithEvents btnNum5 As Button
    Friend WithEvents btnNum1 As Button
    Friend WithEvents btnNumDivide As Button
    Friend WithEvents btnNumPlus As Button
    Friend WithEvents btnNum4 As Button
    Friend WithEvents btnNum2 As Button
    Friend WithEvents btnNum3 As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents chkExcel As RadioButton
    Friend WithEvents chkNotepad As RadioButton
    Friend WithEvents txtFeed As TextBox
    Friend WithEvents btnOpen As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents txtExcel As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents txtWorkbook As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents txtSheet As ToolStripStatusLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents result As DataSet
End Class

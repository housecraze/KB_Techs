<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bookings
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.clientBtn = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.logoutBtn = New System.Windows.Forms.Button()
        Me.usrnm = New System.Windows.Forms.TextBox()
        Me.completedBtn = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.search = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Location = New System.Drawing.Point(-2, -2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 665)
        Me.Label1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PictureBox1.Image = Global.KB_Techs.My.Resources.Resources._1logo
        Me.PictureBox1.Location = New System.Drawing.Point(25, 33)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(126, 121)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Aquire", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(43, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 48)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "KB" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Techs"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'clientBtn
        '
        Me.clientBtn.BackColor = System.Drawing.Color.Silver
        Me.clientBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.clientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clientBtn.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clientBtn.ForeColor = System.Drawing.Color.Black
        Me.clientBtn.Location = New System.Drawing.Point(0, 270)
        Me.clientBtn.Name = "clientBtn"
        Me.clientBtn.Size = New System.Drawing.Size(187, 49)
        Me.clientBtn.TabIndex = 3
        Me.clientBtn.Text = "Schedules"
        Me.clientBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(234, 212)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(676, 330)
        Me.DataGridView1.TabIndex = 4
        '
        'logoutBtn
        '
        Me.logoutBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.logoutBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.logoutBtn.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logoutBtn.ForeColor = System.Drawing.Color.White
        Me.logoutBtn.Location = New System.Drawing.Point(108, 625)
        Me.logoutBtn.Name = "logoutBtn"
        Me.logoutBtn.Size = New System.Drawing.Size(75, 23)
        Me.logoutBtn.TabIndex = 6
        Me.logoutBtn.Text = "Logout"
        Me.logoutBtn.UseVisualStyleBackColor = False
        '
        'usrnm
        '
        Me.usrnm.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.usrnm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.usrnm.Cursor = System.Windows.Forms.Cursors.Default
        Me.usrnm.ForeColor = System.Drawing.Color.White
        Me.usrnm.Location = New System.Drawing.Point(6, 627)
        Me.usrnm.Name = "usrnm"
        Me.usrnm.ReadOnly = True
        Me.usrnm.Size = New System.Drawing.Size(97, 20)
        Me.usrnm.TabIndex = 5
        '
        'completedBtn
        '
        Me.completedBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.completedBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.completedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.completedBtn.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.completedBtn.ForeColor = System.Drawing.Color.White
        Me.completedBtn.Location = New System.Drawing.Point(0, 341)
        Me.completedBtn.Name = "completedBtn"
        Me.completedBtn.Size = New System.Drawing.Size(187, 49)
        Me.completedBtn.TabIndex = 7
        Me.completedBtn.Text = "Completed" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Transactions"
        Me.completedBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 422)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(187, 49)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Cancelled" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Schedules"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'search
        '
        Me.search.BackColor = System.Drawing.Color.Black
        Me.search.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search.ForeColor = System.Drawing.Color.White
        Me.search.Location = New System.Drawing.Point(347, 166)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(183, 22)
        Me.search.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(250, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Search/Filter"
        '
        'Bookings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(954, 657)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.completedBtn)
        Me.Controls.Add(Me.logoutBtn)
        Me.Controls.Add(Me.usrnm)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.clientBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Bookings"
        Me.Text = "KB Techs Admin Panel"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents clientBtn As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents logoutBtn As Button
    Friend WithEvents usrnm As TextBox
    Friend WithEvents completedBtn As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents search As TextBox
    Friend WithEvents Label4 As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.lblInput = New System.Windows.Forms.Label()
        Me.btnInput = New System.Windows.Forms.Button()
        Me.lbxDetailsInput = New System.Windows.Forms.ListBox()
        Me.lblDetailsInput = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblDetailsOutput = New System.Windows.Forms.Label()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.lbxDetailsOutput = New System.Windows.Forms.ListBox()
        Me.btnOutput = New System.Windows.Forms.Button()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HowToUseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.lbxInputFolder = New System.Windows.Forms.ListBox()
        Me.lbxOutputFolder = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'lblInput
        '
        Me.lblInput.AutoSize = True
        Me.lblInput.Location = New System.Drawing.Point(7, 18)
        Me.lblInput.MaximumSize = New System.Drawing.Size(247, 13)
        Me.lblInput.Name = "lblInput"
        Me.lblInput.Size = New System.Drawing.Size(69, 13)
        Me.lblInput.TabIndex = 0
        Me.lblInput.Text = "Input Folder: "
        '
        'btnInput
        '
        Me.btnInput.Location = New System.Drawing.Point(6, 34)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(90, 23)
        Me.btnInput.TabIndex = 1
        Me.btnInput.Text = "Select Folder"
        Me.btnInput.UseVisualStyleBackColor = True
        '
        'lbxDetailsInput
        '
        Me.lbxDetailsInput.FormattingEnabled = True
        Me.lbxDetailsInput.HorizontalScrollbar = True
        Me.lbxDetailsInput.Location = New System.Drawing.Point(6, 173)
        Me.lbxDetailsInput.Name = "lbxDetailsInput"
        Me.lbxDetailsInput.Size = New System.Drawing.Size(247, 82)
        Me.lbxDetailsInput.TabIndex = 3
        '
        'lblDetailsInput
        '
        Me.lblDetailsInput.AutoSize = True
        Me.lblDetailsInput.Location = New System.Drawing.Point(6, 156)
        Me.lblDetailsInput.Name = "lblDetailsInput"
        Me.lblDetailsInput.Size = New System.Drawing.Size(42, 13)
        Me.lblDetailsInput.TabIndex = 4
        Me.lblDetailsInput.Text = "Details:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblDetailsInput)
        Me.GroupBox1.Controls.Add(Me.lblInput)
        Me.GroupBox1.Controls.Add(Me.lbxDetailsInput)
        Me.GroupBox1.Controls.Add(Me.btnInput)
        Me.GroupBox1.Controls.Add(Me.lbxInputFolder)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(259, 276)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblDetailsOutput)
        Me.GroupBox2.Controls.Add(Me.lblOutput)
        Me.GroupBox2.Controls.Add(Me.lbxDetailsOutput)
        Me.GroupBox2.Controls.Add(Me.btnOutput)
        Me.GroupBox2.Controls.Add(Me.lbxOutputFolder)
        Me.GroupBox2.Location = New System.Drawing.Point(301, 32)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(259, 276)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'lblDetailsOutput
        '
        Me.lblDetailsOutput.AutoSize = True
        Me.lblDetailsOutput.Location = New System.Drawing.Point(6, 156)
        Me.lblDetailsOutput.Name = "lblDetailsOutput"
        Me.lblDetailsOutput.Size = New System.Drawing.Size(42, 13)
        Me.lblDetailsOutput.TabIndex = 4
        Me.lblDetailsOutput.Text = "Details:"
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Location = New System.Drawing.Point(7, 18)
        Me.lblOutput.MaximumSize = New System.Drawing.Size(247, 13)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(77, 13)
        Me.lblOutput.TabIndex = 0
        Me.lblOutput.Text = "Output Folder: "
        '
        'lbxDetailsOutput
        '
        Me.lbxDetailsOutput.FormattingEnabled = True
        Me.lbxDetailsOutput.HorizontalScrollbar = True
        Me.lbxDetailsOutput.Location = New System.Drawing.Point(6, 173)
        Me.lbxDetailsOutput.Name = "lbxDetailsOutput"
        Me.lbxDetailsOutput.Size = New System.Drawing.Size(247, 82)
        Me.lbxDetailsOutput.TabIndex = 3
        '
        'btnOutput
        '
        Me.btnOutput.Location = New System.Drawing.Point(6, 34)
        Me.btnOutput.Name = "btnOutput"
        Me.btnOutput.Size = New System.Drawing.Size(90, 23)
        Me.btnOutput.TabIndex = 1
        Me.btnOutput.Text = "Select Folder"
        Me.btnOutput.UseVisualStyleBackColor = True
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog1"
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(404, 314)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 7
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(485, 314)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(323, 314)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 9
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(574, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(93, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HowToUseToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'HowToUseToolStripMenuItem
        '
        Me.HowToUseToolStripMenuItem.Name = "HowToUseToolStripMenuItem"
        Me.HowToUseToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.HowToUseToolStripMenuItem.Text = "How To Use"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 345)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(574, 22)
        Me.StatusStrip1.TabIndex = 11
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lbxInputFolder
        '
        Me.lbxInputFolder.FormattingEnabled = True
        Me.lbxInputFolder.HorizontalScrollbar = True
        Me.lbxInputFolder.Location = New System.Drawing.Point(6, 64)
        Me.lbxInputFolder.Name = "lbxInputFolder"
        Me.lbxInputFolder.Size = New System.Drawing.Size(247, 82)
        Me.lbxInputFolder.TabIndex = 5
        '
        'lbxOutputFolder
        '
        Me.lbxOutputFolder.FormattingEnabled = True
        Me.lbxOutputFolder.HorizontalScrollbar = True
        Me.lbxOutputFolder.Location = New System.Drawing.Point(6, 64)
        Me.lbxOutputFolder.Name = "lbxOutputFolder"
        Me.lbxOutputFolder.Size = New System.Drawing.Size(247, 82)
        Me.lbxOutputFolder.TabIndex = 6
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 367)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main"
        Me.Text = "Form2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents lblInput As Label
    Friend WithEvents btnInput As Button
    Friend WithEvents lbxDetailsInput As ListBox
    Friend WithEvents lblDetailsInput As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblDetailsOutput As Label
    Friend WithEvents lblOutput As Label
    Friend WithEvents lbxDetailsOutput As ListBox
    Friend WithEvents btnOutput As Button
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents HowToUseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents lbxInputFolder As ListBox
    Friend WithEvents lbxOutputFolder As ListBox
End Class

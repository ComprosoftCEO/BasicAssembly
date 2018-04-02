<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.BasicAssemblyLabel = New System.Windows.Forms.Label()
        Me.MemoryListBox = New System.Windows.Forms.ListBox()
        Me.MemoryLabel = New System.Windows.Forms.Label()
        Me.AccLabel = New System.Windows.Forms.Label()
        Me.BakupLabel = New System.Windows.Forms.Label()
        Me.NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.AccumulatorOutput = New System.Windows.Forms.Label()
        Me.BakupOutput = New System.Windows.Forms.Label()
        Me.OutputTextBox = New System.Windows.Forms.TextBox()
        Me.OutputLabel = New System.Windows.Forms.Label()
        Me.RunButton = New System.Windows.Forms.Button()
        Me.RunTimer = New System.Windows.Forms.Timer(Me.components)
        Me.OverflowLabel = New System.Windows.Forms.Label()
        Me.OverflowOutput = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CommandsLabel = New System.Windows.Forms.Label()
        Me.Commands2Label = New System.Windows.Forms.Label()
        Me.FormMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClearAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ResetColorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.OverclockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenTextFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SaveTextFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.ColorDialog = New System.Windows.Forms.ColorDialog()
        CType(Me.NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.FormMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'BasicAssemblyLabel
        '
        Me.BasicAssemblyLabel.AutoSize = True
        Me.BasicAssemblyLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicAssemblyLabel.Location = New System.Drawing.Point(373, 42)
        Me.BasicAssemblyLabel.Name = "BasicAssemblyLabel"
        Me.BasicAssemblyLabel.Size = New System.Drawing.Size(206, 31)
        Me.BasicAssemblyLabel.TabIndex = 0
        Me.BasicAssemblyLabel.Text = "Basic Assembly"
        '
        'MemoryListBox
        '
        Me.MemoryListBox.BackColor = System.Drawing.Color.Black
        Me.MemoryListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MemoryListBox.ForeColor = System.Drawing.Color.Lime
        Me.MemoryListBox.FormattingEnabled = True
        Me.MemoryListBox.ItemHeight = 24
        Me.MemoryListBox.Location = New System.Drawing.Point(26, 116)
        Me.MemoryListBox.Name = "MemoryListBox"
        Me.MemoryListBox.Size = New System.Drawing.Size(146, 196)
        Me.MemoryListBox.TabIndex = 2
        '
        'MemoryLabel
        '
        Me.MemoryLabel.AutoSize = True
        Me.MemoryLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MemoryLabel.Location = New System.Drawing.Point(57, 81)
        Me.MemoryLabel.Name = "MemoryLabel"
        Me.MemoryLabel.Size = New System.Drawing.Size(65, 20)
        Me.MemoryLabel.TabIndex = 3
        Me.MemoryLabel.Text = "Memory"
        '
        'AccLabel
        '
        Me.AccLabel.AutoSize = True
        Me.AccLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccLabel.Location = New System.Drawing.Point(206, 119)
        Me.AccLabel.Name = "AccLabel"
        Me.AccLabel.Size = New System.Drawing.Size(102, 20)
        Me.AccLabel.TabIndex = 4
        Me.AccLabel.Text = "Accumulator:"
        '
        'BakupLabel
        '
        Me.BakupLabel.AutoSize = True
        Me.BakupLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BakupLabel.Location = New System.Drawing.Point(206, 157)
        Me.BakupLabel.Name = "BakupLabel"
        Me.BakupLabel.Size = New System.Drawing.Size(67, 20)
        Me.BakupLabel.TabIndex = 5
        Me.BakupLabel.Text = "Backup:"
        '
        'NumericUpDown
        '
        Me.NumericUpDown.BackColor = System.Drawing.Color.Black
        Me.NumericUpDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown.ForeColor = System.Drawing.Color.Lime
        Me.NumericUpDown.Location = New System.Drawing.Point(46, 335)
        Me.NumericUpDown.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.NumericUpDown.Name = "NumericUpDown"
        Me.NumericUpDown.Size = New System.Drawing.Size(102, 31)
        Me.NumericUpDown.TabIndex = 6
        '
        'UpdateButton
        '
        Me.UpdateButton.ForeColor = System.Drawing.Color.Black
        Me.UpdateButton.Location = New System.Drawing.Point(61, 379)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(75, 23)
        Me.UpdateButton.TabIndex = 7
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'AccumulatorOutput
        '
        Me.AccumulatorOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AccumulatorOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccumulatorOutput.Location = New System.Drawing.Point(339, 119)
        Me.AccumulatorOutput.Name = "AccumulatorOutput"
        Me.AccumulatorOutput.Size = New System.Drawing.Size(56, 25)
        Me.AccumulatorOutput.TabIndex = 8
        Me.AccumulatorOutput.Text = "000"
        '
        'BakupOutput
        '
        Me.BakupOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BakupOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BakupOutput.Location = New System.Drawing.Point(339, 160)
        Me.BakupOutput.Name = "BakupOutput"
        Me.BakupOutput.Size = New System.Drawing.Size(56, 22)
        Me.BakupOutput.TabIndex = 9
        Me.BakupOutput.Text = "000"
        '
        'OutputTextBox
        '
        Me.OutputTextBox.BackColor = System.Drawing.Color.Black
        Me.OutputTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OutputTextBox.ForeColor = System.Drawing.Color.Lime
        Me.OutputTextBox.Location = New System.Drawing.Point(200, 277)
        Me.OutputTextBox.Multiline = True
        Me.OutputTextBox.Name = "OutputTextBox"
        Me.OutputTextBox.ReadOnly = True
        Me.OutputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.OutputTextBox.Size = New System.Drawing.Size(255, 108)
        Me.OutputTextBox.TabIndex = 10
        '
        'OutputLabel
        '
        Me.OutputLabel.AutoSize = True
        Me.OutputLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OutputLabel.Location = New System.Drawing.Point(287, 244)
        Me.OutputLabel.Name = "OutputLabel"
        Me.OutputLabel.Size = New System.Drawing.Size(62, 20)
        Me.OutputLabel.TabIndex = 11
        Me.OutputLabel.Text = "Output:"
        '
        'RunButton
        '
        Me.RunButton.ForeColor = System.Drawing.Color.Black
        Me.RunButton.Location = New System.Drawing.Point(274, 412)
        Me.RunButton.Name = "RunButton"
        Me.RunButton.Size = New System.Drawing.Size(75, 23)
        Me.RunButton.TabIndex = 12
        Me.RunButton.Text = "Run"
        Me.RunButton.UseVisualStyleBackColor = True
        '
        'RunTimer
        '
        '
        'OverflowLabel
        '
        Me.OverflowLabel.AutoSize = True
        Me.OverflowLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OverflowLabel.Location = New System.Drawing.Point(206, 196)
        Me.OverflowLabel.Name = "OverflowLabel"
        Me.OverflowLabel.Size = New System.Drawing.Size(74, 20)
        Me.OverflowLabel.TabIndex = 15
        Me.OverflowLabel.Text = "Overflow:"
        '
        'OverflowOutput
        '
        Me.OverflowOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OverflowOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OverflowOutput.Location = New System.Drawing.Point(339, 194)
        Me.OverflowOutput.Name = "OverflowOutput"
        Me.OverflowOutput.Size = New System.Drawing.Size(56, 22)
        Me.OverflowOutput.TabIndex = 16
        Me.OverflowOutput.Text = "False"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.CommandsLabel)
        Me.Panel1.Location = New System.Drawing.Point(482, 139)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(513, 292)
        Me.Panel1.TabIndex = 17
        '
        'CommandsLabel
        '
        Me.CommandsLabel.AutoSize = True
        Me.CommandsLabel.Font = New System.Drawing.Font("Lucida Console", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CommandsLabel.Location = New System.Drawing.Point(11, 7)
        Me.CommandsLabel.Name = "CommandsLabel"
        Me.CommandsLabel.Size = New System.Drawing.Size(757, 456)
        Me.CommandsLabel.TabIndex = 2
        Me.CommandsLabel.Text = resources.GetString("CommandsLabel.Text")
        '
        'Commands2Label
        '
        Me.Commands2Label.AutoSize = True
        Me.Commands2Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Commands2Label.Location = New System.Drawing.Point(662, 94)
        Me.Commands2Label.Name = "Commands2Label"
        Me.Commands2Label.Size = New System.Drawing.Size(112, 24)
        Me.Commands2Label.TabIndex = 18
        Me.Commands2Label.Text = "Commands:"
        '
        'FormMenuStrip
        '
        Me.FormMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.FormMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.FormMenuStrip.Name = "FormMenuStrip"
        Me.FormMenuStrip.Size = New System.Drawing.Size(1019, 24)
        Me.FormMenuStrip.TabIndex = 19
        Me.FormMenuStrip.Text = "FormMenuStrip"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.LoadToolStripMenuItem, Me.ToolStripSeparator1, Me.ClearAllToolStripMenuItem})
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.SaveToolStripMenuItem.Text = "Save Program"
        '
        'LoadToolStripMenuItem
        '
        Me.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem"
        Me.LoadToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.LoadToolStripMenuItem.Text = "Load Program"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(146, 6)
        '
        'ClearAllToolStripMenuItem
        '
        Me.ClearAllToolStripMenuItem.Name = "ClearAllToolStripMenuItem"
        Me.ClearAllToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.ClearAllToolStripMenuItem.Text = "Clear All"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TextColorToolStripMenuItem, Me.BackgroundColorToolStripMenuItem, Me.ToolStripSeparator2, Me.ResetColorsToolStripMenuItem, Me.ToolStripSeparator3, Me.OverclockToolStripMenuItem})
        Me.EditToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'TextColorToolStripMenuItem
        '
        Me.TextColorToolStripMenuItem.Name = "TextColorToolStripMenuItem"
        Me.TextColorToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.TextColorToolStripMenuItem.Text = "Text Color"
        '
        'BackgroundColorToolStripMenuItem
        '
        Me.BackgroundColorToolStripMenuItem.Name = "BackgroundColorToolStripMenuItem"
        Me.BackgroundColorToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.BackgroundColorToolStripMenuItem.Text = "Background Color"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(167, 6)
        '
        'ResetColorsToolStripMenuItem
        '
        Me.ResetColorsToolStripMenuItem.Name = "ResetColorsToolStripMenuItem"
        Me.ResetColorsToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.ResetColorsToolStripMenuItem.Text = "Reset Colors"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(167, 6)
        '
        'OverclockToolStripMenuItem
        '
        Me.OverclockToolStripMenuItem.Name = "OverclockToolStripMenuItem"
        Me.OverclockToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.OverclockToolStripMenuItem.Text = "Overclock"
        '
        'OpenTextFileDialog
        '
        Me.OpenTextFileDialog.Filter = "Text Files|*.txt"
        '
        'SaveTextFileDialog
        '
        Me.SaveTextFileDialog.FileName = "Program"
        Me.SaveTextFileDialog.Filter = "Text Files|*.txt"
        '
        'MainForm
        '
        Me.AcceptButton = Me.UpdateButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1019, 458)
        Me.Controls.Add(Me.Commands2Label)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.OverflowOutput)
        Me.Controls.Add(Me.OverflowLabel)
        Me.Controls.Add(Me.RunButton)
        Me.Controls.Add(Me.OutputLabel)
        Me.Controls.Add(Me.OutputTextBox)
        Me.Controls.Add(Me.BakupOutput)
        Me.Controls.Add(Me.AccumulatorOutput)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.NumericUpDown)
        Me.Controls.Add(Me.BakupLabel)
        Me.Controls.Add(Me.AccLabel)
        Me.Controls.Add(Me.MemoryLabel)
        Me.Controls.Add(Me.MemoryListBox)
        Me.Controls.Add(Me.BasicAssemblyLabel)
        Me.Controls.Add(Me.FormMenuStrip)
        Me.ForeColor = System.Drawing.Color.Lime
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.FormMenuStrip
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Basic Assembly"
        CType(Me.NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.FormMenuStrip.ResumeLayout(False)
        Me.FormMenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BasicAssemblyLabel As System.Windows.Forms.Label
    Friend WithEvents MemoryListBox As System.Windows.Forms.ListBox
    Friend WithEvents MemoryLabel As System.Windows.Forms.Label
    Friend WithEvents AccLabel As System.Windows.Forms.Label
    Friend WithEvents BakupLabel As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents UpdateButton As System.Windows.Forms.Button
    Friend WithEvents AccumulatorOutput As System.Windows.Forms.Label
    Friend WithEvents BakupOutput As System.Windows.Forms.Label
    Friend WithEvents OutputTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OutputLabel As System.Windows.Forms.Label
    Friend WithEvents RunButton As System.Windows.Forms.Button
    Friend WithEvents RunTimer As System.Windows.Forms.Timer
    Friend WithEvents OverflowLabel As System.Windows.Forms.Label
    Friend WithEvents OverflowOutput As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CommandsLabel As System.Windows.Forms.Label
    Friend WithEvents Commands2Label As System.Windows.Forms.Label
    Friend WithEvents FormMenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenTextFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveTextFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ClearAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackgroundColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorDialog As System.Windows.Forms.ColorDialog
    Friend WithEvents ResetColorsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents OverclockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class

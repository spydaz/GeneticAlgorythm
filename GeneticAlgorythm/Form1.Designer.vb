<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGeneticLearner
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
        Me.TextBoxOutput = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.NumericMutationRate = New System.Windows.Forms.NumericUpDown()
        Me.NumericPopulation = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxDisplayStats = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonExecute = New System.Windows.Forms.Button()
        Me.TextBoxPhrase = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericMutationRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericPopulation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBoxOutput
        '
        Me.TextBoxOutput.Location = New System.Drawing.Point(12, 70)
        Me.TextBoxOutput.Multiline = True
        Me.TextBoxOutput.Name = "TextBoxOutput"
        Me.TextBoxOutput.Size = New System.Drawing.Size(347, 540)
        Me.TextBoxOutput.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.NumericMutationRate)
        Me.GroupBox1.Controls.Add(Me.NumericPopulation)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBoxDisplayStats)
        Me.GroupBox1.Location = New System.Drawing.Point(377, 248)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(460, 362)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Settings"
        '
        'NumericMutationRate
        '
        Me.NumericMutationRate.Location = New System.Drawing.Point(10, 334)
        Me.NumericMutationRate.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericMutationRate.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericMutationRate.Name = "NumericMutationRate"
        Me.NumericMutationRate.Size = New System.Drawing.Size(65, 22)
        Me.NumericMutationRate.TabIndex = 19
        Me.NumericMutationRate.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'NumericPopulation
        '
        Me.NumericPopulation.Location = New System.Drawing.Point(11, 279)
        Me.NumericPopulation.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NumericPopulation.Name = "NumericPopulation"
        Me.NumericPopulation.Size = New System.Drawing.Size(64, 22)
        Me.NumericPopulation.TabIndex = 18
        Me.NumericPopulation.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 310)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 17)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Mutation Rate"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 252)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 17)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Population Size"
        '
        'TextBoxDisplayStats
        '
        Me.TextBoxDisplayStats.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBoxDisplayStats.Location = New System.Drawing.Point(3, 18)
        Me.TextBoxDisplayStats.Multiline = True
        Me.TextBoxDisplayStats.Name = "TextBoxDisplayStats"
        Me.TextBoxDisplayStats.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxDisplayStats.Size = New System.Drawing.Size(454, 216)
        Me.TextBoxDisplayStats.TabIndex = 13
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.ButtonExecute)
        Me.GroupBox2.Controls.Add(Me.TextBoxPhrase)
        Me.GroupBox2.Location = New System.Drawing.Point(382, 72)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(451, 130)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Learning"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Phrase to be learnt"
        '
        'ButtonExecute
        '
        Me.ButtonExecute.Location = New System.Drawing.Point(353, 101)
        Me.ButtonExecute.Name = "ButtonExecute"
        Me.ButtonExecute.Size = New System.Drawing.Size(75, 23)
        Me.ButtonExecute.TabIndex = 9
        Me.ButtonExecute.Text = "Execute"
        Me.ButtonExecute.UseVisualStyleBackColor = True
        '
        'TextBoxPhrase
        '
        Me.TextBoxPhrase.Location = New System.Drawing.Point(6, 64)
        Me.TextBoxPhrase.Name = "TextBoxPhrase"
        Me.TextBoxPhrase.Size = New System.Drawing.Size(422, 22)
        Me.TextBoxPhrase.TabIndex = 8
        '
        'FormGeneticLearner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(853, 622)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBoxOutput)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormGeneticLearner"
        Me.Text = "Genetic Learing Algorhythm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumericMutationRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericPopulation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxOutput As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents NumericMutationRate As NumericUpDown
    Friend WithEvents NumericPopulation As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxDisplayStats As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonExecute As Button
    Friend WithEvents TextBoxPhrase As TextBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnGetScore = New System.Windows.Forms.Button()
        Me.lstScores = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnGetScore
        '
        Me.btnGetScore.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetScore.Location = New System.Drawing.Point(12, 12)
        Me.btnGetScore.Name = "btnGetScore"
        Me.btnGetScore.Size = New System.Drawing.Size(200, 38)
        Me.btnGetScore.TabIndex = 0
        Me.btnGetScore.Text = "Get Score"
        Me.btnGetScore.UseVisualStyleBackColor = True
        '
        'lstScores
        '
        Me.lstScores.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstScores.FormattingEnabled = True
        Me.lstScores.ItemHeight = 15
        Me.lstScores.Location = New System.Drawing.Point(12, 56)
        Me.lstScores.Name = "lstScores"
        Me.lstScores.Size = New System.Drawing.Size(200, 169)
        Me.lstScores.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(226, 241)
        Me.Controls.Add(Me.lstScores)
        Me.Controls.Add(Me.btnGetScore)
        Me.Name = "Form1"
        Me.Text = "(Insert Sport Here) Teams Scores"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnGetScore As Button
    Friend WithEvents lstScores As ListBox
End Class

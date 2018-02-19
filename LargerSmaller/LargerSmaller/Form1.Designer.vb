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
        Me.lblTwoIntegers = New System.Windows.Forms.Label()
        Me.lblA = New System.Windows.Forms.Label()
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.lblB = New System.Windows.Forms.Label()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.btnCompare = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTwoIntegers
        '
        Me.lblTwoIntegers.AutoSize = True
        Me.lblTwoIntegers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTwoIntegers.Location = New System.Drawing.Point(65, 18)
        Me.lblTwoIntegers.Name = "lblTwoIntegers"
        Me.lblTwoIntegers.Size = New System.Drawing.Size(137, 16)
        Me.lblTwoIntegers.TabIndex = 0
        Me.lblTwoIntegers.Text = "Enter Two Integers"
        '
        'lblA
        '
        Me.lblA.AutoSize = True
        Me.lblA.Location = New System.Drawing.Point(13, 60)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(17, 13)
        Me.lblA.TabIndex = 1
        Me.lblA.Text = "A:"
        '
        'txtA
        '
        Me.txtA.Location = New System.Drawing.Point(68, 60)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(56, 20)
        Me.txtA.TabIndex = 2
        '
        'lblB
        '
        Me.lblB.AutoSize = True
        Me.lblB.Location = New System.Drawing.Point(148, 60)
        Me.lblB.Name = "lblB"
        Me.lblB.Size = New System.Drawing.Size(17, 13)
        Me.lblB.TabIndex = 3
        Me.lblB.Text = "B:"
        '
        'txtB
        '
        Me.txtB.Location = New System.Drawing.Point(205, 60)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(56, 20)
        Me.txtB.TabIndex = 4
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Location = New System.Drawing.Point(124, 123)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(0, 13)
        Me.lblMessage.TabIndex = 5
        '
        'btnCompare
        '
        Me.btnCompare.Location = New System.Drawing.Point(49, 172)
        Me.btnCompare.Name = "btnCompare"
        Me.btnCompare.Size = New System.Drawing.Size(75, 23)
        Me.btnCompare.TabIndex = 6
        Me.btnCompare.Text = "Compare"
        Me.btnCompare.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(160, 172)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCompare)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.lblB)
        Me.Controls.Add(Me.txtA)
        Me.Controls.Add(Me.lblA)
        Me.Controls.Add(Me.lblTwoIntegers)
        Me.Name = "Form1"
        Me.Text = "Larger and Smaller"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTwoIntegers As Label
    Friend WithEvents lblA As Label
    Friend WithEvents txtA As TextBox
    Friend WithEvents lblB As Label
    Friend WithEvents txtB As TextBox
    Friend WithEvents lblMessage As Label
    Friend WithEvents btnCompare As Button
    Friend WithEvents btnExit As Button
End Class

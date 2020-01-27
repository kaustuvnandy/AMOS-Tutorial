<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Query_Select
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.View = New System.Windows.Forms.Button()
        Me.Quit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter the search word here"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(28, 100)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(453, 22)
        Me.TextBox1.TabIndex = 1
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(28, 145)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(453, 212)
        Me.ListBox1.TabIndex = 2
        '
        'View
        '
        Me.View.Location = New System.Drawing.Point(282, 377)
        Me.View.Name = "View"
        Me.View.Size = New System.Drawing.Size(83, 34)
        Me.View.TabIndex = 3
        Me.View.Text = "View"
        Me.View.UseVisualStyleBackColor = True
        '
        'Quit
        '
        Me.Quit.Location = New System.Drawing.Point(398, 377)
        Me.Quit.Name = "Quit"
        Me.Quit.Size = New System.Drawing.Size(83, 34)
        Me.Quit.TabIndex = 4
        Me.Quit.Text = "Exit"
        Me.Quit.UseVisualStyleBackColor = True
        '
        'Query_Select
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 440)
        Me.Controls.Add(Me.Quit)
        Me.Controls.Add(Me.View)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Query_Select"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select Query"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents TextBox1 As Windows.Forms.TextBox
    Friend WithEvents ListBox1 As Windows.Forms.ListBox
    Friend WithEvents View As Windows.Forms.Button
    Friend WithEvents Quit As Windows.Forms.Button
End Class

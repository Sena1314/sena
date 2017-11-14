<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class hobiler
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.kaydetb = New System.Windows.Forms.Button()
        Me.devamb = New System.Windows.Forms.Button()
        Me.hobib = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"SANAT", "SAĞLIK", "BİLİM", "YAŞAM"})
        Me.ComboBox1.Location = New System.Drawing.Point(77, 54)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(77, 98)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Kategori:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "İlgi Alanı:"
        '
        'kaydetb
        '
        Me.kaydetb.Location = New System.Drawing.Point(306, 280)
        Me.kaydetb.Name = "kaydetb"
        Me.kaydetb.Size = New System.Drawing.Size(75, 23)
        Me.kaydetb.TabIndex = 4
        Me.kaydetb.Text = "Kaydet"
        Me.kaydetb.UseVisualStyleBackColor = True
        '
        'devamb
        '
        Me.devamb.Location = New System.Drawing.Point(420, 280)
        Me.devamb.Name = "devamb"
        Me.devamb.Size = New System.Drawing.Size(75, 23)
        Me.devamb.TabIndex = 5
        Me.devamb.Text = "Devam Et"
        Me.devamb.UseVisualStyleBackColor = True
        '
        'hobib
        '
        Me.hobib.Location = New System.Drawing.Point(42, 280)
        Me.hobib.Name = "hobib"
        Me.hobib.Size = New System.Drawing.Size(110, 23)
        Me.hobib.TabIndex = 6
        Me.hobib.Text = "Yeni Hobi Ekle"
        Me.hobib.UseVisualStyleBackColor = True
        '
        'hobiler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 335)
        Me.Controls.Add(Me.hobib)
        Me.Controls.Add(Me.devamb)
        Me.Controls.Add(Me.kaydetb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "hobiler"
        Me.Text = "hobiler"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents kaydetb As Button
    Friend WithEvents devamb As Button
    Friend WithEvents hobib As Button
End Class

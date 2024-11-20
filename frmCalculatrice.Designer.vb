<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCalculatrice
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
        Lbl_a = New Label()
        res = New Label()
        Lbl_b = New Label()
        val_a = New TextBox()
        Btn_plus = New Button()
        Byn_fois = New Button()
        Btn_div = New Button()
        Btn_equal = New Button()
        Btn_moins = New Button()
        Btn_rest = New Button()
        val_b = New TextBox()
        SuspendLayout()
        ' 
        ' Lbl_a
        ' 
        Lbl_a.AutoSize = True
        Lbl_a.Font = New Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl_a.Location = New Point(128, 74)
        Lbl_a.Name = "Lbl_a"
        Lbl_a.Size = New Size(36, 36)
        Lbl_a.TabIndex = 0
        Lbl_a.Text = "A"
        ' 
        ' res
        ' 
        res.AutoSize = True
        res.Font = New Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        res.Location = New Point(399, 365)
        res.Name = "res"
        res.Size = New Size(131, 36)
        res.TabIndex = 1
        res.Text = "resultat"
        ' 
        ' Lbl_b
        ' 
        Lbl_b.AutoSize = True
        Lbl_b.Font = New Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl_b.Location = New Point(128, 123)
        Lbl_b.Name = "Lbl_b"
        Lbl_b.Size = New Size(34, 36)
        Lbl_b.TabIndex = 2
        Lbl_b.Text = "b"
        ' 
        ' val_a
        ' 
        val_a.Location = New Point(181, 76)
        val_a.Name = "val_a"
        val_a.Size = New Size(125, 39)
        val_a.TabIndex = 4
        ' 
        ' Btn_plus
        ' 
        Btn_plus.ForeColor = Color.IndianRed
        Btn_plus.Location = New Point(81, 196)
        Btn_plus.Name = "Btn_plus"
        Btn_plus.Size = New Size(83, 35)
        Btn_plus.TabIndex = 5
        Btn_plus.Text = "+"
        Btn_plus.UseVisualStyleBackColor = True
        ' 
        ' Byn_fois
        ' 
        Byn_fois.Location = New Point(270, 196)
        Byn_fois.Name = "Byn_fois"
        Byn_fois.Size = New Size(94, 29)
        Byn_fois.TabIndex = 6
        Byn_fois.Text = "*"
        Byn_fois.UseVisualStyleBackColor = True
        ' 
        ' Btn_div
        ' 
        Btn_div.Location = New Point(81, 237)
        Btn_div.Name = "Btn_div"
        Btn_div.Size = New Size(94, 29)
        Btn_div.TabIndex = 7
        Btn_div.Text = "/"
        Btn_div.UseVisualStyleBackColor = True
        ' 
        ' Btn_equal
        ' 
        Btn_equal.Location = New Point(181, 237)
        Btn_equal.Name = "Btn_equal"
        Btn_equal.Size = New Size(94, 29)
        Btn_equal.TabIndex = 8
        Btn_equal.Text = "="
        Btn_equal.UseVisualStyleBackColor = True
        ' 
        ' Btn_moins
        ' 
        Btn_moins.Location = New Point(170, 199)
        Btn_moins.Name = "Btn_moins"
        Btn_moins.Size = New Size(94, 29)
        Btn_moins.TabIndex = 9
        Btn_moins.Text = "-"
        Btn_moins.UseVisualStyleBackColor = True
        ' 
        ' Btn_rest
        ' 
        Btn_rest.Location = New Point(281, 231)
        Btn_rest.Name = "Btn_rest"
        Btn_rest.Size = New Size(105, 29)
        Btn_rest.TabIndex = 10
        Btn_rest.Text = "reset"
        Btn_rest.UseVisualStyleBackColor = True
        ' 
        ' val_b
        ' 
        val_b.Location = New Point(181, 125)
        val_b.Name = "val_b"
        val_b.Size = New Size(125, 39)
        val_b.TabIndex = 11
        ' 
        ' frmCalculatrice
        ' 
        AutoScaleDimensions = New SizeF(17F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1700, 720)
        Controls.Add(val_b)
        Controls.Add(Btn_rest)
        Controls.Add(Btn_moins)
        Controls.Add(Btn_equal)
        Controls.Add(Btn_div)
        Controls.Add(Byn_fois)
        Controls.Add(Btn_plus)
        Controls.Add(val_a)
        Controls.Add(Lbl_b)
        Controls.Add(res)
        Controls.Add(Lbl_a)
        Font = New Font("Stencil", 16.2F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.IndianRed
        Margin = New Padding(6, 5, 6, 5)
        Name = "frmCalculatrice"
        Text = "Calculatrice"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Lbl_a As Label
    Friend WithEvents res As Label
    Friend WithEvents Lbl_b As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LBL_RS As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Btn_plus As Button
    Friend WithEvents Byn_fois As Button
    Friend WithEvents Btn_equ As Button
    Friend WithEvents Btn_moins As Button
    Friend WithEvents Btn_rest As Button
    Friend WithEvents Btn_equal As Button
    Friend WithEvents val_a As TextBox
    Friend WithEvents val_b As TextBox
    Friend WithEvents Btn_div As Button

End Class

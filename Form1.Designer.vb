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
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCategoria = New System.Windows.Forms.Label()
        Me.btnCompro = New System.Windows.Forms.Button()
        Me.cmdReini = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitulo.Location = New System.Drawing.Point(77, 22)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(254, 17)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Categoria de box segun el registro peso"
        '
        'txtPeso
        '
        Me.txtPeso.Location = New System.Drawing.Point(153, 96)
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(100, 23)
        Me.txtPeso.TabIndex = 1
        ' Me.txtPeso.Text = "KG"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(110, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Peso"
        '
        'lblCategoria
        '
        Me.lblCategoria.AutoSize = True
        Me.lblCategoria.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCategoria.Location = New System.Drawing.Point(87, 169)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(0, 17)
        Me.lblCategoria.TabIndex = 3
        '
        'btnCompro
        '
        Me.btnCompro.Location = New System.Drawing.Point(163, 125)
        Me.btnCompro.Name = "btnCompro"
        Me.btnCompro.Size = New System.Drawing.Size(75, 23)
        Me.btnCompro.TabIndex = 4
        Me.btnCompro.Text = "Calcular"
        Me.btnCompro.UseVisualStyleBackColor = True
        '
        'cmdReini
        '
        Me.cmdReini.Location = New System.Drawing.Point(163, 208)
        Me.cmdReini.Name = "cmdReini"
        Me.cmdReini.Size = New System.Drawing.Size(75, 23)
        Me.cmdReini.TabIndex = 5
        Me.cmdReini.Text = "REINICIAR"
        Me.cmdReini.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 354)
        Me.Controls.Add(Me.cmdReini)
        Me.Controls.Add(Me.btnCompro)
        Me.Controls.Add(Me.lblCategoria)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPeso)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents txtPeso As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCategoria As Label
    Friend WithEvents btnCompro As Button
    Friend WithEvents cmdReini As Button
End Class

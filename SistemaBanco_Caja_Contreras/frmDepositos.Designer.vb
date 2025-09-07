<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDepositos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn200 = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btn100 = New System.Windows.Forms.Button()
        Me.btnOtraCantidad = New System.Windows.Forms.Button()
        Me.btn50 = New System.Windows.Forms.Button()
        Me.btn1000 = New System.Windows.Forms.Button()
        Me.btn20 = New System.Windows.Forms.Button()
        Me.btn500 = New System.Windows.Forms.Button()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(375, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 29)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "Cantidad"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Myanmar Text", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(548, 330)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(196, 48)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Otra cantidad"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Myanmar Text", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(137, 233)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 48)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "$50"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Myanmar Text", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(137, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 48)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "$20"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Myanmar Text", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(644, 242)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 48)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "$1000"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Myanmar Text", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(137, 321)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 48)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "$100"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Myanmar Text", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(660, 154)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 48)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "$500"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Myanmar Text", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(137, 409)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 48)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "$200"
        '
        'btn200
        '
        Me.btn200.AutoSize = True
        Me.btn200.Location = New System.Drawing.Point(25, 391)
        Me.btn200.Name = "btn200"
        Me.btn200.Size = New System.Drawing.Size(106, 82)
        Me.btn200.TabIndex = 35
        Me.btn200.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.AutoSize = True
        Me.btnSalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSalir.Location = New System.Drawing.Point(761, 409)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(109, 64)
        Me.btnSalir.TabIndex = 34
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btn100
        '
        Me.btn100.AutoSize = True
        Me.btn100.Location = New System.Drawing.Point(25, 303)
        Me.btn100.Name = "btn100"
        Me.btn100.Size = New System.Drawing.Size(106, 82)
        Me.btn100.TabIndex = 33
        Me.btn100.UseVisualStyleBackColor = True
        '
        'btnOtraCantidad
        '
        Me.btnOtraCantidad.AutoSize = True
        Me.btnOtraCantidad.Location = New System.Drawing.Point(761, 312)
        Me.btnOtraCantidad.Name = "btnOtraCantidad"
        Me.btnOtraCantidad.Size = New System.Drawing.Size(106, 82)
        Me.btnOtraCantidad.TabIndex = 32
        Me.btnOtraCantidad.UseVisualStyleBackColor = True
        '
        'btn50
        '
        Me.btn50.AutoSize = True
        Me.btn50.Location = New System.Drawing.Point(25, 215)
        Me.btn50.Name = "btn50"
        Me.btn50.Size = New System.Drawing.Size(106, 82)
        Me.btn50.TabIndex = 31
        Me.btn50.UseVisualStyleBackColor = True
        '
        'btn1000
        '
        Me.btn1000.AutoSize = True
        Me.btn1000.Location = New System.Drawing.Point(761, 224)
        Me.btn1000.Name = "btn1000"
        Me.btn1000.Size = New System.Drawing.Size(106, 82)
        Me.btn1000.TabIndex = 30
        Me.btn1000.UseVisualStyleBackColor = True
        '
        'btn20
        '
        Me.btn20.AutoSize = True
        Me.btn20.Location = New System.Drawing.Point(25, 120)
        Me.btn20.Name = "btn20"
        Me.btn20.Size = New System.Drawing.Size(106, 82)
        Me.btn20.TabIndex = 29
        Me.btn20.UseVisualStyleBackColor = True
        '
        'btn500
        '
        Me.btn500.AutoSize = True
        Me.btn500.Location = New System.Drawing.Point(761, 129)
        Me.btn500.Name = "btn500"
        Me.btn500.Size = New System.Drawing.Size(106, 82)
        Me.btn500.TabIndex = 28
        Me.btn500.UseVisualStyleBackColor = True
        '
        'txtCantidad
        '
        Me.txtCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.txtCantidad.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtCantidad.Location = New System.Drawing.Point(298, 66)
        Me.txtCantidad.Multiline = True
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(273, 91)
        Me.txtCantidad.TabIndex = 45
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(635, 409)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 64)
        Me.Button1.TabIndex = 46
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Location = New System.Drawing.Point(577, 85)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 50)
        Me.Button2.TabIndex = 47
        Me.Button2.Text = "ACEPTAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmDepositos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.ClientSize = New System.Drawing.Size(904, 519)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn200)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btn100)
        Me.Controls.Add(Me.btnOtraCantidad)
        Me.Controls.Add(Me.btn50)
        Me.Controls.Add(Me.btn1000)
        Me.Controls.Add(Me.btn20)
        Me.Controls.Add(Me.btn500)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Name = "frmDepositos"
        Me.Text = "frmDepositos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Private WithEvents Label8 As System.Windows.Forms.Label
    Private WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents btn200 As System.Windows.Forms.Button
    Private WithEvents btnSalir As System.Windows.Forms.Button
    Private WithEvents btn100 As System.Windows.Forms.Button
    Private WithEvents btnOtraCantidad As System.Windows.Forms.Button
    Private WithEvents btn50 As System.Windows.Forms.Button
    Private WithEvents btn1000 As System.Windows.Forms.Button
    Private WithEvents btn20 As System.Windows.Forms.Button
    Private WithEvents btn500 As System.Windows.Forms.Button
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Private WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class

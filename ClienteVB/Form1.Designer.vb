<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnSumar = New System.Windows.Forms.Button()
        Me.tb_nro1 = New System.Windows.Forms.TextBox()
        Me.tb_nro2 = New System.Windows.Forms.TextBox()
        Me.btnResta = New System.Windows.Forms.Button()
        Me.btnMultiplicacion = New System.Windows.Forms.Button()
        Me.btnDivision = New System.Windows.Forms.Button()
        Me.btnPotencia = New System.Windows.Forms.Button()
        Me.btnRaiz = New System.Windows.Forms.Button()
        Me.btnPorcentaje = New System.Windows.Forms.Button()
        Me.btnFactorial = New System.Windows.Forms.Button()
        Me.btnSeno = New System.Windows.Forms.Button()
        Me.btnCoseno = New System.Windows.Forms.Button()
        Me.tb_resultado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtResultado = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.a = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSumar
        '
        Me.btnSumar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSumar.Location = New System.Drawing.Point(47, 115)
        Me.btnSumar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSumar.Name = "btnSumar"
        Me.btnSumar.Size = New System.Drawing.Size(56, 28)
        Me.btnSumar.TabIndex = 0
        Me.btnSumar.Text = "+"
        Me.btnSumar.UseVisualStyleBackColor = True
        '
        'tb_nro1
        '
        Me.tb_nro1.Location = New System.Drawing.Point(47, 69)
        Me.tb_nro1.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_nro1.Name = "tb_nro1"
        Me.tb_nro1.Size = New System.Drawing.Size(76, 20)
        Me.tb_nro1.TabIndex = 1
        '
        'tb_nro2
        '
        Me.tb_nro2.Location = New System.Drawing.Point(150, 69)
        Me.tb_nro2.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_nro2.Name = "tb_nro2"
        Me.tb_nro2.Size = New System.Drawing.Size(76, 20)
        Me.tb_nro2.TabIndex = 2
        '
        'btnResta
        '
        Me.btnResta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResta.Location = New System.Drawing.Point(108, 115)
        Me.btnResta.Margin = New System.Windows.Forms.Padding(2)
        Me.btnResta.Name = "btnResta"
        Me.btnResta.Size = New System.Drawing.Size(56, 28)
        Me.btnResta.TabIndex = 3
        Me.btnResta.Text = "-"
        Me.btnResta.UseVisualStyleBackColor = True
        '
        'btnMultiplicacion
        '
        Me.btnMultiplicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMultiplicacion.Location = New System.Drawing.Point(168, 115)
        Me.btnMultiplicacion.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMultiplicacion.Name = "btnMultiplicacion"
        Me.btnMultiplicacion.Size = New System.Drawing.Size(56, 28)
        Me.btnMultiplicacion.TabIndex = 4
        Me.btnMultiplicacion.Text = "*"
        Me.btnMultiplicacion.UseVisualStyleBackColor = True
        '
        'btnDivision
        '
        Me.btnDivision.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDivision.Location = New System.Drawing.Point(47, 155)
        Me.btnDivision.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDivision.Name = "btnDivision"
        Me.btnDivision.Size = New System.Drawing.Size(56, 32)
        Me.btnDivision.TabIndex = 5
        Me.btnDivision.Text = "÷"
        Me.btnDivision.UseVisualStyleBackColor = True
        '
        'btnPotencia
        '
        Me.btnPotencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPotencia.Location = New System.Drawing.Point(108, 155)
        Me.btnPotencia.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPotencia.Name = "btnPotencia"
        Me.btnPotencia.Size = New System.Drawing.Size(56, 32)
        Me.btnPotencia.TabIndex = 6
        Me.btnPotencia.Text = "^"
        Me.btnPotencia.UseVisualStyleBackColor = True
        '
        'btnRaiz
        '
        Me.btnRaiz.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRaiz.Location = New System.Drawing.Point(168, 155)
        Me.btnRaiz.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRaiz.Name = "btnRaiz"
        Me.btnRaiz.Size = New System.Drawing.Size(56, 32)
        Me.btnRaiz.TabIndex = 7
        Me.btnRaiz.Text = "√ "
        Me.btnRaiz.UseVisualStyleBackColor = True
        '
        'btnPorcentaje
        '
        Me.btnPorcentaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPorcentaje.Location = New System.Drawing.Point(47, 200)
        Me.btnPorcentaje.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPorcentaje.Name = "btnPorcentaje"
        Me.btnPorcentaje.Size = New System.Drawing.Size(56, 29)
        Me.btnPorcentaje.TabIndex = 8
        Me.btnPorcentaje.Text = "%"
        Me.btnPorcentaje.UseVisualStyleBackColor = True
        '
        'btnFactorial
        '
        Me.btnFactorial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFactorial.Location = New System.Drawing.Point(108, 200)
        Me.btnFactorial.Margin = New System.Windows.Forms.Padding(2)
        Me.btnFactorial.Name = "btnFactorial"
        Me.btnFactorial.Size = New System.Drawing.Size(56, 29)
        Me.btnFactorial.TabIndex = 9
        Me.btnFactorial.Text = "!"
        Me.btnFactorial.UseVisualStyleBackColor = True
        '
        'btnSeno
        '
        Me.btnSeno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeno.Location = New System.Drawing.Point(168, 200)
        Me.btnSeno.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSeno.Name = "btnSeno"
        Me.btnSeno.Size = New System.Drawing.Size(56, 29)
        Me.btnSeno.TabIndex = 10
        Me.btnSeno.Text = "Sen"
        Me.btnSeno.UseVisualStyleBackColor = True
        '
        'btnCoseno
        '
        Me.btnCoseno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCoseno.Location = New System.Drawing.Point(108, 241)
        Me.btnCoseno.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCoseno.Name = "btnCoseno"
        Me.btnCoseno.Size = New System.Drawing.Size(56, 28)
        Me.btnCoseno.TabIndex = 11
        Me.btnCoseno.Text = "Cos"
        Me.btnCoseno.UseVisualStyleBackColor = True
        '
        'tb_resultado
        '
        Me.tb_resultado.Location = New System.Drawing.Point(47, 327)
        Me.tb_resultado.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_resultado.Name = "tb_resultado"
        Me.tb_resultado.Size = New System.Drawing.Size(179, 20)
        Me.tb_resultado.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(54, 42)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 17)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Numero1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtResultado
        '
        Me.txtResultado.AutoSize = True
        Me.txtResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResultado.Location = New System.Drawing.Point(106, 300)
        Me.txtResultado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(81, 17)
        Me.txtResultado.TabIndex = 15
        Me.txtResultado.Text = "Resultado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(155, 42)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 17)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Numero2"
        '
        'a
        '
        Me.a.AutoSize = True
        Me.a.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.a.ForeColor = System.Drawing.SystemColors.Info
        Me.a.Location = New System.Drawing.Point(17, 7)
        Me.a.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.a.Name = "a"
        Me.a.Size = New System.Drawing.Size(248, 25)
        Me.a.TabIndex = 16
        Me.a.Text = "Operaciones Aritméticas"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(278, 362)
        Me.Controls.Add(Me.a)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tb_resultado)
        Me.Controls.Add(Me.btnCoseno)
        Me.Controls.Add(Me.btnSeno)
        Me.Controls.Add(Me.btnFactorial)
        Me.Controls.Add(Me.btnPorcentaje)
        Me.Controls.Add(Me.btnRaiz)
        Me.Controls.Add(Me.btnPotencia)
        Me.Controls.Add(Me.btnDivision)
        Me.Controls.Add(Me.btnMultiplicacion)
        Me.Controls.Add(Me.btnResta)
        Me.Controls.Add(Me.tb_nro2)
        Me.Controls.Add(Me.tb_nro1)
        Me.Controls.Add(Me.btnSumar)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSumar As Button
    Friend WithEvents tb_nro1 As TextBox
    Friend WithEvents tb_nro2 As TextBox
    Friend WithEvents btnResta As Button
    Friend WithEvents btnMultiplicacion As Button
    Friend WithEvents btnDivision As Button
    Friend WithEvents btnPotencia As Button
    Friend WithEvents btnRaiz As Button
    Friend WithEvents btnPorcentaje As Button
    Friend WithEvents btnFactorial As Button
    Friend WithEvents btnSeno As Button
    Friend WithEvents btnCoseno As Button
    Friend WithEvents tb_resultado As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtResultado As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents a As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CalculatorView
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
        lbl_num1 = New Label()
        lbl_operacion = New Label()
        lbl_num2 = New Label()
        txt_num1 = New TextBox()
        txt_num2 = New TextBox()
        cbx_operaciones = New ComboBox()
        lbl_resultadoCSharp = New Label()
        lbl_resultadoFSharp = New Label()
        btn_calcular = New Button()
        SuspendLayout()
        ' 
        ' lbl_num1
        ' 
        lbl_num1.AutoSize = True
        lbl_num1.Location = New Point(46, 67)
        lbl_num1.Name = "lbl_num1"
        lbl_num1.Size = New Size(63, 15)
        lbl_num1.TabIndex = 0
        lbl_num1.Text = "Numero 1:"
        ' 
        ' lbl_operacion
        ' 
        lbl_operacion.AutoSize = True
        lbl_operacion.Location = New Point(46, 142)
        lbl_operacion.Name = "lbl_operacion"
        lbl_operacion.Size = New Size(65, 15)
        lbl_operacion.TabIndex = 1
        lbl_operacion.Text = "Operacion:"
        ' 
        ' lbl_num2
        ' 
        lbl_num2.AutoSize = True
        lbl_num2.Location = New Point(46, 105)
        lbl_num2.Name = "lbl_num2"
        lbl_num2.Size = New Size(63, 15)
        lbl_num2.TabIndex = 2
        lbl_num2.Text = "Numero 2:"
        ' 
        ' txt_num1
        ' 
        txt_num1.Location = New Point(121, 67)
        txt_num1.Name = "txt_num1"
        txt_num1.Size = New Size(138, 23)
        txt_num1.TabIndex = 3
        ' 
        ' txt_num2
        ' 
        txt_num2.Location = New Point(121, 102)
        txt_num2.Name = "txt_num2"
        txt_num2.Size = New Size(138, 23)
        txt_num2.TabIndex = 4
        ' 
        ' cbx_operaciones
        ' 
        cbx_operaciones.FormattingEnabled = True
        cbx_operaciones.Items.AddRange(New Object() {"Sumar", "Restar", "Multiplicar", "Dividir"})
        cbx_operaciones.Location = New Point(121, 139)
        cbx_operaciones.Name = "cbx_operaciones"
        cbx_operaciones.Size = New Size(138, 23)
        cbx_operaciones.TabIndex = 5
        ' 
        ' lbl_resultadoCSharp
        ' 
        lbl_resultadoCSharp.AutoSize = True
        lbl_resultadoCSharp.Location = New Point(298, 70)
        lbl_resultadoCSharp.Name = "lbl_resultadoCSharp"
        lbl_resultadoCSharp.Size = New Size(0, 15)
        lbl_resultadoCSharp.TabIndex = 6
        ' 
        ' lbl_resultadoFSharp
        ' 
        lbl_resultadoFSharp.AutoSize = True
        lbl_resultadoFSharp.Location = New Point(298, 105)
        lbl_resultadoFSharp.Name = "lbl_resultadoFSharp"
        lbl_resultadoFSharp.Size = New Size(0, 15)
        lbl_resultadoFSharp.TabIndex = 7
        ' 
        ' btn_calcular
        ' 
        btn_calcular.BackColor = Color.Green
        btn_calcular.FlatAppearance.BorderSize = 0
        btn_calcular.FlatStyle = FlatStyle.Flat
        btn_calcular.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btn_calcular.ForeColor = SystemColors.ButtonHighlight
        btn_calcular.Location = New Point(50, 178)
        btn_calcular.Name = "btn_calcular"
        btn_calcular.Size = New Size(209, 36)
        btn_calcular.TabIndex = 8
        btn_calcular.Text = "Calcular"
        btn_calcular.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(519, 252)
        Controls.Add(btn_calcular)
        Controls.Add(lbl_resultadoFSharp)
        Controls.Add(lbl_resultadoCSharp)
        Controls.Add(cbx_operaciones)
        Controls.Add(txt_num2)
        Controls.Add(txt_num1)
        Controls.Add(lbl_num2)
        Controls.Add(lbl_operacion)
        Controls.Add(lbl_num1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbl_num1 As Label
    Friend WithEvents lbl_operacion As Label
    Friend WithEvents lbl_num2 As Label
    Friend WithEvents txt_num1 As TextBox
    Friend WithEvents txt_num2 As TextBox
    Friend WithEvents cbx_operaciones As ComboBox
    Friend WithEvents lbl_resultadoCSharp As Label
    Friend WithEvents lbl_resultadoFSharp As Label
    Friend WithEvents btn_calcular As Button
End Class

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
        Label1 = New Label()
        Label2 = New Label()
        Numero = New TextBox()
        Evaluar = New Button()
        resultadoPar = New Label()
        resultadoImpar = New Label()
        limpiar = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(243, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(142, 20)
        Label1.TabIndex = 0
        Label1.Text = "Numero Par e Impar"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(46, 82)
        Label2.Name = "Label2"
        Label2.Size = New Size(124, 20)
        Label2.TabIndex = 1
        Label2.Text = "Igresa un numero"
        ' 
        ' Numero
        ' 
        Numero.Location = New Point(200, 82)
        Numero.Name = "Numero"
        Numero.Size = New Size(125, 27)
        Numero.TabIndex = 2
        ' 
        ' Evaluar
        ' 
        Evaluar.Location = New Point(376, 82)
        Evaluar.Name = "Evaluar"
        Evaluar.Size = New Size(94, 29)
        Evaluar.TabIndex = 3
        Evaluar.Text = "Evaluar"
        Evaluar.UseVisualStyleBackColor = True
        ' 
        ' resultadoPar
        ' 
        resultadoPar.AutoSize = True
        resultadoPar.Location = New Point(510, 86)
        resultadoPar.Name = "resultadoPar"
        resultadoPar.Size = New Size(29, 20)
        resultadoPar.TabIndex = 4
        resultadoPar.Text = "Par"
        ' 
        ' resultadoImpar
        ' 
        resultadoImpar.AutoSize = True
        resultadoImpar.Location = New Point(510, 120)
        resultadoImpar.Name = "resultadoImpar"
        resultadoImpar.Size = New Size(48, 20)
        resultadoImpar.TabIndex = 5
        resultadoImpar.Text = "Impar"
        ' 
        ' limpiar
        ' 
        limpiar.Location = New Point(650, 82)
        limpiar.Name = "limpiar"
        limpiar.Size = New Size(94, 29)
        limpiar.TabIndex = 6
        limpiar.Text = "Limpiar"
        limpiar.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(limpiar)
        Controls.Add(resultadoImpar)
        Controls.Add(resultadoPar)
        Controls.Add(Evaluar)
        Controls.Add(Numero)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Numero As TextBox
    Friend WithEvents Evaluar As Button
    Friend WithEvents resultadoPar As Label
    Friend WithEvents resultadoImpar As Label
    Friend WithEvents limpiar As Button
End Class

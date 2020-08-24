<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.aceptar = New System.Windows.Forms.Button()
        Me.siguiente = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(12, 12)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(288, 237)
        Me.WebBrowser1.TabIndex = 0
        '
        'aceptar
        '
        Me.aceptar.Location = New System.Drawing.Point(306, 174)
        Me.aceptar.Name = "aceptar"
        Me.aceptar.Size = New System.Drawing.Size(75, 23)
        Me.aceptar.TabIndex = 1
        Me.aceptar.Text = "ACEPTAR"
        Me.aceptar.UseVisualStyleBackColor = True
        '
        'siguiente
        '
        Me.siguiente.Location = New System.Drawing.Point(307, 204)
        Me.siguiente.Name = "siguiente"
        Me.siguiente.Size = New System.Drawing.Size(75, 23)
        Me.siguiente.TabIndex = 2
        Me.siguiente.Text = "SIGUIENTE"
        Me.siguiente.UseVisualStyleBackColor = True
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 261)
        Me.Controls.Add(Me.siguiente)
        Me.Controls.Add(Me.aceptar)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Name = "Principal"
        Me.Text = "Principal"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents aceptar As System.Windows.Forms.Button
    Friend WithEvents siguiente As System.Windows.Forms.Button
End Class

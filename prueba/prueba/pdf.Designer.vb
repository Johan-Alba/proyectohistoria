<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pdf
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pdf))
        Me.AxAcroPDF1 = New AxAcroPDFLib.AxAcroPDF()
        Me.Aceptar = New System.Windows.Forms.Button()
        Me.Siguiente = New System.Windows.Forms.Button()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxAcroPDF1
        '
        Me.AxAcroPDF1.Enabled = True
        Me.AxAcroPDF1.Location = New System.Drawing.Point(24, 27)
        Me.AxAcroPDF1.Name = "AxAcroPDF1"
        Me.AxAcroPDF1.OcxState = CType(resources.GetObject("AxAcroPDF1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAcroPDF1.Size = New System.Drawing.Size(212, 199)
        Me.AxAcroPDF1.TabIndex = 0
        '
        'Aceptar
        '
        Me.Aceptar.Location = New System.Drawing.Point(259, 174)
        Me.Aceptar.Name = "Aceptar"
        Me.Aceptar.Size = New System.Drawing.Size(75, 23)
        Me.Aceptar.TabIndex = 1
        Me.Aceptar.Text = "Aceptar"
        Me.Aceptar.UseVisualStyleBackColor = True
        '
        'Siguiente
        '
        Me.Siguiente.Location = New System.Drawing.Point(259, 203)
        Me.Siguiente.Name = "Siguiente"
        Me.Siguiente.Size = New System.Drawing.Size(75, 23)
        Me.Siguiente.TabIndex = 2
        Me.Siguiente.Text = "Siguiente"
        Me.Siguiente.UseVisualStyleBackColor = True
        '
        'pdf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 261)
        Me.Controls.Add(Me.Siguiente)
        Me.Controls.Add(Me.Aceptar)
        Me.Controls.Add(Me.AxAcroPDF1)
        Me.Name = "pdf"
        Me.Text = "pdf"
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AxAcroPDF1 As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents Aceptar As System.Windows.Forms.Button
    Friend WithEvents Siguiente As System.Windows.Forms.Button
End Class

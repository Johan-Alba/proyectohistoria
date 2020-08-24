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
        Me.components = New System.ComponentModel.Container()
        Me.prueba = New System.Windows.Forms.Label()
        Me.cargando = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'prueba
        '
        Me.prueba.AutoSize = True
        Me.prueba.Location = New System.Drawing.Point(52, 93)
        Me.prueba.Name = "prueba"
        Me.prueba.Size = New System.Drawing.Size(41, 13)
        Me.prueba.TabIndex = 1
        Me.prueba.Text = "Prueba"
        '
        'cargando
        '
        Me.cargando.AutoSize = True
        Me.cargando.Location = New System.Drawing.Point(52, 141)
        Me.cargando.Name = "cargando"
        Me.cargando.Size = New System.Drawing.Size(53, 13)
        Me.cargando.TabIndex = 2
        Me.cargando.Text = "Cargando"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(27, 226)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(294, 23)
        Me.ProgressBar1.TabIndex = 3
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.prueba.My.Resources.Resources.cooltext356668841438706
        Me.PictureBox2.Location = New System.Drawing.Point(27, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(294, 37)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.prueba.My.Resources.Resources._12023057_912228432203169_1892726728_n
        Me.PictureBox1.Location = New System.Drawing.Point(-4, -4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(346, 270)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 261)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.cargando)
        Me.Controls.Add(Me.prueba)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents prueba As System.Windows.Forms.Label
    Friend WithEvents cargando As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox

End Class

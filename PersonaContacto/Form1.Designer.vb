<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXTnombre = New System.Windows.Forms.TextBox()
        Me.TXTapm = New System.Windows.Forms.TextBox()
        Me.TXTapp = New System.Windows.Forms.TextBox()
        Me.DTPfn = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TXTcorreoe = New System.Windows.Forms.TextBox()
        Me.TXTtelef = New System.Windows.Forms.TextBox()
        Me.BTNmostrar = New System.Windows.Forms.Button()
        Me.BTNlimpiar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(199, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(227, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Datos de Usuario"
        '
        'TXTnombre
        '
        Me.TXTnombre.Location = New System.Drawing.Point(126, 90)
        Me.TXTnombre.Name = "TXTnombre"
        Me.TXTnombre.Size = New System.Drawing.Size(163, 20)
        Me.TXTnombre.TabIndex = 1
        '
        'TXTapm
        '
        Me.TXTapm.Location = New System.Drawing.Point(126, 162)
        Me.TXTapm.Name = "TXTapm"
        Me.TXTapm.Size = New System.Drawing.Size(163, 20)
        Me.TXTapm.TabIndex = 2
        '
        'TXTapp
        '
        Me.TXTapp.Location = New System.Drawing.Point(126, 126)
        Me.TXTapp.Name = "TXTapp"
        Me.TXTapp.Size = New System.Drawing.Size(163, 20)
        Me.TXTapp.TabIndex = 3
        '
        'DTPfn
        '
        Me.DTPfn.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPfn.Location = New System.Drawing.Point(432, 83)
        Me.DTPfn.Name = "DTPfn"
        Me.DTPfn.Size = New System.Drawing.Size(100, 20)
        Me.DTPfn.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nombre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Apellido Paterno"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Apellido Materno"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(318, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Fecha de Nacimiento"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(318, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Correo Electrónico"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(318, 126)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Telefono"
        '
        'TXTcorreoe
        '
        Me.TXTcorreoe.Location = New System.Drawing.Point(432, 162)
        Me.TXTcorreoe.Name = "TXTcorreoe"
        Me.TXTcorreoe.Size = New System.Drawing.Size(161, 20)
        Me.TXTcorreoe.TabIndex = 13
        '
        'TXTtelef
        '
        Me.TXTtelef.Location = New System.Drawing.Point(432, 126)
        Me.TXTtelef.Name = "TXTtelef"
        Me.TXTtelef.Size = New System.Drawing.Size(161, 20)
        Me.TXTtelef.TabIndex = 12
        '
        'BTNmostrar
        '
        Me.BTNmostrar.Location = New System.Drawing.Point(518, 201)
        Me.BTNmostrar.Name = "BTNmostrar"
        Me.BTNmostrar.Size = New System.Drawing.Size(75, 23)
        Me.BTNmostrar.TabIndex = 16
        Me.BTNmostrar.Text = "Mostrar"
        Me.BTNmostrar.UseVisualStyleBackColor = True
        '
        'BTNlimpiar
        '
        Me.BTNlimpiar.Location = New System.Drawing.Point(15, 201)
        Me.BTNlimpiar.Name = "BTNlimpiar"
        Me.BTNlimpiar.Size = New System.Drawing.Size(75, 23)
        Me.BTNlimpiar.TabIndex = 17
        Me.BTNlimpiar.Text = "Limpiar"
        Me.BTNlimpiar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 242)
        Me.Controls.Add(Me.BTNlimpiar)
        Me.Controls.Add(Me.BTNmostrar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TXTcorreoe)
        Me.Controls.Add(Me.TXTtelef)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DTPfn)
        Me.Controls.Add(Me.TXTapp)
        Me.Controls.Add(Me.TXTapm)
        Me.Controls.Add(Me.TXTnombre)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TXTnombre As TextBox
    Friend WithEvents TXTapm As TextBox
    Friend WithEvents TXTapp As TextBox
    Friend WithEvents DTPfn As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TXTcorreoe As TextBox
    Friend WithEvents TXTtelef As TextBox
    Friend WithEvents BTNmostrar As Button
    Friend WithEvents BTNlimpiar As Button
End Class

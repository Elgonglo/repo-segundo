<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioPrincipal
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
        Me.lblerror = New System.Windows.Forms.Label()
        Me.btnsaludar = New System.Windows.Forms.Button()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblerrorapellido = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblerror
        '
        Me.lblerror.AutoSize = True
        Me.lblerror.ForeColor = System.Drawing.Color.Red
        Me.lblerror.Location = New System.Drawing.Point(208, 52)
        Me.lblerror.Name = "lblerror"
        Me.lblerror.Size = New System.Drawing.Size(0, 13)
        Me.lblerror.TabIndex = 7
        '
        'btnsaludar
        '
        Me.btnsaludar.Location = New System.Drawing.Point(101, 83)
        Me.btnsaludar.Name = "btnsaludar"
        Me.btnsaludar.Size = New System.Drawing.Size(75, 23)
        Me.btnsaludar.TabIndex = 6
        Me.btnsaludar.Text = "Saludar"
        Me.btnsaludar.UseVisualStyleBackColor = True
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Location = New System.Drawing.Point(49, 49)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(50, 13)
        Me.lblnombre.TabIndex = 5
        Me.lblnombre.Text = " Nombre:"
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(101, 46)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(100, 20)
        Me.txtnombre.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(386, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 10
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Location = New System.Drawing.Point(227, 48)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(47, 13)
        Me.lblApellido.TabIndex = 9
        Me.lblApellido.Text = "Apellido:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(279, 45)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 8
        '
        'lblerrorapellido
        '
        Me.lblerrorapellido.AutoSize = True
        Me.lblerrorapellido.ForeColor = System.Drawing.Color.Red
        Me.lblerrorapellido.Location = New System.Drawing.Point(386, 46)
        Me.lblerrorapellido.Name = "lblerrorapellido"
        Me.lblerrorapellido.Size = New System.Drawing.Size(0, 13)
        Me.lblerrorapellido.TabIndex = 11
        '
        'FormularioPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblerrorapellido)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblApellido)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblerror)
        Me.Controls.Add(Me.btnsaludar)
        Me.Controls.Add(Me.lblnombre)
        Me.Controls.Add(Me.txtnombre)
        Me.Name = "FormularioPrincipal"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents lblerror As Label
    Private WithEvents btnsaludar As Button
    Private WithEvents lblnombre As Label
    Private WithEvents txtnombre As TextBox
    Private WithEvents Label1 As Label
    Private WithEvents lblApellido As Label
    Private WithEvents TextBox1 As TextBox
    Friend WithEvents lblerrorapellido As Label
End Class

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
        Me.cmdEjecutar = New System.Windows.Forms.Button()
        Me.lblsalida = New System.Windows.Forms.Label()
        Me.txta = New System.Windows.Forms.TextBox()
        Me.lbla = New System.Windows.Forms.Label()
        Me.lblb = New System.Windows.Forms.Label()
        Me.Txtb = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmdEjecutar
        '
        Me.cmdEjecutar.Location = New System.Drawing.Point(184, 186)
        Me.cmdEjecutar.Name = "cmdEjecutar"
        Me.cmdEjecutar.Size = New System.Drawing.Size(75, 23)
        Me.cmdEjecutar.TabIndex = 0
        Me.cmdEjecutar.Text = "Ejecutar"
        Me.cmdEjecutar.UseVisualStyleBackColor = True
        '
        'lblsalida
        '
        Me.lblsalida.AutoSize = True
        Me.lblsalida.Location = New System.Drawing.Point(300, 97)
        Me.lblsalida.Name = "lblsalida"
        Me.lblsalida.Size = New System.Drawing.Size(39, 13)
        Me.lblsalida.TabIndex = 1
        Me.lblsalida.Text = "Label1"
        '
        'txta
        '
        Me.txta.Location = New System.Drawing.Point(66, 59)
        Me.txta.Name = "txta"
        Me.txta.Size = New System.Drawing.Size(100, 20)
        Me.txta.TabIndex = 2
        '
        'lbla
        '
        Me.lbla.AutoSize = True
        Me.lbla.Location = New System.Drawing.Point(66, 40)
        Me.lbla.Name = "lbla"
        Me.lbla.Size = New System.Drawing.Size(103, 13)
        Me.lbla.TabIndex = 3
        Me.lbla.Text = "Ingrese el valor de a"
        '
        'lblb
        '
        Me.lblb.AutoSize = True
        Me.lblb.Location = New System.Drawing.Point(66, 97)
        Me.lblb.Name = "lblb"
        Me.lblb.Size = New System.Drawing.Size(103, 13)
        Me.lblb.TabIndex = 4
        Me.lblb.Text = "Ingrese el valor de b"
        '
        'Txtb
        '
        Me.Txtb.Location = New System.Drawing.Point(69, 131)
        Me.Txtb.Name = "Txtb"
        Me.Txtb.Size = New System.Drawing.Size(100, 20)
        Me.Txtb.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 261)
        Me.Controls.Add(Me.Txtb)
        Me.Controls.Add(Me.lblb)
        Me.Controls.Add(Me.lbla)
        Me.Controls.Add(Me.txta)
        Me.Controls.Add(Me.lblsalida)
        Me.Controls.Add(Me.cmdEjecutar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdEjecutar As System.Windows.Forms.Button
    Friend WithEvents lblsalida As System.Windows.Forms.Label
    Friend WithEvents txta As System.Windows.Forms.TextBox
    Friend WithEvents lbla As System.Windows.Forms.Label
    Friend WithEvents lblb As System.Windows.Forms.Label
    Friend WithEvents Txtb As System.Windows.Forms.TextBox

End Class

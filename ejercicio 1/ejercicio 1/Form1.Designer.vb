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
        Me.txtdato = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmdEjecutar
        '
        Me.cmdEjecutar.Location = New System.Drawing.Point(184, 148)
        Me.cmdEjecutar.Name = "cmdEjecutar"
        Me.cmdEjecutar.Size = New System.Drawing.Size(75, 23)
        Me.cmdEjecutar.TabIndex = 0
        Me.cmdEjecutar.Text = "Ejecutar"
        Me.cmdEjecutar.UseVisualStyleBackColor = True
        '
        'lblsalida
        '
        Me.lblsalida.AutoSize = True
        Me.lblsalida.Location = New System.Drawing.Point(306, 81)
        Me.lblsalida.Name = "lblsalida"
        Me.lblsalida.Size = New System.Drawing.Size(39, 13)
        Me.lblsalida.TabIndex = 1
        Me.lblsalida.Text = "Label1"
        '
        'txtdato
        '
        Me.txtdato.Location = New System.Drawing.Point(68, 81)
        Me.txtdato.Name = "txtdato"
        Me.txtdato.Size = New System.Drawing.Size(100, 20)
        Me.txtdato.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 261)
        Me.Controls.Add(Me.txtdato)
        Me.Controls.Add(Me.lblsalida)
        Me.Controls.Add(Me.cmdEjecutar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdEjecutar As System.Windows.Forms.Button
    Friend WithEvents lblsalida As System.Windows.Forms.Label
    Friend WithEvents txtdato As System.Windows.Forms.TextBox

End Class

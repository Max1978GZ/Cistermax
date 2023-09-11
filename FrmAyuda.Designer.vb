<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAyuda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAyuda))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtAyuda = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(662, 433)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Cerrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TxtAyuda
        '
        Me.TxtAyuda.Dock = System.Windows.Forms.DockStyle.Top
        Me.TxtAyuda.Location = New System.Drawing.Point(0, 0)
        Me.TxtAyuda.Multiline = True
        Me.TxtAyuda.Name = "TxtAyuda"
        Me.TxtAyuda.ReadOnly = True
        Me.TxtAyuda.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtAyuda.Size = New System.Drawing.Size(749, 418)
        Me.TxtAyuda.TabIndex = 1
        Me.TxtAyuda.Text = resources.GetString("TxtAyuda.Text")
        '
        'FrmAyuda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 468)
        Me.Controls.Add(Me.TxtAyuda)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "FrmAyuda"
        Me.Text = "Ayuda Cisco"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TxtAyuda As System.Windows.Forms.TextBox
End Class

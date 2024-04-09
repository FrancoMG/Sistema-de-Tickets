<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBorrarUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBorrarUsuario))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.cmbUsuario = New System.Windows.Forms.ComboBox()
        Me.lblErrorCampos = New System.Windows.Forms.Label()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.btnAtras = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Tickets.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(86, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(224, 123)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblUsuario.Location = New System.Drawing.Point(82, 139)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(70, 23)
        Me.lblUsuario.TabIndex = 1
        Me.lblUsuario.Text = "Usuario"
        '
        'cmbUsuario
        '
        Me.cmbUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbUsuario.FormattingEnabled = True
        Me.cmbUsuario.Location = New System.Drawing.Point(158, 141)
        Me.cmbUsuario.Name = "cmbUsuario"
        Me.cmbUsuario.Size = New System.Drawing.Size(170, 21)
        Me.cmbUsuario.TabIndex = 2
        '
        'lblErrorCampos
        '
        Me.lblErrorCampos.AutoSize = True
        Me.lblErrorCampos.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblErrorCampos.ForeColor = System.Drawing.Color.Maroon
        Me.lblErrorCampos.Location = New System.Drawing.Point(103, 176)
        Me.lblErrorCampos.Name = "lblErrorCampos"
        Me.lblErrorCampos.Size = New System.Drawing.Size(203, 14)
        Me.lblErrorCampos.TabIndex = 3
        Me.lblErrorCampos.Text = "Seleccione el usuario que desea eliminar"
        Me.lblErrorCampos.Visible = False
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnRegistrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnRegistrar.Location = New System.Drawing.Point(129, 208)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(125, 35)
        Me.btnRegistrar.TabIndex = 4
        Me.btnRegistrar.Text = "Borrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'btnAtras
        '
        Me.btnAtras.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAtras.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAtras.Location = New System.Drawing.Point(305, 258)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(74, 30)
        Me.btnAtras.TabIndex = 5
        Me.btnAtras.Text = "Atras"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'frmBorrarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Coral
        Me.ClientSize = New System.Drawing.Size(391, 300)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.lblErrorCampos)
        Me.Controls.Add(Me.cmbUsuario)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBorrarUsuario"
        Me.Text = "Borrar Usuario"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblUsuario As Label
    Friend WithEvents cmbUsuario As ComboBox
    Friend WithEvents lblErrorCampos As Label
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents btnAtras As Button
End Class

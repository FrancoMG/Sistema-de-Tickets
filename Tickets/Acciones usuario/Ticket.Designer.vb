<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTicket
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTicket))
        Me.txtConsulta = New System.Windows.Forms.TextBox()
        Me.lblConsulta = New System.Windows.Forms.Label()
        Me.txtAsunto = New System.Windows.Forms.TextBox()
        Me.lblAsunto = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbUsuarios = New System.Windows.Forms.ComboBox()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.lblErrorCampos = New System.Windows.Forms.Label()
        Me.btnAtras = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtConsulta
        '
        Me.txtConsulta.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtConsulta.Location = New System.Drawing.Point(146, 209)
        Me.txtConsulta.Multiline = True
        Me.txtConsulta.Name = "txtConsulta"
        Me.txtConsulta.Size = New System.Drawing.Size(389, 190)
        Me.txtConsulta.TabIndex = 9
        '
        'lblConsulta
        '
        Me.lblConsulta.AutoSize = True
        Me.lblConsulta.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblConsulta.Location = New System.Drawing.Point(12, 206)
        Me.lblConsulta.Name = "lblConsulta"
        Me.lblConsulta.Size = New System.Drawing.Size(79, 23)
        Me.lblConsulta.TabIndex = 8
        Me.lblConsulta.Text = "Consulta"
        '
        'txtAsunto
        '
        Me.txtAsunto.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtAsunto.Location = New System.Drawing.Point(146, 163)
        Me.txtAsunto.Name = "txtAsunto"
        Me.txtAsunto.Size = New System.Drawing.Size(170, 23)
        Me.txtAsunto.TabIndex = 7
        '
        'lblAsunto
        '
        Me.lblAsunto.AutoSize = True
        Me.lblAsunto.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblAsunto.Location = New System.Drawing.Point(12, 160)
        Me.lblAsunto.Name = "lblAsunto"
        Me.lblAsunto.Size = New System.Drawing.Size(67, 23)
        Me.lblAsunto.TabIndex = 6
        Me.lblAsunto.Text = "Asunto"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Tickets.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(162, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(224, 123)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 444)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(380, 23)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Seleccione el usuario que desea enviarle el ticket"
        '
        'cmbUsuarios
        '
        Me.cmbUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbUsuarios.FormattingEnabled = True
        Me.cmbUsuarios.Location = New System.Drawing.Point(424, 448)
        Me.cmbUsuarios.Name = "cmbUsuarios"
        Me.cmbUsuarios.Size = New System.Drawing.Size(140, 21)
        Me.cmbUsuarios.TabIndex = 11
        '
        'btnEnviar
        '
        Me.btnEnviar.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnEnviar.Location = New System.Drawing.Point(221, 513)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(125, 35)
        Me.btnEnviar.TabIndex = 12
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'lblErrorCampos
        '
        Me.lblErrorCampos.AutoSize = True
        Me.lblErrorCampos.BackColor = System.Drawing.Color.Coral
        Me.lblErrorCampos.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblErrorCampos.ForeColor = System.Drawing.Color.Maroon
        Me.lblErrorCampos.Location = New System.Drawing.Point(163, 562)
        Me.lblErrorCampos.Name = "lblErrorCampos"
        Me.lblErrorCampos.Size = New System.Drawing.Size(246, 14)
        Me.lblErrorCampos.TabIndex = 13
        Me.lblErrorCampos.Text = "Complete los campos vacios para poder continuar"
        Me.lblErrorCampos.Visible = False
        '
        'btnAtras
        '
        Me.btnAtras.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAtras.Location = New System.Drawing.Point(491, 564)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(74, 30)
        Me.btnAtras.TabIndex = 14
        Me.btnAtras.Text = "Atras"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'frmTicket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Coral
        Me.ClientSize = New System.Drawing.Size(577, 603)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.lblErrorCampos)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.cmbUsuarios)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtConsulta)
        Me.Controls.Add(Me.lblConsulta)
        Me.Controls.Add(Me.txtAsunto)
        Me.Controls.Add(Me.lblAsunto)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTicket"
        Me.Text = "Ticket"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtConsulta As TextBox
    Friend WithEvents lblConsulta As Label
    Friend WithEvents txtAsunto As TextBox
    Friend WithEvents lblAsunto As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbUsuarios As ComboBox
    Friend WithEvents btnEnviar As Button
    Friend WithEvents lblErrorCampos As Label
    Friend WithEvents btnAtras As Button
End Class

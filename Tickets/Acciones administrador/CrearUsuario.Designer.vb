<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCrearUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCrearUsuario))
        Me.lblID = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.btnLista = New System.Windows.Forms.Button()
        Me.btnVerificar = New System.Windows.Forms.Button()
        Me.lblErrorCampos = New System.Windows.Forms.Label()
        Me.gbxUsuario = New System.Windows.Forms.GroupBox()
        Me.lblErrorCamposR = New System.Windows.Forms.Label()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.chkVerContraseña = New System.Windows.Forms.CheckBox()
        Me.txtConfirmarContraseña = New System.Windows.Forms.TextBox()
        Me.lblConfirmarC = New System.Windows.Forms.Label()
        Me.lblContraseña = New System.Windows.Forms.Label()
        Me.cmbTipoUsuario = New System.Windows.Forms.ComboBox()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.lblTU = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.gbxUsuario.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblID.Location = New System.Drawing.Point(100, 39)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(94, 23)
        Me.lblID.TabIndex = 0
        Me.lblID.Text = "ID Persona"
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtID.Location = New System.Drawing.Point(195, 40)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(170, 27)
        Me.txtID.TabIndex = 1
        '
        'btnLista
        '
        Me.btnLista.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnLista.Location = New System.Drawing.Point(386, 40)
        Me.btnLista.Name = "btnLista"
        Me.btnLista.Size = New System.Drawing.Size(116, 27)
        Me.btnLista.TabIndex = 2
        Me.btnLista.Text = "Ver Lista"
        Me.btnLista.UseVisualStyleBackColor = True
        '
        'btnVerificar
        '
        Me.btnVerificar.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnVerificar.Location = New System.Drawing.Point(207, 76)
        Me.btnVerificar.Name = "btnVerificar"
        Me.btnVerificar.Size = New System.Drawing.Size(125, 28)
        Me.btnVerificar.TabIndex = 3
        Me.btnVerificar.Text = "Verificar"
        Me.btnVerificar.UseVisualStyleBackColor = True
        '
        'lblErrorCampos
        '
        Me.lblErrorCampos.AutoSize = True
        Me.lblErrorCampos.BackColor = System.Drawing.Color.Coral
        Me.lblErrorCampos.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblErrorCampos.ForeColor = System.Drawing.Color.Maroon
        Me.lblErrorCampos.Location = New System.Drawing.Point(338, 86)
        Me.lblErrorCampos.Name = "lblErrorCampos"
        Me.lblErrorCampos.Size = New System.Drawing.Size(246, 14)
        Me.lblErrorCampos.TabIndex = 4
        Me.lblErrorCampos.Text = "Complete los campos vacios para poder continuar"
        Me.lblErrorCampos.Visible = False
        '
        'gbxUsuario
        '
        Me.gbxUsuario.Controls.Add(Me.lblErrorCamposR)
        Me.gbxUsuario.Controls.Add(Me.btnRegistrar)
        Me.gbxUsuario.Controls.Add(Me.chkVerContraseña)
        Me.gbxUsuario.Controls.Add(Me.txtConfirmarContraseña)
        Me.gbxUsuario.Controls.Add(Me.lblConfirmarC)
        Me.gbxUsuario.Controls.Add(Me.lblContraseña)
        Me.gbxUsuario.Controls.Add(Me.cmbTipoUsuario)
        Me.gbxUsuario.Controls.Add(Me.txtContraseña)
        Me.gbxUsuario.Controls.Add(Me.lblTU)
        Me.gbxUsuario.Controls.Add(Me.txtNombre)
        Me.gbxUsuario.Controls.Add(Me.lblNombre)
        Me.gbxUsuario.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.gbxUsuario.Location = New System.Drawing.Point(64, 122)
        Me.gbxUsuario.Name = "gbxUsuario"
        Me.gbxUsuario.Size = New System.Drawing.Size(444, 252)
        Me.gbxUsuario.TabIndex = 5
        Me.gbxUsuario.TabStop = False
        Me.gbxUsuario.Text = "Datos Usuario"
        '
        'lblErrorCamposR
        '
        Me.lblErrorCamposR.AutoSize = True
        Me.lblErrorCamposR.BackColor = System.Drawing.Color.Coral
        Me.lblErrorCamposR.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblErrorCamposR.ForeColor = System.Drawing.Color.Maroon
        Me.lblErrorCamposR.Location = New System.Drawing.Point(88, 227)
        Me.lblErrorCamposR.Name = "lblErrorCamposR"
        Me.lblErrorCamposR.Size = New System.Drawing.Size(246, 14)
        Me.lblErrorCamposR.TabIndex = 6
        Me.lblErrorCamposR.Text = "Complete los campos vacios para poder continuar"
        Me.lblErrorCamposR.Visible = False
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnRegistrar.Location = New System.Drawing.Point(143, 180)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(125, 35)
        Me.btnRegistrar.TabIndex = 6
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'chkVerContraseña
        '
        Me.chkVerContraseña.AutoSize = True
        Me.chkVerContraseña.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.chkVerContraseña.Location = New System.Drawing.Point(341, 104)
        Me.chkVerContraseña.Name = "chkVerContraseña"
        Me.chkVerContraseña.Size = New System.Drawing.Size(99, 18)
        Me.chkVerContraseña.TabIndex = 13
        Me.chkVerContraseña.Text = "Ver contraseña"
        Me.chkVerContraseña.UseVisualStyleBackColor = True
        '
        'txtConfirmarContraseña
        '
        Me.txtConfirmarContraseña.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtConfirmarContraseña.Location = New System.Drawing.Point(234, 131)
        Me.txtConfirmarContraseña.Name = "txtConfirmarContraseña"
        Me.txtConfirmarContraseña.Size = New System.Drawing.Size(170, 27)
        Me.txtConfirmarContraseña.TabIndex = 12
        '
        'lblConfirmarC
        '
        Me.lblConfirmarC.AutoSize = True
        Me.lblConfirmarC.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblConfirmarC.Location = New System.Drawing.Point(50, 132)
        Me.lblConfirmarC.Name = "lblConfirmarC"
        Me.lblConfirmarC.Size = New System.Drawing.Size(178, 23)
        Me.lblConfirmarC.TabIndex = 11
        Me.lblConfirmarC.Text = "Confirmar contraseña"
        '
        'lblContraseña
        '
        Me.lblContraseña.AutoSize = True
        Me.lblContraseña.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblContraseña.Location = New System.Drawing.Point(50, 98)
        Me.lblContraseña.Name = "lblContraseña"
        Me.lblContraseña.Size = New System.Drawing.Size(99, 23)
        Me.lblContraseña.TabIndex = 10
        Me.lblContraseña.Text = "Contraseña"
        '
        'cmbTipoUsuario
        '
        Me.cmbTipoUsuario.Font = New System.Drawing.Font("Corbel", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbTipoUsuario.FormattingEnabled = True
        Me.cmbTipoUsuario.Location = New System.Drawing.Point(162, 69)
        Me.cmbTipoUsuario.Name = "cmbTipoUsuario"
        Me.cmbTipoUsuario.Size = New System.Drawing.Size(170, 21)
        Me.cmbTipoUsuario.TabIndex = 9
        '
        'txtContraseña
        '
        Me.txtContraseña.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtContraseña.Location = New System.Drawing.Point(162, 98)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.Size = New System.Drawing.Size(170, 27)
        Me.txtContraseña.TabIndex = 8
        '
        'lblTU
        '
        Me.lblTU.AutoSize = True
        Me.lblTU.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTU.Location = New System.Drawing.Point(50, 65)
        Me.lblTU.Name = "lblTU"
        Me.lblTU.Size = New System.Drawing.Size(106, 23)
        Me.lblTU.TabIndex = 7
        Me.lblTU.Text = "Tipo usuario"
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtNombre.Location = New System.Drawing.Point(191, 36)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(170, 27)
        Me.txtNombre.TabIndex = 6
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblNombre.Location = New System.Drawing.Point(50, 40)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(135, 23)
        Me.lblNombre.TabIndex = 6
        Me.lblNombre.Text = "Nombre usuario"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Tickets.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(0, 422)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(224, 123)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'btnAtras
        '
        Me.btnAtras.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAtras.Location = New System.Drawing.Point(488, 502)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(74, 30)
        Me.btnAtras.TabIndex = 14
        Me.btnAtras.Text = "Atras"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'frmCrearUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Coral
        Me.ClientSize = New System.Drawing.Size(583, 544)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.gbxUsuario)
        Me.Controls.Add(Me.lblErrorCampos)
        Me.Controls.Add(Me.btnVerificar)
        Me.Controls.Add(Me.btnLista)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblID)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCrearUsuario"
        Me.Text = "Crear usuario"
        Me.gbxUsuario.ResumeLayout(False)
        Me.gbxUsuario.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblID As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents btnLista As Button
    Friend WithEvents btnVerificar As Button
    Friend WithEvents lblErrorCampos As Label
    Friend WithEvents gbxUsuario As GroupBox
    Friend WithEvents lblErrorCamposR As Label
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents chkVerContraseña As CheckBox
    Friend WithEvents txtConfirmarContraseña As TextBox
    Friend WithEvents lblConfirmarC As Label
    Friend WithEvents lblContraseña As Label
    Friend WithEvents cmbTipoUsuario As ComboBox
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents lblTU As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnAtras As Button
End Class

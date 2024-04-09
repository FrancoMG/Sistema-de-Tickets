<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccionesAdministrador
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAccionesAdministrador))
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.gbxAcciones = New System.Windows.Forms.GroupBox()
        Me.btnVerListado = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnOtrosTickets = New System.Windows.Forms.Button()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.gbxAcciones.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Corbel", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblTitulo.Location = New System.Drawing.Point(322, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(350, 39)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Elija una de las opciones"
        '
        'gbxAcciones
        '
        Me.gbxAcciones.Controls.Add(Me.btnVerListado)
        Me.gbxAcciones.Controls.Add(Me.btnEliminar)
        Me.gbxAcciones.Controls.Add(Me.btnOtrosTickets)
        Me.gbxAcciones.Controls.Add(Me.btnCrear)
        Me.gbxAcciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.gbxAcciones.Location = New System.Drawing.Point(44, 79)
        Me.gbxAcciones.Name = "gbxAcciones"
        Me.gbxAcciones.Size = New System.Drawing.Size(865, 153)
        Me.gbxAcciones.TabIndex = 1
        Me.gbxAcciones.TabStop = False
        '
        'btnVerListado
        '
        Me.btnVerListado.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnVerListado.Location = New System.Drawing.Point(449, 52)
        Me.btnVerListado.Name = "btnVerListado"
        Me.btnVerListado.Size = New System.Drawing.Size(190, 61)
        Me.btnVerListado.TabIndex = 3
        Me.btnVerListado.Text = "Ver listado de errores"
        Me.btnVerListado.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnEliminar.Location = New System.Drawing.Point(229, 52)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(190, 61)
        Me.btnEliminar.TabIndex = 2
        Me.btnEliminar.Text = "Borrar un usuario"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnOtrosTickets
        '
        Me.btnOtrosTickets.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnOtrosTickets.Location = New System.Drawing.Point(669, 52)
        Me.btnOtrosTickets.Name = "btnOtrosTickets"
        Me.btnOtrosTickets.Size = New System.Drawing.Size(190, 61)
        Me.btnOtrosTickets.TabIndex = 1
        Me.btnOtrosTickets.Text = "Ver tickets de otros usuarios"
        Me.btnOtrosTickets.UseVisualStyleBackColor = True
        '
        'btnCrear
        '
        Me.btnCrear.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCrear.Location = New System.Drawing.Point(6, 52)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(190, 61)
        Me.btnCrear.TabIndex = 0
        Me.btnCrear.Text = "Crear un usuario"
        Me.btnCrear.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Tickets.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(0, 289)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(224, 123)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'btnAtras
        '
        Me.btnAtras.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAtras.Location = New System.Drawing.Point(871, 370)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(84, 30)
        Me.btnAtras.TabIndex = 3
        Me.btnAtras.Text = "Atras"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'frmAccionesAdministrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Coral
        Me.ClientSize = New System.Drawing.Size(967, 412)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.gbxAcciones)
        Me.Controls.Add(Me.lblTitulo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAccionesAdministrador"
        Me.Text = "Acciones administrador"
        Me.gbxAcciones.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents gbxAcciones As GroupBox
    Friend WithEvents btnVerListado As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnOtrosTickets As Button
    Friend WithEvents btnCrear As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnAtras As Button
End Class

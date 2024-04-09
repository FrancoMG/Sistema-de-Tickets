<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLista
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLista))
        Me.dgvPersonas = New System.Windows.Forms.DataGridView()
        Me.CodPersona = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombrePersona = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoPersona = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DNIPersona = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionPersona = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoPersona = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailPersona = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dgvPersonas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvPersonas
        '
        Me.dgvPersonas.AllowUserToAddRows = False
        Me.dgvPersonas.AllowUserToDeleteRows = False
        Me.dgvPersonas.BackgroundColor = System.Drawing.Color.Coral
        Me.dgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPersonas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodPersona, Me.NombrePersona, Me.ApellidoPersona, Me.DNIPersona, Me.DireccionPersona, Me.TelefonoPersona, Me.EmailPersona})
        Me.dgvPersonas.Location = New System.Drawing.Point(-2, 0)
        Me.dgvPersonas.Name = "dgvPersonas"
        Me.dgvPersonas.ReadOnly = True
        Me.dgvPersonas.RowTemplate.Height = 25
        Me.dgvPersonas.Size = New System.Drawing.Size(744, 242)
        Me.dgvPersonas.TabIndex = 0
        '
        'CodPersona
        '
        Me.CodPersona.HeaderText = "Codigo Persona"
        Me.CodPersona.Name = "CodPersona"
        Me.CodPersona.ReadOnly = True
        '
        'NombrePersona
        '
        Me.NombrePersona.HeaderText = "Nombre"
        Me.NombrePersona.Name = "NombrePersona"
        Me.NombrePersona.ReadOnly = True
        '
        'ApellidoPersona
        '
        Me.ApellidoPersona.HeaderText = "Apellido"
        Me.ApellidoPersona.Name = "ApellidoPersona"
        Me.ApellidoPersona.ReadOnly = True
        '
        'DNIPersona
        '
        Me.DNIPersona.HeaderText = "DNI"
        Me.DNIPersona.Name = "DNIPersona"
        Me.DNIPersona.ReadOnly = True
        '
        'DireccionPersona
        '
        Me.DireccionPersona.HeaderText = "Direccion"
        Me.DireccionPersona.Name = "DireccionPersona"
        Me.DireccionPersona.ReadOnly = True
        '
        'TelefonoPersona
        '
        Me.TelefonoPersona.HeaderText = "Telefono"
        Me.TelefonoPersona.Name = "TelefonoPersona"
        Me.TelefonoPersona.ReadOnly = True
        '
        'EmailPersona
        '
        Me.EmailPersona.HeaderText = "E-Mail"
        Me.EmailPersona.Name = "EmailPersona"
        Me.EmailPersona.ReadOnly = True
        '
        'btnAtras
        '
        Me.btnAtras.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAtras.Location = New System.Drawing.Point(435, 304)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(138, 30)
        Me.btnAtras.TabIndex = 1
        Me.btnAtras.Text = "Atras"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Tickets.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 287)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(224, 123)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'frmLista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Coral
        Me.ClientSize = New System.Drawing.Size(739, 410)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.dgvPersonas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLista"
        Me.Text = "Lista Usuarios"
        CType(Me.dgvPersonas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvPersonas As DataGridView
    Friend WithEvents CodPersona As DataGridViewTextBoxColumn
    Friend WithEvents NombrePersona As DataGridViewTextBoxColumn
    Friend WithEvents ApellidoPersona As DataGridViewTextBoxColumn
    Friend WithEvents DNIPersona As DataGridViewTextBoxColumn
    Friend WithEvents DireccionPersona As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoPersona As DataGridViewTextBoxColumn
    Friend WithEvents EmailPersona As DataGridViewTextBoxColumn
    Friend WithEvents btnAtras As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class

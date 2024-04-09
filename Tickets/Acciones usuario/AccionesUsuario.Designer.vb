<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccionesUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAccionesUsuario))
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnCrearTicket = New System.Windows.Forms.Button()
        Me.btnVerTickets = New System.Windows.Forms.Button()
        Me.btnOtrosTickets = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnAtras = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Corbel", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblTitulo.Location = New System.Drawing.Point(146, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(350, 39)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Elija una de las opciones"
        '
        'btnCrearTicket
        '
        Me.btnCrearTicket.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCrearTicket.Location = New System.Drawing.Point(12, 105)
        Me.btnCrearTicket.Name = "btnCrearTicket"
        Me.btnCrearTicket.Size = New System.Drawing.Size(190, 61)
        Me.btnCrearTicket.TabIndex = 1
        Me.btnCrearTicket.Text = "Crear Un Ticket"
        Me.btnCrearTicket.UseVisualStyleBackColor = True
        '
        'btnVerTickets
        '
        Me.btnVerTickets.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnVerTickets.Location = New System.Drawing.Point(222, 105)
        Me.btnVerTickets.Name = "btnVerTickets"
        Me.btnVerTickets.Size = New System.Drawing.Size(190, 61)
        Me.btnVerTickets.TabIndex = 2
        Me.btnVerTickets.Text = "Tickets Enviados"
        Me.btnVerTickets.UseVisualStyleBackColor = True
        '
        'btnOtrosTickets
        '
        Me.btnOtrosTickets.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnOtrosTickets.Location = New System.Drawing.Point(433, 105)
        Me.btnOtrosTickets.Name = "btnOtrosTickets"
        Me.btnOtrosTickets.Size = New System.Drawing.Size(190, 61)
        Me.btnOtrosTickets.TabIndex = 3
        Me.btnOtrosTickets.Text = "Tickets Recibidos"
        Me.btnOtrosTickets.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Tickets.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 203)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(224, 123)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'btnAtras
        '
        Me.btnAtras.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAtras.Location = New System.Drawing.Point(549, 286)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(74, 30)
        Me.btnAtras.TabIndex = 5
        Me.btnAtras.Text = "Atras"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'frmAccionesUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Coral
        Me.ClientSize = New System.Drawing.Size(635, 325)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnOtrosTickets)
        Me.Controls.Add(Me.btnVerTickets)
        Me.Controls.Add(Me.btnCrearTicket)
        Me.Controls.Add(Me.lblTitulo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAccionesUsuario"
        Me.Text = "Acciones del Usuario"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents btnCrearTicket As Button
    Friend WithEvents btnVerTickets As Button
    Friend WithEvents btnOtrosTickets As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnAtras As Button
End Class

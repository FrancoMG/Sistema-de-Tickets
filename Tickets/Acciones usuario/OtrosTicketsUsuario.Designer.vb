﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOtrosTicketsUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOtrosTicketsUsuario))
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dgvTickets = New System.Windows.Forms.DataGridView()
        Me.CodTicket = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AsuntoTicket = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConsultaTicket = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.Fechaticket = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblTitulo = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTickets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAtras
        '
        Me.btnAtras.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAtras.Location = New System.Drawing.Point(393, 513)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(138, 30)
        Me.btnAtras.TabIndex = 7
        Me.btnAtras.Text = "Atras"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Tickets.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 433)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(224, 123)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'dgvTickets
        '
        Me.dgvTickets.AllowUserToAddRows = False
        Me.dgvTickets.AllowUserToDeleteRows = False
        Me.dgvTickets.BackgroundColor = System.Drawing.Color.Coral
        Me.dgvTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTickets.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodTicket, Me.NombreU, Me.AsuntoTicket, Me.ConsultaTicket, Me.Fechaticket})
        Me.dgvTickets.Location = New System.Drawing.Point(0, 81)
        Me.dgvTickets.Name = "dgvTickets"
        Me.dgvTickets.ReadOnly = True
        Me.dgvTickets.RowTemplate.Height = 25
        Me.dgvTickets.Size = New System.Drawing.Size(544, 334)
        Me.dgvTickets.TabIndex = 5
        '
        'CodTicket
        '
        Me.CodTicket.HeaderText = "Codigo Ticket"
        Me.CodTicket.Name = "CodTicket"
        Me.CodTicket.ReadOnly = True
        '
        'NombreU
        '
        Me.NombreU.HeaderText = "Usuario"
        Me.NombreU.Name = "NombreU"
        Me.NombreU.ReadOnly = True
        '
        'AsuntoTicket
        '
        Me.AsuntoTicket.HeaderText = "Asunto"
        Me.AsuntoTicket.Name = "AsuntoTicket"
        Me.AsuntoTicket.ReadOnly = True
        '
        'ConsultaTicket
        '
        Me.ConsultaTicket.HeaderText = "Consulta"
        Me.ConsultaTicket.Name = "ConsultaTicket"
        Me.ConsultaTicket.ReadOnly = True
        '
        'Fechaticket
        '
        Me.Fechaticket.HeaderText = "Fecha Emitido"
        Me.Fechaticket.Name = "Fechaticket"
        Me.Fechaticket.ReadOnly = True
        Me.Fechaticket.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Fechaticket.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Corbel", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblTitulo.Location = New System.Drawing.Point(96, 4)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(358, 39)
        Me.lblTitulo.TabIndex = 4
        Me.lblTitulo.Text = "Tickets de otros usuarios"
        '
        'frmOtrosTicketsUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Coral
        Me.ClientSize = New System.Drawing.Size(543, 561)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.dgvTickets)
        Me.Controls.Add(Me.lblTitulo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmOtrosTicketsUsuario"
        Me.Text = "Tickets de otros usuarios"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTickets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAtras As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dgvTickets As DataGridView
    Friend WithEvents CodTicket As DataGridViewTextBoxColumn
    Friend WithEvents NombreU As DataGridViewTextBoxColumn
    Friend WithEvents AsuntoTicket As DataGridViewTextBoxColumn
    Friend WithEvents ConsultaTicket As DataGridViewLinkColumn
    Friend WithEvents Fechaticket As DataGridViewTextBoxColumn
    Friend WithEvents lblTitulo As Label
End Class

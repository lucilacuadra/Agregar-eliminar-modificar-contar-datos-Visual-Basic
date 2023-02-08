<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formlistbox
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formlistbox))
        Me.txtdato = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.listbox = New System.Windows.Forms.ListBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.lblIngreseuntexto = New System.Windows.Forms.Label()
        Me.lblcantidad = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtdato
        '
        Me.txtdato.Location = New System.Drawing.Point(299, 61)
        Me.txtdato.Name = "txtdato"
        Me.txtdato.Size = New System.Drawing.Size(200, 20)
        Me.txtdato.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'listbox
        '
        Me.listbox.FormattingEnabled = True
        Me.listbox.Location = New System.Drawing.Point(188, 126)
        Me.listbox.Name = "listbox"
        Me.listbox.Size = New System.Drawing.Size(436, 173)
        Me.listbox.TabIndex = 2
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(91, 352)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 3
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnagregar
        '
        Me.btnagregar.Location = New System.Drawing.Point(225, 352)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(75, 23)
        Me.btnagregar.TabIndex = 4
        Me.btnagregar.Text = "Agregar"
        Me.btnagregar.UseVisualStyleBackColor = True
        '
        'btneliminar
        '
        Me.btneliminar.Location = New System.Drawing.Point(363, 352)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(75, 23)
        Me.btneliminar.TabIndex = 5
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'btnmodificar
        '
        Me.btnmodificar.Location = New System.Drawing.Point(512, 352)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(75, 23)
        Me.btnmodificar.TabIndex = 6
        Me.btnmodificar.Text = "Modificar"
        Me.btnmodificar.UseVisualStyleBackColor = True
        '
        'lblIngreseuntexto
        '
        Me.lblIngreseuntexto.AutoSize = True
        Me.lblIngreseuntexto.Location = New System.Drawing.Point(360, 35)
        Me.lblIngreseuntexto.Name = "lblIngreseuntexto"
        Me.lblIngreseuntexto.Size = New System.Drawing.Size(83, 13)
        Me.lblIngreseuntexto.TabIndex = 7
        Me.lblIngreseuntexto.Text = "Ingrese un texto"
        '
        'lblcantidad
        '
        Me.lblcantidad.AutoSize = True
        Me.lblcantidad.Location = New System.Drawing.Point(655, 357)
        Me.lblcantidad.Name = "lblcantidad"
        Me.lblcantidad.Size = New System.Drawing.Size(13, 13)
        Me.lblcantidad.TabIndex = 8
        Me.lblcantidad.Text = "0"
        '
        'formlistbox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblcantidad)
        Me.Controls.Add(Me.lblIngreseuntexto)
        Me.Controls.Add(Me.btnmodificar)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.btnagregar)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.listbox)
        Me.Controls.Add(Me.txtdato)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "formlistbox"
        Me.Text = " "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtdato As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents listbox As ListBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnagregar As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents btnmodificar As Button
    Friend WithEvents lblIngreseuntexto As Label
    Friend WithEvents lblcantidad As Label
End Class

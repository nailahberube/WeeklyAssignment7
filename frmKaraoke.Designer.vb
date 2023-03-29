<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmKaraoke
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.pnlKaraoke = New System.Windows.Forms.Panel()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.btnClearForm = New System.Windows.Forms.Button()
        Me.btnTotalCost = New System.Windows.Forms.Button()
        Me.txtTotalHours = New System.Windows.Forms.TextBox()
        Me.lblHourlyRentalRoom = New System.Windows.Forms.Label()
        Me.cboComboBox = New System.Windows.Forms.ComboBox()
        Me.lblKMN = New System.Windows.Forms.Label()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlKaraoke.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlKaraoke
        '
        Me.pnlKaraoke.BackColor = System.Drawing.Color.Black
        Me.pnlKaraoke.Controls.Add(Me.lblTotalCost)
        Me.pnlKaraoke.Controls.Add(Me.btnClearForm)
        Me.pnlKaraoke.Controls.Add(Me.btnTotalCost)
        Me.pnlKaraoke.Controls.Add(Me.txtTotalHours)
        Me.pnlKaraoke.Controls.Add(Me.lblHourlyRentalRoom)
        Me.pnlKaraoke.Controls.Add(Me.cboComboBox)
        Me.pnlKaraoke.Controls.Add(Me.lblKMN)
        Me.pnlKaraoke.Location = New System.Drawing.Point(341, 1)
        Me.pnlKaraoke.Name = "pnlKaraoke"
        Me.pnlKaraoke.Size = New System.Drawing.Size(506, 508)
        Me.pnlKaraoke.TabIndex = 0
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.BackColor = System.Drawing.Color.White
        Me.lblTotalCost.Location = New System.Drawing.Point(145, 396)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(119, 20)
        Me.lblTotalCost.TabIndex = 6
        Me.lblTotalCost.Text = "XXXXXXXXXX"
        '
        'btnClearForm
        '
        Me.btnClearForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearForm.Location = New System.Drawing.Point(87, 316)
        Me.btnClearForm.Name = "btnClearForm"
        Me.btnClearForm.Size = New System.Drawing.Size(130, 35)
        Me.btnClearForm.TabIndex = 5
        Me.btnClearForm.Text = "Clear Form "
        Me.btnClearForm.UseVisualStyleBackColor = True
        '
        'btnTotalCost
        '
        Me.btnTotalCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTotalCost.Location = New System.Drawing.Point(339, 316)
        Me.btnTotalCost.Name = "btnTotalCost"
        Me.btnTotalCost.Size = New System.Drawing.Size(130, 35)
        Me.btnTotalCost.TabIndex = 4
        Me.btnTotalCost.Text = "Total Cost "
        Me.btnTotalCost.UseVisualStyleBackColor = True
        '
        'txtTotalHours
        '
        Me.txtTotalHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalHours.Location = New System.Drawing.Point(258, 270)
        Me.txtTotalHours.MaxLength = 2
        Me.txtTotalHours.Name = "txtTotalHours"
        Me.txtTotalHours.Size = New System.Drawing.Size(41, 26)
        Me.txtTotalHours.TabIndex = 3
        Me.txtTotalHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblHourlyRentalRoom
        '
        Me.lblHourlyRentalRoom.AutoSize = True
        Me.lblHourlyRentalRoom.BackColor = System.Drawing.Color.Black
        Me.lblHourlyRentalRoom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHourlyRentalRoom.ForeColor = System.Drawing.Color.White
        Me.lblHourlyRentalRoom.Location = New System.Drawing.Point(132, 210)
        Me.lblHourlyRentalRoom.Name = "lblHourlyRentalRoom"
        Me.lblHourlyRentalRoom.Size = New System.Drawing.Size(298, 22)
        Me.lblHourlyRentalRoom.TabIndex = 2
        Me.lblHourlyRentalRoom.Text = "Hourly Rental of Karaoke Room "
        '
        'cboComboBox
        '
        Me.cboComboBox.FormattingEnabled = True
        Me.cboComboBox.Items.AddRange(New Object() {"Number of Songs ($2.99 per song)", "Hours in Private Karaoke Booth ($8.99 per hour) "})
        Me.cboComboBox.Location = New System.Drawing.Point(87, 111)
        Me.cboComboBox.Name = "cboComboBox"
        Me.cboComboBox.Size = New System.Drawing.Size(382, 28)
        Me.cboComboBox.TabIndex = 1
        Me.cboComboBox.Text = "Customize Your Night:"
        '
        'lblKMN
        '
        Me.lblKMN.AutoSize = True
        Me.lblKMN.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKMN.ForeColor = System.Drawing.Color.White
        Me.lblKMN.Location = New System.Drawing.Point(113, 33)
        Me.lblKMN.Name = "lblKMN"
        Me.lblKMN.Size = New System.Drawing.Size(332, 37)
        Me.lblKMN.TabIndex = 0
        Me.lblKMN.Text = "Karaoke Music Night"
        '
        'frmKaraoke
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.WeeklyAssignment7.My.Resources.Resources.karaoke
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(848, 509)
        Me.Controls.Add(Me.pnlKaraoke)
        Me.Name = "frmKaraoke"
        Me.Text = "Karaoke Music Night "
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlKaraoke.ResumeLayout(False)
        Me.pnlKaraoke.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents pnlKaraoke As Panel
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents btnClearForm As Button
    Friend WithEvents btnTotalCost As Button
    Friend WithEvents txtTotalHours As TextBox
    Friend WithEvents lblHourlyRentalRoom As Label
    Friend WithEvents cboComboBox As ComboBox
    Friend WithEvents lblKMN As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNewCust
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNewCust))
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.TxtCode = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Btncancel = New MykeCtrlEx.PushButton()
        Me.Btnsave = New MykeCtrlEx.PushButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtAddress = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtName
        '
        Me.TxtName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TxtName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TxtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtName.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtName.Location = New System.Drawing.Point(173, 55)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(364, 27)
        Me.TxtName.TabIndex = 1
        '
        'TxtCode
        '
        Me.TxtCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TxtCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TxtCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCode.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCode.Location = New System.Drawing.Point(173, 18)
        Me.TxtCode.Name = "TxtCode"
        Me.TxtCode.Size = New System.Drawing.Size(153, 27)
        Me.TxtCode.TabIndex = 0
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(7, 49)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(159, 39)
        Me.Label17.TabIndex = 175
        Me.Label17.Text = "Customer/Supplier Name"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(7, 18)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(84, 15)
        Me.Label15.TabIndex = 174
        Me.Label15.Text = "Code"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Btncancel
        '
        Me.Btncancel.BackgroundImage = CType(resources.GetObject("Btncancel.BackgroundImage"), System.Drawing.Image)
        Me.Btncancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btncancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btncancel.FlatAppearance.BorderSize = 0
        Me.Btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btncancel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btncancel.ForeColor = System.Drawing.Color.Black
        Me.Btncancel.GUI_ACCSS = "JMoiakne122208"
        Me.Btncancel.GUI_ENABLE_HOVER = True
        Me.Btncancel.GUI_ENABLED = True
        Me.Btncancel.GUI_FORECOLOR_HOVER = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btncancel.GUI_ICONS = MykeCtrlEx.PushButton.Icons.None
        Me.Btncancel.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickBlue
        Me.Btncancel.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Black
        Me.Btncancel.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.Btncancel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btncancel.Location = New System.Drawing.Point(434, 169)
        Me.Btncancel.Name = "Btncancel"
        Me.Btncancel.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.Btncancel.Size = New System.Drawing.Size(107, 33)
        Me.Btncancel.TabIndex = 4
        Me.Btncancel.Text = "CANCEL"
        Me.Btncancel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btncancel.UseVisualStyleBackColor = True
        '
        'Btnsave
        '
        Me.Btnsave.BackgroundImage = CType(resources.GetObject("Btnsave.BackgroundImage"), System.Drawing.Image)
        Me.Btnsave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btnsave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btnsave.FlatAppearance.BorderSize = 0
        Me.Btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnsave.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnsave.ForeColor = System.Drawing.Color.Black
        Me.Btnsave.GUI_ACCSS = "JMoiakne122208"
        Me.Btnsave.GUI_ENABLE_HOVER = True
        Me.Btnsave.GUI_ENABLED = True
        Me.Btnsave.GUI_FORECOLOR_HOVER = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btnsave.GUI_ICONS = MykeCtrlEx.PushButton.Icons.None
        Me.Btnsave.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickBlue
        Me.Btnsave.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Black
        Me.Btnsave.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.Btnsave.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btnsave.Location = New System.Drawing.Point(316, 169)
        Me.Btnsave.Name = "Btnsave"
        Me.Btnsave.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.Btnsave.Size = New System.Drawing.Size(107, 33)
        Me.Btnsave.TabIndex = 3
        Me.Btnsave.Text = "SAVE"
        Me.Btnsave.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btnsave.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(8, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 39)
        Me.Label1.TabIndex = 179
        Me.Label1.Text = "Address:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtAddress
        '
        Me.TxtAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TxtAddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TxtAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtAddress.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAddress.Location = New System.Drawing.Point(173, 93)
        Me.TxtAddress.Multiline = True
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.Size = New System.Drawing.Size(365, 50)
        Me.TxtAddress.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.TxtCode)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TxtName)
        Me.Panel1.Controls.Add(Me.TxtAddress)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(556, 163)
        Me.Panel1.TabIndex = 180
        '
        'FrmNewCust
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WeighingSystemV1_1.My.Resources.Resources.f
        Me.ClientSize = New System.Drawing.Size(556, 208)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Btncancel)
        Me.Controls.Add(Me.Btnsave)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmNewCust"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add New Client"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TxtName As System.Windows.Forms.TextBox
    Friend WithEvents TxtCode As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Btncancel As MykeCtrlEx.PushButton
    Friend WithEvents Btnsave As MykeCtrlEx.PushButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTransOK
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTransOK))
        Me.TxtMsg = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnClose = New MykeCtrlEx.PushButton()
        Me.BtnReprint = New MykeCtrlEx.PushButton()
        Me.btnclosing = New MykeCtrlEx.PushButton()
        Me.SuspendLayout()
        '
        'TxtMsg
        '
        Me.TxtMsg.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMsg.Location = New System.Drawing.Point(12, 58)
        Me.TxtMsg.Multiline = True
        Me.TxtMsg.Name = "TxtMsg"
        Me.TxtMsg.ReadOnly = True
        Me.TxtMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtMsg.Size = New System.Drawing.Size(393, 143)
        Me.TxtMsg.TabIndex = 0
        Me.TxtMsg.TabStop = False
        Me.TxtMsg.Text = "Transaction Com"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 15)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Status Window"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Symbol", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 270)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Copright By: Terriniel Scales Inc."
        '
        'BtnClose
        '
        Me.BtnClose.BackgroundImage = CType(resources.GetObject("BtnClose.BackgroundImage"), System.Drawing.Image)
        Me.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClose.FlatAppearance.BorderSize = 0
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.ForeColor = System.Drawing.Color.Maroon
        Me.BtnClose.GUI_ACCSS = "JMoiakne122208"
        Me.BtnClose.GUI_ENABLE_HOVER = True
        Me.BtnClose.GUI_ENABLED = True
        Me.BtnClose.GUI_FORECOLOR_HOVER = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnClose.GUI_ICONS = MykeCtrlEx.PushButton.Icons.None
        Me.BtnClose.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickBlue
        Me.BtnClose.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Empty
        Me.BtnClose.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnClose.Location = New System.Drawing.Point(310, 211)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(95, 47)
        Me.BtnClose.TabIndex = 9
        Me.BtnClose.Text = "Close"
        Me.BtnClose.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'BtnReprint
        '
        Me.BtnReprint.BackgroundImage = CType(resources.GetObject("BtnReprint.BackgroundImage"), System.Drawing.Image)
        Me.BtnReprint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnReprint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnReprint.FlatAppearance.BorderSize = 0
        Me.BtnReprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReprint.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReprint.ForeColor = System.Drawing.Color.Maroon
        Me.BtnReprint.GUI_ACCSS = "JMoiakne122208"
        Me.BtnReprint.GUI_ENABLE_HOVER = True
        Me.BtnReprint.GUI_ENABLED = True
        Me.BtnReprint.GUI_FORECOLOR_HOVER = System.Drawing.Color.Empty
        Me.BtnReprint.GUI_ICONS = MykeCtrlEx.PushButton.Icons.None
        Me.BtnReprint.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickBlue
        Me.BtnReprint.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Empty
        Me.BtnReprint.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnReprint.Location = New System.Drawing.Point(201, 211)
        Me.BtnReprint.Name = "BtnReprint"
        Me.BtnReprint.Size = New System.Drawing.Size(103, 47)
        Me.BtnReprint.TabIndex = 8
        Me.BtnReprint.Text = "Re-Print"
        Me.BtnReprint.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnReprint.UseVisualStyleBackColor = True
        '
        'btnclosing
        '
        Me.btnclosing.BackgroundImage = CType(resources.GetObject("btnclosing.BackgroundImage"), System.Drawing.Image)
        Me.btnclosing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnclosing.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnclosing.FlatAppearance.BorderSize = 0
        Me.btnclosing.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclosing.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclosing.ForeColor = System.Drawing.Color.Maroon
        Me.btnclosing.GUI_ACCSS = "JMoiakne122208"
        Me.btnclosing.GUI_ENABLE_HOVER = True
        Me.btnclosing.GUI_ENABLED = True
        Me.btnclosing.GUI_FORECOLOR_HOVER = System.Drawing.Color.Empty
        Me.btnclosing.GUI_ICONS = MykeCtrlEx.PushButton.Icons.None
        Me.btnclosing.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickBlue
        Me.btnclosing.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Empty
        Me.btnclosing.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.btnclosing.Location = New System.Drawing.Point(92, 211)
        Me.btnclosing.Name = "btnclosing"
        Me.btnclosing.Size = New System.Drawing.Size(103, 47)
        Me.btnclosing.TabIndex = 12
        Me.btnclosing.Text = "Print Closing"
        Me.btnclosing.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnclosing.UseVisualStyleBackColor = True
        Me.btnclosing.Visible = False
        '
        'FrmTransOK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WeighingSystemV1_1.My.Resources.Resources.msgbox
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(417, 297)
        Me.Controls.Add(Me.btnclosing)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnReprint)
        Me.Controls.Add(Me.TxtMsg)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "FrmTransOK"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmTransOK"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtMsg As System.Windows.Forms.TextBox
    Friend WithEvents BtnClose As MykeCtrlEx.PushButton
    Friend WithEvents BtnReprint As MykeCtrlEx.PushButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnclosing As MykeCtrlEx.PushButton
End Class

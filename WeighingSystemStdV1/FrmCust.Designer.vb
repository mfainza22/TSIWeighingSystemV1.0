<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCust
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCust))
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Dg = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.BtnFirst = New System.Windows.Forms.ToolStripButton()
        Me.BtnBack = New System.Windows.Forms.ToolStripButton()
        Me.LblRecord = New System.Windows.Forms.ToolStripTextBox()
        Me.BtnNext = New System.Windows.Forms.ToolStripButton()
        Me.BtnLast = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.PnlHeader = New System.Windows.Forms.Panel()
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnPrint = New MykeCtrlEx.PushButton()
        Me.BtnExit = New MykeCtrlEx.PushButton()
        Me.Col_Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_addr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Contactp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_telno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_active = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Panel10.SuspendLayout()
        CType(Me.Dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.PnlHeader.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.White
        Me.Panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel10.Controls.Add(Me.Dg)
        Me.Panel10.Controls.Add(Me.ToolStrip1)
        Me.Panel10.Controls.Add(Me.Panel6)
        Me.Panel10.Controls.Add(Me.PnlHeader)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel10.Location = New System.Drawing.Point(5, 5)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(969, 449)
        Me.Panel10.TabIndex = 29
        '
        'Dg
        '
        Me.Dg.BackgroundColor = System.Drawing.SystemColors.ControlDark
        Me.Dg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Dg.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dg.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Dg.ColumnHeadersHeight = 30
        Me.Dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Col_Id, Me.Col_Code, Me.Col_Name, Me.Col_addr, Me.Col_Contactp, Me.Col_telno, Me.Col_active})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Dg.DefaultCellStyle = DataGridViewCellStyle2
        Me.Dg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dg.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.Dg.GridColor = System.Drawing.Color.Aqua
        Me.Dg.Location = New System.Drawing.Point(0, 108)
        Me.Dg.MultiSelect = False
        Me.Dg.Name = "Dg"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial Narrow", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Aqua
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dg.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.Dg.RowHeadersWidth = 75
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Aqua
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.DimGray
        Me.Dg.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.Dg.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.Dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dg.Size = New System.Drawing.Size(967, 306)
        Me.Dg.TabIndex = 142
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackgroundImage = Global.WeighingSystemV1_1.My.Resources.Resources.WhiteHeader3
        Me.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.BtnFirst, Me.BtnBack, Me.LblRecord, Me.BtnNext, Me.BtnLast, Me.ToolStripSeparator1, Me.ToolStripLabel2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 414)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(967, 33)
        Me.ToolStrip1.TabIndex = 144
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripLabel1.Margin = New System.Windows.Forms.Padding(27, 1, 0, 2)
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(44, 30)
        Me.ToolStripLabel1.Text = "Record"
        '
        'BtnFirst
        '
        Me.BtnFirst.AutoSize = False
        Me.BtnFirst.BackColor = System.Drawing.Color.Transparent
        Me.BtnFirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnFirst.Image = Global.WeighingSystemV1_1.My.Resources.Resources.First_16px
        Me.BtnFirst.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnFirst.Name = "BtnFirst"
        Me.BtnFirst.Size = New System.Drawing.Size(24, 24)
        Me.BtnFirst.Tag = "20,20"
        '
        'BtnBack
        '
        Me.BtnBack.AutoSize = False
        Me.BtnBack.BackColor = System.Drawing.Color.Transparent
        Me.BtnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnBack.Image = Global.WeighingSystemV1_1.My.Resources.Resources.Back_16px
        Me.BtnBack.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BtnBack.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(24, 24)
        Me.BtnBack.Tag = "20,20"
        '
        'LblRecord
        '
        Me.LblRecord.AutoSize = False
        Me.LblRecord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblRecord.Name = "LblRecord"
        Me.LblRecord.Size = New System.Drawing.Size(100, 23)
        Me.LblRecord.Text = "0 of 0"
        Me.LblRecord.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnNext
        '
        Me.BtnNext.AutoSize = False
        Me.BtnNext.BackColor = System.Drawing.Color.Transparent
        Me.BtnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnNext.Image = Global.WeighingSystemV1_1.My.Resources.Resources.Next_16px
        Me.BtnNext.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BtnNext.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(24, 24)
        Me.BtnNext.Tag = "20,20"
        '
        'BtnLast
        '
        Me.BtnLast.AutoSize = False
        Me.BtnLast.BackColor = System.Drawing.Color.Transparent
        Me.BtnLast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnLast.Image = Global.WeighingSystemV1_1.My.Resources.Resources.Last_16px
        Me.BtnLast.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnLast.Name = "BtnLast"
        Me.BtnLast.Size = New System.Drawing.Size(24, 24)
        Me.BtnLast.Tag = "20,20"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 33)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(99, 30)
        Me.ToolStripLabel2.Text = "TABLE: CUSTOMER"
        '
        'Panel6
        '
        Me.Panel6.AccessibleDescription = "PnlSearcher"
        Me.Panel6.BackgroundImage = Global.WeighingSystemV1_1.My.Resources.Resources.WhiteHeader3
        Me.Panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 98)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(967, 10)
        Me.Panel6.TabIndex = 141
        '
        'PnlHeader
        '
        Me.PnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.PnlHeader.BackgroundImage = Global.WeighingSystemV1_1.My.Resources.Resources.WhiteHeader1
        Me.PnlHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlHeader.Controls.Add(Me.TxtSearch)
        Me.PnlHeader.Controls.Add(Me.Label14)
        Me.PnlHeader.Controls.Add(Me.Label2)
        Me.PnlHeader.Controls.Add(Me.Panel3)
        Me.PnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.PnlHeader.Name = "PnlHeader"
        Me.PnlHeader.Size = New System.Drawing.Size(967, 98)
        Me.PnlHeader.TabIndex = 143
        '
        'TxtSearch
        '
        Me.TxtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TxtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TxtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSearch.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSearch.Location = New System.Drawing.Point(81, 69)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(446, 23)
        Me.TxtSearch.TabIndex = 133
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(13, 76)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(44, 15)
        Me.Label14.TabIndex = 136
        Me.Label14.Text = "Search"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(8, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(248, 26)
        Me.Label2.TabIndex = 140
        Me.Label2.Text = "CUSTOMER MAINTENANCE"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.BtnPrint)
        Me.Panel3.Controls.Add(Me.BtnExit)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(765, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(202, 98)
        Me.Panel3.TabIndex = 8
        '
        'BtnPrint
        '
        Me.BtnPrint.BackgroundImage = CType(resources.GetObject("BtnPrint.BackgroundImage"), System.Drawing.Image)
        Me.BtnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrint.FlatAppearance.BorderSize = 0
        Me.BtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPrint.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnPrint.ForeColor = System.Drawing.Color.Maroon
        Me.BtnPrint.GUI_ACCSS = "JMoiakne122208"
        Me.BtnPrint.GUI_ENABLE_HOVER = True
        Me.BtnPrint.GUI_ENABLED = True
        Me.BtnPrint.GUI_FORECOLOR_HOVER = System.Drawing.Color.Empty
        Me.BtnPrint.GUI_ICONS = MykeCtrlEx.PushButton.Icons.Printer16
        Me.BtnPrint.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickYellow
        Me.BtnPrint.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Empty
        Me.BtnPrint.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnPrint.Image = CType(resources.GetObject("BtnPrint.Image"), System.Drawing.Image)
        Me.BtnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPrint.Location = New System.Drawing.Point(30, 6)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(100, 31)
        Me.BtnPrint.TabIndex = 143
        Me.BtnPrint.Text = "Print List"
        Me.BtnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.BackgroundImage = CType(resources.GetObject("BtnExit.BackgroundImage"), System.Drawing.Image)
        Me.BtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExit.FlatAppearance.BorderSize = 0
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnExit.ForeColor = System.Drawing.Color.Maroon
        Me.BtnExit.GUI_ACCSS = "JMoiakne122208"
        Me.BtnExit.GUI_ENABLE_HOVER = True
        Me.BtnExit.GUI_ENABLED = True
        Me.BtnExit.GUI_FORECOLOR_HOVER = System.Drawing.Color.Empty
        Me.BtnExit.GUI_ICONS = MykeCtrlEx.PushButton.Icons.Home24
        Me.BtnExit.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickYellow
        Me.BtnExit.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Empty
        Me.BtnExit.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnExit.Image = CType(resources.GetObject("BtnExit.Image"), System.Drawing.Image)
        Me.BtnExit.Location = New System.Drawing.Point(136, 6)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(63, 31)
        Me.BtnExit.TabIndex = 141
        Me.BtnExit.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'Col_Id
        '
        Me.Col_Id.HeaderText = "Id"
        Me.Col_Id.MaxInputLength = 0
        Me.Col_Id.MinimumWidth = 2
        Me.Col_Id.Name = "Col_Id"
        Me.Col_Id.ReadOnly = True
        Me.Col_Id.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Col_Id.Width = 2
        '
        'Col_Code
        '
        Me.Col_Code.HeaderText = "Customer Code"
        Me.Col_Code.MaxInputLength = 15
        Me.Col_Code.Name = "Col_Code"
        Me.Col_Code.Width = 120
        '
        'Col_Name
        '
        Me.Col_Name.HeaderText = "Company/Customer Name"
        Me.Col_Name.MaxInputLength = 35
        Me.Col_Name.Name = "Col_Name"
        Me.Col_Name.Width = 270
        '
        'Col_addr
        '
        Me.Col_addr.HeaderText = "Address"
        Me.Col_addr.Name = "Col_addr"
        Me.Col_addr.Width = 300
        '
        'Col_Contactp
        '
        Me.Col_Contactp.HeaderText = "Contact Person"
        Me.Col_Contactp.Name = "Col_Contactp"
        Me.Col_Contactp.Width = 160
        '
        'Col_telno
        '
        Me.Col_telno.HeaderText = "Contact Number"
        Me.Col_telno.Name = "Col_telno"
        Me.Col_telno.Width = 120
        '
        'Col_active
        '
        Me.Col_active.HeaderText = "Active"
        Me.Col_active.Name = "Col_active"
        Me.Col_active.Width = 80
        '
        'FrmCust
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(979, 459)
        Me.Controls.Add(Me.Panel10)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FrmCust"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Table: Raw Materials"
        Me.Panel10.ResumeLayout(False)
        CType(Me.Dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.PnlHeader.ResumeLayout(False)
        Me.PnlHeader.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TxtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Dg As System.Windows.Forms.DataGridView
    Friend WithEvents Col_Pack As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PnlHeader As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BtnFirst As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnBack As System.Windows.Forms.ToolStripButton
    Friend WithEvents LblRecord As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BtnNext As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnLast As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BtnExit As MykeCtrlEx.PushButton
    Friend WithEvents BtnPrint As MykeCtrlEx.PushButton
    Friend WithEvents Col_Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col_Code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col_addr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col_Contactp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col_telno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col_active As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class

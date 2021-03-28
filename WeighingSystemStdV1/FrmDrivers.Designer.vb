<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDrivers
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDrivers))
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Dg = New System.Windows.Forms.DataGridView()
        Me.Col_Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.Panel10.Size = New System.Drawing.Size(765, 449)
        Me.Panel10.TabIndex = 29
        '
        'Dg
        '
        Me.Dg.BackgroundColor = System.Drawing.SystemColors.ControlDark
        Me.Dg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Dg.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dg.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.Dg.ColumnHeadersHeight = 30
        Me.Dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Col_Id, Me.Col_Name})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Dg.DefaultCellStyle = DataGridViewCellStyle6
        Me.Dg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dg.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.Dg.GridColor = System.Drawing.Color.Aqua
        Me.Dg.Location = New System.Drawing.Point(0, 108)
        Me.Dg.MultiSelect = False
        Me.Dg.Name = "Dg"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Arial Narrow", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Aqua
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dg.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.Dg.RowHeadersWidth = 75
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Aqua
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.DimGray
        Me.Dg.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.Dg.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.Dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dg.Size = New System.Drawing.Size(763, 306)
        Me.Dg.TabIndex = 142
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
        'Col_Name
        '
        Me.Col_Name.HeaderText = "Driver Name"
        Me.Col_Name.MaxInputLength = 35
        Me.Col_Name.Name = "Col_Name"
        Me.Col_Name.Width = 300
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.BtnFirst, Me.BtnBack, Me.LblRecord, Me.BtnNext, Me.BtnLast, Me.ToolStripSeparator1, Me.ToolStripLabel2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 414)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(763, 33)
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
        Me.BtnFirst.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
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
        Me.ToolStripLabel2.Size = New System.Drawing.Size(87, 30)
        Me.ToolStripLabel2.Text = "TABLE: DRIVERS"
        '
        'Panel6
        '
        Me.Panel6.AccessibleDescription = "PnlSearcher"
        Me.Panel6.BackgroundImage = Global.WeighingSystemV1_1.My.Resources.Resources.WhiteHeader3
        Me.Panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 98)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(763, 10)
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
        Me.PnlHeader.Size = New System.Drawing.Size(763, 98)
        Me.PnlHeader.TabIndex = 143
        '
        'TxtSearch
        '
        Me.TxtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TxtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TxtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSearch.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSearch.Location = New System.Drawing.Point(79, 67)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(446, 23)
        Me.TxtSearch.TabIndex = 133
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(11, 74)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(44, 15)
        Me.Label14.TabIndex = 136
        Me.Label14.Text = "Search"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(288, 26)
        Me.Label2.TabIndex = 140
        Me.Label2.Text = "DRIVER LISTING MAINTENANCE"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.BtnPrint)
        Me.Panel3.Controls.Add(Me.BtnExit)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(568, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(195, 98)
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
        Me.BtnPrint.Location = New System.Drawing.Point(12, 8)
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
        Me.BtnExit.Location = New System.Drawing.Point(118, 8)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(63, 31)
        Me.BtnExit.TabIndex = 141
        Me.BtnExit.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'FrmDrivers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(775, 459)
        Me.Controls.Add(Me.Panel10)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FrmDrivers"
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
    Friend WithEvents Col_Name As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IMSS_ResultUserControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IMSS_ResultUserControl))
        Me._IMSS_SizeColumn = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_ElementsColumn = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_CategoryColumn = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me._IMSS_OutPutPanels_Labels = New DevComponents.DotNetBar.PanelEx()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_TotaleSelectedItemsSizeToDelete_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_ItemToDeleteTotalNumber_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_FullSize_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_TotalItems_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_TotalCleanUpPotential = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_SelectedForCleanUp_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_ListHolders_Panel = New DevComponents.DotNetBar.PanelEx()
        Me._IMSS_CheckBoxX_CheckAllUnCheckAll = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.lvwTemps = New ComponentOwl.BetterListView.BetterListView()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_LitsHoders_Panel = New DevComponents.DotNetBar.PanelEx()
        Me.PanelEx3 = New DevComponents.DotNetBar.PanelEx()
        Me._IMSS_LA_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_MO_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_CO_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_LastAccess_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_ModifiedOn_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_CreatedOn_Label = New DevComponents.DotNetBar.LabelX()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me._IMSS_ViewItem = New DevComponents.DotNetBar.ButtonX()
        Me._IMSS_PROPERTIS = New DevComponents.DotNetBar.ButtonX()
        Me._IMSS_ItemName = New System.Windows.Forms.Label()
        Me._IMSS_LOGO_ITEM_TITLE = New System.Windows.Forms.PictureBox()
        Me._IMSS_DetailsTitle_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_Details_Panel = New DevComponents.DotNetBar.PanelEx()
        Me.PanelEx1.SuspendLayout()
        Me._IMSS_OutPutPanels_Labels.SuspendLayout()
        Me.PanelEx2.SuspendLayout()
        Me._IMSS_ListHolders_Panel.SuspendLayout()
        CType(Me.lvwTemps, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._IMSS_LitsHoders_Panel.SuspendLayout()
        Me.PanelEx3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._IMSS_LOGO_ITEM_TITLE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_IMSS_SizeColumn
        '
        Me._IMSS_SizeColumn.Name = "_IMSS_SizeColumn"
        Me._IMSS_SizeColumn.Text = "Size"
        Me._IMSS_SizeColumn.Width = 101
        '
        '_IMSS_ElementsColumn
        '
        Me._IMSS_ElementsColumn.Name = "_IMSS_ElementsColumn"
        Me._IMSS_ElementsColumn.Text = "Shortcut Target"
        Me._IMSS_ElementsColumn.Width = 400
        '
        '_IMSS_CategoryColumn
        '
        Me._IMSS_CategoryColumn.Name = "_IMSS_CategoryColumn"
        Me._IMSS_CategoryColumn.Text = "Category"
        Me._IMSS_CategoryColumn.Width = 514
        '
        'PanelEx1
        '
        Me.PanelEx1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me._IMSS_OutPutPanels_Labels)
        Me.PanelEx1.Controls.Add(Me._IMSS_ListHolders_Panel)
        Me.PanelEx1.Controls.Add(Me.lvwTemps)
        Me.PanelEx1.Location = New System.Drawing.Point(12, 40)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(570, 371)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.Color = System.Drawing.Color.White
        Me.PanelEx1.Style.BackColor2.Color = System.Drawing.Color.White
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 2
        '
        '_IMSS_OutPutPanels_Labels
        '
        Me._IMSS_OutPutPanels_Labels.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._IMSS_OutPutPanels_Labels.CanvasColor = System.Drawing.SystemColors.Control
        Me._IMSS_OutPutPanels_Labels.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_OutPutPanels_Labels.Controls.Add(Me.PanelEx2)
        Me._IMSS_OutPutPanels_Labels.Controls.Add(Me._IMSS_TotalCleanUpPotential)
        Me._IMSS_OutPutPanels_Labels.Controls.Add(Me._IMSS_SelectedForCleanUp_Label)
        Me._IMSS_OutPutPanels_Labels.Location = New System.Drawing.Point(0, 321)
        Me._IMSS_OutPutPanels_Labels.Name = "_IMSS_OutPutPanels_Labels"
        Me._IMSS_OutPutPanels_Labels.Size = New System.Drawing.Size(570, 50)
        Me._IMSS_OutPutPanels_Labels.Style.Alignment = System.Drawing.StringAlignment.Center
        Me._IMSS_OutPutPanels_Labels.Style.BackColor1.Color = System.Drawing.Color.WhiteSmoke
        Me._IMSS_OutPutPanels_Labels.Style.BackColor2.Color = System.Drawing.Color.Gainsboro
        Me._IMSS_OutPutPanels_Labels.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me._IMSS_OutPutPanels_Labels.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me._IMSS_OutPutPanels_Labels.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me._IMSS_OutPutPanels_Labels.Style.GradientAngle = 90
        Me._IMSS_OutPutPanels_Labels.TabIndex = 1
        '
        'PanelEx2
        '
        Me.PanelEx2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.LabelX5)
        Me.PanelEx2.Controls.Add(Me.LabelX4)
        Me.PanelEx2.Controls.Add(Me.LabelX3)
        Me.PanelEx2.Controls.Add(Me.LabelX2)
        Me.PanelEx2.Controls.Add(Me._IMSS_TotaleSelectedItemsSizeToDelete_Label)
        Me.PanelEx2.Controls.Add(Me._IMSS_ItemToDeleteTotalNumber_Label)
        Me.PanelEx2.Controls.Add(Me._IMSS_FullSize_Label)
        Me.PanelEx2.Controls.Add(Me._IMSS_TotalItems_Label)
        Me.PanelEx2.Location = New System.Drawing.Point(379, 3)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(188, 44)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.Color = System.Drawing.Color.WhiteSmoke
        Me.PanelEx2.Style.BackColor2.Color = System.Drawing.Color.Gainsboro
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.BorderWidth = 0
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 5
        '
        'LabelX5
        '
        Me.LabelX5.AutoSize = True
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.Location = New System.Drawing.Point(49, 23)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(31, 17)
        Me.LabelX5.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.LabelX5.TabIndex = 9
        Me.LabelX5.Text = "Item"
        '
        'LabelX4
        '
        Me.LabelX4.AutoSize = True
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.Location = New System.Drawing.Point(49, 3)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(32, 17)
        Me.LabelX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.LabelX4.TabIndex = 8
        Me.LabelX4.Text = "Item"
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.Location = New System.Drawing.Point(162, 23)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(19, 17)
        Me.LabelX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.LabelX3.TabIndex = 7
        Me.LabelX3.Text = "KB"
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(162, 3)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(20, 17)
        Me.LabelX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.LabelX2.TabIndex = 6
        Me.LabelX2.Text = "KB"
        '
        '_IMSS_TotaleSelectedItemsSizeToDelete_Label
        '
        Me._IMSS_TotaleSelectedItemsSizeToDelete_Label.AutoSize = True
        '
        '
        '
        Me._IMSS_TotaleSelectedItemsSizeToDelete_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_TotaleSelectedItemsSizeToDelete_Label.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_TotaleSelectedItemsSizeToDelete_Label.Location = New System.Drawing.Point(96, 3)
        Me._IMSS_TotaleSelectedItemsSizeToDelete_Label.Name = "_IMSS_TotaleSelectedItemsSizeToDelete_Label"
        Me._IMSS_TotaleSelectedItemsSizeToDelete_Label.Size = New System.Drawing.Size(14, 17)
        Me._IMSS_TotaleSelectedItemsSizeToDelete_Label.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me._IMSS_TotaleSelectedItemsSizeToDelete_Label.TabIndex = 5
        Me._IMSS_TotaleSelectedItemsSizeToDelete_Label.Text = """"""
        '
        '_IMSS_ItemToDeleteTotalNumber_Label
        '
        Me._IMSS_ItemToDeleteTotalNumber_Label.AutoSize = True
        '
        '
        '
        Me._IMSS_ItemToDeleteTotalNumber_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_ItemToDeleteTotalNumber_Label.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_ItemToDeleteTotalNumber_Label.Location = New System.Drawing.Point(15, 3)
        Me._IMSS_ItemToDeleteTotalNumber_Label.Name = "_IMSS_ItemToDeleteTotalNumber_Label"
        Me._IMSS_ItemToDeleteTotalNumber_Label.Size = New System.Drawing.Size(26, 17)
        Me._IMSS_ItemToDeleteTotalNumber_Label.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me._IMSS_ItemToDeleteTotalNumber_Label.TabIndex = 2
        Me._IMSS_ItemToDeleteTotalNumber_Label.Text = "100"
        '
        '_IMSS_FullSize_Label
        '
        Me._IMSS_FullSize_Label.AutoSize = True
        '
        '
        '
        Me._IMSS_FullSize_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_FullSize_Label.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_FullSize_Label.Location = New System.Drawing.Point(96, 23)
        Me._IMSS_FullSize_Label.Name = "_IMSS_FullSize_Label"
        Me._IMSS_FullSize_Label.Size = New System.Drawing.Size(14, 17)
        Me._IMSS_FullSize_Label.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me._IMSS_FullSize_Label.TabIndex = 4
        Me._IMSS_FullSize_Label.Text = """"""
        '
        '_IMSS_TotalItems_Label
        '
        Me._IMSS_TotalItems_Label.AutoSize = True
        '
        '
        '
        Me._IMSS_TotalItems_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_TotalItems_Label.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_TotalItems_Label.Location = New System.Drawing.Point(16, 23)
        Me._IMSS_TotalItems_Label.Name = "_IMSS_TotalItems_Label"
        Me._IMSS_TotalItems_Label.Size = New System.Drawing.Size(25, 17)
        Me._IMSS_TotalItems_Label.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me._IMSS_TotalItems_Label.TabIndex = 3
        Me._IMSS_TotalItems_Label.Text = "100"
        '
        '_IMSS_TotalCleanUpPotential
        '
        Me._IMSS_TotalCleanUpPotential.AutoSize = True
        '
        '
        '
        Me._IMSS_TotalCleanUpPotential.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_TotalCleanUpPotential.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_TotalCleanUpPotential.Location = New System.Drawing.Point(8, 24)
        Me._IMSS_TotalCleanUpPotential.Name = "_IMSS_TotalCleanUpPotential"
        Me._IMSS_TotalCleanUpPotential.Size = New System.Drawing.Size(151, 17)
        Me._IMSS_TotalCleanUpPotential.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me._IMSS_TotalCleanUpPotential.TabIndex = 1
        Me._IMSS_TotalCleanUpPotential.Text = "Total clean-up potential:"
        '
        '_IMSS_SelectedForCleanUp_Label
        '
        Me._IMSS_SelectedForCleanUp_Label.AutoSize = True
        '
        '
        '
        Me._IMSS_SelectedForCleanUp_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_SelectedForCleanUp_Label.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_SelectedForCleanUp_Label.Location = New System.Drawing.Point(8, 4)
        Me._IMSS_SelectedForCleanUp_Label.Name = "_IMSS_SelectedForCleanUp_Label"
        Me._IMSS_SelectedForCleanUp_Label.Size = New System.Drawing.Size(142, 17)
        Me._IMSS_SelectedForCleanUp_Label.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me._IMSS_SelectedForCleanUp_Label.TabIndex = 0
        Me._IMSS_SelectedForCleanUp_Label.Text = "Selected for clean-up:"
        '
        '_IMSS_ListHolders_Panel
        '
        Me._IMSS_ListHolders_Panel.CanvasColor = System.Drawing.SystemColors.Control
        Me._IMSS_ListHolders_Panel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_ListHolders_Panel.Controls.Add(Me._IMSS_CheckBoxX_CheckAllUnCheckAll)
        Me._IMSS_ListHolders_Panel.Dock = System.Windows.Forms.DockStyle.Top
        Me._IMSS_ListHolders_Panel.Location = New System.Drawing.Point(0, 0)
        Me._IMSS_ListHolders_Panel.Name = "_IMSS_ListHolders_Panel"
        Me._IMSS_ListHolders_Panel.Size = New System.Drawing.Size(570, 26)
        Me._IMSS_ListHolders_Panel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me._IMSS_ListHolders_Panel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me._IMSS_ListHolders_Panel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me._IMSS_ListHolders_Panel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me._IMSS_ListHolders_Panel.Style.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_ListHolders_Panel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me._IMSS_ListHolders_Panel.Style.GradientAngle = 90
        Me._IMSS_ListHolders_Panel.TabIndex = 0
        Me._IMSS_ListHolders_Panel.Text = "  Broken shortcut of the system and other software"
        '
        '_IMSS_CheckBoxX_CheckAllUnCheckAll
        '
        Me._IMSS_CheckBoxX_CheckAllUnCheckAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me._IMSS_CheckBoxX_CheckAllUnCheckAll.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_CheckBoxX_CheckAllUnCheckAll.Checked = True
        Me._IMSS_CheckBoxX_CheckAllUnCheckAll.CheckState = System.Windows.Forms.CheckState.Checked
        Me._IMSS_CheckBoxX_CheckAllUnCheckAll.CheckValue = "Y"
        Me._IMSS_CheckBoxX_CheckAllUnCheckAll.Location = New System.Drawing.Point(430, 3)
        Me._IMSS_CheckBoxX_CheckAllUnCheckAll.Name = "_IMSS_CheckBoxX_CheckAllUnCheckAll"
        Me._IMSS_CheckBoxX_CheckAllUnCheckAll.Size = New System.Drawing.Size(136, 20)
        Me._IMSS_CheckBoxX_CheckAllUnCheckAll.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_CheckBoxX_CheckAllUnCheckAll.TabIndex = 0
        Me._IMSS_CheckBoxX_CheckAllUnCheckAll.Text = "Check | UnCheck Items"
        '
        'lvwTemps
        '
        Me.lvwTemps.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwTemps.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvwTemps.CheckBoxes = ComponentOwl.BetterListView.BetterListViewCheckBoxes.TwoState
        Me.lvwTemps.Columns.AddRange(New Object() {Me._IMSS_CategoryColumn, Me._IMSS_ElementsColumn, Me._IMSS_SizeColumn})
        Me.lvwTemps.Location = New System.Drawing.Point(2, 27)
        Me.lvwTemps.MultiSelect = False
        Me.lvwTemps.Name = "lvwTemps"
        Me.lvwTemps.Size = New System.Drawing.Size(566, 292)
        Me.lvwTemps.TabIndex = 0
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(12, 11)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(432, 23)
        Me.LabelX1.TabIndex = 4
        Me.LabelX1.Text = "Select the items to be deleted for the current cleanup process"
        '
        '_IMSS_LitsHoders_Panel
        '
        Me._IMSS_LitsHoders_Panel.CanvasColor = System.Drawing.SystemColors.Control
        Me._IMSS_LitsHoders_Panel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_LitsHoders_Panel.Controls.Add(Me.LabelX1)
        Me._IMSS_LitsHoders_Panel.Controls.Add(Me.PanelEx3)
        Me._IMSS_LitsHoders_Panel.Controls.Add(Me.PanelEx1)
        Me._IMSS_LitsHoders_Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me._IMSS_LitsHoders_Panel.Location = New System.Drawing.Point(0, 0)
        Me._IMSS_LitsHoders_Panel.Name = "_IMSS_LitsHoders_Panel"
        Me._IMSS_LitsHoders_Panel.Size = New System.Drawing.Size(824, 414)
        Me._IMSS_LitsHoders_Panel.Style.Alignment = System.Drawing.StringAlignment.Center
        Me._IMSS_LitsHoders_Panel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me._IMSS_LitsHoders_Panel.Style.BackColor2.Color = System.Drawing.Color.White
        Me._IMSS_LitsHoders_Panel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me._IMSS_LitsHoders_Panel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me._IMSS_LitsHoders_Panel.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.None
        Me._IMSS_LitsHoders_Panel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me._IMSS_LitsHoders_Panel.Style.GradientAngle = 90
        Me._IMSS_LitsHoders_Panel.TabIndex = 4
        '
        'PanelEx3
        '
        Me.PanelEx3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelEx3.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx3.Controls.Add(Me._IMSS_LA_Label)
        Me.PanelEx3.Controls.Add(Me._IMSS_MO_Label)
        Me.PanelEx3.Controls.Add(Me._IMSS_CO_Label)
        Me.PanelEx3.Controls.Add(Me._IMSS_LastAccess_Label)
        Me.PanelEx3.Controls.Add(Me._IMSS_ModifiedOn_Label)
        Me.PanelEx3.Controls.Add(Me._IMSS_CreatedOn_Label)
        Me.PanelEx3.Controls.Add(Me.PictureBox1)
        Me.PanelEx3.Controls.Add(Me._IMSS_ViewItem)
        Me.PanelEx3.Controls.Add(Me._IMSS_PROPERTIS)
        Me.PanelEx3.Controls.Add(Me._IMSS_ItemName)
        Me.PanelEx3.Controls.Add(Me._IMSS_LOGO_ITEM_TITLE)
        Me.PanelEx3.Controls.Add(Me._IMSS_DetailsTitle_Label)
        Me.PanelEx3.Controls.Add(Me._IMSS_Details_Panel)
        Me.PanelEx3.Location = New System.Drawing.Point(588, 40)
        Me.PanelEx3.Name = "PanelEx3"
        Me.PanelEx3.Size = New System.Drawing.Size(224, 371)
        Me.PanelEx3.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx3.Style.BackColor1.Color = System.Drawing.Color.WhiteSmoke
        Me.PanelEx3.Style.BackColor2.Color = System.Drawing.Color.White
        Me.PanelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx3.Style.GradientAngle = 90
        Me.PanelEx3.TabIndex = 3
        '
        '_IMSS_LA_Label
        '
        Me._IMSS_LA_Label.AutoSize = True
        '
        '
        '
        Me._IMSS_LA_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_LA_Label.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_LA_Label.Location = New System.Drawing.Point(89, 268)
        Me._IMSS_LA_Label.Name = "_IMSS_LA_Label"
        Me._IMSS_LA_Label.Size = New System.Drawing.Size(15, 16)
        Me._IMSS_LA_Label.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me._IMSS_LA_Label.TabIndex = 20
        Me._IMSS_LA_Label.Text = "..."
        '
        '_IMSS_MO_Label
        '
        Me._IMSS_MO_Label.AutoSize = True
        '
        '
        '
        Me._IMSS_MO_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_MO_Label.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_MO_Label.Location = New System.Drawing.Point(89, 231)
        Me._IMSS_MO_Label.Name = "_IMSS_MO_Label"
        Me._IMSS_MO_Label.Size = New System.Drawing.Size(15, 16)
        Me._IMSS_MO_Label.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me._IMSS_MO_Label.TabIndex = 19
        Me._IMSS_MO_Label.Text = "..."
        '
        '_IMSS_CO_Label
        '
        Me._IMSS_CO_Label.AutoSize = True
        '
        '
        '
        Me._IMSS_CO_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_CO_Label.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_CO_Label.Location = New System.Drawing.Point(89, 199)
        Me._IMSS_CO_Label.Name = "_IMSS_CO_Label"
        Me._IMSS_CO_Label.Size = New System.Drawing.Size(15, 16)
        Me._IMSS_CO_Label.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me._IMSS_CO_Label.TabIndex = 18
        Me._IMSS_CO_Label.Text = "..."
        '
        '_IMSS_LastAccess_Label
        '
        Me._IMSS_LastAccess_Label.AutoSize = True
        '
        '
        '
        Me._IMSS_LastAccess_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_LastAccess_Label.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_LastAccess_Label.Location = New System.Drawing.Point(9, 268)
        Me._IMSS_LastAccess_Label.Name = "_IMSS_LastAccess_Label"
        Me._IMSS_LastAccess_Label.Size = New System.Drawing.Size(75, 16)
        Me._IMSS_LastAccess_Label.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me._IMSS_LastAccess_Label.TabIndex = 17
        Me._IMSS_LastAccess_Label.Text = "Last Access :"
        '
        '_IMSS_ModifiedOn_Label
        '
        Me._IMSS_ModifiedOn_Label.AutoSize = True
        '
        '
        '
        Me._IMSS_ModifiedOn_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_ModifiedOn_Label.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_ModifiedOn_Label.Location = New System.Drawing.Point(9, 231)
        Me._IMSS_ModifiedOn_Label.Name = "_IMSS_ModifiedOn_Label"
        Me._IMSS_ModifiedOn_Label.Size = New System.Drawing.Size(77, 16)
        Me._IMSS_ModifiedOn_Label.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me._IMSS_ModifiedOn_Label.TabIndex = 16
        Me._IMSS_ModifiedOn_Label.Text = "Modified On :"
        '
        '_IMSS_CreatedOn_Label
        '
        Me._IMSS_CreatedOn_Label.AutoSize = True
        '
        '
        '
        Me._IMSS_CreatedOn_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_CreatedOn_Label.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_CreatedOn_Label.Location = New System.Drawing.Point(9, 199)
        Me._IMSS_CreatedOn_Label.Name = "_IMSS_CreatedOn_Label"
        Me._IMSS_CreatedOn_Label.Size = New System.Drawing.Size(74, 16)
        Me._IMSS_CreatedOn_Label.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me._IMSS_CreatedOn_Label.TabIndex = 15
        Me._IMSS_CreatedOn_Label.Text = "Created On :"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(10, 361)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(192, 4)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        '_IMSS_ViewItem
        '
        Me._IMSS_ViewItem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me._IMSS_ViewItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._IMSS_ViewItem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me._IMSS_ViewItem.Location = New System.Drawing.Point(124, 331)
        Me._IMSS_ViewItem.Name = "_IMSS_ViewItem"
        Me._IMSS_ViewItem.Size = New System.Drawing.Size(75, 23)
        Me._IMSS_ViewItem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_ViewItem.TabIndex = 13
        Me._IMSS_ViewItem.Text = "View Item"
        '
        '_IMSS_PROPERTIS
        '
        Me._IMSS_PROPERTIS.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me._IMSS_PROPERTIS.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._IMSS_PROPERTIS.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me._IMSS_PROPERTIS.Location = New System.Drawing.Point(22, 331)
        Me._IMSS_PROPERTIS.Name = "_IMSS_PROPERTIS"
        Me._IMSS_PROPERTIS.Size = New System.Drawing.Size(75, 23)
        Me._IMSS_PROPERTIS.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_PROPERTIS.TabIndex = 12
        Me._IMSS_PROPERTIS.Text = "Properties "
        '
        '_IMSS_ItemName
        '
        Me._IMSS_ItemName.AutoSize = True
        Me._IMSS_ItemName.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_ItemName.Location = New System.Drawing.Point(6, 168)
        Me._IMSS_ItemName.Name = "_IMSS_ItemName"
        Me._IMSS_ItemName.Size = New System.Drawing.Size(19, 15)
        Me._IMSS_ItemName.TabIndex = 9
        Me._IMSS_ItemName.Text = "..."
        '
        '_IMSS_LOGO_ITEM_TITLE
        '
        Me._IMSS_LOGO_ITEM_TITLE.Location = New System.Drawing.Point(76, 82)
        Me._IMSS_LOGO_ITEM_TITLE.Name = "_IMSS_LOGO_ITEM_TITLE"
        Me._IMSS_LOGO_ITEM_TITLE.Size = New System.Drawing.Size(58, 58)
        Me._IMSS_LOGO_ITEM_TITLE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me._IMSS_LOGO_ITEM_TITLE.TabIndex = 8
        Me._IMSS_LOGO_ITEM_TITLE.TabStop = False
        '
        '_IMSS_DetailsTitle_Label
        '
        '
        '
        '
        Me._IMSS_DetailsTitle_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_DetailsTitle_Label.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_DetailsTitle_Label.Location = New System.Drawing.Point(19, 33)
        Me._IMSS_DetailsTitle_Label.Name = "_IMSS_DetailsTitle_Label"
        Me._IMSS_DetailsTitle_Label.Size = New System.Drawing.Size(163, 43)
        Me._IMSS_DetailsTitle_Label.TabIndex = 5
        Me._IMSS_DetailsTitle_Label.Text = "Details for selected items"
        Me._IMSS_DetailsTitle_Label.WordWrap = True
        '
        '_IMSS_Details_Panel
        '
        Me._IMSS_Details_Panel.CanvasColor = System.Drawing.SystemColors.Control
        Me._IMSS_Details_Panel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_Details_Panel.Dock = System.Windows.Forms.DockStyle.Top
        Me._IMSS_Details_Panel.Location = New System.Drawing.Point(0, 0)
        Me._IMSS_Details_Panel.Name = "_IMSS_Details_Panel"
        Me._IMSS_Details_Panel.Size = New System.Drawing.Size(224, 26)
        Me._IMSS_Details_Panel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me._IMSS_Details_Panel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me._IMSS_Details_Panel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me._IMSS_Details_Panel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me._IMSS_Details_Panel.Style.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_Details_Panel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me._IMSS_Details_Panel.Style.GradientAngle = 90
        Me._IMSS_Details_Panel.TabIndex = 4
        Me._IMSS_Details_Panel.Text = "  Details"
        '
        'IMSS_ResultUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me._IMSS_LitsHoders_Panel)
        Me.Name = "IMSS_ResultUserControl"
        Me.Size = New System.Drawing.Size(824, 414)
        Me.PanelEx1.ResumeLayout(False)
        Me._IMSS_OutPutPanels_Labels.ResumeLayout(False)
        Me._IMSS_OutPutPanels_Labels.PerformLayout()
        Me.PanelEx2.ResumeLayout(False)
        Me.PanelEx2.PerformLayout()
        Me._IMSS_ListHolders_Panel.ResumeLayout(False)
        CType(Me.lvwTemps, System.ComponentModel.ISupportInitialize).EndInit()
        Me._IMSS_LitsHoders_Panel.ResumeLayout(False)
        Me.PanelEx3.ResumeLayout(False)
        Me.PanelEx3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._IMSS_LOGO_ITEM_TITLE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents _IMSS_SizeColumn As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_ElementsColumn As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_CategoryColumn As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents _IMSS_OutPutPanels_Labels As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents _IMSS_ItemToDeleteTotalNumber_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_FullSize_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_TotalItems_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_TotalCleanUpPotential As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_SelectedForCleanUp_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_ListHolders_Panel As DevComponents.DotNetBar.PanelEx
    Friend WithEvents lvwTemps As ComponentOwl.BetterListView.BetterListView
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_LitsHoders_Panel As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelEx3 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents _IMSS_Details_Panel As DevComponents.DotNetBar.PanelEx
    Friend WithEvents _IMSS_TotaleSelectedItemsSizeToDelete_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_DetailsTitle_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_CheckBoxX_CheckAllUnCheckAll As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_ItemName As System.Windows.Forms.Label
    Friend WithEvents _IMSS_LOGO_ITEM_TITLE As System.Windows.Forms.PictureBox
    Friend WithEvents _IMSS_ViewItem As DevComponents.DotNetBar.ButtonX
    Friend WithEvents _IMSS_PROPERTIS As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents _IMSS_LA_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_MO_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_CO_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_LastAccess_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_ModifiedOn_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_CreatedOn_Label As DevComponents.DotNetBar.LabelX

End Class

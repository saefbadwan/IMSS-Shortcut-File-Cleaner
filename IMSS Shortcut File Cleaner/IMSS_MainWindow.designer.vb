<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWindow
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me._IMSS_ProgressScanning = New System.Windows.Forms.ProgressBar()
        Me._IMSS_OutPutPanel = New DevComponents.DotNetBar.PanelEx()
        Me._IMSS_WArning_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_StepIndicator = New DevComponents.DotNetBar.Controls.StepIndicator()
        Me._IMSS_MiniStatus_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_Status_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_MiniTiltle = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_MainStatusTitel = New DevComponents.DotNetBar.LabelX()
        Me.Bar2 = New DevComponents.DotNetBar.Bar()
        Me.DotNetBarManager1 = New DevComponents.DotNetBar.DotNetBarManager(Me.components)
        Me.DockSite4 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite1 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite2 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite8 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite5 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite6 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite7 = New DevComponents.DotNetBar.DockSite()
        Me._IMSS_ToolsBar = New DevComponents.DotNetBar.Bar()
        Me.DockSite3 = New DevComponents.DotNetBar.DockSite()
        Me._IMSS_MainPanel = New DevComponents.DotNetBar.PanelEx()
        Me._IMSS_BalloonTip = New DevComponents.DotNetBar.BalloonTip()
        Me._IMSS_SELECT_FOLDER = New System.Windows.Forms.FolderBrowserDialog()
        Me._IMSS_Warning_Icon = New System.Windows.Forms.PictureBox()
        Me._IMSS_InfoPictureBox_Image = New System.Windows.Forms.PictureBox()
        Me._IMSS_LoadingGifImage = New System.Windows.Forms.PictureBox()
        Me._IMSS_Logo = New System.Windows.Forms.PictureBox()
        Me._IMSS_CleanFile_Button = New DevComponents.DotNetBar.ButtonItem()
        Me._IMSS_CancelButton = New DevComponents.DotNetBar.ButtonItem()
        Me._IMSS_Close_Button = New DevComponents.DotNetBar.ButtonItem()
        Me._IMSS_SCAN_SELECTED_TARGETS = New DevComponents.DotNetBar.ButtonItem()
        Me._IMSS_OutPutPanel.SuspendLayout()
        CType(Me.Bar2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockSite7.SuspendLayout()
        CType(Me._IMSS_ToolsBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._IMSS_MainPanel.SuspendLayout()
        CType(Me._IMSS_Warning_Icon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._IMSS_InfoPictureBox_Image, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._IMSS_LoadingGifImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._IMSS_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_IMSS_ProgressScanning
        '
        Me._IMSS_ProgressScanning.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._IMSS_ProgressScanning.Location = New System.Drawing.Point(164, 95)
        Me._IMSS_ProgressScanning.MarqueeAnimationSpeed = 5
        Me._IMSS_ProgressScanning.Name = "_IMSS_ProgressScanning"
        Me._IMSS_ProgressScanning.Size = New System.Drawing.Size(615, 19)
        Me._IMSS_ProgressScanning.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me._IMSS_ProgressScanning.TabIndex = 2
        '
        '_IMSS_OutPutPanel
        '
        Me._IMSS_OutPutPanel.CanvasColor = System.Drawing.SystemColors.Control
        Me._IMSS_OutPutPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_OutPutPanel.Controls.Add(Me._IMSS_Warning_Icon)
        Me._IMSS_OutPutPanel.Controls.Add(Me._IMSS_WArning_Label)
        Me._IMSS_OutPutPanel.Controls.Add(Me._IMSS_StepIndicator)
        Me._IMSS_OutPutPanel.Controls.Add(Me._IMSS_InfoPictureBox_Image)
        Me._IMSS_OutPutPanel.Controls.Add(Me._IMSS_MiniStatus_Label)
        Me._IMSS_OutPutPanel.Controls.Add(Me._IMSS_LoadingGifImage)
        Me._IMSS_OutPutPanel.Controls.Add(Me._IMSS_Status_Label)
        Me._IMSS_OutPutPanel.Controls.Add(Me._IMSS_MiniTiltle)
        Me._IMSS_OutPutPanel.Controls.Add(Me._IMSS_Logo)
        Me._IMSS_OutPutPanel.Controls.Add(Me._IMSS_MainStatusTitel)
        Me._IMSS_OutPutPanel.Controls.Add(Me._IMSS_ProgressScanning)
        Me._IMSS_OutPutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me._IMSS_OutPutPanel.Location = New System.Drawing.Point(0, 0)
        Me._IMSS_OutPutPanel.Name = "_IMSS_OutPutPanel"
        Me._IMSS_OutPutPanel.Size = New System.Drawing.Size(820, 414)
        Me._IMSS_OutPutPanel.Style.Alignment = System.Drawing.StringAlignment.Center
        Me._IMSS_OutPutPanel.Style.BackColor1.Alpha = CType(225, Byte)
        Me._IMSS_OutPutPanel.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(254, Byte), Integer))
        Me._IMSS_OutPutPanel.Style.BackColor2.Color = System.Drawing.Color.White
        Me._IMSS_OutPutPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me._IMSS_OutPutPanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me._IMSS_OutPutPanel.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.None
        Me._IMSS_OutPutPanel.Style.BorderWidth = 0
        Me._IMSS_OutPutPanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me._IMSS_OutPutPanel.Style.GradientAngle = 90
        Me._IMSS_OutPutPanel.TabIndex = 3
        '
        '_IMSS_WArning_Label
        '
        Me._IMSS_WArning_Label.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._IMSS_WArning_Label.AutoSize = True
        '
        '
        '
        Me._IMSS_WArning_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_WArning_Label.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_WArning_Label.Location = New System.Drawing.Point(431, 394)
        Me._IMSS_WArning_Label.Name = "_IMSS_WArning_Label"
        Me._IMSS_WArning_Label.Size = New System.Drawing.Size(384, 16)
        Me._IMSS_WArning_Label.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me._IMSS_WArning_Label.TabIndex = 41
        Me._IMSS_WArning_Label.Text = "During the scanning the computer may stop responding temporarily."
        '
        '_IMSS_StepIndicator
        '
        Me._IMSS_StepIndicator.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._IMSS_StepIndicator.CurrentStep = 0
        Me._IMSS_StepIndicator.Location = New System.Drawing.Point(164, 120)
        Me._IMSS_StepIndicator.Name = "_IMSS_StepIndicator"
        Me._IMSS_StepIndicator.Size = New System.Drawing.Size(615, 4)
        Me._IMSS_StepIndicator.TabIndex = 40
        '
        '_IMSS_MiniStatus_Label
        '
        Me._IMSS_MiniStatus_Label.AutoSize = True
        '
        '
        '
        Me._IMSS_MiniStatus_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_MiniStatus_Label.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_MiniStatus_Label.Location = New System.Drawing.Point(164, 132)
        Me._IMSS_MiniStatus_Label.Name = "_IMSS_MiniStatus_Label"
        Me._IMSS_MiniStatus_Label.Size = New System.Drawing.Size(0, 0)
        Me._IMSS_MiniStatus_Label.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me._IMSS_MiniStatus_Label.TabIndex = 9
        '
        '_IMSS_Status_Label
        '
        Me._IMSS_Status_Label.AutoSize = True
        '
        '
        '
        Me._IMSS_Status_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_Status_Label.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_Status_Label.Location = New System.Drawing.Point(164, 74)
        Me._IMSS_Status_Label.Name = "_IMSS_Status_Label"
        Me._IMSS_Status_Label.Size = New System.Drawing.Size(113, 16)
        Me._IMSS_Status_Label.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me._IMSS_Status_Label.TabIndex = 7
        Me._IMSS_Status_Label.Text = "Checking category :"
        '
        '_IMSS_MiniTiltle
        '
        '
        '
        '
        Me._IMSS_MiniTiltle.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_MiniTiltle.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_MiniTiltle.ForeColor = System.Drawing.Color.Black
        Me._IMSS_MiniTiltle.Location = New System.Drawing.Point(164, 42)
        Me._IMSS_MiniTiltle.Name = "_IMSS_MiniTiltle"
        Me._IMSS_MiniTiltle.Size = New System.Drawing.Size(358, 23)
        Me._IMSS_MiniTiltle.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me._IMSS_MiniTiltle.TabIndex = 6
        Me._IMSS_MiniTiltle.Text = "Please wait while searching your computer for broken sortcuts."
        '
        '_IMSS_MainStatusTitel
        '
        '
        '
        '
        Me._IMSS_MainStatusTitel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_MainStatusTitel.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_MainStatusTitel.Location = New System.Drawing.Point(164, 12)
        Me._IMSS_MainStatusTitel.Name = "_IMSS_MainStatusTitel"
        Me._IMSS_MainStatusTitel.Size = New System.Drawing.Size(457, 23)
        Me._IMSS_MainStatusTitel.TabIndex = 4
        Me._IMSS_MainStatusTitel.Text = "Searching for broken shortcut in shortcut and recent list"
        '
        'Bar2
        '
        Me.Bar2.AccessibleDescription = "DotNetBar Bar (Bar2)"
        Me.Bar2.AccessibleName = "DotNetBar Bar"
        Me.Bar2.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar
        Me.Bar2.AntiAlias = True
        Me.Bar2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Bar2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Bar2.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.ResizeHandle
        Me.Bar2.Location = New System.Drawing.Point(0, 448)
        Me.Bar2.Name = "Bar2"
        Me.Bar2.Size = New System.Drawing.Size(820, 25)
        Me.Bar2.Stretch = True
        Me.Bar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bar2.TabIndex = 12
        Me.Bar2.TabStop = False
        Me.Bar2.Text = "Bar2"
        '
        'DotNetBarManager1
        '
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.F1)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlC)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlA)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlV)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlX)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlZ)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlY)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.Del)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.Ins)
        Me.DotNetBarManager1.BottomDockSite = Me.DockSite4
        Me.DotNetBarManager1.EnableFullSizeDock = False
        Me.DotNetBarManager1.LeftDockSite = Me.DockSite1
        Me.DotNetBarManager1.ParentForm = Me
        Me.DotNetBarManager1.RightDockSite = Me.DockSite2
        Me.DotNetBarManager1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.DotNetBarManager1.ToolbarBottomDockSite = Me.DockSite8
        Me.DotNetBarManager1.ToolbarLeftDockSite = Me.DockSite5
        Me.DotNetBarManager1.ToolbarRightDockSite = Me.DockSite6
        Me.DotNetBarManager1.ToolbarTopDockSite = Me.DockSite7
        Me.DotNetBarManager1.TopDockSite = Me.DockSite3
        '
        'DockSite4
        '
        Me.DockSite4.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DockSite4.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.DockSite4.Location = New System.Drawing.Point(0, 473)
        Me.DockSite4.Name = "DockSite4"
        Me.DockSite4.Size = New System.Drawing.Size(820, 0)
        Me.DockSite4.TabIndex = 16
        Me.DockSite4.TabStop = False
        '
        'DockSite1
        '
        Me.DockSite1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite1.Dock = System.Windows.Forms.DockStyle.Left
        Me.DockSite1.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.DockSite1.Location = New System.Drawing.Point(0, 34)
        Me.DockSite1.Name = "DockSite1"
        Me.DockSite1.Size = New System.Drawing.Size(0, 414)
        Me.DockSite1.TabIndex = 13
        Me.DockSite1.TabStop = False
        '
        'DockSite2
        '
        Me.DockSite2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite2.Dock = System.Windows.Forms.DockStyle.Right
        Me.DockSite2.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.DockSite2.Location = New System.Drawing.Point(820, 34)
        Me.DockSite2.Name = "DockSite2"
        Me.DockSite2.Size = New System.Drawing.Size(0, 414)
        Me.DockSite2.TabIndex = 14
        Me.DockSite2.TabStop = False
        '
        'DockSite8
        '
        Me.DockSite8.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DockSite8.Location = New System.Drawing.Point(0, 473)
        Me.DockSite8.Name = "DockSite8"
        Me.DockSite8.Size = New System.Drawing.Size(820, 0)
        Me.DockSite8.TabIndex = 20
        Me.DockSite8.TabStop = False
        '
        'DockSite5
        '
        Me.DockSite5.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite5.Dock = System.Windows.Forms.DockStyle.Left
        Me.DockSite5.Location = New System.Drawing.Point(0, 34)
        Me.DockSite5.Name = "DockSite5"
        Me.DockSite5.Size = New System.Drawing.Size(0, 439)
        Me.DockSite5.TabIndex = 17
        Me.DockSite5.TabStop = False
        '
        'DockSite6
        '
        Me.DockSite6.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite6.Dock = System.Windows.Forms.DockStyle.Right
        Me.DockSite6.Location = New System.Drawing.Point(820, 34)
        Me.DockSite6.Name = "DockSite6"
        Me.DockSite6.Size = New System.Drawing.Size(0, 439)
        Me.DockSite6.TabIndex = 18
        Me.DockSite6.TabStop = False
        '
        'DockSite7
        '
        Me.DockSite7.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite7.Controls.Add(Me._IMSS_ToolsBar)
        Me.DockSite7.Dock = System.Windows.Forms.DockStyle.Top
        Me.DockSite7.Location = New System.Drawing.Point(0, 0)
        Me.DockSite7.Name = "DockSite7"
        Me.DockSite7.Size = New System.Drawing.Size(820, 34)
        Me.DockSite7.TabIndex = 19
        Me.DockSite7.TabStop = False
        '
        '_IMSS_ToolsBar
        '
        Me._IMSS_ToolsBar.AccessibleDescription = "DotNetBar Bar (_IMSS_ToolsBar)"
        Me._IMSS_ToolsBar.AccessibleName = "DotNetBar Bar"
        Me._IMSS_ToolsBar.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me._IMSS_ToolsBar.Dock = System.Windows.Forms.DockStyle.Top
        Me._IMSS_ToolsBar.DockSide = DevComponents.DotNetBar.eDockSide.Top
        Me._IMSS_ToolsBar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me._IMSS_ToolsBar.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Office2003
        Me._IMSS_ToolsBar.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me._IMSS_CleanFile_Button, Me._IMSS_CancelButton, Me._IMSS_Close_Button, Me._IMSS_SCAN_SELECTED_TARGETS})
        Me._IMSS_ToolsBar.Location = New System.Drawing.Point(0, 0)
        Me._IMSS_ToolsBar.Name = "_IMSS_ToolsBar"
        Me._IMSS_ToolsBar.Size = New System.Drawing.Size(820, 33)
        Me._IMSS_ToolsBar.Stretch = True
        Me._IMSS_ToolsBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me._IMSS_ToolsBar.TabIndex = 1
        Me._IMSS_ToolsBar.TabStop = False
        Me._IMSS_ToolsBar.Text = "Tools Bar"
        '
        'DockSite3
        '
        Me.DockSite3.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite3.Dock = System.Windows.Forms.DockStyle.Top
        Me.DockSite3.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.DockSite3.Location = New System.Drawing.Point(0, 34)
        Me.DockSite3.Name = "DockSite3"
        Me.DockSite3.Size = New System.Drawing.Size(820, 0)
        Me.DockSite3.TabIndex = 15
        Me.DockSite3.TabStop = False
        '
        '_IMSS_MainPanel
        '
        Me._IMSS_MainPanel.CanvasColor = System.Drawing.SystemColors.Control
        Me._IMSS_MainPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_OutPutPanel)
        Me._IMSS_MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me._IMSS_MainPanel.Location = New System.Drawing.Point(0, 34)
        Me._IMSS_MainPanel.Name = "_IMSS_MainPanel"
        Me._IMSS_MainPanel.Size = New System.Drawing.Size(820, 414)
        Me._IMSS_MainPanel.Style.Alignment = System.Drawing.StringAlignment.Center
        Me._IMSS_MainPanel.Style.BackColor1.Color = System.Drawing.Color.White
        Me._IMSS_MainPanel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me._IMSS_MainPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me._IMSS_MainPanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me._IMSS_MainPanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me._IMSS_MainPanel.Style.GradientAngle = 90
        Me._IMSS_MainPanel.TabIndex = 21
        '
        '_IMSS_BalloonTip
        '
        Me._IMSS_BalloonTip.AutoCloseTimeOut = 40
        Me._IMSS_BalloonTip.CaptionIcon = CType(resources.GetObject("_IMSS_BalloonTip.CaptionIcon"), System.Drawing.Icon)
        Me._IMSS_BalloonTip.Style = DevComponents.DotNetBar.eBallonStyle.Office2007Alert
        '
        '_IMSS_SELECT_FOLDER
        '
        Me._IMSS_SELECT_FOLDER.Description = "Select path to scan it for broken shortcuts"
        '
        '_IMSS_Warning_Icon
        '
        Me._IMSS_Warning_Icon.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._IMSS_Warning_Icon.Image = Global.IMSS_Shortcut_File_Cleaner.My.Resources.Resources._IMSS_ProcessingWarning_Icon_16x16
        Me._IMSS_Warning_Icon.InitialImage = Nothing
        Me._IMSS_Warning_Icon.Location = New System.Drawing.Point(409, 394)
        Me._IMSS_Warning_Icon.Name = "_IMSS_Warning_Icon"
        Me._IMSS_Warning_Icon.Size = New System.Drawing.Size(16, 16)
        Me._IMSS_Warning_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me._IMSS_Warning_Icon.TabIndex = 42
        Me._IMSS_Warning_Icon.TabStop = False
        '
        '_IMSS_InfoPictureBox_Image
        '
        Me._IMSS_InfoPictureBox_Image.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._IMSS_BalloonTip.SetBalloonCaption(Me._IMSS_InfoPictureBox_Image, "Information")
        Me._IMSS_BalloonTip.SetBalloonText(Me._IMSS_InfoPictureBox_Image, resources.GetString("_IMSS_InfoPictureBox_Image.BalloonText"))
        Me._IMSS_InfoPictureBox_Image.Image = Global.IMSS_Shortcut_File_Cleaner.My.Resources.Resources._IMSS_Info_Icon_16x16
        Me._IMSS_InfoPictureBox_Image.Location = New System.Drawing.Point(797, 3)
        Me._IMSS_InfoPictureBox_Image.Name = "_IMSS_InfoPictureBox_Image"
        Me._IMSS_InfoPictureBox_Image.Size = New System.Drawing.Size(16, 16)
        Me._IMSS_InfoPictureBox_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me._IMSS_InfoPictureBox_Image.TabIndex = 10
        Me._IMSS_InfoPictureBox_Image.TabStop = False
        '
        '_IMSS_LoadingGifImage
        '
        Me._IMSS_LoadingGifImage.Image = CType(resources.GetObject("_IMSS_LoadingGifImage.Image"), System.Drawing.Image)
        Me._IMSS_LoadingGifImage.InitialImage = Nothing
        Me._IMSS_LoadingGifImage.Location = New System.Drawing.Point(142, 74)
        Me._IMSS_LoadingGifImage.Name = "_IMSS_LoadingGifImage"
        Me._IMSS_LoadingGifImage.Size = New System.Drawing.Size(16, 16)
        Me._IMSS_LoadingGifImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me._IMSS_LoadingGifImage.TabIndex = 8
        Me._IMSS_LoadingGifImage.TabStop = False
        '
        '_IMSS_Logo
        '
        Me._IMSS_Logo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me._IMSS_Logo.Image = Global.IMSS_Shortcut_File_Cleaner.My.Resources.Resources._IMSS_ShortcutsSearchs_Full_Icon_96x96
        Me._IMSS_Logo.Location = New System.Drawing.Point(12, 312)
        Me._IMSS_Logo.Name = "_IMSS_Logo"
        Me._IMSS_Logo.Size = New System.Drawing.Size(96, 96)
        Me._IMSS_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me._IMSS_Logo.TabIndex = 5
        Me._IMSS_Logo.TabStop = False
        '
        '_IMSS_CleanFile_Button
        '
        Me._IMSS_CleanFile_Button.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me._IMSS_CleanFile_Button.Enabled = False
        Me._IMSS_CleanFile_Button.Image = Global.IMSS_Shortcut_File_Cleaner.My.Resources.Resources._IMSS_Clean_Icon_24x24
        Me._IMSS_CleanFile_Button.Name = "_IMSS_CleanFile_Button"
        Me._IMSS_CleanFile_Button.Text = "Cleanup all selected items"
        Me._IMSS_CleanFile_Button.Visible = False
        '
        '_IMSS_CancelButton
        '
        Me._IMSS_CancelButton.BeginGroup = True
        Me._IMSS_CancelButton.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me._IMSS_CancelButton.Image = Global.IMSS_Shortcut_File_Cleaner.My.Resources.Resources._IMSS_StopAnalysis_Icon_24x24
        Me._IMSS_CancelButton.Name = "_IMSS_CancelButton"
        Me._IMSS_CancelButton.Text = "Stop Analysis"
        '
        '_IMSS_Close_Button
        '
        Me._IMSS_Close_Button.BeginGroup = True
        Me._IMSS_Close_Button.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me._IMSS_Close_Button.Enabled = False
        Me._IMSS_Close_Button.Image = Global.IMSS_Shortcut_File_Cleaner.My.Resources.Resources._IMSS_ShutdownManager_Cancel_OuterGlow_Icon_24x24
        Me._IMSS_Close_Button.Name = "_IMSS_Close_Button"
        Me._IMSS_Close_Button.Text = "Close"
        Me._IMSS_Close_Button.Visible = False
        '
        '_IMSS_SCAN_SELECTED_TARGETS
        '
        Me._IMSS_SCAN_SELECTED_TARGETS.BeginGroup = True
        Me._IMSS_SCAN_SELECTED_TARGETS.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me._IMSS_SCAN_SELECTED_TARGETS.Image = Global.IMSS_Shortcut_File_Cleaner.My.Resources.Resources._IMSS_SCAN_SELECTED_Icon_24x24
        Me._IMSS_SCAN_SELECTED_TARGETS.Name = "_IMSS_SCAN_SELECTED_TARGETS"
        Me._IMSS_SCAN_SELECTED_TARGETS.Text = "Scan specified path for broken shortcuts"
        Me._IMSS_SCAN_SELECTED_TARGETS.Visible = False
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(820, 473)
        Me.Controls.Add(Me._IMSS_MainPanel)
        Me.Controls.Add(Me.DockSite2)
        Me.Controls.Add(Me.DockSite1)
        Me.Controls.Add(Me.Bar2)
        Me.Controls.Add(Me.DockSite3)
        Me.Controls.Add(Me.DockSite4)
        Me.Controls.Add(Me.DockSite5)
        Me.Controls.Add(Me.DockSite6)
        Me.Controls.Add(Me.DockSite7)
        Me.Controls.Add(Me.DockSite8)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(836, 511)
        Me.Name = "MainWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IMSS Broken Shortcuts Remover"
        Me._IMSS_OutPutPanel.ResumeLayout(False)
        Me._IMSS_OutPutPanel.PerformLayout()
        CType(Me.Bar2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockSite7.ResumeLayout(False)
        CType(Me._IMSS_ToolsBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me._IMSS_MainPanel.ResumeLayout(False)
        CType(Me._IMSS_Warning_Icon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._IMSS_InfoPictureBox_Image, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._IMSS_LoadingGifImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._IMSS_Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents _IMSS_ProgressScanning As System.Windows.Forms.ProgressBar
    Friend WithEvents _IMSS_OutPutPanel As DevComponents.DotNetBar.PanelEx
    Friend WithEvents _IMSS_Logo As System.Windows.Forms.PictureBox
    Friend WithEvents _IMSS_MainStatusTitel As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_Status_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_MiniTiltle As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_MiniStatus_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents Bar2 As DevComponents.DotNetBar.Bar
    Friend WithEvents DotNetBarManager1 As DevComponents.DotNetBar.DotNetBarManager
    Friend WithEvents DockSite4 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite1 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite2 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite3 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite5 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite6 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite7 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite8 As DevComponents.DotNetBar.DockSite
    Friend WithEvents _IMSS_ToolsBar As DevComponents.DotNetBar.Bar
    Friend WithEvents _IMSS_CleanFile_Button As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents _IMSS_MainPanel As DevComponents.DotNetBar.PanelEx
    Friend WithEvents _IMSS_InfoPictureBox_Image As System.Windows.Forms.PictureBox
    Friend WithEvents _IMSS_LoadingGifImage As System.Windows.Forms.PictureBox
    Friend WithEvents _IMSS_CancelButton As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents _IMSS_StepIndicator As DevComponents.DotNetBar.Controls.StepIndicator
    Friend WithEvents _IMSS_BalloonTip As DevComponents.DotNetBar.BalloonTip
    Friend WithEvents _IMSS_Warning_Icon As System.Windows.Forms.PictureBox
    Friend WithEvents _IMSS_WArning_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_Close_Button As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents _IMSS_SCAN_SELECTED_TARGETS As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents _IMSS_SELECT_FOLDER As System.Windows.Forms.FolderBrowserDialog

End Class

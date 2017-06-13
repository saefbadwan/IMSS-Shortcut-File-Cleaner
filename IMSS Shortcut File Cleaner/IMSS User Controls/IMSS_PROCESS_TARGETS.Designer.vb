<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IMSS_PROCESS_TARGETS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IMSS_PROCESS_TARGETS))
        Me._IMSS_OutPutPanel = New DevComponents.DotNetBar.PanelEx()
        Me._IMSS_Warning_Icon = New System.Windows.Forms.PictureBox()
        Me._IMSS_WArning_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_StepIndicator = New DevComponents.DotNetBar.Controls.StepIndicator()
        Me._IMSS_InfoPictureBox_Image = New System.Windows.Forms.PictureBox()
        Me._IMSS_MiniStatus_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_LoadingGifImage = New System.Windows.Forms.PictureBox()
        Me._IMSS_Status_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_MiniTiltle = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_Logo = New System.Windows.Forms.PictureBox()
        Me._IMSS_MainStatusTitel = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_ProgressScanning = New System.Windows.Forms.ProgressBar()
        Me._IMSS_OutPutPanel.SuspendLayout()
        CType(Me._IMSS_Warning_Icon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._IMSS_InfoPictureBox_Image, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._IMSS_LoadingGifImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._IMSS_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me._IMSS_OutPutPanel.Size = New System.Drawing.Size(824, 414)
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
        Me._IMSS_OutPutPanel.TabIndex = 4
        '
        '_IMSS_Warning_Icon
        '
        Me._IMSS_Warning_Icon.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._IMSS_Warning_Icon.Image = Global.IMSS_Shortcut_File_Cleaner.My.Resources.Resources._IMSS_ProcessingWarning_Icon_16x16
        Me._IMSS_Warning_Icon.InitialImage = Nothing
        Me._IMSS_Warning_Icon.Location = New System.Drawing.Point(413, 394)
        Me._IMSS_Warning_Icon.Name = "_IMSS_Warning_Icon"
        Me._IMSS_Warning_Icon.Size = New System.Drawing.Size(16, 16)
        Me._IMSS_Warning_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me._IMSS_Warning_Icon.TabIndex = 42
        Me._IMSS_Warning_Icon.TabStop = False
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
        Me._IMSS_WArning_Label.Location = New System.Drawing.Point(435, 394)
        Me._IMSS_WArning_Label.Name = "_IMSS_WArning_Label"
        Me._IMSS_WArning_Label.Size = New System.Drawing.Size(379, 16)
        Me._IMSS_WArning_Label.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me._IMSS_WArning_Label.TabIndex = 41
        Me._IMSS_WArning_Label.Text = "During the deletion the computer may stop responding temporarily."
        '
        '_IMSS_StepIndicator
        '
        Me._IMSS_StepIndicator.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._IMSS_StepIndicator.CurrentStep = 0
        Me._IMSS_StepIndicator.Location = New System.Drawing.Point(164, 120)
        Me._IMSS_StepIndicator.Name = "_IMSS_StepIndicator"
        Me._IMSS_StepIndicator.Size = New System.Drawing.Size(619, 4)
        Me._IMSS_StepIndicator.TabIndex = 40
        '
        '_IMSS_InfoPictureBox_Image
        '
        Me._IMSS_InfoPictureBox_Image.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._IMSS_InfoPictureBox_Image.Image = Global.IMSS_Shortcut_File_Cleaner.My.Resources.Resources._IMSS_Info_Icon_16x16
        Me._IMSS_InfoPictureBox_Image.Location = New System.Drawing.Point(801, 3)
        Me._IMSS_InfoPictureBox_Image.Name = "_IMSS_InfoPictureBox_Image"
        Me._IMSS_InfoPictureBox_Image.Size = New System.Drawing.Size(16, 16)
        Me._IMSS_InfoPictureBox_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me._IMSS_InfoPictureBox_Image.TabIndex = 10
        Me._IMSS_InfoPictureBox_Image.TabStop = False
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
        Me._IMSS_Status_Label.Size = New System.Drawing.Size(15, 16)
        Me._IMSS_Status_Label.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me._IMSS_Status_Label.TabIndex = 7
        Me._IMSS_Status_Label.Text = "..."
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
        Me._IMSS_MiniTiltle.Size = New System.Drawing.Size(318, 23)
        Me._IMSS_MiniTiltle.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me._IMSS_MiniTiltle.TabIndex = 6
        Me._IMSS_MiniTiltle.Text = "Please wait while deleting founded broken sortcuts files."
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
        '_IMSS_MainStatusTitel
        '
        '
        '
        '
        Me._IMSS_MainStatusTitel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_MainStatusTitel.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_MainStatusTitel.Location = New System.Drawing.Point(164, 12)
        Me._IMSS_MainStatusTitel.Name = "_IMSS_MainStatusTitel"
        Me._IMSS_MainStatusTitel.Size = New System.Drawing.Size(183, 23)
        Me._IMSS_MainStatusTitel.TabIndex = 4
        Me._IMSS_MainStatusTitel.Text = "Deleting broken shortcuts"
        '
        '_IMSS_ProgressScanning
        '
        Me._IMSS_ProgressScanning.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._IMSS_ProgressScanning.Location = New System.Drawing.Point(164, 95)
        Me._IMSS_ProgressScanning.MarqueeAnimationSpeed = 5
        Me._IMSS_ProgressScanning.Name = "_IMSS_ProgressScanning"
        Me._IMSS_ProgressScanning.Size = New System.Drawing.Size(619, 19)
        Me._IMSS_ProgressScanning.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me._IMSS_ProgressScanning.TabIndex = 2
        '
        'IMSS_PROCESS_TARGETS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me._IMSS_OutPutPanel)
        Me.Name = "IMSS_PROCESS_TARGETS"
        Me.Size = New System.Drawing.Size(824, 414)
        Me._IMSS_OutPutPanel.ResumeLayout(False)
        Me._IMSS_OutPutPanel.PerformLayout()
        CType(Me._IMSS_Warning_Icon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._IMSS_InfoPictureBox_Image, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._IMSS_LoadingGifImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._IMSS_Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents _IMSS_OutPutPanel As DevComponents.DotNetBar.PanelEx
    Friend WithEvents _IMSS_Warning_Icon As System.Windows.Forms.PictureBox
    Friend WithEvents _IMSS_WArning_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_StepIndicator As DevComponents.DotNetBar.Controls.StepIndicator
    Friend WithEvents _IMSS_InfoPictureBox_Image As System.Windows.Forms.PictureBox
    Friend WithEvents _IMSS_MiniStatus_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_LoadingGifImage As System.Windows.Forms.PictureBox
    Friend WithEvents _IMSS_Status_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_MiniTiltle As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_Logo As System.Windows.Forms.PictureBox
    Friend WithEvents _IMSS_MainStatusTitel As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_ProgressScanning As System.Windows.Forms.ProgressBar

End Class

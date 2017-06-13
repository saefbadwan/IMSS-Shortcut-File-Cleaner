' بسم الله الرحمن الرحيم
Imports System.Runtime.InteropServices
Imports System.IO

Public Class IMSS_ResultUserControl
#Region "IMSS File Properties Show Dialog Var"
    <DllImport("Shell32", CharSet:=CharSet.Auto, SetLastError:=True)> _
    Public Shared Function ShellExecuteEx(ByRef lpExecInfo As SHELLEXECUTEINFO) As Boolean
    End Function
    Private Const SEE_MASK_INVOKEIDLIST = &HC
    Private Const SEE_MASK_NOCLOSEPROCESS = &H40
    Private Const SEE_MASK_FLAG_NO_UI = &H400
    Public Const SW_SHOW As Short = 5
    Public Structure SHELLEXECUTEINFO
        Public cbSize As Integer
        Public fMask As Integer
        Public hwnd As IntPtr
        <MarshalAs(UnmanagedType.LPTStr)> Public lpVerb As String
        <MarshalAs(UnmanagedType.LPTStr)> Public lpFile As String
        <MarshalAs(UnmanagedType.LPTStr)> Public lpParameters As String
        <MarshalAs(UnmanagedType.LPTStr)> Public lpDirectory As String
        Dim nShow As Integer
        Dim hInstApp As IntPtr
        Dim lpIDList As IntPtr
        <MarshalAs(UnmanagedType.LPTStr)> Public lpClass As String
        Public hkeyClass As IntPtr
        Public dwHotKey As Integer
        Public hIcon As IntPtr
        Public hProcess As IntPtr
    End Structure
#End Region

    '    Private Sub lvwTemps_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvwTemps.SelectedIndexChanged
    '        For Each _IMSS_SelectedItem In lvwTemps.Items
    '            If _IMSS_SelectedItem.Selected = True Then
    '                _IMSS_DetailsTotalSelectedItemSize.Text = _IMSS_SelectedItem.SubItems(1).Text.ToString() & " items"
    '                _IMSS_TotalSelectedItemFile.Text = _IMSS_SelectedItem.SubItems(2).Text.ToString()
    '                _IMSS_DetailsTitle_Label.Text = _IMSS_SelectedItem.Text
    '                _IMSS_SET_TITLELABELS(_IMSS_SelectedItem.Text)
    '            End If
    '        Next
    '    End Sub

    '    Private Sub _IMSS_SET_TITLELABELS(ByVal _IMSS_ITEMSSELECTEDTEXTSTRING As String)
    '        On Error Resume Next
    '        Select Case True
    '            Case _IMSS_ITEMSSELECTEDTEXTSTRING.Contains("Windows Updates Backup")
    '                MainWindow._IMSS_ShowItems.Enabled = False
    '            Case _IMSS_ITEMSSELECTEDTEXTSTRING.Contains("VS 20")
    '                MainWindow._IMSS_ShowItems.Enabled = False
    '            Case Else
    '                MainWindow._IMSS_ShowItems.Enabled = True
    '        End Select

    '        Select Case _IMSS_ITEMSSELECTEDTEXTSTRING
    '            Case "Recent Documents"
    '                _IMSS_DetailsOutPutPrograms_Label.Text = My.Resources._IMSS_WindowsExplorInfo
    '            Case "Thumbnail Cache"
    '                _IMSS_DetailsOutPutPrograms_Label.Text = My.Resources._IMSS_WindowsExplorInfo
    '            Case "Windows Updates Backup"
    '                _IMSS_DetailsOutPutPrograms_Label.Text = My.Resources._IMSS_WindowsUpdatesBackupInfo
    '            Case "Windows Temp Files"
    '                _IMSS_SET_SystemInfo()
    '            Case "User Temp Files"
    '                _IMSS_SET_SystemInfo()
    '            Case "Memory Dumps"
    '                _IMSS_SET_SystemInfo()
    '            Case "ChkDsk File Fragments"
    '                _IMSS_SET_SystemInfo()
    '            Case "Windows Log Files"
    '                _IMSS_SET_SystemInfo()
    '            Case "Windows Error Reporting"
    '                _IMSS_SET_SystemInfo()
    '            Case "Image Preview Folder Window"
    '                _IMSS_SET_SystemInfo()
    '            Case "Advanced Prefetch Data"
    '                _IMSS_DetailsOutPutPrograms_Label.Text = My.Resources._IMSS_AdvancedInfo
    '            Case "IIS Logs"
    '                _IMSS_DetailsOutPutPrograms_Label.Text = My.Resources._IMSS_AdvancedInfo
    '            Case "IIS Logs Files ETL"
    '                _IMSS_DetailsOutPutPrograms_Label.Text = My.Resources._IMSS_AdvancedInfo
    '            Case "uTorrent Image Cache"
    '                _IMSS_DetailsOutPutPrograms_Label.Text = My.Resources._IMSS_uTorrentInfo
    '            Case "uTorrent Temp Files"
    '                _IMSS_DetailsOutPutPrograms_Label.Text = My.Resources._IMSS_uTorrentInfo
    '            Case "Sun Java Cache"
    '                _IMSS_DetailsOutPutPrograms_Label.Text = My.Resources._IMSS_SunJava
    '            Case "Sun Java System Cache"
    '                _IMSS_DetailsOutPutPrograms_Label.Text = My.Resources._IMSS_SunJava
    '            Case "FileZilla Recent Servers"
    '                _IMSS_DetailsOutPutPrograms_Label.Text = My.Resources._IMSS_FileZillaInfo
    '            Case "Paint.NET Temp Files"
    '                _IMSS_DetailsOutPutPrograms_Label.Text = My.Resources._IMSS_PaintNETInfo
    '            Case "Media Player Temp Files"
    '                _IMSS_DetailsOutPutPrograms_Label.Text = My.Resources._IMSS_WindowsMediaPlayer
    '            Case "Cache"
    '                _IMSS_DetailsOutPutPrograms_Label.Text = My.Resources._IMSS_QuickTimePlayer
    '            Case "Player Session"
    '                _IMSS_DetailsOutPutPrograms_Label.Text = My.Resources._IMSS_QuickTimePlayer
    '            Case "Adobe Temp Files"
    '                _IMSS_DetailsOutPutPrograms_Label.Text = My.Resources._IMSS_AdobeFlashPlayer
    '            Case "Log Files"
    '                _IMSS_DetailsOutPutPrograms_Label.Text = My.Resources._IMSS_AVGAntivirus
    '            Case "Log Files XML"
    '                _IMSS_DetailsOutPutPrograms_Label.Text = My.Resources._IMSS_AVGAntivirus
    '            Case "AVG Backup Files"
    '                _IMSS_DetailsOutPutPrograms_Label.Text = My.Resources._IMSS_AVGAntivirus
    '            Case "Misc Files"
    '                _IMSS_DetailsOutPutPrograms_Label.Text = My.Resources._IMSS_AVGAntivirus
    '            Case "AVGTemp Files"
    '                _IMSS_DetailsOutPutPrograms_Label.Text = My.Resources._IMSS_AVGAntivirus
    '            Case "Logs"
    '                _IMSS_DetailsOutPutPrograms_Label.Text = My.Resources._IMSS_MalwareBytes
    '            Case "Quarantine Files"
    '                _IMSS_DetailsOutPutPrograms_Label.Text = My.Resources._IMSS_MalwareBytes
    '            Case "Backup Files"
    '                _IMSS_DetailsOutPutPrograms_Label.Text = My.Resources._IMSS_MalwareBytes
    '            Case "History Resource"
    '                _IMSS_DetailsOutPutPrograms_Label.Text = My.Resources._IMSS_WindowsDefender
    '            Case "Quick Historys"
    '                _IMSS_DetailsOutPutPrograms_Label.Text = My.Resources._IMSS_WindowsDefender
    '            Case "Defende Backups"
    '                _IMSS_DetailsOutPutPrograms_Label.Text = My.Resources._IMSS_WindowsDefender
    '            Case "SpybotS&D Logs"
    '                _IMSS_DetailsOutPutPrograms_Label.Text = My.Resources._IMSS_SpybotSD
    '            Case "Backups"
    '                _IMSS_DetailsOutPutPrograms_Label.Text = My.Resources._IMSS_SpybotSD
    '            Case "Statistics"
    '                _IMSS_DetailsOutPutPrograms_Label.Text = My.Resources._IMSS_SpybotSD
    '            Case "VS 2012 File MRU List"
    '                _IMSS_DetailsOutPutPrograms_Label.Text = My.Resources._IMSS_VisualStudio
    '            Case "VS 2012 Project MRU List"
    '                _IMSS_DetailsOutPutPrograms_Label.Text = My.Resources._IMSS_VisualStudio
    '            Case "VS 2010 File MRU List"
    '                _IMSS_DetailsOutPutPrograms_Label.Text = My.Resources._IMSS_VisualStudio
    '            Case "VS 2010 Project MRU List"
    '                _IMSS_DetailsOutPutPrograms_Label.Text = My.Resources._IMSS_VisualStudio
    '            Case "VS 2008 File MRU List"
    '                _IMSS_DetailsOutPutPrograms_Label.Text = My.Resources._IMSS_VisualStudio
    '            Case "VS 2008 Project MRU List"
    '                _IMSS_DetailsOutPutPrograms_Label.Text = My.Resources._IMSS_VisualStudio
    '            Case "VS 2005 File MRU List"
    '                _IMSS_DetailsOutPutPrograms_Label.Text = My.Resources._IMSS_VisualStudio
    '            Case "VS 2005 Project MRU List"
    '                _IMSS_DetailsOutPutPrograms_Label.Text = My.Resources._IMSS_VisualStudio
    '            Case "Recycle Bin"
    '                _IMSS_DetailsOutPutPrograms_Label.Text = My.Resources._IMSS_RecycleBin
    '            Case "Service Profiles Caches"
    '                _IMSS_DetailsOutPutPrograms_Label.Text = My.Resources._IMSS_ServiceProfiles
    '            Case "jrs files"
    '                _IMSS_DetailsOutPutPrograms_Label.Text = My.Resources._IMSS_WindowsMail
    '            Case "Standar Log Files"
    '                _IMSS_DetailsOutPutPrograms_Label.Text = My.Resources._IMSS_WindowsMail
    '            Case "Backup Log Files"
    '                _IMSS_DetailsOutPutPrograms_Label.Text = My.Resources._IMSS_WindowsMail
    '            Case "Temp Files"
    '                _IMSS_DetailsOutPutPrograms_Label.Text = My.Resources._IMSS_CDDVD
    '            Case Else
    '                _IMSS_DetailsOutPutPrograms_Label.Text = "Nothing"
    '        End Select
    '    End Sub
    '    Private Sub _IMSS_SET_SystemInfo()
    '        _IMSS_DetailsOutPutPrograms_Label.Text = My.Resources._IMSS_SystemInfo
    '    End Sub
    '    Private Sub lvwTemps_ItemChecked(ByVal sender As System.Object, ByVal eventArgs As ComponentOwl.BetterListView.BetterListViewItemCheckedEventArgs) Handles lvwTemps.ItemChecked
    '        If _IMSS_STATUS = True Then
    '            _IMSS_ItemToDeleteTotalNumber_Label.Text = 0
    '            Dim _IMSS_Output As Double
    '            For Each _IMSS_CheckedItems In lvwTemps.Items
    '                If _IMSS_CheckedItems.Checked = True Then
    '                    Dim _IMSS_SelctedCheckedItemSizeInByte As Double = CType(_IMSS_CheckedItems.SubItems(2).Text.Replace("MB", "").Trim(), Double)
    '                    _IMSS_ItemToDeleteTotalNumber_Label.Text = CType(Convert.ToInt32(_IMSS_ItemToDeleteTotalNumber_Label.Text.Replace(",", "")) + _
    '                    Convert.ToInt32(_IMSS_CheckedItems.SubItems(1).Text.Replace(",", "")), String)
    '                    _IMSS_Output += _IMSS_SelctedCheckedItemSizeInByte
    '                End If
    '            Next
    '            _IMSS_TotaleSelectedItemsSizeToDelete_Label.Text = CType(_IMSS_Output, String) & " MB"
    '            _IMSS_ItemToDeleteTotalNumber_Label.Text = CType(_IMSS_FormatNumber(CType(_IMSS_ItemToDeleteTotalNumber_Label.Text, Double)), String)
    '        End If
    '    End Sub

    '    'Private Function _IMSS_ConvertBtoByte(ByVal _IMSS_Size As Double) As Double
    '    '    Return _IMSS_Size
    '    'End Function
    '    'Private Function _IMSS_ConvertKBtoByte(ByVal _IMSS_Size As Double) As Double
    '    '    Return _IMSS_Size * 1024
    '    'End Function
    '    'Private Function _IMSS_ConvertMBtoByte(ByVal _IMSS_Size As Double) As Double
    '    '    Return _IMSS_Size * 1048576
    '    'End Function
    '    'Private Function _IMSS_ConvertGBtoByte(ByVal _IMSS_Size As Double) As Double
    '    '    Return _IMSS_Size * 1073741824
    '    'End Function
    '    'Private Function _IMSS_ConvertMaxToMinOfOutPut()
    '    '    Select Case _IMSS_TotaleSelectedItemsSizeToDelete_Label.Text
    '    '        Case _IMSS_TotaleSelectedItemsSizeToDelete_Label.Text.Contains("Gb")
    '    '            Return CType(_IMSS_TotaleSelectedItemsSizeToDelete_Label.Text.Replace("Gb", "").Trim(), Double)
    '    '            Exit Function
    '    '        Case _IMSS_TotaleSelectedItemsSizeToDelete_Label.Text.Contains("Mb")
    '    '            Return _IMSS_ConvertMBtoByte(CType(_IMSS_TotaleSelectedItemsSizeToDelete_Label.Text.Replace("Mb", "").Replace(",", "").Replace(".", "").Trim(), Long))
    '    '            Exit Function
    '    '        Case _IMSS_TotaleSelectedItemsSizeToDelete_Label.Text.Contains("Kb")
    '    '            Return _IMSS_ConvertKBtoByte(CType(_IMSS_TotaleSelectedItemsSizeToDelete_Label.Text.Replace("Kb", "").Replace(",", "").Replace(".", "").Trim(), Long))
    '    '            Exit Function
    '    '        Case _IMSS_TotaleSelectedItemsSizeToDelete_Label.Text.Contains("b")
    '    '            Return _IMSS_ConvertBtoByte(CType(_IMSS_TotaleSelectedItemsSizeToDelete_Label.Text.Replace("b", "").Replace(",", "").Replace(".", "").Trim(), Long))
    '    '            'Case Else
    '    '            Exit Function
    '    '    End Select
    '    '    Return New Double = 0.0
    '    'End Function

    '    Public Shared Function _IMSS_FormatNumber(ByVal _IMSS_NUMBER As Double) As String
    '        Dim s As String = _IMSS_NUMBER.ToString()
    '        Dim result As String = ""

    '        If s.IndexOf("."c) <> -1 Then
    '            result = s.Substring(s.IndexOf("."c))
    '            s = s.Substring(0, s.IndexOf("."c))
    '        End If

    '        While s.Length > 3
    '            result = "," & s.Substring(s.Length - 3)
    '            s = s.Substring(0, s.Length - 3)
    '        End While
    '        If s.Length = 0 Then
    '            Return result.Substring(1)
    '        End If
    '        Return s & result
    '    End Function

    '    Private Function FormatFileSize(ByVal FileSizeBytes As Long) As String
    '        Dim sizeTypes() As String = {"b", "Kb", "Mb", "Gb"}
    '        Dim Len As Decimal = FileSizeBytes
    '        Dim sizeType As Integer = 0
    '        Do While Len > 1024
    '            Len = Decimal.Round(Len / 1024, 2)
    '            sizeType += 1
    '            If sizeType >= sizeTypes.Length - 1 Then Exit Do
    '        Loop
    '        Dim Resp As String = Len.ToString & " " & sizeTypes(sizeType)
    '        Return Resp
    '    End Function

    '    'Private Sub _IMSS_LitsHoders_Panel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_LitsHoders_Panel.Click
    '    '    Control.CheckForIllegalCrossThreadCalls = False
    '    'End Sub

    '    Private Sub _IMSS_CheckBoxX_CheckAllUnCheckAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_CheckBoxX_CheckAllUnCheckAll.CheckedChanged
    '        If _IMSS_CheckBoxX_CheckAllUnCheckAll.Checked = True Then
    '            _IMSS_CheckAll(True)
    '        Else
    '            _IMSS_CheckAll(False)
    '        End If
    '    End Sub
    '    Private Sub _IMSS_CheckAll(ByVal _IMSS_STATUS As Boolean)
    '        For Each _IMSS_ITEMS In lvwTemps.Items
    '            If _IMSS_STATUS = True Then
    '                If CType(_IMSS_ITEMS.SubItems(1).Text.Replace(",", ""), Integer) > 1 Then
    '                    _IMSS_ITEMS.Checked = True
    '                Else
    '                    _IMSS_ITEMS.Checked = False
    '                End If
    '            Else
    '                _IMSS_ITEMS.Checked = False
    '            End If
    '        Next
    '    End Sub

    '    Private Sub IMSS_ResultUserControl_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
    '        With lvwTemps
    '            .Columns(0).Width = CInt(.Width * 0.7) 'set column width to be 100% of controls width
    '            '.Columns(1).Width = CInt(.Width * 0.5) 'set column width to be 50% of controls width
    '        End With
    '    End Sub

    Private Sub _IMSS_CheckBoxX_CheckAllUnCheckAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_CheckBoxX_CheckAllUnCheckAll.CheckedChanged
        For Each _IMSS_ITEMS In lvwTemps.Items
            If _IMSS_CheckBoxX_CheckAllUnCheckAll.Checked = True Then
                _IMSS_ITEMS.Checked = True
            Else
                _IMSS_ITEMS.Checked = False
            End If
        Next
    End Sub
    Public _IMSS_CHECKED_ITEMS As Boolean = False
    Private Sub lvwTemps_ItemChecked(ByVal sender As System.Object, ByVal eventArgs As ComponentOwl.BetterListView.BetterListViewItemCheckedEventArgs) Handles lvwTemps.ItemChecked
        If eventArgs.Item.Checked Then
            _IMSS_ItemToDeleteTotalNumber_Label.Text = Convert.ToInt32(_IMSS_ItemToDeleteTotalNumber_Label.Text) + 1
            If _IMSS_CHECKED_ITEMS = True Then _IMSS_TotaleSelectedItemsSizeToDelete_Label.Text = Convert.ToDouble(_IMSS_TotaleSelectedItemsSizeToDelete_Label.Text) + Convert.ToDouble(eventArgs.Item.SubItems(2).Text.Replace("KB", ""))
        Else
            _IMSS_ItemToDeleteTotalNumber_Label.Text = Convert.ToInt32(_IMSS_ItemToDeleteTotalNumber_Label.Text) - 1
            If _IMSS_CHECKED_ITEMS = True Then _IMSS_TotaleSelectedItemsSizeToDelete_Label.Text = Convert.ToDouble(_IMSS_TotaleSelectedItemsSizeToDelete_Label.Text) - Convert.ToDouble(eventArgs.Item.SubItems(2).Text.Replace("KB", ""))
        End If
        If Not Convert.ToInt32(_IMSS_ItemToDeleteTotalNumber_Label.Text) > 0 Then MainWindow._IMSS_CleanFile_Button.Enabled = False Else MainWindow._IMSS_CleanFile_Button.Enabled = True
    End Sub

    Private Sub lvwTemps_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvwTemps.SelectedIndexChanged
        On Error Resume Next
        _IMSS_LOGO_ITEM_TITLE.Image = Icon.ExtractAssociatedIcon(lvwTemps.SelectedItems(0).Text).ToBitmap()
        _IMSS_ItemName.Text = _IMSS_CkeckItemLength()
        _IMSS_CO_Label.Text = New FileInfo(lvwTemps.SelectedItems(0).Text).CreationTime.ToString().Substring(0, 10)
        _IMSS_MO_Label.Text = New FileInfo(lvwTemps.SelectedItems(0).Text).LastWriteTime.ToString().Substring(0, 10)
        _IMSS_LA_Label.Text = New FileInfo(lvwTemps.SelectedItems(0).Text).LastAccessTime.ToString().Substring(0, 10)
    End Sub
    Private Function _IMSS_CkeckItemLength() As String
        If IO.Path.GetFileNameWithoutExtension(lvwTemps.SelectedItems(0).Text).Length > 16 Then _
            Return "Item Name : " & IO.Path.GetFileNameWithoutExtension(lvwTemps.SelectedItems(0).Text).Substring(0, 16) & "..." Else _
            Return "Item Name : " & IO.Path.GetFileNameWithoutExtension(lvwTemps.SelectedItems(0).Text)
    End Function

    Private Sub _IMSS_PROPERTIS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_PROPERTIS.Click
        On Error GoTo _IMSS_ON_ERROR
        Dim sei As New SHELLEXECUTEINFO
            sei.cbSize = Marshal.SizeOf(sei)
            sei.lpVerb = "properties"
            sei.lpFile = _lvwTemps.SelectedItems(0).Text
            sei.nShow = SW_SHOW
            sei.fMask = SEE_MASK_INVOKEIDLIST
            If Not ShellExecuteEx(sei) Then
                Dim ex As New System.ComponentModel.Win32Exception(System.Runtime.InteropServices.Marshal.GetLastWin32Error())
                MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
_IMSS_ON_ERROR:
        ' MessageBox.Show("Pleas select item to show it's propertis !", Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
    End Sub

    Private Sub _IMSS_ViewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_ViewItem.Click
        On Error GoTo _IMSS_ON_ERROR
        Process.Start(IO.Path.GetDirectoryName(lvwTemps.SelectedItems(0).Text))
_IMSS_ON_ERROR:
    End Sub

End Class

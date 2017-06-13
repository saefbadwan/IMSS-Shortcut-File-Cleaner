' بسم الله الرحمن الرحيم
Imports System.IO
Imports System
Imports System.Text
Imports ComponentOwl.BetterListView
Imports Microsoft.Win32
Imports DevComponents.DotNetBar

'Imports Shell32
Public Class MainWindow
#Region "IMSS User Controls Items"
    Private _IMSS_RESULIT As New IMSS_ResultUserControl
    Private Sub _IMSS_SETUP_LISTVIEW()
        _IMSS_StepIndicator.StepCount = 10
        _IMSS_RESULIT.lvwTemps.Groups.Add("Desktop Elements").Image = My.Resources._IMSS_Desktop_Icon_24x24
        _IMSS_RESULIT.lvwTemps.Groups.Add("Recint Elements").Image = My.Resources._IMSS_Recent_Icon_24x24
        _IMSS_RESULIT.lvwTemps.Groups.Add("My Documents Elements").Image = My.Resources._IMSS_MyDocuments_Icon_24x24
        _IMSS_RESULIT.lvwTemps.Groups.Add("History Elements").Image = My.Resources._IMSS_History_Icon_24x24
        _IMSS_RESULIT.lvwTemps.Groups.Add("StartMenu Elements").Image = My.Resources._IMSS_StartMenu_Icon_24x24
        _IMSS_RESULIT.lvwTemps.Groups.Add("Templates Elements").Image = My.Resources._IMSS_Templates_Icon_24x24
        _IMSS_RESULIT.lvwTemps.Groups.Add("Favorites Elements").Image = My.Resources._IMSS_Favorites_Icon_24x24
        _IMSS_RESULIT.lvwTemps.Groups.Add("InternetCache Elements").Image = My.Resources._IMSS_TemporaryInternetFiles_Icon_24x24
        _IMSS_RESULIT.lvwTemps.Groups.Add("Other Elements").Image = My.Resources._IMSS_TemporaryInternetFiles_Icon_24x24
        _IMSS_RESULIT.lvwTemps.ShowGroups = True
    End Sub
#End Region
#Region "IMSS Defulit Search Paths"
    Private _IMSS_Desktop_Path As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
    Private _IMSS_Documint_Path As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
    Private _IMSS_History As String = Environment.GetFolderPath(Environment.SpecialFolder.History)
    Private _IMSS_Recent As String = Environment.GetFolderPath(Environment.SpecialFolder.Recent)
    Private _IMSS_StartMenu As String = Environment.GetFolderPath(Environment.SpecialFolder.StartMenu)
    Private _IMSS_Templates As String = Environment.GetFolderPath(Environment.SpecialFolder.Templates)
    Private _IMSS_Favorites As String = Environment.GetFolderPath(Environment.SpecialFolder.Favorites)
    Private _IMSS_InternetCache As String = Environment.GetFolderPath(Environment.SpecialFolder.InternetCache)
#Region "IMSS CLAC ITEM"
    Private _IMSS_CALC_ALL_ITEMS As Integer = 0
    Private _IMSS_CALC_ALL_SIZE As Double = 0.0
#End Region
    Private Sub _IMSS_CALC_OUTPUT()
        _IMSS_RESULIT._IMSS_ItemToDeleteTotalNumber_Label.Text = _IMSS_CALC_ALL_ITEMS.ToString()
        _IMSS_RESULIT._IMSS_TotalItems_Label.Text = _IMSS_CALC_ALL_ITEMS.ToString()
        _IMSS_RESULIT._IMSS_FullSize_Label.Text = _IMSS_CALC_ALL_SIZE.ToString()
        _IMSS_RESULIT._IMSS_TotaleSelectedItemsSizeToDelete_Label.Text = _IMSS_CALC_ALL_SIZE.ToString()
        _IMSS_RESULIT._IMSS_CHECKED_ITEMS = True
        _IMSS_SCAN_SELECTED_TARGETS.Visible = True
        If Not _IMSS_RESULIT.lvwTemps.Items.Count = 0 Then
            Me._IMSS_OutPutPanel.Visible = False : Me._IMSS_OutPutPanel.Dock = DockStyle.None
            Me._IMSS_OutPutPanel.Enabled = False ' _IMSS_RESULIT.Enabled = True
            _IMSS_RESULIT.Dock = DockStyle.Fill : _IMSS_RESULIT.Visible = True
            Me._IMSS_MainPanel.Controls.Add(_IMSS_RESULIT)
            _IMSS_RESULIT.lvwTemps.Items(0).Selected = True
            _IMSS_CleanFile_Button.Enabled = True
            _IMSS_CleanFile_Button.Visible = True
        Else
            Dim _IMSS_NOTFOUND As New IMSS_ITEMS_NOTFOUND
            Me._IMSS_OutPutPanel.Visible = False : Me._IMSS_OutPutPanel.Dock = DockStyle.None : Me._IMSS_OutPutPanel.Enabled = False
            _IMSS_NOTFOUND.Dock = DockStyle.Fill : _IMSS_NOTFOUND.Visible = True
            _IMSS_Close_Button.Enabled = True : _IMSS_Close_Button.Visible = True
            Me._IMSS_MainPanel.Controls.Add(_IMSS_NOTFOUND)
            _IMSS_CleanFile_Button.Visible = False
        End If
        _IMSS_CancelButton.Visible = False
    End Sub
#End Region

#Region "IMSS Scan For Targets And Set OutPut Resuilt"
    'Private Delegate Sub _IMSS_UPDATE_LABEL_TEXT_DELEGATE(ByVal _IMSS_OUTPUT_INFO As String)
    Private Sub _IMSS_UPDATE_LABEL_TEXT(ByVal _IMSS_OUTPUT_INFO As String)
        If _IMSS_Status_Label.InvokeRequired = True Then
            Invoke(New MethodInvoker(Sub()
                                         _IMSS_Status_Label.Text = _IMSS_OUTPUT_INFO
                                     End Sub)) : Else
            _IMSS_Status_Label.Text = _IMSS_OUTPUT_INFO : End If
    End Sub
    Private Sub _IMSS_UPDATE_LISTVIEW_ITEMS()
        If _IMSS_RESULIT.lvwTemps.InvokeRequired = True Then
            Invoke(New MethodInvoker(Sub()
                                         _IMSS_LOAD_ALL_RESULIT()
                                     End Sub)) : Else
            _IMSS_LOAD_ALL_RESULIT() : End If
    End Sub
    Private Sub _IMSS_LOAD_ALL_RESULIT()
        _IMSS_CALC_ALL_ITEMS = _IMSS_FOUNDED_ITEMS_LIST.Count.ToString()
        For Each _IMSS_ITEM As String In _IMSS_FOUNDED_ITEMS_LIST
            _IMSS_CALC_ALL_SIZE += Convert.ToDouble(_IMSS_GetSizeKB(_IMSS_ITEM.ToString()).Replace("KB", ""))
            If _IMSS_ITEM.ToString().Contains("Desktop") Then
                With _IMSS_RESULIT.lvwTemps.Groups(0).Items.Add(_IMSS_ITEM.ToString())
                    .Checked = True
                    .SubItems.Add(_IMSS_GET_LINK_TARGET(_IMSS_ITEM.ToString())).Image = My.Resources._IMSS_Warning_Icon_16x16
                    .SubItems.Add(_IMSS_GetSizeKB(_IMSS_ITEM.ToString()))
                End With
            ElseIf _IMSS_ITEM.ToString().Contains("Recent") Then
                With _IMSS_RESULIT.lvwTemps.Groups(1).Items.Add(_IMSS_ITEM.ToString())
                    .Checked = True
                    .SubItems.Add(_IMSS_GET_LINK_TARGET(_IMSS_ITEM.ToString())).Image = My.Resources._IMSS_Warning_Icon_16x16
                    .SubItems.Add(_IMSS_GetSizeKB(_IMSS_ITEM.ToString()))
                End With
            ElseIf _IMSS_ITEM.ToString().Contains("My Documents") Then
                With _IMSS_RESULIT.lvwTemps.Groups(2).Items.Add(_IMSS_ITEM.ToString())
                    .Checked = True
                    .SubItems.Add(_IMSS_GET_LINK_TARGET(_IMSS_ITEM.ToString())).Image = My.Resources._IMSS_Warning_Icon_16x16
                    .SubItems.Add(_IMSS_GetSizeKB(_IMSS_ITEM.ToString()))
                End With
            ElseIf _IMSS_ITEM.ToString().Contains("History") Then
                With _IMSS_RESULIT.lvwTemps.Groups(3).Items.Add(_IMSS_ITEM.ToString())
                    .Checked = True
                    .SubItems.Add(_IMSS_GET_LINK_TARGET(_IMSS_ITEM.ToString())).Image = My.Resources._IMSS_Warning_Icon_16x16
                    .SubItems.Add(_IMSS_GetSizeKB(_IMSS_ITEM.ToString()))
                End With
            ElseIf _IMSS_ITEM.ToString().Contains("Start Menu") Then
                With _IMSS_RESULIT.lvwTemps.Groups(4).Items.Add(_IMSS_ITEM.ToString())
                    .Checked = True
                    .SubItems.Add(_IMSS_GET_LINK_TARGET(_IMSS_ITEM.ToString())).Image = My.Resources._IMSS_Warning_Icon_16x16
                    .SubItems.Add(_IMSS_GetSizeKB(_IMSS_ITEM.ToString()))
                End With
            ElseIf _IMSS_ITEM.ToString().Contains("Templates") Then
                With _IMSS_RESULIT.lvwTemps.Groups(5).Items.Add(_IMSS_ITEM.ToString())
                    .Checked = True
                    .SubItems.Add(_IMSS_GET_LINK_TARGET(_IMSS_ITEM.ToString())).Image = My.Resources._IMSS_Warning_Icon_16x16
                    .SubItems.Add(_IMSS_GetSizeKB(_IMSS_ITEM.ToString()))
                End With
            ElseIf _IMSS_ITEM.ToString().Contains("Favorites") Then
                With _IMSS_RESULIT.lvwTemps.Groups(6).Items.Add(_IMSS_ITEM.ToString())
                    .Checked = True
                    .SubItems.Add(_IMSS_GET_LINK_TARGET(_IMSS_ITEM.ToString())).Image = My.Resources._IMSS_Warning_Icon_16x16
                    .SubItems.Add(_IMSS_GetSizeKB(_IMSS_ITEM.ToString()))
                End With
            ElseIf _IMSS_ITEM.ToString().Contains("Temporary Internet Files") Then
                With _IMSS_RESULIT.lvwTemps.Groups(7).Items.Add(_IMSS_ITEM.ToString())
                    .Checked = True
                    .SubItems.Add(_IMSS_GET_LINK_TARGET(_IMSS_ITEM.ToString())).Image = My.Resources._IMSS_Warning_Icon_16x16
                    .SubItems.Add(_IMSS_GetSizeKB(_IMSS_ITEM.ToString()))
                End With
            Else
                With _IMSS_RESULIT.lvwTemps.Groups(8).Items.Add(_IMSS_ITEM.ToString())
                    .Checked = True
                    .SubItems.Add(_IMSS_GET_LINK_TARGET(_IMSS_ITEM.ToString())).Image = My.Resources._IMSS_Warning_Icon_16x16
                    .SubItems.Add(_IMSS_GetSizeKB(_IMSS_ITEM.ToString()))
                End With
            End If
        Next
        _IMSS_CALC_OUTPUT()
    End Sub
    Private _IMSS_FOUNDED_ITEMS_LIST As New ArrayList
    Private Sub _IMSS_START_SEARCHER_ON_DEFULIT_PATHS()
        _IMSS_UPDATE_LABEL_TEXT("Checking category : Desktop Files") : _IMSS_SEARCHER(_IMSS_Desktop_Path) : _IMSS_StepIndicator.CurrentStep = 1
        _IMSS_UPDATE_LABEL_TEXT("Checking category : Documint") : _IMSS_SEARCHER(_IMSS_Documint_Path) : System.Threading.Thread.Sleep(400) : _IMSS_StepIndicator.CurrentStep = 2
        _IMSS_UPDATE_LABEL_TEXT("Checking category : History Files") : _IMSS_SEARCHER(_IMSS_History) : System.Threading.Thread.Sleep(400) : _IMSS_StepIndicator.CurrentStep = 3
        _IMSS_UPDATE_LABEL_TEXT("Checking category : Recent Files") : _IMSS_SEARCHER(_IMSS_Recent) : System.Threading.Thread.Sleep(400) : _IMSS_StepIndicator.CurrentStep = 4
        _IMSS_UPDATE_LABEL_TEXT("Checking category : Start Menu Files") : _IMSS_SEARCHER(_IMSS_StartMenu) : System.Threading.Thread.Sleep(400) : _IMSS_StepIndicator.CurrentStep = 5
        _IMSS_UPDATE_LABEL_TEXT("Checking category : Templates Files") : _IMSS_SEARCHER(_IMSS_Templates) : System.Threading.Thread.Sleep(400) : _IMSS_StepIndicator.CurrentStep = 6
        _IMSS_UPDATE_LABEL_TEXT("Checking category : Favorites Files") : _IMSS_SEARCHER(_IMSS_Favorites) : System.Threading.Thread.Sleep(400) : _IMSS_StepIndicator.CurrentStep = 7
        _IMSS_UPDATE_LABEL_TEXT("Checking category : Internet Cache Files") : _IMSS_SEARCHER(_IMSS_InternetCache) : System.Threading.Thread.Sleep(400) : _IMSS_StepIndicator.CurrentStep = 9
        _IMSS_UPDATE_LABEL_TEXT("Checking category's Complete") : _IMSS_StepIndicator.CurrentStep = 10
        '_IMSS_MAIN_START_THREAD.Join()
        _IMSS_UPDATE_LISTVIEW_ITEMS()
    End Sub
    Private Sub _IMSS_SEARCHER(ByVal _IMSS_TARGET As String)
        For Each _IMSS_FILE As String In IO.Directory.GetFiles(_IMSS_TARGET, "*.lnk", SearchOption.TopDirectoryOnly)
            If _IMSS_CHECK_LINK_TARGET(_IMSS_FILE) = True Then
                _IMSS_FOUNDED_ITEMS_LIST.Add(_IMSS_FILE)
            End If
        Next
    End Sub
    Private Function _IMSS_CHECK_LINK_TARGET(ByVal FileName As String) As Boolean
        On Error GoTo _IMSS_ON_ERROR
        Dim Obj As Object : Obj = CreateObject("WScript.Shell")
        Dim Shortcut As Object : Shortcut = Obj.CreateShortcut(FileName)
        If Path.HasExtension(Shortcut.TargetPath) Then
            If IO.File.Exists(Shortcut.TargetPath) Then Return False Else Return True
        Else
            If IO.Directory.Exists(Shortcut.TargetPath) Then Return False Else Return True
        End If
_IMSS_ON_ERROR:
        Return False
    End Function
    Function _IMSS_GET_LINK_TARGET(ByVal FileName As String) As String
        On Error GoTo _IMSS_ON_ERROR
        Dim Obj As Object : Obj = CreateObject("WScript.Shell")
        Dim Shortcut As Object : Shortcut = Obj.CreateShortcut(FileName)
        If (Shortcut.TargetPath) = String.Empty Then Return "Duplicate System Shortcut" Else Return (Shortcut.TargetPath)
_IMSS_ON_ERROR:
        Return "Error while get the target path"
    End Function
    Private Function _IMSS_GetSizeKB(ByVal Filename As String) As String
        Dim _IMSS_Value As String = (New IO.FileInfo(Filename).Length / 1024).ToString()
        If _IMSS_Value.Length > 6 Then
            Return (New IO.FileInfo(Filename).Length / 1024).ToString().Substring(0, 6) & " KB"
        Else
            Return (New IO.FileInfo(Filename).Length / 1024).ToString() & " KB"
        End If
    End Function
#End Region

#Region "IMSS ON STARTUP START"
    Private _IMSS_MAIN_START_THREAD As New Threading.Thread(New Threading.ThreadStart(AddressOf _IMSS_START_SEARCHER_ON_DEFULIT_PATHS))
    Private Sub MainWindow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _IMSS_SETUP_LISTVIEW()
        _IMSS_MAIN_START_THREAD.Start()
    End Sub
#End Region

    Private Sub _IMSS_CancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_CancelButton.Click
        Try : _IMSS_MAIN_START_THREAD.Abort() : Catch ex As Exception : End Try
        Application.Exit()
    End Sub

    Private Sub _IMSS_CleanFile_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_CleanFile_Button.Click
        Dim _IMSS_LIST_TO_DELETE_ITEMS As New ArrayList
        For Each _IMSS_SELCTED_FOR_DELETE_ITEM In _IMSS_RESULIT.lvwTemps.Items
            If _IMSS_SELCTED_FOR_DELETE_ITEM.Checked = True Then
                _IMSS_LIST_TO_DELETE_ITEMS.Add(_IMSS_SELCTED_FOR_DELETE_ITEM.Text)
            End If
        Next
        Dim _IMSS_PROCESS_TARGETS As New IMSS_PROCESS_TARGETS(_IMSS_LIST_TO_DELETE_ITEMS, _IMSS_CALC_ALL_SIZE)
        _IMSS_PROCESS_TARGETS._IMSS_StepIndicator.StepCount = _IMSS_LIST_TO_DELETE_ITEMS.Count
        Me._IMSS_OutPutPanel.Visible = False : Me._IMSS_OutPutPanel.Dock = DockStyle.None
        _IMSS_RESULIT.Dock = DockStyle.None : _IMSS_RESULIT.Visible = False
        _IMSS_PROCESS_TARGETS.Dock = DockStyle.Fill : _IMSS_PROCESS_TARGETS.Visible = True
        _IMSS_PROCESS_TARGETS._IMSS_Status_Label.Text = "Initializing ..."
        Me._IMSS_MainPanel.Controls.Add(_IMSS_PROCESS_TARGETS)
        _IMSS_PROCESS_TARGETS._IMSS_STARTS()
    End Sub

    Private Sub _IMSS_Close_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Close_Button.Click
        Application.Exit()
    End Sub
#Region "IMSS SCAN SELECTED PATH"
    Private _IMSS_SELECTED_TARGET As String = String.Empty
    Private Sub ButtonItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_SCAN_SELECTED_TARGETS.Click
        If _IMSS_SELECT_FOLDER.ShowDialog = Windows.Forms.DialogResult.OK Then
            _IMSS_RESULIT._IMSS_CHECKED_ITEMS = False
            _IMSS_CancelButton.Visible = False
            _IMSS_Close_Button.Visible = False
            _IMSS_SELECTED_TARGET = _IMSS_SELECT_FOLDER.SelectedPath
            _IMSS_FOUNDED_ITEMS_LIST.Clear()
            _IMSS_RESULIT.lvwTemps.Items.Clear()
            _IMSS_MainPanel.Controls.Clear()
            _IMSS_MainPanel.Controls.Add(_IMSS_OutPutPanel)
            _IMSS_OutPutPanel.Dock = DockStyle.Fill : _IMSS_OutPutPanel.Visible = True
            Dim _IMSS_SELECTED_START_THREAD As New Threading.Thread(New Threading.ThreadStart(AddressOf _IMSS_START_SEARCHER_ON_SELECTED_PATHS))
            _IMSS_SELECTED_START_THREAD.Start()
        End If
    End Sub

    Private Sub _IMSS_START_SEARCHER_ON_SELECTED_PATHS()
        _IMSS_UPDATE_LABEL_TEXT("Checking category : " & _IMSS_SELECTED_TARGET) : _IMSS_SEARCHER(_IMSS_SELECTED_TARGET) : _IMSS_StepIndicator.CurrentStep = 10
        _IMSS_UPDATE_LISTVIEW_ITEMS()
    End Sub

#End Region

End Class
' بسم الله الرحمن الرحيم
Public Class IMSS_PROCESS_TARGETS
    Private _IMSS_TARGET_LIST_ITEMS As New ArrayList
    Private _IMSS_TARGET_ITEMS_ALL_SIZE As String = String.Empty
    Public Sub New(ByRef _IMSS_TARGET_LIST As ArrayList, ByVal _IMSS_TOTALE_ITEMS_SIZE As Double)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _IMSS_TARGET_LIST_ITEMS.AddRange(_IMSS_TARGET_LIST)
        _IMSS_TARGET_ITEMS_ALL_SIZE = _IMSS_TOTALE_ITEMS_SIZE.ToString()
    End Sub
    Private _IMSS_MAIN_START_THREAD As New Threading.Thread(New Threading.ThreadStart(AddressOf _IMSS_START_DELETER_ON_DEFULIT_PATHS))
    Public Sub _IMSS_STARTS()
        _IMSS_MAIN_START_THREAD.Start()
    End Sub

    Private Sub _IMSS_START_DELETER_ON_DEFULIT_PATHS()
        System.Threading.Thread.Sleep(1000)
        If _IMSS_Status_Label.InvokeRequired = True Then
            Invoke(New MethodInvoker(Sub()
                                         _IMSS_PROCESS_TARGET_ITEMS()
                                     End Sub)) : Else
            _IMSS_PROCESS_TARGET_ITEMS()
        End If
    End Sub

    Private Sub _IMSS_PROCESS_TARGET_ITEMS()
        ' On Error Resume Next
        For Each IMSS_TARGET_LIST_ITEMS In _IMSS_TARGET_LIST_ITEMS
            _IMSS_Status_Label.Text = "Deleting target : " & IMSS_TARGET_LIST_ITEMS
            If IO.File.Exists(IMSS_TARGET_LIST_ITEMS) Then IO.File.Delete(IMSS_TARGET_LIST_ITEMS)
            _IMSS_StepIndicator.CurrentStep += 1
        Next
        MainWindow._IMSS_MainPanel.Controls.Clear()
        Dim _IMSS_COMPLETE As New IMSS_ITEMS_NOTFOUND
        _IMSS_COMPLETE._IMSS_MainStatusTitel.Text = "The selected items was deleted successfully " & Environment.NewLine & " , click close to close the program"
        _IMSS_COMPLETE._IMSS_ListHolders_Panel.Text = "Deleting broken shortcuts was complete"
        _IMSS_COMPLETE._IMSS_ItemToDeleteTotalNumber_Label.Text = _IMSS_TARGET_LIST_ITEMS.Count.ToString()
        _IMSS_COMPLETE._IMSS_TotaleSelectedItemsSizeToDelete_Label.Text = _IMSS_TARGET_ITEMS_ALL_SIZE
        _IMSS_COMPLETE.Dock = DockStyle.Fill : _IMSS_COMPLETE.Visible = True : _IMSS_COMPLETE._IMSS_MainStatusTitel.Location = New Point(260, 248)
        MainWindow._IMSS_Close_Button.Enabled = True : MainWindow._IMSS_Close_Button.Visible = True
        MainWindow._IMSS_MainPanel.Controls.Add(_IMSS_COMPLETE)
        MainWindow._IMSS_CleanFile_Button.Visible = False
    End Sub
End Class

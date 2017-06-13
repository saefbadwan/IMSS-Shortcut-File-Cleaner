Imports System.IO

Public Class IMSS_Windows_XP_7_8_Paths
    Private IMSS_OS_SYSTEM As Boolean

#Region " Base Path Methods "
    Public ReadOnly Property _IMSS_WindowsDefenderDefinitionUpdatesBackup As String
        Get
            Return programData() & "\Microsoft\Windows Defender\Definition Updates\Backup"
        End Get
    End Property
    Public ReadOnly Property programData As String
        Get
            Return Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData)
        End Get
    End Property
    Public ReadOnly Property _IMSS_WindowsErrorReportingReportQueue As String
        Get
            Return profileAppDataLocal() & "\Microsoft\Windows\WER\ReportQueue"
        End Get
    End Property
    Public ReadOnly Property profileAppDataRoaming As String
        Get
            Return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
        End Get
    End Property
    Public ReadOnly Property profileAppDataLocal As String
        Get
            Return Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)
        End Get
    End Property
    Public ReadOnly Property profileAppDataLocalLow As String
        Get
            Return Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\Low"
        End Get
    End Property
    Public ReadOnly Property AllUserAppDataLocalLow As String
        Get
            Return Environment.ExpandEnvironmentVariables("%AllUsersProfile%") & "\AppData\Local"
        End Get
    End Property
    Public ReadOnly Property system32Path As String
        Get
            Return Environment.GetFolderPath(Environment.SpecialFolder.System)
        End Get
    End Property
    Public ReadOnly Property osDriveWindows As String
        Get
            Return Environment.GetEnvironmentVariable("WINDIR", EnvironmentVariableTarget.Machine)
        End Get
    End Property
    Public ReadOnly Property osDrive As String
        Get
            Return system32Path.Substring(0, 3)
        End Get
    End Property
#End Region
End Class

Imports System.IO
Imports System.Security

Public Class Main
    ' Pre-defined RGB & WP values for BT.2020
    Const BT2020_xW = 0.3127
    Const BT2020_yW = 0.329
    Const BT2020_xR = 0.708
    Const BT2020_yR = 0.292
    Const BT2020_xG = 0.17
    Const BT2020_yG = 0.797
    Const BT2020_xB = 0.131
    Const BT2020_yB = 0.046

    ' Pre-defined RGB & WP values for BT.709
    Const BT709_xW = 0.3127
    Const BT709_yW = 0.329
    Const BT709_xR = 0.64
    Const BT709_yR = 0.33
    Const BT709_xG = 0.3
    Const BT709_yG = 0.6
    Const BT709_xB = 0.15
    Const BT709_yB = 0.06

    ' Pre-defined RGB & WP values for P3-D65
    Const P3D65Display_xW = 0.3127
    Const P3D65Display_yW = 0.329
    Const P3D65Display_xR = 0.68
    Const P3D65Display_yR = 0.32
    Const P3D65Display_xG = 0.265
    Const P3D65Display_yG = 0.69
    Const P3D65Display_xB = 0.15
    Const P3D65Display_yB = 0.06

    ' Create Dictonaries for storing paths
    Dim dictInput As New Dictionary(Of String, String)
    Dim dictOutput As New Dictionary(Of String, String)

    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        lbxDetailsInput.Items.Clear()
        'OpenFileDialog1.FileName = "Select an Input HDR Movie"
        'OpenFileDialog1.Filter = "Matroska files (*.mkv)|*.mkv"
        'OpenFileDialog1.Title = "Open Input HDR file"
        'If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
        '    Try
        '        Dim strFilePath = OpenFileDialog1.FileName
        '        tbxInput.Text = strFilePath
        '        Extract(strFilePath, 0)
        '    Catch ex As SecurityException
        '        MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" & $"Details:\n\n{ex.StackTrace}")
        '    End Try
        'End If
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            lbxInputFolder.Items.Clear()
            lblInput.Text = "Input Folder: "
            lblInput.Text &= FolderBrowserDialog1.SelectedPath
            PopulateFolderList(Split(lblInput.Text, ": ")(1), 0)
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnOutput_Click(sender As Object, e As EventArgs) Handles btnOutput.Click
        lbxDetailsOutput.Items.Clear()
        'OpenFileDialog1.FileName = "Select an Output HDR Movie"
        'OpenFileDialog1.Filter = "Matroska files (*.mkv)|*.mkv"
        'OpenFileDialog1.Title = "Open Output HDR file"
        'If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
        '    Try
        '        Dim strFilePath = OpenFileDialog1.FileName
        '        tbxOutput.Text = strFilePath
        '        Extract(strFilePath, 1)
        '    Catch ex As SecurityException
        '        MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" & $"Details:\n\n{ex.StackTrace}")
        '    End Try
        'End If
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            lbxOutputFolder.Items.Clear()
            lblOutput.Text = "Output Folder: "
            lblOutput.Text &= FolderBrowserDialog1.SelectedPath
            PopulateFolderList(Split(lblOutput.Text, ": ")(1), 1)
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Insert(lbxOutputFolder.SelectedItem)
        lbxDetailsOutput.Items.Clear()
        Extract(lbxOutputFolder.SelectedItem, 1)
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        lbxInputFolder.Items.Clear()
        lbxOutputFolder.Items.Clear()
        lbxDetailsInput.Items.Clear()
        lbxDetailsOutput.Items.Clear()
        lblInput.Text = "Input Folder: "
        lblOutput.Text = "Output Folder: "
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Function GetData(strParameters)
        Dim oProcess As New Process()
        Dim oStartInfo As New ProcessStartInfo("MediaInfo", strParameters) With {
    .CreateNoWindow = True,
    .UseShellExecute = False,
    .RedirectStandardOutput = True
        }
        oProcess.StartInfo = oStartInfo
        oProcess.Start()
        Dim oStreamReader As System.IO.StreamReader = oProcess.StandardOutput
        GetData = oStreamReader.ReadLine
    End Function

    Function WriteData(strParameters)
        Dim oProcess As New Process()
        Dim oStartInfo As New ProcessStartInfo("mkvpropedit", strParameters) With {
    .CreateNoWindow = True,
    .UseShellExecute = False,
    .RedirectStandardOutput = True
        }
        oProcess.StartInfo = oStartInfo
        oProcess.Start()
        Dim oStreamReader As System.IO.StreamReader = oProcess.StandardOutput
        WriteData = oStreamReader.ReadLine
    End Function

    Public Sub Extract(strFileName As String, ByVal Destination As Integer)
        Dim lReturnColourSpace
        Dim lReturnLuminance
        Dim lReturnMaxCLL
        Dim lReturnMaxFall
        Dim oProcess As New Process
        Dim strDestination

        'get the destination
        If Destination = 0 Then
            strDestination = lbxDetailsInput
        ElseIf Destination = 1 Then
            strDestination = lbxDetailsOutput
        Else
            MsgBox("Internal Error, No Applicable Destination.", vbAbort, "Application Error")
            Exit Sub
        End If

        ' Extract values from source video
        lReturnColourSpace = GetData(Chr(34) & "--Inform=" & "Video;%MasteringDisplay_ColorPrimaries%" & Chr(34) & " " & Chr(34) & strFileName & Chr(34))
        lReturnLuminance = GetData(Chr(34) & "--Inform=" & "Video;%MasteringDisplay_Luminance%" & Chr(34) & " " & Chr(34) & strFileName & Chr(34))
        lReturnMaxCLL = GetData(Chr(34) & "--Inform=" & "Video;%MaxCLL%" & Chr(34) & " " & Chr(34) & strFileName & Chr(34))
        lReturnMaxFall = GetData(Chr(34) & "--Inform=" & "Video;%MaxFALL%" & Chr(34) & " " & Chr(34) & strFileName & Chr(34))

        ' Print results from MediaInfo
        With strDestination
            .Items.Add("Mastering Display Color Primaries: " & If(lReturnColourSpace, "None"))
            .Items.Add("Mastering Display Luminance: " & If(lReturnLuminance, "None"))
            .Items.Add("Max CLL: " & If(lReturnMaxCLL, "None"))
            .Items.Add("Max FALL: " & If(lReturnMaxFall, "None"))
        End With
    End Sub

    Public Sub Insert(strFileName As String)
        Dim strArguments As String

        strArguments = Chr(34) & strFileName & Chr(34) & " --edit track:v1"
        If Trim(Split(lbxDetailsInput.Items(0).ToString, ":")(1)) = "BT.2020" Then
            strArguments &= " --set chromaticity-coordinates-red-x=" & BT2020_xR _
                & " --set chromaticity-coordinates-red-y=" & BT2020_yR _
                & " --set chromaticity-coordinates-green-x=" & BT2020_xG _
                & " --set chromaticity-coordinates-green-y=" & BT2020_yG _
                & " --set chromaticity-coordinates-blue-x=" & BT2020_xB _
                & " --set chromaticity-coordinates-blue-y=" & BT2020_yB _
                & " --set white-coordinates-x=" & BT2020_xW _
                & " --set white-coordinates-y=" & BT2020_yW

        ElseIf Trim(Split(lbxDetailsInput.Items(0).ToString, ":")(1)) = "BT.709" Then
            strArguments &= " --set chromaticity-coordinates-red-x=" & BT709_xR _
                & " --set chromaticity-coordinates-red-y=" & BT709_yR _
                & " --set chromaticity-coordinates-green-x=" & BT709_xG _
                & " --set chromaticity-coordinates-green-y=" & BT709_yG _
                & " --set chromaticity-coordinates-blue-x=" & BT709_xB _
                & " --set chromaticity-coordinates-blue-y=" & BT709_yB _
                & " --set white-coordinates-x=" & BT709_xW _
                & " --set white-coordinates-y=" & BT709_yW

        ElseIf Trim(Split(lbxDetailsInput.Items(0).ToString, ":")(1)) = "Display P3" Then
            strArguments &= " --set chromaticity-coordinates-red-x=" & P3D65Display_xR _
                & " --set chromaticity-coordinates-red-y=" & P3D65Display_yR _
                & " --set chromaticity-coordinates-green-x=" & P3D65Display_xG _
                & " --set chromaticity-coordinates-green-y=" & P3D65Display_yG _
                & " --set chromaticity-coordinates-blue-x=" & P3D65Display_xB _
                & " --set chromaticity-coordinates-blue-y=" & P3D65Display_yB _
                & " --set white-coordinates-x=" & P3D65Display_xW _
                & " --set white-coordinates-y=" & P3D65Display_yW
        Else
            MsgBox("Unknown colour space: " & Trim(Split(lbxDetailsInput.Items(0).ToString, ":")(1)), vbExclamation, "Error - Can Not Continue")
            Exit Sub
        End If

        strArguments &= " --set min-luminance=" & Split(Trim(Split(lbxDetailsInput.Items(1), ":")(2)), " ")(0) _
                & " --set max-luminance=" & Split(Trim(Split(lbxDetailsInput.Items(1), ":")(3)), " ")(0)

        If Split(Trim(Split(lbxDetailsInput.Items(2).ToString, ":")(1)), " ")(0) <> "" Then
            strArguments &= " --set max-content-light=" & Split(Trim(Split(lbxDetailsInput.Items(2).ToString, ":")(1)), " ")(0) _
                & " --set max-frame-light=" & Split(Trim(Split(lbxDetailsInput.Items(3).ToString, ":")(1)), " ")(0)
        End If

        WriteData(strArguments)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub HowToUseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HowToUseToolStripMenuItem.Click
        HowToUse.Show()
    End Sub

    Sub PopulateFolderList(strFolder As String, intWhich As Integer)
        Dim d As String
        Dim f As String
        Dim o As ListBox
        Dim dict As Dictionary(Of String, String)

        If intWhich = 0 Then
            o = lbxInputFolder
            dict = dictInput
        ElseIf intWhich = 1 Then
            o = lbxOutputFolder
            dict = dictOutput
        Else
            MsgBox("An Error Has Occured - Stopping", vbCritical, "Error")
            Exit Sub
        End If

        Try
            For Each d In Directory.GetDirectories(strFolder)
                For Each f In Directory.GetFiles(d, "*2160p.mkv")
                    dict.Add(Split(f, "\")(3), f)
                    o.Items.Add(Split(f, "\")(3))
                Next
            Next
        Catch excpt As System.Exception
            Debug.WriteLine(excpt.Message)
        End Try
    End Sub

    Private Sub lbxInputFolder_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxInputFolder.SelectedIndexChanged
        lbxDetailsInput.Items.Clear()
        Try
            For Each Pair As KeyValuePair(Of String, String) In dictInput
                If Pair.Key = lbxInputFolder.SelectedItem Then
                    Extract(Pair.Value, 0)
                    Exit For
                End If
            Next
        Catch ex As SecurityException
            MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" & $"Details:\n\n{ex.StackTrace}")
        End Try
    End Sub

    Private Sub lbxOutputFolder_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxOutputFolder.SelectedIndexChanged
        lbxDetailsOutput.Items.Clear()
        Try
            For Each Pair As KeyValuePair(Of String, String) In dictOutput
                If Pair.Key = lbxOutputFolder.SelectedItem Then
                    Extract(Pair.Value, 1)
                    Exit For
                End If
            Next
        Catch ex As SecurityException
            MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" & $"Details:\n\n{ex.StackTrace}")
        End Try
    End Sub
End Class


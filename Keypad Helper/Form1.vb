Imports Microsoft.Office.Core
Imports Microsoft.Office.Interop.Excel
Imports System.Diagnostics
Imports System.IO.Path
Imports System.Runtime.InteropServices
Imports System.Data.OleDb
Imports System.IO
Imports System.Net
Imports ExcelDataReader


Public Class Form1
    Private WithEvents kbHook As New KeyboardHook
    Shared xlBook As Microsoft.Office.Interop.Excel.Workbook
    Shared xlSheet As Microsoft.Office.Interop.Excel.Worksheet
    Shared xlApp As Microsoft.Office.Interop.Excel.Application
    Dim isLogging As Boolean = False
    Dim usingExcl As Boolean = False
    Dim keyCount As Integer = 0
    Dim keyStrokes As String
    Dim curKey As String
    Dim strFinal As String
    Dim Debugging As Boolean = False
    Dim keyDown As Boolean = False
    Dim firstKey As String




    Private Sub kbHook_KeyUp(Key As Keys) Handles kbHook.KeyUp
        If Key.ToString = firstKey Then
            keyDown = False
            keyCount = 0
        End If
    End Sub


    Private Sub kbHook_KeyDown(Key As Keys) Handles kbHook.KeyDown
        If Key.ToString <> firstKey Then

            If keyDown = False Then
                firstKey = Key.ToString
                keyDown = True
                keyCount = keyCount + 1
                curKey = Key.ToString

                Dim curKeyMatchNumPad As Boolean = curKey Like "NumPad[0-9]" ' Key pressed is NumPad0, NumPad1...
                If curKeyMatchNumPad Then
                    curKey = curKey.Substring(6)
                End If

                Dim curKeyMatchDNum As Boolean = curKey Like "D[0-9]" ' Key pressed is D0, D1...
                If curKeyMatchDNum = True Then
                    curKey = curKey.Substring(1)
                End If

                If keyCount <= 1 Then
                    If isLogging = True Then
                        If Key.ToString = "Return" Then
                            txtFeed.AppendText(keyStrokes & " | ")
                            keyStrokes = ""
                            keyCount = 0
                        Else
                            keyStrokes = keyStrokes & curKey
                        End If
                    End If
                End If
                If Debugging = True Then
                    Debug.Print("KeyCount: " & keyCount)
                    Debug.Print("Key: " & curKey)
                    Debug.Print("KeyStrokes: " & keyStrokes)
                End If
            End If
        End If
    End Sub




    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click





        If chkExcel.Checked = True Then
            usingExcl = CheckForExcel()
            If usingExcl = False Then
                chkExcel.Checked = False
                chkNotepad.Checked = True
            End If
        End If
        If chkNotepad.Checked = True Then
            txtFeed.AppendText("")
        End If

    End Sub


    Private Function CheckForExcel() As Boolean
        Try
            xlApp = CType(Marshal.GetActiveObject("Excel.Application"), Microsoft.Office.Interop.Excel.Application)
        Catch ex As Exception
            xlApp = New Microsoft.Office.Interop.Excel.Application
        End Try

        Try
            xlBook = xlApp.ActiveWorkbook
            If xlBook Is Nothing Then
                If MessageBox.Show("Couldn't find Excel." & vbCrLf & "Do you want to open a file?", "Error", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    Dim opnFile As New OpenFileDialog
                    If opnFile.ShowDialog = DialogResult.OK Then
                        xlBook = xlApp.Workbooks.Open(opnFile.FileName)
                    Else
                        Try
                            xlBook = xlApp.Workbooks.Add()
                        Catch ex As Exception
                            Debug.Print(ex.ToString)
                        End Try
                    End If
                Else
                    Try
                        xlBook = xlApp.Workbooks.Add()
                    Catch ex As Exception
                        Debug.Print(ex.ToString)
                    End Try
                End If
            End If
        Catch ex As Exception
            xlBook = xlApp.Workbooks.Add
        End Try

        Try
            xlSheet = xlBook.ActiveSheet
        Catch ex As Exception
            xlSheet = xlBook.Sheets.Add
        End Try

        With xlApp
            .UserControl = True
            .Visible = True
        End With

        Debug.Print(xlApp.Name)
        Debug.Print(xlBook.Name)
        Debug.Print(xlSheet.Name)

        If xlSheet.Name.Length > 0 Then
            txtExcel.Text = xlApp.Caption
            txtWorkbook.Text = xlBook.Name
            txtSheet.Text = xlSheet.Name
            Return True
        End If


    End Function



    Private Sub btnNumEnter_Click(sender As Object, e As EventArgs) Handles btnNumEnter.Click
        strFinal = txtFeed.Text.Replace(" | ", ",")
        Clipboard.SetText(strFinal, TextDataFormat.CommaSeparatedValue)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim opnFile As New OpenFileDialog
        Dim filepath
        If opnFile.ShowDialog = DialogResult.OK Then
            filepath = opnFile.FileName
        End If


        Dim myStream = File.Open(filepath, FileMode.Open, FileAccess.Read)

        Dim xconfig As New ExcelDataSetConfiguration
        Dim xtabledata As New ExcelDataTableConfiguration
        Dim Results
        xconfig.UseColumnDataType = True
        xconfig.ConfigureDataTable = Function(tableReader) New ExcelDataTableConfiguration() With {.UseHeaderRow = True, .EmptyColumnNamePrefix = "Column"}

        Using Reader = ExcelDataReader.ExcelReaderFactory.CreateReader(myStream, New ExcelDataReader.ExcelReaderConfiguration())
            Do While Reader.NextResult = True
                Results = Reader.AsDataSet(xconfig)
            Loop

        End Using


        DataSet1 = Results
        DataGridView1.DataSource = Results

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
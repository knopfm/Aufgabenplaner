Imports System.Globalization
Imports System.IO

Public Class Language
    Private innerFile As File
    Private innerLanguage As CultureInfo

    Public Sub New()
        innerLanguage = New CultureInfo("de-DE")
    End Sub

    Public Sub setFile(file As File)
        innerFile = file
    End Sub

    Public Function getFile() As File
        Return innerFile
    End Function

    Public Sub setLanguage(lang As CultureInfo)
        innerLanguage = lang
    End Sub

    Public Function getLanguage() As CultureInfo
        Return innerLanguage
    End Function

    Public Sub loadLanguagePackage()

    End Sub

    Public Sub saveLanguagePackage()

    End Sub

    Public Function getLanguageFiles() As String()

    End Function

    Public Function getTranslation(name As String) As String
        If innerLanguage.Name = "de-DE" Then
            Select Case name
                Case "Day1L"
                    Return "Mo"
                Case "Day2L"
                    Return "Di"
                Case "Day3L"
                    Return "Mi"
                Case "Day4L"
                    Return "Do"
                Case "Day5L"
                    Return "Fr"
                Case "Day6L"
                    Return "Sa"
                Case "Day7L"
                    Return "So"
                Case "TodayLL"
                    Return "Heute"
                Case Else
                    Return ""
            End Select
        ElseIf innerLanguage.name = "en-US" Then
            Select Case name
                Case "Day1L"
                    Return "Mon"
                Case "Day2L"
                    Return "Tue"
                Case "Day3L"
                    Return "Wed"
                Case "Day4L"
                    Return "Thu"
                Case "Day5L"
                    Return "Fri"
                Case "Day6L"
                    Return "Sat"
                Case "Day7L"
                    Return "Sun"
                Case "TodayLL"
                    Return "Today"
                Case Else
                    Return ""
            End Select
        End If
        Return ""
    End Function

    Public Sub setTransaltion(name As String, text As String)

    End Sub
End Class

Imports System.Globalization

Public Class Aufgabenplaner
    'Private lang As CultureInfo = New CultureInfo("en-US") 'CultureInfo.CurrentCulture
    Private lang As CultureInfo = New CultureInfo("de-DE") 'CultureInfo.CurrentCulture
    Private languageManager As New Language

    Private Sub Aufgabenplaner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StatusLBL.Text = "Verbunden"
        setLanguageToGUI(lang)
    End Sub

    Private Sub NeuTSMI_Click(sender As Object, e As EventArgs) Handles NeuTSMI.Click
        Calender1.Month = Now.AddMonths(1)
    End Sub

    Private Sub setLanguageToGUI(lang As CultureInfo)
        languageManager.setLanguage(lang)
        'languageManager.setFile()
        languageManager.loadLanguagePackage()
        Calender1.setLangMgr(languageManager)
        Calender1.setLanguageToGUI()
    End Sub

End Class

'Aufgabe anzeigen
'Kalender
'Details
'Einstellungen
'Server verbinden
'Speichern
'Google Download
'Sprachpaket
'Registry: Einstellungen (Sprache, Größe, 
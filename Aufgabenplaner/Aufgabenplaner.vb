Public Class Aufgabenplaner
    Private lang As String = "DE"
    Private languageManager As New Language

    Private Sub Aufgabenplaner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StatusLBL.Text = "Verbunden"
        setLanguageToGUI(lang)
    End Sub

    Private Sub NeuTSMI_Click(sender As Object, e As EventArgs) Handles NeuTSMI.Click
        MsgBox(DatePart(DateInterval.WeekOfYear, Now, FirstDayOfWeek.System, FirstWeekOfYear.System))
    End Sub

    Private Sub setLanguageToGUI(lang As String)
        languageManager.setLanguage(lang)
        'languageManager.setFile()
        languageManager.loadLanguagePackage()
        Calender1.setLanguageToGUI(languageManager)
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
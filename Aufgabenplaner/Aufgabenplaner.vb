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
        Day1L.Text = languageManager.getTranslation("Day1L")
        Day2L.Text = languageManager.getTranslation("Day2L")
        Day3L.Text = languageManager.getTranslation("Day3L")
        Day4L.Text = languageManager.getTranslation("Day4L")
        Day5L.Text = languageManager.getTranslation("Day5L")
        Day6L.Text = languageManager.getTranslation("Day6L")
        Day7L.Text = languageManager.getTranslation("Day7L")
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

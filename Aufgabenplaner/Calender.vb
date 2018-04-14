Public Class Calender

    Public Sub New()
        InitializeComponent()

    End Sub

    Public Sub setLanguageToGUI(langMgr As Language)

        Day1L.Text = langMgr.getTranslation("Day1L")
        Day2L.Text = langMgr.getTranslation("Day2L")
        Day3L.Text = langMgr.getTranslation("Day3L")
        Day4L.Text = langMgr.getTranslation("Day4L")
        Day5L.Text = langMgr.getTranslation("Day5L")
        Day6L.Text = langMgr.getTranslation("Day6L")
        Day7L.Text = langMgr.getTranslation("Day7L")
    End Sub

    Public Sub addCalenderEntry(item As CalenderEntry)

    End Sub

    Public Sub removeCalenderEntry(item As CalenderEntry)

    End Sub

    Public Function getCalenderEntry(item As CalenderEntry) As String

    End Function

End Class

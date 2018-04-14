Public Class Calender
    Private innerMonth As DateTime
    Private innerCEntrys As List(Of CalenderEntry)
    Private langMgr As Language

    Public Sub New()
        Me.InitializeComponent()
        Month = Now
    End Sub

    Public Sub setLanguageToGUI()
        Day1L.Text = langMgr.getTranslation("Day1L")
        Day2L.Text = langMgr.getTranslation("Day2L")
        Day3L.Text = langMgr.getTranslation("Day3L")
        Day4L.Text = langMgr.getTranslation("Day4L")
        Day5L.Text = langMgr.getTranslation("Day5L")
        Day6L.Text = langMgr.getTranslation("Day6L")
        Day7L.Text = langMgr.getTranslation("Day7L")
        setupMonth()
    End Sub

    Public Sub addCalenderEntry(item As CalenderEntry)

    End Sub

    Public Sub removeCalenderEntry(item As CalenderEntry)

    End Sub

    Public Function getCalenderEntry(item As CalenderEntry) As String

    End Function

    Public Sub setLangMgr(langMgr As Language)
        Me.langMgr = langMgr
    End Sub

    Public Property Month As DateTime
        Get
            Return innerMonth
        End Get
        Set(value As DateTime)
            innerMonth = New DateTime(value.Year, value.Month, 1)
            setupMonth()
        End Set
    End Property

    Private Sub setupMonth()
        Week1L.Text = DatePart(DateInterval.WeekOfYear, innerMonth, FirstDayOfWeek.Monday, FirstWeekOfYear.Jan1)
        Week2L.Text = DatePart(DateInterval.WeekOfYear, innerMonth.AddDays(7), FirstDayOfWeek.Monday, FirstWeekOfYear.Jan1)
        Week3L.Text = DatePart(DateInterval.WeekOfYear, innerMonth.AddDays(14), FirstDayOfWeek.Monday, FirstWeekOfYear.Jan1)
        Week4L.Text = DatePart(DateInterval.WeekOfYear, innerMonth.AddDays(21), FirstDayOfWeek.Monday, FirstWeekOfYear.Jan1)
        If langMgr IsNot Nothing Then
            TodayLL.Text = langMgr.getTranslation("TodayLL") & " " & Now.ToLocalTime.ToShortDateString
            CalenderMonthLL.Text = innerMonth.ToString("MMMMMMMM", langMgr.getLanguage) & " " & innerMonth.ToLocalTime.Year
        Else
            TodayLL.Text = Now.ToLocalTime.ToShortDateString
            CalenderMonthLL.Text = innerMonth.ToString("MMMMMMMM") & " " & innerMonth.ToLocalTime.Year
        End If

    End Sub
End Class
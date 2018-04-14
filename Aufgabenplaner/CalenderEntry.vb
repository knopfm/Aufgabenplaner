Public Class CalenderEntry
    Public CEName As String = "Calender Entry"
    Public CEUser As String = "System"
    Public CEDescribtion As String = ""
    Public CEStartTime As New DateTime
    Public CEEndTime As New DateTime
    Public CEStatus As Integer

    Public Shared Operator =(left As CalenderEntry, right As CalenderEntry) As Boolean
        Return left.CEStartTime = right.CEStartTime And left.CEEndTime = right.CEEndTime
    End Operator

    Public Shared Operator <>(left As CalenderEntry, right As CalenderEntry) As Boolean
        Return left.CEStartTime <> right.CEStartTime And left.CEEndTime <> right.CEEndTime
    End Operator
End Class

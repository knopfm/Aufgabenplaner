Imports System.IO

Public Class TaskListMonth
    'Private innerMonat As Date
    Private innerList As New List(Of TaskDetail)
    Private innerFile As File

    Public Sub setFile(file As File)
        innerFile = file
    End Sub

    Public Function getFile() As File
        Return innerFile
    End Function

    Public Sub loadMonth()

    End Sub

    Public Sub saveMonth()

    End Sub

    Public Function getTask(index As Integer) As TaskDetail
        If index >= 0 And index < getLengh() Then
            Return innerList(index)
        Else
            Throw New IndexOutOfRangeException
        End If
    End Function

    Public Sub setTask(index As Integer, task As TaskDetail)
        If index >= 0 And index < getLengh() Then
            innerList(index) = task
        Else
            Throw New IndexOutOfRangeException
        End If
    End Sub

    Public Function getTaskAtDay(day As DateTime) As List(Of TaskDetail)
        Dim ret As New List(Of TaskDetail)
        For index As Integer = 0 To getLengh() - 1
            If innerList(index).StartDate.Date <= day.Date And innerList(index).EndDate.Date >= day.Date Then
                ret.Add(innerList(index))
            End If
        Next
        Return ret
    End Function

    Public Function getLengh() As Integer
        Return innerList.Count
    End Function

    Public Sub addTask(task As TaskDetail)
        innerList.Add(task)
    End Sub
End Class

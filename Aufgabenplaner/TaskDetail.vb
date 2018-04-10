Public Class TaskDetail

    Public ID As ULong
    Public Name As String
    Public StartDate As DateTime
    Public EndDate As DateTime
    Public Desc As String
    Public User As String
    Public Priority As Integer
    Public Type As TaskTypes
    Public Status As TaskState

    Public Sub New()
        Me.New(0, "Unnamed Task", "New Task without any Settings")
    End Sub

    Public Sub New(ID As ULong, Name As String, Desc As String)
        Me.New(ID, Name, Desc, Now, Now.AddHours(1))
    End Sub

    Public Sub New(ID As ULong, Name As String, Desc As String, StartDate As DateTime, EndDate As DateTime)
        Me.New(ID, Name, Desc, StartDate, EndDate, SystemInformation.UserName)
    End Sub

    Public Sub New(ID As ULong, Name As String, Desc As String, StartDate As DateTime, EndDate As DateTime, User As String)
        Me.New(ID, Name, Desc, StartDate, EndDate, User, 0)
    End Sub

    Public Sub New(ID As ULong, Name As String, Desc As String, StartDate As DateTime, EndDate As DateTime, User As String, Priority As Integer)
        Me.New(ID, Name, Desc, StartDate, EndDate, User, Priority, TaskTypes.Normal)
    End Sub

    Public Sub New(ID As ULong, Name As String, Desc As String, StartDate As DateTime, EndDate As DateTime, User As String, Priority As Integer, Type As TaskTypes)
        Me.New(ID, Name, Desc, StartDate, EndDate, User, Priority, TaskTypes.Normal, TaskState.Info)
    End Sub

    Public Sub New(ID As ULong, Name As String, Desc As String, StartDate As DateTime, EndDate As DateTime, User As String, Priority As Integer, Type As TaskTypes, Status As TaskState)
        Me.ID = ID
        Me.Name = Name
        Me.StartDate = StartDate
        Me.EndDate = EndDate
        Me.Desc = Desc
        Me.User = User
        Me.Priority = Priority
        Me.Type = Type
        Me.Status = Status
    End Sub
End Class
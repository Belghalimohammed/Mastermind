Imports System.Windows.Forms
Imports System.Drawing.Drawing2D
Public Class roundbutt
    Inherits Button
    Protected Overrides Sub OnPaint(pevent As PaintEventArgs)
        Dim graph As GraphicsPath = New GraphicsPath()
        graph.AddEllipse(5, 5, ClientSize.Width - 10, ClientSize.Height - 10)
        Me.Region = New Drawing.Region(graph)
        MyBase.OnPaint(pevent)
    End Sub


End Class

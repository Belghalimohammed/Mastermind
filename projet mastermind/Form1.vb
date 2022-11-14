

Public Class Form1
    Public y As Integer = 4
    Structure gr
        Dim a As System.Windows.Forms.GroupBox
        Dim b As System.Windows.Forms.GroupBox

    End Structure

    Public gt() As gr
    Public n As Integer = 0
    Public color As Drawing.Color
    Public nn As Integer = 1
    Public nt As Integer
    Public nc As Integer
    Public Sub New(a As Integer, b As Integer)

        nt = a
        nc = b
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Function obj(b As System.Windows.Forms.GroupBox, nm As Integer, x As Integer) As projet_mastermind.roundbutt

        Dim a As projet_mastermind.roundbutt
        a = New projet_mastermind.roundbutt


        Me.Controls.Add(a)
        With a
            .Top = 5 + (n * 40)

            .Left = ((40 - x) * nm)
            .Width = 40 - x
            .Height = 40 - x
            .FlatStyle = Windows.Forms.FlatStyle.Flat
            .BackColor = Drawing.Color.White


        End With



        Return a
    End Function
    Public Function grp(n As Integer) As System.Windows.Forms.GroupBox
        Dim a As System.Windows.Forms.GroupBox
        a = New System.Windows.Forms.GroupBox
        Me.Controls.Add(a)
        With a
            .Top = 20 + (50 * n)
            .Left = 50
            .Width = nc * (40)
            .Height = 50
            .FlatStyle = Windows.Forms.FlatStyle.Flat
            .BackColor = Drawing.Color.Transparent


        End With



        For p = 0 To nc - 1
            a.Controls.Add(obj(a, p, 0))
        Next



        ReDim Preserve gt(n)
        gt(n).a = a

        If n = 0 Then

            rand()
        Else
            gt(n).b = hints(n)
        End If



      


        Return a



    End Function
    Public Function hints(n As Integer) As System.Windows.Forms.GroupBox


        Dim a As System.Windows.Forms.GroupBox
        a = New System.Windows.Forms.GroupBox
        Me.Controls.Add(a)
        With a
            .Top = 20 + (50 * n)
            .Left = 220 + ((nc - 4) * 50)
            .Width = nc * 25
            .Height = 50
            .FlatStyle = Windows.Forms.FlatStyle.Flat
            .BackColor = Drawing.Color.Transparent
            .Visible = False

        End With



        For p = 0 To nc - 1
            a.Controls.Add(obj(a, p, 15))
        Next



        Return a
    End Function
    Public Function dbl(t() As Integer, x As Integer) As Boolean

        If t.Length = 0 Then
            Return True
        End If
        For i = 0 To t.Length - 1

            If (x = t(i)) Then
                Return False
            End If
        Next
        Return True

    End Function



    Public Function rantab() As Integer()
        Dim t(nc) As Integer

        Dim w As Random = New Random
        Dim i As Integer
        Dim j As Integer = 0

        For k = 0 To nc - 1
            Do
                i = w.Next(1, 12)

            Loop While dbl(t, i) = False
            Console.WriteLine(2)
            t(j) = i
            j += 1
        Next



        Return (t)
    End Function
    Public Sub rand()


        '  Dim w As Random = New Random
        Dim j As Integer = 0
        Dim t() As Integer = rantab()
        Dim i As Integer

        For Each b As projet_mastermind.roundbutt In gt(0).a.Controls

            ' Dim i As Integer = w.Next(1, 7)

            i = t(j)


            Select Case i
                Case 1 : b.BackColor = Drawing.Color.DarkBlue
                Case 2 : b.BackColor = Drawing.Color.Red
                Case 3 : b.BackColor = Drawing.Color.Blue
                Case 4 : b.BackColor = Drawing.Color.Yellow
                Case 5 : b.BackColor = Drawing.Color.Silver

                Case 6 : b.BackColor = Drawing.Color.Green
                Case 7 : b.BackColor = Drawing.Color.Gray
                Case 8 : b.BackColor = Drawing.Color.Violet
                Case 9 : b.BackColor = Drawing.Color.Maroon
                Case 10 : b.BackColor = Drawing.Color.Tan
                Case 11 : b.BackColor = Drawing.Color.Orchid
                Case 12 : b.BackColor = Drawing.Color.Crimson


            End Select

            j += 1
        Next

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Console.WriteLine(1)
        Dim g As System.Windows.Forms.GroupBox
        g = grp(n) ' random
        gt(0).a.Visible = False

        For i = 1 To nt

            g = grp(i)
            '  n = n + 1

        Next
        n = nt

    End Sub

    Private Sub Roundbutt14_Click(sender As Object, e As EventArgs) Handles Roundbutt8.Click, Roundbutt7.Click, Roundbutt6.Click, Roundbutt4.Click, Roundbutt2.Click, Roundbutt1.Click, Roundbutt9.Click, Roundbutt5.Click, Roundbutt3.Click, Roundbutt12.Click, Roundbutt11.Click, Roundbutt10.Click
        Dim b As projet_mastermind.roundbutt = CType(sender, projet_mastermind.roundbutt)

        color = b.BackColor

        sendcolor()

        If isdone(gt(nn).a) = True Then
            Button1.Enabled = True

        End If

    End Sub
    Public Sub sendcolor()

        Button2.Enabled = True
        ' gt(nn).a.Hide()

        For Each b As projet_mastermind.roundbutt In gt(nn).a.Controls
            If (b.BackColor = Drawing.Color.White) Then
                b.BackColor = color
                Exit Sub
            End If
        Next

    End Sub
    Public Function isdone(gr As System.Windows.Forms.GroupBox) As Boolean
        For Each b As roundbutt In gr.Controls
            If (b.BackColor = Drawing.Color.White) Then
                Return False
            End If
        Next
        Return True
    End Function
    Public Function isempty(gr As System.Windows.Forms.GroupBox) As Boolean
        For Each b As roundbutt In gr.Controls
            If (b.BackColor <> Drawing.Color.White) Then
                Return False
            End If
        Next
        Return True
    End Function
    Private Sub check()
        Dim i As Integer = 1
        Dim j As Integer

        Dim col As Drawing.Color
        For Each a As roundbutt In gt(0).a.Controls
            j = 1
            col = Drawing.Color.White
            For Each b As roundbutt In gt(nn).a.Controls
                If (a.BackColor = b.BackColor) Then
                    If i = j Then
                        col = Drawing.Color.Navy
                    Else
                        If (col <> Drawing.Color.Navy) Then
                            col = Drawing.Color.Red
                        End If

                    End If
                End If
                j += 1
            Next
            If (col <> Drawing.Color.White) Then
                addhint(col)
            End If


            i += 1
        Next

    End Sub
    Private Sub addhint(co As Drawing.Color)
        For Each c As roundbutt In gt(nn).b.Controls
            If (c.BackColor = Drawing.Color.White) Then
                c.BackColor = co
                Exit Sub
            End If
        Next
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        gt(nn).b.Visible = True
        check()
        win()
        loss()
        nn += 1
        Button1.Enabled = False

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button1.Enabled = False




        Dim i As Integer
        For i = nc - 1 To 0 Step -1
            Console.WriteLine(i)
            If gt(nn).a.Controls(i).BackColor <> Drawing.Color.White Then
                gt(nn).a.Controls(i).BackColor = Drawing.Color.White
                If (isempty(gt(nn).a)) Then
                    Button2.Enabled = False

                End If
                Exit Sub

            End If
        Next



    End Sub

    Public Sub win()
        For Each a As roundbutt In gt(nn).b.Controls
            If (a.BackColor <> Drawing.Color.Navy) Then
                Exit Sub
            End If
        Next
        f2.Label1.Text = "you win"
        'MsgBox("you win !!")
        f1.Hide()

    End Sub
    Public Sub loss()
        If (nn = nt) Then
            f2.Label1.Text = "you loose"
            'MsgBox("you win !!")
            f1.Hide()
        End If
        

    End Sub
  
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        f1.Hide()
        f1.Close()
        f1 = New Form1(nt, nc)
        f1.ShowDialog()
    End Sub
End Class
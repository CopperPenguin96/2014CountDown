Public Class frmCountdown

    Dim Show As Boolean

    Private Sub Countdown_Tick(sender As Object, e As EventArgs) Handles Countdown.Tick
        'Assigns the numbers to the variables
        'Repeats due to the Timer Tick
        Dim Days As Integer = 365 - System.DateTime.Now.DayOfYear
        Dim Hours As Integer = 24 - System.DateTime.Now.Hour
        Dim Minutes As Integer = 60 - System.DateTime.Now.Minute
        Dim Seconds As Integer = 60 - System.DateTime.Now.Second
        Dim Milli As Integer = 1000 - System.DateTime.Now.Millisecond
        'Uses the Boolean to determine if the picturebox should be shown or not
        Select Case Show
            Case False
                'Adds the Variables to the Labels text
                lblDays.Text = Days & " Days"
                lblHours.Text = Hours & " Hours"
                lblMinutes.Text = Minutes & " Minutes"
                lblSeconds.Text = Seconds & " Seconds"
                lblHalfSeconds.Text = Milli & " Milliseconds"
                'Sets the text as the variables
                Me.Text = "2014 Countdown ->" & Days & ":" & Hours & ":" & Minutes & ":" & Seconds & ":" & Milli

                If System.DateTime.Today.Year = 2014 Then
                    'Hides the labels and changes the head label's text
                    lblHeader.Text = "Happy New Year!!!!!"
                    lblDays.Hide()
                    lblHours.Hide()
                    lblMinutes.Hide()
                    lblSeconds.Hide()
                    lblHalfSeconds.Hide()
                    'Will start the Case True
                    Show = True
                End If
            Case True
                'Shows the GIF picturebox
                picFireworks.Show()
                'Returns to the application's default set if the year is 2013
                'This is when the user is changing the System's time settings
                If System.DateTime.Today.Year = 2013 Then
                    Show = False
                    picFireworks.Hide()
                    lblHeader.Text = "2014 Countdown"
                    lblDays.Show()
                    lblHours.Show()
                    lblMinutes.Show()
                    lblSeconds.Show()
                    lblHalfSeconds.Show()
                End If
        End Select

    End Sub
End Class

Public Class frmKaraoke
    Private _decSong As Decimal = 2.99D
    Private _decHourlyRate As Decimal = 8.99D
    Private Sub frmKaraoke_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'The frmKaraoke_Load event holds the splash screen for approximately 6 seconds 
        Threading.Thread.Sleep(3000)
        ClearForm()
    End Sub
    Private Function ValidateInput() As Boolean
        'This procedure validate the input 
        Dim intNumber As Integer
        Dim blnValid As Boolean = False
        Try
            'Converts the target amount to an integer value 
            intNumber = Convert.ToInt32(txtTotalHours.Text)
            If intNumber > 0D Then
                blnValid = True
                Return blnValid
            Else
                MsgBox("Please enter a number greater then 0", , "Error")
            End If
        Catch Exception As FormatException
            'This Catch block detects letters, symbols, blank enteries, etc
            MsgBox("Please enter a valid amount", , "Error")
        Catch Exception As OverflowException
            ' This Catch block detects numbers that are too large or too small 
            MsgBox("Please enter a reasonable amount", , "Error")
        Catch Exception As SystemException
            'This Catch block detects a generic exception not acught by earlier Catch blocks 
            MsgBox("Entry invalid. Please enter a valid number representing the number in your party", , "Error")
        End Try
        'Place focus back onto the Textbox
        txtTotalHours.Focus()
        txtTotalHours.Clear()
        Return blnValid
    End Function

    Private Function ComputeSongCost(ByVal intPass As Integer) As Decimal
        Dim decPassCost As Decimal
        decPassCost = intPass * _decSong

        Return decPassCost
    End Function

    Private Function ComputeRoomCost(ByVal intPass As Integer) As Decimal
        Dim decTicketCost As Decimal
        decTicketCost = intPass * _decHourlyRate

        Return decTicketCost
    End Function

    Private Sub btnClearForm_Click(sender As Object, e As EventArgs) Handles btnClearForm.Click
        'The btnClear click event clears the form 
        ClearForm()
    End Sub

    Private Sub ClearForm()
        'Clears the form
        cboComboBox.SelectedIndex = -1
        lblTotalCost.Visible = False
        txtTotalHours.Visible = False
        btnTotalCost.Visible = False
        btnTotalCost.Visible = False
        btnClearForm.Visible = False
        lblHourlyRentalRoom.Visible = False
        txtTotalHours.Clear()
    End Sub

    Private Sub btnTotalCost_Click(sender As Object, e As EventArgs) Handles btnTotalCost.Click
        Dim blnAmountIsValid As Boolean = False
        Dim intValue As Integer
        Dim decTotal As Decimal

        ' A function procedure is called to avlidate the value entered 
        blnAmountIsValid = ValidateInput()
        If blnAmountIsValid = True Then
            'Input is assigned to variable
            intValue = Convert.ToInt32(txtTotalHours.Text)
            If cboComboBox.SelectedIndex = 0 Then
                decTotal = ComputeSongCost(intValue)
            Else
                decTotal = ComputeRoomCost(intValue)
            End If

            lblTotalCost.Visible = True
            lblTotalCost.Text = "Total Cost of Karaoke Night - " & decTotal.ToString("C")
        End If

    End Sub

    Private Sub cboComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboComboBox.SelectedIndexChanged
        'The cboSelectAction SelectedIndexChanged event places the objects on the form
        If cboComboBox.SelectedIndex = 0 Then
            lblHourlyRentalRoom.Text = "Number of Karaoke Songs: "
            lblHourlyRentalRoom.Visible = True
            txtTotalHours.Visible = True
            btnTotalCost.Visible = True
            btnClearForm.Visible = True
            'Place focus on the textbox
            txtTotalHours.Focus()
        End If
        If cboComboBox.SelectedIndex = 1 Then
            lblHourlyRentalRoom.Text = "Hourly Rental Karaoke Room: "
            lblHourlyRentalRoom.Visible = True
            txtTotalHours.Visible = True
            btnTotalCost.Visible = True
            btnClearForm.Visible = True
            'Place focus on textbox
            txtTotalHours.Focus()
        End If
    End Sub
End Class

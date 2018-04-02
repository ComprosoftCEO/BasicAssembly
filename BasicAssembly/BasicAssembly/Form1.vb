Imports System.IO

Public Class MainForm

    Dim MemoryArrayInteger(1000) As Integer         'Array that stores all commands in your code
    Dim TempMemoryArrayInteger(1000) As Integer     'Temporary array that can be modified during runtime
    Dim programPosition As Integer = 0              'The current position in the code

    Dim Running As Boolean = False                  'Whether or not the program is running
    Dim Started As Boolean = False                  'Has the code been started yet
    Dim Input As Boolean = False

    Dim Accumulator As Integer = 0                  'Accumulator
    Dim Bakup As Integer = 0                        'Bakup
    Dim OverFlow As Boolean = False                 'Overflow

    'Form load
    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Set all default values to 0 and output values into list box
        MemoryListBox.Items.Clear()
        For i = 0 To 999 Step 1
            MemoryArrayInteger(i) = 0
            MemoryListBox.Items.Add(i.ToString("d3") & " : " & 0)
        Next

        MemoryListBox.SelectedIndex = 0

    End Sub

    'Update the selected memory address
    Private Sub UpdateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateButton.Click


        If Input = False Then
            'Update the array
            MemoryArrayInteger(MemoryListBox.SelectedIndex) = NumericUpDown.Value

            MemoryListBox.Items.Item(MemoryListBox.SelectedIndex) = MemoryListBox.SelectedIndex.ToString("d3") & " : " & MemoryArrayInteger(MemoryListBox.SelectedIndex)

            If MemoryListBox.SelectedIndex < 999 Then MemoryListBox.SelectedIndex += 1
        Else
            'Input the selected value
            Accumulator = NumericUpDown.Value

            'Disable the buttons
            UpdateButton.Visible = False
            UpdateButton.Enabled = False
            NumericUpDown.Enabled = False
            NumericUpDown.Visible = False

            'Show a console message
            OutputTextBox.AppendText(Accumulator & Environment.NewLine)

            UpdateText()
            NextPosition()

            'Turn off input mode
            Input = False
        End If
    End Sub

    'Update the value of the Numeric Up and Down
    Private Sub MemoryListBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MemoryListBox.SelectedIndexChanged

        If Running = True Then
            MemoryListBox.SelectedIndex = programPosition
        End If

        If Input = False Then
            If Not MemoryListBox.SelectedIndex = -1 Then
                NumericUpDown.Value = MemoryArrayInteger(MemoryListBox.SelectedIndex)
            End If
        End If
    End Sub

    'Run the program
    Private Sub RunButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RunButton.Click

        If Running = False Then
            StartProgram()
        Else

            OutputTextBox.AppendText("Terminated Early")
            StopProgram()

        End If
    End Sub


    'Start the program
    Sub StartProgram()
        'Set the starting positin
        programPosition = 0
        MemoryListBox.SelectedIndex = 0

        'Clear the output
        OutputTextBox.Clear()

        'Disable buttons
        UpdateButton.Enabled = False
        NumericUpDown.Enabled = False
        UpdateButton.Visible = False
        NumericUpDown.Visible = False
        RunButton.Text = "Stop"
        FormMenuStrip.Enabled = False

        'Reset Variables
        Accumulator = 0
        Bakup = 0
        OverFlow = False
        Input = False


        'Create the temporary array and reset the code
        For i = 0 To 999 Step 1
            TempMemoryArrayInteger(i) = MemoryArrayInteger(i)
        Next

        'Start the timer
        Running = True
        RunTimer.Enabled = True
        Started = True

        'Update the text
        UpdateText()

    End Sub

    'All Program Commands
    Private Sub RunTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RunTimer.Tick

        'Make sure the input method insn't activated
        If Input = False Then
            'Update the selected index to show where the computer is in the code
            MemoryListBox.SelectedIndex = programPosition

            'Run the commands
            Select Case TempMemoryArrayInteger(programPosition)
                Case 0
                    BRK()
                Case 1
                    JMP()
                Case 2
                    JRF()
                Case 3
                    JRB()
                Case 4
                    LDA()
                Case 5
                    STA()
                Case 6
                    LDB()
                Case 7
                    STB()
                Case 8
                    SAV()
                Case 9
                    SWP()
                Case 10
                    ADD()
                Case 11
                    SUBB()
                Case 12
                    ABK()
                Case 13
                    SBK()
                Case 14
                    JEZ()
                Case 15
                    JNZ()
                Case 16
                    JOV()
                Case 17
                    INN()
                Case 18
                    INT()
                Case 19
                    CHRR()
                Case 20
                    BEP()
                Case 21
                    RNDD()
                Case 999
                    NextPosition()
                Case Else
                    'Output a message that the command isn't recognized
                    OutputTextBox.AppendText("Unknown Command: " & TempMemoryArrayInteger(programPosition) & Environment.NewLine)

                    'Move to the next position in the code
                    NextPosition()

            End Select

        End If
    End Sub

    'Increase the position in the program
    Sub NextPosition()

        If programPosition < 999 Then programPosition += 1 Else programPosition = 0
        MemoryListBox.SelectedIndex = programPosition

    End Sub

    'Stop the program
    Sub StopProgram()
        'Enable buttons
        UpdateButton.Text = "Update"
        UpdateButton.Enabled = True
        NumericUpDown.Enabled = True
        UpdateButton.Visible = True
        NumericUpDown.Visible = True
        RunButton.Text = "Run"
        FormMenuStrip.Enabled = True

        'Disable status variables
        Running = False
        Input = False


        'Reset the code
        MemoryListBox.Items.Clear()
        For i = 0 To 999 Step 1
            MemoryListBox.Items.Add(i.ToString("d3") & " : " & MemoryArrayInteger(i))
        Next

        MemoryListBox.SelectedIndex = 0

        'Stop the timer
        RunTimer.Enabled = False

    End Sub

    'Updates the status text
    Sub UpdateText()

        AccumulatorOutput.Text = Accumulator.ToString("d3")
        BakupOutput.Text = Bakup.ToString("d3")
        OverflowOutput.Text = OverFlow.ToString()

    End Sub



    '------------Assembly Opcodes---------------
    'BRK (00) - Kill the program
    'JMP (01) - Jump to new position in code
    'JRF (02) - Jump relative position forward
    'JRB (03) - Jump relative position backwards
    'LDA (04) - Load number into accumulator
    'STA (05) - Store accumulator into memory slot
    'LDB (06) - Load bakup from memory slot indicated by accumulator
    'STB (07) - Store bakup into memory slot indicated by accumulator
    'SAV (08) - Save accumulator into bakup
    'SWP (09) - Swap accumulator and bakup
    'ADD (10) - Add value to accumulator
    'SUB (11) - Subtract value from accumulator
    'ABK (12) - Add bakup to accumulator
    'SBK (13) - Subtract bakup from accumulator
    'JEZ (14) - Jump to new position if accumulator = 0
    'JNZ (15) - Jump to new position if accumulator is not equal to 0
    'JOV (16) - Jump if there was an overflow when adding or subtracting
    'IN  (17) - Get user input as integer (0 - 999)
    'INT (18) - Export the value of accumulator to the console
    'CHR (19) - Export the value of accumulator as string (0 = enter)
    'BEP (20) - Play beep sound
    'RND (21) - Set accumulator to random number from 0 to 999
    'NOP (xx) - Do nothing

    Sub BRK()
        'Tell where the program was terminated
        OutputTextBox.AppendText("Terminated at " & programPosition.ToString("d3"))
        StopProgram()
    End Sub

    Sub JMP()
        'Move the cursor to the next position in the code and fine the memory address to jump to
        NextPosition()
        programPosition = TempMemoryArrayInteger(programPosition)
        MemoryListBox.SelectedIndex = programPosition
    End Sub

    Sub JRF()
        'Get the value of the next memory address
        NextPosition()
        Dim AddVal = TempMemoryArrayInteger(programPosition)

        'Add this value to the program position
        programPosition = (programPosition + AddVal) Mod 1000

        NextPosition()

    End Sub

    Sub JRB()
        'Get the value of the next memory address
        NextPosition()
        Dim SubVal = TempMemoryArrayInteger(programPosition)

        'Add this value to the program position
        If (programPosition - SubVal - 1) >= 0 Then
            programPosition -= (SubVal + 1)
        Else
            programPosition = programPosition - SubVal + 1000 - 1
        End If

    End Sub

    Sub LDA()
        'Find the value of the next memory slot
        NextPosition()
        Accumulator = TempMemoryArrayInteger(programPosition)

        'Update text and move to the next position
        UpdateText()
        NextPosition()
    End Sub

    Sub STA()
        'Find the value of the next memory slot
        NextPosition()
        Dim NewPos = TempMemoryArrayInteger(programPosition)

        'Store the accumultor in the modifiable memory slot and update the list box
        TempMemoryArrayInteger(NewPos) = Accumulator
        MemoryListBox.Items.Item(NewPos) = NewPos.ToString("d3") & " : " & TempMemoryArrayInteger(NewPos)

        'Move to the next position in the code
        NextPosition()
    End Sub

    Sub LDB()
        'Find the value at the memory slot at location acc
        Bakup = TempMemoryArrayInteger(Accumulator)

        'Update text and move to the next position
        UpdateText()
        NextPosition()
    End Sub

    Sub STB()
        'Store the accumultor in the memory slot indicated by acc
        TempMemoryArrayInteger(Accumulator) = Bakup
        MemoryListBox.Items.Item(Accumulator) = Accumulator.ToString("d3") & " : " & TempMemoryArrayInteger(Accumulator)

        'Move to the next position in the code
        NextPosition()
    End Sub

    Sub SAV()
        'Bakup equals accumulator
        Bakup = Accumulator

        'Move to next position in code and update the text
        UpdateText()
        NextPosition()

    End Sub

    Sub SWP()
        'Define temporary variable to hold value of acc
        Dim TempVar = Accumulator

        'Update accumulator and bakup
        Accumulator = Bakup
        Bakup = TempVar

        'Move to the next position in code
        UpdateText()
        NextPosition()
    End Sub

    Sub ADD()
        'Find the next value in the code
        NextPosition()
        Dim TempAdd = TempMemoryArrayInteger(programPosition)

        'Make sure there isn't an overflow
        If (Accumulator + TempAdd) <= 999 Then
            Accumulator += TempAdd
            OverFlow = False
        Else
            Accumulator = (Accumulator + TempAdd) - 1000
            OverFlow = True
        End If

        'Update the text and move to the next position
        UpdateText()
        NextPosition()

    End Sub

    Sub SUBB()
        'Find the next value in the code
        NextPosition()
        Dim TempSub = TempMemoryArrayInteger(programPosition)

        'Make sure there isn't an overflow
        If (Accumulator - TempSub) >= 0 Then
            Accumulator -= TempSub
            OverFlow = False
        Else
            Accumulator = Accumulator - TempSub + 1000
            OverFlow = True
        End If

        'Update the text and move to the next position
        UpdateText()
        NextPosition()

    End Sub

    Sub ABK()
        'Get the value of bakup
        Dim TempAdd = Bakup

        'Make sure there isn't an overflow
        If (Accumulator + TempAdd) <= 999 Then
            Accumulator += TempAdd
            OverFlow = False
        Else
            Accumulator = (Accumulator + TempAdd) - 1000
            OverFlow = True
        End If

        'Update the text and move to the next position
        UpdateText()
        NextPosition()
    End Sub

    Sub SBK()
        'Get the value of Bakup
        Dim TempSub = Bakup

        'Make sure there isn't an overflow
        If (Accumulator - TempSub) >= 0 Then
            Accumulator -= TempSub
            OverFlow = False
        Else
            Accumulator = Accumulator - TempSub + 1000
            OverFlow = True
        End If

        'Update the text and move to the next position
        UpdateText()
        NextPosition()


    End Sub

    Sub JEZ()

        'Test if accumulator is equal to 0
        If Accumulator = 0 Then
            JMP()
        Else
            'Move along as normal
            NextPosition()
            NextPosition()
        End If

    End Sub

    Sub JNZ()
        'Test if accumulator is equal to 0
        If Not Accumulator = 0 Then
            JMP()
        Else
            'Move along as normal
            NextPosition()
            NextPosition()
        End If

    End Sub

    Sub JOV()
        'Test if accumulator is equal to 0
        If OverFlow = True Then
            JMP()
        Else
            'Move along as normal
            NextPosition()
            NextPosition()
        End If
    End Sub

    Sub INN()
        'Turn on input
        Input = True

        'Enable the input buttons
        UpdateButton.Text = "Input"
        UpdateButton.Enabled = True
        UpdateButton.Visible = True
        NumericUpDown.Enabled = True
        NumericUpDown.Visible = True

        NumericUpDown.Value = 0

        'Show console message
        OutputTextBox.AppendText("Get user input: ")

    End Sub

    Sub INT()

        'Update the output text and move to next position
        OutputTextBox.AppendText(Accumulator.ToString & Environment.NewLine)
        NextPosition()

    End Sub

    Sub CHRR()
        'Output string of acc (0 = enter)
        If Accumulator = 0 Then
            OutputTextBox.AppendText(Environment.NewLine)
        ElseIf Accumulator > 31 And Accumulator < 127 Then
            OutputTextBox.AppendText(Chr(Accumulator))
        Else
            OutputTextBox.AppendText("Unknown Character: " & Accumulator & Environment.NewLine)
        End If

        'Move to next position in code
        NextPosition()
    End Sub

    Sub BEP()
        Console.Beep(2000, 100)
        System.Threading.Thread.Sleep(500)
        NextPosition()
    End Sub

    Sub RNDD()
        Accumulator = Math.Floor(Rnd() * 1000)

        'Next position and update text
        UpdateText()
        NextPosition()
    End Sub

    'Load program from text document
    Private Sub LoadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadToolStripMenuItem.Click

        'The program reads each line in the text document. All symbols between ; are ignored. The first 3 number
        'not enclosed in ; ; become the number for that line in the program

        'Show the file dialog
        If OpenTextFileDialog.ShowDialog() = DialogResult.OK Then

            'First, reset the program array
            For i = 0 To 999 Step 1
                MemoryArrayInteger(i) = 0
            Next


            'Define IO Stream reader and list of each line in program
            Dim TextFile As New StreamReader(OpenTextFileDialog.FileName)
            Dim Lines As New List(Of String)

            'The current line
            Dim CurrentLine As String = TextFile.ReadLine

            'Loop through every line to get all lines
            Do While (Not CurrentLine Is Nothing)
                Lines.Add(CurrentLine)

                CurrentLine = TextFile.ReadLine
            Loop

            'Close the StreamReader
            TextFile.Close()

            Dim ArrayPosition As Integer = 0            'Position in the program array

            'Now loop through each line as a string
            For Each ln As String In Lines

                'Define variable
                Dim Comment As Boolean
                Dim Numbers As Integer
                Dim FinalNumber As Integer


                Comment = False
                Numbers = 0
                FinalNumber = 0

                'Loop through each character
                For Each c As Char In ln
                    Select Case c
                        Case ";"
                            'Semicolon is comment part of code
                            If Comment = False Then Comment = True Else Comment = False

                        Case "0", "1", "2", "3", "4", "5", "6", "7", "8", "9"
                            'If the comment is turned off, read the number if the max digits hasn't been exceeded
                            If (Comment = False And Numbers < 3) Then

                                'Move all digits over one space to the left
                                FinalNumber *= 10
                                FinalNumber += Convert.ToInt16(c.ToString())

                                'Keep track of the numbers of numbers
                                Numbers += 1
                            End If

                    End Select
                Next

                'After the line is processed, move the value into the array
                If (Numbers > 0 And ArrayPosition <= 999) Then
                    MemoryArrayInteger(ArrayPosition) = FinalNumber
                    ArrayPosition += 1
                End If

            Next

            'Finally, export the array to the listbox
            MemoryListBox.Items.Clear()

            For i = 0 To 999 Step 1
                MemoryListBox.Items.Add(i.ToString("d3") & " : " & MemoryArrayInteger(i))
            Next

            MemoryListBox.SelectedIndex = 0

            'Update the output text
            OutputTextBox.Clear()
            OutputTextBox.AppendText("Program loaded." & Environment.NewLine)

        End If

    End Sub

    'Save the program to a text document
    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click

        'Prompt the user to save to a file
        If SaveTextFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then

            'Pick how much of the program to export
RepickExport:
            Dim Export = InputBox("How much of the program do you wish to export" & Environment.NewLine & "Memory slot 0 to (0 - 999) inclusive", "How much to export:", 999)
            Dim ExportNumber As Integer

            If Export <> "" Then

                Try

                    ExportNumber = Convert.ToInt32(Export)

                    If ExportNumber < 0 Or ExportNumber > 999 Then
                        MessageBox.Show("Please enter a valid number between 0 and 999", "Enter Valid Number", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        GoTo RepickExport
                    End If
                    
                Catch ex As Exception
                    MessageBox.Show("Please enter a valid number.", "Enter valid number", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                GoTo RepickExport
            End Try

                'Define a stream writer to save the file
                Dim TextFile As New StreamWriter(SaveTextFileDialog.FileName)

                'Write all of the memory into the file
                For i = 0 To ExportNumber
                    TextFile.WriteLine(";" & i.ToString("d3") & "; " & MemoryArrayInteger(i))
                Next

                'At the end, close the file
                TextFile.Close()

                'Update the output text
                OutputTextBox.Clear()
                OutputTextBox.AppendText("Program saved.")

            End If

            End If
    End Sub




    'Update text color
    Private Sub TextColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextColorToolStripMenuItem.Click
        'Show the color dialog and update the text color of all controls
        If ColorDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.ForeColor = ColorDialog.Color
            MemoryListBox.ForeColor = ColorDialog.Color
            OutputTextBox.ForeColor = ColorDialog.Color
            NumericUpDown.ForeColor = ColorDialog.Color
        End If
    End Sub

    'Background Color
    Private Sub BackgroundColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackgroundColorToolStripMenuItem.Click
        'Show the color dialog and update the background color of all controls
        If ColorDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.BackColor = ColorDialog.Color
            MemoryListBox.BackColor = ColorDialog.Color
            OutputTextBox.BackColor = ColorDialog.Color
            NumericUpDown.BackColor = ColorDialog.Color
        End If

    End Sub

    Private Sub ResetColorsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetColorsToolStripMenuItem.Click
        'Reset all form colors
        If MessageBox.Show("Reset all colors?", "Reset Colors?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            'Text color
            Me.ForeColor = Color.Lime
            MemoryListBox.ForeColor = Color.Lime
            OutputTextBox.ForeColor = Color.Lime
            NumericUpDown.ForeColor = Color.Lime

            'Back color
            Me.BackColor = Color.Black
            MemoryListBox.BackColor = Color.Black
            OutputTextBox.BackColor = Color.Black
            NumericUpDown.BackColor = Color.Black

        End If




    End Sub

    'Clear program
    Private Sub ClearAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearAllToolStripMenuItem.Click

        If MessageBox.Show("Clear entire program?", "Clear Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            'Set all default values to 0 and output values into list box
            MemoryListBox.Items.Clear()
            For i = 0 To 999 Step 1
                MemoryArrayInteger(i) = 0
                MemoryListBox.Items.Add(i.ToString("d3") & " : " & 0)
            Next

            MemoryListBox.SelectedIndex = 0

        End If

    End Sub

    'Overclock button
    Private Sub OverclockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OverclockToolStripMenuItem.Click

RepickClockSpeed:
        Dim NewClock = InputBox("Input new clock speed (in milliseconds)", "Input new clock speed", 100)

        If NewClock <> "" Then

            Try

                RunTimer.Interval = Convert.ToInt32(NewClock)


            Catch ex As Exception
                MessageBox.Show("Please enter a valid clock speed.", "Enter valid clock speed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                GoTo RepickClockSpeed
            End Try

        End If

    End Sub
End Class

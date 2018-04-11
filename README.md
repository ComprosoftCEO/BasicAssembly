# Basic Assembly
Interactive programming GUI for a simplified assembly language

<br>

## About
The Basic Assembly Computer is a simulation of a "fake" microprocessor, designed to teach assembly and low-level programming concepts. Instructions are stored as integers in RAM and entered using the memory editor. User interaction occurs using the terminal and number input control. Labels are also provided to display the registers and flags of the computer to track the internal state of the processor.

<br>

## Hardware Specifications
### "Bytes"
Unlike bytes in a normal computer, which are 8-bits long and store numbers from 0 to 255, "bytes" in the Basic Assembly Computer store numbers from 0 to 999. Like a normal computer, adding 1 to 999 overflows to 0, and subtracting 1 from 0 underflows to 999 (both also set the overflow flag).
### Memory
The Basic Assembly Computer has a total of 1000 memory slots (labeled 000 to 999). Each memory slot holds one "byte," which can be interperted as an instruction or used as raw data.
### Registers
* __Accumulator__ - Handles all math operations, such as adding and subtracting
* __Backup__ - Used to load indirect data when the address is stored in the Accumulator
* __Program Counter__ - Indicates the current instruction to execute in memory
### Flags
* __Overflow Flag__ - Set if the last math operation (adding or subtracting) resulted in an overflow or underflow. Otherwise, this flag is not set.

<br>

## Instruction Set
Instructions in the Basic Assembly Computer are represented as integers. The following table lists all allowed instructions in the computer: (Note that some instructions take up two "bytes")

| Integer | Opcode | Argument | Description |
|:------- |:------ |:-------- |:----------- |
| 0  | BRK | | Kill the program (stop all execution) |
| 1  | JMP | \<POS\> | Jump to memory slot \<POS\> and continue execution |
| 2  | JRF | \<COUNT\> | Jump \<COUNT\> memory slots forward |
| 3  | JRB | \<COUNT\> | Jump \<COUNT\> memory slots backwards |
| 4  | LDA | \<NUMBER\> | Load \<NUMBER\> into the Accumulator  |
| 5  | STA | \<MEMORY\> | Store the Accumulator into the memory slot \<MEMORY\> |
| 6  | LDB | | Load the Backup register with the integer stored in the memory slot \<Accumulator\> |
| 7  | STB | | Store the Backup register into the memory slot indicated by \<Accumulator\>  |
| 8  | SAV | | Save the Accumulator into the Backup register |
| 9  | SWP | | Swap the Accumulator and Backup registers |
| 10 | ADD\*\* | \<VALUE\> | Add \<VALUE\> to the Accumulator |
| 11 | SUB\*\* | \<VALUE\> | Subtract \<VALUE\> from the Accumulator |
| 12 | ABK\*\* | | Add the Backup register to the Accumulator |
| 13 | SBK\*\* | | Subtract the Backup register from the Accumulator |
| 14 | JEZ | \<POS\> | Jump to memory slot \<POS\> if the Accumulator is equal to 0 |
| 15 | JNZ | \<POS\> | Jump to memory slot \<POS\> if the Accumulator is not equal to 0  |
| 16 | JOV | \<POS\> | Jump to memory slot \<POS\> if the Overflow Flag is set |
| 17 | IN  | | Get user input as an integer |
| 18 | INT | | Output the value of the Accumulator to the console as an integer (0 to 999) |
| 19 | CHR | | Output the value of the Accumulator to the console as an [ASCII character](https://www.asciitable.com/). Valid characters are 32 to 126, and 0 = new line. |
| 20 | BEP | | Play a short "beep" sound  |
| 21 | RND | | Set accumulator to a random number from 0 to 999 |
| 22 | NOP | | Do Nothing |
| 23 to 999| ??? | | Unknown Command |

\*\* = Instruction Modifies Overflow Flag

<br>

## Program Execution
After a program is loaded into the Basic Assembly Computer, click the "Run" button to begin execution. The program __always__ starts executing in memory slot 0. While the program is running, it can be stopped prematurely by clicking the "Stop" button.

<br>

## Input and Output
When the IN command is executed, the program temporarily pauses execution to wait for user input. The control used to input data into memory becomes active, but the button below reads "Input". This is correct behavior. To input numerical data into the computer, type the number (0 to 999) into the number box and click "Input".

Output data is displayed in the terminal window under "Output" and can be scrolled to see prior results from the program.

<br>

## Saving and Loading Files
Basic Assembly programs can be stored to text files for later use. The format for text files is as follows:
* All text between semicolons ; is ignored (like a comment)
* The first digits (0 to 9), up to a total of 3 digits, are parsed as the "data" for that line. Lines with no digits are ignored (empty line).
* The parsed data fill slots sequentially, starting at memory slot 0 and increasing

<br>

## Customization
The colors of the Basic Assembly Computer can be customized using the Edit tab. Modify the text color or the background color using the "Text Color" and "Background Color" options on the toolbar.

<br>

## Overclocking
Basic Assembly instructions are executed using a Visual Basic timer object. By default, the timer delay is set to 100 milliseconds. However, you can "overclock" or "underclock" the Basic Assembly Computer by modifying the timer delay. Click on the "Overclock" option under the Edit menu on the toolbar to change the clock speed.

<br>

## Things I Would Still Like To Do:
* Write a full-blown assembler for reading Basic Assembly files
* Find a better system for implementing the Basic Assembly Computer and instruction set
* Dropdown or interface to enter commands by opcode (instead of using the integer)
* Add more commands

<br>

## Other Notes
Basic Assembly was inspired by the computer game [TIS-100](http://www.zachtronics.com/tis-100/), one of my all-time favorite programming games.

1. Create the File

The program creates a file named Home.txt using File.CreateText() and writes information into it using WriteLine().

File name: Home.txt

2. Creating a New File Using Path

The program creates khk.txt at a specific location using an absolute file path.

File path:
C:\Users\dhaaf\Downloads\output\khk.txt

The program writes three lines of text into the file.

Note: The output folder must exist before creating the file.

3.### Read the File

The program uses StreamReader, File.OpenText(), and ReadLine() to read the file line by line.

The while loop continues reading until the end of the file. The contents are displayed in listBox1.

4. ####Delete the File

The program uses File.Delete() to delete the entire khk.txt file.

File.Exists() checks whether the file exists before attempting to delete it.

5.### Reading Using Other Functions

The program uses File.ReadAllLines() to read all lines from the file at once.

A foreach loop displays each line in listBox1.

6. ###Delete an Item from the ListBox

The program uses listBox1.Items.Remove() to remove the selected item from the ListBox.

This operation removes the displayed item only; it does not delete the original file or modify its contents.

C# Methods Used

Method

Purpose

File.CreateText()

Creates a text file and opens it for writing.

WriteLine()

Writes text into a file.

File.OpenText()

Opens a text file for reading.

ReadLine()

Reads one line from a file.

File.ReadAllLines()

Reads all lines from a file into an array.

File.Exists()

Checks whether a file exists.

File.Delete()

Deletes a file.

Items.Add()

Adds an item to a ListBox.

Items.Remove()

Removes a selected item from a ListBox.

Conclusion

This assignment demonstrates the basic file handling features of C#. It provides practical experience in creating files, writing and reading data, deleting files, and managing ListBox items in a Windows Forms application.
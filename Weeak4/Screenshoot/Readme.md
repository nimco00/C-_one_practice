# C# Code Documentation – Additional Examples

## Introduction

This document provides detailed explanations of additional C# programming examples. These examples demonstrate important programming concepts, including logical operators, file creation, file writing, file reading, and file handling in Windows Forms applications.

The purpose of this documentation is to explain how each code example works and how it can be used in a C# application.

---

## 1. AND Operator (`&&`)

### Overview
The AND operator (`&&`) is a logical operator in C# that checks whether two or more conditions are true. It returns `true` only when all conditions are satisfied.

### Code Function
This example uses the AND operator to validate whether the number of courses is between 1 and 8.

The condition:

`course >= 1 && course <= 8`

checks two things:

- `course >= 1`: Checks whether the course value is greater than or equal to 1.
- `course <= 8`: Checks whether the course value is less than or equal to 8.

Both conditions must be true for the program to execute the statements inside the `if` block.

### Nested If-Else Statements
Inside the main condition, nested `if-else if` statements check the student's academic level and calculate the tuition fee.

- **Level 1:** The number of courses is multiplied by 40.
- **Level 2:** The number of courses is multiplied by 45.

### Example
If a student selects 4 courses:

- Level 1: 4 × 40 = 160
- Level 2: 4 × 45 = 180

### Key Concepts
- Logical AND operator (`&&`)
- Conditional statements (`if`, `else if`)
- Nested conditional statements
- Validation of input values
- Mathematical calculations

---

## 2. Create File (`StreamWriter`)

### Overview
This example demonstrates how to create a new text file and write information into it using C# file handling techniques.

C# provides the `System.IO` namespace, which contains classes and methods for working with files.

### Code Function
The example uses `File.CreateText()` to create a new text file named `php.txt`.

The following steps explain how the code works:

**1. Create a StreamWriter object**

The variable `output_file1` is used to store the StreamWriter object.

**2. Create the file**

`File.CreateText("php.txt")`

This method creates a new text file named `php.txt`. If the file already exists, its previous contents are overwritten.

**3. Write information**

`WriteLine()` is used to write text into the file.

The example writes two lines of information into the file.

**4. Close the file**

`Close()` closes the file connection after writing is completed.

### Example Code

```csharp
StreamWriter output_file1;

output_file1 = File.CreateText("php.txt");

output_file1.WriteLine("First Line");
output_file1.WriteLine("Second Line");

output_file1.Close();
```

### Key Concepts
- File creation
- `StreamWriter` class
- `File.CreateText()` method
- `WriteLine()` method
- `Close()` method
- `System.IO` namespace

---

## 3. Read File (`StreamReader`)

### Overview
This example demonstrates how to read information from an existing text file using the `StreamReader` class.

It reads the file character by character and displays the information inside a Windows Forms `ListBox` control.

### Code Function
The program uses `File.OpenText()` to open the text file for reading.

The following steps explain the process:

**1. Declare a StreamReader object**

A `StreamReader` object is used to read text from the file.

**2. Open the file**

`File.OpenText()` opens the specified text file and prepares it for reading.

**3. Check the end of the file**

The `while` loop uses `EndOfStream` to check whether the end of the file has been reached.

**4. Read characters**

The `Read()` method reads one character at a time and returns its numeric character value.

The value is converted into a `char` data type.

**5. Display the characters**

`listBox1.Items.Add()` adds each character to the ListBox control.

**6. Close the file**

`Close()` closes the StreamReader after reading is completed.

### Key Concepts
- `StreamReader` class
- `File.OpenText()` method
- `while` loop
- `EndOfStream` property
- `Read()` method
- Character conversion (`char`)
- ListBox control
- `Close()` method

---

## 4. Read All Text (`File.ReadAllText`)

### Overview
This example demonstrates a simple way to read the complete contents of a text file using the `File.ReadAllText()` method.

Unlike the StreamReader example, this method reads the entire file at once without requiring a loop.

### Code Function
The program uses `File.ReadAllText()` to read all text from a specified file and display it inside a ListBox control.

### How It Works

**1. Open and read the file**

`File.ReadAllText()` reads the complete contents of the specified text file and returns the contents as a string.

**2. Store the information**

The returned text can be stored in a string variable or used directly.

**3. Display the information**

`listBox1.Items.Add()` adds the complete text to the ListBox as one item.

**4. Automatic file closing**

The method automatically closes the file after reading, so there is no need to manually call `Close()`.

### Example Code

```csharp
string content;

content = File.ReadAllText("php.txt");

listBox1.Items.Add(content);
```

### Key Concepts
- `File.ReadAllText()` method
- Reading complete file contents
- String data type
- ListBox control
- Simplified file handling
- Automatic file closing

---

## 5. Comparison of File Handling Methods

The following table compares the file handling methods demonstrated in these examples.

| Method | Purpose | Description |
|---|---|---|
| `File.CreateText()` | Create a file | Creates a text file for writing |
| `StreamWriter` | Write data | Writes text into a file |
| `File.OpenText()` | Open a file | Opens a text file for reading |
| `StreamReader` | Read data | Reads text from a file |
| `File.ReadAllText()` | Read all text | Reads the entire file at once |
| `WriteLine()` | Write a line | Writes text followed by a new line |
| `Read()` | Read a character | Reads one character at a time |
| `Close()` | Close a file | Closes the file connection |

---

## 6. Important Notes

- Always include `using System.IO;` when working with file handling classes and methods.
- Make sure the file exists before attempting to read it.
- `File.CreateText()` creates a new file or overwrites an existing file.
- `StreamReader` is useful when reading data step by step.
- `File.ReadAllText()` is convenient when the entire file contents are needed.
- Always close file connections when using StreamReader or StreamWriter directly.
- File paths determine where files are created and where the program searches for existing files.

---

## Conclusion

These additional C# examples demonstrate essential programming concepts and file handling techniques.

The AND operator helps validate multiple conditions, while the file handling examples demonstrate how to create, write, and read text files.

Understanding these methods is important for developing C# applications that process information, manage files, and display data through Windows Forms controls.

**Topics Covered:**
1. Logical AND Operator (`&&`)
2. File Creation
3. Writing Text Files
4. Reading Files Using StreamReader
5. Reading Complete Files Using File.ReadAllText
6. Windows Forms ListBox Control

---
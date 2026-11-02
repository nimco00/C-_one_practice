# Chapter 4: File  in C#

## Introduction to File 

File  in C# is an important programming concept that allows applications to create, save, read, and manage data using files.

In C#, files are used to store information permanently. Unlike variables, which store data temporarily while a program is running, files can keep information even after the application is closed.

File handling is commonly used in Windows Forms applications to save student information, employee records, customer details, and other types of data.

This chapter covers the following topics:

- 5.5 Using Files for Data Storage
- 5.6 The OpenFileDialog and SaveFileDialog Controls

# 5.5 Using Files for Data Storage

## What is File Storage?

File storage is the process of saving data into a file so that it can be retrieved and used later.

C# provides several classes for working with files. These classes are available in the `System.IO` namespace.

The `System.IO` namespace contains classes that allow programmers to perform input and output operations, such as creating, reading, writing, and deleting files.

### Importing the System.IO Namespace

Before using file-handling classes, we need to include the following statement:

```csharp
using System.IO;
```

**Explanation:**

- `using` allows the program to access a namespace.
- `System.IO` provides classes for file input and output.
- `StreamWriter` and `StreamReader` are examples of classes found in this namespace.

## 1. Creating a File

C# provides the `File.CreateText()` method to create a text file.

### Example: Create a File

```csharp
StreamWriter outfiles;

outfiles = File.CreateText("Home.txt");

outfiles.Close();
```

### Explanation

- `StreamWriter outfiles;` declares a variable used to write data into a file.
- `File.CreateText("Home.txt");` creates a text file named Home.txt.
- `outfiles.Close();` closes the file after it has been created.

**Note:** If the file already exists, `File.CreateText()` overwrites its contents.

## 2. Writing Data into a File

The `StreamWriter` class is used to write text into a file.

The `WriteLine()` method writes data into a file and moves to the next line.

### Example: Writing Information

###csharp
StreamWriter outfiles;

outfiles = File.CreateText("Home.txt");

outfiles.WriteLine("Welcome to CA242");
outfiles.WriteLine("My name is Naima Ahmed");
outfiles.WriteLine("My faculty is Computer Science");

outfiles.Close();
```

### Explanation

- `StreamWriter` is used to write data.
- `File.CreateText()` creates the file.
- `WriteLine()` writes text into the file.
- `Close()` closes the file.

### Output Stored in Home.txt

```text
Welcome to CA242
My name is Naima Ahmed
My faculty is Computer Science
```

The information remains stored in the file after the program is closed.

## 3. The Write() and WriteLine() Methods

C# provides two important methods for writing data into files.

| Method | Description |
|---|---|
| `Write()` | Writes data without moving to a new line. |
| `WriteLine()` | Writes data and moves to the next line. |

### Example: Write()

```csharp
StreamWriter outfiles;

outfiles = File.CreateText("Student.txt");

outfiles.Write("Ahmed ");
outfiles.Write("Ali");

outfiles.Close();
```

Output:

```text
Ahmed Ali
```

### Example: WriteLine()

```csharp
StreamWriter outfiles;

outfiles = File.CreateText("Student.txt");

outfiles.WriteLine("Ahmed");
outfiles.WriteLine("Ali");

outfiles.Close();
```

Output:

```text
Ahmed
Ali
```

## 4. Reading Data from a File

The `StreamReader` class is used to read information from a text file.

The `ReadLine()` method reads one line of text from the file.

### Example: Reading a File

```csharp
StreamReader Reads;

Reads = File.OpenText("Home.txt");

string lines;

lines = Reads.ReadLine();

MessageBox.Show(lines);

Reads.Close();
```

### Explanation

- `StreamReader Reads;` declares a variable for reading data.
- `File.OpenText("Home.txt");` opens the file for reading.
- `string lines;` declares a string variable.
- `Reads.ReadLine();` reads the first line.
- `MessageBox.Show(lines);` displays the text.
- `Reads.Close();` closes the file.

## 5. Reading Multiple Lines

To read all lines from a file, a loop can be used.

### Example: Reading All Lines

```csharp
StreamReader Reads;

Reads = File.OpenText("Home.txt");

string lines;

while ((lines = Reads.ReadLine()) != null)
{
    MessageBox.Show(lines);
}

Reads.Close();
```

### Explanation

- `while` repeats the reading process.
- `ReadLine()` reads one line at a time.
- `!= null` checks whether the file still contains a line.
- When the end of the file is reached, the loop stops.

## 6. Difference Between StreamWriter and StreamReader

| StreamWriter | StreamReader |
|---|---|
| Used to write data | Used to read data |
| Saves information into a file | Retrieves information from a file |
| Uses `Write()` | Uses `Read()` |
| Uses `WriteLine()` | Uses `ReadLine()` |
| Creates or writes files | Opens existing files for reading |

## 7. Closing a File

After completing file operations, the file should be closed.

```csharp
outfiles.Close();
```

or

```csharp
Reads.Close();
```

Closing a file releases the resources used by the program and helps prevent file access problems.

---

# 5.6 The OpenFileDialog and SaveFileDialog Controls

## Introduction

The OpenFileDialog and SaveFileDialog controls are Windows Forms controls that allow users to interact with files through a graphical interface.

These controls make file handling easier because users do not need to type the full file path manually.

## 1. OpenFileDialog Control

### What is OpenFileDialog?

`OpenFileDialog` is a Windows Forms control that allows users to select an existing file from their computer.

It is commonly used when an application needs to read information from a file.

### Example: Opening a File

```csharp
StreamReader Reads;

DialogResult Result;

Result = openFileDialog1.ShowDialog();

if (Result == DialogResult.OK)
{
    Reads = File.OpenText(openFileDialog1.FileName);

    string lines;

    lines = Reads.ReadLine();

    MessageBox.Show(lines);

    Reads.Close();
}
```

### Explanation

- `StreamReader Reads;` declares a reading variable.
- `DialogResult Result;` stores the result of the dialog.
- `ShowDialog()` displays the OpenFileDialog window.
- `DialogResult.OK` means the user selected a file and clicked OK.
- `FileName` contains the selected file path.
- `ReadLine()` reads the first line.
- `MessageBox.Show()` displays the text.
- `Close()` closes the file.

## 2. The DialogResult Property

The `DialogResult` property indicates which button the user clicked in a dialog box.

### Example: OK or Cancel

```csharp
DialogResult Result;

Result = openFileDialog1.ShowDialog();

if (Result == DialogResult.OK)
{
    MessageBox.Show("File selected successfully");
}
else
{
    MessageBox.Show("File selection cancelled");
}
```

### Explanation

- `DialogResult.OK` means the user clicked OK.
- `DialogResult.Cancel` means the user cancelled the operation.
- `if` checks the result of the dialog.
- `else` executes when the result is not OK.

## 3. SaveFileDialog Control

### What is SaveFileDialog?

`SaveFileDialog` is a Windows Forms control that allows users to choose a location and name for saving a file.

It is commonly used when an application needs to store information in a file.

### Example: Saving a File

```csharp
StreamWriter write;

DialogResult Result;

Result = saveFileDialog1.ShowDialog();

if (Result == DialogResult.OK)
{
    write = File.CreateText(saveFileDialog1.FileName);

    write.WriteLine("Welcome to C# Programming");
    write.WriteLine("File saved successfully");

    write.Close();
}
```

### Explanation

- `SaveFileDialog` displays the Save window.
- `ShowDialog()` displays the dialog.
- `DialogResult.OK` checks whether the user clicked Save.
- `File.CreateText()` creates the file at the selected location.
- `FileName` contains the selected file path.
- `WriteLine()` writes information into the file.
- `Close()` closes the file.

## 4. The FileName Property

The `FileName` property returns the name and path of the selected file.

### Example: FileName

```csharp
string filename;

DialogResult Result;

Result = openFileDialog1.ShowDialog();

if (Result == DialogResult.OK)
{
    filename = openFileDialog1.FileName;

    MessageBox.Show(filename);
}
```

### Explanation

If the user selects a file named Home.txt from the Downloads folder, the `FileName` property may return:

```text
C:\Users\dhaaf\Downloads\Home.txt
```

The full path allows the program to locate the file.

## 5. The InitialDirectory Property

The `InitialDirectory` property specifies the folder that appears first when the dialog opens.

### Example: InitialDirectory

```csharp
openFileDialog1.InitialDirectory =
    @"C:\Users\dhaaf\Downloads";

openFileDialog1.ShowDialog();
```

### Explanation

- `InitialDirectory` sets the default folder.
- The OpenFileDialog starts in the Downloads folder.
- The user can still select another folder.

## 6. Reading a File Using OpenFileDialog and ListBox

A ListBox can be used to display the contents of a selected file.

### Example: Display File Contents in ListBox

```csharp
StreamReader Reads;

DialogResult Result;

Result = openFileDialog1.ShowDialog();

if (Result == DialogResult.OK)
{
    Reads = File.OpenText(openFileDialog1.FileName);

    string lines;

    while ((lines = Reads.ReadLine()) != null)
    {
        listBox1.Items.Add(lines);
    }

    Reads.Close();
}
```

### Explanation

- `openFileDialog1.ShowDialog()` opens the file selection window.
- `FileName` retrieves the selected file path.
- `File.OpenText()` opens the selected file.
- `ReadLine()` reads one line at a time.
- `listBox1.Items.Add(lines)` adds each line to the ListBox.
- `while` repeats until all lines have been read.
- `Close()` closes the file.

## 7. Difference Between OpenFileDialog and SaveFileDialog

| OpenFileDialog | SaveFileDialog |
|---|---|
| Selects an existing file | Selects a location to save a file |
| Used for reading files | Used for saving files |
| Uses `File.OpenText()` | Uses `File.CreateText()` |
| Displays an Open window | Displays a Save window |
| Returns selected file path | Returns selected save path |

---

# Important Methods and Properties

| Method / Property | Purpose |
|---|---|
| `File.CreateText()` | Creates a text file |
| `File.OpenText()` | Opens a text file for reading |
| `Write()` | Writes data without a new line |
| `WriteLine()` | Writes data with a new line |
| `ReadLine()` | Reads one line |
| `Close()` | Closes the file |
| `ShowDialog()` | Displays a dialog window |
| `FileName` | Gets the selected file path |
| `InitialDirectory` | Sets the starting folder |
| `DialogResult.OK` | Indicates that OK was selected |
| `DialogResult.Cancel` | Indicates that the operation was cancelled |

# Learning Objectives

After completing this chapter, students should be able to:

- Explain the purpose of file handling in C#.
- Create text files using `File.CreateText()`.
- Write information using `StreamWriter`.
- Read information using `StreamReader`.
- Understand the difference between `Write()` and `WriteLine()`.
- Read one line or multiple lines from a file.
- Use OpenFileDialog to select an existing file.
- Use SaveFileDialog to save a new file.
- Understand the `DialogResult` property.
- Use the `FileName` and `InitialDirectory` properties.
- Display file contents using a MessageBox or ListBox.
- Close files after completing file operations.

# Conclusion

File handling is an essential part of C# programming because it allows applications to store and retrieve data permanently.

The `StreamWriter` class is used to write information into files, while the `StreamReader` class is used to read information from files.

The OpenFileDialog and SaveFileDialog controls make file operations easier by allowing users to select files and locations through a graphical interface.

These concepts are useful when developing Windows Forms applications such as student management systems, hotel booking systems, employee management systems, and other applications that require data storage.

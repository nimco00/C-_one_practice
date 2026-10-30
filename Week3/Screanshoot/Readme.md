# C# Windows Forms Code Documentation - Chapter 3

## Introduction

This document provides a summary of the C# Windows Forms code examples in Chapter 3. Each section explains the purpose and functionality of the corresponding code example.

## 1. Checkbox.png

**Code Function:**

Demonstrates how to check whether a CheckBox has been selected by the user. If `cbcomputer` is checked, the program assigns `"Computer"` to the `faculties` variable and adds it to `listBox1`.

## 2. Clear Button.png

**Code Function:**

Demonstrates how to clear user input from `txtnumber` and reset `lblDecision` to an empty string when the `btnClear_Click` event is triggered.

## 3. Close Button.png

**Code Function:**

Demonstrates how to close the current Windows Form using the `this.Close()` method when the user clicks the `btnExit` button.

## 4. If and Else If.png

**Code Function:**

Demonstrates the use of `double.TryParse()` with `if-else if` statements to validate multiple student test scores (`Score1`, `Score2`, and `Score3`). If any entered score is invalid, the program displays a warning message using a `MessageBox`.

## 5. If and Else.png

**Code Function:**

Demonstrates input validation using `int.TryParse()` to convert textbox input into an integer. The program checks whether the number is within the range of 1 to 10. If valid, it updates `lblDecision`; otherwise, it displays an error message using a `MessageBox`.

## 6. Radio Button.png

**Code Function:**

Demonstrates how to check a gender selection using `rdmale.Checked`. If the Male RadioButton is selected, the program assigns `"Male"` to the gender variable and adds it to `listBox1`.

## 7. Select Item.png

**Code Function:**

Demonstrates how to retrieve the currently selected item from `listBox1` using `SelectedItem.ToString()` and display the selected value in a `MessageBox`.

## Conclusion

This chapter demonstrates important C# Windows Forms concepts, including CheckBoxes, RadioButtons, decision structures, input validation, ListBox operations, and button click events. These examples help develop interactive Windows Forms applications.
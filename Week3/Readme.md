# CHAPTER 3: MAKING DECISIONS

## Introduction
This chapter explains how decision structures are used in C# programming to control the flow of a program based on conditions.

## 3.1 Decision Structures and the if Statement
Decision structures allow a program to make decisions based on conditions. The `if` statement executes a block of code when a condition is true.

## 3.2 The if-else Statement
The `if-else` statement executes one block of code when the condition is true and another block when the condition is false.

## 3.3 Nested Decision Structures
Nested decision structures are used when one decision structure is placed inside another to check multiple conditions.

## 3.4 Logical Operators
Logical operators are used to combine or reverse Boolean expressions.

- &&= AND
- || = OR
- !=  NOT

## 3.5 bool Variables and Flags
A Boolean variable stores either `true` or `false`. A flag is used to indicate whether a specific condition has occurred.

## 3.6 Comparing Strings
String comparison is used to check whether two strings are equal or different using operators such as `==` and `!=`.

## 3.7 Preventing Data Conversion Exceptions with TryParse
The `TryParse` method checks whether user input can be converted into a specific data type without causing a conversion exception.

## 3.8 Input Validation
Input validation checks user-entered data to ensure that it is correct and within the required range before processing.

## 3.9 Radio Buttons and Check Boxes
Radio Buttons allow users to select one option from a group, while Check Boxes allow users to select multiple independent options.

## 3.10 The switch Statement
The `switch` statement is used to select one execution path from multiple alternatives using `case`, `break`, and `default`.

## 3.11 Introduction to List Boxes
A ListBox is a Windows Forms control that displays a collection of items and allows users to select, add, and remove items.

### Important ListBox Properties and Methods

- Text Gets the text of the selected item.
- Items  Contains all items in the ListBox.
- Items.Count  Returns the number of items.
- SelectedItem Gets the selected item.
- SelectedIndex  Gets the index of the selected item.
- Items.Add() Adds a new item.
- Items.Remove()  Removes a specific item.
- Items.RemoveAt() Removes an item using its index.
- Items.Clear() Removes all items.

## Conclusion
Chapter 3 introduces decision-making structures in C#. These concepts help programmers control program execution, validate user input, and create interactive Windows Forms applications.
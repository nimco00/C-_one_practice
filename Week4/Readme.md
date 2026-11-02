# CHAPTER 4: LOOPS IN C#

## Introduction

This chapter introduces the different types of loops used in C# programming. Loops are important programming structures that allow a program to execute a block of statements repeatedly based on specific conditions.

They help reduce repeated code, improve program efficiency, and make applications easier to manage. This chapter also explains increment and decrement operators, which are commonly used to control loop execution.

---

## 4.1 The while Loop

The `while` loop is a repetition structure that executes a block of statements as long as a specified Boolean condition is true.

- It is known as a **pretest loop** because the condition is checked before the loop body executes.
- If the condition is initially false, the statements inside the loop will not execute.
- It is commonly used when the number of repetitions is not known in advance.

## 4.2 The ++ and -- Operators

The increment (`++`) and decrement (`--`) operators are used to increase or decrease the value of a variable by one.

These operators are commonly used in loops to control counters and repetition.

There are two ways to use these operators:

- **Postfix Mode:** The current value is used first, then the variable is increased or decreased. Examples: `count++` and `count--`.
- **Prefix Mode:** The variable is increased or decreased first, then its updated value is used. Examples: `++count` and `--count`.

## 4.3 The for Loop

The `for` loop is a repetition structure mainly used when the number of iterations is known.

It combines three important expressions in one statement:

- **Initialization:** Creates or assigns the starting value of the counter.
- **Condition:** Checks whether the loop should continue executing.
- **Update:** Increases or decreases the counter after each iteration.

The `for` loop is commonly used for counting, processing arrays, and repeating tasks a specific number of times.

## 4.4 The do-while Loop

The `do-while` loop executes a block of statements before checking its Boolean condition.

- It is known as a **posttest loop** because the condition is evaluated after the statements execute.
- The loop body always executes at least once.
- If the condition remains true, the loop continues repeating.
- A semicolon is required after the `while` condition.

It is useful when a program must execute an operation at least once before checking whether it should repeat.

---

## Comparison of Loop Structures

| Loop | Condition Checked | Minimum Executions |
|---|---|---|
| while | Before execution | 0 |
| for | Before execution | 0 |
| do-while | After execution | 1 |

## Conclusion

This chapter explains the main looping structures in C#, including `while`, `for`, and `do-while`. It also introduces increment and decrement operators used to control repetition.

Understanding these concepts helps programmers write efficient code, avoid unnecessary repetition, and control how many times statements are executed.
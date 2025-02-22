# Uninitialized Property Access in C#

This repository demonstrates a common, yet subtle, error in C#: accessing a property before it has been initialized.  Uninitialized properties can lead to unpredictable behavior, including exceptions or incorrect calculations. 

## The Bug

The `bug.cs` file contains a class `MyClass` with a property `MyProperty` and a method `MyMethod`. `MyMethod` attempts to read the value of `MyProperty` before any value is assigned to it.  The value retrieved will be the default value for the property's type (0 for `int`), which might be unexpected if you intended to assign the property a different value later.

## The Solution

The `bugSolution.cs` file provides a corrected version.  The property is initialized before use, or a check is added to handle potential null values. This ensures that there are no unexpected values retrieved and helps to ensure that the behavior of the code is reliable.
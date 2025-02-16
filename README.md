# Uninitialized Property Access in C#

This repository demonstrates a subtle issue in C# related to accessing properties that haven't been explicitly initialized.  While not strictly an error, it can lead to unexpected behavior if the default value is not accounted for.

The `ExampleClass.cs` file contains code that accesses a property (`MyProperty`) before assigning a value.  The default value (0 for integers) is then used. The `ExampleClassSolution.cs` offers a solution using explicit initialization.

## How to Reproduce
1. Clone the repository.
2. Compile and run `ExampleClass.cs`. Observe the output.
3. Review and run `ExampleClassSolution.cs` for a corrected approach.
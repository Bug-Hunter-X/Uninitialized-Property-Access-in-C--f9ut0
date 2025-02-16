public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a property that hasn't been initialized will result in a default value (0 for int)
        int value = MyProperty; 
        Console.WriteLine(value); // Output: 0

        // Modifying a property changes its value only for the current instance
        MyProperty = 10;
        Console.WriteLine(MyProperty); // Output: 10
    }
}
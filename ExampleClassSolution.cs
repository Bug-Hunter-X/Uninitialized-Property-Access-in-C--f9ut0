public class ExampleClass
{
    public int MyProperty { get; set; } = 0; // Initialize property with a default value

    public void MyMethod()
    {
        // Explicit initialization prevents the use of a default value unless intended.
        MyProperty = 10;
        int value = MyProperty; //Now the value is 10
        Console.WriteLine(value); // Output: 10

        MyProperty = 20;
        Console.WriteLine(MyProperty); // Output: 20
    }
}
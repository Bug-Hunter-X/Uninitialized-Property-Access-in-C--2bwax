public class MyClass
{
    public int MyProperty { get; set; } = 0; // bug fix: initialize the property

    public void MyMethod()
    {
        int value = MyProperty; 
        Console.WriteLine(value);
    }

    //Alternative solution using null checks if property is nullable.
    public int? NullableMyProperty { get; set; }

    public void MyMethodWithNullCheck()
    {
        int value = NullableMyProperty ?? 0; // Null-coalescing operator handles null
        Console.WriteLine(value);
    }
} 
public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        int x = 10;
        int y = 0;
        int z = x / y; // Potential DivideByZeroException
    }
}
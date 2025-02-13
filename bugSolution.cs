public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        int x = 10;
        int y = 0;
        try
        {
            int z = x / y; 
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
            // Handle the exception appropriately, e.g., log the error, display a user-friendly message, or use a default value.
        }
    }

    public void MyMethodWithInputValidation()
    {
        int x = 10;
        int y = GetInput();

        if(y != 0)
        {
            int z = x / y; 
        }
        else
        {
            Console.WriteLine("Cannot divide by zero.");
        }
    }

    private int GetInput()
    {
        // Here you should replace this with actual user input, validation, and error handling
        return 0; //Simulate potential user input
    }
}
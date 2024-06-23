

using ConditionalBreakpointAndTracepoint;

Calculator calculator = new Calculator();
for (int i = 0; i < 10; i++)
{
    int result = calculator.Add(i, 5);
    Console.WriteLine($"Iteration: {i}, Result: {result}");
    if (result == 10)
    {
        Console.WriteLine("Result is 10!");
    }
}
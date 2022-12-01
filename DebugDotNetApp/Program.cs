using System.Diagnostics;

int result = Fibonacci(5);
Console.WriteLine(result);

static int Fibonacci(int n)
{
    int n1 = 0;
    int n2 = 1;
    int sum;

    for (int i = 2; i <= n; i++)
    {
        sum = n1 + n2;
        n1 = n2;
        n2 = sum;
    }

    return n == 0 ? n1 : n2; 
}

// Logging and tracing in .NET applications

// System.Diagnostics.Trace
// System.Diagnostics.Debug 

// Both are part of the System.Diagnostics

/*
    System.Console
    - Always enabled and always writes to console
    - Useful for information that your customer might need to see in the release
    - Simplest approach, use for ad-hoc temp debugging & not checked into source control
 
    System.Diagnostics.Trace
    - Only enabled when TRACE is defined
    - Writes to attached listener, by default: DefaultTraceListener
    - Use this API when you create logs that'll be enabled in most builds

    System.Diagnostis.Debug
    - Only enabled when DEBUG is defined (in debug mode)
    - Writes to an attached debugger
    - Use this API when create logs that will be enabled only in debug mode
*/

Console.WriteLine("This message is readable by the end-user");
Trace.WriteLine("This is trace message when tracing the app");
Debug.WriteLine("This is debug message just for developers");

Debug.Write("Debug - ");
Debug.WriteLine("This is a full line");
Debug.WriteLine("This is another full line");


// Conditional Tracing

int count = 0;
if (count == 0)
{
    Debug.WriteLine("The count is 0 and this may cause an exception");
}

Debug.WriteLineIf(count == 0, "The count is 0 and this may cause an exception");

bool errorFlag = false;

Trace.WriteIf(errorFlag, "Error in AppendDate procedure");
Debug.WriteIf(errorFlag, "Transaction abandoned");
Trace.Write("Invalid value for data request");

// verifying that certain condition exists

int intergerDivide(int dividend, int divisor)
{
    Debug.Assert(divisor != 0, $"{nameof(divisor)} is 0 and will cause an exception");

    return dividend / divisor;
}

// logging and tracing
Debug.WriteLine($"Entering {nameof(Fibonacci)} method");
Debug.WriteLine($"We are looking for the {n}th number");

for (int i = 2; i <= n; i++)
{
    sum = n1 + n2;
    n1 = n2;
    n2 = sum;
    Debug.WriteLineIf(sum == 1, $"sum is 1, n1 is {n1}, n2 is {n2}");
}



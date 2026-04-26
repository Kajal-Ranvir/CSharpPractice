using System;
using Serilog;

class Program
{
    static void Main()
    {
        // Logger config
        Log.Logger = new LoggerConfiguration()
            .WriteTo.Console()
            .WriteTo.File("log.txt", rollingInterval: RollingInterval.Day)
            .CreateLogger();

        try
        {
            Log.Information("Application Started");

            Console.Write("Enter number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Log.Information($"User entered: {num}");

            int result = 100 / num;

            Console.WriteLine($"Result: {result}");
            Log.Information("Calculation successful");
        }
        catch (Exception ex)
        {
            Log.Error(ex, "Error occurred");
            Console.WriteLine("Something went wrong!");
        }
        finally
        {
            Log.Information("Application Ended");
            Log.CloseAndFlush();
        }
    }
}
using System;
using Microsoft.Extensions.Configuration;
using System.IO;

class Program
{
    static void Main()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json");

        var config = builder.Build();

        string appName = config["AppSettings:AppName"];
        string version = config["AppSettings:Version"];
        int number = Convert.ToInt32(config["AppSettings:DefaultNumber"]);

        Console.WriteLine($"App Name: {appName}");
        Console.WriteLine($"Version: {version}");
        Console.WriteLine($"Default Number: {number}");
    }
}
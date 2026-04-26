using System;
using Microsoft.Extensions.DependencyInjection;

// Interface
interface IMessageService
{
    void SendMessage();
}

// Implementation
class EmailService : IMessageService
{
    public void SendMessage()
    {
        Console.WriteLine("Email Sent!");
    }
}

// Consumer class
class Notification
{
    private readonly IMessageService _service;

    public Notification(IMessageService service)
    {
        _service = service;
    }

    public void Notify()
    {
        _service.SendMessage();
    }
}

class Program
{
    static void Main()
    {
        // DI container
        var serviceProvider = new ServiceCollection()
            .AddTransient<IMessageService, EmailService>()
            .AddTransient<Notification>()
            .BuildServiceProvider();

        var notification = serviceProvider.GetService<Notification>();

        notification.Notify();
    }
}
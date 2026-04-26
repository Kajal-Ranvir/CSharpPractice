using System;

class Demo
{
    public event Action OnClick;

    public void Click()
    {
        OnClick?.Invoke();
    }
}

class Program
{
    static void Main()
    {
        Demo d = new Demo();
        d.OnClick += () => Console.WriteLine("Event Triggered");
        d.Click();
    }
}
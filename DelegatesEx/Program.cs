using DelegatesEx;

static void DisplayMessage(string message)
{
    Console.WriteLine($"Message: {message}");
}
// Create an instance of the delegate and assign the method DisplayMessage
SimpleDelegate delegateInstance = DisplayMessage;

// Invoke the method through delegate
delegateInstance("Hello, Delegates!");

SimpleDelegate delegateInstance2 = DisplayMessage;

delegateInstance2("Another message");
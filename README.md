# KeyInputManager
A basic key input manager.

A usage example:
```csharp
while (true)
{
  if (KeyInputManager.GetKey(KeyCode.Alt) & KeyInputManager.GetKey(KeyCode.R))
    Console.WriteLine("You just pressed alt+r");
}
```

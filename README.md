# KeyInputManager
A basic key input manager.

It has 3 methods:
```csharp
KeyInputManager.GetKey(KeyCode.A);
KeyInputManager.GetKeyDown(KeyCode.A);
KeyInputManager.GetKeyUp(KeyCode.A);
```

A usage example:
```csharp
while (true)
{
  if (KeyInputManager.GetKey(KeyCode.Alt) & KeyInputManager.GetKeyDown(KeyCode.R))
    Console.WriteLine("You just pressed alt+r");
}
```

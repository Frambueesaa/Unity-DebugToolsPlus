# DebugToolsPlus

**DebugToolsPlus** is a Unity package that enhances your debugging experience by providing advanced logging functionalities. With support for customizable colors, formatting, and extended log levels, it makes debugging faster and more efficient.

## Features

- Easy-to-use logging system.
- Support for custom log colors and formats.
- Includes:
  - A static class `D` for quick log output.
  - A static class `DColors` for color customization.
  - An enum `DColor` for defining log colors.
  - A test script `DebugToolsPlusTest` to help you get started.

## Installation

1. Import the package into your Unity project via the Unity Asset Store or directly into the project’s `Assets` folder.

## Usage

Once imported, you can start using **DebugToolsPlus** right away. Here are several examples of how to use the logging system:

### Basic Logging

```csharp
using DebugToolsPlus;

public class Example : MonoBehaviour
{
    void Start()
    {
        // Simple log message
        D.Log("Your Title", "This is a normal log message.");

        // Warning log message
        D.LogWarning("Your Title", "This is a warning message.");
        D.Log("Your Title", "This is a warning message.", LogType.Warning);

        // Error log message
        D.LogError("Your Title", "This is an error message.");
        D.Log("Your Title", "This is a warning message.", LogType.Error);

        // Custom colored log
        D.Log("Your Title", "This is a custom colored log.", DColors.Green); //Green
        D.Log("Your Title", "This is a custom colored log.", 3); //Green

        D.Log("Your Title", "This is a red warning log.", DColors.Red); //Red
        D.Log("Your Title", "This is a red warning log.", 2); //Red

        D.Log("Your Title", "This is a blue info log.", DColors.Blue);  //Blue
        D.Log("Your Title", "This is a blue info log.", 4);  //Blue

        //You can colored the log with a number too!
        //You can colored the Warning and Error log too!

        //Use Object for Context in Unity Editor
        D.Log("Your Title", "This is a log with context.", this);

        //Or combine all together
        D.Log("Your Title", "This is a log with context and color.", this, LogType.Warning, DColors.Yellow); //Yellow

        //To show the message with color you can try the following
        D.Log("Your Title", "This is a log with context and color.", this, LogType.Warning, DColors.Yellow, true); //Yellow
    }
}

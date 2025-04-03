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

1. Download or clone this repository.
2. Import the package into your Unity project via the Unity Asset Store or directly into the project’s `Assets` folder.

## Usage

Once imported, you can start using **DebugToolsPlus** right away. Here's a quick example of how to use the logging system:

```csharp
using DebugToolsPlus;

public class Example : MonoBehaviour
{
    void Start()
    {
        // Example of logging with custom color
        D.Log("This is a normal log message.");
        D.LogWarning("This is a warning message.");
        D.LogError("This is an error message.");
        D.Log("This is a custom colored log.", DColors.Green);
    }
}

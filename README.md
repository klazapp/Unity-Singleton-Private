# Singleton Patterns for Unity

## Introduction

The Singleton package under the `com.Klazapp.Utility` namespace provides robust implementations of the Singleton pattern for Unity, including both a persistent and a standard version. These classes ensure that only one instance of a component exists throughout the lifecycle of the application, with the persistent variant also surviving across different scenes.

## Features

- **MonoSingletonGlobal**: Standard singleton implementation that ensures only one instance of a component exists within the application.
- **MonoPersistentSingletonGlobal**: Extends the standard singleton pattern to make the instance persist across multiple scenes without being destroyed.
- **Automatic Instance Creation**: Automatically creates a new instance of the singleton object if one does not already exist.
- **Simple Integration**: Easily integrate with any Unity project to manage singleton instances of various components.

## Dependencies

- **Unity 2017.1 or Newer**: Required for the latest MonoBehaviour and GameObject API features.

## Compatibility

Designed to work universally across all Unity projects, regardless of the rendering pipeline or platform.

| Compatibility | URP | BRP | HDRP |
|---------------|-----|-----|------|
| Compatible    | ✔️   | ✔️   | ✔️    |

## Installation

1. Download the Singleton package scripts from the [GitHub repository](https://github.com/klazapp/Unity-Singleton-Public.git) or via the Unity Package Manager.
2. Add the scripts to your Unity project within any scripts directory.

## Usage

To utilize the singleton pattern, inherit your class from `MonoSingletonGlobal<T>` or `MonoPersistentSingletonGlobal<T>` where `T` is your component class. Access your singleton instance via `Instance` property:

```csharp
public class GameManager : MonoSingletonGlobal<GameManager>
{
    void Start()
    {
        // Use the instance
        Debug.Log("GameManager started");
    }
}
```

## To-Do List (Future Features)

- [ ] Implement thread-safe initialization to enhance reliability in multi-threaded scenarios.
- [ ] Expand the utility to include non-MonoBehaviour singletons for broader use cases.

## License

This utility is released under the MIT License, permitting free use, modification, and distribution within your projects.

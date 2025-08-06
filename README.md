# DCIT 318: Programming II Assignment 2

## Overview
This C# console application demonstrates three core Object-Oriented Programming (OOP) concepts:

1. **Inheritance and Method Overriding**
2. **Abstract Classes and Methods**
3. **Interfaces**

The project is organized into folders for each concept, with a single `Program.cs` file that demonstrates all features.

---

## Project Structure

```
ConsoleApplication/
│
├── Inheritance/
│   ├── Animal.cs
│   ├── Dog.cs
│   └── Cat.cs
│
├── Abstraction/
│   ├── Shape.cs
│   ├── Circle.cs
│   └── Rectangle.cs
│
├── Interfaces/
│   ├── IMovable.cs
│   ├── Car.cs
│   └── Bicycle.cs
│
├── Program.cs
│
├── ConsoleApplication.csproj
```

---

## Features

### 1. Inheritance and Method Overriding
- **Animal**: Base class with a virtual method `MakeSound()`.
- **Dog** and **Cat**: Derived classes that override `MakeSound()`.
- **Demonstration**: Instances of each class are created and their `MakeSound()` methods are called in `Program.cs`.

### 2. Abstract Classes and Methods
- **Shape**: Abstract class with an abstract method `GetArea()`.
- **Circle** and **Rectangle**: Derived classes that implement `GetArea()`.
- **Demonstration**: Instances are created and their areas are displayed in `Program.cs`.

### 3. Interfaces
- **IMovable**: Interface with a method `Move()`.
- **Car** and **Bicycle**: Implement `IMovable` and provide their own `Move()` implementations.
- **Demonstration**: Instances are created and their `Move()` methods are called in `Program.cs`.

---

## How to Run

1. Open the solution in Visual Studio or VS Code.
2. Restore dependencies (if needed):
   ```
   dotnet restore
   ```
3. Build and run the project:
   ```
   dotnet run --project ConsoleApplication
   ```
4. You should see output demonstrating all three OOP concepts.

---

## Example Output
```
Some generic sound
Bark
Meow
Circle area: 78.54
Rectangle area: 24.00
Car is moving
Bicycle is moving
```

---

## Author
- theGeniusDennis

---

## Notes
- Ensure you are running the project from the `ConsoleApplication` directory if using the command line.
- The code is organized for clarity and educational purposes.

# FizzBuzz

A clean, extensible implementation of the classic FizzBuzz programming exercise built with .NET 8.0, featuring a rule-based architecture to make it easy to add new rules and behaviors.

## Overview

The FizzBuzz game follows the traditional rules:

- Print "Fizz" for numbers divisible by 3
- Print "Buzz" for numbers divisible by 5
- Print "FizzBuzz" for numbers divisible by both 3 and 5
- Print the number itself for all other cases

## Architecture

The solution is organized into three main projects:

### 🏗️ Project Structure

```
FizzBuzz/
├── FizzBuzz/                 # Console application entry point
├── FizzBuzz.Core/           # Core business logic and rules
└── FizzBuzzTests/           # Unit and integration tests
```

## 🚀 Getting Started

### Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) or later
- Visual Studio 2022, VS Code, or any .NET-compatible IDE

### Running the Application

1. **Clone the repository**

   ```bash
   git clone <repository-url>
   cd FizzBuzz
   ```

2. **Restore dependencies**

   ```bash
   dotnet restore
   ```

3. **Build the solution**

   ```bash
   dotnet build
   ```

4. **Run the application**
   ```bash
   dotnet run --project FizzBuzz
   ```

### Running Tests

```bash
# Run all tests
dotnet test

# Run tests with detailed output
dotnet test --verbosity normal

# Run tests for a specific project
dotnet test FizzBuzzTests
```

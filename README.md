# Old Phone Keypad

A C# implementation of an old mobile phone keypad that converts keypad input into text based on the number of times each key is pressed.

The solution includes:

- A reusable `OldPhoneKeypad` class library
- Unit tests using xUnit
- An ASP.NET Core Web API wrapper demonstrating how customers could consume the library through a REST API
- Swagger/OpenAPI documentation for testing the API

## Solution Structure

```text
OldPhoneKeypad/
├── OldPhoneKeypad/
│   └── PhoneKeypad.cs
│
├── OldPhoneKeypad.Tests/
│   └── PhoneKeypadTests.cs
│
└── OldPhoneKeypad.Api/
    ├── Controllers/
    │   └── OldPhonePadController.cs
    ├── Models/
    │   ├── OldPhonePadRequest.cs
    │   └── OldPhonePadResponse.cs
    └── Program.cs


## Features

...

## Requirements

...

## Getting Started

...

## Using the Library

...

## REST API Demo

...

## API Example

...

## Running Tests

...

## Design Decisions

...

## Error Handling

...
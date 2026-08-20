# Old Phone Keypad API - How To Guide

## Overview

The Old Phone Keypad API provides a simple REST endpoint for converting
old mobile phone keypad input into text.

## Prerequisites

- .NET 10 SDK
- A REST API client such as Swagger UI, Postman, or curl

## Running the API

1. Clone the repository.
2. Open the solution in Visual Studio.
3. Set `OldPhoneKeypad.Api` as the startup project.
4. Run the application.
5. Open the Swagger UI URL displayed by the application.

## Sending a Request

Send a POST request to:

`/api/OldPhonePad`

with the following JSON body:

```json
{
  "input": "4433555 555666#"
}
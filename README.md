# _Palindrome Checker_

#### _App that checks if a string is a palindrome, 7.14.2020_

#### By _**Mariel Hamson and Jeff Kim**_

## Description

This is an app that takes a string of characters and determines whether the string is the same if reversed, making it a palindrome.

## Specs

| Behavior                                        | Input                                    | Output                                            | Completed(Y/N?) |
| ----------------------------------------------- | ---------------------------------------- | ------------------------------------------------- | --------------- |
| Take a string and return a split array          | "Apple"                                  | str[] myArray{ "A", "p", "p", "l", "e" }          | Y               |
| Reverse array and store in new array            | str[] myArray{ "A", "p", "p", "l", "e" } | str[] myReversedArray { "e", "l", "p", "p", "a" } | Y               |
| Compare myReversedArray to myArray using a loop | myReversedArray == myArray               | True                                              | Y               |

## Setup/Installation Requirements

Clone repository from GitHub: https://github.com/MarielHamson/Palindrome.git

**Requires .NET, `dotnet script` installed:**

_Download the .NET Core SDK and install_

_Install `dotnet script` using the command `dotnet tool install -g dotnet-script`_

_Run `dotnet restore` to get testing framework_

_Run `dotnet build` and `dotnet run`_

## Known Bugs

_No Known Bugs at this time_

## Support and contact details

_Please let me know if you have any questions or concerns at mariel.hamson@gmail.com_

## Technologies Used

_C#, .NET, MSTest_

### License

_MIT License_

Copyright (c) 2020 **_Mariel Hamson and Jeff Kim_**

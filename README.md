# _Palindrome Checker_

#### _App that checks if a string is a palindrome, 7.14.2020_

#### By _**Mariel Hamson and Jeff Kim**_

## Description

This is an app that takes a string of characters and determines whether the string is the same if reversed, making it a palindrome.

## Specs

| Behavior                                        | Input                                    | Output                                            | Completed(Y/N?) |
| ----------------------------------------------- | ---------------------------------------- | ------------------------------------------------- | --------------- |
| Take a string and return a split array          | "Apple"                                  | str[] myArray{ "A", "p", "p", "l", "e" }          | N               |
| Reverse array and store in new array            | str[] myArray{ "A", "p", "p", "l", "e" } | str[] myReversedArray { "e", "l", "p", "p", "a" } | N               |
| Compare myReversedArray to myArray using a loop | myReversedArray == myArray               | True                                              | N               |
| ...                                             | .                                        | .                                                 | .               |

## Setup/Installation Requirements

### Obtaining API Key

- In order to use this app, you must obtain an API key from https://www.exchangerate-api.com/. On the homepage, enter your email address and click "Get Free Key"
- Enter your name and create a password in order to see the API key. Hold on to the key as you will need to enter it in the next step

### Clone from GitHub and Run app via NPM

- First, ensure you have node.js and NPM installed
- Navigate to: www.github.com/marielhamson/currency-exchange
- Find the "Code" button and either download the .zip or use the .git filename to clone the repository on your command line into the desired location ("git clone https://github.com/MarielHamson/currency-exchange.git)
- Open the project in your code editor of choice
- Add a file in the root directory called ".env"
- Add the following line to the file: API_KEY= {insert your API key here}
- run npm install _and then_ npm start to see the app on a live server

## Known Bugs

_No Known Bugs at this time_

## Support and contact details

_Please let me know if you have any questions or concerns at mariel.hamson@gmail.com_

## Technologies Used

_C#, .NET, MSTest_

### License

_MIT License_

Copyright (c) 2020 **_Mariel Hamson_**

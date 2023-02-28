# Pierre's Bakery

#### By E. Luckie ☀️

#### Simple C# console application acts as an ordering medium for a faux bakery. Users are shown how much each bakery item costs and are able to input how many of each item they want. Their order and order total is then displayed back to them.

## Technologies Used

* C#
* Dotnet
* MSTest
* Markdown
* Git

## Description

This C# console application was created to demonstrate understanding of using TDD with C#, namespaces, classes, and auto-implemented properties. Once the application is ran via command in the computer's terminal, users are greeted by the bakery and displayed the prices of the baked goods available. Each baked good has the price for a singular item as well as sales for higher quantities. Pastries are buy 3 get 1 free, bread is buy 2 get 1 free. After reviewing the prices, users are asked if they would like to place an order or not. If they choose no, the application shows a goodbye message and exits. If they choose yes, they're prompted to enter their desired quantity of both pastries and bread. Once entered, the quantities are displayed back to the user to confirm. They're then able to confirm or reject the order.

* If user **confirms** the quantities: their order is calculated and displayed back to them. This includes the quantity & cost of each baked good and the grand total
* If user **rejects** the quantities: they're prompted to re-enter their quantities & the confirmation process restarts

Upon displaying their confirmed order and grand total, users are prompted to choose if they would like to create a new order or exit. Responding "yes" (case-insensitive) takes them back to the welcome message to create a new order. Pressing any other key exits the console application.

## Setup/Installation Requirements

1. Clone this repo
2. Open your terminal (e.g., Terminal or GitBash) and navigate to this project's production directory called **PierresBakery**
3. In the command line, run the command ``dotnet run`` to compile and execute the console application
* This will also automatically run the _restore_ command to retrieve and install the necessary packages for this application
* Since this is a console application, you'll interact with it through text commands in your terminal
4. Optionally, you can run ``dotnet build`` to compile this console app without running it

1. Using a shell program, navigate to the directory called **PierresBakery.Tests**
2. Once in the **PierresBakery.Tests** directory, run the command ``dotnet restore`` in the console
3. After the restore process is complete, run the command ``dotnet test`` in the console. This will run all written tests and display the test results in the console to review

## Known Bugs

* No known bugs.

## Stretch Plans

* Allow users to keep adding to their order by adding cart functionality
* Allow users to order different types of Bread and Pastry

## License

MIT License

Copyright (c) 2023 Luckie
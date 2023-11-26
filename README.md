# Code_X Tax Calculator

## Introduction

The Code_X Tax Calculator is a C# console application designed to calculate income tax based on user-provided monthly salary, allowances, and deductions. It utilizes a progressive tax rate structure with different tax brackets.

## Getting Started

### Prerequisites

- .NET SDK installed on your machine.

### Usage

1. Run the application.
2. Enter your name when prompted.
3. Input your monthly salary when prompted.
4. Input allowances and deductions as needed.
5. The application will calculate the tax payable and display the result.

## Variables

- `UpTo`: Upper limit for the first tax bracket.
- `Over`: Threshold for the highest tax bracket.
- `lower_lim_1` to `upper_lim_5`: Income limits for different tax brackets.
- `rate_UpT0` to `rate_5`: Tax rates for each bracket.
- `On`: Boolean variable to control the main loop.

## Functions

### Welcome()

Displays a welcome message in the console.

### net_income(double Taxable_income, double Deduction, double Tax_payable)

Calculates and displays the net income based on taxable income, deductions, and tax payable.

### CalculationWait()

Simulates a delay during tax calculation with a random number of iterations and delays.

## Contributing

Contributions to this project are welcome. Feel free to submit pull requests or report issues.

## License

This project is licensed under the [MIT License](LICENSE).

## Acknowledgments

We extend our sincere appreciation to the developers ( karisacodes,WacoderForever, s1gm9) and contributors (G-CoderX, Stephanie Makori, Voste254, Nyabs254, 123Origami) who have generously contributed to enhancing this tax calculator.



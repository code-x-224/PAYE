# Code_X Tax Calculator

## Introduction

The Code_X Tax Calculator is a C# console application designed to calculate income tax based on user-provided monthly salary, allowances, and deductions. It utilizes a progressive tax rate structure with different tax brackets.


## Member details

Stephanie Makori -S13/07829/22

Sally Munga -S13/07782/22

Sylvia Anyango-S13/10620/22

Gilbert Omindeh - S13/07816/22

Emmanuel Magothe - S13/07775/22

Stephen Onyango- S13/07841/22

Daniel Amani Karisa- S13/07763/22

Seth Omondi - S13/04402/21

Samuel Mathews - S13/07776/22

Halkano Liban - S13/07771/22

## Getting Started

## User Guide

The user guide is a video that helps the user get started with the application.

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

We extend our sincere appreciation to the developers ( karisacodes,s1gm9,WacoderForever) and contributors (G-CoderX, Stephanie Makori, Voste254, Nyabs254, 123Origami) who have generously contributed to enhancing this tax calculator.



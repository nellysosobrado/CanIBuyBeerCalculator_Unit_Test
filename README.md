# Manual Unit Testing in .NET Without a Framework

 .NET console application that demonstrates **manual unit testing without any testing framework** 

## Purpose

The goal is to show an understanding of core testing principles using only basic C# code. It demonstrates how to manually test business logic using clear test cases and output results directly to the console.

## Project Structure

- **MyFirstUnitTest** – contains the business logic for deciding if a person can buy beer based on age, location, and alcohol level.
- **MyFirstUnitTest.Tests** – runs manual tests and prints **PASS/FAIL** messages based on expected outcomes.

## What it Shows

- Understanding of the Arrange-Act-Assert pattern  
- Ability to separate logic and testing into clean project layers  
- A disciplined approach to verifying code without relying on external tools

## How to Run

1. Open the solution in Visual Studio.  
2. Set `MyFirstUnitTest.Tests` as the startup project.  
3. Run the application to see test results in the console.

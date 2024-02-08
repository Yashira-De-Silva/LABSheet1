using System;

class Program
{
    static void Main(string[] args)
    {
        // Task 1: Calculate area of a rectangle
        CalculateRectangleArea();

        // Task 2: Check if numbers are even or odd
        CheckEvenOdd();

        // Task 3: Calculate sum of numbers up to N
        CalculateSum();

        // Task 4: Print Fibonacci series
        PrintFibonacciSeries();

        // Task 5: Display multiplication table
        DisplayMultiplicationTable();

        // Task 6: Determine student grade
        DetermineStudentGrade();

        // Task 7: Simulate basic ATM machine
        SimulateATMMachine();
    }

    // Task 1: Calculate area of a rectangle
    static void CalculateRectangleArea()
    {
        Console.WriteLine("Enter the length of the rectangle:");
        double length = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the width of the rectangle:");
        double width = double.Parse(Console.ReadLine());

        double area = length * width;

        Console.WriteLine($"The area of the rectangle is: {area}");
    }

    // Task 2: Check if numbers are even or odd
    static void CheckEvenOdd()
    {
        Console.WriteLine("Enter 10 numbers:");

        for (int i = 0; i < 10; i++)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(num % 2 == 0 ? "Even" : "Odd");
        }
    }

    // Task 3: Calculate sum of numbers up to N
    static void CalculateSum()
    {
        Console.WriteLine("Enter a positive integer:");
        int n = int.Parse(Console.ReadLine());

        if (n < 0)
        {
            Console.WriteLine("ERROR");
            return;
        }

        int sum = (n * (n + 1)) / 2;
        Console.WriteLine($"Sum of numbers from 1 to {n} is: {sum}");
    }

    // Task 4: Print Fibonacci series
    static void PrintFibonacciSeries()
    {
        Console.WriteLine("Enter the number of terms for Fibonacci series:");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(Fibonacci(i));
        }
    }

    static int Fibonacci(int n)
    {
        if (n <= 1)
            return n;
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    // Task 5: Display multiplication table
    static void DisplayMultiplicationTable()
    {
        Console.WriteLine("Enter a number:");
        int num = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{num} x {i} = {num * i}");
        }
    }

    // Task 6: Determine student grade
    static void DetermineStudentGrade()
    {
        Console.WriteLine("Enter student's name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter exam marks:");
        int marks = int.Parse(Console.ReadLine());

        if (marks < 0 || marks > 100)
        {
            Console.WriteLine("ERROR: Marks should be between 0 and 100.");
            return;
        }

        char grade;

        if (marks >= 75)
            grade = 'A';
        else if (marks >= 60)
            grade = 'B';
        else if (marks >= 50)
            grade = 'C';
        else if (marks >= 40)
            grade = 'D';
        else
            grade = 'F';

        Console.WriteLine($"Student Name: {name}, Grade: {grade}");
    }

    // Task 7: Simulate basic ATM machine
    static void SimulateATMMachine()
    {
        int balance = 1000;

        while (true)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit Money");
            Console.WriteLine("3. Withdraw Money");
            Console.WriteLine("4. Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Your balance is: {balance}");
                    break;
                case 2:
                    Console.WriteLine("Enter amount to deposit:");
                    int depositAmount = int.Parse(Console.ReadLine());
                    balance += depositAmount;
                    Console.WriteLine($"Deposited {depositAmount}. Your new balance is: {balance}");
                    break;
                case 3:
                    Console.WriteLine("Enter amount to withdraw:");
                    int withdrawAmount = int.Parse(Console.ReadLine());
                    if (withdrawAmount > balance)
                        Console.WriteLine("Insufficient balance.");
                    else
                    {
                        balance -= withdrawAmount;
                        Console.WriteLine($"Withdrawn {withdrawAmount}. Your new balance is: {balance}");
                    }
                    break;
                case 4:
                    Console.WriteLine("Exiting...");
                    return;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}

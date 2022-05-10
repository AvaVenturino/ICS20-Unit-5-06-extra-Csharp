// Created by: Ava Venturino
// Created on: April 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        int counter1;
        int counter2;
        var addedNumber = 0;
        var answer = 0;

        Console.Write("Multiplication using loops:\n");
        Console.Write("Input first integer: ");
        counter1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input second integer: ");
        counter2 = Convert.ToInt32(Console.ReadLine());

        if (counter1 > 0 && counter2 > 0) {
            while (addedNumber < counter2) {
                addedNumber = addedNumber + 1;
                answer = answer + counter1;
            }
        } else if (counter1 < 0 && counter2 < 0) {
            while (addedNumber > counter2) {
                addedNumber = addedNumber - 1;
                answer = answer - counter1;
            }
        } else if (counter1 > 0 && counter2 < 0) {
            while (addedNumber > counter2) {
                addedNumber = addedNumber - 1;
                answer = answer - counter1;
            }
        } else if (counter1 < 0 && counter2 > 0) {
            while (addedNumber < counter2) {
                addedNumber = addedNumber + 1;
                answer = answer + counter1;
            }
        }
        Console.WriteLine("The answer is: " + answer );
    }
}

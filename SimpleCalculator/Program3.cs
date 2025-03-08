﻿using System;

namespace ConsoleApp4{
    class Program{
        static void Main(string[] args){
            bool playAgain;
            do{
                playAgain = false;
                Console.ForegroundColor=ConsoleColor.White;// Ensure default color at start

                Console.WriteLine("Enter first number");
                double firstNumber = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter a command '+','-','*','/': ");
                char command = Convert.ToChar(Console.ReadLine());

                Console.WriteLine("Enter second number: ");
                double secondNumber = Convert.ToDouble(Console.ReadLine());

                switch (command){
                    case '+':
                        Console.WriteLine(firstNumber + secondNumber);
                        break;
                    case '-':
                        Console.WriteLine(firstNumber - secondNumber);
                        break;
                    case '*':
                        Console.WriteLine(firstNumber * secondNumber);
                        break;
                    case '/':
                        Console.WriteLine(firstNumber / secondNumber);
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please enter a valid command: '+', '-', '*', '/' ");
                        Console.ForegroundColor=ConsoleColor.White;
                        break;
                }

                Console.WriteLine("Again? (y/n)");
                if (Console.ReadKey().KeyChar == 'y'){
                    playAgain = true;
                    Console.WriteLine(); 
                    continue; 
                }

                Console.WriteLine("\nRandom number mode? Press (r)");
                if (Console.ReadKey().KeyChar == 'r'){
                    Console.WriteLine("\nGuess a number between 1-100");
                    int randomNumber = new Random().Next(1, 101); 
                    int guess;

                    do{
                        guess = Convert.ToInt32(Console.ReadLine());

                        if (guess > randomNumber){
                            Console.WriteLine("Too high! Try again: ");
                        } else if (guess < randomNumber){
                            Console.WriteLine("Too low! Try again: ");
                        }
                    } while (guess != randomNumber); 

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Congratulations!!! You won!!!");
                    Console.ForegroundColor=ConsoleColor.White;
                    
                    Console.WriteLine("Press any key to exit...");
                    Console.ReadKey();
                    return; 
                }

                Console.WriteLine("Goodbye!");
            } while (playAgain);
        }
    }
}

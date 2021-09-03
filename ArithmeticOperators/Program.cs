using System;

namespace ArithmeticOperators
{
    class Arithmetic
    {
        public int Add(int firstNumber, int secondNumber)=>
            firstNumber + secondNumber;

        public int Substract(int firstNumber, int secondNumber)=>
            firstNumber - secondNumber;

        public int Multiply(int firstNumber, int secondNumber)=>
            firstNumber * secondNumber;

        public double Divide(int firstNumber, int secondNumber)=>
            firstNumber / secondNumber;

        static void Main(string[] args)
        {
            Arithmetic operation = new Arithmetic();

            Console.Write("Enter a number : ");
            int firstNumber = Int32.Parse(Console.ReadLine());

            Console.Write("Enter another number : ");
            int secondNumber = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"Addition of two numbers is : {operation.Add(firstNumber, secondNumber)}");
            Console.WriteLine(value: $"Substraction of two numbers is : {operation.Substract(firstNumber, secondNumber)}");
            Console.WriteLine($"Multiplication of two numbers is : {operation.Multiply(firstNumber, secondNumber)}");
            Console.WriteLine($"Division of two numbers is : {operation.Divide(firstNumber, secondNumber)}");

            Console.ReadLine();
        }
    }
}

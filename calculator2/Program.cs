using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator2
{
    class Program
    {
        public static void Main(string[] args)
        {
            int CalculationResult = 0;


            while (true)
            {
                //FIRST NUMBER INPUT
                CalculationResult = 0;

                Console.Write("Please enter a number: ");

                bool checkInputFirstNumber;
                int userInputFirstNumber;

                checkInputFirstNumber = int.TryParse(Console.ReadLine(), out userInputFirstNumber);

                while (checkInputFirstNumber == false)
                {
                    Console.Write("Invalid input. Please enter a number: ");
                    checkInputFirstNumber = int.TryParse(Console.ReadLine(), out userInputFirstNumber);
                }

                Console.WriteLine("\n\n");


                //SECOND NUMBER INPUT

                Console.Write("Again, please enter a number: ");

                bool checkInputSecondNumber;
                int userInputSecondNumber;

                checkInputSecondNumber = int.TryParse(Console.ReadLine(), out userInputSecondNumber);

                Console.WriteLine("\n\n");

                while (checkInputSecondNumber == false)
                {
                    Console.Write("Invalid input. Please enter a number for this field: ");
                    checkInputSecondNumber = int.TryParse(Console.ReadLine(), out userInputSecondNumber);
                }


                Console.WriteLine("\n\n");


                //OPERAND INPUT

                Console.Write("Please enter an operand using this key: \n 1. Add \n " +
                        "2. Subtract \n 3. Multiply \n 4. Divide \n\n\n\n");

                bool checkInputOperand;
                int userInputOperand;

                checkInputOperand = int.TryParse(Console.ReadLine(), out userInputOperand);
                



                while ((checkInputOperand == false) ||
                    (userInputOperand != 1 && userInputOperand != 2 && userInputOperand != 3 && userInputOperand != 4))
                {
                    Console.Write("Invalid input. Please enter an operand using this key: \n 1. Add \n " +
                    "2. Subtract \n 3. Multiply \n 4. Divide \n\n\n\n");

                    checkInputOperand = int.TryParse(Console.ReadLine(), out userInputOperand);
                }
                


                //REFERRING TO METHODS
                if (userInputOperand == 1)
                {
                    CalculationResult = Operations.Addition(userInputFirstNumber, userInputSecondNumber);
                }

                else if (userInputOperand == 2)
                {
                    CalculationResult = Operations.Subtraction(userInputFirstNumber, userInputSecondNumber);
                }
                else if (userInputOperand == 3)
                {
                    CalculationResult = Operations.Multiplication(userInputFirstNumber, userInputSecondNumber);
                }
                else if (userInputOperand == 4)
                {
                    CalculationResult = Operations.Division(userInputFirstNumber, userInputSecondNumber);
                }

                Console.WriteLine("\n\n The answer is " + CalculationResult);
                Console.WriteLine();
            }

        }

        //METHODS

        public static class Operations
        {

            public static int Addition(int firstNumber, int secondNumber)
            {
                int result = firstNumber + secondNumber;
                return result;
            }

            public static int Subtraction(int firstNumber, int secondNumber)
            {
                int result = firstNumber - secondNumber;
                return result;
            }

            public static int Multiplication(int firstNumber, int secondNumber)
            {
                int result = firstNumber * secondNumber;
                return result;
            }
            public static int Division(int firstNumber, int secondNumber)
            {
                int result = firstNumber / secondNumber;
                return result;
            }
        }
    }
}

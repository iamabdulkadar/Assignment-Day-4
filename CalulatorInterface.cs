using System;

namespace InterfaceCalculator
{
    interface IBasicCalculator
    {
        void Addiction();
        void Subtraction();
        void Multiplication();
        void Division();

    }
    interface IScientifcCalculator
    {
        void MatrixOperation();
        void LogOperation();
        void Exponational();

    }
    class BasicCalculator : IBasicCalculator
    {
        public int number1, number2;
        public BasicCalculator()
        {
            Console.Write("\n Enter the number 1 : ");
            number1 = Int32.Parse(Console.ReadLine());
            Console.Write("\n Enter the number 2 : ");
            number2 = Int32.Parse(Console.ReadLine());
        }
        public void Addiction()
        {
            int result = number1 + number2;
            Console.WriteLine($"\n Addiction of {number1} and {number2} = {result}");
        }

        public void Division()
        {
            double result = number1 / number2;
            Console.WriteLine($"\n Division of {number1} and {number2} = {result}");
        }

        public void Multiplication()
        {
            int result = number1 * number2;
            Console.WriteLine($"\n Multiplication of {number1} and {number2} = {result}");
        }

        public void Subtraction()
        {
            int result = number1 - number2;
            Console.WriteLine($"\n Subtraction of {number1} and {number2} = {result}");
        }
    }
    class ScientificCalculator : IScientifcCalculator
    {
        public void Exponational()
        {
            Console.WriteLine($"\n This is Exponational method from IScientifcCalculator interface...");
        }

        public void LogOperation()
        {
            Console.WriteLine($"\n This is LogOperation method from IScientifcCalculator interface...");
        }

        public void MatrixOperation()
        {
            Console.WriteLine($"\n This is MatrixOperation method from IScientifcCalculator interface...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator program using interface. (Create interfaces for Basic and Scientific calculator).");

            var basic = new BasicCalculator();
            var scientific = new ScientificCalculator();
        Calculator:
            Console.WriteLine("\n Option 1 - Basic Calculator");
            Console.WriteLine(" Option 2 - Scientific Calculator");
            Console.WriteLine(" Option 3 - Clear Console");
            Console.WriteLine(" Option 4 - Exit");
            Console.Write("\n Enter the above option : ");
            int option1 = Int32.Parse(Console.ReadLine());

            switch (option1)
            {
                case 1:
                    {
                    BasicCalculator:
                        Console.WriteLine("\n Option 1 - Addiction");
                        Console.WriteLine(" Option 2 - Subtraction");
                        Console.WriteLine(" Option 3 - Multipilcation");
                        Console.WriteLine(" Option 4 - Division");
                        Console.Write("\n Enter the above option : ");
                        int option2 = Int32.Parse(Console.ReadLine());

                        switch (option2)
                        {
                            case 1:
                                basic.Addiction();
                                goto Calculator;
                            case 2:
                                basic.Subtraction();
                                goto Calculator;
                            case 3:
                                basic.Multiplication();
                                goto Calculator;
                            case 4:
                                basic.Division();
                                goto Calculator;
                            default:
                                Console.WriteLine("\n Invalid  Option....");
                                goto Calculator;
                        }
                    }
                case 2:
                    {
                        Console.WriteLine("\n Option 1 - MatrixOperation");
                        Console.WriteLine(" Option 2 - LogOperation");
                        Console.WriteLine(" Option 3 - Exponational");
                        Console.Write("\n Enter the above option : ");
                        int option3 = Int32.Parse(Console.ReadLine());

                        switch (option3)
                        {
                            case 1:
                                scientific.MatrixOperation();
                                goto Calculator;
                            case 2:
                                scientific.LogOperation();
                                goto Calculator;
                            case 3:
                                scientific.Exponational();
                                goto Calculator;
                            case 4:
                                basic.Division();
                                goto Calculator;
                            default:
                                Console.WriteLine("\n Invalid Option....");
                                goto Calculator;
                        }
                    }
                case 3:
                    Console.Clear();
                    goto Calculator;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("\n Invalid Option....");
                    goto Calculator;
            }
        }
    }
}

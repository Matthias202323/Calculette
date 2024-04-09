using System.Diagnostics.Metrics;

namespace Calculette
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("First operand :");

                string input = Console.ReadLine();
                float first = float.Parse(input);

                Console.WriteLine("Second operand :");
                string input2 = Console.ReadLine();
                float second = float.Parse(input2);

                Console.WriteLine("Which operation ?");
                string op = Console.ReadLine();
                switch (op)
                {
                    case "add":
                    case "+":
                        Add(first, second);
                        break;
                    case "multiply":
                    case "x":
                        Multiply(first, second);
                        break;
                    case "substract":
                    case "-":
                        Substract(first, second);
                        break;
                    case "divide":
                    case "/":
                        Divide(first, second);
                        break;
                    case "modulo":
                    case "%":
                        Modulo(first, second);
                        break;
                    default:
                        Console.WriteLine("Invalid Operation");
                        break;
                }
            }
        }
        static void Add(float input , float input2)
        {
            float addResult = input + input2;
            Console.WriteLine(input + " + " + input2 + " = " + addResult);
        }
        static void Substract(float input, float input2)
        {
            float subResult = input - input2;
            Console.WriteLine(input + " - " + input2 + " = " + subResult);

        }
        static void Multiply(float input, float input2)
        {
            
            float mulResult = input * input2;
            Console.WriteLine(input + " x " + input2 + " = " + mulResult);
            
        }
        static void Divide(float input, float input2)
        {

            float divResult = input / input2;
            Console.WriteLine(input + " / " + input2 + " = " + divResult);

        }
        static void Modulo(float input, float input2)
        {
            float modResult = input % input2;
            Console.WriteLine(input + " % " + input2 + " = " + modResult);
        }
    }
}

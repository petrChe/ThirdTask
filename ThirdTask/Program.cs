using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdTask
{
    class Program
    {
        static void Main(string[] args)
        {
                GcdOperator firstOperator = new GcdOperator(30, 18);
                Console.WriteLine("The LCD of {0},{1} = {2}", firstOperator.firstNumber, firstOperator.secondNumber,
                    firstOperator.FindEuclidGcd(firstOperator.firstNumber, firstOperator.secondNumber));
                GcdOperator secondOperator = new GcdOperator(78, 294, 570);
                long time;
                Console.WriteLine("The LCD of {0},{1},{2} = {3}", secondOperator.firstNumber, secondOperator.secondNumber,
                    secondOperator.thirdNumber, secondOperator.FindEuclidGcd(secondOperator.firstNumber, secondOperator.secondNumber, secondOperator.thirdNumber, out time));
                Console.WriteLine("Milliseconds of executing method {0}", time);
                long milliseconds;
                Console.WriteLine("The LCD of {0},{1} = {2}", firstOperator.firstNumber, firstOperator.secondNumber,
                   firstOperator.FindBinaryGcd(firstOperator.firstNumber, firstOperator.secondNumber, out milliseconds));
                Console.WriteLine("Milliseconds of executing method {0}", milliseconds);
                Console.ReadKey();
            }
        }
    }


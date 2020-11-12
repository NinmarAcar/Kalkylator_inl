using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkylator_inl
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum;
            int secondNum;
            int thirdNum;
            string operation1;
            string operation2;
            int answer = 0;
            //
            Console.WriteLine("Hej, använd Ninmars Kalkylator för mindre huvudvärk;)");
            Console.ReadLine();

            Console.Write("Skriv in det första talet:");
            firstNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dags att använda sig av en operator ( x , / , +, -) ");
            operation1 = Console.ReadLine();

            Console.Write("Var god och mata in det andra talet: ");
            secondNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Dags att använda sig andra operatorn ( x , / , +, -) ");
            operation2 = Console.ReadLine();

            Console.Write("Skriv in det tredje talet:");
            thirdNum = Convert.ToInt32(Console.ReadLine());



            if (operation1 == "x" && operation2 == "x")
            {
                answer = firstNum * secondNum * thirdNum;
                Console.WriteLine(firstNum + " x " + secondNum + " x " + thirdNum + " = " + answer);
                Console.ReadLine();
            }
            else if (operation1 == "/" && operation2 == "/")
            {
                answer = firstNum / secondNum / thirdNum;
                Console.WriteLine(firstNum + " / " + secondNum + " / " + thirdNum + " = " + answer);
                Console.ReadLine();
            }
            else if (operation1 == "+" && operation2 == "+")
            {
                answer = firstNum + secondNum + thirdNum;
                Console.WriteLine(firstNum + " + " + secondNum + " + " + thirdNum + " = " + answer);
                Console.ReadLine();
            }
            else if (operation1 == "-" && operation2 == "-")
            {
                answer = firstNum - secondNum - thirdNum;
                Console.WriteLine(firstNum + " - " + secondNum + " - " + thirdNum + " = " + answer);
                Console.ReadLine();
            }
            else if (operation1 == "x" && operation2 == "+")
            {
                answer = firstNum * secondNum + thirdNum;
                Console.WriteLine(firstNum + " x " + secondNum + " + " + thirdNum + " = " + answer);
                Console.ReadLine();
            }
            else if (operation1 == "x" && operation2 == "/")
            {
                answer = firstNum * secondNum / thirdNum;
                Console.WriteLine(firstNum + " x " + secondNum + " / " + thirdNum + " = " + answer);
                Console.ReadLine();
            }
            else if (operation1 == "x" && operation2 == "-")
            {
                answer = firstNum * secondNum - thirdNum;
                Console.WriteLine(firstNum + " x " + secondNum + " - " + thirdNum + " = " + answer);
                Console.ReadLine();
            }
            else if (operation1 == "/" && operation2 == "x")
            {
                answer = firstNum / secondNum * thirdNum;
                Console.WriteLine(firstNum + " / " + secondNum + " x " + thirdNum + " = " + answer);
                Console.ReadLine();
            }
            else if (operation1 == "/" && operation2 == "x")
            {
                answer = firstNum / secondNum + thirdNum;
                Console.WriteLine(firstNum + " / " + secondNum + " + " + thirdNum + " = " + answer);
                Console.ReadLine();
            }
            else if (operation1 == "/" && operation2 == "-")
            {
                answer = firstNum / secondNum - thirdNum;
                Console.WriteLine(firstNum + " / " + secondNum + " - " + thirdNum + " = " + answer);
                Console.ReadLine();
            }
            else if (operation1 == "+" && operation2 == "x")
            {
                answer = firstNum + secondNum * thirdNum;
                Console.WriteLine(firstNum + " + " + secondNum + " x " + thirdNum + " = " + answer);
                Console.ReadLine();
            }
            else if (operation1 == "+" && operation2 == "/")
            {
                answer = firstNum + secondNum / thirdNum;
                Console.WriteLine(firstNum + " + " + secondNum + " / " + thirdNum + " = " + answer);
                Console.ReadLine();
            }
            else if (operation1 == "+" && operation2 == "-")
            {
                answer = firstNum + secondNum - thirdNum;
                Console.WriteLine(firstNum + " + " + secondNum + " - " + thirdNum + " = " + answer);
                Console.ReadLine();
            }
            else if (operation1 == "-" && operation2 == "x")
            {
                answer = firstNum - secondNum * thirdNum;
                Console.WriteLine(firstNum + " - " + secondNum + " x " + thirdNum + " = " + answer);
                Console.ReadLine();
            }
            else if (operation1 == "-" && operation2 == "/")
            {
                answer = firstNum - secondNum / thirdNum;
                Console.WriteLine(firstNum + " - " + secondNum + " / " + thirdNum + " = " + answer);
                Console.ReadLine();
            }
            else if (operation1 == "-" && operation2 == "+")
            {
                answer = firstNum - secondNum + thirdNum;
                Console.WriteLine(firstNum + " - " + secondNum + " + " + thirdNum + " = " + answer);
                Console.ReadLine();
            }
        }
    }
}

using System;

int firstNumber,secondNumber;

System.Console.Write("first Number: ");
firstNumber=Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("-----------------------------------------------------------------------------------");
System.Console.WriteLine("Enter one of the arithmetic operations!\nFor example: \"+\", \"-\", \"*\", \"/\", \"%\"");
System.Console.WriteLine("-----------------------------------------------------------------------------------");
string operation =Console.ReadLine();

System.Console.Write("second Number: ");
secondNumber=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();

// switch(operation)
// {
//   case "+":
//           System.Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
//           System.Console.Write($"Result: {firstNumber} + {secondNumber} = {firstNumber+secondNumber}");
//           System.Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
//           break;
//   case "-":
//           System.Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
//           System.Console.WriteLine($"Result: {firstNumber} - {secondNumber} = {firstNumber-secondNumber}");
//           System.Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
//           break;
//   case "*":
//           System.Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
//           System.Console.WriteLine($"Result: {firstNumber} * {secondNumber} = {firstNumber*secondNumber}");
//           System.Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
//           break;
//   case "/":
//           System.Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
//           System.Console.WriteLine($"Result: {firstNumber} / {secondNumber} = {firstNumber/secondNumber}");
//           System.Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
//           break;
//   case "%":
//           System.Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
//           System.Console.WriteLine($"Result: {firstNumber} % {secondNumber} = {firstNumber%secondNumber}");
//           System.Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
//           break;
//   default:
//           System.Console.WriteLine("Operation not found!");
//           break;
// }

string result = operation switch
{
      "+" => $"$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$\nResult: {firstNumber} + {secondNumber} = {firstNumber+secondNumber} \n$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$",
      "-" => $"$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$\nResult: {firstNumber} - {secondNumber} = {firstNumber-secondNumber} \n$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$",
      "*" => $"$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$\nResult: {firstNumber} * {secondNumber} = {firstNumber*secondNumber} \n$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$",
      "/" => $"$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$\nResult: {firstNumber} / {secondNumber} = {firstNumber/secondNumber} \n$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$",
      "%" => $"$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$\nResult: {firstNumber} % {secondNumber} = {firstNumber%secondNumber} \n$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$",
      _ => "Operation not found!"
};
System.Console.WriteLine(result);

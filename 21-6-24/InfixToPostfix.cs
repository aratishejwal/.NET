using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter an infix expression:");
        string infix = Console.ReadLine();
        string postfix = ConvertInfixToPostfix(infix);
        Console.WriteLine("Postfix expression: " + postfix);
    }

    static string ConvertInfixToPostfix(string infix)
    {
        Stack<char> operators = new Stack<char>();
        List<char> output = new List<char>();

        foreach (char token in infix)
        {
            if (char.IsLetterOrDigit(token))
            {
                output.Add(token);
            }
            else if (token == '(')
            {
                operators.Push(token);
            }
            else if (token == ')')
            {
                while (operators.Count > 0 && operators.Peek() != '(')
                {
                    output.Add(operators.Pop());
                }
                if (operators.Count > 0 && operators.Peek() == '(')
                {
                    operators.Pop();
                }
            }
            else if (IsOperator(token))
            {
                while (operators.Count > 0 && Precedence(operators.Peek()) >= Precedence(token))
                {
                    output.Add(operators.Pop());
                }
                operators.Push(token);
            }
        }

        while (operators.Count > 0)
        {
            output.Add(operators.Pop());
        }

        return new string(output.ToArray());
    }

    static bool IsOperator(char token)
    {
        return token == '+' || token == '-' || token == '*' || token == '/';
    }

    static int Precedence(char token)
    {
        switch (token)
        {
            case '+':
            case '-':
                return 1;
            case '*':
            case '/':
                return 2;
            default:
                return 0;
        }
    }
}

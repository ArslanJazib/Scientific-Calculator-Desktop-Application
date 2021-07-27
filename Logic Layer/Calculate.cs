using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicTier
{
    public class Calculate
    {
             
        public double calculateOutput(string current_input)
        {
            if (current_input.Contains("abs("))
            {
                current_input = calculate_abs(current_input);          
            }
            if (current_input.Contains((char)(Operators.PLUS)) ||
                    current_input.Contains((char)(Operators.MINUS)) ||
                    current_input.Contains((char)(Operators.MULTIPLY)) ||
                    current_input.Contains((char)(Operators.MODULUS)) ||
                    current_input.Contains((char)(Operators.DIVIDE)))
            {
                string postfix_expression = convertor(current_input);
                double answer = evaluator(postfix_expression);
                return answer;
            }
            else
            {
                double answer = double.Parse(current_input);
                return answer;
            }
            return 0.0;
        }
        public string calculate_abs(string current_input)
        {
            string value = "";
            string result = "";
            int x = 0;
            while (true)
            {
                if(x<current_input.Length)
                {
                    if (current_input[x] == 'a')
                    {
                        int index = x + 4;
                        while (current_input[index] != ')')
                        {
                            value += current_input[index];
                            index++;
                        }
                        x = index - 1;
                        result = Math.Abs(decimal.Parse(value)).ToString();
                        current_input = current_input.Replace("abs(" + value + ")", result);

                    }
                    else
                    {
                        x++;
                    }
                }
                else
                {
                    break;
                }
            }
            return current_input;
        }
        public string validate(string current_input, string button_name)
        {
            if (button_name == "dec")
            {
                return decimalOutput(current_input);
            }
            if (button_name == "braces")
            {
                return bracesOutput(current_input);
            }
            if (button_name=="bar")
            {
                return barOutput(current_input);
            }
            if (button_name == "minus" || button_name=="plus"||
                button_name=="multiply"|| button_name=="mod" || button_name=="divide")
            {
                if(button_name=="minus")
                {
                    return OperatorOutput(current_input,"-");
                }
                else if (button_name == "plus")
                {
                    return OperatorOutput(current_input, "+");
                }
                if (button_name == "multiply")
                {
                    return OperatorOutput(current_input, "x");
                }
                if (button_name == "mod")
                {
                    return OperatorOutput(current_input, "%");
                }
                if (button_name == "divide")
                {
                    return OperatorOutput(current_input, "/");
                }
            }
            if(button_name=="denote")
            {
                return denoteOutput(current_input);

            }
            if(button_name=="pi")
            {
                return piOutput(current_input);
            }
            if(button_name=="sqrt")
            {
                return sqrtOutput(current_input);

            }
            if(button_name=="fraction")
            {
                return fractionOutput(current_input);
            }
            if(button_name=="factorial")
            {
                return factorialOutput(current_input);
            }
            if(button_name=="square")
            {
                return squareOutput(current_input);
            }
            if (button_name == "cube")
            {
                return cubeOutput(current_input);
            }
            if(button_name=="power")
            {
                return powerOutput(current_input);
            }
            if(button_name== "exponent")
            {
                return exponentOutput(current_input);
            }
            if(button_name=="sin")
            {
                return sinOutput(current_input);
            }
            if (button_name == "sin^-1")
            {
                return sin_inverseOutput(current_input);
            }
            if (button_name == "cos")
            {
                return cosOutput(current_input);
            }
            if (button_name == "cos^-1")
            {
                return cos_inverseOutput(current_input);
            }
            if (button_name == "tan")
            {
                return tanOutput(current_input);
            }
            if (button_name == "tan^-1")
            {
                return tan_inverseOutput(current_input);
            }
            if (button_name == "ln")
            {
                return lnOutput(current_input);
            }
            if (button_name == "log_2")
            {
                return log_baseOutput(current_input);
            }
            return "";
        }
        public string lnOutput(string current_input)
        {
            if (current_input != "")
            {
                if (current_input.Contains("("))
                {
                    char check = current_input.ElementAt(current_input.Length - 1);
                    if (check != (char)Operators.PLUS &&
                    check != (char)Operators.MINUS &&
                    check != (char)Operators.MULTIPLY &&
                    check != (char)Operators.DIVIDE &&
                    check != (char)Operators.MODULUS && check != '(')
                    {
                        current_input += "x ln(";
                    }
                    else
                    {
                        current_input += "ln(";
                    }
                    return current_input;
                }
                if (balance_parentheses(current_input) == true)
                {
                    char check = current_input.ElementAt(current_input.Length - 1);
                    if (check != (char)Operators.PLUS &&
                    check != (char)Operators.MINUS &&
                    check != (char)Operators.MULTIPLY &&
                    check != (char)Operators.DIVIDE &&
                    check != (char)Operators.MODULUS && check != '(')
                    {
                        current_input += "x ln(";
                    }
                    else
                    {
                        current_input += "ln(";
                    }
                    return current_input;
                }
                else
                {
                    current_input += ")";
                    return current_input;
                }
            }
            else
            {
                current_input = "ln(";
                return current_input;
            }
        }
        public string log_baseOutput(string current_input)
        {
            if (current_input != "")
            {
                if (current_input.Contains("("))
                {
                    char check = current_input.ElementAt(current_input.Length - 1);
                    if (check != (char)Operators.PLUS &&
                    check != (char)Operators.MINUS &&
                    check != (char)Operators.MULTIPLY &&
                    check != (char)Operators.DIVIDE &&
                    check != (char)Operators.MODULUS && check != '(')
                    {
                        current_input += "x log2(";
                    }
                    else
                    {
                        current_input += "log2(";
                    }
                    return current_input;
                }
                if (balance_parentheses(current_input) == true)
                {
                    char check = current_input.ElementAt(current_input.Length - 1);
                    if (check != (char)Operators.PLUS &&
                    check != (char)Operators.MINUS &&
                    check != (char)Operators.MULTIPLY &&
                    check != (char)Operators.DIVIDE &&
                    check != (char)Operators.MODULUS && check != '(')
                    {
                        current_input += "x log2(";
                    }
                    else
                    {
                        current_input += "log2(";
                    }
                    return current_input;
                }
                else
                {
                    current_input += ")";
                    return current_input;
                }
            }
            else
            {
                current_input = "log2(";
                return current_input;
            }
        }
        public string tan_inverseOutput(string current_input)
        {
            if (current_input != "")
            {
                if (current_input.Contains("("))
                {
                    char check = current_input.ElementAt(current_input.Length - 1);
                    if (check != (char)Operators.PLUS &&
                    check != (char)Operators.MINUS &&
                    check != (char)Operators.MULTIPLY &&
                    check != (char)Operators.DIVIDE &&
                    check != (char)Operators.MODULUS && check != '(')
                    {
                        current_input += "x tan^-1(";
                    }
                    else
                    {
                        current_input += "tan^-1(";
                    }
                    return current_input;
                }
                if (balance_parentheses(current_input) == true)
                {
                    char check = current_input.ElementAt(current_input.Length - 1);
                    if (check != (char)Operators.PLUS &&
                    check != (char)Operators.MINUS &&
                    check != (char)Operators.MULTIPLY &&
                    check != (char)Operators.DIVIDE &&
                    check != (char)Operators.MODULUS && check != '(')
                    {
                        current_input += "x tan^-1(";
                    }
                    else
                    {
                        current_input += "tan^-1(";
                    }
                    return current_input;
                }
                else
                {
                    current_input += ")";
                    return current_input;
                }
            }
            else
            {
                current_input = "tan^-1(";
                return current_input;
            }
        }
        public string tanOutput(string current_input)
        {
            if (current_input != "")
            {
                if (current_input.Contains("("))
                {
                    char check = current_input.ElementAt(current_input.Length - 1);
                    if (check != (char)Operators.PLUS &&
                    check != (char)Operators.MINUS &&
                    check != (char)Operators.MULTIPLY &&
                    check != (char)Operators.DIVIDE &&
                    check != (char)Operators.MODULUS && check != '(')
                    {
                        current_input += "x tan(";
                    }
                    else
                    {
                        current_input += "tan(";
                    }
                    return current_input;
                }
                else if (balance_parentheses(current_input) == true)
                {
                    char check = current_input.ElementAt(current_input.Length - 1);
                    if (check != (char)Operators.PLUS &&
                    check != (char)Operators.MINUS &&
                    check != (char)Operators.MULTIPLY &&
                    check != (char)Operators.DIVIDE &&
                    check != (char)Operators.MODULUS && check != '(')
                    {
                        current_input += "x tan(";
                    }
                    else
                    {
                        current_input += "tan(";
                    }
                    return current_input;
                }
                else
                {
                    current_input += ")";
                    return current_input;
                }
            }
            else
            {
                current_input = "tan(";
                return current_input;
            }
        }
        public string cos_inverseOutput(string current_input)
        {
            if (current_input != "")
            {
                if (current_input.Contains("("))
                {
                    char check = current_input.ElementAt(current_input.Length - 1);
                    if (check != (char)Operators.PLUS &&
                    check != (char)Operators.MINUS &&
                    check != (char)Operators.MULTIPLY &&
                    check != (char)Operators.DIVIDE &&
                    check != (char)Operators.MODULUS && check != '(')
                    {
                        current_input += "x cos^-1(";
                    }
                    else
                    {
                        current_input += "cos^-1(";
                    }
                    return current_input;
                }
                if (balance_parentheses(current_input) == true)
                {
                    char check = current_input.ElementAt(current_input.Length - 1);
                    if (check != (char)Operators.PLUS &&
                    check != (char)Operators.MINUS &&
                    check != (char)Operators.MULTIPLY &&
                    check != (char)Operators.DIVIDE &&
                    check != (char)Operators.MODULUS && check != '(')
                    {
                        current_input += "x cos^-1(";
                    }
                    else
                    {
                        current_input += "cos^-1(";
                    }
                    return current_input;
                }
                else
                {
                    current_input += ")";
                    return current_input;
                }
            }
            else
            {
                current_input = "cos^-1(";
                return current_input;
            }
        }
        public string cosOutput(string current_input)
        {
            if (current_input != "")
            {
                if (current_input.Contains("("))
                {
                    char check = current_input.ElementAt(current_input.Length - 1);
                    if (check != (char)Operators.PLUS &&
                    check != (char)Operators.MINUS &&
                    check != (char)Operators.MULTIPLY &&
                    check != (char)Operators.DIVIDE &&
                    check != (char)Operators.MODULUS && check != '(')
                    {
                        current_input += "x cos(";
                    }
                    else
                    {
                        current_input += "cos(";
                    }
                    return current_input;
                }
                else if (balance_parentheses(current_input) == true)
                {
                    char check = current_input.ElementAt(current_input.Length - 1);
                    if (check != (char)Operators.PLUS &&
                    check != (char)Operators.MINUS &&
                    check != (char)Operators.MULTIPLY &&
                    check != (char)Operators.DIVIDE &&
                    check != (char)Operators.MODULUS && check != '(')
                    {
                        current_input += "x cos(";
                    }
                    else
                    {
                        current_input += "cos(";
                    }
                    return current_input;
                }
                else
                {
                    current_input += ")";
                    return current_input;
                }
            }
            else
            {
                current_input = "cos(";
                return current_input;
            }
        }
        public string sin_inverseOutput(string current_input)
        {
            if (current_input != "")
            {
                if (current_input.Contains("("))
                {
                    char check = current_input.ElementAt(current_input.Length - 1);
                    if (check != (char)Operators.PLUS &&
                    check != (char)Operators.MINUS &&
                    check != (char)Operators.MULTIPLY &&
                    check != (char)Operators.DIVIDE &&
                    check != (char)Operators.MODULUS && check != '(')
                    {
                        current_input += "x sin^-1(";
                    }
                    else
                    {
                        current_input += "sin^-1(";
                    }
                    return current_input;
                }
                if (balance_parentheses(current_input) == true)
                {
                    char check = current_input.ElementAt(current_input.Length - 1);
                    if (check != (char)Operators.PLUS &&
                    check != (char)Operators.MINUS &&
                    check != (char)Operators.MULTIPLY &&
                    check != (char)Operators.DIVIDE &&
                    check != (char)Operators.MODULUS && check != '(')
                    {
                        current_input += "x sin^-1(";
                    }
                    else
                    {
                        current_input += "sin^-1(";
                    }
                    return current_input;
                }
                else
                {
                    current_input += ")";
                    return current_input;
                }
            }
            else
            {
                current_input = "sin^-1(";
                return current_input;
            }
        }
        public string sinOutput(string current_input)
        {
            if (current_input != "")
            {
                if (current_input.Contains("("))
                {
                    char check = current_input.ElementAt(current_input.Length - 1);
                    if (check != (char)Operators.PLUS &&
                    check != (char)Operators.MINUS &&
                    check != (char)Operators.MULTIPLY &&
                    check != (char)Operators.DIVIDE &&
                    check != (char)Operators.MODULUS && check != '(')
                    {
                        current_input += "x sin(";
                    }
                    else
                    {
                        current_input += "sin(";
                    }
                    return current_input;
                }
                else if (balance_parentheses(current_input) == true)
                {
                    char check = current_input.ElementAt(current_input.Length - 1);
                    if (check != (char)Operators.PLUS &&
                    check != (char)Operators.MINUS &&
                    check != (char)Operators.MULTIPLY &&
                    check != (char)Operators.DIVIDE &&
                    check != (char)Operators.MODULUS && check != '(')
                    {
                        current_input += "x sin(";
                    }
                    else
                    {
                        current_input += "sin(";
                    }
                    return current_input;
                }
                else
                {
                    current_input += ")";
                    return current_input;
                }
            }
            else
            {
                current_input = "sin(";
                return current_input;
            }
        }
        public string exponentOutput(string current_input)
        {
            if (current_input != "")
            {
                char check = current_input.ElementAt(current_input.Length - 1);
                if (check != (char)Operators.PLUS &&
                check != (char)Operators.MINUS &&
                check != (char)Operators.MULTIPLY &&
                check != (char)Operators.DIVIDE &&
                check != (char)Operators.MODULUS && check != '(')
                {
                    current_input += " x 2.718^";
                }
                else
                {
                    current_input += " 2.718^";
                }
                return current_input;
            }
            else
            {
                current_input += " 2.718^";
                return current_input;

            }
        }
        public string powerOutput(string current_input)
        {
            if (current_input != "")
            {
                char check = current_input.ElementAt(current_input.Length - 1);
                if (check >= '0' && check <= '9')
                {
                    current_input += "^";
                    return current_input;
                }
            }
            return current_input;
        }
        public string cubeOutput(string current_input)
        {
            if (current_input != "")
            {
                char check = current_input.ElementAt(current_input.Length - 1);
                if (check >= '0' && check <= '9')
                {
                    current_input += "^3";
                    return current_input;
                }
            }
            return current_input;
        }
        public string squareOutput(string current_input)
        {
            if (current_input != "")
            {
                char check = current_input.ElementAt(current_input.Length - 1);
                if (check >= '0' && check <= '9')
                {
                    current_input += "^2";
                    return current_input;
                }
            }
            return current_input;
        }
        public string factorialOutput(string current_input)
        {
            if(current_input!="")
            {
                char check = current_input.ElementAt(current_input.Length - 1);
                if (check>='0'&&check<='9')
                {
                    current_input=current_input.Insert(current_input.Length - 1, "(");
                    current_input += "!)";
                    return current_input;
                }
            }
            return current_input;
        }
        public string fractionOutput(string current_input)
        {
            if (current_input != "")
            {
                if (current_input.Contains("("))
                {
                    char check = current_input.ElementAt(current_input.Length - 1);
                    if(check != (char)Operators.PLUS &&
                    check != (char)Operators.MINUS &&
                    check != (char)Operators.MULTIPLY &&
                    check != (char)Operators.DIVIDE &&
                    check != (char)Operators.MODULUS &&check!='(')
                    {
                        current_input += "x1/(";
                    }
                    else
                    {
                        current_input += "1/(";
                    }
                    return current_input;
                }
                else if (balance_parentheses(current_input) == true)
                {
                    char check = current_input.ElementAt(current_input.Length - 1);
                    if (check != (char)Operators.PLUS &&
                    check != (char)Operators.MINUS &&
                    check != (char)Operators.MULTIPLY &&
                    check != (char)Operators.DIVIDE &&
                    check != (char)Operators.MODULUS && check != '(')
                    {
                        current_input += "x1/(";
                    }
                    else
                    {
                        current_input += "1/(";
                    }
                    return current_input;
                }
                else
                {
                    current_input += ")";
                    return current_input;
                }
            }
            else
            {
                current_input = "1/(";
                return current_input;
            }
        }
        public string sqrtOutput(string current_input)
        {
            if (current_input != "")
            {
                if (current_input.Contains("("))
                {
                    char check = current_input.ElementAt(current_input.Length - 1);
                    if (check != (char)Operators.PLUS &&
                    check != (char)Operators.MINUS &&
                    check != (char)Operators.MULTIPLY &&
                    check != (char)Operators.DIVIDE &&
                    check != (char)Operators.MODULUS && check != '(')
                    {
                        current_input += "x(sqrt(";
                    }
                    else
                    {
                        current_input += "sqrt(";
                    }
                    return current_input;
                }
                else if (balance_parentheses(current_input) == true)
                {
                    char check = current_input.ElementAt(current_input.Length - 1);
                    if (check != (char)Operators.PLUS &&
                    check != (char)Operators.MINUS &&
                    check != (char)Operators.MULTIPLY &&
                    check != (char)Operators.DIVIDE &&
                    check != (char)Operators.MODULUS && check != '(')
                    {
                        current_input += "x(sqrt(";
                    }
                    else
                    {
                        current_input += "sqrt(";
                    }
                    return current_input;
                }
                else
                {
                    current_input += ")";
                    return current_input;
                }
            }
            else
            {
                current_input = "sqrt(";
                return current_input;
            }
        }
        public string piOutput(string current_input)
        {
            if (current_input != "")
            {
                char check = current_input.ElementAt(current_input.Length - 1);
                if (check != (char)Operators.PLUS &&
                check != (char)Operators.MINUS &&
                check != (char)Operators.MULTIPLY &&
                check != (char)Operators.DIVIDE &&
                check != (char)Operators.MODULUS && check != '(')
                {
                    current_input += " x pi";
                }
                else
                {
                    current_input += "pi";
                }
                return current_input;
            }
            else
            {
                current_input += "pi";
                return current_input;

            }
        }
        public string denoteOutput(string current_input)
        {
            if (current_input != "")
            {
                if (current_input.Contains("("))
                {
                    char check = current_input.ElementAt(current_input.Length - 1);
                    if (check != (char)Operators.PLUS &&
                    check != (char)Operators.MINUS &&
                    check != (char)Operators.MULTIPLY &&
                    check != (char)Operators.DIVIDE &&
                    check != (char)Operators.MODULUS && check != '(')
                    {
                        current_input += "x(-1x(";
                    }
                    else
                    {
                        current_input += "-1x(";
                    }
                    return current_input;
                }
                else if (balance_parentheses(current_input) == true)
                {
                    char check = current_input.ElementAt(current_input.Length - 1);
                    if (check != (char)Operators.PLUS &&
                    check != (char)Operators.MINUS &&
                    check != (char)Operators.MULTIPLY &&
                    check != (char)Operators.DIVIDE &&
                    check != (char)Operators.MODULUS && check != '(')
                    {
                        current_input += "x(-1x(";
                    }
                    else
                    {
                        current_input += "-1x(";
                    }
                    return current_input;
                }
                else
                {
                    current_input += ")";
                    return current_input;
                }
            }
            else
            {
                current_input = "-1x(";
                return current_input;
            }
        }
        public string OperatorOutput(string current_input,string Operator)
        {
            char check = ' ';
            try
            {
                 check = current_input.ElementAt(current_input.Length - 1);
            }
            catch(Exception e)
            {
                current_input = " ";
                check = current_input.ElementAt(current_input.Length - 1);
            }
            if (current_input != "" &&
                check != (char)Operators.PLUS &&
                check != (char)Operators.MINUS &&
                check != (char)Operators.MULTIPLY &&
                check != (char)Operators.DIVIDE &&
                check != (char)Operators.MODULUS
                )
            {
                current_input += Operator;
                return current_input;
            }
            else
            {
                return current_input;
            }
        }
        public string barOutput(string current_input)
        {
            if (current_input != "")
            {
                if (current_input.Contains("("))
                {
                    char check = current_input.ElementAt(current_input.Length - 1);
                    if (check != (char)Operators.PLUS &&
                    check != (char)Operators.MINUS &&
                    check != (char)Operators.MULTIPLY &&
                    check != (char)Operators.DIVIDE &&
                    check != (char)Operators.MODULUS && check!='(')
                    {
                        current_input += "x(abs(";
                    }
                    else
                    {
                        current_input += "abs(";
                    }
                    return current_input;
                }
                else if (balance_parentheses(current_input) == true)
                {
                    char check = current_input.ElementAt(current_input.Length - 1);
                    if (check != (char)Operators.PLUS &&
                    check != (char)Operators.MINUS &&
                    check != (char)Operators.MULTIPLY &&
                    check != (char)Operators.DIVIDE &&
                    check != (char)Operators.MODULUS && check != '(')
                    {
                        current_input += "x(abs(";
                    }
                    else
                    {
                        current_input += "abs(";
                    }
                    return current_input;
                }
                else
                {
                    current_input = ")";
                    return current_input;
                }
            }
            else
            {
                current_input = "abs(";
                return current_input;
            }
        } 
        public string decimalOutput(string current_input)
        {
            bool flag1 = false;
            bool flag2 = false;
            if (current_input .Length==0)
            {
                current_input = "0.";
                flag1 = true;
            }
            else
            {
                foreach(char c in current_input)
                {
                    if(c!='.')
                    {
                        flag2 = true;
                    }
                }
            }
            if(flag1==false || flag2==true)
            {
                current_input += ".";
            }
            return current_input;
        }
        public string bracesOutput(string current_input)
        {
            if(current_input!="")
            {
                char check = current_input.ElementAt(current_input.Length - 1);

                if (check == '(')
                {
                    current_input += '(';
                    return current_input;
                }
                else if (balance_parentheses(current_input) == true)
                {
                    current_input+='(';
                    return current_input;
                }
                else
                {
                    current_input += ")";
                    return current_input;
                }
            }
            else
            {
                current_input = "(";
                return current_input;
            }
        }
        public bool balance_parentheses(string exp)
        {
            int size = exp.Length;
            int count1 = 0, count2 = 0;
            Stack<char> inputStack = new Stack<char>(size);
            for (int loop1 = 0; loop1 != size; loop1++)
            {
                // Pushing the opening parentheses and counting them
                if (exp[loop1] == '(')
                {
                    inputStack.Push(exp[loop1]);
                    count1++;
                }
                // counting the closing parentheses
                if (exp[loop1] == ')')
                {
                    count2++;
                }
                //Poping the opening parentheses because of closing parentheses
                if (exp[loop1] == ')' && inputStack.Peek() == '(')
                {
                    inputStack.Pop();
                }
            }
            // If stack is empty then the expression is valid
            if (inputStack.Count == 0 && count1 == count2)
            {
                return true;
            }
            else
            {
                return false;
            }

        }





        // Function to evaluate postfix expression
        public double evaluator(string exp)
        {
            int size = exp.Length;
            double op1, op2, ans = 0;
            int count = 0;
            Stack<double> inputStack = new Stack<double>(size);
            for (int loop1 = 0; loop1 < size; loop1++)
            {
                if(exp[loop1]==' ')
                {
                    continue;
                }
                else if(exp[loop1]>='0'&&exp[loop1]<='9')
                {
                    string digit = "";
                    int index=loop1;
                    while(true)
                    {
                        if (exp[index] >= '0' && exp[index] <= '9'|| exp[index] == '.')
                        {
                            digit += exp[index];
                            index++;
                            loop1 = index-1;
                        }
                        else
                        {
                            break;
                        }
                    }
                    inputStack.Push(double.Parse(digit));
                }
                // Evaluating the expression
                else
                {
                    if(exp[loop1]!='!')
                    {
                        try
                        {
                            op1 = inputStack.Pop();

                        }
                        catch (Exception e)
                        {
                            op1 = 0;
                        }
                        try
                        {
                            op2 = inputStack.Pop();
                        }
                        catch (Exception e)
                        {
                            op2 = 0;

                        }
                        try
                        {
                            switch (exp[loop1])
                            {
                                case '+':

                                    ans = op2 + op1;

                                    break;
                                case '-':

                                    ans = op2 - op1;

                                    break;
                                case 'x':
                                    ans = op2 * op1;
                                    break;
                                case '/':

                                    ans = op2 / op1;
                                    break;
                                case '%':
                                    ans = op2 % op1;
                                    break;
                                case '^':
                                    ans = double.Parse(Math.Pow(op2, op1).ToString());
                                    break;


                            }
                        }
                        catch (Exception e)
                        {
                            return 0;
                        }
                        inputStack.Push(ans);
                    }
                    else
                    {
                        try
                        {
                            try
                            {
                                op1 = inputStack.Pop();

                            }
                            catch (Exception e)
                            {
                                op1 = 0;
                            }
                            switch (exp[loop1])
                            {

                                case '!':
                                    ans = op1;
                                    for (double i = op1 - 1; i >= 1; i--)
                                    {
                                        ans = ans * i;
                                    }
                                    break;
                            }
                            inputStack.Push(ans);
                        }
                        catch (Exception e)
                        {

                        }
                    }
                }
            }
            return inputStack.Pop();

        }

        // Function for setting precedence of operators
        public bool precedence(char op1, char op2)
        {
            // Opening parentheses has the highest precedence
            if (op1 == '(')
            {
                return false;
            }
            int p1 = 0, p2 = 0, p3 = 0;
            // Setting precedence of the operator already in the stack
            switch (op1)
            {
                case '^':
                    {
                        p3 = 3;
                        break;
                    }
                case '/':
                case 'x':
                case '%':
                    {
                        p1 = 2;
                        break;
                    }
                case '+':
                case '-':
                    {
                        p1 = 1;
                        break;
                    }
            }
            // Setting precedence of operator which is being pushed in the stack
            switch (op2)
            {
                case '^':
                    {
                        p3 = 3;
                        break;
                    }
                case '/':
                case 'x':
                case '%':
                    {
                        p2 = 2;
                        break;
                    }
                case '+':
                case '-':
                    {
                        p2 = 1;
                        break;
                    }
            }
            // Comaring the precedence of both operators
            if (p1 >= p2 && p1>=p3)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        // Function to convert infix into postfix
        public string convertor(string current_input)
        {
 
            current_input = current_input.Replace("pi", "3.141592");
            string converted = "";
            int size = 0;
            int length = current_input.Length;
            // Calculating the size of the stack
            for (int loop5 = 0; loop5 <length; loop5++)
            {
                switch (current_input[loop5])
                {
                    
                    case '(':
                    case ')':
                    case '/':
                    case 'x':
                    case '+':
                    case '-':
                    case '%':
                    case '^':
                    case '!':
                    
                        {
                            size++;
                            break;
                        }
                }
            }
            Stack<char> s4 = new Stack<char>(size);
            for (int loop6 = 0; loop6 < length; loop6++)
            {
                // For operands
                if ((current_input[loop6] >= '0' && current_input[loop6] <= '9'))
                {

                    string multidigit_number = current_input[loop6].ToString();
                    int index = (loop6)+1;
                    if (index < length)
                    {
                        while (index < length)
                        {
                            if((current_input[index] >= '0' && current_input[index] <= '9')|| current_input[index] == '.')
                            {
                                multidigit_number += current_input[index].ToString();
                                index++;
                                loop6++;
                            }
                            else
                            {
                                break;

                            }
                        }
                    }
                    converted += " "+multidigit_number;
                }
                // Pushing operators in the stack
                else
                {
                    // Pushing opening parentheses in the stack
                    switch (current_input[loop6])
                    {
                        case '(':
                            {
                                s4.Push(current_input[loop6]);
                                break;
                            }
                        // Poping values from the stack due to closing parentheses
                        case ')':
                            {
                                while (s4.Peek() != '(')
                                {
                                    converted += s4.Peek();
                                    s4.Pop();
                                }
                                s4.Pop();
                                break;
                            }
                        // Pushing operators in the stack
                        case '/':
                        case 'x':
                        case '%':
                        case '+':
                        case '-':
                        case '^':
                        case '!':
                        
                            {
                                char c = current_input[loop6];
                                /* Comparing the precedence of the top value of the stack
                                with the one which is being pushed*/
                                while (s4.Count != 0 && precedence(s4.Peek(), current_input[loop6]) == true)
                                {
                                    char temp= s4.Peek();
                                    s4.Pop();
                                    converted += temp;
                                }
                                s4.Push(current_input[loop6]);
                                break;
                            }
                    }

                }
            }
            // Writing the operators left in the stack 
            while (s4.Count!=0)
            {
                converted += s4.Pop();
            }
            return converted;
        }

    }
}

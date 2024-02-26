using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorGUI
{
    public partial class Calculatorinator : Form
    {
        public Calculatorinator()
        {
            InitializeComponent();
        }
        private void InputButClick(object sender, EventArgs e)
        {
            DisplayLabel.Text += (sender as Button).Text;
        }

        private void CalcEquation(object sender, EventArgs e)
        {
            String PostFix = ParseInfix(DisplayLabel.Text);
            Double result = CalPostFix(PostFix);
            Math.Round(result, 5);
            DisplayLabel.Text = result.ToString();
        }

        private void DeleteInput(object sender, EventArgs e)
        {
            if(DisplayLabel.Text.Length > 0)
                DisplayLabel.Text = DisplayLabel.Text.Substring(0, DisplayLabel.Text.Length - 1);
        }

        private void ClearInputs(object sender, EventArgs e)
        {
            DisplayLabel.Text = "";
        }

        static string ParseInfix(String s)
        {
            String pString = "";
            int curInx = 0;
            Stack<Char> pStack = new Stack<Char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (!Char.IsDigit(s[i]))
                {
                    if (pStack.Count == 0)
                    {
                        pStack.Push(s[i]);
                        pString += s.Substring(curInx, i - curInx) + ",";
                    }
                    else if (s[i] == '(') //Handles ( and ) Scenarios
                    {
                        pStack.Push(s[i]);
                    }
                    else if (s[i] == ')')
                    {
                        pString += s.Substring(curInx, i - curInx) + ",";
                        while (!pStack.Peek().Equals('('))
                        {
                            pString += pStack.Pop() + ",";
                        }
                        pStack.Pop();
                    }
                    else //Special cases handled, now can work just off priorty.
                    {
                        if (i != curInx)
                            pString += s.Substring(curInx, i - curInx) + ",";
                        if (SetPrec(s[i]) > SetPrec(pStack.Peek()))
                        {
                            pStack.Push(s[i]);
                        }
                        else
                        {
                            while (pStack.Count > 0 && (SetPrec(s[i]) <= SetPrec(pStack.Peek())))
                            {
                                pString += pStack.Pop() + ",";
                            }
                            pStack.Push(s[i]);
                        }

                    }

                    curInx = i + 1;
                }

                if (i == s.Length - 1)
                {
                    pString += s.Substring(curInx) + ",";
                }

            }



            while (pStack.Count != 1)
            {
                pString += pStack.Pop() + ",";
            }

            pString += pStack.Pop();
            return pString;
        }

        private static int SetPrec(char c)
        {
            if (c == '^')
                return 3;
            else if (c == '*' || c == '/')
                return 2;
            else if (c == '+' || c == '-')
                return 1;
            else
                return 0;

        }

        private static double CalPostFix(string s)
        {
            String[] sArr = s.Split(',');
            double temp, A, B;
            Console.WriteLine(sArr.Length);

            Stack<double> pStack = new Stack<double>();

            foreach (String s2 in sArr)
            {
                if (!Double.TryParse(s2, out temp))
                {
                    switch (s2)
                    {
                        case "+":
                            A = pStack.Pop();
                            B = pStack.Pop();
                            temp = A + B;
                            pStack.Push(temp);
                            break;
                        case "-":
                            A = pStack.Pop();
                            B = pStack.Pop();
                            temp = B - A;
                            pStack.Push(temp);
                            break;
                        case "*":
                            A = pStack.Pop();
                            B = pStack.Pop();
                            temp = A * B;
                            pStack.Push(temp);
                            break;
                        case "/":
                            A = pStack.Pop();
                            B = pStack.Pop();
                            temp = B / A;
                            pStack.Push(temp);
                            break;
                        case "^":
                            A = pStack.Pop();
                            B = pStack.Pop();
                            temp = Math.Pow(B, A);
                            pStack.Push(temp);
                            break;
                        default: break;

                    }
                }
                else
                {
                    pStack.Push(Convert.ToDouble(s2));
                }
            }

            return pStack.Pop();
        }

        private void Calculatorinator_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InfixPrefixPostfixConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int OperatörÖnceliği(char op)
        {
            if (op == '+' || op == '-') return 1;
            if (op == '*' || op == '/') return 2;
            if (op == '^') return 3;
            return 0;
        }
        private string InfixToPostfix(string infix)
        {
            var çıktı = new List<string>();
            var yığın = new Stack<char>();

            foreach (char karakter in infix)
            {
                if (char.IsLetterOrDigit(karakter))  
                {
                    çıktı.Add(karakter.ToString());
                }
                else if (karakter == '(')  
                {
                    yığın.Push(karakter);
                }
                else if (karakter == ')')  
                {
                    while (yığın.Count > 0 && yığın.Peek() != '(')
                    {
                        çıktı.Add(yığın.Pop().ToString());
                    }
                    yığın.Pop();  
                }
                else  
                {
                    while (yığın.Count > 0 && OperatörÖnceliği(yığın.Peek()) >= OperatörÖnceliği(karakter))
                    {
                        çıktı.Add(yığın.Pop().ToString());
                    }
                    yığın.Push(karakter);  
                }
            }

            while (yığın.Count > 0)
            {
                çıktı.Add(yığın.Pop().ToString());
            }

            return string.Join(" ", çıktı); 
        }

        private string InfixToPrefix(string infix)
        {
            char[] tersInfix = infix.ToCharArray();
            Array.Reverse(tersInfix);
            string tersInfixStr = new string(tersInfix);

            tersInfixStr = tersInfixStr.Replace('(', '#');
            tersInfixStr = tersInfixStr.Replace(')', '(');
            tersInfixStr = tersInfixStr.Replace('#', ')');

            string postfix = InfixToPostfix(tersInfixStr);

            string[] postfixDizi = postfix.Split(' ');
            Array.Reverse(postfixDizi);
            return string.Join(" ", postfixDizi);  
        }
        private void btnToPostfix_Click(object sender, EventArgs e)
        {
            string infix = txtInfix.Text;  
            lblPostfix.Text = "Postfix: " + InfixToPostfix(infix);  
        }
        private void btnToPrefix_Click(object sender, EventArgs e)
        {
            string infix = txtInfix.Text;  
            lblPrefix.Text = "Prefix: " + InfixToPrefix(infix);  
        }
    }
}

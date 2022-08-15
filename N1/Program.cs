using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N1
{
    internal class Program //Дана строка, содержащая скобки трёх видов (круглые, квадратные и фигурные) и любые другие символы. Проверить, корректно ли в ней расставлены скобки. Например, в строке ([]{})[] скобки расставлены корректно, а в строке ([]] — нет. Указание: задача решается однократным проходом по символам заданной строки слева направо; для каждой открывающей скобки в строке в стек помещается соответствующая закрывающая, каждая закрывающая скобка в строке должна соответствовать скобке из вершины стека (при этом скобка с вершины стека снимается); в конце прохода стек должен быть пуст. Стек: коллекция (первый вошел, последний вышел)
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            Console.WriteLine(Chek(str));
            Console.ReadKey();
        }

        static bool Chek(string str)
        { 
            Stack<char> stack = new Stack<char>();  //Коллекция символов строки
            Dictionary<char, char> sk = new Dictionary<char, char>
            {
                {'(',')' },
                {'[',']' },
                {'{','}' },
            };

            foreach(char c in str)
            {
                if (c == '(' || c == '[' || c == '{')
                    stack.Push(sk[c]);
                if (c == ')' || c == ']' || c == '}')
                {
                    if (stack.Count == 0 || stack.Pop()!=c)
                    {
                        return false;
                    }


                }

            }
            if (stack.Count == 0)
                return true;
            else
                return false;

            
        }

    }
}

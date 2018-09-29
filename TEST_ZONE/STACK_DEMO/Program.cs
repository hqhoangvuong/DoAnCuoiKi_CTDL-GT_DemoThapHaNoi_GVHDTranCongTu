using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace STACK_DEMO
{
    public class Program
    {
        public struct ThuTuc
        {
            public int N;
            public char A;
            public char B;
            public char C;
        };

        static void Main(string[] args)
        {
            ThuTuc X = new ThuTuc();
            X.N = int.Parse(Console.ReadLine());
            X.A = 'A';
            X.B = 'B';
            X.C = 'C';

            Stack<ThuTuc> myStack = new Stack<ThuTuc>();
            ThuTuc temp = new ThuTuc();
            ThuTuc temp1 = new ThuTuc();
            myStack.Push(X);
            do
            {
                temp = myStack.Pop();
                if (temp.N == 1)
                    Console.WriteLine("{0} {1}", temp.A, temp.B);
                else
                {
                    temp1.N = temp.N - 1;
                    temp1.A = temp.C;
                    temp1.B = temp.B;
                    temp1.C = temp.A;
                    myStack.Push(temp1);
                    temp1.N = 1;
                    temp1.A = temp.A;
                    temp1.B = temp.B;
                    temp1.C = temp.C;
                    myStack.Push(temp1);
                    temp1.N = temp.N - 1;
                    temp1.A = temp.A;
                    temp1.B = temp.C;
                    temp1.C = temp.B;
                    myStack.Push(temp1);
                }
            } while (myStack.Count != 0);
            Console.ReadKey();
        }
    }
}


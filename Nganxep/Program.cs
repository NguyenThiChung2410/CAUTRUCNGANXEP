﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nganxep
{
    class Stack 
    {
        private int[] data;
        private int top;

        public Stack()
        {
            data = new int[100];
            top = -1;

        }
        public Stack(int size)
        {
            data = new int[size];
            top = -1;
        }
        public bool isEmpty()
        {
            bool kq = false;
            if (top == -1)
                kq = true;
            return kq;
                  
        }
        public bool isFull()
        {
            bool kq = false;
            if (top == data.Length - 1)
                kq = true;
            return kq;
        }
        public void Push(int x)
        {
            if (isFull())
            {
                Console.WriteLine("Stack da day.Them that bai");
            }
            else
            {
                top++;
                data[top] = x;
            }
        }
        public int Pop()
        {
            int kq = 0;
            if (isEmpty())
            {
                Console.WriteLine("stack da day.Them that bai");
            }
            else
            {
                kq = data[top--];

            }
            return kq;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            
            Console.Write("Nhap co so he 10: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Nhap co so can doi: ");
            int x = int.Parse(Console.ReadLine());

            
            while (n > 0)
            {
                s.Push(n % x);
                n = n / x;
            }
            int value;
            Console.Write($"Bieu dien he {x}:");
            while (!s.isEmpty())
            {
                value = s.Pop();
                if (x == 16)
                {
                    switch (value)
                    {
                        case 10:
                            Console.Write("A");
                            break;
                        case 11:
                            Console.Write("B");
                            break;
                        case 12:
                            Console.Write("C");
                            break;
                        case 13:
                            Console.Write("D");
                            break;
                        case 14:
                            Console.Write("E");
                            break;
                        case 15:
                            Console.Write("F");
                            break;
                        case 16:
                            Console.Write("G");
                            break;
                        default:
                            Console.Write(value);
                            break;
                    }
                }
            }
            Console.ReadLine();
        }
    }
}

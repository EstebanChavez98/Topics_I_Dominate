using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stacks_Example
{
    class Stack
    {
        private int max;
        private int top;
        private int[] stack;
        public Stack() { }
        public Stack(int _max)
        {
            stack = new int[_max];
            max = _max;
            top = -1;
        }
        public bool fullStack()
        {
            if(top == max - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool emptyStack()
        {
            if(top == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void push(int n)
        {
            if (fullStack())
            {
                MessageBox.Show("Full Stack");
            }
            else
            {
                top++; stack[top] = n;
            }
        }
        public int pop()
        {
            int n = 0;
            if (emptyStack())
            {
                MessageBox.Show("Empty Stack");
                return n;
            }
            else
            {
                n = stack[top];
                top--;
                return n;
            }
        }
    }
}

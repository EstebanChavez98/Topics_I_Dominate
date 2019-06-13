using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueueExample
{
    class Queue
    {
        private int front;
        private int behind;
        private int[] queue;
        private int maximum;
        public Queue() { }
        public Queue(int max)
        {
            front = -1; behind = -1;
            maximum = max;
            queue = new int[maximum];
        }
        public bool fullQueue()
        {
            if(behind == maximum - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool emptyQueue()
        {
            if(front == maximum - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void addQueue(int n)
        {
            if (fullQueue())
            {
                MessageBox.Show("Fill Queue");
            }
            else
            {
                behind++;
                queue[behind] = n;
                if (behind == 0)
                {
                    front = 0;
                }
            }
        }
        public int deleteQueue()
        {
            int n = -666;
            if (emptyQueue())
            {
                MessageBox.Show("Empty Queue");
            }
            else
            {
                n = queue[front];
                if(front == behind)
                {
                    front = -1;
                    behind = -1;
                }
                else
                {
                    front++;
                }
            }
            return n;
        }
    }
}

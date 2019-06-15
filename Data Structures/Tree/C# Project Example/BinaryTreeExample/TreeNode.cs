using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeExample
{
    public class TreeNode
    {
        public int data;
        public String name;
        public TreeNode LeftSon, RightSon;
        public TreeNode(int d, String nam)
        {
            this.data = d;
            this.name = nam;
            this.LeftSon = null;
            this.RightSon = null;
        }
        public String toString()
        {
            return name + ", and it's number is " + data;
        }
    }
}

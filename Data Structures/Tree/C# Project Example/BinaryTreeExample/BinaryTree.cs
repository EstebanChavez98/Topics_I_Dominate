using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeExample
{
    public class BinaryTree
    {
        TreeNode root;
        public BinaryTree()
        {
            root = null;
        }
        //Method to insert a node in the tree
        public void addNode(int d, String nam)
        {
            TreeNode _new = new TreeNode(d, nam);
            if (root == null)
            { root = _new; }
            else
            {
                TreeNode aux = root;
                TreeNode father;
                while (true)
                {
                    father = aux;
                    if (d < aux.data)
                    {
                        aux = aux.LeftSon;
                        if (aux == null)
                        {
                            father.LeftSon = _new;
                            return;
                        }
                    }
                    else
                    {
                        aux = aux.RightSon;
                        if (aux == null)
                        {
                            father.RightSon = _new;
                            return;
                        }
                    }
                }
            }
        }
        //Method to know if the tree is empty
        public bool isEmpty()
        {
            return root == null;
        }
        //Method to travel the tree in inOrder
        public void inOrder(TreeNode r)
        {
            if (r != null)
            {
                inOrder(r.LeftSon);
                //Componente (r.data);
                inOrder(r.RightSon);
            }
        }
        //Method to travel the tree in preOrder
        public void preOrder(TreeNode r)
        {
            if (r != null)
            {
                //Componente (r.data);
                preOrder(r.LeftSon);
                preOrder(r.RightSon);
            }
        }
        //Method to travel the tree in postOrder
        public void postOrder(TreeNode r)
        {
            if (r != null)
            {
                postOrder(r.LeftSon);
                postOrder(r.RightSon);
                //Componente (r.data);
            }
        }
        //Method to search a node in the tree
        public TreeNode searchNode(int d)
        {
            TreeNode aux = root;
            while (aux.data != d)
            {
                if (d < aux.data)
                { aux = aux.LeftSon; }
                else
                { aux = aux.RightSon; }
                if (aux == null)
                { return null; }
            }
            return aux;
        }
        //Method to delete a node from the tree
        public bool delete(int d)
        {
            TreeNode aux = root;
            TreeNode father = root;
            bool isLeftSon = true;
            while (aux.data != d)
            {
                father = aux;
                if (d < aux.data)
                {
                    isLeftSon = true;
                    aux = aux.LeftSon;
                }
                else
                {
                    isLeftSon = false;
                    aux = aux.RightSon;
                }
                if (aux == null)
                {
                    return false;
                }
            }//While end
            if (aux.LeftSon == null && aux.RightSon == null)
            {
                if (aux == root)
                {
                    root = null;
                }
                else if (isLeftSon)
                {
                    father.LeftSon = null;
                }
                else
                {
                    father.RightSon = null;
                }
            }
            else if (aux.RightSon == null)
            {
                if (aux == root)
                {
                    root = aux.LeftSon;
                }
                else if (isLeftSon)
                {
                    father.LeftSon = aux.LeftSon;
                }
                else
                {
                    father.RightSon = aux.LeftSon;
                }
            }
            else if (aux.LeftSon == null)
            {
                if (aux == root)
                {
                    root = aux.RightSon;
                }
                else if (isLeftSon)
                {
                    father.LeftSon = aux.RightSon;
                }
                else
                {
                    father.RightSon = aux.LeftSon;
                }
            }
            else
            {
                TreeNode replace = getReplace(aux);
                if (aux == root)
                {
                    root = replace;
                }
                else if (isLeftSon)
                {
                    father.LeftSon = replace;
                }
                else
                {
                    father.RightSon = replace;
                }
                replace.LeftSon = aux.LeftSon;
            }
            return true;
        }
        //Method in charge to return the node to replace
        public TreeNode getReplace(TreeNode nodeR)
        {
            TreeNode replace_father = nodeR;
            TreeNode replace = nodeR;
            TreeNode aux = nodeR.RightSon;
            while (aux != null)
            {
                replace_father = replace;
                replace = aux;
                aux = aux.LeftSon;
            }
            if (replace != nodeR.LeftSon)
            {
                replace_father.LeftSon = replace.LeftSon;
                replace.RightSon = nodeR.RightSon;
            }
            //Componente ("The replace node is: " + replace);
            return replace;
        }
    }
}

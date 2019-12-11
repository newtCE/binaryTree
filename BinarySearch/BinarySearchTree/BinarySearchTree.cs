using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BinarySearchTree
    {
        public Node root;
        public BinarySearchTree()
        {
            root = null;    //used to specify the beginning
        }
        public bool Search(int data)
        {
            Node targetNode = root;
            if (data == targetNode.data)
            {
                return true;
            }
            else
            {
                while (true)
                {
                    if (data < targetNode.data && targetNode.leftChild != null)
                    {
                        targetNode = targetNode.leftChild;
                        if (data == targetNode.data)
                        {
                            return true;
                        }
                    }
                    else if (data > targetNode.data && targetNode.rightChild != null)
                    {
                        targetNode = targetNode.rightChild;
                        if (data == targetNode.data)
                        {
                            return true;
                        }
                    }
                    else
                    {
                        return false; //no paths to check
                    }
                }
            }

        }
        public void Add(int data)
        {
            Node nodeTemp = new Node();
            nodeTemp.data = data;
            if (root == null) //is this the start point
            {
                root = nodeTemp; //now it is
            }
            else
            {
                nodeTemp = root;    //temporary node
                Node parent; 
                while (true)
                {
                    parent = nodeTemp;
                    if (data < nodeTemp.data)
                    {
                        nodeTemp = nodeTemp.leftChild;
                        if (nodeTemp == null)
                        {
                            parent.leftChild = nodeTemp;
                            break;
                        }

                    }
                    else
                    {
                        nodeTemp = nodeTemp.rightChild;
                        if (nodeTemp == null)
                        {
                            parent.rightChild = nodeTemp;
                            break;
                        }
                    }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree testTree = new BinarySearchTree();
            testTree.Add(40);
            testTree.Add(38);
            testTree.Add(41);
            testTree.Add(50);
            testTree.Add(51);
            testTree.Search(40);
            testTree.Search(50);
            testTree.Search(66);


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BinaryTree
    {
        public Node Root { get; set;}

        public bool Add(int Value)
        {
            Node before = null, after = this.Root;
            
            while(after != null)
            {
                before = after;
                if (Value < after.Data)
                {
                    after = after.LeftNode;
                }
                else if(Value > after.Data)
                {
                    after = after.RightNode;
                }
                else
                {
                    return false;
                }
            }

            Node newnode = new Node();
            newnode.Data = Value;
            if(this.Root == null)
            {
                this.Root = newnode;
            }
            else
            {
                if (Value<before.Data)
                {
                    before.LeftNode = newnode;
                }
                else
                {
                    before.RightNode = newnode;
                }
            }
            return true;
        }


        public void TravarsePreorder(Node Parent)
        {
            if (Parent != null)
            {
                Console.WriteLine(Parent.Data + " ");
                TravarsePreorder(Parent.LeftNode);
                TravarsePreorder(Parent.RightNode);
            }
        }




    }
}

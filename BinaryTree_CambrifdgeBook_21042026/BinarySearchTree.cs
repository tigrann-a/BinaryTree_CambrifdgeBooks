namespace BinaryTree_CambrifdgeBook_21042026;

public class BinarySearchTree
{
    public Node root;

    public BinarySearchTree()
    {
        root = null;
    }

    public void Insert(int i)
    {
        Node newNode = new Node();
        newNode.Value = i;
        if (root == null)
        {
            root = newNode;
        }
        else
        {
            Node current = root;
            Node parent;
            while (true)
            {
                parent = current;
                if (i < current.Value)
                {
                    current = current.Left;
                    if (current == null)
                    {
                        parent.Left = newNode;
                        break;
                    }
                }
                else
                {
                    current = current.Right;
                    if (current == null)
                    {
                        parent.Right = newNode;
                        break;
                    }
                }
            }
        } 
    }

    #region In-Order Traversal
    public void InOrder(Node theRoot)
    {
        if(theRoot != null)
        {
            InOrder(theRoot.Left);
            theRoot.DisplayNode();
            InOrder(theRoot.Right);
        }
    }

    #endregion

    #region Pre-Order Traversal
    public void PreOrder(Node theRoot)
    {
        if(theRoot != null)
        {
            theRoot.DisplayNode();
            PreOrder(theRoot.Left);
            PreOrder(theRoot.Right);
        }
    }

    #endregion

    #region Post-Order Traversal
    public void PostOrder(Node theRoot)
    {
        if(theRoot != null)
        {
            PostOrder(theRoot.Left);
            PostOrder(theRoot.Right);
            theRoot.DisplayNode();
        }
    }

    #endregion

    public int FindMin()
    {
        Node current = root;
        while(current.Left != null)
            current = current.Left;
        return current.Value;
    }

    public int FindMax()
    {
        Node current = root;
        while(current.Right != null)
            current = current.Right;
        return current.Value;
    }

    public int Find(int key)
    {
        Node current = root;
        while(current.Value != key)
        {
            if (key < current.Value)
            {
                current = current.Left;
            }
            else if(key > current.Value)
            {
                current = current.Right;
            }
            else if(current == null)
            {
                return -1;
            }
        }

        return current.Value;
    }
}

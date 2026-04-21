using BinaryTree_CambrifdgeBook_21042026;

BinarySearchTree numbers = new BinarySearchTree();

numbers.Insert(10);
numbers.Insert(23);
numbers.Insert(18);
numbers.Insert(34);
numbers.Insert(68);
numbers.Insert(8);
numbers.Insert(13);
numbers.Insert(1);
numbers.Insert(4);

Console.WriteLine("In-Order Traversal: ");

//numbers.InOrder(numbers.root);
//numbers.PreOrder(numbers.root);
numbers.PostOrder(numbers.root);
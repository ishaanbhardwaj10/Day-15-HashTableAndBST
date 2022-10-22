namespace HashTableAndBST
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Welcome to HashTable and Binary Search Tree Problems");
            Console.WriteLine("Use Case #1: Create a Binary Search Tree");
            Console.WriteLine("Use Case #2: Create the Binary Tree shown in figure");

            Console.Write("Choose a use case number to run the program: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    BinarySearchTree<int> treeOne = new BinarySearchTree<int>(56);
                    treeOne.Insert(30);
                    treeOne.Insert(70);
                    treeOne.Display();
                    break;
                case 2:
                    BinarySearchTree<int> treeTwo = new BinarySearchTree<int>(56);
                    treeTwo.Insert(30);
                    treeTwo.Insert(70);
                    treeTwo.Insert(22);
                    treeTwo.Insert(40);
                    treeTwo.Insert(60);
                    treeTwo.Insert(95);
                    treeTwo.Insert(11);
                    treeTwo.Insert(65);
                    treeTwo.Insert(3);
                    treeTwo.Insert(16);
                    treeTwo.Insert(63);
                    treeTwo.Insert(67);
                    treeTwo.Display();
                    Console.WriteLine("-------------------------------");
                    treeTwo.GetSize();
                    Console.WriteLine("-------------------------------");
                    break;
                default:
                    Console.WriteLine("Please enter a valid use case number!");
                    break;
            }


        }
    }
}
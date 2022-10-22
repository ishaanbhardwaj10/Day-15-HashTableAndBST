namespace HashTableAndBST
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Welcome to HashTable and Binary Search Tree Problems");
            Console.WriteLine("Use Case #1: Create a Binary Search Tree");

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
                default:
                    Console.WriteLine("Please enter a valid use case number!");
                    break;
            }


        }
    }
}
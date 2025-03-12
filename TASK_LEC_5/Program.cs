namespace TASK_LEC_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome My App { Wael Mohamed abdou }");
            List<int> numbers = new List<int>();
            char choice;
            do
            {
                Console.WriteLine("**************************************");
                Console.WriteLine(@"Please Choose from menu : 
A - Add Item.
B - Display Items.
M - Dispaly Mean of numbers.
S - Display the smallest number.
L - Display the largest number.
R - Sort List.
F - Find Number.
C - Clear List.
Q - Quit Program.");
                choice = char.ToUpper(Convert.ToChar(Console.ReadLine()));
                Console.Clear();
                switch (choice)
                {
                    case 'A':
                        Console.WriteLine("Please Enter Number");
                        bool isInt = int.TryParse(Console.ReadLine(), out int number);

                        if (isInt)
                        {
                            bool isDuplicate = false;

                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] == number)
                                {
                                    isDuplicate = true;
                                    break;
                                }
                            }
                            if (isDuplicate)
                            {
                                Console.WriteLine($"Found {number} in List. Are you sure you want to add it again? (Y: Yes, N: No)");
                                char chooseDuplicate = char.ToUpper(Convert.ToChar(Console.ReadLine()));

                                if (chooseDuplicate == 'Y')
                                {
                                    numbers.Add(number);
                                    Console.WriteLine($"{number} is added to the list.");
                                }
                                else
                                {
                                    Console.WriteLine("-----------------------------------------");
                                    Console.WriteLine("Transaction Canceled.");
                                    Console.WriteLine("-----------------------------------------");
                                }
                            }
                            else
                            {
                                numbers.Add(number);
                                Console.WriteLine("-----------------------------------------");
                                Console.WriteLine($"{number} is added to the list.");
                                Console.WriteLine("-----------------------------------------");
                            }
                        }
                        else
                        {
                            Console.WriteLine("-----------------------------------------");
                            Console.WriteLine("Invalid Number. Please enter a valid number.");
                            Console.WriteLine("-----------------------------------------");
                        }
                        break; // A - Add Item
                    case 'B':
                        if (numbers.Count == 0)
                        {
                            Console.WriteLine("----------------------------");
                            Console.WriteLine("The list is empty.");
                            Console.WriteLine("----------------------------");
                        }
                        else
                        {
                            Console.WriteLine("------- Items in List:-----");
                            Console.WriteLine($"Count  Item in list : {numbers.Count}");
                            string listshow = string.Join(" ", numbers);
                            Console.WriteLine($"[ {listshow} ] ");
                            Console.WriteLine("----------------------------");
                        }
                        break; //B - Display Items
                    case 'M': // Mean Numbers In List
                        if (numbers.Count == 0)
                        {
                            Console.WriteLine("----------------------------");
                            Console.WriteLine("The list is empty.");
                            Console.WriteLine("----------------------------");
                        }
                        else
                        {
                            Console.WriteLine("------- Mean Numbers :-----");

                            int SumList = 0;
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                SumList += numbers[i];
                            }
                            Console.WriteLine("-----------------------------------------");
                            Console.WriteLine($"Mean Numbers In List = {(double)(SumList / numbers.Count)}");
                            Console.WriteLine("-----------------------------------");
                        }
                        break;
                    case 'S': // Smallest Number In List 
                        if (numbers.Count == 0)
                        {
                            Console.WriteLine("----------------------------");
                            Console.WriteLine("The list is empty.");
                            Console.WriteLine("----------------------------");
                        }
                        else
                        {
                            Console.WriteLine("------- Smallest Number  :-----");

                            int smallestNmuber = numbers[0];
                            for (int i = 1; i < numbers.Count; i++)
                            {
                                smallestNmuber = numbers[i] < smallestNmuber ? numbers[i] : smallestNmuber;
                            }
                            Console.WriteLine($"Smallest Number in  List = {smallestNmuber}");
                            Console.WriteLine("-----------------------------------");
                        }
                        break;
                    case 'L': // largest  Number In List 
                        if (numbers.Count == 0)
                        {
                            Console.WriteLine("----------------------------");
                            Console.WriteLine("The list is empty.");
                            Console.WriteLine("----------------------------");
                        }
                        else
                        {
                            Console.WriteLine("------- largest Number  :-----");

                            int largestNmuber = numbers[0];
                            for (int i = 1; i < numbers.Count; i++)
                            {
                                largestNmuber = numbers[i] > largestNmuber ? numbers[i] : largestNmuber;
                            }
                            Console.WriteLine("-----------------------------------");
                            Console.WriteLine($"largest Number in  List = {largestNmuber}");
                            Console.WriteLine("-----------------------------------");
                        }
                        break;
                    case 'R': // Sort  Number In List 
                        if (numbers.Count == 0)
                        {
                            Console.WriteLine("----------------------------");
                            Console.WriteLine("The list is empty.");
                            Console.WriteLine("----------------------------");
                        }
                        else
                        {
                            Console.WriteLine("------- Sort Numbers  :-----");
                            char chooseSortType;
                            Console.WriteLine("Please Choose Sort TYpe \nA:Asc\nD:Desc");
                            chooseSortType = char.ToUpper(Convert.ToChar(Console.ReadLine()));
                            switch (chooseSortType)
                            {
                                case 'A': // تصاعدي
                                    for (int i = 0; i < numbers.Count - 1; i++)
                                    {
                                        for (int j = 0; j < numbers.Count - i - 1; j++)
                                        {
                                            if (numbers[j] > numbers[j + 1])
                                            {
                                                int temp = numbers[j];
                                                numbers[j] = numbers[j + 1];
                                                numbers[j + 1] = temp;
                                            }
                                        }
                                    }

                                    Console.WriteLine("List sorted in Ascending order.");

                                    break;

                                case 'D': // تنازلي
                                    for (int i = 0; i < numbers.Count - 1; i++)
                                    {
                                        for (int j = 0; j < numbers.Count - i - 1; j++)
                                        {
                                            if (numbers[j] < numbers[j + 1])
                                            {
                                                int temp = numbers[j];
                                                numbers[j] = numbers[j + 1];
                                                numbers[j + 1] = temp;
                                            }
                                        }
                                    }
                                    Console.WriteLine("List sorted in Descending order.");
                                    break;
                            }

                        }
                        break;
                    case 'F':
                        if (numbers.Count == 0)
                        {
                            Console.WriteLine("----------------------------");
                            Console.WriteLine("The list is empty.");
                            Console.WriteLine("----------------------------");
                        }
                        else
                        {
                            Console.WriteLine("Please Enter Number");
                            bool checkHsInt = int.TryParse(Console.ReadLine(), out int intNumber);
                            if (checkHsInt)
                            {
                                bool isFound = false;
                                int index = 0;

                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    if (numbers[i] == intNumber)
                                    {
                                        isFound = true;
                                        index = i;
                                        break;
                                    }
                                }
                                if (isFound)
                                {
                                    Console.WriteLine($"Found {intNumber} in List. as index {index}");

                                }
                                else
                                {
                                    Console.WriteLine("-----------------------------------------");
                                    Console.WriteLine($"{intNumber} is not found in list.");
                                    Console.WriteLine("-----------------------------------------");
                                }
                            }
                            else
                            {
                                Console.WriteLine("-----------------------------------------");
                                Console.WriteLine("Invalid Number. Please enter a valid number.");
                                Console.WriteLine("-----------------------------------------");
                            }

                        }
                        break; // A - Add Item
                    case 'C': // Clear Number In List 
                        if (numbers.Count == 0)
                        {
                            Console.WriteLine("----------------------------");
                            Console.WriteLine("The list is empty.");
                            Console.WriteLine("----------------------------");
                        }
                        else
                        {
                            Console.Write("Are You Sure Cleard List Y:Yes , N : No ");
                            char chooseSure;
                            chooseSure = char.ToUpper(Convert.ToChar(Console.ReadLine()));
                            if (chooseSure == 'Y')
                            {
                                numbers.Clear();
                                Console.WriteLine("----------------------------");
                                Console.WriteLine("List Is Cleared");
                                Console.WriteLine("----------------------------");
                            }
                            else
                            {
                                Console.WriteLine("----------------------------");
                                Console.WriteLine("TransAction Cancelsd");
                                Console.WriteLine("----------------------------");
                            }

                        }
                        break;
                    case 'Q':
                        Console.WriteLine("Good Bye");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
            while (choice != 'Q');

        }
    }
}

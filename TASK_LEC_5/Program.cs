namespace TASK_LEC_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome My App { Wael Mohamed abdou }");
            List<int> numbers = new List<int>();
            string choice;
            do
            {
                Console.WriteLine("**************************************");
                Console.WriteLine($@"Please Choose from menu : 

A - Add a numbers
P - Print numbers
T - Sum Numbers
M - Display mean of the numbers
S - Display the smallest numbers
L - Display the largest numbers
R - Sort List
F - Find a number
C - Clear list
Q - Quit");

                choice = (Console.ReadLine().ToUpper().Trim());
                if (choice.Length == 1)
                {
                    Console.Clear();
                    switch (choice)
                    {
                        case "A":  // A - Add a number
                            Console.WriteLine("Please Enter Number To added The List numbers");
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
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write($" {number} is already Exites List. Are you sure  want to add it again? (Y: Yes, N: No)");
                                    char chooseDuplicate = char.ToUpper(Convert.ToChar(Console.ReadLine()));
                                    Console.ResetColor();

                                    if (chooseDuplicate == 'Y')
                                    {
                                        numbers.Add(number);
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("-----------------------------------------");
                                        Console.WriteLine($"{number} is added to the list.");
                                        Console.WriteLine("-----------------------------------------");
                                        Console.ResetColor();
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("-----------------------------------------");
                                        Console.WriteLine("Transaction Canceled.");
                                        Console.WriteLine("-----------------------------------------");
                                        Console.ResetColor();
                                    }
                                }
                                else
                                {
                                    numbers.Add(number);
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("-----------------------------------------");
                                    Console.WriteLine($"{number} is added to the list.");
                                    Console.WriteLine("-----------------------------------------");
                                    Console.ResetColor();
                                }
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("-----------------------------------------");
                                Console.WriteLine("Invalid Number. Please enter a valid number.");
                                Console.WriteLine("-----------------------------------------");
                                Console.ResetColor();
                            }
                            break; //A - Add a number
                        case "P":
                            if (numbers.Count == 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("----------------------------");
                                Console.WriteLine("The list is empty.");
                                Console.WriteLine("----------------------------");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("------- Items in List:-----");
                                Console.WriteLine($"Count  Item in list : {numbers.Count}");
                                string listshow = string.Join(" ", numbers);
                                Console.WriteLine($"[ {listshow} ] ");
                                Console.WriteLine("----------------------------");
                                Console.ResetColor();
                            }
                            break; //P - Print numbers
                        case "T": // Mean Numbers In List
                            if (numbers.Count == 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("----------------------------");
                                Console.WriteLine("The list is empty.");
                                Console.WriteLine("----------------------------");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("------- Sum Numbers :-----");

                                int SumList = 0;
                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    SumList += numbers[i];
                                }

                                Console.WriteLine("-----------------------------------------");
                                Console.WriteLine($"Total Numbers In List = {SumList}");
                                Console.WriteLine("-----------------------------------------");
                                Console.ResetColor();
                            }
                            break; //T - Display Sum numbers
                        case "M": // Mean Numbers In List
                            if (numbers.Count == 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("----------------------------");
                                Console.WriteLine("The list is empty.");
                                Console.WriteLine("----------------------------");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("------- Mean Numbers :-----");

                                int SumList = 0;
                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    SumList += numbers[i];
                                }

                                Console.WriteLine("-----------------------------------------");
                                Console.WriteLine($"Mean Numbers In List = {(double)SumList / numbers.Count}");
                                Console.WriteLine("-----------------------------------------");
                                Console.ResetColor();
                            }
                            break; //M - Display mean of the numbers
                        case "S": // Smallest Number In List 
                            if (numbers.Count == 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("----------------------------");
                                Console.WriteLine("The list is empty.");
                                Console.WriteLine("----------------------------");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("------- Smallest Number  :-----");

                                int smallestNmuber = numbers[0];
                                for (int i = 1; i < numbers.Count; i++)
                                {
                                    smallestNmuber = numbers[i] < smallestNmuber ? numbers[i] : smallestNmuber;
                                }

                                Console.WriteLine("-----------------------------------");
                                Console.WriteLine($"Smallest Number in  List = {smallestNmuber}");
                                Console.WriteLine("-----------------------------------");
                                Console.ResetColor();
                            }
                            break; //S - Display the smallest number
                        case "L": // largest  Number In List 
                            if (numbers.Count == 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("----------------------------");
                                Console.WriteLine("The list is empty.");
                                Console.WriteLine("----------------------------");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("------- largest Number  :-----");

                                int largestNmuber = numbers[0];
                                for (int i = 1; i < numbers.Count; i++)
                                {
                                    largestNmuber = numbers[i] > largestNmuber ? numbers[i] : largestNmuber;
                                }
                                Console.WriteLine("-----------------------------------");
                                Console.WriteLine($"largest Number in  List = {largestNmuber}");
                                Console.WriteLine("-----------------------------------");
                                Console.ResetColor();
                            }
                            break; //L - Display the largest number
                        case "R": // Sort  Number In List 
                            if (numbers.Count == 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("----------------------------");
                                Console.WriteLine("The list is empty.");
                                Console.WriteLine("----------------------------");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.WriteLine("------- Sort Numbers  :-----");
                                char chooseSortType;
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Please Choose Sort TYpe \nA:Asc\nD:Desc");
                                chooseSortType = char.ToUpper(Convert.ToChar(Console.ReadLine()));
                                Console.ResetColor();
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
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("List sorted in Ascending order.");
                                        Console.ResetColor();

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
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("List sorted in Descending order.");
                                        Console.ResetColor();
                                        break;
                                }

                            }
                            break; //R - Sort List
                        case "F":
                            if (numbers.Count == 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("----------------------------");
                                Console.WriteLine("The list is empty.");
                                Console.WriteLine("----------------------------");
                                Console.ResetColor();
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
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine($"Found {intNumber} in List. as index {index}");
                                        Console.ResetColor();

                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("-----------------------------------------");
                                        Console.WriteLine($"{intNumber} is not found in list.");
                                        Console.WriteLine("-----------------------------------------");
                                        Console.ResetColor();
                                    }
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("-----------------------------------------");
                                    Console.WriteLine("Invalid Number. Please enter a valid number.");
                                    Console.WriteLine("-----------------------------------------");
                                    Console.ResetColor();
                                }

                            }
                            break; //F - Find a number
                        case "C": // Clear Number In List 
                            if (numbers.Count == 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("----------------------------");
                                Console.WriteLine("The list is empty.");
                                Console.WriteLine("----------------------------");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write("Are You Sure Cleard List Y:Yes , N : No ");
                                char chooseSure;
                                chooseSure = char.ToUpper(Convert.ToChar(Console.ReadLine()));
                                Console.ResetColor();
                                if (chooseSure == 'Y')
                                {
                                    numbers.Clear();
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("----------------------------");
                                    Console.WriteLine("List Is Cleared");
                                    Console.WriteLine("----------------------------");
                                    Console.ResetColor();
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("----------------------------");
                                    Console.WriteLine("TransAction Cancelsd");
                                    Console.WriteLine("----------------------------");
                                    Console.ResetColor();

                                }

                            }
                            break; //C - Clear list
                        case "Q":
                            Console.WriteLine("Good Bye");
                            break; //Q - Quit
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("--------------------------------");
                            Console.WriteLine("Invalid Choice");
                            Console.WriteLine("--------------------------------");
                            Console.ResetColor();

                            break;
                    }

                }
                else
                {

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("Pleas Enter One Letter From Menu");
                    Console.WriteLine("--------------------------------");
                    Console.ResetColor();
                }

            }
            while (choice != "Q");

        }
    }
}

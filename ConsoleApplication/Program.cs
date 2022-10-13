using ConsoleApplication;

namespace consoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Students std_obj = new Students();
            string choice = null;
            books book_obj = new books();
            P: {
            Console.Clear();
            }
            Console.WriteLine("1:Students      |     2:Books");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a == 1)
            {
                Console.Clear();
                Console.WriteLine("Please select one of the following options: ");
                while (choice != "w")
                {
                    Console.WriteLine("1. add new student");
                    Console.WriteLine("2. view students");
                    Console.WriteLine("3. update student");
                    Console.WriteLine("4. delete student");
                    Console.WriteLine("5. search student");
                    Console.WriteLine("w. to exit");
                    Console.WriteLine("p. to go on main page");
                    choice = Console.ReadLine();
                    if (choice == "p" || choice == "P")
                        goto P;
                    Console.Clear();
                    switch (Convert.ToInt32(choice))
                    {
                        case 1:
                            std_obj.create_Student();
                            break;
                        case 2:
                            std_obj.read_Student();
                            break;
                        case 3:
                            Console.WriteLine("Enter the ID of a student: ");
                            std_obj.update_Student(Convert.ToInt32(Console.ReadLine()));
                            break;
                        case 4:
                            Console.WriteLine("Enter the ID of a student: ");
                            std_obj.delete_Student(Convert.ToInt32(Console.ReadLine()));
                            break;
                        case 5:
                            Console.Clear();
                            Console.Write("Enter Student Id to Search: ");
                            std_obj.search_Student(Convert.ToInt32(Console.ReadLine()));
                            break;
                        default:
                            Console.WriteLine("Input a valid Number :");
                            break;
                    }
                }
            }
            else if (a == 2)
            {
                Console.Clear();
                Console.WriteLine("Please select one of the following options: ");
                while (choice != "w")
                {
                    Console.WriteLine("1. add new book");
                    Console.WriteLine("2. view books");
                    Console.WriteLine("3. update book");
                    Console.WriteLine("4. delete book");
                    Console.WriteLine("5. search book");
                    Console.WriteLine("6. search issue book from student ID");
                    Console.WriteLine("7. update only student issue id in book record");
                    Console.WriteLine("w. to exit");
                    Console.WriteLine("p. to go on main page");
                    choice = Console.ReadLine();
                    if (choice == "p")
                        goto P;
                    Console.Clear();
                    switch (Convert.ToInt32(choice))
                    {
                        case 1:
                            book_obj.create_book();
                            break;
                        case 2:
                            book_obj.read_book();
                            break;
                        case 3:
                            Console.WriteLine("Enter the ID of a book: ");
                            book_obj.update_book(Convert.ToInt32(Console.ReadLine()));
                            break;
                        case 4:
                            Console.WriteLine("Enter the ID of a book: ");
                            book_obj.delete_book(Convert.ToInt32(Console.ReadLine()));
                            break;
                        case 5:
                            Console.Clear();
                            Console.Write("Enter book Id to Search: ");
                            book_obj.search_book(Convert.ToInt32(Console.ReadLine()));
                            break;
                        case 6:
                            Console.Clear();
                            Console.Write("Enter student Id to Search: ");
                            book_obj.search_book_stdID(Convert.ToInt32(Console.ReadLine()));
                            break;
                        case 7:
                            Console.Clear();
                            Console.Write("Enter student Id to Search: ");
                            book_obj.update_book_stdID(Convert.ToInt32(Console.ReadLine()));
                            break;
                        default:
                            Console.WriteLine("Input a valid Number :");
                            break;
                    }
                }
            }
           /* else
            {
                Console.WriteLine("enter a valid number! ");
                Console.WriteLine("Press any key to continue....");
                Console.ReadKey();
                Console.Clear()

            }*/

           // goto P;
                //Console.Clear();
        }
    }
}
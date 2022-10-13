namespace ConsoleApplication
{
    public class books
    {
        int id,id2;
        string name;

        public void create_book()
        {
            Console.Write("Enter Book ID: ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Book Name: ");
            name = Console.ReadLine();
            Console.Write("Enter Student ID to which this book asign: ");
            id2 = Convert.ToInt32(Console.ReadLine());

            StreamWriter file = new StreamWriter("book.txt", append: true);
            file.WriteLine($"{id}\t{name}\t{id2}");
            file.Flush();
            file.Close();
        }

        public void read_book()
        {
            try
            {
                StreamReader file = new StreamReader("book.txt");
                string[] inputs = file.ReadToEnd().Split("\n");
                for (int i = 0; i < (inputs.Length - 1); i++)
                {
                    string[] variables = inputs[i].Split("\t");
                    id = Convert.ToInt32(variables[0]);
                    name = variables[1];
                    id2 = Convert.ToInt32(variables[2]);

                    Console.WriteLine($"{id} {name} {id2}");
                }
                file.Close();
            }
            catch
            {
                Console.WriteLine("file does not exist:");
                return;
            }
        }

        public void search_book(int bookID)
        {
            try
            {
                StreamReader file = new StreamReader("book.txt");
                string[] inputs = file.ReadToEnd().Split("\n");
                for (int i = 0; i < (inputs.Length - 1); i++)
                {
                    string[] variables = inputs[i].Split("\t");
                    id = Convert.ToInt32(variables[0]);
                    name = variables[1];
                    id2 = Convert.ToInt32(variables[2]);

                    if (id == bookID)
                    {
                        Console.WriteLine($"{id} {name} {id2}");
                    }
                }
                file.Close();
            }
            catch
            {
                Console.WriteLine("record are not Found!");
                return;
            }
        }

        public void update_book(int bookID)
        {
            bool Match = false;
            StreamReader fileR = new StreamReader("book.txt");
            string[] inputs = fileR.ReadToEnd().Split("\n");
            fileR.Close();
            File.Delete("book.txt");
            StreamWriter fileW = new StreamWriter("book.txt", append: true);
            for (int i = 0; i < (inputs.Length - 1); i++)
            {
                string[] variables = inputs[i].Split("\t");
                id = Convert.ToInt32(variables[0]);
                name = variables[1];
                id2 = Convert.ToInt32(variables[2]);

                if (id == bookID)
                {
                    Match = true;
                    Console.Clear();
                    Console.WriteLine("Enter updated record: ");
                    Console.Write("Enter Student ID: ");
                    id = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Student Name: ");
                    name = Console.ReadLine();
                    Console.Write("Enter Student Program: ");
                    id2 = Convert.ToInt32(Console.ReadLine());
                    fileW.WriteLine($"{id}\t{name}\t{id2}");
                }
                else
                {
                    fileW.WriteLine($"{id}\t{name}\t{id2}");
                }
            }
            if (Match)
            {
                Console.Clear();
                Console.WriteLine("Record updated!");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Record not found");
            }
            fileW.Close();
        }

        public void delete_book(int bookID)
        {
            bool Match = false;
            StreamReader fileR = new StreamReader("book.txt");
            string[] inputs = fileR.ReadToEnd().Split("\n");
            fileR.Close();
            File.Delete("book.txt");
            StreamWriter fileW = new StreamWriter("book.txt", append: true);
            for (int i = 0; i < (inputs.Length - 1); i++)
            {
                string[] variables = inputs[i].Split("\t");
                id = Convert.ToInt32(variables[0]);
                name = variables[1];
                id2 = Convert.ToInt32(variables[2]);

                if (id == bookID)
                {
                    Match = true;
                }
                else
                {
                    fileW.WriteLine($"{id}\t{name}\t{id2}");
                }
            }
            if (Match)
            {
                Console.Clear();
                Console.WriteLine("Record deleted!");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Record are not found");
            }
            fileW.Close();
        }

        public void search_book_stdID(int bookID)
        {
            try
            {
                StreamReader file = new StreamReader("book.txt");
                string[] inputs = file.ReadToEnd().Split("\n");
                for (int i = 0; i < (inputs.Length - 1); i++)
                {
                    string[] variables = inputs[i].Split("\t");
                    id = Convert.ToInt32(variables[0]);
                    name = variables[1];
                    id2 = Convert.ToInt32(variables[2]);

                    if (id2 == bookID)
                    {
                        Console.WriteLine($"{id} {name} {id2}");
                    }
                }
                file.Close();
            }
            catch
            {
                Console.WriteLine("record are Not Found!");
                return;
            }
        }

        public void update_book_stdID(int bookID)
        {
            bool Match = false;
            StreamReader fileR = new StreamReader("book.txt");
            string[] inputs = fileR.ReadToEnd().Split("\n");
            fileR.Close();
            File.Delete("book.txt");
            StreamWriter fileW = new StreamWriter("book.txt", append: true);
            for (int i = 0; i < (inputs.Length - 1); i++)
            {
                string[] variables = inputs[i].Split("\t");
                id = Convert.ToInt32(variables[0]);
                name = variables[1];
                id2 = Convert.ToInt32(variables[2]);

                if (id == bookID)
                {
                    Match = true;
                    Console.Clear();
                    Console.Write("Enter new assign Student ID: ");
                    id2 = Convert.ToInt32(Console.ReadLine());
                    fileW.WriteLine($"{id}\t{name}\t{id2}");
                }
                else
                {
                    fileW.WriteLine($"{id}\t{name}\t{id2}");
                }
            }
            if (Match)
            {
                Console.Clear();
                Console.WriteLine("Record updated!");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Record  are not found");
            }
            fileW.Close();
        }
    }
}

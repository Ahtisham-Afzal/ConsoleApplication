
namespace ConsoleApplication
{
    public class Students
    {
        int id;
        string name;
        string program;

        public void create_Student()
        {
            Console.Write("Enter Student ID: ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Student Name: ");
            name = Console.ReadLine();
            Console.Write("Enter Student Program: ");
            program = Console.ReadLine();

            StreamWriter file = new StreamWriter("student.txt", append: true);
            file.WriteLine($"{id}\t{name}\t{program}");
            file.Flush();
            file.Close();

        }

        public void read_Student()
        {
            try
            {
                StreamReader file = new StreamReader("student.txt");
                string[] inputs = file.ReadToEnd().Split("\n");
                for (int i = 0; i < (inputs.Length - 1); i++)
                {
                    string[] variables = inputs[i].Split("\t");
                    id = Convert.ToInt32(variables[0]);
                    name = variables[1];
                    program = variables[2];

                    Console.WriteLine($"{id} {name} {program}");
                }
                file.Close();
            }
            catch
            {
                Console.WriteLine("file does not exist:");
                return;
            }
        }

        public void search_Student(int stdID)
        {
            try
            {
                StreamReader file = new StreamReader("student.txt");
                string[] inputs = file.ReadToEnd().Split("\n");
                for (int i = 0; i < (inputs.Length - 1); i++)
                {
                    string[] variables = inputs[i].Split("\t");
                    id = Convert.ToInt32(variables[0]);
                    name = variables[1];
                    program = variables[2];

                    if (id == stdID)
                    {
                        Console.WriteLine($"{id} {name} {program}");
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

        public void update_Student(int stdId)
        {
            bool Match = false;
            StreamReader fileR = new StreamReader("student.txt");
            string[] inputs = fileR.ReadToEnd().Split("\n");
            fileR.Close();
            File.Delete("student.txt");
            StreamWriter fileW = new StreamWriter("student.txt", append: true);
            for (int i = 0; i < (inputs.Length - 1); i++)
            {
                string[] variables = inputs[i].Split("\t");
                id = Convert.ToInt32(variables[0]);
                name = variables[1];
                program = variables[2];

                if (id == stdId)
                {
                    Match = true;
                    Console.Clear();
                    Console.WriteLine("Enter updated record: ");
                    Console.Write("Enter Student ID: ");
                    id = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Student Name: ");
                    name = Console.ReadLine();
                    Console.Write("Enter Student Program: ");
                    program = Console.ReadLine();
                    fileW.WriteLine($"{id}\t{name}\t{program}");
                }
                else
                {
                    fileW.WriteLine($"{id}\t{name}\t{program}");
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

        public void delete_Student(int stdId)
        {
            bool Match = false;
            StreamReader fileR = new StreamReader("student.txt");
            string[] inputs = fileR.ReadToEnd().Split("\n");
            fileR.Close();
            File.Delete("student.txt");
            StreamWriter fileW = new StreamWriter("student.txt", append: true);
            for (int i = 0; i < (inputs.Length - 1); i++)
            {
                string[] variables = inputs[i].Split("\t");
                id = Convert.ToInt32(variables[0]);
                name = variables[1];
                program = variables[2];

                if (id == stdId)
                {
                    Match = true;
                }
                else
                {
                    fileW.WriteLine($"{id}\t{name}\t{program}");
                }
            }
            if (Match)
            {
                Console.Clear();
                Console.WriteLine("Record  deleted!");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Record are not found");
            }
            fileW.Close();
        }
    }
}

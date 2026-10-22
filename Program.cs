namespace Week2Assignment2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            string address;

            const string path = @"C:\MSSA\10975\Files\";
            Console.WriteLine("Week 2 Assignment 2.3");
            Console.Write("Enter a file name to create a new text file: ");
            string filename = path + Console.ReadLine() + ".txt";

            try
            {
                if (!File.Exists(filename))
                {
                    using (StreamWriter writer = File.CreateText(filename))
                    {
                        Console.Write("What is your name: ");
                        name = Console.ReadLine();
                        Console.Write("What is your age: ");
                        age = int.Parse(Console.ReadLine());
                        Console.Write("What is your street address: ");
                        address = Console.ReadLine();
                        writer.WriteLine($"Name: {name}\nAge: {age} years old\nStreet Address: {address}");
                        Console.WriteLine("File created successfully.");
                    }
                }
                else
                {
                    Console.WriteLine("File already exists.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Reading file contents");

            try
            {
                using (StreamReader sr = new StreamReader(filename))
                {
                    Console.WriteLine(sr.ReadToEnd());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

namespace FileHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    StreamWriter writer = new StreamWriter(@"C:\Users\anami\Svam\C#\Day7\test.txt");
            //    writer.WriteLine("this is second line");
            //    writer.WriteLine("this is third line");
            //    writer.Close();

            //    //StreamReader reader = new StreamReader(@"C:\Users\anami\Svam\C#\Day7\test.txt");
            //    //Console.WriteLine(reader.ReadToEnd());
            //    //reader.Close();


            //    StreamReader reader = new StreamReader(@"C:\Users\anami\Svam\C#\Day7\test.txt");
            //     string line = reader.ReadLine();
            //    while(line!= null)
            //    {
            //        Console.WriteLine(line);
            //        line = reader.ReadLine();
            //    }
            //    reader.Close();

            FileStream fs = new FileStream(@"C:\Users\anami\Svam\C#\Day7\a.txt", FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fs);
            string ch = "y";
            string name = null;
            while (ch == "y")
            {
                Console.WriteLine("Enter name");
                name = Console.ReadLine();
                writer.WriteLine(name);
                Console.WriteLine("Add moew ");
                ch = Console.ReadLine();
            }
            writer.Close();
            fs.Close();
            fs = new FileStream(@"C:\Users\anami\Svam\C#\Day7\a.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fs);
        }







        }
    }

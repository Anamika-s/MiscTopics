namespace MiscTopics
{
    struct Doj
    {
        int day, month, year;
    }
    struct Address
    {
         string house_no, city, state, country;
    }
    struct Record
    {
         public int Id;
        public string Name;
        public string Dept;
        //int day, month, year;
        Doj doj;
        Address address;
              public void Get()
        {

        }
        public void Display()
        {

        }
    }

    class STudent
    {
        Address address;
        int[] num = new int[10];

    }
    internal class Program
    {
        enum Choice : byte { Addition=1,Plus,Add, Subtraction, Product=8, Divide };

        static void Main(string[] args)
        {
            //Record rec = new Record();
                                                    Console.WriteLine((int)Choice.Addition);
                                                    Console.WriteLine("Hello, World!");
                                                    int num1, num2;
                                                    int ch;
                                                    Console.WriteLine("ENter No1");
                                                    num1 = Byte.Parse(Console.ReadLine());
                                                    Console.WriteLine("ENter No2");
                                                    num2 = Byte.Parse(Console.ReadLine());
                                                    Console.WriteLine("ENter ch");
                                                    ch = Byte.Parse(Console.ReadLine());

                                                    switch (ch)
                                                    {
                                                        case (int)Choice.Addition:
                    
                                                        case (int)Choice.Add:
                                                            {
                                                                Console.WriteLine(num1+num2);
                                                                break;
                                                            }
                                                        case (int)Choice.Subtraction:
                                                            {
                                                                Console.WriteLine(num1 - num2);
                                                                break;
                                                            }
                                                        case (int)Choice.Product:
                                                            {
                                                                Console.WriteLine(num1 * num2);
                                                                break;
                                                            }
                                                        case (int)Choice.Divide:
                                                            {
                                                                Console.WriteLine(num1 / num2);
                                                                break;
                                                            }



            }
        }
    }
}
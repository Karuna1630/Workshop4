namespace Workshop4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.name = "Karuna Giri";
            student1.age = 20;
            student1.id = 101;
            Console.WriteLine(student1.name);
            Student student2 = new Student();
            Console.WriteLine(student1.age);
        }
    }
}

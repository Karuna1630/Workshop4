namespace Workshop4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating a student object
            Student student1 = new Student();
            student1.name = "Karuna Giri";
            student1.age = 20;
            student1.id = 101;
            Console.WriteLine(student1.name);
            Console.WriteLine(student1.id);
            Console.WriteLine(student1.age);

            // Creating another student object
            Student student2 = new Student();
            student2.name = "Anil Thapa";   
            Console.WriteLine(student2.age);
        }
    }
}

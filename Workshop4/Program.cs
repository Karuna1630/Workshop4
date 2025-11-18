namespace Workshop4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating first student object
            Student student1 = new Student();
            student1.id = 101;
            student1.name = "Karuna Giri";
            student1.age = 20;

            // Displaying details of the first student
            Console.WriteLine("Student 1:");
            Console.WriteLine(student1.name);
            Console.WriteLine(student1.id);
            Console.WriteLine(student1.age);

            // Creating second student object
            Student student2 = new Student();
            student2.id = 102;
            student2.name = "Anil Thapa";   
            student2.age = 20;

            // Displaying details of the second student
            Console.WriteLine("Student 2:");
            Console.WriteLine(student2.name);
            Console.WriteLine(student1.id);
            Console.WriteLine(student1.age);

            // Printing static field
            Console.WriteLine("Total Students: " + Student.totalStudents);



        }
    }
}

namespace Workshop4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating object of ParameterDemo
            ParameterDemo demo = new ParameterDemo();

            //Calling Increase(ref int)
            int num = 20;                    // initial value
            demo.Increase(ref num);          // ref allows method to modify original value
            Console.WriteLine("After Increase: " + num);

            //Calling GetFullName(out string) 
            demo.GetFullName(out string fullName);   // out parameter must be assigned inside the method
            Console.WriteLine("Full Name: " + fullName);

            //Calling SumAll(params int[]) 
            Console.WriteLine("SumAll(5, 10, 15): " + demo.SumAll(5, 10, 15));
            Console.WriteLine("SumAll(1, 2, 3, 4, 5): " + demo.SumAll(1, 2, 3, 4, 5));



            //// Create object
            //Calculator calc = new Calculator();

            //// Call and print welcome message
            //calc.PrintWelcome();

            ////calling calculator methods
            //Console.WriteLine("Addition: " + calc.Add(5, 3));
            //Console.WriteLine("Multiplication: " + calc.Multiply(5, 3));

            //// Call Multiply method (using default value for num2)
            //Console.WriteLine("Multiplication: " + calc.Multiply(5));






            //// Creating first student object
            //Student student1 = new Student();
            //student1.id = 101;
            //student1.name = "Karuna Giri";
            //student1.age = 20;

            //// Displaying details of the first student
            //Console.WriteLine("Student 1:");
            //Console.WriteLine(student1.name);
            //Console.WriteLine(student1.id);
            //Console.WriteLine(student1.age);

            //// Creating second student object
            //Student student2 = new Student();
            //student2.id = 102;
            //student2.name = "Anil Thapa";   
            //student2.age = 20;

            //// Displaying details of the second student
            //Console.WriteLine("Student 2:");
            //Console.WriteLine(student2.name);
            //Console.WriteLine(student1.id);
            //Console.WriteLine(student1.age);

            //// Printing static field
            //Console.WriteLine("Total Students: " + Student.totalStudents);



        }
    }
}

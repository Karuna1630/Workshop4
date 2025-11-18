namespace Workshop4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 5
            Console.Write("Enter the day (Example: Sunday): ");
            string day = Console.ReadLine();


            // Check if the day is weekend or weekday
            if (day.ToLower() == "friday" || day.ToLower() == "saturday")
            {
                Console.WriteLine("It is: Weekend");
            }
            else
            {
                Console.WriteLine("It is: Weekday");
            }
            Console.WriteLine();


            //// Record Book

            //// Create an object for book and assign the values
            //Book book1 = new Book("WAR AND PEACE", "Leo Tolstoy", 680);


            //// Print the value of first object
            //Console.WriteLine("Book 1:");
            //Console.WriteLine("Title: " + book1.title);
            //Console.WriteLine("Author: " + book1.author);
            //Console.WriteLine("Price: $" + book1.price);
            //Console.WriteLine();

            //// Create another object and by using with expression, change the title and price
            //Book book2 = book1 with { title = "Harry Potter", price = 2199 };

            //Console.WriteLine("Book 2 ");
            //Console.WriteLine("Title: " + book2.title);
            //Console.WriteLine("Author: " + book2.author);
            //Console.WriteLine("Price: $" + book2.price);
            //Console.WriteLine();

            //// Deconstruct the second object into three variables and print them
            //var (title, author, price) = book2;
            //Console.WriteLine("Deconstructed Book 2:");
            //Console.WriteLine("Title: " + title);
            //Console.WriteLine("Author: " + author);
            //Console.WriteLine("Price: $" + price);



            ////task 4: Player Class with Constructors
            //// creating Object using default constructor 
            //Player p1 = new Player();
            //Console.WriteLine();

            //// Create another object using parameterized constructor
            //Player player2 = new Player("Karuna Giri",1 ,50);

            //// Print the values of the fields using both objects
            //Console.WriteLine("Player 1 (Default Constructor):");
            //Console.WriteLine("Player Name: " + p1.playerName);
            //Console.WriteLine("Level: " + p1.level);
            //Console.WriteLine("Health: " + p1.health);
            //Console.WriteLine();

            //Console.WriteLine("Player 2 (Parameterized Constructor):");
            //Console.WriteLine("Player Name: " + player2.playerName);
            //Console.WriteLine("Level: " + player2.level);
            //Console.WriteLine("Health: " + player2.health);
            //Console.WriteLine();








            //// Task 3: Parameter Types Demo
            //// Creating object of ParameterDemo
            //ParameterDemo demo = new ParameterDemo();

            ////Calling Increase(ref int)
            //int num = 20;                    // initial value
            //demo.Increase(ref num);          // ref allows method to modify original value
            //Console.WriteLine("After Increase: " + num);

            ////Calling GetFullName(out string) 
            //demo.GetFullName(out string fullName);   // out parameter must be assigned inside the method
            //Console.WriteLine("Full Name: " + fullName);

            ////Calling SumAll(params int[]) 
            //Console.WriteLine("SumAll(5, 10, 15): " + demo.SumAll(5, 10, 15));
            //Console.WriteLine("SumAll(1, 2, 3, 4, 5): " + demo.SumAll(1, 2, 3, 4, 5));



            //task 2: Calculator Class with Methods
            //// Create object
            //Calculator calc = new Calculator();

            //// Call and print welcome message
            //calc.PrintWelcome();

            ////calling calculator methods
            //Console.WriteLine("Addition: " + calc.Add(5, 3));
            //Console.WriteLine("Multiplication: " + calc.Multiply(5, 3));

            //// Call Multiply method (using default value for num2)
            //Console.WriteLine("Multiplication: " + calc.Multiply(5));





            //Task 1: Student Class with Static Field
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

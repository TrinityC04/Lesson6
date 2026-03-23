namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //8.1
            string[] names = { "Ava", "Ben", "Chen" };
            int[] ages = { 19, 21, 20 };
            double[] marks = { 72.5, 88.0, 64.0 };

            List<Student> students = new();

            for (int i = 0; i < names.Length; i++)
            {
                students.Add(new Student(names[i], ages[i], marks[i]));
            }

            Console.WriteLine("All students:");
            foreach (var student in students)
            {
                student.DisplayStudent();
            }

            students.RemoveAt(1);

            Console.WriteLine();
            Console.WriteLine("After removing index 1:");
            foreach (var student in students)
            {
                student.DisplayStudent();
            }


            Console.WriteLine("\n\n");
            //8.2
            var geralt = new User("Geralt", "of Rivia", "WhiteWolf", "geralt@kaer-morhen.com");

            geralt.DisplaySummary();
            geralt.ChangeEmail("kat-1234@gmail.com");
            geralt.DisplaySummary();


            Console.WriteLine("\n\n");
            //8.3
            var user2 = new User2("Witcher01");

            Console.WriteLine($"Starting username: {user2.Username}");

            user2.Username = "";
            Console.WriteLine($"After invalid update: {user2.Username}");

            user2.Username = "WhiteWolf";
            Console.WriteLine($"After valid update: {user2.Username}");

            Console.WriteLine("\n\n");
            //8.4
            List<Employee> team = new()
            {
                new Developer("Ada"),
                new Manager("Grace"),
		    };

            foreach (var employee in team)
            {
                employee.Work();
            }
        }
    }
}

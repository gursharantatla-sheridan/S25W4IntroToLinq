namespace S25W4IntroToLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 4, 3, 5, 7, 8, 6, 3, 2, 4, 6, 8, 9, 1 };

            // query syntax
            var greaterThan4 = from num in array
                               where num > 4
                               orderby num descending
                               select num;

            // method syntax
            var greaterThan5 = array.Where(n => n > 5).OrderBy(n => n).ToList();

            foreach (var i in greaterThan5)
                Console.Write(i + " ");
            Console.WriteLine("\n\n\n");



            List<string> colors = new List<string>();
            colors.Add("rUSt");
            colors.Add("bLuE");
            colors.Add("GreEn");
            colors.Add("ReD");

            var startsWithR = from c in colors
                              let upperCaseStr = c.ToUpper()
                              where upperCaseStr.StartsWith("R")
                              orderby upperCaseStr
                              select upperCaseStr;

            foreach (var i in startsWithR)
                Console.WriteLine(i);

            Console.WriteLine("\n\n\n");

            colors.Add("RuBy");
            colors.Add("PiNK");

            // deferred execution
            foreach (var i in startsWithR)
                Console.WriteLine(i);

            Console.WriteLine("\n\n\n");



            List<Employee> employees = new List<Employee>()
            {
                new Employee("James", "Blue", 5000),
                new Employee("Anne", "Indigo", 3000),
                new Employee("John", "Indigo", 6000),
                new Employee("Carrie", "Brown", 8000),
                new Employee("Bob", "White", 4000),
                new Employee("James", "Grey", 5500)
            };


            foreach (var emp in employees)
                Console.WriteLine(emp);
            Console.WriteLine("\n\n");


            var between4k6k = from e in employees
                              where e.Salary >= 4000 && e.Salary <= 6000
                              select e;

            foreach (var emp in between4k6k)
                Console.WriteLine(emp);
            Console.WriteLine("\n\n");


            var sortedEmps = from e in employees
                             orderby e.LastName, e.FirstName
                             select e;

            foreach (var emp in sortedEmps)
                Console.WriteLine(emp);
            Console.WriteLine("\n\n");


            var lastnames = (from e in employees
                            select e.LastName).Distinct();

            foreach (var emp in lastnames)
                Console.WriteLine(emp);
            Console.WriteLine("\n\n");


            var empNames = from e in employees
                           select new { e.FirstName, e.LastName };

            foreach (var emp in empNames)
                Console.WriteLine(emp);
            Console.WriteLine("\n\n");
        }
    }
}

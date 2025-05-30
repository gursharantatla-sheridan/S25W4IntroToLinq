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


        }
    }
}

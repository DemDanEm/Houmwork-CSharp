namespace Arrays1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Фантастика", "Криминал", "Экшн" };

            string[][] movies = {
                new string[] { "Матрица", "Интерстеллар", "Время" }, // Фантастика
                new string[] { "Крёстный отец", "Казино", "Славные парни" }, // Криминал
                new string[] { "Аватар", "Человек-паук", "Железный человек" } // Экшн
                };
            for (int i = 0; i < movies.Length; i++)
            {
                Console.WriteLine(names[i] + ":");
                foreach (string film in movies[i])
                {
                    Console.WriteLine("- " + film);
                }
                Console.WriteLine("\n");
            }

        }
    }
}

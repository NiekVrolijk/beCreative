namespace version_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region example2

            int totalGood = 0;
            int totalBad = 0;
            Random random = new Random();

            Console.ReadLine();

            while (true)
            {
                int good = 0;
                int bad = 0;

                for (int i = 0; i < 100; i++)
                {
                    int roll = random.Next(1, 21);
                    if (roll > 10)
                    {
                        good++;
                    }
                    else
                    {
                        bad++;
                    }
                }

                Console.WriteLine($"good: {good} + bad: {bad}");

                if (good > 50)
                {
                    totalGood++;
                }
                else if (bad > 50)
                {
                    totalBad++;
                }

                Console.WriteLine($"total good: {totalGood} + total bad: {totalBad}");

                Console.ReadLine();
            }
            #endregion
        }
    }
}
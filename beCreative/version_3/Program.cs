using System.CodeDom.Compiler;

namespace version_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region example3
            int numberOfDiceRolled = 100;
            int diceRolled = 0;

            int good = 0;
            int bad = 0;
            int totalGood = 0;
            int totalBad = 0;

            Console.ReadLine();
            Generate();

            void Generate(){
                good = 0; bad = 0;
                for(int i = 0; i < numberOfDiceRolled; i++)
                {
                    Random rnd = new Random();
                    diceRolled = rnd.Next(1, 21);
                    GoodOrBad();
                }
                Console.WriteLine($"good: {good} + bad: {bad}");
                TotalGoodAndTotalBad();
                Console.WriteLine($"total good: {totalGood} + total bad: {totalBad}");
                Console.ReadLine();
                Generate();
            }

            void GoodOrBad()
            {
                if (diceRolled > 10)
                {
                    good++;
                }
                else
                {
                    bad++;
                }
            }

            void TotalGoodAndTotalBad()
            {
                if (good > bad)
                {
                    totalGood++;
                }
                else if (bad > good)
                {
                    totalBad++;
                }
            }
            #endregion
        }
    }
}
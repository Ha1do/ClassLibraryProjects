using UtilityLibraries;

class Program
{
    static void Main(string[] args)
    {
        int tests;        // к-во тестов
        int CubesCount, AllSidesCount; // к-во кубиков в одном тесте, к-во всех второн всех кубиков`

        tests = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < tests; i++)   // работа с одним тестом
        {
            CubesCount = Convert.ToInt32(Console.ReadLine());
            string[] s = new string[CubesCount];            // масив строк 
            AllSidesCount = CubesCount * 6;

            for (int j = 0; j < CubesCount; j++)
            {
                s[j] = Console.ReadLine();

                for (int h = 3; h < s[j].Length; h += 2)
                {
                    if (s[j][h] != '0')
                    {
                        AllSidesCount--;
                    }
                }
            }
            System.Console.WriteLine(AllSidesCount);
        }
    }
}
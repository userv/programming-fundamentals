using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winecraft
{
    public class Winecraft
    {
        public static void Main()
        {
            List<int> grapes = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int daysGrowth = int.Parse(Console.ReadLine());

            while (grapes.Count - 1 == daysGrowth)
            {
                grapes = WineCraft(daysGrowth, grapes);
                for (int j = 0; j < grapes.Count; j++)
                {
                    if (grapes[j] <= daysGrowth)
                    {
                        grapes.RemoveAt(j);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", grapes));

        }

        public static List<int> WineCraft(int daysGrowth, List<int> grapes)
        {
            for (int i = 0; i < daysGrowth; i++)
            {
                for (int j = 0; j < grapes.Count; j++)
                {
                    bool isFirstElement = j == 0;
                    bool isLastElement = j == grapes.Count - 1;
                    if (isFirstElement)
                    {
                        var isNextGreaterGrape = IsNextGreaterGrape(grapes, j);
                        if (!isNextGreaterGrape)
                        {
                            grapes[j]++;
                            continue;
                        }
                    }
                    if (!isFirstElement && !isLastElement)
                    {
                        var isGreaterGrape = IsGreaterGrape(grapes, j);
                        if (isGreaterGrape && grapes[j - 1] > 0)
                        {
                            grapes[j]++;
                            grapes[j - 1]--;
                        }
                        if (isGreaterGrape && grapes[j + 1] > 0)
                        {
                            grapes[j]++;
                            grapes[j + 1]--;
                            continue;
                        }
                        //var isNextGreaterGrape = IsNextGreaterGrape(grapes, j);
                        //var isPreviousGreaterGrape = IsPreviousGreaterGrape(grapes, j);
                        if (grapes[j] > 0 && !IsNextGreaterGrape(grapes,j))
                        {
                            grapes[j]++;
                        }

                    }

                    if (isLastElement)
                    {
                        var isPreviousGreaterGrape = IsPreviousGreaterGrape(grapes, j);
                        if (grapes[j] > 0 && !isPreviousGreaterGrape)
                        {
                            grapes[j]++;
                        }
                    }
                }
            }
            return grapes;
        }

        public static bool IsNextGreaterGrape(List<int> grapes, int j)
        {
            if (j < grapes.Count - 2)
            {
                bool isNextGreaterGrape = (grapes[j + 1] > grapes[j]) && (grapes[j + 1] > grapes[j + 2]);
                return isNextGreaterGrape;
            }

            return false;
        }

        public static bool IsPreviousGreaterGrape(List<int> grapes, int j)
        {
            bool isPreviousGreaterGrape = (grapes[j - 1] > grapes[j - 2]) && (grapes[j - 1] > grapes[j]);
            return isPreviousGreaterGrape;
        }

        public static bool IsGreaterGrape(List<int> grapes, int j)
        {
            bool isGreaterGrape = (grapes[j] > grapes[j - 1]) && (grapes[j] > grapes[j + 1]);
            return isGreaterGrape;
        }
    }
}

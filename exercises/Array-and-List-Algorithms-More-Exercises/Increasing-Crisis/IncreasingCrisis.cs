using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increasing_Crisis
{
    public class IncreasingCrisis
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<int> numbersList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            for (int i = 0; i < n - 1; i++)
            {
                List<int> currentSequence = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                ProcessSequences(numbersList, currentSequence);

            }
            Console.WriteLine(string.Join(" ", numbersList));
        }

        public static void ProcessSequences(List<int> numbersList, List<int> currentSequence)
        {
            for (int i = 0; i < currentSequence.Count; i++)
            {
                int index = FindRightmostLowerElement(numbersList, currentSequence[i]);
                bool isNextElementGreater = IsNextElementGreater(currentSequence, i);
                bool isIncreasingSequence = IsIncreasingSequence(currentSequence);
                if ((index == numbersList.Count - 1) && isIncreasingSequence)
                {
                    numbersList.AddRange(currentSequence);
                    return;
                }
                if ((index == numbersList.Count - 1) && isNextElementGreater)
                {
                    numbersList.Add(currentSequence[i]);
                    continue;
                }
                if (index != -1 && isNextElementGreater)
                {
                    numbersList.Insert(index, currentSequence[i]);
                }
                else
                {


                    if (index == numbersList.Count - 1)
                    {
                        numbersList.Add(currentSequence[i]);
                        return;
                    }

                    //index++;
                    numbersList.Insert(index, currentSequence[i]);
                    int count = numbersList.Count - index;
                    numbersList.RemoveRange(index, count);
                    return;




                }
            }

        }

        public static bool IsIncreasingSequence(List<int> currentSequence)
        {

            for (int i = 0; i < currentSequence.Count - 1; i++)
            {
                if (currentSequence[i] > currentSequence[i + 1])
                {
                    return false;
                }

            }
            return true;
        }

        private static int FindRightmostLowerElement(List<int> numbersList, int currentElement)
        {
            //for (int i = 0; i < numbersList.Count - 1; i++)
            //{
            //    if (currentElement >= numbersList[i] && currentElement <= numbersList[i + 1])
            //    {
            //        // numbersList.Insert(i+1,currentElement);
            //        return i + 1;
            //    }

            //}
            for (int i = numbersList.Count - 1; i > 1; i--)
            {
                if (currentElement <= numbersList[i] && currentElement >= numbersList[i - 1])
                {

                    return i;
                }

            }
            if (currentElement >= numbersList[numbersList.Count - 1])
            {
                return numbersList.Count - 1;
            }
            return -1;
        }

        public static bool IsNextElementGreater(List<int> currentSequence, int i)
        {
            bool isIncreasingSequence = false;
            bool isLastElement = (currentSequence.Count - 1) == i;
            if (!isLastElement)
            {
                isIncreasingSequence = currentSequence[i] <= currentSequence[i + 1];
            }
            else
            {
                isIncreasingSequence = currentSequence[i] >= currentSequence[i - 1];
            }

            return isIncreasingSequence;
        }
    }




}


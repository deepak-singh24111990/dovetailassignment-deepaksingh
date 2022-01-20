
namespace DoveTailQuestion2And3.Utilities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class TempTracker
    {
        public int[] InsertTemprature(string tempList)
        {
            if (tempList == null || tempList == string.Empty)
            {
                return new int[0];
            }

            string[] tempArray = tempList.Split(',');
            int[] temp = new int[tempArray.Length];
            int a;
            for (int i = 0; i < tempArray.Length; i++)
            {
                if (!int.TryParse(tempArray[i], out a))
                {
                    return new int[0];
                }
                temp[i] = Convert.ToInt32(tempArray[i]);
            }
            return temp;
        }
        public int GetMaximumTemprature(int []temp)
        {
            if (temp == null || temp.Length == 0)
            {
                return 0;
            }
            Array.Sort(temp);
            int max = temp[0];
            for (int i = 1; i < temp.Length; i++)
            {
                if (max < temp[i])
                {
                    max = temp[i];
                }
            }
            return max;
        }

        public int GetMinimumTemprature(int[] temp)
        {
            if (temp == null || temp.Length == 0)
            {
                return 0;
            }
            Array.Sort(temp);
            int min = temp[0];
            for (int i = 1; i < temp.Length; i++)
            {
                if (min > temp[i])
                {
                    min = temp[i];
                }
            }
            return min;
        }

        public int GetMeanTemprature(int[] temp)
        {
            if (temp == null || temp.Length == 0)
            {
                return 0;
            }
            int mean = 0, sum = 0;

            for (int i = 0; i < temp.Length; i++)
            {
                sum += temp[i];
            }
            mean = sum / temp.Length;

            return mean;
        }

        public int GetModeTemprature(int[] temp)
        {
            if (temp == null || temp.Length == 0)
            {
                return 0;
            }
            int maxTemp = GetMaximumTemprature(temp);
            int mode = 0;
            int[] count = new int[maxTemp + 1];
            for (int i = 0; i < maxTemp + 1; i++)
            {
                count[i] = 0;
            }

            for (int i = 0; i < temp.Length; i++)
            {
                count[temp[i]]++;
            }
            
            int k = count[0];
            for (int i = 1; i < maxTemp + 1; i++)
            {
                if (count[i] > k)
                {
                    k = count[i];
                    mode = i;
                }
            }

            return mode;
        }

    }
}

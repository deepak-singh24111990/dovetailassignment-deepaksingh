
namespace DoveTailQuestion2And3.Utilities
{
    using System;
    public static class TempTracker
    {
        public static int[] InsertTemprature(string tempList)
        {
            if (string.IsNullOrEmpty(tempList))
            {
                return new int[0];
            }
            var temperaturesArray = tempList.Split(',');
            var temprature = new int[temperaturesArray.Length];
            for (int i = 0; i < temperaturesArray.Length; i++)
            {
                if (!int.TryParse(temperaturesArray[i], out int a))
                {
                    return new int[0];
                }
                temprature[i] = Convert.ToInt32(temperaturesArray[i]);
            }
            return temprature;
        }
        public static int GetMaximumTemprature(int []temp)
        {
            if (temp == null || temp.Length == 0)
            {
                return 0;
            }
            Array.Sort(temp);
            var max = temp[0];
            for (int i = 1; i < temp.Length; i++)
            {
                if (max < temp[i])
                {
                    max = temp[i];
                }
            }
            return max;
        }
        public static int GetMinimumTemprature(int[] temp)
        {
            if (temp == null || temp.Length == 0)
            {
                return 0;
            }
            Array.Sort(temp);
            var min = temp[0];
            for (int i = 1; i < temp.Length; i++)
            {
                if (min > temp[i])
                {
                    min = temp[i];
                }
            }
            return min;
        }
        public static float GetMeanTemprature(int[] temp)
        {
            if (temp == null || temp.Length == 0)
            {
                return 0;
            }
            float mean = 0, sum = 0; 
            for (int i = 0; i < temp.Length; i++)
            {
                sum += temp[i];
            }
            mean = sum / temp.Length;
            return mean;
        }
        public static int GetModeTemprature(int[] temp)
        {
            if (temp == null || temp.Length == 0)
            {
                return 0;
            }
            int maxTemp = GetMaximumTemprature(temp);
            int mode = 0;
            var count = new int[maxTemp + 1];
            for (int i = 0; i < maxTemp + 1; i++)
            {
                count[i] = 0;
            }
            for (int i = 0; i < temp.Length; i++)
            {
                count[temp[i]]++;
            }
            var k = count[0];
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

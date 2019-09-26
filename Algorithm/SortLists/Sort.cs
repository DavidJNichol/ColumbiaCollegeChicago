using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class Sort
    {
        public List<string> sortGuidList(List<string> newGuidList)
        {
            string[] guids = convertListOfStringToArrayOfString(newGuidList);
            string temp;

            for (int i = 0; i < guids.Length; i++)
            {
                for (int j = 0; j < guids.Length - 1; j++)
                {
                    if (guids[j].CompareTo(guids[j + 1]) > 0)
                    {
                        temp = guids[j];
                        guids[j] = guids[j + 1];
                        guids[j + 1] = temp;
                    }
                }
            }

            return convertArrayToList(guids);
        }

        

        public List<string> bubbleSortDoubleList(List<string> newDoubleList)
        {

            double[] doubles = convertListOfStringToArrayOfDoubles(newDoubleList);

            double temp;

            for (int j = 0; j <= doubles.Length - 2; j++)
            {
                for (int i = 0; i <= doubles.Length - 2; i++)
                {
                    if (doubles[i] > doubles[i + 1])
                    {
                        temp = doubles[i + 1];
                        doubles[i + 1] = doubles[i];
                        doubles[i] = temp;
                    }
                }
            }

            
            return convertArrayToList(doubles);
        }

        private string[] convertListOfStringToArrayOfString(List<string> newGuidList)
        {
            string[] GuidArray = newGuidList.ToArray();
            return GuidArray;
        }

        private double[] convertListOfStringToArrayOfDoubles(List<string> newDoubleList)
        {
            string[] olddoubleArray = newDoubleList.ToArray();
            double[] doubleArray = new double[olddoubleArray.Length];

            for (int i = 0; i < olddoubleArray.Length; i++)
            {
                doubleArray[i] = Double.Parse(olddoubleArray[i]);
            }

            return doubleArray;
        }

        private List<String> convertArrayToList(double[] doubleArray)
        {
            
            string[] s = new string[doubleArray.Length];

            for (int i = 0; i < doubleArray.Length; i++)
            {
                s[i] = doubleArray[i].ToString();
            }

            List<string> lst = new List<string>();

            foreach (var item in s)
            {
                lst.Add(item);
            }

            return lst;
        }

        private List<String> convertArrayToList(string[] stringArray)
        {

            string[] s = new string[stringArray.Length];

            for (int i = 0; i < stringArray.Length; i++)
            {
                s[i] = stringArray[i].ToString();
            }

            List<string> lst = new List<string>();

            foreach (var item in s)
            {
                lst.Add(item);
            }

            return lst;
        }
    }
}

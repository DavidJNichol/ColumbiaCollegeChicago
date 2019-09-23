using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class Sort
    {
        char[] hexa = new char[16] {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F'};
        public List<string> sortGuidList(List<string> newGuidList)
        {
            int first;
            int second;
            string toChange;

            for (int i = 0; i < newGuidList.Count; i++)
            {
                for (int j = 0; j < hexa.Length; j++)
                {
                    // A = A -> j = 10
                    // 7 = 7 -> j = 7
                    if(newGuidList[i][0] == hexa[j])
                    {
                        //11
                        first = j;
                    }
                }

                //if (first > second)
                //{
                //    toChange = newGuidList[i];
                //    newGuidList[i] = newGuidList[i + 1];
                //    newGuidList[i + 1] = toChange;
                //}   
            }
            return newGuidList;
        }

        public List<string> sortDoubleList(List<string> newDoubleList)
        {
            //miss implementation
            return newDoubleList;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class Sort
    {
        char[] hexa = new char[16] {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F'};
        string holdString;
        public List<string> sortGuidList(List<string> newGuidList)
        {
            for (int i = 0; i < newGuidList.Count; i++)
            {
                for (int j = 0; j < hexa.Length; j++)
                {
                    if(newGuidList[i][0] == hexa[j])
                    {
                        
                    }
                }
            }
            //miss implementation
            return newGuidList;
        }

        public List<string> sortDoubleList(List<string> newDoubleList)
        {
            //miss implementation
            return newDoubleList;
        }
    }
}

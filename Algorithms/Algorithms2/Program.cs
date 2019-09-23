using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Data d = new Data();
            Sort s = new Sort();

            d.createLists();
            d.showList();
            d.saveCSVFile();

            d.loadCSVFile();
            //s.sortGuidList(d.getNewListDouble()); // Sort Guid List
            //s.sortGuidList(d.getNewListGuid()); // Sort Double List

            //d.saveCSVFile(d.getNewListInt(), d.getNewListGuid(), d.getNewListDouble()); //First Sort Save file

            Console.ReadLine();
        }
    }
}

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
            
            //Creating first entire List;
            d.createLists();
            d.showList();
            d.saveCSVFile();
            //Finishing the process of saving the list;

            //Loading first list and separating in 3 different lists;
            d.loadCSVFile();

            //Saving GUID and Double List in a different file;
            d.saveNewCSVGUIDFile();
            d.saveNewCSVDoubleFile();

            d.saveNewSortedCSVDoubleFile(s.bubbleSortDoubleList(d.getNewListDouble()));
            d.saveNewSortedCSVGUIDFile(s.sortGuidList(d.getNewListGuid()));
            Console.ReadLine();
        }
    }
}

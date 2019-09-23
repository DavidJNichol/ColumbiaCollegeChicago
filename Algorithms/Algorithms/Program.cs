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

            d.saveCSVFile(s.sortGuidList(d.getNewListGuid()));
            //d.saveCSVFile(d.getNewListInt(), d.getNewListGuid(), d.getNewListDouble()); //First Sort Save file

            Console.ReadLine();
        }
    }
}

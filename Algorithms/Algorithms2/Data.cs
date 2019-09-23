using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Algorithms
{
    public class Data
    {
        private const string Path  = "C:\\Users\\angelo.demello\\Desktop\\Algorithms\\metaData.csv";
        private const string Path2 = "C:\\Users\\angelo.demello\\Desktop\\Algorithms\\metaData2.csv";
        //Save Lists
        List<string> intList;
        List<string> guidList;
        List<string> dbList;

        //Load Lists
        List<string> newListInt = new List<string>();
        List<string> newListGuid = new List<string>();
        List<string> newListDouble = new List<string>();

        public Data()
        {
            intList = new List<string>();
            dbList = new List<string>();
            guidList = new List<string>();
        }

        public List<String> getNewListInt()
        {
            return newListInt;
        }

        public List<String> getNewListGuid()
        {
            return newListGuid;
        }

        public List<String> getNewListDouble()
        {
            return newListDouble;
        }


        public double generateRandomNumber()
        {
            Random number = new Random();

            return number.NextDouble();
        }

        public Guid generateNewGUID()
        {
            return Guid.NewGuid();
        }

        public void createLists()
        {
            for (int i = 0; i < 10; i++)
            {
                this.intList.Add(i.ToString());
                this.guidList.Add(generateNewGUID().ToString());
                this.dbList.Add(generateRandomNumber().ToString());            
            } 
        }

        public void showList()
        {
            for (int i = 0; i < intList.Count; i++)
            {
                Console.WriteLine(intList[i]);
                Console.WriteLine(guidList[i]);
                Console.WriteLine(dbList[i]);
            }
        }

        public void saveCSVFile()
        {
            using (StreamWriter sw = File.CreateText(Path))
            {
                for (int i = 0; i < intList.Count; i++)
                {
                    var line = String.Format("{0},{1},{2}", intList[i], guidList[i], dbList[i]);
                    sw.WriteLine(line); 
                }
            }
        }

        public void saveCSVFile(List<String> intList, List<String> guidList, List<String> dbList)
        {
            using (StreamWriter sw = File.CreateText(Path2))
            {
                for (int i = 0; i < intList.Count; i++)
                {
                    var line = String.Format("{0},{1},{2}", intList[i], guidList[i], dbList[i]);
                    sw.WriteLine(line);
                }
            }
        } 

        public void loadCSVFile()
        {
            using (var reader = new StreamReader(Path))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    newListInt.Add(values[0]);
                    newListGuid.Add(values[1]);
                    newListDouble.Add(values[2]);
                }
            }
        }
    }
}

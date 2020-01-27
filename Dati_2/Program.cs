using System;
using System.Collections.Generic;
using System.IO;

namespace Dati_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "interi.txt";
            List<int> votiList = new List<int>();
            if(File.Exists(file))
            {
                try
                {
                    using (StreamReader reader = new StreamReader(file))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                            votiList.Add(int.Parse(line));
                    }
                } catch { }
            }
            string file2 = "interi2.txt";
            List<int> votiList2 = new List<int>();
            try
            {
                using (StreamWriter writer = new StreamWriter(file2))
                {
                    for (int i = 0; i < votiList.Count; i++)
                    {
                        if ( ! votiList2.Contains(votiList[i]))
                        {
                            writer.WriteLine(votiList[i]);
                            votiList2.Add(votiList[i]);
                        }
                    }
                        
                }
            } catch { }
        }
    }
}

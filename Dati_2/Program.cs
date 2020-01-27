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
            HashSet<int> votiList = new HashSet<int>();
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
            try
            {
                using (StreamWriter writer = new StreamWriter(file2))
                {
                    foreach(int s in votiList)
                            writer.WriteLine(s);
                }
            } catch { }
        }
    }
}

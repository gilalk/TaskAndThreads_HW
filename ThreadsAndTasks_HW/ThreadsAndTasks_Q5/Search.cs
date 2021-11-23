using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadsAndTasks_Q5
{
    class Search
    {
        public static event Action<string> GetPath;
        public static event Action<string> ExceptionMessage;
        public string DiskDrive { get; set; }
        public string SearchTerm { get; set; }
        List<string> Extensions = new List<string>() { ".txt" };

        public Search(string drive, string fileName)
        {
            DiskDrive = drive;
            SearchTerm = fileName;
        }

        public void SearchFiles()
        {
            string path = DiskDrive + @":\";
            string[] files = Directory.GetFiles(path);
            string line = "";
            foreach (var item in files)
            {
                if (item.Contains(Extensions[0]))
                {
                    string fullPath = Path.GetFullPath(item);
                    var streamReader = new StreamReader(fullPath);
                    try
                    {
                        using (streamReader)
                        {
                            while (line != null)
                            {
                                line = streamReader.ReadLine();
                                if (line.Contains(SearchTerm))
                                {
                                    GetPath(fullPath);
                                }
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        ExceptionMessage(e.Message);
                    }

                }
            }
        }
    }
}

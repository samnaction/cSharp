using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;

namespace LinqBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\windows";
            ShowLargerFilesWithoutLinq(path);
            Console.WriteLine("****");
            ShowLargerFilesWithLinq(path);
        }

        private static void ShowLargerFilesWithoutLinq(string path)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            FileInfo[] files = directoryInfo.GetFiles();
            Array.Sort(files, new FileInfoComparer());

            for (int i = 0; i < 5; i++)
            {
                FileInfo file = files[i];
                Console.WriteLine($"{file.Name} -- {file.Length}" );
            }
        }

        class FileInfoComparer : IComparer<FileInfo>
        {
            public int Compare([AllowNull] FileInfo x, [AllowNull] FileInfo y)
            {
                return y.Length.CompareTo(x.Length);
            }
        }

        private static void ShowLargerFilesWithLinq(string path)
        {
            var query = from file in new DirectoryInfo(path).GetFiles()
                        orderby file.Length descending
                        select file;

            foreach (var file in query.Take(5))
            {
                Console.WriteLine($"{file.Name} -- {file.Length}");
            }

            Console.WriteLine("***");

            var queryMethod = new DirectoryInfo(path).GetFiles()
                                    .OrderByDescending(f => f.Length)
                                    .Take(5);

            foreach (var file in query.Take(5))
            {
                Console.WriteLine($"{file.Name} -- {file.Length}");
            }
        }
    }
}

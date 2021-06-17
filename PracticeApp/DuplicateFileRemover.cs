﻿
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApp
{
    public class FileDetails
    {
        public string FileName { get; set; }
        public string FileHash { get; set; }
    }

    public class DuplicateFileRemover
    {
       public void DuplicateRemover() {

            string path;
            ConsoleKeyInfo cki;
            double totalSize = 0;
            //pass directory path as argument to command line
           
                path = @"D:\Temp";

            //Get all files from given directory
            var fileLists = Directory.GetFiles(path);
            int totalFiles = fileLists.Length;

            List<FileDetails> finalDetails = new List<FileDetails>();
            List<string> ToDelete = new List<string>();
            finalDetails.Clear();
            //loop through all the files by file hash code
            foreach (var item in fileLists)
            {
                using (var fs = new FileStream(item, FileMode.Open, FileAccess.Read))
                {
                    finalDetails.Add(new FileDetails()
                    {
                        FileName = item,
                        FileHash = BitConverter.ToString(SHA1.Create().ComputeHash(fs)),
                    });
                }
            }
            //group by file hash code
            var similarList = finalDetails.GroupBy(f => f.FileHash)
                .Select(g => new { FileHash = g.Key, Files = g.Select(z => z.FileName).ToList() });


            //keeping first item of each group as is and identify rest as duplicate files to delete
            ToDelete.AddRange(similarList.SelectMany(f => f.Files.Skip(1)).ToList());
            Console.WriteLine("List of duplicate files - {0}", ToDelete.Count);
            //list all files to be deleted and count total disk space to be empty after delete
            if (ToDelete.Count > 0)
            {
                Console.WriteLine("Files to be deleted - ");
                foreach (var item in ToDelete)
                {
                    Console.WriteLine(item);
                    FileInfo fi = new FileInfo(item);
                    totalSize += fi.Length;
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Total space free up by -  {0}mb", Math.Round((totalSize / 1000000), 6).ToString());
            Console.ForegroundColor = ConsoleColor.White;
            //delete duplicate files
            if (ToDelete.Count > 0)
            {
                Console.WriteLine("To confirm press C to delete");
                Console.WriteLine("Press Escape (Esc) key to quit: \n");
                do
                {
                    cki = Console.ReadKey();
                    Console.WriteLine(" --- You pressed {0}\n", cki.Key.ToString());
                    if (cki.Key == ConsoleKey.C)
                    {
                        Console.WriteLine("Deleting files...");
                        ToDelete.ForEach(File.Delete);
                        Console.WriteLine("Files are deleted successfully");
                    }
                    Console.WriteLine("Press the Escape (Esc) key to quit: \n");
                } while (cki.Key != ConsoleKey.Escape);
            }
            else
            {
                Console.WriteLine("No files to delete");
                Console.ReadLine();
            }

        }

    }

}




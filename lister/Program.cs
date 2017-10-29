﻿using System;
using System.IO;
using System.Collections.Generic;

namespace TwoDave.Lister
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @".\data\simple-3-list.txt";

            Console.WriteLine("Importing data from the simple-3-list.txt file in the data directory.");

            try
            {
                string testprint = FileLib.ReadCommandFile(path);

            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Could not find: {0}", e.FileName);
            }
        }

/*         private static void DisplayList(NodeCollection data)
        {
            //data.PrintList();
            Console.WriteLine("Debugging:");
        } */
    }
}

using System;
using System.IO;
using System.Collections.Generic;

namespace TwoDave.Lister
{
    internal class FileLib
    {
        public static void ReadCommandFile(string path)
        {
            using (StreamReader file = new StreamReader(path))
            {
                string line;

                List<Node> newnodes = new List<Node>();

                while ((line = file.ReadLine()) != null)
                {
                    var temp = line.Split(' ');

                    Node tempnode1 = new Node();
                    Node tempnode2 = new Node();

                    tempnode1.data = temp[0];
                    tempnode2.data = temp[2];

                    string capturecommand = temp[1];

                    if (capturecommand == ">")
                    {
                        tempnode1.next = tempnode2;
                    }
                    else if (capturecommand == "<")
                    {
                        tempnode2.next = tempnode1;
                    }

                    newnodes.Add(tempnode1);
                    newnodes.Add(tempnode2);

                    foreach (Node n in newnodes)
                    {
                        Console.WriteLine("The list of nodes --> {0}", n.data.ToString());
                    }
                }
            }
        }
    }
}
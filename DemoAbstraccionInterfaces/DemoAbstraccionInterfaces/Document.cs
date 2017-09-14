﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAbstraccionInterfaces
{
    public class Document : Printable, Storable
    {
        string DocName { get; set; }
        public void CountCharacters()
        {
            Console.WriteLine("5,426 characters");
        }

        public int Status
        {
            get { return 0; }            
        }

        public void Print()
        {
            Console.WriteLine("Writing document to printer...!");
        }

        public string Read()
        {
            Console.WriteLine("Getting Document from file...");
            return "abc";
        }

        public void Write()
        {
            Console.WriteLine("Writing Document to file...");
        }
    }
}

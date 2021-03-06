﻿using System;
using System.Collections.Generic;
using ConvertDoc.Services;

namespace ConvertDoc
{
    public class Program
    {
        private static List<String> _kind;

        public static void Main(String[] args)
        {
            _kind = new List<String>();
            var service = new JsonSerializationService();
            var filePath = @"D:\Development\GitHub\ldd3\docs.json";
            var result = service.Deserialize<Descriptor>(filePath);
            var mds = new MarkdownExportService();
            mds.Export(result, @"D:\Development\GitHub\ldd3\docs");
            Console.ReadLine();
        }
        
    }
}
using System.Collections.Specialized;
using System;
namespace TextDataAnalyzer;
public class Program{
    private static void Main(string[] args)
    {
        Console.WriteLine("Please, Enter file path ");
        var filePath = Console.ReadLine();
        DirectoryInfo directoryInfo = new DirectoryInfo(filePath);
        if (directoryInfo.Exists == false)
        {
            Console.WriteLine("This file path does not exist.");
            return;
        } 

        var filesNames = directoryInfo.GetFiles();
        IFileAnalysis fileAnalysis = null;
        foreach (var file in filesNames) 
        {
            if (file.isTextFile())
            {
                fileAnalysis = new TxtFileAnalyzer();
                fileAnalysis.analyzeFile(file);
                var result = ((FileAnalyzer)fileAnalysis).getResult();

                Console.WriteLine(" \n \t ---- Text File ---- ");
                Console.WriteLine($"File Name : {file.Name}");
                Console.WriteLine($"\t Word Count : {result.WordCount}");
                Console.WriteLine($"\t Line Count : {result.LineCount}");
            }

            //if (file.isCsvFile())
            //{
            //    fileAnalysis = new CsvFileAnalyzer();
            //    fileAnalysis.analyzeFile(file);
            //    var result = ((FileAnalyzer)fileAnalysis).getResult();

            //    Console.WriteLine(" \n \t ---- CSV File ---- ");
            //    Console.WriteLine($"File Name : {file.Name}");
            //    Console.WriteLine($"\t Field Count : {result.FieldCount}");
            //}
        }
    }
}

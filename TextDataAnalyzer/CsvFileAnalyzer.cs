using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextDataAnalyzer
{
    internal class CsvFileAnalyzer : FileAnalyzer, IFileAnalysis
    {
        public void analyzeFile(FileInfo fileInfo)
        {
            AnalysisResult result = new AnalysisResult();

            string [] fileString = File.ReadAllLines(fileInfo.FullName);
            var rowElements = fileString[0].Split(',');
            result.FieldCount = rowElements.Length;
            setResult(result);
        }
    }
}
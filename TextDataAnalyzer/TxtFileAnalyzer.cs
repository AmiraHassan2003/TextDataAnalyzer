using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextDataAnalyzer
{
    internal class TxtFileAnalyzer : FileAnalyzer, IFileAnalysis
    {
        public void analyzeFile(FileInfo fileInfo)
        {
            AnalysisResult result = new AnalysisResult();

            string file = File.ReadAllText(fileInfo.FullName);
            var words = file.Split(new char[] { ' ', '\n', '\r' });
            result.WordCount = words.Length;
            result.CharacterCount = file.Length;
            var lines = file.Split(new char[] { '\n' });
            result.LineCount = lines.Length;
            setResult(result);
        }
    }
}

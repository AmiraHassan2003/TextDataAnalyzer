using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextDataAnalyzer
{
    internal class FileAnalyzer
    {
        private AnalysisResult _Result;
        public FileAnalyzer()
        {
            
        }
        public void setResult(AnalysisResult Result)
        {
            _Result = Result;
        }
        public AnalysisResult getResult() 
        {
            return _Result;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextDataAnalyzer
{
    internal interface IFileAnalysis
    {
        public void analyzeFile(FileInfo fileInfo);   
    }
}

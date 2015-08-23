using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Earth
{
    public class FunctionInfo
    {
        public string FunctionName { get; private set; }
        public int CodonsEncodingForFunctionsWithThisFunctionName { get; private set; }

        public FunctionInfo(string functionName, int codonsEncodingForFunctionsWithThisFunctionName)
        {
            this.FunctionName = functionName;
            this.CodonsEncodingForFunctionsWithThisFunctionName = codonsEncodingForFunctionsWithThisFunctionName;
        }
    }
}

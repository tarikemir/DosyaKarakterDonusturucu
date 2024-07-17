using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeparatorTransformer.Winform.Helper
{
    public class InterpretEscapeSequences
    {
        public static string Interpret(string text)
        {
            return text
                .Replace("\\t", "\t")
                .Replace("\\n", "\n")
                .Replace("\\r", "\r")
                .Replace("\\\\", "\\"); // This should be last
        }
    }
}

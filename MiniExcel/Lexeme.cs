using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniExcel
{
    enum LexemeType { CellReference, Number, Operation, Text}
    class Lexeme
    {
        public LexemeType Type { get; set; }
        public string LexemeString { get; set; }

        public Lexeme(LexemeType type, string lexemeString)
        {
            Type = type;
            LexemeString = lexemeString;
        }
    }
}

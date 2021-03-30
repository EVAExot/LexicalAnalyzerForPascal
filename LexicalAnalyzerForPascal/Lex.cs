using System;
using System.Collections.Generic;
using System.Text;

namespace LexicalAnalyzerForPascal
{
    class Lex
    {
        public int id;
        public int lex;
        public string val;

        public Lex(int _id, int _lex, string _val)
        {
            id = _id;
            lex = _lex;
            val = _val;
        }
    }
}

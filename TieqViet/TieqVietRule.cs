using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TieqViet
{
    class TieqVietRule
    {
        private string rule;
        private string result;

        public TieqVietRule()
        {
        }

        public TieqVietRule(string rule, string result)
        {
            Rule = rule;
            Result = result;
        }

        public string Rule { get => rule; set => rule = value; }
        public string Result { get => result; set => result = value; }
    }
}

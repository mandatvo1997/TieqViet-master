using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace TieqViet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<TieqVietRule> tieqVietRules;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbInput_KeyDown(object sender, KeyEventArgs e)
        {
            tbOutput.Text = Translate(tbInput.Text);
        }
        public string Translate(string input)
        {
            string result = input;
            foreach(TieqVietRule tv in tieqVietRules)
            {
                result = Regex.Replace(result, tv.Rule, tv.Result);
            }
            return result;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tieqVietRules = new List<TieqVietRule>();
            tieqVietRules.Add(new TieqVietRule("k(h|H)", "x"));
            tieqVietRules.Add(new TieqVietRule("K(h|H)", "X"));
            tieqVietRules.Add(new TieqVietRule("c(?!(h|H))|q", "k"));
            tieqVietRules.Add(new TieqVietRule("C(?!(h|H))|Q", "K"));
            tieqVietRules.Add(new TieqVietRule("t(r|R)|c(h|H)", "c"));
            tieqVietRules.Add(new TieqVietRule("T(r|R)|C(h|H)", "C"));
            tieqVietRules.Add(new TieqVietRule("d|g(i|I)|r", "z"));
            tieqVietRules.Add(new TieqVietRule("D|G(i|I)|R", "Z"));
            tieqVietRules.Add(new TieqVietRule("g(i|ì|í|ỉ|ĩ|ị|I|Ì|Í|Ỉ|Ĩ|Ị)", "z$1"));
            tieqVietRules.Add(new TieqVietRule("G(i|ì|í|ỉ|ĩ|ị|I|Ì|Í|Ỉ|Ĩ|Ị)", "Z$1"));
            tieqVietRules.Add(new TieqVietRule("đ", "d"));
            tieqVietRules.Add(new TieqVietRule("Đ", "d"));
            tieqVietRules.Add(new TieqVietRule("p(h|H)", "f"));
            tieqVietRules.Add(new TieqVietRule("P(h|H)", "F"));
            tieqVietRules.Add(new TieqVietRule("n(g|G)(h|H)?", "q"));
            tieqVietRules.Add(new TieqVietRule("N(g|G)(h|H)?", "Q"));
            tieqVietRules.Add(new TieqVietRule("(g|G)(h|H)", "$1"));
            tieqVietRules.Add(new TieqVietRule("t(h|H)", "w"));
            tieqVietRules.Add(new TieqVietRule("T(h|H)", "W"));
            tieqVietRules.Add(new TieqVietRule("(n|N)(h|H)", "$1\'"));
        }
    }
}

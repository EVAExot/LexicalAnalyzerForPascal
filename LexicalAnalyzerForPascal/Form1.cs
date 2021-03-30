using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LexicalAnalyzerForPascal
{
    public partial class Form1 : Form
    {
        static public (object, int, int, int, int) Analyze(string str)
        {
            var result = new StringBuilder();
            int count_sw = 0;
            int count_dlm = 0;
            int count_num = 0;
            int count_idr = 0;

            Lexic tpl = new Lexic();
            tpl.Analysis(str);

            foreach (var lex in tpl.Lexemes)
            {
                string lexName = null;

                switch (lex.id)
                {
                    case 1:
                        lexName = " служебные слова ";
                        count_sw++;
                        break;
                    case 2:
                        lexName = " ограничители ";
                        count_dlm++;
                        break;
                    case 3:
                        lexName = " числа ";
                        count_num++;
                        break;
                    case 4:
                        lexName = " идентификатор ";
                        count_idr++;
                        break;
                }

                if (lexName != null)
                {
                    result.Append("id: ");
                    result.Append(lex.id);
                    result.Append(" lex: ");
                    result.Append(lex.lex);
                    result.Append(" val: ");
                    result.Append(lex.val);
                    result.Append(" |");
                    result.AppendLine(lexName);
                }
            }

            return (result, count_sw, count_dlm, count_num, count_idr);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();

            (object, int, int, int, int) res = Analyze(textBox1.Text);

            textBox2.Text = res.Item1.ToString() + Environment.NewLine +
                "Служебных слов: " + res.Item2.ToString() + Environment.NewLine +
                "Ограничителей: " + res.Item3.ToString() + Environment.NewLine +
                "Чисел: " + res.Item4.ToString() + Environment.NewLine +
                "Идентификаторов: " + res.Item5.ToString();
        }
    }
}

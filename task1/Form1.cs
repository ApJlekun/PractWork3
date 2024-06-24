using System;
using System.IO;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void create_Click(object sender, EventArgs e)
        {
            var doc = new Word.Application();
            var document = doc.Documents.Add(Path.Combine(Environment.CurrentDirectory, @"C:\temp\ispp21\Шаблон.docx"));
            doc.Visible = true;

            var range = document.Paragraphs[5].Range;
            range.Text = textBox.Text;

            for (int i = 0; i < numericUpDown.Value-1; i++)
            {
                document.Tables[1].Rows.Add(document.Tables[1].Rows[i + 2]);

                range = document.Tables[1].Cell(i + 2, 1).Range;
                range.Text = (i + 1).ToString();
            }

            document.Content.Find.Execute(FindText: "дд.ММ.гггг", ReplaceWith: DateTime.Now, Replace: Word.WdReplace.wdReplaceAll);
        }
    }
}

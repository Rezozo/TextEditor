using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class EditTextForm : Form
    {
        public EditTextForm()
        {
            InitializeComponent();
        }

        private void openStripBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog()
            {
                Filter = "Текстовые файлы (*.txt)|*.txt"
            };

            if (dialog.ShowDialog() == DialogResult.OK && File.Exists(dialog.FileName))
            {
                textArea.LoadFile(dialog.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void saveStripBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog()
            {
                InitialDirectory = Environment.CurrentDirectory,
                Filter = "Текстовые файлы(.txt) |.txt",
                RestoreDirectory = false
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                textArea.SaveFile(sfd.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void copyStripBtn_Click(object sender, EventArgs e)
        {
            if (textArea.SelectedText.Length > 0)
            {
                textArea.Copy();
            }
            else
            {
                MessageBox.Show("Выделите текст для копирования");
            }
        }

        private void insertStripBtn_Click(object sender, EventArgs e)
        {
            try
            {
                textArea.Paste();
            } catch
            {
                MessageBox.Show("Вставка данных такого формата недоступна");
            }
        }

        private void searchStripBtn_Click(object sender, EventArgs e)
        {
            textArea.SelectAll();
            textArea.SelectionBackColor = textArea.BackColor;

            Regex regex = new Regex(Regex.Escape(searchTxt.Text), RegexOptions.IgnoreCase);

            MatchCollection matches = regex.Matches(textArea.Text);

            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                {
                    textArea.SelectionStart = match.Index;
                    textArea.SelectionLength = match.Length;
                    textArea.SelectionBackColor = Color.Yellow;
                }
            }
            else
            {
                MessageBox.Show("Текст не найден");
            }
        }

        private void replaceBtn_Click(object sender, EventArgs e)
        {
            if (replaceTxt1.Text == "" || replaceTxt2.Text == "")
            {
                MessageBox.Show("Укажите все обязательные поля для замены");
                return;
            }

            textArea.Text = textArea.Text.Replace(replaceTxt1.Text, replaceTxt2.Text);
        }

        private void formatStripBtn_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();

            if (fd.ShowDialog() == DialogResult.OK)
            {
                if (textArea.SelectedText.Length > 0)
                {
                    textArea.SelectionFont = fd.Font;
                }
                else
                {
                    textArea.Font = fd.Font;
                }
            }
        }

        private void boldStripBtn_Click(object sender, EventArgs e)
        {
            if (textArea.SelectionFont != null)
            {
                FontStyle currentStyle = textArea.SelectionFont.Style;
                FontStyle newStyle = currentStyle ^ FontStyle.Bold;
                textArea.SelectionFont = new Font(textArea.SelectionFont, newStyle);
            }
        }

        private void italicStripBtn_Click(object sender, EventArgs e)
        {
            if (textArea.SelectionFont != null)
            {
                FontStyle currentStyle = textArea.SelectionFont.Style;
                FontStyle newStyle = currentStyle ^ FontStyle.Italic;
                textArea.SelectionFont = new Font(textArea.SelectionFont, newStyle);
            }
        }

        private void crossStripBtn_Click(object sender, EventArgs e)
        {
            if (textArea.SelectionFont != null)
            {
                FontStyle currentStyle = textArea.SelectionFont.Style;
                FontStyle newStyle = currentStyle ^ FontStyle.Strikeout;
                textArea.SelectionFont = new Font(textArea.SelectionFont, newStyle);
            }
        }

        private void underlineStripBtn_Click(object sender, EventArgs e)
        {
            if (textArea.SelectionFont != null)
            {
                FontStyle currentStyle = textArea.SelectionFont.Style;
                FontStyle newStyle = currentStyle ^ FontStyle.Underline;
                textArea.SelectionFont = new Font(textArea.SelectionFont, newStyle);
            }
        }

        private Dictionary<string, string[]> selectedLanguage;
        private string[] kotlinKeywords = { "fun", "val", "var", "class", "if", "else", "for", "while", "return", "when", "is", "in", "true", "false", "null", "this", "super", "try", "catch", "finally", "throw", "interface", "object", "package", "as", "break", "continue", "do", "typeof", "when", "dynamic", "typeof", "typeof", "by", "field", "property", "constructor", "delegate", "event", "operator", "params", "unchecked" };
        private string[] javaKeywords = { "public", "private", "protected", "class", "void", "int", "if", "else", "for", "while", "return", "try", "catch", "finally", "throw", "throws", "true", "false", "null", "this", "super", "new", "instanceof", "static", "final", "abstract", "synchronized", "volatile", "transient", "implements", "extends", "interface", "enum", "strictfp", "assert", "byte", "short", "long", "double", "float", "char", "boolean", "default", "switch" };
        private string[] csharpKeywords = { "public", "private", "protected", "class", "void", "int", "if", "else", "for", "while", "return", "try", "catch", "finally", "throw", "true", "false", "null", "this", "base", "namespace", "using", "bool", "byte", "sbyte", "short", "ushort", "int", "uint", "long", "ulong", "float", "double", "decimal", "string", "object", "dynamic", "var", "const", "readonly", "delegate", "event", "enum", "struct" };
        private string[] goKeywords = { "func", "var", "const", "package", "import", "if", "else", "for", "return", "switch", "case", "defer", "true", "false", "nil", "chan", "interface", "map", "range", "select", "type", "break", "continue", "goto", "fallthrough", "default", "struct", "select", "const", "true", "false", "nil", "int", "int8", "int16", "int32", "int64", "uint", "uint8", "uint16", "uint32", "uint64", "float32", "float64", "complex64", "complex128", "base32", "base64" };

        private void EditTextForm_Load(object sender, EventArgs e)
        {
            selectedLanguage = new Dictionary<string, string[]>
            {
                {"Kotlin",  kotlinKeywords},
                {"Java", javaKeywords },
                {"C#", csharpKeywords },
                {"Golang", goKeywords },
            };

            langComboBox.Items.Add("Без подсветки");
            langComboBox.Items.AddRange(selectedLanguage.Keys.ToArray());
            langComboBox.SelectedIndex = 0;
        }

        private void langComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            textArea.SelectAll();
            textArea.SelectionColor = textArea.ForeColor;
            ShowSyntax();
        }

        private void textArea_TextChanged(object sender, EventArgs e)
        {
            ShowSyntax();
        }

        private void ShowSyntax()
        {
            string currentLang = langComboBox.SelectedItem.ToString();
            if (currentLang != "Без подсветки")
            {
                string[] keywords = selectedLanguage[currentLang];

                foreach (string keyword in keywords)
                {
                    CheckByKeyword(keyword, Color.Blue);
                }
            }
        }

        private void CheckByKeyword(string keyword, Color color)
        {
            Regex regex = new Regex(Regex.Escape(keyword), RegexOptions.IgnoreCase);
            MatchCollection matches = regex.Matches(textArea.Text);

            int currentStart = textArea.SelectionStart;
            int currentLength = textArea.SelectionLength;
            Color currentColor = textArea.SelectionColor;

            foreach (Match match in matches)
            {
                textArea.SelectionStart = match.Index;
                textArea.SelectionLength = match.Length;
                textArea.SelectionColor = color;
            }

            textArea.SelectionStart = currentStart;
            textArea.SelectionLength = currentLength;
            textArea.SelectionColor = currentColor;
        }

    }
}

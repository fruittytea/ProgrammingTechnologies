using System.Security.Cryptography;
using System.Threading.Channels;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Word = Microsoft.Office.Interop.Word;

namespace Task4_TextEditor
{
    public partial class TextEditor : Form
    {
        public TextEditor()
        {
            InitializeComponent();
            SavingChanges = true;
        }

        public bool SavingChanges;
        public string FilePath;

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextArea.Text) && SavingChanges == false)
            {
                DialogResult result = MessageBox.Show("Вы уверены, что хотите открыть новый файл? Изменения в текущем файле не сохранятся", "Открытие файла", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.No || result == DialogResult.Cancel)
                {
                    return;
                }
            }
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Выберите файл для чтения и редактирования";
                ofd.InitialDirectory = "c:\\"; //начальная директория для обзора файлов
                ofd.Filter = "Все файлы (*.*)|*.*|Текстовые файлы (*.txt, *.doc, *.docx)|*.txt; *.doc; *.docx";
                ofd.RestoreDirectory = true;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FilePath = ofd.FileName;
                    string FileText = System.IO.File.ReadAllText(FilePath);
                    this.Text = FilePath;
                    TextArea.Text = FileText;

                    TextArea.BackColor = SystemColors.Window;
                    TextArea.Font = this.Font;
                    TextArea.ForeColor = SystemColors.WindowText;

                    SavingChanges = true;
                }
            }
        }

        private void ExidFileButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextArea.Text) && SavingChanges == false)
            {
                DialogResult result = MessageBox.Show("Вы уверены, что хотите закрыть файл? Изменения в текущем файле не сохранятся", "Закрытие файла", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.No || result == DialogResult.Cancel)
                {
                    return;
                }
            }
            this.Text = "Текстовый редактор";
            TextArea.Text = "";
            TextArea.BackColor = SystemColors.Window;
            TextArea.Font = this.Font;
            TextArea.ForeColor = SystemColors.WindowText;
        }

        private void TextArea_KeyPress(object sender, KeyPressEventArgs e)
        {
            ChangeCheckFunction();
        }

        private void SaveFileButton_Click(object sender, EventArgs e)
        {
            string SaveType = "Save";
            SaveChangesAction(SaveType);
        }

        private void SaveAsButton_Click(object sender, EventArgs e)
        {
            string SaveType = "SaveAs";
            SaveChangesAction(SaveType);
        }

        public void SaveChangesAction(string SaveType)
        {
            if (this.Text == "Текстовый редактор")
            {
                MessageBox.Show("Откройте файл для редактирования или создайте новый путем ввода текста", "Сохранение файла", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (!this.Text.EndsWith("*") && SaveType == "Save")
                {
                    MessageBox.Show("Изменений для сохранения нет", "Сохранение файла", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                DialogResult result = MessageBox.Show("Вы уверены, что хотите сохранить изменения?", "Сохранение файла", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (SaveFileDialog sfd = new SaveFileDialog())
                    {
                        if (string.IsNullOrEmpty(FilePath) || SaveType == "SaveAs")
                        {
                            sfd.Title = "Выберите расположение для файла";
                            sfd.InitialDirectory = "c:\\";
                            sfd.Filter = "Все файлы (*.*)|*.*|Файл формата .txt|*.txt|Файл формата .doc|*.doc|Файл формата .docx|*.docx";
                            sfd.FileName = "Новый документ.txt";
                            sfd.RestoreDirectory = true;

                            if (sfd.ShowDialog() == DialogResult.OK)
                            {
                                FilePath = sfd.FileName;
                                System.IO.File.WriteAllText(FilePath, TextArea.Text);
                                MessageBox.Show("Изменения сохранены", "Сохранение файла", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                SavingChanges = true;
                                this.Text = FilePath;
                            }
                        }
                        else
                        {
                            System.IO.File.WriteAllText(FilePath, TextArea.Text);
                            MessageBox.Show("Изменения сохранены", "Сохранение файла", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            SavingChanges = true;
                            this.Text = FilePath;
                        }
                    }
                }
                else if (result == DialogResult.No || result == DialogResult.Cancel)
                {
                    return;
                }
            }

        }

        private void BackgroundColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                TextArea.BackColor = color.Color;
                ChangeCheckFunction();
            }
        }

        private void TextColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                TextArea.ForeColor = color.Color;
                ChangeCheckFunction();
            }
        }

        private void FontButton_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            if(font.ShowDialog() == DialogResult.OK)
            {
                TextArea.Font = font.Font;
                ChangeCheckFunction();
            }
        }

        public void ChangeCheckFunction()
        {
            if (this.Text == "Текстовый редактор")
            {
                this.Text = "Новый документ";
            }
            if (!this.Text.EndsWith("*"))
            {
                this.Text += " *";
                SavingChanges = false;
            }
        }
    }
}

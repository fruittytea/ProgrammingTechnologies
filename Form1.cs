using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
                ofd.Filter = "Все файлы (*.*)|*.*|Файлы *.txt|*.txt |Файлы *.doc|*.doc|Файлы *.docx|*.docx";
                ofd.RestoreDirectory = true;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FilePath = ofd.FileName;
                    string FileText = System.IO.File.ReadAllText(FilePath);
                    this.Text = FilePath;
                    TextArea.Text = FileText;
                    SavingChanges = true;
                }
            }
        }

        private void ExidFileButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextArea.Text) && SavingChanges == false)
            {
                DialogResult result = MessageBox.Show("Вы уверены, что хотите закрыть файл? Изменения в текущем файле не сохранятся", "Открытие файла", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.No || result == DialogResult.Cancel)
                {
                    return;
                }
            }
            this.Text = "Текстовый редактор";
            TextArea.Text = "";
        }

        private void TextArea_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(this.Text == "Текстовый редактор")
            {
                this.Text = "Новый документ";
            }
            if(!this.Text.EndsWith("*"))
            {
                this.Text += " *";
                SavingChanges = false;
            }
        }
    }
}

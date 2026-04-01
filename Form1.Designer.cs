namespace Task4_TextEditor
{
    partial class TextEditor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            ActionsMenu = new MenuStrip();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            OpenFileButton = new ToolStripMenuItem();
            SaveButton = new ToolStripMenuItem();
            SaveFileButton = new ToolStripMenuItem();
            SaveAsButton = new ToolStripMenuItem();
            AppearanceButton = new ToolStripMenuItem();
            fontDialog1 = new FontDialog();
            colorDialog1 = new ColorDialog();
            ActionsMenu.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // ActionsMenu
            // 
            ActionsMenu.Items.AddRange(new ToolStripItem[] { открытьToolStripMenuItem, AppearanceButton });
            ActionsMenu.Location = new Point(0, 0);
            ActionsMenu.Name = "ActionsMenu";
            ActionsMenu.Size = new Size(800, 24);
            ActionsMenu.TabIndex = 1;
            ActionsMenu.Text = "menuStrip1";
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { OpenFileButton, SaveButton });
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.Size = new Size(48, 20);
            открытьToolStripMenuItem.Text = "Файл";
            // 
            // OpenFileButton
            // 
            OpenFileButton.Name = "OpenFileButton";
            OpenFileButton.Size = new Size(142, 22);
            OpenFileButton.Text = "Открыть";
            // 
            // SaveButton
            // 
            SaveButton.DropDownItems.AddRange(new ToolStripItem[] { SaveFileButton, SaveAsButton });
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(142, 22);
            SaveButton.Text = "Сохранить...";
            // 
            // SaveFileButton
            // 
            SaveFileButton.Name = "SaveFileButton";
            SaveFileButton.Size = new Size(154, 22);
            SaveFileButton.Text = "Сохранить";
            // 
            // SaveAsButton
            // 
            SaveAsButton.Name = "SaveAsButton";
            SaveAsButton.Size = new Size(154, 22);
            SaveAsButton.Text = "Сохранить как";
            // 
            // AppearanceButton
            // 
            AppearanceButton.Name = "AppearanceButton";
            AppearanceButton.Size = new Size(39, 20);
            AppearanceButton.Text = "Вид";
            // 
            // TextEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ActionsMenu);
            MainMenuStrip = ActionsMenu;
            Name = "TextEditor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Текстовый редактор";
            ActionsMenu.ResumeLayout(false);
            ActionsMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private MenuStrip ActionsMenu;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripMenuItem OpenFileButton;
        private ToolStripMenuItem SaveButton;
        private ToolStripMenuItem SaveFileButton;
        private ToolStripMenuItem SaveAsButton;
        private ToolStripMenuItem AppearanceButton;
        private FontDialog fontDialog1;
        private ColorDialog colorDialog1;
    }
}

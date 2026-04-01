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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextEditor));
            OpenFileDialog = new OpenFileDialog();
            SaveFileDialog = new SaveFileDialog();
            ActionsMenu = new MenuStrip();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            OpenFileButton = new ToolStripMenuItem();
            SaveButton = new ToolStripMenuItem();
            SaveFileButton = new ToolStripMenuItem();
            SaveAsButton = new ToolStripMenuItem();
            AppearanceButton = new ToolStripMenuItem();
            FontDialog = new FontDialog();
            ColorDialog = new ColorDialog();
            TextArea = new RichTextBox();
            ExidFileButton = new ToolStripMenuItem();
            ActionsMenu.SuspendLayout();
            SuspendLayout();
            // 
            // OpenFileDialog
            // 
            OpenFileDialog.FileName = "openFileDialog1";
            // 
            // ActionsMenu
            // 
            ActionsMenu.BackColor = Color.Silver;
            ActionsMenu.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ActionsMenu.Items.AddRange(new ToolStripItem[] { открытьToolStripMenuItem, AppearanceButton });
            ActionsMenu.Location = new Point(0, 0);
            ActionsMenu.Name = "ActionsMenu";
            ActionsMenu.Size = new Size(984, 34);
            ActionsMenu.TabIndex = 1;
            ActionsMenu.Text = "menuStrip1";
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { OpenFileButton, SaveButton, ExidFileButton });
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.Padding = new Padding(10, 3, 10, 3);
            открытьToolStripMenuItem.Size = new Size(69, 30);
            открытьToolStripMenuItem.Text = "Файл";
            // 
            // OpenFileButton
            // 
            OpenFileButton.Name = "OpenFileButton";
            OpenFileButton.Size = new Size(180, 24);
            OpenFileButton.Text = "Открыть";
            OpenFileButton.Click += OpenFileButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.DropDownItems.AddRange(new ToolStripItem[] { SaveFileButton, SaveAsButton });
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(180, 24);
            SaveButton.Text = "Сохранить...";
            // 
            // SaveFileButton
            // 
            SaveFileButton.Name = "SaveFileButton";
            SaveFileButton.Size = new Size(178, 24);
            SaveFileButton.Text = "Сохранить";
            // 
            // SaveAsButton
            // 
            SaveAsButton.Name = "SaveAsButton";
            SaveAsButton.Size = new Size(178, 24);
            SaveAsButton.Text = "Сохранить как";
            // 
            // AppearanceButton
            // 
            AppearanceButton.Name = "AppearanceButton";
            AppearanceButton.Padding = new Padding(10, 3, 10, 3);
            AppearanceButton.Size = new Size(59, 30);
            AppearanceButton.Text = "Вид";
            // 
            // TextArea
            // 
            TextArea.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TextArea.BorderStyle = BorderStyle.None;
            TextArea.Cursor = Cursors.IBeam;
            TextArea.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TextArea.Location = new Point(0, 37);
            TextArea.Margin = new Padding(20, 100, 20, 100);
            TextArea.Name = "TextArea";
            TextArea.Size = new Size(984, 524);
            TextArea.TabIndex = 1;
            TextArea.Text = "";
            // 
            // ExidFileButton
            // 
            ExidFileButton.Name = "ExidFileButton";
            ExidFileButton.Size = new Size(180, 24);
            ExidFileButton.Text = "Закрыть файл";
            ExidFileButton.Click += ExidFileButton_Click;
            // 
            // TextEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(TextArea);
            Controls.Add(ActionsMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
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

        private OpenFileDialog OpenFileDialog;
        private SaveFileDialog SaveFileDialog;
        private MenuStrip ActionsMenu;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripMenuItem OpenFileButton;
        private ToolStripMenuItem SaveButton;
        private ToolStripMenuItem SaveFileButton;
        private ToolStripMenuItem SaveAsButton;
        private ToolStripMenuItem AppearanceButton;
        private FontDialog FontDialog;
        private ColorDialog ColorDialog;
        private RichTextBox TextArea;
        private ToolStripMenuItem ExidFileButton;
    }
}

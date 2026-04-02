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
            ExidFileButton = new ToolStripMenuItem();
            AppearanceButton = new ToolStripMenuItem();
            BackgroundColorButton = new ToolStripMenuItem();
            TextColorButton = new ToolStripMenuItem();
            FontButton = new ToolStripMenuItem();
            FontDialog = new FontDialog();
            ColorDialog = new ColorDialog();
            TextArea = new RichTextBox();
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
            ActionsMenu.Padding = new Padding(7, 3, 0, 3);
            ActionsMenu.Size = new Size(1125, 36);
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
            SaveFileButton.Click += SaveFileButton_Click;
            // 
            // SaveAsButton
            // 
            SaveAsButton.Name = "SaveAsButton";
            SaveAsButton.Size = new Size(178, 24);
            SaveAsButton.Text = "Сохранить как";
            SaveAsButton.Click += SaveAsButton_Click;
            // 
            // ExidFileButton
            // 
            ExidFileButton.Name = "ExidFileButton";
            ExidFileButton.Size = new Size(180, 24);
            ExidFileButton.Text = "Закрыть файл";
            ExidFileButton.Click += ExidFileButton_Click;
            // 
            // AppearanceButton
            // 
            AppearanceButton.DropDownItems.AddRange(new ToolStripItem[] { BackgroundColorButton, TextColorButton, FontButton });
            AppearanceButton.Name = "AppearanceButton";
            AppearanceButton.Padding = new Padding(10, 3, 10, 3);
            AppearanceButton.Size = new Size(59, 30);
            AppearanceButton.Text = "Вид";
            // 
            // BackgroundColorButton
            // 
            BackgroundColorButton.Name = "BackgroundColorButton";
            BackgroundColorButton.Size = new Size(180, 24);
            BackgroundColorButton.Text = "Цвет фона";
            BackgroundColorButton.Click += BackgroundColorButton_Click;
            // 
            // TextColorButton
            // 
            TextColorButton.Name = "TextColorButton";
            TextColorButton.Size = new Size(180, 24);
            TextColorButton.Text = "Цвет текста";
            TextColorButton.Click += TextColorButton_Click;
            // 
            // FontButton
            // 
            FontButton.Name = "FontButton";
            FontButton.Size = new Size(180, 24);
            FontButton.Text = "Шрифт";
            FontButton.Click += FontButton_Click;
            // 
            // TextArea
            // 
            TextArea.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TextArea.BorderStyle = BorderStyle.None;
            TextArea.Cursor = Cursors.IBeam;
            TextArea.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TextArea.Location = new Point(0, 49);
            TextArea.Margin = new Padding(23, 133, 23, 133);
            TextArea.Name = "TextArea";
            TextArea.Size = new Size(1125, 699);
            TextArea.TabIndex = 1;
            TextArea.Text = "";
            TextArea.KeyPress += TextArea_KeyPress;
            // 
            // TextEditor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 748);
            Controls.Add(TextArea);
            Controls.Add(ActionsMenu);
            Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = ActionsMenu;
            Margin = new Padding(3, 4, 3, 4);
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
        private ToolStripMenuItem BackgroundColorButton;
        private ToolStripMenuItem TextColorButton;
        private ToolStripMenuItem FontButton;
    }
}
